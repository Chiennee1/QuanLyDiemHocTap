
namespace QuanLyDiemHocTap.GUI
{
    partial class frmMonHoc
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.GroupBox grpThongTin;
        private System.Windows.Forms.Label lblTenMonHoc;
        private System.Windows.Forms.TextBox txtTenMonHoc;
        private System.Windows.Forms.Label lblKhoi;
        private System.Windows.Forms.ComboBox cboKhoi;
        private System.Windows.Forms.Label lblSoTietLT;
        private System.Windows.Forms.NumericUpDown nudSoTietLT;
        private System.Windows.Forms.Label lblSoTietTH;
        private System.Windows.Forms.NumericUpDown nudSoTietTH;
        private System.Windows.Forms.Label lblHeSo;
        private System.Windows.Forms.NumericUpDown nudHeSo;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.GroupBox grpDanhSach;
        private System.Windows.Forms.DataGridView dgvMonHoc;
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
            this.nudHeSo = new System.Windows.Forms.NumericUpDown();
            this.lblHeSo = new System.Windows.Forms.Label();
            this.nudSoTietTH = new System.Windows.Forms.NumericUpDown();
            this.lblSoTietTH = new System.Windows.Forms.Label();
            this.nudSoTietLT = new System.Windows.Forms.NumericUpDown();
            this.lblSoTietLT = new System.Windows.Forms.Label();
            this.cboKhoi = new System.Windows.Forms.ComboBox();
            this.lblKhoi = new System.Windows.Forms.Label();
            this.txtTenMonHoc = new System.Windows.Forms.TextBox();
            this.lblTenMonHoc = new System.Windows.Forms.Label();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.panelRight = new System.Windows.Forms.Panel();
            this.grpDanhSach = new System.Windows.Forms.GroupBox();
            this.dgvMonHoc = new System.Windows.Forms.DataGridView();
            this.lblTongSo = new System.Windows.Forms.Label();
            this.panelTop.SuspendLayout();
            this.panelLeft.SuspendLayout();
            this.grpThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudHeSo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoTietTH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoTietLT)).BeginInit();
            this.panelButtons.SuspendLayout();
            this.panelRight.SuspendLayout();
            this.grpDanhSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonHoc)).BeginInit();
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
            this.lblTitle.Text = "QUẢN LÝ MÔN HỌC";
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
            this.grpThongTin.Controls.Add(this.nudHeSo);
            this.grpThongTin.Controls.Add(this.lblHeSo);
            this.grpThongTin.Controls.Add(this.nudSoTietTH);
            this.grpThongTin.Controls.Add(this.lblSoTietTH);
            this.grpThongTin.Controls.Add(this.nudSoTietLT);
            this.grpThongTin.Controls.Add(this.lblSoTietLT);
            this.grpThongTin.Controls.Add(this.cboKhoi);
            this.grpThongTin.Controls.Add(this.lblKhoi);
            this.grpThongTin.Controls.Add(this.txtTenMonHoc);
            this.grpThongTin.Controls.Add(this.lblTenMonHoc);
            this.grpThongTin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpThongTin.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpThongTin.Location = new System.Drawing.Point(10, 10);
            this.grpThongTin.Name = "grpThongTin";
            this.grpThongTin.Padding = new System.Windows.Forms.Padding(10);
            this.grpThongTin.Size = new System.Drawing.Size(380, 540);
            this.grpThongTin.TabIndex = 0;
            this.grpThongTin.TabStop = false;
            this.grpThongTin.Text = "Thông tin môn học";

            // lblTenMonHoc
            this.lblTenMonHoc.AutoSize = true;
            this.lblTenMonHoc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTenMonHoc.Location = new System.Drawing.Point(15, 35);
            this.lblTenMonHoc.Name = "lblTenMonHoc";
            this.lblTenMonHoc.Size = new System.Drawing.Size(79, 15);
            this.lblTenMonHoc.TabIndex = 0;
            this.lblTenMonHoc.Text = "Tên môn học:";

            // txtTenMonHoc
            this.txtTenMonHoc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTenMonHoc.Location = new System.Drawing.Point(15, 55);
            this.txtTenMonHoc.Name = "txtTenMonHoc";
            this.txtTenMonHoc.Size = new System.Drawing.Size(350, 23);
            this.txtTenMonHoc.TabIndex = 1;

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

            // lblSoTietLT
            this.lblSoTietLT.AutoSize = true;
            this.lblSoTietLT.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSoTietLT.Location = new System.Drawing.Point(15, 155);
            this.lblSoTietLT.Name = "lblSoTietLT";
            this.lblSoTietLT.Size = new System.Drawing.Size(98, 15);
            this.lblSoTietLT.TabIndex = 4;
            this.lblSoTietLT.Text = "Số tiết lý thuyết:";

            // nudSoTietLT
            this.nudSoTietLT.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nudSoTietLT.Location = new System.Drawing.Point(15, 175);
            this.nudSoTietLT.Maximum = new decimal(new int[] { 200, 0, 0, 0 });
            this.nudSoTietLT.Name = "nudSoTietLT";
            this.nudSoTietLT.Size = new System.Drawing.Size(350, 23);
            this.nudSoTietLT.TabIndex = 5;

            // lblSoTietTH
            this.lblSoTietTH.AutoSize = true;
            this.lblSoTietTH.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSoTietTH.Location = new System.Drawing.Point(15, 215);
            this.lblSoTietTH.Name = "lblSoTietTH";
            this.lblSoTietTH.Size = new System.Drawing.Size(103, 15);
            this.lblSoTietTH.TabIndex = 6;
            this.lblSoTietTH.Text = "Số tiết thực hành:";

            // nudSoTietTH
            this.nudSoTietTH.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nudSoTietTH.Location = new System.Drawing.Point(15, 235);
            this.nudSoTietTH.Maximum = new decimal(new int[] { 200, 0, 0, 0 });
            this.nudSoTietTH.Name = "nudSoTietTH";
            this.nudSoTietTH.Size = new System.Drawing.Size(350, 23);
            this.nudSoTietTH.TabIndex = 7;

            // lblHeSo
            this.lblHeSo.AutoSize = true;
            this.lblHeSo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblHeSo.Location = new System.Drawing.Point(15, 275);
            this.lblHeSo.Name = "lblHeSo";
            this.lblHeSo.Size = new System.Drawing.Size(42, 15);
            this.lblHeSo.TabIndex = 8;
            this.lblHeSo.Text = "Hệ số:";

            // nudHeSo
            this.nudHeSo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nudHeSo.Location = new System.Drawing.Point(15, 295);
            this.nudHeSo.Maximum = new decimal(new int[] { 3, 0, 0, 0 });
            this.nudHeSo.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.nudHeSo.Name = "nudHeSo";
            this.nudHeSo.Size = new System.Drawing.Size(350, 23);
            this.nudHeSo.TabIndex = 9;
            this.nudHeSo.Value = new decimal(new int[] { 1, 0, 0, 0 });

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
            this.grpDanhSach.Controls.Add(this.dgvMonHoc);
            this.grpDanhSach.Controls.Add(this.lblTongSo);
            this.grpDanhSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpDanhSach.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpDanhSach.Location = new System.Drawing.Point(10, 10);
            this.grpDanhSach.Name = "grpDanhSach";
            this.grpDanhSach.Padding = new System.Windows.Forms.Padding(10);
            this.grpDanhSach.Size = new System.Drawing.Size(780, 620);
            this.grpDanhSach.TabIndex = 0;
            this.grpDanhSach.TabStop = false;
            this.grpDanhSach.Text = "Danh sách môn học";

            // lblTongSo
            this.lblTongSo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblTongSo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTongSo.Location = new System.Drawing.Point(10, 593);
            this.lblTongSo.Name = "lblTongSo";
            this.lblTongSo.Size = new System.Drawing.Size(760, 17);
            this.lblTongSo.TabIndex = 1;
            this.lblTongSo.Text = "Tổng số: 0 môn học";

            // dgvMonHoc
            this.dgvMonHoc.AllowUserToAddRows = false;
            this.dgvMonHoc.AllowUserToDeleteRows = false;
            this.dgvMonHoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMonHoc.BackgroundColor = System.Drawing.Color.White;
            this.dgvMonHoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMonHoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMonHoc.Location = new System.Drawing.Point(10, 26);
            this.dgvMonHoc.MultiSelect = false;
            this.dgvMonHoc.Name = "dgvMonHoc";
            this.dgvMonHoc.ReadOnly = true;
            this.dgvMonHoc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMonHoc.Size = new System.Drawing.Size(760, 567);
            this.dgvMonHoc.TabIndex = 0;
            this.dgvMonHoc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMonHoc_CellClick);

            // frmMonHoc
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.panelTop);
            this.Name = "frmMonHoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý môn học";
            this.panelTop.ResumeLayout(false);
            this.panelLeft.ResumeLayout(false);
            this.grpThongTin.ResumeLayout(false);
            this.grpThongTin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudHeSo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoTietTH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoTietLT)).EndInit();
            this.panelButtons.ResumeLayout(false);
            this.panelRight.ResumeLayout(false);
            this.grpDanhSach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonHoc)).EndInit();
            this.ResumeLayout(false);
        }
    }
}