namespace QuanLyDiemHocTap.GUI
{
    partial class frmQuanLyTaiKhoan
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.GroupBox grpThongTin;
        private System.Windows.Forms.Label lblTenDangNhap;
        private System.Windows.Forms.TextBox txtTenDangNhap;
        private System.Windows.Forms.Label lblMatKhau;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.Label lblLoaiTaiKhoan;
        private System.Windows.Forms.ComboBox cboLoaiTaiKhoan;
        private System.Windows.Forms.Label lblNguoiDung;
        private System.Windows.Forms.ComboBox cboNguoiDung;
        private System.Windows.Forms.Label lblTrangThai;
        private System.Windows.Forms.CheckBox chkTrangThai;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnDoiMatKhau;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.GroupBox grpDanhSach;
        private System.Windows.Forms.Panel panelSearch;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.DataGridView dgvTaiKhoan;
        private System.Windows.Forms.Label lblTongSo;

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
            panelTop = new Panel();
            lblTitle = new Label();
            panelLeft = new Panel();
            grpThongTin = new GroupBox();
            chkTrangThai = new CheckBox();
            lblTrangThai = new Label();
            cboNguoiDung = new ComboBox();
            lblNguoiDung = new Label();
            cboLoaiTaiKhoan = new ComboBox();
            lblLoaiTaiKhoan = new Label();
            txtMatKhau = new TextBox();
            lblMatKhau = new Label();
            txtTenDangNhap = new TextBox();
            lblTenDangNhap = new Label();
            panelButtons = new Panel();
            btnLamMoi = new Button();
            btnDoiMatKhau = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            panelRight = new Panel();
            grpDanhSach = new GroupBox();
            dgvTaiKhoan = new DataGridView();
            lblTongSo = new Label();
            panelSearch = new Panel();
            btnTimKiem = new Button();
            txtTimKiem = new TextBox();
            panelTop.SuspendLayout();
            panelLeft.SuspendLayout();
            grpThongTin.SuspendLayout();
            panelButtons.SuspendLayout();
            panelRight.SuspendLayout();
            grpDanhSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTaiKhoan).BeginInit();
            panelSearch.SuspendLayout();
            SuspendLayout();
            // 
            // panelTop
            // 
            panelTop.BackColor = Color.FromArgb(0, 123, 255);
            panelTop.Controls.Add(lblTitle);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Margin = new Padding(5, 6, 5, 6);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(2000, 115);
            panelTop.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.Dock = DockStyle.Fill;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(0, 0);
            lblTitle.Margin = new Padding(5, 0, 5, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(2000, 115);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "QUẢN LÝ TÀI KHOẢN";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelLeft
            // 
            panelLeft.Controls.Add(grpThongTin);
            panelLeft.Controls.Add(panelButtons);
            panelLeft.Dock = DockStyle.Left;
            panelLeft.Location = new Point(0, 115);
            panelLeft.Margin = new Padding(5, 6, 5, 6);
            panelLeft.Name = "panelLeft";
            panelLeft.Padding = new Padding(17, 19, 17, 19);
            panelLeft.Size = new Size(667, 1231);
            panelLeft.TabIndex = 1;
            // 
            // grpThongTin
            // 
            grpThongTin.Controls.Add(chkTrangThai);
            grpThongTin.Controls.Add(lblTrangThai);
            grpThongTin.Controls.Add(cboNguoiDung);
            grpThongTin.Controls.Add(lblNguoiDung);
            grpThongTin.Controls.Add(cboLoaiTaiKhoan);
            grpThongTin.Controls.Add(lblLoaiTaiKhoan);
            grpThongTin.Controls.Add(txtMatKhau);
            grpThongTin.Controls.Add(lblMatKhau);
            grpThongTin.Controls.Add(txtTenDangNhap);
            grpThongTin.Controls.Add(lblTenDangNhap);
            grpThongTin.Dock = DockStyle.Fill;
            grpThongTin.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            grpThongTin.Location = new Point(17, 19);
            grpThongTin.Margin = new Padding(5, 6, 5, 6);
            grpThongTin.Name = "grpThongTin";
            grpThongTin.Padding = new Padding(17, 19, 17, 19);
            grpThongTin.Size = new Size(633, 866);
            grpThongTin.TabIndex = 0;
            grpThongTin.TabStop = false;
            grpThongTin.Text = "Thông tin tài khoản";
            // 
            // chkTrangThai
            // 
            chkTrangThai.AutoSize = true;
            chkTrangThai.Checked = true;
            chkTrangThai.CheckState = CheckState.Checked;
            chkTrangThai.Font = new Font("Segoe UI", 9F);
            chkTrangThai.Location = new Point(25, 577);
            chkTrangThai.Margin = new Padding(5, 6, 5, 6);
            chkTrangThai.Name = "chkTrangThai";
            chkTrangThai.Size = new Size(125, 29);
            chkTrangThai.TabIndex = 9;
            chkTrangThai.Text = "Hoạt động";
            chkTrangThai.UseVisualStyleBackColor = true;
            // 
            // lblTrangThai
            // 
            lblTrangThai.AutoSize = true;
            lblTrangThai.Font = new Font("Segoe UI", 9F);
            lblTrangThai.Location = new Point(25, 529);
            lblTrangThai.Margin = new Padding(5, 0, 5, 0);
            lblTrangThai.Name = "lblTrangThai";
            lblTrangThai.Size = new Size(93, 25);
            lblTrangThai.TabIndex = 8;
            lblTrangThai.Text = "Trạng thái:";
            // 
            // cboNguoiDung
            // 
            cboNguoiDung.DropDownStyle = ComboBoxStyle.DropDownList;
            cboNguoiDung.Font = new Font("Segoe UI", 9F);
            cboNguoiDung.FormattingEnabled = true;
            cboNguoiDung.Location = new Point(25, 452);
            cboNguoiDung.Margin = new Padding(5, 6, 5, 6);
            cboNguoiDung.Name = "cboNguoiDung";
            cboNguoiDung.Size = new Size(581, 33);
            cboNguoiDung.TabIndex = 7;
            // 
            // lblNguoiDung
            // 
            lblNguoiDung.AutoSize = true;
            lblNguoiDung.Font = new Font("Segoe UI", 9F);
            lblNguoiDung.Location = new Point(25, 413);
            lblNguoiDung.Margin = new Padding(5, 0, 5, 0);
            lblNguoiDung.Name = "lblNguoiDung";
            lblNguoiDung.Size = new Size(113, 25);
            lblNguoiDung.TabIndex = 6;
            lblNguoiDung.Text = "Người dùng:";
            // 
            // cboLoaiTaiKhoan
            // 
            cboLoaiTaiKhoan.DropDownStyle = ComboBoxStyle.DropDownList;
            cboLoaiTaiKhoan.Font = new Font("Segoe UI", 9F);
            cboLoaiTaiKhoan.FormattingEnabled = true;
            cboLoaiTaiKhoan.Items.AddRange(new object[] { "Admin", "GiaoVien", "HocSinh" });
            cboLoaiTaiKhoan.Location = new Point(25, 337);
            cboLoaiTaiKhoan.Margin = new Padding(5, 6, 5, 6);
            cboLoaiTaiKhoan.Name = "cboLoaiTaiKhoan";
            cboLoaiTaiKhoan.Size = new Size(581, 33);
            cboLoaiTaiKhoan.TabIndex = 5;
            cboLoaiTaiKhoan.SelectedIndexChanged += cboLoaiTaiKhoan_SelectedIndexChanged;
            // 
            // lblLoaiTaiKhoan
            // 
            lblLoaiTaiKhoan.AutoSize = true;
            lblLoaiTaiKhoan.Font = new Font("Segoe UI", 9F);
            lblLoaiTaiKhoan.Location = new Point(25, 298);
            lblLoaiTaiKhoan.Margin = new Padding(5, 0, 5, 0);
            lblLoaiTaiKhoan.Name = "lblLoaiTaiKhoan";
            lblLoaiTaiKhoan.Size = new Size(126, 25);
            lblLoaiTaiKhoan.TabIndex = 4;
            lblLoaiTaiKhoan.Text = "Loại tài khoản:";
            // 
            // txtMatKhau
            // 
            txtMatKhau.Font = new Font("Segoe UI", 9F);
            txtMatKhau.Location = new Point(25, 221);
            txtMatKhau.Margin = new Padding(5, 6, 5, 6);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.PasswordChar = '●';
            txtMatKhau.Size = new Size(581, 31);
            txtMatKhau.TabIndex = 3;
            // 
            // lblMatKhau
            // 
            lblMatKhau.AutoSize = true;
            lblMatKhau.Font = new Font("Segoe UI", 9F);
            lblMatKhau.Location = new Point(25, 183);
            lblMatKhau.Margin = new Padding(5, 0, 5, 0);
            lblMatKhau.Name = "lblMatKhau";
            lblMatKhau.Size = new Size(90, 25);
            lblMatKhau.TabIndex = 2;
            lblMatKhau.Text = "Mật khẩu:";
            // 
            // txtTenDangNhap
            // 
            txtTenDangNhap.Font = new Font("Segoe UI", 9F);
            txtTenDangNhap.Location = new Point(25, 106);
            txtTenDangNhap.Margin = new Padding(5, 6, 5, 6);
            txtTenDangNhap.Name = "txtTenDangNhap";
            txtTenDangNhap.Size = new Size(581, 31);
            txtTenDangNhap.TabIndex = 1;
            // 
            // lblTenDangNhap
            // 
            lblTenDangNhap.AutoSize = true;
            lblTenDangNhap.Font = new Font("Segoe UI", 9F);
            lblTenDangNhap.Location = new Point(25, 67);
            lblTenDangNhap.Margin = new Padding(5, 0, 5, 0);
            lblTenDangNhap.Name = "lblTenDangNhap";
            lblTenDangNhap.Size = new Size(133, 25);
            lblTenDangNhap.TabIndex = 0;
            lblTenDangNhap.Text = "Tên đăng nhập:";
            // 
            // panelButtons
            // 
            panelButtons.Controls.Add(btnLamMoi);
            panelButtons.Controls.Add(btnDoiMatKhau);
            panelButtons.Controls.Add(btnXoa);
            panelButtons.Controls.Add(btnSua);
            panelButtons.Controls.Add(btnThem);
            panelButtons.Dock = DockStyle.Bottom;
            panelButtons.Location = new Point(17, 885);
            panelButtons.Margin = new Padding(5, 6, 5, 6);
            panelButtons.Name = "panelButtons";
            panelButtons.Padding = new Padding(17, 0, 17, 19);
            panelButtons.Size = new Size(633, 327);
            panelButtons.TabIndex = 1;
            // 
            // btnLamMoi
            // 
            btnLamMoi.BackColor = Color.FromArgb(108, 117, 125);
            btnLamMoi.Dock = DockStyle.Top;
            btnLamMoi.FlatStyle = FlatStyle.Flat;
            btnLamMoi.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnLamMoi.ForeColor = Color.White;
            btnLamMoi.Location = new Point(17, 268);
            btnLamMoi.Margin = new Padding(5, 6, 5, 6);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(599, 67);
            btnLamMoi.TabIndex = 4;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = false;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // btnDoiMatKhau
            // 
            btnDoiMatKhau.BackColor = Color.FromArgb(23, 162, 184);
            btnDoiMatKhau.Dock = DockStyle.Top;
            btnDoiMatKhau.Enabled = false;
            btnDoiMatKhau.FlatStyle = FlatStyle.Flat;
            btnDoiMatKhau.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnDoiMatKhau.ForeColor = Color.White;
            btnDoiMatKhau.Location = new Point(17, 201);
            btnDoiMatKhau.Margin = new Padding(5, 6, 5, 6);
            btnDoiMatKhau.Name = "btnDoiMatKhau";
            btnDoiMatKhau.Size = new Size(599, 67);
            btnDoiMatKhau.TabIndex = 3;
            btnDoiMatKhau.Text = "Đổi mật khẩu";
            btnDoiMatKhau.UseVisualStyleBackColor = false;
            btnDoiMatKhau.Click += btnDoiMatKhau_Click;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.FromArgb(220, 53, 69);
            btnXoa.Dock = DockStyle.Top;
            btnXoa.Enabled = false;
            btnXoa.FlatStyle = FlatStyle.Flat;
            btnXoa.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnXoa.ForeColor = Color.White;
            btnXoa.Location = new Point(17, 134);
            btnXoa.Margin = new Padding(5, 6, 5, 6);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(599, 67);
            btnXoa.TabIndex = 2;
            btnXoa.Text = "Xóa tài khoản";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.FromArgb(255, 193, 7);
            btnSua.Dock = DockStyle.Top;
            btnSua.Enabled = false;
            btnSua.FlatStyle = FlatStyle.Flat;
            btnSua.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSua.ForeColor = Color.Black;
            btnSua.Location = new Point(17, 67);
            btnSua.Margin = new Padding(5, 6, 5, 6);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(599, 67);
            btnSua.TabIndex = 1;
            btnSua.Text = "Cập nhật thông tin";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.FromArgb(40, 167, 69);
            btnThem.Dock = DockStyle.Top;
            btnThem.FlatStyle = FlatStyle.Flat;
            btnThem.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnThem.ForeColor = Color.White;
            btnThem.Location = new Point(17, 0);
            btnThem.Margin = new Padding(5, 6, 5, 6);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(599, 67);
            btnThem.TabIndex = 0;
            btnThem.Text = "Thêm tài khoản";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // panelRight
            // 
            panelRight.Controls.Add(grpDanhSach);
            panelRight.Dock = DockStyle.Fill;
            panelRight.Location = new Point(667, 115);
            panelRight.Margin = new Padding(5, 6, 5, 6);
            panelRight.Name = "panelRight";
            panelRight.Padding = new Padding(0, 19, 17, 19);
            panelRight.Size = new Size(1333, 1231);
            panelRight.TabIndex = 2;
            // 
            // grpDanhSach
            // 
            grpDanhSach.Controls.Add(dgvTaiKhoan);
            grpDanhSach.Controls.Add(lblTongSo);
            grpDanhSach.Controls.Add(panelSearch);
            grpDanhSach.Dock = DockStyle.Fill;
            grpDanhSach.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            grpDanhSach.Location = new Point(0, 19);
            grpDanhSach.Margin = new Padding(5, 6, 5, 6);
            grpDanhSach.Name = "grpDanhSach";
            grpDanhSach.Padding = new Padding(17, 19, 17, 19);
            grpDanhSach.Size = new Size(1316, 1193);
            grpDanhSach.TabIndex = 0;
            grpDanhSach.TabStop = false;
            grpDanhSach.Text = "Danh sách tài khoản";
            // 
            // dgvTaiKhoan
            // 
            dgvTaiKhoan.AllowUserToAddRows = false;
            dgvTaiKhoan.AllowUserToDeleteRows = false;
            dgvTaiKhoan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTaiKhoan.BackgroundColor = Color.White;
            dgvTaiKhoan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTaiKhoan.Dock = DockStyle.Fill;
            dgvTaiKhoan.Location = new Point(17, 133);
            dgvTaiKhoan.Margin = new Padding(5, 6, 5, 6);
            dgvTaiKhoan.Name = "dgvTaiKhoan";
            dgvTaiKhoan.ReadOnly = true;
            dgvTaiKhoan.RowHeadersWidth = 62;
            dgvTaiKhoan.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTaiKhoan.Size = new Size(1282, 983);
            dgvTaiKhoan.TabIndex = 1;
            dgvTaiKhoan.CellClick += dgvTaiKhoan_CellClick;
            // 
            // lblTongSo
            // 
            lblTongSo.Dock = DockStyle.Bottom;
            lblTongSo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTongSo.Location = new Point(17, 1116);
            lblTongSo.Margin = new Padding(5, 0, 5, 0);
            lblTongSo.Name = "lblTongSo";
            lblTongSo.Padding = new Padding(0, 10, 0, 10);
            lblTongSo.Size = new Size(1282, 58);
            lblTongSo.TabIndex = 2;
            lblTongSo.Text = "Tổng số: 0 tài khoản";
            // 
            // panelSearch
            // 
            panelSearch.Controls.Add(btnTimKiem);
            panelSearch.Controls.Add(txtTimKiem);
            panelSearch.Dock = DockStyle.Top;
            panelSearch.Location = new Point(17, 46);
            panelSearch.Margin = new Padding(5, 6, 5, 6);
            panelSearch.Name = "panelSearch";
            panelSearch.Padding = new Padding(0, 0, 0, 19);
            panelSearch.Size = new Size(1282, 87);
            panelSearch.TabIndex = 0;
            // 
            // btnTimKiem
            // 
            btnTimKiem.BackColor = Color.FromArgb(0, 123, 255);
            btnTimKiem.Dock = DockStyle.Right;
            btnTimKiem.FlatStyle = FlatStyle.Flat;
            btnTimKiem.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnTimKiem.ForeColor = Color.White;
            btnTimKiem.Location = new Point(1082, 0);
            btnTimKiem.Margin = new Padding(5, 6, 5, 6);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(200, 68);
            btnTimKiem.TabIndex = 1;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = false;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Dock = DockStyle.Fill;
            txtTimKiem.Font = new Font("Segoe UI", 9F);
            txtTimKiem.Location = new Point(0, 0);
            txtTimKiem.Margin = new Padding(5, 6, 5, 6);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.PlaceholderText = "Nhập tên đăng nhập hoặc họ tên để tìm kiếm...";
            txtTimKiem.Size = new Size(1282, 31);
            txtTimKiem.TabIndex = 0;
            // 
            // frmQuanLyTaiKhoan
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2000, 1346);
            Controls.Add(panelRight);
            Controls.Add(panelLeft);
            Controls.Add(panelTop);
            Margin = new Padding(5, 6, 5, 6);
            Name = "frmQuanLyTaiKhoan";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý tài khoản";
            panelTop.ResumeLayout(false);
            panelLeft.ResumeLayout(false);
            grpThongTin.ResumeLayout(false);
            grpThongTin.PerformLayout();
            panelButtons.ResumeLayout(false);
            panelRight.ResumeLayout(false);
            grpDanhSach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvTaiKhoan).EndInit();
            panelSearch.ResumeLayout(false);
            panelSearch.PerformLayout();
            ResumeLayout(false);
        }
    }
}