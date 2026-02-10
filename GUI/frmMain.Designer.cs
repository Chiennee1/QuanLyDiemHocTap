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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.mnuHeThong = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQuanLyTaiKhoan = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDoiMatKhau = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDanhMuc = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHocSinh = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuGiaoVien = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLop = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMonHoc = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPhanLop = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPhanCong = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQuanLyDiem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNhapDiem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuXemDiem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTongKet = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBaoCao = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBaoCaoLop = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBaoCaoHocSinh = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.lblNguoiDung = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblThoiGian = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();

            // menuStrip
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.mnuHeThong,
                this.mnuDanhMuc,
                this.mnuQuanLyDiem,
                this.mnuBaoCao});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1200, 24);
            this.menuStrip.TabIndex = 0;

            // mnuHeThong
            this.mnuHeThong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.mnuQuanLyTaiKhoan,
                this.mnuDoiMatKhau,
                this.mnuDangXuat,
                this.mnuThoat});
            this.mnuHeThong.Name = "mnuHeThong";
            this.mnuHeThong.Size = new System.Drawing.Size(69, 20);
            this.mnuHeThong.Text = "Hệ thống";

            // mnuQuanLyTaiKhoan
            this.mnuQuanLyTaiKhoan.Name = "mnuQuanLyTaiKhoan";
            this.mnuQuanLyTaiKhoan.Size = new System.Drawing.Size(180, 22);
            this.mnuQuanLyTaiKhoan.Text = "Quản lý tài khoản";
            this.mnuQuanLyTaiKhoan.Click += new System.EventHandler(this.mnuQuanLyTaiKhoan_Click);

            // mnuDoiMatKhau
            this.mnuDoiMatKhau.Name = "mnuDoiMatKhau";
            this.mnuDoiMatKhau.Size = new System.Drawing.Size(180, 22);
            this.mnuDoiMatKhau.Text = "Đổi mật khẩu";
            this.mnuDoiMatKhau.Click += new System.EventHandler(this.mnuDoiMatKhau_Click);

            // mnuDangXuat
            this.mnuDangXuat.Name = "mnuDangXuat";
            this.mnuDangXuat.Size = new System.Drawing.Size(180, 22);
            this.mnuDangXuat.Text = "Đăng xuất";
            this.mnuDangXuat.Click += new System.EventHandler(this.mnuDangXuat_Click);

            // mnuThoat
            this.mnuThoat.Name = "mnuThoat";
            this.mnuThoat.Size = new System.Drawing.Size(180, 22);
            this.mnuThoat.Text = "Đăng xuất";
            this.mnuThoat.Click += new System.EventHandler(this.mnuThoat_Click);

            // mnuDanhMuc
            this.mnuDanhMuc.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.mnuHocSinh,
                this.mnuGiaoVien,
                this.mnuLop,
                this.mnuMonHoc,
                this.mnuPhanLop,
                this.mnuPhanCong});
            this.mnuDanhMuc.Name = "mnuDanhMuc";
            this.mnuDanhMuc.Size = new System.Drawing.Size(74, 20);
            this.mnuDanhMuc.Text = "Danh mục";

            // mnuHocSinh
            this.mnuHocSinh.Name = "mnuHocSinh";
            this.mnuHocSinh.Size = new System.Drawing.Size(200, 22);
            this.mnuHocSinh.Text = "Quản lý học sinh";
            this.mnuHocSinh.Click += new System.EventHandler(this.mnuHocSinh_Click);

            // mnuGiaoVien
            this.mnuGiaoVien.Name = "mnuGiaoVien";
            this.mnuGiaoVien.Size = new System.Drawing.Size(200, 22);
            this.mnuGiaoVien.Text = "Quản lý giáo viên";
            this.mnuGiaoVien.Click += new System.EventHandler(this.mnuGiaoVien_Click);

            // mnuLop
            this.mnuLop.Name = "mnuLop";
            this.mnuLop.Size = new System.Drawing.Size(200, 22);
            this.mnuLop.Text = "Quản lý lớp";
            this.mnuLop.Click += new System.EventHandler(this.mnuLop_Click);

            // mnuMonHoc
            this.mnuMonHoc.Name = "mnuMonHoc";
            this.mnuMonHoc.Size = new System.Drawing.Size(200, 22);
            this.mnuMonHoc.Text = "Quản lý môn học";
            this.mnuMonHoc.Click += new System.EventHandler(this.mnuMonHoc_Click);

            // mnuPhanLop
            this.mnuPhanLop.Name = "mnuPhanLop";
            this.mnuPhanLop.Size = new System.Drawing.Size(200, 22);
            this.mnuPhanLop.Text = "Phân lớp";
            this.mnuPhanLop.Click += new System.EventHandler(this.mnuPhanLop_Click);

            // mnuPhanCong
            this.mnuPhanCong.Name = "mnuPhanCong";
            this.mnuPhanCong.Size = new System.Drawing.Size(200, 22);
            this.mnuPhanCong.Text = "Phân công giảng dạy";
            this.mnuPhanCong.Click += new System.EventHandler(this.mnuPhanCong_Click);

            // mnuQuanLyDiem
            this.mnuQuanLyDiem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.mnuNhapDiem,
                this.mnuXemDiem,
                this.mnuTongKet});
            this.mnuQuanLyDiem.Name = "mnuQuanLyDiem";
            this.mnuQuanLyDiem.Size = new System.Drawing.Size(95, 20);
            this.mnuQuanLyDiem.Text = "Quản lý điểm";

            // mnuNhapDiem
            this.mnuNhapDiem.Name = "mnuNhapDiem";
            this.mnuNhapDiem.Size = new System.Drawing.Size(180, 22);
            this.mnuNhapDiem.Text = "Nhập điểm";
            this.mnuNhapDiem.Click += new System.EventHandler(this.mnuNhapDiem_Click);

            // mnuXemDiem
            this.mnuXemDiem.Name = "mnuXemDiem";
            this.mnuXemDiem.Size = new System.Drawing.Size(180, 22);
            this.mnuXemDiem.Text = "Xem điểm";
            this.mnuXemDiem.Click += new System.EventHandler(this.mnuXemDiem_Click);

            // mnuTongKet
            this.mnuTongKet.Name = "mnuTongKet";
            this.mnuTongKet.Size = new System.Drawing.Size(180, 22);
            this.mnuTongKet.Text = "Tổng kết học kỳ";
            this.mnuTongKet.Click += new System.EventHandler(this.mnuTongKet_Click);

            // mnuBaoCao
            this.mnuBaoCao.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.mnuBaoCaoLop,
                this.mnuBaoCaoHocSinh});
            this.mnuBaoCao.Name = "mnuBaoCao";
            this.mnuBaoCao.Size = new System.Drawing.Size(61, 20);
            this.mnuBaoCao.Text = "Báo cáo";

            // mnuBaoCaoLop
            this.mnuBaoCaoLop.Name = "mnuBaoCaoLop";
            this.mnuBaoCaoLop.Size = new System.Drawing.Size(180, 22);
            this.mnuBaoCaoLop.Text = "Báo cáo theo lớp";
            this.mnuBaoCaoLop.Click += new System.EventHandler(this.mnuBaoCaoLop_Click);

            // mnuBaoCaoHocSinh
            this.mnuBaoCaoHocSinh.Name = "mnuBaoCaoHocSinh";
            this.mnuBaoCaoHocSinh.Size = new System.Drawing.Size(180, 22);
            this.mnuBaoCaoHocSinh.Text = "Báo cáo học sinh";
            this.mnuBaoCaoHocSinh.Click += new System.EventHandler(this.mnuBaoCaoHocSinh_Click);

            // statusStrip
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.lblNguoiDung,
                this.lblThoiGian});
            this.statusStrip.Location = new System.Drawing.Point(0, 726);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1200, 22);
            this.statusStrip.TabIndex = 1;

            // lblNguoiDung
            this.lblNguoiDung.Name = "lblNguoiDung";
            this.lblNguoiDung.Size = new System.Drawing.Size(90, 17);
            this.lblNguoiDung.Text = "Người dùng: ";

            // lblThoiGian
            this.lblThoiGian.Name = "lblThoiGian";
            this.lblThoiGian.Size = new System.Drawing.Size(1095, 17);
            this.lblThoiGian.Spring = true;
            this.lblThoiGian.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            // frmMain
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 748);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hệ thống Quản lý điểm THCS";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}