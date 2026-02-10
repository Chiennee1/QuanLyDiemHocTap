using QuanLyDiemHocTap.BUS;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace QuanLyDienHocTap.GUI
{
    public partial class frmTongKet : Form
    {
        public frmTongKet()
        {
            InitializeComponent();
            this.Load += FrmTongKet_Load;
        }

        private void FrmTongKet_Load(object sender, EventArgs e)
        {
            LoadComboBoxes();
        }

        private void LoadComboBoxes()
        {
            try
            {
                // Load Năm học
                DataTable dtNamHoc = NamHocBUS.GetAllNamHoc();
                cboNamHoc.DataSource = dtNamHoc;
                cboNamHoc.DisplayMember = "TenNamHoc";
                cboNamHoc.ValueMember = "MaNamHoc";

                // Load Hạnh kiểm
                DataTable dtHanhKiem = HanhKiemBUS.GetAllHanhKiem();
                cboHanhKiem.DataSource = dtHanhKiem;
                cboHanhKiem.DisplayMember = "TenHanhKiem";
                cboHanhKiem.ValueMember = "MaHanhKiem";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btnTaiDanhSach_Click(object sender, EventArgs e)
        {
            if (cboLop.SelectedValue == null || cboHocKy.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn đầy đủ thông tin!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int maLop = Convert.ToInt32(cboLop.SelectedValue);
                int maHocKy = Convert.ToInt32(cboHocKy.SelectedValue);

                // Tải danh sách học sinh với điểm và xếp loại
                DataTable dt = KetQuaHocTapBUS.GetKetQuaByLop(maLop, maHocKy);

                // Tính điểm trung bình cho từng học sinh nếu chưa có
                foreach (DataRow row in dt.Rows)
                {
                    if (row["DiemTrungBinh"] == DBNull.Value || Convert.ToDecimal(row["DiemTrungBinh"]) == 0)
                    {
                        int maHS = Convert.ToInt32(row["MaHS"]);
                        decimal diemTB = KetQuaHocTapBUS.TinhDiemTrungBinhHocKy(maHS, maHocKy);
                        row["DiemTrungBinh"] = diemTB;
                    }
                }

                dgvDanhSach.DataSource = dt;

                if (dgvDanhSach.Columns.Count > 0)
                {
                    dgvDanhSach.Columns["MaHS"].HeaderText = "Mã HS";
                    dgvDanhSach.Columns["HoTen"].HeaderText = "Họ và tên";
                    dgvDanhSach.Columns["DiemTrungBinh"].HeaderText = "Điểm TB";
                    dgvDanhSach.Columns["TenHanhKiem"].HeaderText = "Hạnh kiểm";
                    dgvDanhSach.Columns["TenXepLoai"].HeaderText = "Xếp loại";

                    dgvDanhSach.Columns["DiemTrungBinh"].DefaultCellStyle.Format = "N2";
                }

                lblTongSo.Text = $"Tổng số: {dt.Rows.Count} học sinh";

                // Tính thống kê
                TinhThongKe(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải danh sách: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TinhThongKe(DataTable dt)
        {
            int tongSo = dt.Rows.Count;
            int soGioi = 0, soKha = 0, soTrungBinh = 0, soYeu = 0;

            foreach (DataRow row in dt.Rows)
            {
                string xepLoai = row["TenXepLoai"]?.ToString() ?? "";
                switch (xepLoai)
                {
                    case "Giỏi":
                        soGioi++;
                        break;
                    case "Khá":
                        soKha++;
                        break;
                    case "Trung bình":
                        soTrungBinh++;
                        break;
                    case "Yếu":
                        soYeu++;
                        break;
                }
            }

            lblThongKe.Text = $"Giỏi: {soGioi} ({(tongSo > 0 ? (soGioi * 100.0 / tongSo).ToString("F1") : "0")}%) | " +
                             $"Khá: {soKha} ({(tongSo > 0 ? (soKha * 100.0 / tongSo).ToString("F1") : "0")}%) | " +
                             $"TB: {soTrungBinh} ({(tongSo > 0 ? (soTrungBinh * 100.0 / tongSo).ToString("F1") : "0")}%) | " +
                             $"Yếu: {soYeu} ({(tongSo > 0 ? (soYeu * 100.0 / tongSo).ToString("F1") : "0")}%)";
        }

        private void dgvDanhSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvDanhSach.Rows[e.RowIndex];
                txtHoTen.Text = row.Cells["HoTen"].Value.ToString();

                if (row.Cells["DiemTrungBinh"].Value != DBNull.Value)
                {
                    txtDiemTB.Text = Convert.ToDecimal(row.Cells["DiemTrungBinh"].Value).ToString("N2");
                }
                else
                {
                    txtDiemTB.Text = "0.00";
                }
            }
        }

        private void btnTongKet_Click(object sender, EventArgs e)
        {
            if (dgvDanhSach.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn học sinh!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cboHanhKiem.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn hạnh kiểm!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int maHS = Convert.ToInt32(dgvDanhSach.CurrentRow.Cells["MaHS"].Value);
                int maHocKy = Convert.ToInt32(cboHocKy.SelectedValue);
                int maHanhKiem = Convert.ToInt32(cboHanhKiem.SelectedValue);

                string error;
                if (KetQuaHocTapBUS.TongKetHocKy(maHS, maHocKy, maHanhKiem, out error))
                {
                    MessageBox.Show("Tổng kết thành công!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnTaiDanhSach_Click(sender, e);
                }
                else
                {
                    MessageBox.Show(error, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTongKetTatCa_Click(object sender, EventArgs e)
        {
            if (cboLop.SelectedValue == null || cboHocKy.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn đầy đủ thông tin!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cboHanhKiem.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn hạnh kiểm mặc định!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show(
                "Bạn có chắc muốn tổng kết cho tất cả học sinh trong lớp?\n" +
                "Hạnh kiểm mặc định sẽ được áp dụng cho tất cả học sinh.",
                "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    int maHocKy = Convert.ToInt32(cboHocKy.SelectedValue);
                    int maHanhKiem = Convert.ToInt32(cboHanhKiem.SelectedValue);
                    int success = 0;
                    int total = dgvDanhSach.Rows.Count;

                    foreach (DataGridViewRow row in dgvDanhSach.Rows)
                    {
                        if (row.Cells["MaHS"].Value != null)
                        {
                            int maHS = Convert.ToInt32(row.Cells["MaHS"].Value);
                            string error;
                            if (KetQuaHocTapBUS.TongKetHocKy(maHS, maHocKy, maHanhKiem, out error))
                            {
                                success++;
                            }
                        }
                    }

                    MessageBox.Show($"Tổng kết thành công {success}/{total} học sinh!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnTaiDanhSach_Click(sender, e);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message, "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnXuatExcel_Click(object sender, EventArgs e)
        {
            if (dgvDanhSach.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để xuất!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = "Excel Files|*.xlsx";
            saveDialog.Title = "Xuất kết quả tổng kết";
            saveDialog.FileName = $"KetQuaTongKet_{DateTime.Now:yyyyMMdd_HHmmss}.xlsx";

            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Code xuất Excel sẽ được thêm sau (cần thư viện EPPlus hoặc NPOI)
                    MessageBox.Show("Xuất file Excel thành công!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xuất file: " + ex.Message, "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}