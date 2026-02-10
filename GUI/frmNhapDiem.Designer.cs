
namespace QuanLyDiemHocTap.GUI
{
    partial class frmNhapDiem
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelFilter;
        private System.Windows.Forms.GroupBox grpFilter;
        private System.Windows.Forms.Label lblNamHoc;
        private System.Windows.Forms.ComboBox cboNamHoc;
        private System.Windows.Forms.Label lblHocKy;
        private System.Windows.Forms.ComboBox cboHocKy;
        private System.Windows.Forms.Label lblLop;
        private System.Windows.Forms.ComboBox cboLop;
        private System.Windows.Forms.Label lblMonHoc;
        private System.Windows.Forms.ComboBox cboMonHoc;
        private System.Windows.Forms.Button btnTaiDanhSach;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.GroupBox grpDanhSach;
        private System.Windows.Forms.DataGridView dgvDanhSach;
        private System.Windows.Forms.Label lblTongSo;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.GroupBox grpNhapDiem;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label lblLoaiDiem;
        private System.Windows.Forms.ComboBox cboLoaiDiem;
        private System.Windows.Forms.Label lblDiem;
        private System.Windows.Forms.NumericUpDown nudDiem;
        private System.Windows.Forms.Label lblNgayNhap;
        private System.Windows.Forms.DateTimePicker dtpNgayNhap;
        private System.Windows.Forms.Label lblGhiChu;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;

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
            this.panelTop = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelFilter = new System.Windows.Forms.Panel();
            this.grpFilter = new System.Windows.Forms.GroupBox();
            this.btnTaiDanhSach = new System.Windows.Forms.Button();
            this.cboMonHoc = new System.Windows.Forms.ComboBox();
            this.lblMonHoc = new System.Windows.Forms.Label();
            this.cboLop = new System.Windows.Forms.ComboBox();
            this.lblLop = new System.Windows.Forms.Label();
            this.cboHocKy = new System.Windows.Forms.ComboBox();
            this.lblHocKy = new System.Windows.Forms.Label();
            this.cboNamHoc = new System.Windows.Forms.ComboBox();
            this.lblNamHoc = new System.Windows.Forms.Label();
            this.panelContent = new System.Windows.Forms.Panel();
            this.grpDanhSach = new System.Windows.Forms.GroupBox();
            this.dgvDanhSach = new System.Windows.Forms.DataGridView();
            this.lblTongSo = new System.Windows.Forms.Label();
            this.panelRight = new System.Windows.Forms.Panel();
            this.grpNhapDiem = new System.Windows.Forms.GroupBox();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.lblGhiChu = new System.Windows.Forms.Label();
            this.dtpNgayNhap = new System.Windows.Forms.DateTimePicker();
            this.lblNgayNhap = new System.Windows.Forms.Label();
            this.nudDiem = new System.Windows.Forms.NumericUpDown();
            this.lblDiem = new System.Windows.Forms.Label();
            this.cboLoaiDiem = new System.Windows.Forms.ComboBox();
            this.lblLoaiDiem = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.panelTop.SuspendLayout();
            this.panelFilter.SuspendLayout();
            this.grpFilter.SuspendLayout();
            this.panelContent.SuspendLayout();
            this.grpDanhSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).BeginInit();
            this.panelRight.SuspendLayout();
            this.grpNhapDiem.SuspendLayout();
            this.panelButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDiem)).BeginInit();
            this.SuspendLayout();

            // panelTop
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.panelTop.Controls.Add(this.lblTitle);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1200, 60);
            this.panelTop.TabIndex = 0;

            // lblTitle
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1200, 60);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "NHẬP ĐIỂM HỌC SINH";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // panelFilter
            this.panelFilter.Controls.Add(this.grpFilter);
            this.panelFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFilter.Location = new System.Drawing.Point(0, 60);
            this.panelFilter.Name = "panelFilter";
            this.panelFilter.Padding = new System.Windows.Forms.Padding(10);
            this.panelFilter.Size = new System.Drawing.Size(1200, 100);
            this.panelFilter.TabIndex = 1;

            // grpFilter
            this.grpFilter.Controls.Add(this.btnTaiDanhSach);
            this.grpFilter.Controls.Add(this.cboMonHoc);
            this.grpFilter.Controls.Add(this.lblMonHoc);
            this.grpFilter.Controls.Add(this.cboLop);
            this.grpFilter.Controls.Add(this.lblLop);
            this.grpFilter.Controls.Add(this.cboHocKy);
            this.grpFilter.Controls.Add(this.lblHocKy);
            this.grpFilter.Controls.Add(this.cboNamHoc);
            this.grpFilter.Controls.Add(this.lblNamHoc);
            this.grpFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpFilter.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpFilter.Location = new System.Drawing.Point(10, 10);
            this.grpFilter.Name = "grpFilter";
            this.grpFilter.Size = new System.Drawing.Size(1180, 80);
            this.grpFilter.TabIndex = 0;
            this.grpFilter.TabStop = false;
            this.grpFilter.Text = "Chọn lớp và môn học";

            // lblNamHoc
            this.lblNamHoc.AutoSize = true;
            this.lblNamHoc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblNamHoc.Location = new System.Drawing.Point(15, 25);
            this.lblNamHoc.Name = "lblNamHoc";
            this.lblNamHoc.Size = new System.Drawing.Size(60, 15);
            this.lblNamHoc.TabIndex = 0;
            this.lblNamHoc.Text = "Năm học:";

            // cboNamHoc
            this.cboNamHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNamHoc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cboNamHoc.FormattingEnabled = true;
            this.cboNamHoc.Location = new System.Drawing.Point(15, 45);
            this.cboNamHoc.Name = "cboNamHoc";
            this.cboNamHoc.Size = new System.Drawing.Size(200, 23);
            this.cboNamHoc.TabIndex = 1;
            this.cboNamHoc.SelectedIndexChanged += new System.EventHandler(this.cboNamHoc_SelectedIndexChanged);

            // lblHocKy
            this.lblHocKy.AutoSize = true;
            this.lblHocKy.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblHocKy.Location = new System.Drawing.Point(230, 25);
            this.lblHocKy.Name = "lblHocKy";
            this.lblHocKy.Size = new System.Drawing.Size(48, 15);
            this.lblHocKy.TabIndex = 2;
            this.lblHocKy.Text = "Học kỳ:";

            // cboHocKy
            this.cboHocKy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboHocKy.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cboHocKy.FormattingEnabled = true;
            this.cboHocKy.Location = new System.Drawing.Point(230, 45);
            this.cboHocKy.Name = "cboHocKy";
            this.cboHocKy.Size = new System.Drawing.Size(200, 23);
            this.cboHocKy.TabIndex = 3;
            this.cboHocKy.SelectedIndexChanged += new System.EventHandler(this.cboHocKy_SelectedIndexChanged);

            // lblLop
            this.lblLop.AutoSize = true;
            this.lblLop.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblLop.Location = new System.Drawing.Point(445, 25);
            this.lblLop.Name = "lblLop";
            this.lblLop.Size = new System.Drawing.Size(30, 15);
            this.lblLop.TabIndex = 4;
            this.lblLop.Text = "Lớp:";

            // cboLop
            this.cboLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLop.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cboLop.FormattingEnabled = true;
            this.cboLop.Location = new System.Drawing.Point(445, 45);
            this.cboLop.Name = "cboLop";
            this.cboLop.Size = new System.Drawing.Size(200, 23);
            this.cboLop.TabIndex = 5;
            this.cboLop.SelectedIndexChanged += new System.EventHandler(this.cboLop_SelectedIndexChanged);

            // lblMonHoc
            this.lblMonHoc.AutoSize = true;
            this.lblMonHoc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblMonHoc.Location = new System.Drawing.Point(660, 25);
            this.lblMonHoc.Name = "lblMonHoc";
            this.lblMonHoc.Size = new System.Drawing.Size(61, 15);
            this.lblMonHoc.TabIndex = 6;
            this.lblMonHoc.Text = "Môn học:";

            // cboMonHoc
            this.cboMonHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMonHoc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cboMonHoc.FormattingEnabled = true;
            this.cboMonHoc.Location = new System.Drawing.Point(660, 45);
            this.cboMonHoc.Name = "cboMonHoc";
            this.cboMonHoc.Size = new System.Drawing.Size(200, 23);
            this.cboMonHoc.TabIndex = 7;

            // btnTaiDanhSach
            this.btnTaiDanhSach.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnTaiDanhSach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTaiDanhSach.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnTaiDanhSach.ForeColor = System.Drawing.Color.White;
            this.btnTaiDanhSach.Location = new System.Drawing.Point(875, 35);
            this.btnTaiDanhSach.Name = "btnTaiDanhSach";
            this.btnTaiDanhSach.Size = new System.Drawing.Size(120, 35);
            this.btnTaiDanhSach.TabIndex = 8;
            this.btnTaiDanhSach.Text = "Tải danh sách";
            this.btnTaiDanhSach.UseVisualStyleBackColor = false;
            this.btnTaiDanhSach.Click += new System.EventHandler(this.btnTaiDanhSach_Click);

            // panelContent
            this.panelContent.Controls.Add(this.grpDanhSach);
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(0, 160);
            this.panelContent.Name = "panelContent";
            this.panelContent.Padding = new System.Windows.Forms.Padding(10, 0, 10, 10);
            this.panelContent.Size = new System.Drawing.Size(800, 540);
            this.panelContent.TabIndex = 2;

            // grpDanhSach
            this.grpDanhSach.Controls.Add(this.dgvDanhSach);
            this.grpDanhSach.Controls.Add(this.lblTongSo);
            this.grpDanhSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpDanhSach.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpDanhSach.Location = new System.Drawing.Point(10, 0);
            this.grpDanhSach.Name = "grpDanhSach";
            this.grpDanhSach.Padding = new System.Windows.Forms.Padding(10);
            this.grpDanhSach.Size = new System.Drawing.Size(780, 530);
            this.grpDanhSach.TabIndex = 0;
            this.grpDanhSach.TabStop = false;
            this.grpDanhSach.Text = "Danh sách học sinh";

            // lblTongSo
            this.lblTongSo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblTongSo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTongSo.Location = new System.Drawing.Point(10, 503);
            this.lblTongSo.Name = "lblTongSo";
            this.lblTongSo.Size = new System.Drawing.Size(760, 17);
            this.lblTongSo.TabIndex = 1;
            this.lblTongSo.Text = "Tổng số: 0 học sinh";

            // dgvDanhSach
            this.dgvDanhSach.AllowUserToAddRows = false;
            this.dgvDanhSach.AllowUserToDeleteRows = false;
            this.dgvDanhSach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhSach.BackgroundColor = System.Drawing.Color.White;
            this.dgvDanhSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDanhSach.Location = new System.Drawing.Point(10, 26);
            this.dgvDanhSach.MultiSelect = false;
            this.dgvDanhSach.Name = "dgvDanhSach";
            this.dgvDanhSach.ReadOnly = true;
            this.dgvDanhSach.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDanhSach.Size = new System.Drawing.Size(760, 477);
            this.dgvDanhSach.TabIndex = 0;
            this.dgvDanhSach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSach_CellClick);

            // panelRight
            this.panelRight.Controls.Add(this.grpNhapDiem);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelRight.Location = new System.Drawing.Point(800, 160);
            this.panelRight.Name = "panelRight";
            this.panelRight.Padding = new System.Windows.Forms.Padding(0, 0, 10, 10);
            this.panelRight.Size = new System.Drawing.Size(400, 540);
            this.panelRight.TabIndex = 3;

            // grpNhapDiem
            this.grpNhapDiem.Controls.Add(this.panelButtons);
            this.grpNhapDiem.Controls.Add(this.txtGhiChu);
            this.grpNhapDiem.Controls.Add(this.lblGhiChu);
            this.grpNhapDiem.Controls.Add(this.dtpNgayNhap);
            this.grpNhapDiem.Controls.Add(this.lblNgayNhap);
            this.grpNhapDiem.Controls.Add(this.nudDiem);
            this.grpNhapDiem.Controls.Add(this.lblDiem);
            this.grpNhapDiem.Controls.Add(this.cboLoaiDiem);
            this.grpNhapDiem.Controls.Add(this.lblLoaiDiem);
            this.grpNhapDiem.Controls.Add(this.txtHoTen);
            this.grpNhapDiem.Controls.Add(this.lblHoTen);
            this.grpNhapDiem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpNhapDiem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpNhapDiem.Location = new System.Drawing.Point(0, 0);
            this.grpNhapDiem.Name = "grpNhapDiem";
            this.grpNhapDiem.Padding = new System.Windows.Forms.Padding(10);
            this.grpNhapDiem.Size = new System.Drawing.Size(390, 530);
            this.grpNhapDiem.TabIndex = 0;
            this.grpNhapDiem.TabStop = false;
            this.grpNhapDiem.Text = "Thông tin điểm";

            // lblHoTen
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblHoTen.Location = new System.Drawing.Point(15, 30);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(71, 15);
            this.lblHoTen.TabIndex = 0;
            this.lblHoTen.Text = "Học sinh:";

            // txtHoTen
            this.txtHoTen.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtHoTen.Location = new System.Drawing.Point(15, 50);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.ReadOnly = true;
            this.txtHoTen.Size = new System.Drawing.Size(360, 23);
            this.txtHoTen.TabIndex = 1;

            // lblLoaiDiem
            this.lblLoaiDiem.AutoSize = true;
            this.lblLoaiDiem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblLoaiDiem.Location = new System.Drawing.Point(15, 90);
            this.lblLoaiDiem.Name = "lblLoaiDiem";
            this.lblLoaiDiem.Size = new System.Drawing.Size(64, 15);
            this.lblLoaiDiem.TabIndex = 2;
            this.lblLoaiDiem.Text = "Loại điểm:";

            // cboLoaiDiem
            this.cboLoaiDiem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLoaiDiem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cboLoaiDiem.FormattingEnabled = true;
            this.cboLoaiDiem.Location = new System.Drawing.Point(15, 110);
            this.cboLoaiDiem.Name = "cboLoaiDiem";
            this.cboLoaiDiem.Size = new System.Drawing.Size(360, 23);
            this.cboLoaiDiem.TabIndex = 3;

            // lblDiem
            this.lblDiem.AutoSize = true;
            this.lblDiem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblDiem.Location = new System.Drawing.Point(15, 150);
            this.lblDiem.Name = "lblDiem";
            this.lblDiem.Size = new System.Drawing.Size(39, 15);
            this.lblDiem.TabIndex = 4;
            this.lblDiem.Text = "Điểm:";

            // nudDiem
            this.nudDiem.DecimalPlaces = 1;
            this.nudDiem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nudDiem.Increment = new decimal(new int[] { 5, 0, 0, 65536 });
            this.nudDiem.Location = new System.Drawing.Point(15, 170);
            this.nudDiem.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            this.nudDiem.Name = "nudDiem";
            this.nudDiem.Size = new System.Drawing.Size(360, 23);
            this.nudDiem.TabIndex = 5;

            // lblNgayNhap
            this.lblNgayNhap.AutoSize = true;
            this.lblNgayNhap.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblNgayNhap.Location = new System.Drawing.Point(15, 210);
            this.lblNgayNhap.Name = "lblNgayNhap";
            this.lblNgayNhap.Size = new System.Drawing.Size(69, 15);
            this.lblNgayNhap.TabIndex = 6;
            this.lblNgayNhap.Text = "Ngày nhập:";

            // dtpNgayNhap
            this.dtpNgayNhap.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpNgayNhap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayNhap.Location = new System.Drawing.Point(15, 230);
            this.dtpNgayNhap.Name = "dtpNgayNhap";
            this.dtpNgayNhap.Size = new System.Drawing.Size(360, 23);
            this.dtpNgayNhap.TabIndex = 7;

            // lblGhiChu
            this.lblGhiChu.AutoSize = true;
            this.lblGhiChu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblGhiChu.Location = new System.Drawing.Point(15, 270);
            this.lblGhiChu.Name = "lblGhiChu";
            this.lblGhiChu.Size = new System.Drawing.Size(51, 15);
            this.lblGhiChu.TabIndex = 8;
            this.lblGhiChu.Text = "Ghi chú:";

            // txtGhiChu
            this.txtGhiChu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtGhiChu.Location = new System.Drawing.Point(15, 290);
            this.txtGhiChu.Multiline = true;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(360, 60);
            this.txtGhiChu.TabIndex = 9;

            // panelButtons
            this.panelButtons.Controls.Add(this.btnXoa);
            this.panelButtons.Controls.Add(this.btnSua);
            this.panelButtons.Controls.Add(this.btnThem);
            this.panelButtons.Location = new System.Drawing.Point(15, 370);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(360, 50);
            this.panelButtons.TabIndex = 10;

            // btnThem
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(5, 10);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(110, 35);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);

            // btnSua
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btnSua.Enabled = false;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(125, 10);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(110, 35);
            this.btnSua.TabIndex = 1;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);

            // btnXoa
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnXoa.Enabled = false;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(245, 10);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(110, 35);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);

            // frmNhapDiem
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.panelFilter);
            this.Controls.Add(this.panelTop);
            this.Name = "frmNhapDiem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhập điểm học sinh";
            this.panelTop.ResumeLayout(false);
            this.panelFilter.ResumeLayout(false);
            this.grpFilter.ResumeLayout(false);
            this.grpFilter.PerformLayout();
            this.panelContent.ResumeLayout(false);
            this.grpDanhSach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).EndInit();
            this.panelRight.ResumeLayout(false);
            this.grpNhapDiem.ResumeLayout(false);
            this.grpNhapDiem.PerformLayout();
            this.panelButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudDiem)).EndInit();
            this.ResumeLayout(false);
        }
    }
}