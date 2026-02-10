using QuanLyDiemHocTap.BUS;
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
    public partial class frmDoiMatKhau : Form
    {
        public frmDoiMatKhau()
        {
            InitializeComponent();
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            string matKhauCu = txtMatKhauCu.Text.Trim();
            string matKhauMoi = txtMatKhauMoi.Text.Trim();
            string xacNhanMatKhau = txtXacNhanMatKhau.Text.Trim();

            if (string.IsNullOrWhiteSpace(matKhauCu))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu cũ!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMatKhauCu.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(matKhauMoi))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu mới!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMatKhauMoi.Focus();
                return;
            }

            if (matKhauMoi.Length < 6)
            {
                MessageBox.Show("Mật khẩu mới phải có ít nhất 6 ký tự!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMatKhauMoi.Focus();
                return;
            }

            if (matKhauMoi != xacNhanMatKhau)
            {
                MessageBox.Show("Xác nhận mật khẩu không khớp!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtXacNhanMatKhau.Focus();
                return;
            }

            // Kiểm tra mật khẩu cũ
            var taiKhoan = TaiKhoanBUS.DangNhap(CurrentUser.TenDangNhap, matKhauCu);
            if (taiKhoan == null)
            {
                MessageBox.Show("Mật khẩu cũ không đúng!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMatKhauCu.Clear();
                txtMatKhauCu.Focus();
                return;
            }

            string error;
            if (TaiKhoanBUS.DoiMatKhau(CurrentUser.MaTaiKhoan, matKhauCu, matKhauMoi, out error))
            {
                MessageBox.Show("Đổi mật khẩu thành công!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show(error, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chkHienMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            char passwordChar = chkHienMatKhau.Checked ? '\0' : '●';
            txtMatKhauCu.PasswordChar = passwordChar;
            txtMatKhauMoi.PasswordChar = passwordChar;
            txtXacNhanMatKhau.PasswordChar = passwordChar;
        }
    }
}
