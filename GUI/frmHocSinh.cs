using QuanLyDiemHocTap.BUS;
using QuanLyDiemHocTap.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDiemHocTap.GUI
{
    public partial class frmHocSinh : Form
    {
        private int selectedMaHS = -1;

        public frmHocSinh()
        {
            InitializeComponent();
            this.Load += FrmHocSinh_Load;
        }

        private void FrmHocSinh_Load(object sender, EventArgs e)
        {
            LoadData();
            cboGioiTinh.Items.AddRange(new string[] { "Nam", "Nữ" });
            dtpNgaySinh.Value = DateTime.Now.AddYears(-12);
        }

        private void LoadData()
        {
            try
            {
                DataTable dt = HocSinhBUS.GetAllHocSinh();
                dgvHocSinh.DataSource = dt;

                if (dgvHocSinh.Columns.Count > 0)
                {
                    dgvHocSinh.Columns["MaHS"].HeaderText = "Mã HS";
                    dgvHocSinh.Columns["HoTen"].HeaderText = "Họ và tên";
                    dgvHocSinh.Columns["NgaySinh"].HeaderText = "Ngày sinh";
                    dgvHocSinh.Columns["GioiTinh"].HeaderText = "Giới tính";
                    dgvHocSinh.Columns["DiaChi"].HeaderText = "Địa chỉ";
                    dgvHocSinh.Columns["DienThoai"].HeaderText = "Điện thoại";
                    dgvHocSinh.Columns["Email"].HeaderText = "Email";
                    dgvHocSinh.Columns["TrangThai"].Visible = false;
                    dgvHocSinh.Columns["NgayNhapHoc"].Visible = false;


                }

                lblTongSo.Text = $"Tổng số: {dt.Rows.Count} học sinh";
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
            cboGioiTinh.SelectedIndex = 0;
            dtpNgaySinh.Value = DateTime.Now.AddYears(-12);
            selectedMaHS = -1;
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }

        private void dgvHocSinh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvHocSinh.Rows[e.RowIndex];
                selectedMaHS = Convert.ToInt32(row.Cells["MaHS"].Value);

                txtHoTen.Text = row.Cells["HoTen"].Value.ToString();
                dtpNgaySinh.Value = Convert.ToDateTime(row.Cells["NgaySinh"].Value);
                cboGioiTinh.Text = row.Cells["GioiTinh"].Value.ToString();
                txtDiaChi.Text = row.Cells["DiaChi"].Value.ToString();
                txtDienThoai.Text = row.Cells["DienThoai"].Value.ToString();
                txtEmail.Text = row.Cells["Email"].Value.ToString();

                btnThem.Enabled = false;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs()) return;

            HocSinhDTO hs = new HocSinhDTO
            {
                HoTen = txtHoTen.Text.Trim(),
                NgaySinh = dtpNgaySinh.Value,
                GioiTinh = cboGioiTinh.Text,
                DiaChi = txtDiaChi.Text.Trim(),
                DienThoai = txtDienThoai.Text.Trim(),
                Email = txtEmail.Text.Trim()
            };

            string error;
            if (HocSinhBUS.ThemHocSinh(hs, out error))
            {
                MessageBox.Show("Thêm học sinh thành công!", "Thông báo",
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
            if (selectedMaHS == -1)
            {
                MessageBox.Show("Vui lòng chọn học sinh cần sửa!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidateInputs()) return;

            HocSinhDTO hs = new HocSinhDTO
            {
                MaHS = selectedMaHS,
                HoTen = txtHoTen.Text.Trim(),
                NgaySinh = dtpNgaySinh.Value,
                GioiTinh = cboGioiTinh.Text,
                DiaChi = txtDiaChi.Text.Trim(),
                DienThoai = txtDienThoai.Text.Trim(),
                Email = txtEmail.Text.Trim()

            };

            string error;
            if (HocSinhBUS.SuaHocSinh(hs, out error))
            {
                MessageBox.Show("Cập nhật học sinh thành công!", "Thông báo",
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
            if (selectedMaHS == -1)
            {
                MessageBox.Show("Vui lòng chọn học sinh cần xóa!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa học sinh này?",
                "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                string error;
                if (HocSinhBUS.XoaHocSinh(selectedMaHS, out error))
                {
                    MessageBox.Show("Xóa học sinh thành công!", "Thông báo",
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
                DataTable dt = HocSinhBUS.SearchHocSinh(keyword);
                dgvHocSinh.DataSource = dt;
                lblTongSo.Text = $"Tìm thấy: {dt.Rows.Count} học sinh";
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

            if (dtpNgaySinh.Value >= DateTime.Now)
            {
                MessageBox.Show("Ngày sinh không hợp lệ!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
