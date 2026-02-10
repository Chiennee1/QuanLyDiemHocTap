
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
            this.panelTop = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.grpThongTin = new System.Windows.Forms.GroupBox();
            this.cboGVCN = new System.Windows.Forms.ComboBox();
            this.lblGVCN = new System.Windows.Forms.Label();
            this.cboNamHoc = new System.Windows.Forms.ComboBox();
            this.lblNamHoc = new System.Windows.Forms.Label();
            this.cboKhoi = new System.Windows.Forms.ComboBox();
            this.lblKhoi = new System.Windows.Forms.Label();
            this.txtTenLop = new System.Windows.Forms.TextBox();
            this.lblTenLop = new System.Windows.Forms.Label();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.panelRight = new System.Windows.Forms.Panel();
            this.grpDanhSach = new System.Windows.Forms.GroupBox();
            this.dgvLop = new System.Windows.Forms.DataGridView();
            this.lblTongSo = new System.Windows.Forms.Label();
            this.panelTop.SuspendLayout();
            this.panelLeft.SuspendLayout();
            this.grpThongTin.SuspendLayout();
            this.panelButtons.SuspendLayout();
            this.panelRight.SuspendLayout();
            this.grpDanhSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLop)).BeginInit();
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
            this.lblTitle.Text = "QUẢN LÝ LỚP HỌC";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // panelLeft
            this.panelLeft.Controls.Add(this.panelButtons);
            this.panelLeft.Controls.Add(this.grpThongTin);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 60);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Padding = new System.Windows.Forms.Padding(10);
            this.panelLeft.Size = new System.Drawing.Size(400, 640);
            this.panelLeft.TabIndex = 1;

            // grpThongTin
            this.grpThongTin.Controls.Add(this.cboGVCN);
            this.grpThongTin.Controls.Add(this.lblGVCN);
            this.grpThongTin.Controls.Add(this.cboNamHoc);
            this.grpThongTin.Controls.Add(this.lblNamHoc);
            this.grpThongTin.Controls.Add(this.cboKhoi);
            this.grpThongTin.Controls.Add(this.lblKhoi);
            this.grpThongTin.Controls.Add(this.txtTenLop);
            this.grpThongTin.Controls.Add(this.lblTenLop);
            this.grpThongTin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpThongTin.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpThongTin.Location = new System.Drawing.Point(10, 10);
            this.grpThongTin.Name = "grpThongTin";
            this.grpThongTin.Padding = new System.Windows.Forms.Padding(10);
            this.grpThongTin.Size = new System.Drawing.Size(380, 540);
            this.grpThongTin.TabIndex = 0;
            this.grpThongTin.TabStop = false;
            this.grpThongTin.Text = "Thông tin lớp";

            // lblTenLop
            this.lblTenLop.AutoSize = true;
            this.lblTenLop.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTenLop.Location = new System.Drawing.Point(15, 35);
            this.lblTenLop.Name = "lblTenLop";
            this.lblTenLop.Size = new System.Drawing.Size(52, 15);
            this.lblTenLop.TabIndex = 0;
            this.lblTenLop.Text = "Tên lớp:";

            // txtTenLop
            this.txtTenLop.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTenLop.Location = new System.Drawing.Point(15, 55);
            this.txtTenLop.Name = "txtTenLop";
            this.txtTenLop.Size = new System.Drawing.Size(350, 23);
            this.txtTenLop.TabIndex = 1;

            // lblKhoi
            this.lblKhoi.AutoSize = true;
            this.lblKhoi.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblKhoi.Location = new System.Drawing.Point(15, 95);
            this.lblKhoi.Name = "lblKhoi";
            this.lblKhoi.Size = new System.Drawing.Size(35, 15);
            this.lblKhoi.TabIndex = 2;
            this.lblKhoi.Text = "Khối:";

            // cboKhoi
            this.cboKhoi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboKhoi.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cboKhoi.FormattingEnabled = true;
            this.cboKhoi.Location = new System.Drawing.Point(15, 115);
            this.cboKhoi.Name = "cboKhoi";
            this.cboKhoi.Size = new System.Drawing.Size(350, 23);
            this.cboKhoi.TabIndex = 3;

            // lblNamHoc
            this.lblNamHoc.AutoSize = true;
            this.lblNamHoc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblNamHoc.Location = new System.Drawing.Point(15, 155);
            this.lblNamHoc.Name = "lblNamHoc";
            this.lblNamHoc.Size = new System.Drawing.Size(60, 15);
            this.lblNamHoc.TabIndex = 4;
            this.lblNamHoc.Text = "Năm học:";

            // cboNamHoc
            this.cboNamHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNamHoc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cboNamHoc.FormattingEnabled = true;
            this.cboNamHoc.Location = new System.Drawing.Point(15, 175);
            this.cboNamHoc.Name = "cboNamHoc";
            this.cboNamHoc.Size = new System.Drawing.Size(350, 23);
            this.cboNamHoc.TabIndex = 5;

            // lblGVCN
            this.lblGVCN.AutoSize = true;
            this.lblGVCN.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblGVCN.Location = new System.Drawing.Point(15, 215);
            this.lblGVCN.Name = "lblGVCN";
            this.lblGVCN.Size = new System.Drawing.Size(110, 15);
            this.lblGVCN.TabIndex = 6;
            this.lblGVCN.Text = "Giáo viên chủ nhiệm:";

            // cboGVCN
            this.cboGVCN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGVCN.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cboGVCN.FormattingEnabled = true;
            this.cboGVCN.Location = new System.Drawing.Point(15, 235);
            this.cboGVCN.Name = "cboGVCN";
            this.cboGVCN.Size = new System.Drawing.Size(350, 23);
            this.cboGVCN.TabIndex = 7;

            // panelButtons
            this.panelButtons.Controls.Add(this.btnLamMoi);
            this.panelButtons.Controls.Add(this.btnXoa);
            this.panelButtons.Controls.Add(this.btnSua);
            this.panelButtons.Controls.Add(this.btnThem);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelButtons.Location = new System.Drawing.Point(10, 550);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(380, 80);
            this.panelButtons.TabIndex = 1;

            // btnThem
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(15, 15);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(80, 35);
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
            this.btnSua.Location = new System.Drawing.Point(105, 15);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(80, 35);
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
            this.btnXoa.Location = new System.Drawing.Point(195, 15);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(80, 35);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);

            // btnLamMoi
            this.btnLamMoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.btnLamMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLamMoi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnLamMoi.ForeColor = System.Drawing.Color.White;
            this.btnLamMoi.Location = new System.Drawing.Point(285, 15);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(80, 35);
            this.btnLamMoi.TabIndex = 3;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = false;

            // panelRight
            this.panelRight.Controls.Add(this.grpDanhSach);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRight.Location = new System.Drawing.Point(400, 60);
            this.panelRight.Name = "panelRight";
            this.panelRight.Padding = new System.Windows.Forms.Padding(10);
            this.panelRight.Size = new System.Drawing.Size(800, 640);
            this.panelRight.TabIndex = 2;

            // grpDanhSach
            this.grpDanhSach.Controls.Add(this.dgvLop);
            this.grpDanhSach.Controls.Add(this.lblTongSo);
            this.grpDanhSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpDanhSach.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpDanhSach.Location = new System.Drawing.Point(10, 10);
            this.grpDanhSach.Name = "grpDanhSach";
            this.grpDanhSach.Padding = new System.Windows.Forms.Padding(10);
            this.grpDanhSach.Size = new System.Drawing.Size(780, 620);
            this.grpDanhSach.TabIndex = 0;
            this.grpDanhSach.TabStop = false;
            this.grpDanhSach.Text = "Danh sách lớp";

            // lblTongSo
            this.lblTongSo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblTongSo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTongSo.Location = new System.Drawing.Point(10, 593);
            this.lblTongSo.Name = "lblTongSo";
            this.lblTongSo.Size = new System.Drawing.Size(760, 17);
            this.lblTongSo.TabIndex = 1;
            this.lblTongSo.Text = "Tổng số: 0 lớp";

            // dgvLop
            this.dgvLop.AllowUserToAddRows = false;
            this.dgvLop.AllowUserToDeleteRows = false;
            this.dgvLop.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLop.BackgroundColor = System.Drawing.Color.White;
            this.dgvLop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLop.Location = new System.Drawing.Point(10, 26);
            this.dgvLop.MultiSelect = false;
            this.dgvLop.Name = "dgvLop";
            this.dgvLop.ReadOnly = true;
            this.dgvLop.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLop.Size = new System.Drawing.Size(760, 567);
            this.dgvLop.TabIndex = 0;
            this.dgvLop.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLop_CellClick);

            // frmLop
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.panelTop);
            this.Name = "frmLop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý lớp";
            this.panelTop.ResumeLayout(false);
            this.panelLeft.ResumeLayout(false);
            this.grpThongTin.ResumeLayout(false);
            this.grpThongTin.PerformLayout();
            this.panelButtons.ResumeLayout(false);
            this.panelRight.ResumeLayout(false);
            this.grpDanhSach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLop)).EndInit();
            this.ResumeLayout(false);
        }
    }
}