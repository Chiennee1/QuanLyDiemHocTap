using QuanLyDiemHocTap.BUS;
using QuanLyDiemHocTap.DTO;
using System;
using System.Data;
using System.Windows.Forms;

namespace QuanLyDiemHocTap.GUI
{
    public partial class frmGiaoVien : Form
    {
        private int selectedMaGV = -1;

        public frmGiaoVien()
        {
            InitializeComponent();
            this.Load += FrmGiaoVien_Load;
        }

        private void FrmGiaoVien_Load(object sender, EventArgs e)
        {
            LoadData();
            cboGioiTinh.Items.AddRange(new string[] { "Nam", "Nữ" });
            cboGioiTinh.SelectedIndex = 0;
            dtpNgaySinh.Value = DateTime.Now.AddYears(-25);
        }

        private void LoadData()
        {
            try
            {
                DataTable dt = GiaoVienBUS.GetAllGiaoVien();
                dgvGiaoVien.DataSource = dt;

                if (dgvGiaoVien.Columns.Count > 0)
                {
                    dgvGiaoVien.Columns["MaGV"].HeaderText = "Mã GV";
                    dgvGiaoVien.Columns["MaGV"].Width = 80;
                    dgvGiaoVien.Columns["HoTen"].HeaderText = "Họ và tên";
                    dgvGiaoVien.Columns["HoTen"].Width = 180;
                    dgvGiaoVien.Columns["NgaySinh"].HeaderText = "Ngày sinh";
                    dgvGiaoVien.Columns["NgaySinh"].Width = 100;
                    dgvGiaoVien.Columns["GioiTinh"].HeaderText = "Giới tính";
                    dgvGiaoVien.Columns["GioiTinh"].Width = 80;
                    dgvGiaoVien.Columns["DiaChi"].HeaderText = "Địa chỉ";
                    dgvGiaoVien.Columns["DiaChi"].Width = 200;
                    dgvGiaoVien.Columns["DienThoai"].HeaderText = "Điện thoại";
                    dgvGiaoVien.Columns["DienThoai"].Width = 100;
                    dgvGiaoVien.Columns["Email"].HeaderText = "Email";
                    dgvGiaoVien.Columns["Email"].Width = 150;
                    dgvGiaoVien.Columns["ChuyenMon"].HeaderText = "Chuyên môn";
                    dgvGiaoVien.Columns["ChuyenMon"].Width = 150;
                    dgvGiaoVien.Columns["TrangThai"].Visible = false;
                }

                lblTongSo.Text = $"Tổng số: {dt.Rows.Count} giáo viên";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearInputs()
        {
            txtHoTen.Clear();
            txtDiaChi.Clear();
            txtDienThoai.Clear();
            txtEmail.Clear();
            txtChuyenMon.Clear();
            cboGioiTinh.SelectedIndex = 0;
            dtpNgaySinh.Value = DateTime.Now.AddYears(-25);
            selectedMaGV = -1;
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            txtHoTen.Focus();
        }

        private void dgvGiaoVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    DataGridViewRow row = dgvGiaoVien.Rows[e.RowIndex];
                    selectedMaGV = Convert.ToInt32(row.Cells["MaGV"].Value);

                    txtHoTen.Text = row.Cells["HoTen"].Value.ToString();

                    if (row.Cells["NgaySinh"].Value != DBNull.Value)
                        dtpNgaySinh.Value = Convert.ToDateTime(row.Cells["NgaySinh"].Value);

                    cboGioiTinh.Text = row.Cells["GioiTinh"].Value.ToString();
                    txtDiaChi.Text = row.Cells["DiaChi"].Value?.ToString() ?? "";
                    txtDienThoai.Text = row.Cells["DienThoai"].Value?.ToString() ?? "";
                    txtEmail.Text = row.Cells["Email"].Value?.ToString() ?? "";
                    txtChuyenMon.Text = row.Cells["ChuyenMon"].Value?.ToString() ?? "";

                    btnThem.Enabled = false;
                    btnSua.Enabled = true;
                    btnXoa.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message, "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs()) return;

            GiaoVienDTO gv = new GiaoVienDTO
            {
                HoTen = txtHoTen.Text.Trim(),
                NgaySinh = dtpNgaySinh.Value,
                GioiTinh = cboGioiTinh.Text,
                DiaChi = txtDiaChi.Text.Trim(),
                DienThoai = txtDienThoai.Text.Trim(),
                Email = txtEmail.Text.Trim(),
                ChuyenMon = txtChuyenMon.Text.Trim()
            };

            string error;
            if (GiaoVienBUS.ThemGiaoVien(gv, out error))
            {
                MessageBox.Show("Thêm giáo viên thành công!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
                ClearInputs();
            }
            else
            {
                MessageBox.Show(error, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (selectedMaGV == -1)
            {
                MessageBox.Show("Vui lòng chọn giáo viên cần sửa!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidateInputs()) return;

            GiaoVienDTO gv = new GiaoVienDTO
            {
                MaGV = selectedMaGV,
                HoTen = txtHoTen.Text.Trim(),
                NgaySinh = dtpNgaySinh.Value,
                GioiTinh = cboGioiTinh.Text,
                DiaChi = txtDiaChi.Text.Trim(),
                DienThoai = txtDienThoai.Text.Trim(),
                Email = txtEmail.Text.Trim(),
                ChuyenMon = txtChuyenMon.Text.Trim()
            };

            string error;
            if (GiaoVienBUS.SuaGiaoVien(gv, out error))
            {
                MessageBox.Show("Cập nhật giáo viên thành công!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
                ClearInputs();
            }
            else
            {
                MessageBox.Show(error, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (selectedMaGV == -1)
            {
                MessageBox.Show("Vui lòng chọn giáo viên cần xóa!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show(
                "Bạn có chắc muốn xóa giáo viên này?\n" +
                "Lưu ý: Giáo viên sẽ không bị xóa vĩnh viễn, chỉ đánh dấu là không hoạt động.",
                "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                string error;
                if (GiaoVienBUS.XoaGiaoVien(selectedMaGV, out error))
                {
                    MessageBox.Show("Xóa giáo viên thành công!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                    ClearInputs();
                }
                else
                {
                    MessageBox.Show(error, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            ClearInputs();
            LoadData();
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtTimKiem.Text.Trim();
            if (!string.IsNullOrWhiteSpace(keyword))
            {
                try
                {
                    DataTable dt = GiaoVienBUS.GetAllGiaoVien();
                    DataView dv = dt.DefaultView;
                    dv.RowFilter = $"HoTen LIKE '%{keyword}%' OR DienThoai LIKE '%{keyword}%' OR ChuyenMon LIKE '%{keyword}%'";
                    dgvGiaoVien.DataSource = dv.ToTable();
                    lblTongSo.Text = $"Tìm thấy: {dv.Count} giáo viên";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi tìm kiếm: " + ex.Message, "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                LoadData();
            }
        }

        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                MessageBox.Show("Vui lòng nhập họ tên!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHoTen.Focus();
                return false;
            }

            if (cboGioiTinh.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn giới tính!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboGioiTinh.Focus();
                return false;
            }

            if (dtpNgaySinh.Value >= DateTime.Now.AddYears(-18))
            {
                MessageBox.Show("Giáo viên phải từ 18 tuổi trở lên!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpNgaySinh.Focus();
                return false;
            }

            // Validate email nếu có nhập
            if (!string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                if (!IsValidEmail(txtEmail.Text.Trim()))
                {
                    MessageBox.Show("Email không hợp lệ!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtEmail.Focus();
                    return false;
                }
            }

            // Validate số điện thoại nếu có nhập
            if (!string.IsNullOrWhiteSpace(txtDienThoai.Text))
            {
                string phone = txtDienThoai.Text.Trim();
                if (phone.Length < 10 || !System.Text.RegularExpressions.Regex.IsMatch(phone, @"^\d+$"))
                {
                    MessageBox.Show("Số điện thoại không hợp lệ!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtDienThoai.Focus();
                    return false;
                }
            }

            return true;
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
    }
}