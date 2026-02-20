using QuanLyDiemHocTap.BUS;
using System;
using System.Data;
using System.Windows.Forms;

namespace QuanLyDiemHocTap.GUI
{
    public partial class frmQuanLyTaiKhoan : Form
    {
        private int selectedMaTaiKhoan = -1;

        public frmQuanLyTaiKhoan()
        {
            InitializeComponent();
            this.Load += FrmQuanLyTaiKhoan_Load;
        }

        private void FrmQuanLyTaiKhoan_Load(object sender, EventArgs e)
        {
            try
            {
                InitializeForm();
            }
            catch (Exception ex)
            {
                ShowError("Lỗi khi tải form", ex);
            }
        }

        private void InitializeForm()
        {
            cboLoaiTaiKhoan.SelectedIndex = 0;
            chkTrangThai.Checked = true;
            LoadData();
            ClearInputs();
        }

        private void LoadData()
        {
            try
            {
                DataTable dt = TaiKhoanBUS.GetAllTaiKhoan();
                dgvTaiKhoan.DataSource = dt;

                ConfigureDataGridView();
                UpdateRecordCount(dt.Rows.Count);
            }
            catch (Exception ex)
            {
                ShowError("Lỗi tải dữ liệu", ex);
            }
        }

        private void ConfigureDataGridView()
        {
            if (dgvTaiKhoan.Columns.Count == 0)
                return;

            // Ẩn các cột không cần thiết
            HideColumn("MaTaiKhoan");
            HideColumn("MaNguoiDung");
            HideColumn("MatKhau");

            // Đặt tiêu đề cột
            SetColumnHeader("TenDangNhap", "Tên đăng nhập");
            SetColumnHeader("LoaiTaiKhoan", "Loại tài khoản");
            SetColumnHeader("HoTen", "Họ và tên");
            SetColumnHeader("Email", "Email");

            if (dgvTaiKhoan.Columns.Contains("TrangThai"))
            {
                dgvTaiKhoan.Columns["TrangThai"].HeaderText = "Trạng thái";
                dgvTaiKhoan.Columns["TrangThai"].Width = 100;
            }

            if (dgvTaiKhoan.Columns.Contains("NgayTao"))
            {
                dgvTaiKhoan.Columns["NgayTao"].HeaderText = "Ngày tạo";
                dgvTaiKhoan.Columns["NgayTao"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";
                dgvTaiKhoan.Columns["NgayTao"].Width = 150;
            }

            dgvTaiKhoan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void HideColumn(string columnName)
        {
            if (dgvTaiKhoan.Columns.Contains(columnName))
                dgvTaiKhoan.Columns[columnName].Visible = false;
        }

        private void SetColumnHeader(string columnName, string headerText)
        {
            if (dgvTaiKhoan.Columns.Contains(columnName))
                dgvTaiKhoan.Columns[columnName].HeaderText = headerText;
        }

        private void UpdateRecordCount(int count, bool isSearch = false)
        {
            lblTongSo.Text = isSearch
                ? $"Tìm thấy: {count} tài khoản"
                : $"Tổng số: {count} tài khoản";
        }

        private void cboLoaiTaiKhoan_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string loaiTK = cboLoaiTaiKhoan.SelectedItem?.ToString();

                if (string.IsNullOrEmpty(loaiTK))
                    return;

                ResetNguoiDungComboBox();

                switch (loaiTK)
                {
                    case "Admin":
                        ConfigureAdminMode();
                        break;
                    case "GiaoVien":
                        ConfigureGiaoVienMode();
                        break;
                    case "HocSinh":
                        ConfigureHocSinhMode();
                        break;
                }
            }
            catch (Exception ex)
            {
                ShowError("Lỗi khi chọn loại tài khoản", ex);
            }
        }

        private void ResetNguoiDungComboBox()
        {
            cboNguoiDung.DataSource = null;
            cboNguoiDung.Items.Clear();
        }

        private void ConfigureAdminMode()
        {
            cboNguoiDung.Enabled = false;
            lblNguoiDung.Text = "Người dùng: (Admin không cần chọn)";
        }

