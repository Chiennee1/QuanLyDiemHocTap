using QuanLyDiemHocTap.BUS;
using QuanLyDiemHocTap.DTO;
using System;
using System.Data;
using System.Windows.Forms;

namespace QuanLyDiemHocTap.GUI
{
    public partial class frmBaoCaoHocSinh : Form
    {
        public frmBaoCaoHocSinh()
        {
            InitializeComponent();
            this.Load += FrmBaoCaoHocSinh_Load;
        }

        private void FrmBaoCaoHocSinh_Load(object sender, EventArgs e)
        {
            LoadHocSinh();
        }

        private void LoadHocSinh()
        {
            try
            {
                DataTable dt = HocSinhBUS.GetAllHocSinh();
                cboHocSinh.DataSource = dt;
                cboHocSinh.DisplayMember = "HoTen";
                cboHocSinh.ValueMember = "MaHS";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnXemBaoCao_Click(object sender, EventArgs e)
        {
            if (cboHocSinh.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn học sinh!");
                return;
            }

            try
            {
                int maHS = Convert.ToInt32(cboHocSinh.SelectedValue);

                // Hiển thị thông tin học sinh
                HocSinhDTO hs = HocSinhBUS.GetHocSinhByMa(maHS);
                if (hs != null)
                {
                    lblThongTinHS.Text = $"Họ tên: {hs.HoTen}\n" +
                                        $"Ngày sinh: {hs.NgaySinh:dd/MM/yyyy}\n" +
                                        $"Giới tính: {hs.GioiTinh}\n" +
                                        $"Địa chỉ: {hs.DiaChi}";
                }

                // Lấy kết quả các học kỳ
                DataTable dtKetQua = new DataTable();
                dtKetQua.Columns.Add("HocKy", typeof(string));
                dtKetQua.Columns.Add("DiemTB", typeof(decimal));
                dtKetQua.Columns.Add("HanhKiem", typeof(string));
                dtKetQua.Columns.Add("XepLoai", typeof(string));

                DataTable dtHocKy = HocKyBUS.GetAllHocKy();
                foreach (DataRow row in dtHocKy.Rows)
                {
                    int maHocKy = Convert.ToInt32(row["MaHocKy"]);
                    DataTable dtKQ = KetQuaHocTapBUS.GetKetQuaByHocSinh(maHS, maHocKy);

                    if (dtKQ.Rows.Count > 0)
                    {
                        DataRow kqRow = dtKetQua.NewRow();
                        kqRow["HocKy"] = row["TenHocKy"];
                        kqRow["DiemTB"] = dtKQ.Rows[0]["DiemTrungBinh"];
                        kqRow["HanhKiem"] = dtKQ.Rows[0]["TenHanhKiem"];
                        kqRow["XepLoai"] = dtKQ.Rows[0]["TenXepLoai"];
                        dtKetQua.Rows.Add(kqRow);
                    }
                }

                dgvKetQua.DataSource = dtKetQua;

                if (dgvKetQua.Columns.Count > 0)
                {
                    dgvKetQua.Columns["HocKy"].HeaderText = "Học kỳ";
                    dgvKetQua.Columns["DiemTB"].HeaderText = "Điểm TB";
                    dgvKetQua.Columns["HanhKiem"].HeaderText = "Hạnh kiểm";
                    dgvKetQua.Columns["XepLoai"].HeaderText = "Xếp loại";
                    dgvKetQua.Columns["DiemTB"].DefaultCellStyle.Format = "N2";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
    }
}