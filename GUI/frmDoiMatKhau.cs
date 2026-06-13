using QuanLyDiemHocTap.BUS;
using System;
using System.Windows.Forms;

namespace QuanLyDiemHocTap.GUI
{
    public partial class frmDoiMatKhau : Form
    {
        private int maTaiKhoan;

        public frmDoiMatKhau()
        {
            InitializeComponent();
        }

        public frmDoiMatKhau(int maTaiKhoan) : this()
        {
            this.maTaiKhoan = maTaiKhoan;
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            if (!ValidateInput())
                return;

            if (txtMatKhauMoi.Text != txtXacNhanMatKhau.Text)
            {
                MessageBox.Show("Mật khẩu xác nhận không khớp!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtXacNhanMatKhau.Focus();
                return;
            }

            try
            {
                if (TaiKhoanBUS.DoiMatKhau(maTaiKhoan, txtMatKhauCu.Text,
                    txtMatKhauMoi.Text, out string error))
                {
                    MessageBox.Show("Đổi mật khẩu thành công!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show(error, "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi đổi mật khẩu: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chkHienMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            char passwordChar = chkHienMatKhau.Checked ? '\0' : '●';

            txtMatKhauCu.PasswordChar = passwordChar;
            txtMatKhauMoi.PasswordChar = passwordChar;
            txtXacNhanMatKhau.PasswordChar = passwordChar;
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtMatKhauCu.Text))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu cũ!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMatKhauCu.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtMatKhauMoi.Text))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu mới!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMatKhauMoi.Focus();
                return false;
            }

            if (txtMatKhauMoi.Text.Length < 6)
            {
                MessageBox.Show("Mật khẩu phải có ít nhất 6 ký tự!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMatKhauMoi.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtXacNhanMatKhau.Text))
            {
                MessageBox.Show("Vui lòng xác nhận mật khẩu mới!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtXacNhanMatKhau.Focus();
                return false;
            }

            return true;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void txtMatKhauCu_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMatKhauMoi_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
