namespace QuanLyDiemHocTap.GUI
{
    partial class frmHocSinh
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.GroupBox grpThongTin;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.Label lblGioiTinh;
        private System.Windows.Forms.ComboBox cboGioiTinh;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label lblDienThoai;
        private System.Windows.Forms.TextBox txtDienThoai;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.GroupBox grpDanhSach;
        private System.Windows.Forms.DataGridView dgvHocSinh;
        private System.Windows.Forms.Panel panelSearch;
        private System.Windows.Forms.Label lblTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
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
            panelButtons = new Panel();
            btnLamMoi = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            grpThongTin = new GroupBox();
            txtEmail = new TextBox();
            lblEmail = new Label();
            txtDienThoai = new TextBox();
            lblDienThoai = new Label();
            txtDiaChi = new TextBox();
            lblDiaChi = new Label();
            cboGioiTinh = new ComboBox();
            lblGioiTinh = new Label();
            dtpNgaySinh = new DateTimePicker();
            lblNgaySinh = new Label();
            txtHoTen = new TextBox();
            lblHoTen = new Label();
            panelRight = new Panel();
            grpDanhSach = new GroupBox();
            dgvHocSinh = new DataGridView();
            panelSearch = new Panel();
            lblTongSo = new Label();
            txtTimKiem = new TextBox();
            lblTimKiem = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            panelTop.SuspendLayout();
            panelLeft.SuspendLayout();
            panelButtons.SuspendLayout();
            grpThongTin.SuspendLayout();
            panelRight.SuspendLayout();
            grpDanhSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHocSinh).BeginInit();
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
            lblTitle.Text = "QUẢN LÝ HỌC SINH";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelLeft
            // 
            panelLeft.Controls.Add(panelButtons);
            panelLeft.Controls.Add(grpThongTin);
            panelLeft.Dock = DockStyle.Left;
            panelLeft.Location = new Point(0, 115);
            panelLeft.Margin = new Padding(5, 6, 5, 6);
            panelLeft.Name = "panelLeft";
            panelLeft.Padding = new Padding(17, 19, 17, 19);
            panelLeft.Size = new Size(667, 1231);
            panelLeft.TabIndex = 1;
            // 
            // panelButtons
            // 
            panelButtons.Controls.Add(btnLamMoi);
            panelButtons.Controls.Add(btnXoa);
            panelButtons.Controls.Add(btnSua);
            panelButtons.Controls.Add(btnThem);
            panelButtons.Dock = DockStyle.Bottom;
            panelButtons.Location = new Point(17, 1058);
            panelButtons.Margin = new Padding(5, 6, 5, 6);
            panelButtons.Name = "panelButtons";
            panelButtons.Size = new Size(633, 154);
            panelButtons.TabIndex = 1;
            // 
            // btnLamMoi
            // 
            btnLamMoi.BackColor = Color.FromArgb(108, 117, 125);
            btnLamMoi.FlatStyle = FlatStyle.Flat;
            btnLamMoi.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnLamMoi.ForeColor = Color.White;
            btnLamMoi.Location = new Point(475, 29);
            btnLamMoi.Margin = new Padding(5, 6, 5, 6);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(133, 67);
            btnLamMoi.TabIndex = 3;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = false;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.FromArgb(220, 53, 69);
            btnXoa.Enabled = false;
            btnXoa.FlatStyle = FlatStyle.Flat;
            btnXoa.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnXoa.ForeColor = Color.White;
            btnXoa.Location = new Point(325, 29);
            btnXoa.Margin = new Padding(5, 6, 5, 6);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(133, 67);
            btnXoa.TabIndex = 2;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.FromArgb(0, 123, 255);
            btnSua.Enabled = false;
            btnSua.FlatStyle = FlatStyle.Flat;
            btnSua.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSua.ForeColor = Color.White;
            btnSua.Location = new Point(175, 29);
            btnSua.Margin = new Padding(5, 6, 5, 6);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(133, 67);
            btnSua.TabIndex = 1;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.FromArgb(40, 167, 69);
            btnThem.FlatStyle = FlatStyle.Flat;
            btnThem.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnThem.ForeColor = Color.White;
            btnThem.Location = new Point(25, 29);
            btnThem.Margin = new Padding(5, 6, 5, 6);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(133, 67);
            btnThem.TabIndex = 0;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // grpThongTin
            // 
            grpThongTin.Controls.Add(textBox1);
            grpThongTin.Controls.Add(label1);
            grpThongTin.Controls.Add(textBox2);
            grpThongTin.Controls.Add(label2);
            grpThongTin.Controls.Add(txtEmail);
            grpThongTin.Controls.Add(lblEmail);
            grpThongTin.Controls.Add(txtDienThoai);
            grpThongTin.Controls.Add(lblDienThoai);
            grpThongTin.Controls.Add(txtDiaChi);
            grpThongTin.Controls.Add(lblDiaChi);
            grpThongTin.Controls.Add(cboGioiTinh);
            grpThongTin.Controls.Add(lblGioiTinh);
            grpThongTin.Controls.Add(dtpNgaySinh);
            grpThongTin.Controls.Add(lblNgaySinh);
            grpThongTin.Controls.Add(txtHoTen);
            grpThongTin.Controls.Add(lblHoTen);
            grpThongTin.Dock = DockStyle.Fill;
            grpThongTin.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            grpThongTin.Location = new Point(17, 19);
            grpThongTin.Margin = new Padding(5, 6, 5, 6);
            grpThongTin.Name = "grpThongTin";
            grpThongTin.Padding = new Padding(17, 19, 17, 19);
            grpThongTin.Size = new Size(633, 1193);
            grpThongTin.TabIndex = 0;
            grpThongTin.TabStop = false;
            grpThongTin.Text = "Thông tin học sinh";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 9F);
            txtEmail.Location = new Point(25, 750);
            txtEmail.Margin = new Padding(5, 6, 5, 6);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(581, 31);
            txtEmail.TabIndex = 11;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 9F);
            lblEmail.Location = new Point(25, 712);
            lblEmail.Margin = new Padding(5, 0, 5, 0);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(58, 25);
            lblEmail.TabIndex = 10;
            lblEmail.Text = "Email:";
            // 
            // txtDienThoai
            // 
            txtDienThoai.Font = new Font("Segoe UI", 9F);
            txtDienThoai.Location = new Point(25, 635);
            txtDienThoai.Margin = new Padding(5, 6, 5, 6);
            txtDienThoai.Name = "txtDienThoai";
            txtDienThoai.Size = new Size(581, 31);
            txtDienThoai.TabIndex = 9;
            // 
            // lblDienThoai
            // 
            lblDienThoai.AutoSize = true;
            lblDienThoai.Font = new Font("Segoe UI", 9F);
            lblDienThoai.Location = new Point(25, 596);
            lblDienThoai.Margin = new Padding(5, 0, 5, 0);
            lblDienThoai.Name = "lblDienThoai";
            lblDienThoai.Size = new Size(97, 25);
            lblDienThoai.TabIndex = 8;
            lblDienThoai.Text = "Điện thoại:";
            // 
            // txtDiaChi
            // 
            txtDiaChi.Font = new Font("Segoe UI", 9F);
            txtDiaChi.Location = new Point(25, 452);
            txtDiaChi.Margin = new Padding(5, 6, 5, 6);
            txtDiaChi.Multiline = true;
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(581, 112);
            txtDiaChi.TabIndex = 7;
            // 
            // lblDiaChi
            // 
            lblDiaChi.AutoSize = true;
            lblDiaChi.Font = new Font("Segoe UI", 9F);
            lblDiaChi.Location = new Point(25, 413);
            lblDiaChi.Margin = new Padding(5, 0, 5, 0);
            lblDiaChi.Name = "lblDiaChi";
            lblDiaChi.Size = new Size(69, 25);
            lblDiaChi.TabIndex = 6;
            lblDiaChi.Text = "Địa chỉ:";
            // 
            // cboGioiTinh
            // 
            cboGioiTinh.DropDownStyle = ComboBoxStyle.DropDownList;
            cboGioiTinh.Font = new Font("Segoe UI", 9F);
            cboGioiTinh.FormattingEnabled = true;
            cboGioiTinh.Location = new Point(25, 337);
            cboGioiTinh.Margin = new Padding(5, 6, 5, 6);
            cboGioiTinh.Name = "cboGioiTinh";
            cboGioiTinh.Size = new Size(581, 33);
            cboGioiTinh.TabIndex = 5;
            // 
            // lblGioiTinh
            // 
            lblGioiTinh.AutoSize = true;
            lblGioiTinh.Font = new Font("Segoe UI", 9F);
            lblGioiTinh.Location = new Point(25, 298);
            lblGioiTinh.Margin = new Padding(5, 0, 5, 0);
            lblGioiTinh.Name = "lblGioiTinh";
            lblGioiTinh.Size = new Size(82, 25);
            lblGioiTinh.TabIndex = 4;
            lblGioiTinh.Text = "Giới tính:";
            // 
            // dtpNgaySinh
            // 
            dtpNgaySinh.Font = new Font("Segoe UI", 9F);
            dtpNgaySinh.Format = DateTimePickerFormat.Short;
            dtpNgaySinh.Location = new Point(25, 221);
            dtpNgaySinh.Margin = new Padding(5, 6, 5, 6);
            dtpNgaySinh.Name = "dtpNgaySinh";
            dtpNgaySinh.Size = new Size(581, 31);
            dtpNgaySinh.TabIndex = 3;
            // 
            // lblNgaySinh
            // 
            lblNgaySinh.AutoSize = true;
            lblNgaySinh.Font = new Font("Segoe UI", 9F);
            lblNgaySinh.Location = new Point(25, 183);
            lblNgaySinh.Margin = new Padding(5, 0, 5, 0);
            lblNgaySinh.Name = "lblNgaySinh";
            lblNgaySinh.Size = new Size(95, 25);
            lblNgaySinh.TabIndex = 2;
            lblNgaySinh.Text = "Ngày sinh:";
            // 
            // txtHoTen
            // 
            txtHoTen.Font = new Font("Segoe UI", 9F);
            txtHoTen.Location = new Point(25, 106);
            txtHoTen.Margin = new Padding(5, 6, 5, 6);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(581, 31);
            txtHoTen.TabIndex = 1;
            // 
            // lblHoTen
            // 
            lblHoTen.AutoSize = true;
            lblHoTen.Font = new Font("Segoe UI", 9F);
            lblHoTen.Location = new Point(25, 67);
            lblHoTen.Margin = new Padding(5, 0, 5, 0);
            lblHoTen.Name = "lblHoTen";
            lblHoTen.Size = new Size(93, 25);
            lblHoTen.TabIndex = 0;
            lblHoTen.Text = "Họ và tên:";
            // 
            // panelRight
            // 
            panelRight.Controls.Add(grpDanhSach);
            panelRight.Dock = DockStyle.Fill;
            panelRight.Location = new Point(667, 115);
            panelRight.Margin = new Padding(5, 6, 5, 6);
            panelRight.Name = "panelRight";
            panelRight.Padding = new Padding(17, 19, 17, 19);
            panelRight.Size = new Size(1333, 1231);
            panelRight.TabIndex = 2;
            // 
            // grpDanhSach
            // 
            grpDanhSach.Controls.Add(dgvHocSinh);
            grpDanhSach.Controls.Add(panelSearch);
            grpDanhSach.Dock = DockStyle.Fill;
            grpDanhSach.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            grpDanhSach.Location = new Point(17, 19);
            grpDanhSach.Margin = new Padding(5, 6, 5, 6);
            grpDanhSach.Name = "grpDanhSach";
            grpDanhSach.Padding = new Padding(17, 19, 17, 19);
            grpDanhSach.Size = new Size(1299, 1193);
            grpDanhSach.TabIndex = 0;
            grpDanhSach.TabStop = false;
            grpDanhSach.Text = "Danh sách học sinh";
            // 
            // dgvHocSinh
            // 
            dgvHocSinh.AllowUserToAddRows = false;
            dgvHocSinh.AllowUserToDeleteRows = false;
            dgvHocSinh.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHocSinh.BackgroundColor = Color.White;
            dgvHocSinh.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHocSinh.Dock = DockStyle.Fill;
            dgvHocSinh.Location = new Point(17, 142);
            dgvHocSinh.Margin = new Padding(5, 6, 5, 6);
            dgvHocSinh.MultiSelect = false;
            dgvHocSinh.Name = "dgvHocSinh";
            dgvHocSinh.ReadOnly = true;
            dgvHocSinh.RowHeadersWidth = 62;
            dgvHocSinh.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvHocSinh.Size = new Size(1265, 1032);
            dgvHocSinh.TabIndex = 1;
            dgvHocSinh.CellClick += dgvHocSinh_CellClick;
            // 
            // panelSearch
            // 
            panelSearch.Controls.Add(lblTongSo);
            panelSearch.Controls.Add(txtTimKiem);
            panelSearch.Controls.Add(lblTimKiem);
            panelSearch.Dock = DockStyle.Top;
            panelSearch.Location = new Point(17, 46);
            panelSearch.Margin = new Padding(5, 6, 5, 6);
            panelSearch.Name = "panelSearch";
            panelSearch.Size = new Size(1265, 96);
            panelSearch.TabIndex = 0;
            // 
            // lblTongSo
            // 
            lblTongSo.AutoSize = true;
            lblTongSo.Font = new Font("Segoe UI", 9F);
            lblTongSo.Location = new Point(667, 29);
            lblTongSo.Margin = new Padding(5, 0, 5, 0);
            lblTongSo.Name = "lblTongSo";
            lblTongSo.Size = new Size(167, 25);
            lblTongSo.TabIndex = 2;
            lblTongSo.Text = "Tổng số: 0 học sinh";
            // 
            // txtTimKiem
            // 
            txtTimKiem.Font = new Font("Segoe UI", 9F);
            txtTimKiem.Location = new Point(125, 23);
            txtTimKiem.Margin = new Padding(5, 6, 5, 6);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(497, 31);
            txtTimKiem.TabIndex = 1;
            txtTimKiem.TextChanged += txtTimKiem_TextChanged;
            // 
            // lblTimKiem
            // 
            lblTimKiem.AutoSize = true;
            lblTimKiem.Font = new Font("Segoe UI", 9F);
            lblTimKiem.Location = new Point(17, 29);
            lblTimKiem.Margin = new Padding(5, 0, 5, 0);
            lblTimKiem.Name = "lblTimKiem";
            lblTimKiem.Size = new Size(88, 25);
            lblTimKiem.TabIndex = 0;
            lblTimKiem.Text = "Tìm kiếm:";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 9F);
            textBox1.Location = new Point(22, 963);
            textBox1.Margin = new Padding(5, 6, 5, 6);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(581, 31);
            textBox1.TabIndex = 15;
            textBox1.Text = "a";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F);
            label1.Location = new Point(22, 925);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(21, 25);
            label1.TabIndex = 14;
            label1.Text = "a";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 9F);
            textBox2.Location = new Point(22, 848);
            textBox2.Margin = new Padding(5, 6, 5, 6);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(581, 31);
            textBox2.TabIndex = 13;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F);
            label2.Location = new Point(22, 809);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(21, 25);
            label2.TabIndex = 12;
            label2.Text = "a";
            // 
            // frmHocSinh
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2000, 1346);
            Controls.Add(panelRight);
            Controls.Add(panelLeft);
            Controls.Add(panelTop);
            Margin = new Padding(5, 6, 5, 6);
            Name = "frmHocSinh";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý học sinh";
            panelTop.ResumeLayout(false);
            panelLeft.ResumeLayout(false);
            panelButtons.ResumeLayout(false);
            grpThongTin.ResumeLayout(false);
            grpThongTin.PerformLayout();
            panelRight.ResumeLayout(false);
            grpDanhSach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvHocSinh).EndInit();
            panelSearch.ResumeLayout(false);
            panelSearch.PerformLayout();
            ResumeLayout(false);
        }
        private TextBox textBox1;
        private Label label1;
        private TextBox textBox2;
        private Label label2;
    }
}