        private void ConfigureGiaoVienMode()
        {
            cboNguoiDung.Enabled = true;
            lblNguoiDung.Text = "Chọn giáo viên:";

            DataTable dtGV = GiaoVienBUS.GetAllGiaoVien();
            if (dtGV != null && dtGV.Rows.Count > 0)
            {
                cboNguoiDung.DataSource = dtGV;
                cboNguoiDung.DisplayMember = "HoTen";
                cboNguoiDung.ValueMember = "MaGV";
            }
        }

        private void ConfigureHocSinhMode()
        {
            cboNguoiDung.Enabled = true;
            lblNguoiDung.Text = "Chọn học sinh:";

            DataTable dtHS = HocSinhBUS.GetAllHocSinh();
            if (dtHS != null && dtHS.Rows.Count > 0)
            {
                cboNguoiDung.DataSource = dtHS;
                cboNguoiDung.DisplayMember = "HoTen";
                cboNguoiDung.ValueMember = "MaHS";
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!ValidateInputForAdd())
                return;

            if (!TryGetMaNguoiDung(out int maNguoiDung))
                return;

            try
            {
                string loaiTK = cboLoaiTaiKhoan.SelectedItem?.ToString();

                if (TaiKhoanBUS.ThemTaiKhoan(txtTenDangNhap.Text.Trim(),
                    txtMatKhau.Text, loaiTK, maNguoiDung, out string error))
                {
                    ShowSuccess("Thêm tài khoản thành công!");
                    LoadData();
                    ClearInputs();
                }
                else
                {
                    ShowError(error);
                }
            }
            catch (Exception ex)
            {
                ShowError("Lỗi thêm tài khoản", ex);
            }
        }

        private bool ValidateInputForAdd()
        {
            if (string.IsNullOrWhiteSpace(txtTenDangNhap.Text))
            {
                ShowWarning("Vui lòng nhập tên đăng nhập!");
                txtTenDangNhap.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtMatKhau.Text))
            {
                ShowWarning("Vui lòng nhập mật khẩu!");
                txtMatKhau.Focus();
                return false;
            }

            if (txtMatKhau.Text.Length < 6)
            {
                ShowWarning("Mật khẩu phải có ít nhất 6 ký tự!");
                txtMatKhau.Focus();
                return false;
            }

            return true;
        }

        private bool TryGetMaNguoiDung(out int maNguoiDung)
        {
            maNguoiDung = 0;
            string loaiTK = cboLoaiTaiKhoan.SelectedItem?.ToString();

            if (loaiTK == "Admin")
            {
                return true;
            }

            if (loaiTK == "GiaoVien" || loaiTK == "HocSinh")
            {
                if (cboNguoiDung.SelectedValue == null ||
                    cboNguoiDung.SelectedValue is DataRowView)
                {
                    ShowWarning("Vui lòng chọn người dùng!");
                    return false;
                }
                maNguoiDung = Convert.ToInt32(cboNguoiDung.SelectedValue);
            }

            return true;
        }

