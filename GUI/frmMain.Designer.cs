namespace QuanLyDiemHocTap.GUI
{
    partial class frmMain
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem mnuHeThong;
        private System.Windows.Forms.ToolStripMenuItem mnuQuanLyTaiKhoan;
        private System.Windows.Forms.ToolStripMenuItem mnuDoiMatKhau;
        private System.Windows.Forms.ToolStripMenuItem mnuDangXuat;
        private System.Windows.Forms.ToolStripMenuItem mnuThoat;
        private System.Windows.Forms.ToolStripMenuItem mnuDanhMuc;
        private System.Windows.Forms.ToolStripMenuItem mnuHocSinh;
        private System.Windows.Forms.ToolStripMenuItem mnuGiaoVien;
        private System.Windows.Forms.ToolStripMenuItem mnuLop;
        private System.Windows.Forms.ToolStripMenuItem mnuMonHoc;
        private System.Windows.Forms.ToolStripMenuItem mnuPhanLop;
        private System.Windows.Forms.ToolStripMenuItem mnuPhanCong;
        private System.Windows.Forms.ToolStripMenuItem mnuQuanLyDiem;
        private System.Windows.Forms.ToolStripMenuItem mnuNhapDiem;
        private System.Windows.Forms.ToolStripMenuItem mnuXemDiem;
        private System.Windows.Forms.ToolStripMenuItem mnuTongKet;
        private System.Windows.Forms.ToolStripMenuItem mnuBaoCao;
        private System.Windows.Forms.ToolStripMenuItem mnuBaoCaoLop;
        private System.Windows.Forms.ToolStripMenuItem mnuBaoCaoHocSinh;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel lblNguoiDung;
        private System.Windows.Forms.ToolStripStatusLabel lblThoiGian;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            menuStrip = new MenuStrip();
            mnuHeThong = new ToolStripMenuItem();
            mnuQuanLyTaiKhoan = new ToolStripMenuItem();
            mnuDoiMatKhau = new ToolStripMenuItem();
            mnuDangXuat = new ToolStripMenuItem();
            mnuDanhMuc = new ToolStripMenuItem();
            mnuHocSinh = new ToolStripMenuItem();
            mnuGiaoVien = new ToolStripMenuItem();
            mnuLop = new ToolStripMenuItem();
            mnuMonHoc = new ToolStripMenuItem();
            mnuPhanLop = new ToolStripMenuItem();
            mnuPhanCong = new ToolStripMenuItem();
            mnuQuanLyDiem = new ToolStripMenuItem();
            mnuNhapDiem = new ToolStripMenuItem();
            mnuXemDiem = new ToolStripMenuItem();
            mnuTongKet = new ToolStripMenuItem();
            mnuBaoCao = new ToolStripMenuItem();
            mnuBaoCaoLop = new ToolStripMenuItem();
            mnuBaoCaoHocSinh = new ToolStripMenuItem();
            statusStrip = new StatusStrip();
            lblNguoiDung = new ToolStripStatusLabel();
            lblThoiGian = new ToolStripStatusLabel();
            menuStrip.SuspendLayout();
            statusStrip.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip
            // 
            menuStrip.ImageScalingSize = new Size(24, 24);
            menuStrip.Items.AddRange(new ToolStripItem[] { mnuHeThong, mnuDanhMuc, mnuQuanLyDiem, mnuBaoCao });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Padding = new Padding(10, 4, 0, 4);
            menuStrip.Size = new Size(2000, 37);
            menuStrip.TabIndex = 0;
            // 
            // mnuHeThong
            // 
            mnuHeThong.DropDownItems.AddRange(new ToolStripItem[] { mnuQuanLyTaiKhoan, mnuDoiMatKhau, mnuDangXuat });
            mnuHeThong.Name = "mnuHeThong";
            mnuHeThong.Size = new Size(103, 29);
            mnuHeThong.Text = "Hệ thống";
            // 
            // mnuQuanLyTaiKhoan
            // 
            mnuQuanLyTaiKhoan.Name = "mnuQuanLyTaiKhoan";
            mnuQuanLyTaiKhoan.Size = new Size(270, 34);
            mnuQuanLyTaiKhoan.Text = "Quản lý tài khoản";
            mnuQuanLyTaiKhoan.Click += mnuQuanLyTaiKhoan_Click;
            // 
            // mnuDoiMatKhau
            // 
            mnuDoiMatKhau.Name = "mnuDoiMatKhau";
            mnuDoiMatKhau.Size = new Size(270, 34);
            mnuDoiMatKhau.Text = "Đổi mật khẩu";
            mnuDoiMatKhau.Click += mnuDoiMatKhau_Click;
            // 
            // mnuDangXuat
            // 
            mnuDangXuat.Name = "mnuDangXuat";
            mnuDangXuat.Size = new Size(270, 34);
            mnuDangXuat.Text = "Đăng xuất";
            mnuDangXuat.Click += mnuDangXuat_Click;
            // 
            // mnuDanhMuc
            // 
            mnuDanhMuc.DropDownItems.AddRange(new ToolStripItem[] { mnuHocSinh, mnuGiaoVien, mnuLop, mnuMonHoc, mnuPhanLop, mnuPhanCong });
            mnuDanhMuc.Name = "mnuDanhMuc";
            mnuDanhMuc.Size = new Size(109, 29);
            mnuDanhMuc.Text = "Danh mục";
            // 
            // mnuHocSinh
            // 
            mnuHocSinh.Name = "mnuHocSinh";
            mnuHocSinh.Size = new Size(282, 34);
            mnuHocSinh.Text = "Quản lý học sinh";
            mnuHocSinh.Click += mnuHocSinh_Click;
            // 
            // mnuGiaoVien
            // 
            mnuGiaoVien.Name = "mnuGiaoVien";
            mnuGiaoVien.Size = new Size(282, 34);
            mnuGiaoVien.Text = "Quản lý giáo viên";
            mnuGiaoVien.Click += mnuGiaoVien_Click;
            // 
            // mnuLop
            // 
            mnuLop.Name = "mnuLop";
            mnuLop.Size = new Size(282, 34);
            mnuLop.Text = "Quản lý lớp";
            mnuLop.Click += mnuLop_Click;
            // 
            // mnuMonHoc
            // 
            mnuMonHoc.Name = "mnuMonHoc";
            mnuMonHoc.Size = new Size(282, 34);
            mnuMonHoc.Text = "Quản lý môn học";
            mnuMonHoc.Click += mnuMonHoc_Click;
            // 
            // mnuPhanLop
            // 
            mnuPhanLop.Name = "mnuPhanLop";
            mnuPhanLop.Size = new Size(282, 34);
            mnuPhanLop.Text = "Phân lớp";
            mnuPhanLop.Click += mnuPhanLop_Click;
            // 
            // mnuPhanCong
            // 
            mnuPhanCong.Name = "mnuPhanCong";
            mnuPhanCong.Size = new Size(282, 34);
            mnuPhanCong.Text = "Phân công giảng dạy";
            mnuPhanCong.Click += mnuPhanCong_Click;
            // 
            // mnuQuanLyDiem
            // 
            mnuQuanLyDiem.DropDownItems.AddRange(new ToolStripItem[] { mnuNhapDiem, mnuXemDiem, mnuTongKet });
            mnuQuanLyDiem.Name = "mnuQuanLyDiem";
            mnuQuanLyDiem.Size = new Size(134, 29);
            mnuQuanLyDiem.Text = "Quản lý điểm";
            // 
            // mnuNhapDiem
            // 
            mnuNhapDiem.Name = "mnuNhapDiem";
            mnuNhapDiem.Size = new Size(241, 34);
            mnuNhapDiem.Text = "Nhập điểm";
            mnuNhapDiem.Click += mnuNhapDiem_Click;
            // 
            // mnuXemDiem
            // 
            mnuXemDiem.Name = "mnuXemDiem";
            mnuXemDiem.Size = new Size(241, 34);
            mnuXemDiem.Text = "Xem điểm";
            mnuXemDiem.Click += mnuXemDiem_Click;
            // 
            // mnuTongKet
            // 
            mnuTongKet.Name = "mnuTongKet";
            mnuTongKet.Size = new Size(241, 34);
            mnuTongKet.Text = "Tổng kết học kỳ";
            mnuTongKet.Click += mnuTongKet_Click;
            // 
            // mnuBaoCao
            // 
            mnuBaoCao.DropDownItems.AddRange(new ToolStripItem[] { mnuBaoCaoLop, mnuBaoCaoHocSinh });
            mnuBaoCao.Name = "mnuBaoCao";
            mnuBaoCao.Size = new Size(91, 29);
            mnuBaoCao.Text = "Báo cáo";
            // 
            // mnuBaoCaoLop
            // 
            mnuBaoCaoLop.Name = "mnuBaoCaoLop";
            mnuBaoCaoLop.Size = new Size(249, 34);
            mnuBaoCaoLop.Text = "Báo cáo theo lớp";
            mnuBaoCaoLop.Click += mnuBaoCaoLop_Click;
            // 
            // mnuBaoCaoHocSinh
            // 
            mnuBaoCaoHocSinh.Name = "mnuBaoCaoHocSinh";
            mnuBaoCaoHocSinh.Size = new Size(249, 34);
            mnuBaoCaoHocSinh.Text = "Báo cáo học sinh";
            mnuBaoCaoHocSinh.Click += mnuBaoCaoHocSinh_Click;
            // 
            // statusStrip
            // 
            statusStrip.ImageScalingSize = new Size(24, 24);
            statusStrip.Items.AddRange(new ToolStripItem[] { lblNguoiDung, lblThoiGian });
            statusStrip.Location = new Point(0, 1406);
            statusStrip.Name = "statusStrip";
            statusStrip.Padding = new Padding(2, 0, 23, 0);
            statusStrip.Size = new Size(2000, 32);
            statusStrip.TabIndex = 1;
            // 
            // lblNguoiDung
            // 
            lblNguoiDung.Name = "lblNguoiDung";
            lblNguoiDung.Size = new Size(118, 25);
            lblNguoiDung.Text = "Người dùng: ";
            // 
            // lblThoiGian
            // 
            lblThoiGian.Name = "lblThoiGian";
            lblThoiGian.Size = new Size(1857, 25);
            lblThoiGian.Spring = true;
            lblThoiGian.TextAlign = ContentAlignment.MiddleRight;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2000, 1438);
            Controls.Add(statusStrip);
            Controls.Add(menuStrip);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip;
            Margin = new Padding(5, 6, 5, 6);
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hệ thống Quản lý điểm THCS";
            WindowState = FormWindowState.Maximized;
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}