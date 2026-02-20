using QuanLyDiemHocTap.BUS;
using System;
using System.Data;
using System.Windows.Forms;

namespace QuanLyDiemHocTap.GUI
{
    public partial class frmPhanLop : Form
    {
        private bool isLoading = false;

        public frmPhanLop()
        {
            InitializeComponent();
            this.Load += FrmPhanLop_Load;
        }

        private void FrmPhanLop_Load(object sender, EventArgs e)
        {
            try
            {
                isLoading = true;
                LoadComboBoxes();
                isLoading = false;

                // Load cascade các ComboBox con
                if (cboNamHoc.SelectedValue != null)
                {
                    cboNamHoc_SelectedIndexChanged(null, null);

                    if (cboHocKy.SelectedValue != null)
                    {
                        cboHocKy_SelectedIndexChanged(null, null);
                    }
                }
            }
            catch (Exception ex)
            {
                isLoading = false;
                MessageBox.Show("Lỗi khi tải form: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadComboBoxes()
        {
            try
            {
                DataTable dtNamHoc = NamHocBUS.GetAllNamHoc();
                if (dtNamHoc != null && dtNamHoc.Rows.Count > 0)
                {
                    cboNamHoc.DataSource = dtNamHoc;
                    cboNamHoc.DisplayMember = "TenNamHoc";
                    cboNamHoc.ValueMember = "MaNamHoc";
                }
                else
                {
                    MessageBox.Show("Không có dữ liệu năm học. Vui lòng thêm năm học trước!",
                        "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cboNamHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isLoading) return;

            if (cboNamHoc.SelectedValue != null && cboNamHoc.SelectedValue.GetType() != typeof(DataRowView))
            {
                try
                {
                    int maNamHoc = Convert.ToInt32(cboNamHoc.SelectedValue);
                    DataTable dtHocKy = HocKyBUS.GetHocKyByNamHoc(maNamHoc);

                    if (dtHocKy != null && dtHocKy.Rows.Count > 0)
                    {
                        cboHocKy.DataSource = dtHocKy;
                        cboHocKy.DisplayMember = "TenHocKy";
                        cboHocKy.ValueMember = "MaHocKy";
                    }
                    else
                    {
                        cboHocKy.DataSource = null;
                        cboLop.DataSource = null;
                        MessageBox.Show("Năm học này chưa có học kỳ!", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi tải học kỳ: " + ex.Message, "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void cboHocKy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isLoading) return;

            if (cboHocKy.SelectedValue != null && cboHocKy.SelectedValue.GetType() != typeof(DataRowView))
            {
                try
                {
                    DataTable dtLop = LopBUS.GetAllLop();

                    if (dtLop != null && dtLop.Rows.Count > 0)
                    {
                        cboLop.DataSource = dtLop;
                        cboLop.DisplayMember = "TenLop";
                        cboLop.ValueMember = "MaLop";
                    }
                    else
                    {
                        cboLop.DataSource = null;
                        MessageBox.Show("Chưa có lớp học!", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi tải lớp: " + ex.Message, "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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

                // Tải danh sách học sinh trong lớp
                DataTable dtTrongLop = PhanLopBUS.GetHocSinhByLop(maLop, maHocKy);
                dgvHocSinhTrongLop.DataSource = dtTrongLop;

                if (dgvHocSinhTrongLop.Columns.Count > 0)
                {
                    // Ẩn các cột không cần thiết
                    if (dgvHocSinhTrongLop.Columns.Contains("MaLop"))
                        dgvHocSinhTrongLop.Columns["MaLop"].Visible = false;
                    if (dgvHocSinhTrongLop.Columns.Contains("MaHocKy"))
                        dgvHocSinhTrongLop.Columns["MaHocKy"].Visible = false;
                    if (dgvHocSinhTrongLop.Columns.Contains("MaPhanLop"))
                        dgvHocSinhTrongLop.Columns["MaPhanLop"].Visible = false;
                    if (dgvHocSinhTrongLop.Columns.Contains("NgayPhanLop"))
                        dgvHocSinhTrongLop.Columns["NgayPhanLop"].Visible = false;

                    // Đặt tiêu đề
                    if (dgvHocSinhTrongLop.Columns.Contains("MaHS"))
                        dgvHocSinhTrongLop.Columns["MaHS"].HeaderText = "Mã HS";
                    if (dgvHocSinhTrongLop.Columns.Contains("HoTen"))
                        dgvHocSinhTrongLop.Columns["HoTen"].HeaderText = "Họ và tên";
                    if (dgvHocSinhTrongLop.Columns.Contains("NgaySinh"))
                    {
                        dgvHocSinhTrongLop.Columns["NgaySinh"].HeaderText = "Ngày sinh";
                        dgvHocSinhTrongLop.Columns["NgaySinh"].DefaultCellStyle.Format = "dd/MM/yyyy";
                    }
                    if (dgvHocSinhTrongLop.Columns.Contains("GioiTinh"))
                        dgvHocSinhTrongLop.Columns["GioiTinh"].HeaderText = "Giới tính";

                    dgvHocSinhTrongLop.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }

                // Tải tất cả học sinh
                DataTable dtTatCa = HocSinhBUS.GetAllHocSinh();
                dgvTatCaHocSinh.DataSource = dtTatCa;

                if (dgvTatCaHocSinh.Columns.Count > 0)
                {
                    // Ẩn các cột không cần thiết
                    if (dgvTatCaHocSinh.Columns.Contains("TrangThai"))
                        dgvTatCaHocSinh.Columns["TrangThai"].Visible = false;
                    if (dgvTatCaHocSinh.Columns.Contains("NgayNhapHoc"))
                        dgvTatCaHocSinh.Columns["NgayNhapHoc"].Visible = false;
                    if (dgvTatCaHocSinh.Columns.Contains("DiaChi"))
                        dgvTatCaHocSinh.Columns["DiaChi"].Visible = false;
                    if (dgvTatCaHocSinh.Columns.Contains("DienThoai"))
                        dgvTatCaHocSinh.Columns["DienThoai"].Visible = false;
                    if (dgvTatCaHocSinh.Columns.Contains("Email"))
                        dgvTatCaHocSinh.Columns["Email"].Visible = false;

                    // Đặt tiêu đề
                    if (dgvTatCaHocSinh.Columns.Contains("MaHS"))
                        dgvTatCaHocSinh.Columns["MaHS"].HeaderText = "Mã HS";
                    if (dgvTatCaHocSinh.Columns.Contains("HoTen"))
                        dgvTatCaHocSinh.Columns["HoTen"].HeaderText = "Họ và tên";
                    if (dgvTatCaHocSinh.Columns.Contains("NgaySinh"))
                    {
                        dgvTatCaHocSinh.Columns["NgaySinh"].HeaderText = "Ngày sinh";
                        dgvTatCaHocSinh.Columns["NgaySinh"].DefaultCellStyle.Format = "dd/MM/yyyy";
                    }
                    if (dgvTatCaHocSinh.Columns.Contains("GioiTinh"))
                        dgvTatCaHocSinh.Columns["GioiTinh"].HeaderText = "Giới tính";

                    dgvTatCaHocSinh.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }

                lblTrongLop.Text = $"Trong lớp: {dtTrongLop.Rows.Count} học sinh";
                lblTatCa.Text = $"Tất cả: {dtTatCa.Rows.Count} học sinh";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải danh sách: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThemVaoLop_Click(object sender, EventArgs e)
        {
            if (dgvTatCaHocSinh.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn học sinh từ danh sách!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cboLop.SelectedValue == null || cboHocKy.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn lớp và học kỳ!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int maHS = Convert.ToInt32(dgvTatCaHocSinh.CurrentRow.Cells["MaHS"].Value);
                int maLop = Convert.ToInt32(cboLop.SelectedValue);
                int maHocKy = Convert.ToInt32(cboHocKy.SelectedValue);

                string error;
                if (PhanLopBUS.ThemHocSinhVaoLop(maHS, maLop, maHocKy, out error))
                {
                    MessageBox.Show("Thêm học sinh vào lớp thành công!", "Thông báo",
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
                MessageBox.Show("Lỗi thêm học sinh: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoaKhoiLop_Click(object sender, EventArgs e)
        {
            if (dgvHocSinhTrongLop.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn học sinh từ danh sách trong lớp!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show(
                "Bạn có chắc chắn muốn xóa học sinh khỏi lớp này không?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    int maHS = Convert.ToInt32(dgvHocSinhTrongLop.CurrentRow.Cells["MaHS"].Value);
                    int maLop = Convert.ToInt32(cboLop.SelectedValue);
                    int maHocKy = Convert.ToInt32(cboHocKy.SelectedValue);

                    string error;
                    if (PhanLopBUS.XoaHocSinhKhoiLop(maHS, maLop, maHocKy, out error))
                    {
                        MessageBox.Show("Xóa học sinh khỏi lớp thành công!", "Thông báo",
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
                    MessageBox.Show("Lỗi xóa học sinh: " + ex.Message, "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}