using QuanLyDiemHocTap.BUS;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace QuanLyDiemHocTap.GUI
{
    public partial class frmXemDiem : Form
    {
        public frmXemDiem()
        {
            InitializeComponent();
            this.Load += FrmXemDiem_Load;
        }

        private void FrmXemDiem_Load(object sender, EventArgs e)
        {
            LoadComboBoxes();
        }

        private void LoadComboBoxes()
        {
            try
            {
                DataTable dtNamHoc = NamHocBUS.GetAllNamHoc();
                cboNamHoc.DataSource = dtNamHoc;
                cboNamHoc.DisplayMember = "TenNamHoc";
                cboNamHoc.ValueMember = "MaNamHoc";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void cboNamHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboNamHoc.SelectedValue != null)
            {
                try
                {
                    int maNamHoc = Convert.ToInt32(cboNamHoc.SelectedValue);
                    DataTable dtHocKy = HocKyBUS.GetHocKyByNamHoc(maNamHoc);
                    cboHocKy.DataSource = dtHocKy;
                    cboHocKy.DisplayMember = "TenHocKy";
                    cboHocKy.ValueMember = "MaHocKy";
                }
                catch { }
            }
        }

        private void cboHocKy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboHocKy.SelectedValue != null)
            {
                try
                {
                    DataTable dtLop = LopBUS.GetAllLop();
                    cboLop.DataSource = dtLop;
                    cboLop.DisplayMember = "TenLop";
                    cboLop.ValueMember = "MaLop";
                }
                catch { }
            }
        }

        private void cboLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboLop.SelectedValue != null && cboHocKy.SelectedValue != null)
            {
                try
                {
                    int maLop = Convert.ToInt32(cboLop.SelectedValue);
                    int maHocKy = Convert.ToInt32(cboHocKy.SelectedValue);

                    DataTable dtHS = HocSinhBUS.GetHocSinhByLop(maLop, maHocKy);
                    cboHocSinh.DataSource = dtHS;
                    cboHocSinh.DisplayMember = "HoTen";
                    cboHocSinh.ValueMember = "MaHS";
                }
                catch { }
            }
        }

        private void btnXemDiem_Click(object sender, EventArgs e)
        {
            if (cboHocSinh.SelectedValue == null || cboHocKy.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn đầy đủ thông tin!");
                return;
            }

            try
            {
                int maHS = Convert.ToInt32(cboHocSinh.SelectedValue);
                int maHocKy = Convert.ToInt32(cboHocKy.SelectedValue);

                // Hiển thị điểm chi tiết
                DataTable dtDiem = DiemBUS.GetDiemByHocSinh(maHS, maHocKy);
                dgvDiem.DataSource = dtDiem;

                if (dgvDiem.Columns.Count > 0)
                {
                    dgvDiem.Columns["MaDiem"].Visible = false;
                    dgvDiem.Columns["MaHS"].Visible = false;
                    dgvDiem.Columns["MaMonHoc"].Visible = false;
                    dgvDiem.Columns["MaHocKy"].Visible = false;
                    dgvDiem.Columns["MaLoaiDiem"].Visible = false;
                    dgvDiem.Columns["TenMonHoc"].HeaderText = "Môn học";
                    dgvDiem.Columns["TenLoaiDiem"].HeaderText = "Loại điểm";
                    dgvDiem.Columns["DiemSo"].HeaderText = "Điểm";
                    dgvDiem.Columns["HeSo"].HeaderText = "Hệ số";
                    dgvDiem.Columns["NgayNhap"].HeaderText = "Ngày nhập";
                    dgvDiem.Columns["GhiChu"].HeaderText = "Ghi chú";
                }

                // Tính và hiển thị điểm trung bình các môn
                TinhDiemTrungBinhCacMon(maHS, maHocKy);

                // Hiển thị kết quả tổng kết
                HienThiKetQuaTongKet(maHS, maHocKy);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void TinhDiemTrungBinhCacMon(int maHS, int maHocKy)
        {
            try
            {
                DataTable dtMonHoc = MonHocBUS.GetAllMonHoc();
                DataTable dtKetQua = new DataTable();
                dtKetQua.Columns.Add("MonHoc", typeof(string));
                dtKetQua.Columns.Add("DiemTB", typeof(decimal));

                foreach (DataRow row in dtMonHoc.Rows)
                {
                    int maMonHoc = Convert.ToInt32(row["MaMonHoc"]);
                    decimal diemTB = DiemBUS.TinhDiemTrungBinhMon(maHS, maMonHoc, maHocKy);

                    if (diemTB > 0)
                    {
                        DataRow newRow = dtKetQua.NewRow();
                        newRow["MonHoc"] = row["TenMonHoc"];
                        newRow["DiemTB"] = diemTB;
                        dtKetQua.Rows.Add(newRow);
                    }
                }

                dgvDiemTB.DataSource = dtKetQua;

                if (dgvDiemTB.Columns.Count > 0)
                {
                    dgvDiemTB.Columns["MonHoc"].HeaderText = "Môn học";
                    dgvDiemTB.Columns["DiemTB"].HeaderText = "Điểm TB";
                    dgvDiemTB.Columns["DiemTB"].DefaultCellStyle.Format = "N2";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tính điểm TB: " + ex.Message);
            }
        }

        private void HienThiKetQuaTongKet(int maHS, int maHocKy)
        {
            try
            {
                decimal diemTBHK = KetQuaHocTapBUS.TinhDiemTrungBinhHocKy(maHS, maHocKy);

                DataTable dtKetQua = KetQuaHocTapBUS.GetKetQuaByHocSinh(maHS, maHocKy);

                if (dtKetQua.Rows.Count > 0)
                {
                    DataRow row = dtKetQua.Rows[0];
                    lblDiemTBHK.Text = $"Điểm TB học kỳ: {diemTBHK:N2}";
                    lblHanhKiem.Text = $"Hạnh kiểm: {row["TenHanhKiem"]}";
                    lblXepLoai.Text = $"Xếp loại: {row["TenXepLoai"]}";
                }
                else
                {
                    lblDiemTBHK.Text = $"Điểm TB học kỳ: {diemTBHK:N2}";
                    lblHanhKiem.Text = "Hạnh kiểm: Chưa đánh giá";
                    lblXepLoai.Text = "Xếp loại: Chưa xếp loại";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hiển thị kết quả: " + ex.Message);
            }
        }
    }
}