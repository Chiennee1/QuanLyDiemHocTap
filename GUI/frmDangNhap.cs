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
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string tenDangNhap = txtTenDangNhap.Text.Trim();
            string matKhau = txtMatKhau.Text.Trim();

            if (string.IsNullOrWhiteSpace(tenDangNhap))
            {
                MessageBox.Show("Vui lòng nhập tên đăng nhập!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenDangNhap.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(matKhau))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMatKhau.Focus();
                return;
            }

            TaiKhoanDTO taiKhoan = TaiKhoanBUS.DangNhap(tenDangNhap, matKhau);

            if (taiKhoan != null)
            {
                MessageBox.Show("Đăng nhập thành công!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Lưu thông tin người dùng hiện tại
                CurrentUser.MaTaiKhoan = taiKhoan.MaTaiKhoan;
                CurrentUser.TenDangNhap = taiKhoan.TenDangNhap;
                CurrentUser.LoaiTaiKhoan = taiKhoan.LoaiTaiKhoan;
                CurrentUser.MaNguoiDung = taiKhoan.MaNguoiDung;

                // Mở form chính
                frmMain frmMain = new frmMain();
                this.Hide();
                frmMain.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMatKhau.Clear();
                txtTenDangNhap.Focus();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn thoát?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void txtMatKhau_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnDangNhap_Click(sender, e);
            }
        }
    }

    // Class lưu thông tin người dùng hiện tại
    public static class CurrentUser
    {
        public static int MaTaiKhoan { get; set; }
        public static string TenDangNhap { get; set; }
        public static string LoaiTaiKhoan { get; set; }
        public static int MaNguoiDung { get; set; }
    }
}
