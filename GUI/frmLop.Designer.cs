
namespace QuanLyDiemHocTap.GUI
{
    partial class frmLop
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.GroupBox grpThongTin;
        private System.Windows.Forms.Label lblTenLop;
        private System.Windows.Forms.TextBox txtTenLop;
        private System.Windows.Forms.Label lblKhoi;
        private System.Windows.Forms.ComboBox cboKhoi;
        private System.Windows.Forms.Label lblNamHoc;
        private System.Windows.Forms.ComboBox cboNamHoc;
        private System.Windows.Forms.Label lblGVCN;
        private System.Windows.Forms.ComboBox cboGVCN;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.GroupBox grpDanhSach;
        private System.Windows.Forms.DataGridView dgvLop;
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
            cboGVCN = new ComboBox();
            lblGVCN = new Label();
            cboNamHoc = new ComboBox();
            lblNamHoc = new Label();
            cboKhoi = new ComboBox();
            lblKhoi = new Label();
            txtTenLop = new TextBox();
            lblTenLop = new Label();
            panelRight = new Panel();
            grpDanhSach = new GroupBox();
            dgvLop = new DataGridView();
            lblTongSo = new Label();
            button1 = new Button();
            panelTop.SuspendLayout();
            panelLeft.SuspendLayout();
            panelButtons.SuspendLayout();
            grpThongTin.SuspendLayout();
            panelRight.SuspendLayout();
            grpDanhSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLop).BeginInit();
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
            lblTitle.Text = "QUẢN LÝ LỚP HỌC";
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
            grpThongTin.Controls.Add(button1);
            grpThongTin.Controls.Add(cboGVCN);
            grpThongTin.Controls.Add(lblGVCN);
            grpThongTin.Controls.Add(cboNamHoc);
            grpThongTin.Controls.Add(lblNamHoc);
            grpThongTin.Controls.Add(cboKhoi);
            grpThongTin.Controls.Add(lblKhoi);
            grpThongTin.Controls.Add(txtTenLop);
            grpThongTin.Controls.Add(lblTenLop);
            grpThongTin.Dock = DockStyle.Fill;
            grpThongTin.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            grpThongTin.Location = new Point(17, 19);
            grpThongTin.Margin = new Padding(5, 6, 5, 6);
            grpThongTin.Name = "grpThongTin";
            grpThongTin.Padding = new Padding(17, 19, 17, 19);
            grpThongTin.Size = new Size(633, 1193);
            grpThongTin.TabIndex = 0;
            grpThongTin.TabStop = false;
            grpThongTin.Text = "Thông tin lớp";
            // 
            // cboGVCN
            // 
            cboGVCN.DropDownStyle = ComboBoxStyle.DropDownList;
            cboGVCN.Font = new Font("Segoe UI", 9F);
            cboGVCN.FormattingEnabled = true;
            cboGVCN.Location = new Point(25, 452);
            cboGVCN.Margin = new Padding(5, 6, 5, 6);
            cboGVCN.Name = "cboGVCN";
            cboGVCN.Size = new Size(581, 33);
            cboGVCN.TabIndex = 7;
            // 
            // lblGVCN
            // 
            lblGVCN.AutoSize = true;
            lblGVCN.Font = new Font("Segoe UI", 9F);
            lblGVCN.Location = new Point(25, 413);
            lblGVCN.Margin = new Padding(5, 0, 5, 0);
            lblGVCN.Name = "lblGVCN";
            lblGVCN.Size = new Size(176, 25);
            lblGVCN.TabIndex = 6;
            lblGVCN.Text = "Giáo viên chủ nhiệm:";
            // 
            // cboNamHoc
            // 
            cboNamHoc.DropDownStyle = ComboBoxStyle.DropDownList;
            cboNamHoc.Font = new Font("Segoe UI", 9F);
            cboNamHoc.FormattingEnabled = true;
            cboNamHoc.Location = new Point(25, 337);
            cboNamHoc.Margin = new Padding(5, 6, 5, 6);
            cboNamHoc.Name = "cboNamHoc";
            cboNamHoc.Size = new Size(581, 33);
            cboNamHoc.TabIndex = 5;
            // 
            // lblNamHoc
            // 
            lblNamHoc.AutoSize = true;
            lblNamHoc.Font = new Font("Segoe UI", 9F);
            lblNamHoc.Location = new Point(25, 298);
            lblNamHoc.Margin = new Padding(5, 0, 5, 0);
            lblNamHoc.Name = "lblNamHoc";
            lblNamHoc.Size = new Size(88, 25);
            lblNamHoc.TabIndex = 4;
            lblNamHoc.Text = "Năm học:";
            // 
            // cboKhoi
            // 
            cboKhoi.DropDownStyle = ComboBoxStyle.DropDownList;
            cboKhoi.Font = new Font("Segoe UI", 9F);
            cboKhoi.FormattingEnabled = true;
            cboKhoi.Location = new Point(25, 221);
            cboKhoi.Margin = new Padding(5, 6, 5, 6);
            cboKhoi.Name = "cboKhoi";
            cboKhoi.Size = new Size(581, 33);
            cboKhoi.TabIndex = 3;
            // 
            // lblKhoi
            // 
            lblKhoi.AutoSize = true;
            lblKhoi.Font = new Font("Segoe UI", 9F);
            lblKhoi.Location = new Point(25, 183);
            lblKhoi.Margin = new Padding(5, 0, 5, 0);
            lblKhoi.Name = "lblKhoi";
            lblKhoi.Size = new Size(51, 25);
            lblKhoi.TabIndex = 2;
            lblKhoi.Text = "Khối:";
            // 
            // txtTenLop
            // 
            txtTenLop.Font = new Font("Segoe UI", 9F);
            txtTenLop.Location = new Point(25, 106);
            txtTenLop.Margin = new Padding(5, 6, 5, 6);
            txtTenLop.Name = "txtTenLop";
            txtTenLop.Size = new Size(581, 31);
            txtTenLop.TabIndex = 1;
            // 
            // lblTenLop
            // 
            lblTenLop.AutoSize = true;
            lblTenLop.Font = new Font("Segoe UI", 9F);
            lblTenLop.Location = new Point(25, 67);
            lblTenLop.Margin = new Padding(5, 0, 5, 0);
            lblTenLop.Name = "lblTenLop";
            lblTenLop.Size = new Size(73, 25);
            lblTenLop.TabIndex = 0;
            lblTenLop.Text = "Tên lớp:";
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
            grpDanhSach.Controls.Add(dgvLop);
            grpDanhSach.Controls.Add(lblTongSo);
            grpDanhSach.Dock = DockStyle.Fill;
            grpDanhSach.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            grpDanhSach.Location = new Point(17, 19);
            grpDanhSach.Margin = new Padding(5, 6, 5, 6);
            grpDanhSach.Name = "grpDanhSach";
            grpDanhSach.Padding = new Padding(17, 19, 17, 19);
            grpDanhSach.Size = new Size(1299, 1193);
            grpDanhSach.TabIndex = 0;
            grpDanhSach.TabStop = false;
            grpDanhSach.Text = "Danh sách lớp";
            // 
            // dgvLop
            // 
            dgvLop.AllowUserToAddRows = false;
            dgvLop.AllowUserToDeleteRows = false;
            dgvLop.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLop.BackgroundColor = Color.White;
            dgvLop.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLop.Dock = DockStyle.Fill;
            dgvLop.Location = new Point(17, 46);
            dgvLop.Margin = new Padding(5, 6, 5, 6);
            dgvLop.MultiSelect = false;
            dgvLop.Name = "dgvLop";
            dgvLop.ReadOnly = true;
            dgvLop.RowHeadersWidth = 62;
            dgvLop.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLop.Size = new Size(1265, 1095);
            dgvLop.TabIndex = 0;
            dgvLop.CellClick += dgvLop_CellClick;
            // 
            // lblTongSo
            // 
            lblTongSo.Dock = DockStyle.Bottom;
            lblTongSo.Font = new Font("Segoe UI", 9F);
            lblTongSo.Location = new Point(17, 1141);
            lblTongSo.Margin = new Padding(5, 0, 5, 0);
            lblTongSo.Name = "lblTongSo";
            lblTongSo.Size = new Size(1265, 33);
            lblTongSo.TabIndex = 1;
            lblTongSo.Text = "Tổng số: 0 lớp";
            // 
            // button1
            // 
            button1.Location = new Point(60, 919);
            button1.Name = "button1";
            button1.Size = new Size(194, 34);
            button1.TabIndex = 8;
            button1.Text = "Chức năng mới";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // frmLop
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2000, 1346);
            Controls.Add(panelRight);
            Controls.Add(panelLeft);
            Controls.Add(panelTop);
            Margin = new Padding(5, 6, 5, 6);
            Name = "frmLop";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý lớp";
            panelTop.ResumeLayout(false);
            panelLeft.ResumeLayout(false);
            panelButtons.ResumeLayout(false);
            grpThongTin.ResumeLayout(false);
            grpThongTin.PerformLayout();
            panelRight.ResumeLayout(false);
            grpDanhSach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvLop).EndInit();
            ResumeLayout(false);
        }
        private Button button1;
    }
}