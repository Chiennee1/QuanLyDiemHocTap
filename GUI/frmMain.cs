using QuanLyDienHocTap.GUI;
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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            this.Load += FrmMain_Load;
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            // Hiển thị thông tin người dùng
            lblNguoiDung.Text = $"Xin chào: {CurrentUser.TenDangNhap} ({CurrentUser.LoaiTaiKhoan})";

            // Phân quyền theo loại tài khoản
            if (CurrentUser.LoaiTaiKhoan != "Admin")
            {
                mnuHeThong.Visible = false;
            }
        }

        // Menu Hệ thống
        private void mnuQuanLyTaiKhoan_Click(object sender, EventArgs e)
        {
           frmQuanLyTaiKhoan frm = new frmQuanLyTaiKhoan();
            frm.Show();
        }

        private void mnuDoiMatKhau_Click(object sender, EventArgs e)
        {
            frmDoiMatKhau frm = new frmDoiMatKhau();
            frm.ShowDialog();
        }

        private void mnuDangXuat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn đăng xuất?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
                frmDangNhap frmDangNhap = new frmDangNhap();
                frmDangNhap.Show();
            }
        }

        private void mnuThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn thoát?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        // Menu Danh mục
        private void mnuHocSinh_Click(object sender, EventArgs e)
        {
            frmHocSinh frm = new frmHocSinh();
            frm.MdiParent = this;
            frm.Show();
        }

        private void mnuGiaoVien_Click(object sender, EventArgs e)
        {
            frmGiaoVien frm = new frmGiaoVien();
            frm.MdiParent = this;
            frm.Show();
        }

        private void mnuLop_Click(object sender, EventArgs e)
        {
            frmLop frm = new frmLop();
            frm.MdiParent = this;
            frm.Show();
        }

        private void mnuMonHoc_Click(object sender, EventArgs e)
        {
            frmMonHoc frm = new frmMonHoc();
            frm.MdiParent = this;
            frm.Show();
        }

        private void mnuPhanLop_Click(object sender, EventArgs e)
        {
            frmPhanLop frm = new frmPhanLop();
            frm.MdiParent = this;
            frm.Show();
        }

        private void mnuPhanCong_Click(object sender, EventArgs e)
        {
            frmPhanCong frm = new frmPhanCong();
            frm.MdiParent = this;
            frm.Show();
        }

        // Menu Quản lý điểm
        private void mnuNhapDiem_Click(object sender, EventArgs e)
        {
            frmNhapDiem frm = new frmNhapDiem();
            frm.MdiParent = this;
            frm.Show();
        }

        private void mnuXemDiem_Click(object sender, EventArgs e)
        {
            frmXemDiem frm = new frmXemDiem();
            frm.MdiParent = this;
            frm.Show();
        }

        private void mnuTongKet_Click(object sender, EventArgs e)
        {
            frmTongKet frm = new frmTongKet();
            frm.MdiParent = this;
            frm.Show();
        }

        // Menu Báo cáo
        private void mnuBaoCaoLop_Click(object sender, EventArgs e)
        {
            frmBaoCaoLop frm = new frmBaoCaoLop();
            frm.MdiParent = this;
            frm.Show();
        }

        private void mnuBaoCaoHocSinh_Click(object sender, EventArgs e)
        {
            frmBaoCaoHocSinh frm = new frmBaoCaoHocSinh();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}