        private void dgvTaiKhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= dgvTaiKhoan.Rows.Count)
                return;

            try
            {
                DataGridViewRow row = dgvTaiKhoan.Rows[e.RowIndex];

                if (!IsValidCell(row, "MaTaiKhoan"))
                    return;

                LoadSelectedAccount(row);
            }
            catch (Exception ex)
            {
                ShowError("Lỗi khi chọn tài khoản", ex);
            }
        }

        private bool IsValidCell(DataGridViewRow row, string columnName)
        {
            return row.Cells[columnName].Value != null &&
                   row.Cells[columnName].Value != DBNull.Value;
        }

        private void LoadSelectedAccount(DataGridViewRow row)
        {
            selectedMaTaiKhoan = Convert.ToInt32(row.Cells["MaTaiKhoan"].Value);

            txtTenDangNhap.Text = row.Cells["TenDangNhap"].Value?.ToString() ?? string.Empty;
            txtTenDangNhap.Enabled = false;
            txtMatKhau.Clear();
            txtMatKhau.Enabled = false;

            string loaiTK = row.Cells["LoaiTaiKhoan"].Value?.ToString() ?? "Admin";
            cboLoaiTaiKhoan.SelectedItem = loaiTK;

            // Load MaNguoiDung nếu không phải Admin
            if (loaiTK != "Admin" && IsValidCell(row, "MaNguoiDung"))
            {
                int maNguoiDung = Convert.ToInt32(row.Cells["MaNguoiDung"].Value);

                // Đảm bảo ComboBox đã load xong trước khi set value
                Application.DoEvents();

                if (cboNguoiDung.Items.Count > 0)
                {
                    cboNguoiDung.SelectedValue = maNguoiDung;
                }
            }

            chkTrangThai.Checked = IsValidCell(row, "TrangThai") &&
                                   Convert.ToBoolean(row.Cells["TrangThai"].Value);

            EnableEditMode();
        }

        private void EnableEditMode()
        {
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnDoiMatKhau.Enabled = true;
            btnThem.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (selectedMaTaiKhoan == -1)
            {
                ShowWarning("Vui lòng chọn tài khoản cần sửa!");
                return;
            }

            if (!TryGetMaNguoiDung(out int maNguoiDung))
                return;

            try
            {
                string loaiTK = cboLoaiTaiKhoan.SelectedItem?.ToString();

                if (TaiKhoanBUS.SuaTaiKhoan(selectedMaTaiKhoan, loaiTK,
                    maNguoiDung, chkTrangThai.Checked, out string error))
                {
                    ShowSuccess("Cập nhật tài khoản thành công!");
                    LoadData();
                    ClearInputs();
                }
                else
                {
                    ShowError(error);
                }
            }
            catch (Exception ex)
            {
                ShowError("Lỗi cập nhật tài khoản", ex);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (selectedMaTaiKhoan == -1)
            {
                ShowWarning("Vui lòng chọn tài khoản cần xóa!");
                return;
            }

            DialogResult result = MessageBox.Show(
                $"Bạn có chắc chắn muốn xóa tài khoản '{txtTenDangNhap.Text}' không?\n\n" +
                "Tài khoản sẽ bị vô hiệu hóa!",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result != DialogResult.Yes)
                return;

            try
            {
                if (TaiKhoanBUS.XoaTaiKhoan(selectedMaTaiKhoan, out string error))
                {
                    ShowSuccess("Xóa tài khoản thành công!");
                    LoadData();
                    ClearInputs();
                }
                else
                {
                    ShowError(error);
                }
            }
            catch (Exception ex)
            {
                ShowError("Lỗi xóa tài khoản", ex);
            }
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            if (selectedMaTaiKhoan == -1)
            {
                ShowWarning("Vui lòng chọn tài khoản cần đổi mật khẩu!");
                return;
            }

            using (frmDoiMatKhau frm = new frmDoiMatKhau(selectedMaTaiKhoan))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    ShowSuccess("Đổi mật khẩu thành công!");
                }
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                string keyword = txtTimKiem.Text.Trim();

                if (string.IsNullOrWhiteSpace(keyword))
                {
                    LoadData();
                    return;
                }

                DataTable dt = TaiKhoanBUS.SearchTaiKhoan(keyword);
                dgvTaiKhoan.DataSource = dt;
                UpdateRecordCount(dt.Rows.Count, true);

                if (dt.Rows.Count == 0)
                {
                    ShowInfo("Không tìm thấy tài khoản nào!");
                }
            }
            catch (Exception ex)
            {
                ShowError("Lỗi tìm kiếm", ex);
            }
        }

        private void txtTimKiem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnTimKiem.PerformClick();
                e.Handled = true;
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtTimKiem.Clear();
            ClearInputs();
            LoadData();
        }

        private void ClearInputs()
        {
            txtTenDangNhap.Clear();
            txtTenDangNhap.Enabled = true;
            txtMatKhau.Clear();
            txtMatKhau.Enabled = true;
            cboLoaiTaiKhoan.SelectedIndex = 0;
            ResetNguoiDungComboBox();
            chkTrangThai.Checked = true;

            selectedMaTaiKhoan = -1;

            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnDoiMatKhau.Enabled = false;
        }

        #region Helper Methods

        private void ShowSuccess(string message)
        {
            MessageBox.Show(message, "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ShowWarning(string message)
        {
            MessageBox.Show(message, "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void ShowInfo(string message)
        {
            MessageBox.Show(message, "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ShowError(string message)
        {
            MessageBox.Show(message, "Lỗi",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void ShowError(string message, Exception ex)
        {
            MessageBox.Show($"{message}: {ex.Message}", "Lỗi",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        #endregion
    }
}