namespace QuanLyDiemHocTap.GUI
{
    partial class frmPhanLop
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
        private System.Windows.Forms.Button btnTaiDanhSach;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.GroupBox grpTrongLop;
        private System.Windows.Forms.DataGridView dgvHocSinhTrongLop;
        private System.Windows.Forms.Label lblTrongLop;
        private System.Windows.Forms.Button btnXoaKhoiLop;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.GroupBox grpTatCa;
        private System.Windows.Forms.DataGridView dgvTatCaHocSinh;
        private System.Windows.Forms.Label lblTatCa;
        private System.Windows.Forms.Button btnThemVaoLop;

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
            this.cboLop = new System.Windows.Forms.ComboBox();
            this.lblLop = new System.Windows.Forms.Label();
            this.cboHocKy = new System.Windows.Forms.ComboBox();
            this.lblHocKy = new System.Windows.Forms.Label();
            this.cboNamHoc = new System.Windows.Forms.ComboBox();
            this.lblNamHoc = new System.Windows.Forms.Label();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.grpTrongLop = new System.Windows.Forms.GroupBox();
            this.dgvHocSinhTrongLop = new System.Windows.Forms.DataGridView();
            this.btnXoaKhoiLop = new System.Windows.Forms.Button();
            this.lblTrongLop = new System.Windows.Forms.Label();
            this.panelRight = new System.Windows.Forms.Panel();
            this.grpTatCa = new System.Windows.Forms.GroupBox();
            this.dgvTatCaHocSinh = new System.Windows.Forms.DataGridView();
            this.btnThemVaoLop = new System.Windows.Forms.Button();
            this.lblTatCa = new System.Windows.Forms.Label();
            this.panelTop.SuspendLayout();
            this.panelFilter.SuspendLayout();
            this.grpFilter.SuspendLayout();
            this.panelLeft.SuspendLayout();
            this.grpTrongLop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHocSinhTrongLop)).BeginInit();
            this.panelRight.SuspendLayout();
            this.grpTatCa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTatCaHocSinh)).BeginInit();
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
            this.lblTitle.Text = "PHÂN LỚP HỌC SINH";
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
            this.grpFilter.Text = "Chọn lớp";

            // Similar controls as frmNhapDiem filter section

            // panelLeft
            this.panelLeft.Controls.Add(this.grpTrongLop);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 160);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Padding = new System.Windows.Forms.Padding(10);
            this.panelLeft.Size = new System.Drawing.Size(600, 540);
            this.panelLeft.TabIndex = 2;

            // grpTrongLop
            this.grpTrongLop.Controls.Add(this.dgvHocSinhTrongLop);
            this.grpTrongLop.Controls.Add(this.btnXoaKhoiLop);
            this.grpTrongLop.Controls.Add(this.lblTrongLop);
            this.grpTrongLop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpTrongLop.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpTrongLop.Location = new System.Drawing.Point(10, 10);
            this.grpTrongLop.Name = "grpTrongLop";
            this.grpTrongLop.Padding = new System.Windows.Forms.Padding(10);
            this.grpTrongLop.Size = new System.Drawing.Size(580, 520);
            this.grpTrongLop.TabIndex = 0;
            this.grpTrongLop.TabStop = false;
            this.grpTrongLop.Text = "Học sinh trong lớp";

            // dgvHocSinhTrongLop
            this.dgvHocSinhTrongLop.AllowUserToAddRows = false;
            this.dgvHocSinhTrongLop.AllowUserToDeleteRows = false;
            this.dgvHocSinhTrongLop.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHocSinhTrongLop.BackgroundColor = System.Drawing.Color.White;
            this.dgvHocSinhTrongLop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHocSinhTrongLop.Location = new System.Drawing.Point(10, 26);
            this.dgvHocSinhTrongLop.Name = "dgvHocSinhTrongLop";
            this.dgvHocSinhTrongLop.ReadOnly = true;
            this.dgvHocSinhTrongLop.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHocSinhTrongLop.Size = new System.Drawing.Size(560, 434);
            this.dgvHocSinhTrongLop.TabIndex = 0;

            // btnXoaKhoiLop
            this.btnXoaKhoiLop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnXoaKhoiLop.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnXoaKhoiLop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaKhoiLop.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnXoaKhoiLop.ForeColor = System.Drawing.Color.White;
            this.btnXoaKhoiLop.Location = new System.Drawing.Point(10, 460);
            this.btnXoaKhoiLop.Name = "btnXoaKhoiLop";
            this.btnXoaKhoiLop.Size = new System.Drawing.Size(560, 40);
            this.btnXoaKhoiLop.TabIndex = 1;
            this.btnXoaKhoiLop.Text = "← Xóa khỏi lớp";
            this.btnXoaKhoiLop.UseVisualStyleBackColor = false;
            this.btnXoaKhoiLop.Click += new System.EventHandler(this.btnXoaKhoiLop_Click);

            // lblTrongLop
            this.lblTrongLop.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblTrongLop.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTrongLop.Location = new System.Drawing.Point(10, 500);
            this.lblTrongLop.Name = "lblTrongLop";
            this.lblTrongLop.Size = new System.Drawing.Size(560, 10);
            this.lblTrongLop.TabIndex = 2;
            this.lblTrongLop.Text = "Trong lớp: 0 học sinh";

            // panelRight
            this.panelRight.Controls.Add(this.grpTatCa);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRight.Location = new System.Drawing.Point(600, 160);
            this.panelRight.Name = "panelRight";
            this.panelRight.Padding = new System.Windows.Forms.Padding(0, 10, 10, 10);
            this.panelRight.Size = new System.Drawing.Size(600, 540);
            this.panelRight.TabIndex = 3;

            // grpTatCa
            this.grpTatCa.Controls.Add(this.dgvTatCaHocSinh);
            this.grpTatCa.Controls.Add(this.btnThemVaoLop);
            this.grpTatCa.Controls.Add(this.lblTatCa);
            this.grpTatCa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpTatCa.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpTatCa.Location = new System.Drawing.Point(0, 10);
            this.grpTatCa.Name = "grpTatCa";
            this.grpTatCa.Padding = new System.Windows.Forms.Padding(10);
            this.grpTatCa.Size = new System.Drawing.Size(590, 520);
            this.grpTatCa.TabIndex = 0;
            this.grpTatCa.TabStop = false;
            this.grpTatCa.Text = "Tất cả học sinh";

            // dgvTatCaHocSinh
            this.dgvTatCaHocSinh.AllowUserToAddRows = false;
            this.dgvTatCaHocSinh.AllowUserToDeleteRows = false;
            this.dgvTatCaHocSinh.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTatCaHocSinh.BackgroundColor = System.Drawing.Color.White;
            this.dgvTatCaHocSinh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTatCaHocSinh.Location = new System.Drawing.Point(10, 26);
            this.dgvTatCaHocSinh.Name = "dgvTatCaHocSinh";
            this.dgvTatCaHocSinh.ReadOnly = true;
            this.dgvTatCaHocSinh.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTatCaHocSinh.Size = new System.Drawing.Size(570, 434);
            this.dgvTatCaHocSinh.TabIndex = 0;

            // btnThemVaoLop
            this.btnThemVaoLop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnThemVaoLop.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnThemVaoLop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemVaoLop.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnThemVaoLop.ForeColor = System.Drawing.Color.White;
            this.btnThemVaoLop.Location = new System.Drawing.Point(10, 460);
            this.btnThemVaoLop.Name = "btnThemVaoLop";
            this.btnThemVaoLop.Size = new System.Drawing.Size(570, 40);
            this.btnThemVaoLop.TabIndex = 1;
            this.btnThemVaoLop.Text = "Thêm vào lớp →";
            this.btnThemVaoLop.UseVisualStyleBackColor = false;
            this.btnThemVaoLop.Click += new System.EventHandler(this.btnThemVaoLop_Click);

            // lblTatCa
            this.lblTatCa.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblTatCa.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTatCa.Location = new System.Drawing.Point(10, 500);
            this.lblTatCa.Name = "lblTatCa";
            this.lblTatCa.Size = new System.Drawing.Size(570, 10);
            this.lblTatCa.TabIndex = 2;
            this.lblTatCa.Text = "Tất cả: 0 học sinh";

            // frmPhanLop
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.panelFilter);
            this.Controls.Add(this.panelTop);
            this.Name = "frmPhanLop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phân lớp học sinh";
            this.ResumeLayout(false);
        }
    }
}