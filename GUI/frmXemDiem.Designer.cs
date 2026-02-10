
namespace QuanLyDiemHocTap.GUI
{
    partial class frmXemDiem
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
        private System.Windows.Forms.Label lblHocSinh;
        private System.Windows.Forms.ComboBox cboHocSinh;
        private System.Windows.Forms.Button btnXemDiem;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.GroupBox grpDiemChiTiet;
        private System.Windows.Forms.DataGridView dgvDiem;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.GroupBox grpDiemTB;
        private System.Windows.Forms.DataGridView dgvDiemTB;
        private System.Windows.Forms.GroupBox grpKetQua;
        private System.Windows.Forms.Label lblDiemTBHK;
        private System.Windows.Forms.Label lblHanhKiem;
        private System.Windows.Forms.Label lblXepLoai;

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
            this.btnXemDiem = new System.Windows.Forms.Button();
            this.cboHocSinh = new System.Windows.Forms.ComboBox();
            this.lblHocSinh = new System.Windows.Forms.Label();
            this.cboLop = new System.Windows.Forms.ComboBox();
            this.lblLop = new System.Windows.Forms.Label();
            this.cboHocKy = new System.Windows.Forms.ComboBox();
            this.lblHocKy = new System.Windows.Forms.Label();
            this.cboNamHoc = new System.Windows.Forms.ComboBox();
            this.lblNamHoc = new System.Windows.Forms.Label();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.grpDiemChiTiet = new System.Windows.Forms.GroupBox();
            this.dgvDiem = new System.Windows.Forms.DataGridView();
            this.panelRight = new System.Windows.Forms.Panel();
            this.grpKetQua = new System.Windows.Forms.GroupBox();
            this.lblXepLoai = new System.Windows.Forms.Label();
            this.lblHanhKiem = new System.Windows.Forms.Label();
            this.lblDiemTBHK = new System.Windows.Forms.Label();
            this.grpDiemTB = new System.Windows.Forms.GroupBox();
            this.dgvDiemTB = new System.Windows.Forms.DataGridView();
            this.panelTop.SuspendLayout();
            this.panelFilter.SuspendLayout();
            this.grpFilter.SuspendLayout();
            this.panelLeft.SuspendLayout();
            this.grpDiemChiTiet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiem)).BeginInit();
            this.panelRight.SuspendLayout();
            this.grpKetQua.SuspendLayout();
            this.grpDiemTB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiemTB)).BeginInit();
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
            this.lblTitle.Text = "XEM ĐIỂM HỌC SINH";
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
            this.grpFilter.Controls.Add(this.btnXemDiem);
            this.grpFilter.Controls.Add(this.cboHocSinh);
            this.grpFilter.Controls.Add(this.lblHocSinh);
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
            this.grpFilter.Text = "Chọn học sinh";

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
            this.cboNamHoc.Size = new System.Drawing.Size(180, 23);
            this.cboNamHoc.TabIndex = 1;
            this.cboNamHoc.SelectedIndexChanged += new System.EventHandler(this.cboNamHoc_SelectedIndexChanged);

            // lblHocKy
            this.lblHocKy.AutoSize = true;
            this.lblHocKy.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblHocKy.Location = new System.Drawing.Point(210, 25);
            this.lblHocKy.Name = "lblHocKy";
            this.lblHocKy.Size = new System.Drawing.Size(48, 15);
            this.lblHocKy.TabIndex = 2;
            this.lblHocKy.Text = "Học kỳ:";

            // cboHocKy
            this.cboHocKy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboHocKy.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cboHocKy.FormattingEnabled = true;
            this.cboHocKy.Location = new System.Drawing.Point(210, 45);
            this.cboHocKy.Name = "cboHocKy";
            this.cboHocKy.Size = new System.Drawing.Size(180, 23);
            this.cboHocKy.TabIndex = 3;
            this.cboHocKy.SelectedIndexChanged += new System.EventHandler(this.cboHocKy_SelectedIndexChanged);

            // lblLop
            this.lblLop.AutoSize = true;
            this.lblLop.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblLop.Location = new System.Drawing.Point(405, 25);
            this.lblLop.Name = "lblLop";
            this.lblLop.Size = new System.Drawing.Size(30, 15);
            this.lblLop.TabIndex = 4;
            this.lblLop.Text = "Lớp:";

            // cboLop
            this.cboLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLop.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cboLop.FormattingEnabled = true;
            this.cboLop.Location = new System.Drawing.Point(405, 45);
            this.cboLop.Name = "cboLop";
            this.cboLop.Size = new System.Drawing.Size(180, 23);
            this.cboLop.TabIndex = 5;
            this.cboLop.SelectedIndexChanged += new System.EventHandler(this.cboLop_SelectedIndexChanged);

            // lblHocSinh
            this.lblHocSinh.AutoSize = true;
            this.lblHocSinh.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblHocSinh.Location = new System.Drawing.Point(600, 25);
            this.lblHocSinh.Name = "lblHocSinh";
            this.lblHocSinh.Size = new System.Drawing.Size(58, 15);
            this.lblHocSinh.TabIndex = 6;
            this.lblHocSinh.Text = "Học sinh:";

            // cboHocSinh
            this.cboHocSinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboHocSinh.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cboHocSinh.FormattingEnabled = true;
            this.cboHocSinh.Location = new System.Drawing.Point(600, 45);
            this.cboHocSinh.Name = "cboHocSinh";
            this.cboHocSinh.Size = new System.Drawing.Size(250, 23);
            this.cboHocSinh.TabIndex = 7;

            // btnXemDiem
            this.btnXemDiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnXemDiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXemDiem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnXemDiem.ForeColor = System.Drawing.Color.White;
            this.btnXemDiem.Location = new System.Drawing.Point(865, 35);
            this.btnXemDiem.Name = "btnXemDiem";
            this.btnXemDiem.Size = new System.Drawing.Size(120, 35);
            this.btnXemDiem.TabIndex = 8;
            this.btnXemDiem.Text = "Xem điểm";
            this.btnXemDiem.UseVisualStyleBackColor = false;
            this.btnXemDiem.Click += new System.EventHandler(this.btnXemDiem_Click);

            // panelLeft
            this.panelLeft.Controls.Add(this.grpDiemChiTiet);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLeft.Location = new System.Drawing.Point(0, 160);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Padding = new System.Windows.Forms.Padding(10, 0, 5, 10);
            this.panelLeft.Size = new System.Drawing.Size(700, 540);
            this.panelLeft.TabIndex = 2;

            // grpDiemChiTiet
            this.grpDiemChiTiet.Controls.Add(this.dgvDiem);
            this.grpDiemChiTiet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpDiemChiTiet.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpDiemChiTiet.Location = new System.Drawing.Point(10, 0);
            this.grpDiemChiTiet.Name = "grpDiemChiTiet";
            this.grpDiemChiTiet.Padding = new System.Windows.Forms.Padding(10);
            this.grpDiemChiTiet.Size = new System.Drawing.Size(685, 530);
            this.grpDiemChiTiet.TabIndex = 0;
            this.grpDiemChiTiet.TabStop = false;
            this.grpDiemChiTiet.Text = "Điểm chi tiết";

            // dgvDiem
            this.dgvDiem.AllowUserToAddRows = false;
            this.dgvDiem.AllowUserToDeleteRows = false;
            this.dgvDiem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDiem.BackgroundColor = System.Drawing.Color.White;
            this.dgvDiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDiem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDiem.Location = new System.Drawing.Point(10, 26);
            this.dgvDiem.Name = "dgvDiem";
            this.dgvDiem.ReadOnly = true;
            this.dgvDiem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDiem.Size = new System.Drawing.Size(665, 494);
            this.dgvDiem.TabIndex = 0;

            // panelRight
            this.panelRight.Controls.Add(this.grpKetQua);
            this.panelRight.Controls.Add(this.grpDiemTB);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelRight.Location = new System.Drawing.Point(700, 160);
            this.panelRight.Name = "panelRight";
            this.panelRight.Padding = new System.Windows.Forms.Padding(5, 0, 10, 10);
            this.panelRight.Size = new System.Drawing.Size(500, 540);
            this.panelRight.TabIndex = 3;

            // grpDiemTB
            this.grpDiemTB.Controls.Add(this.dgvDiemTB);
            this.grpDiemTB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpDiemTB.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpDiemTB.Location = new System.Drawing.Point(5, 0);
            this.grpDiemTB.Name = "grpDiemTB";
            this.grpDiemTB.Padding = new System.Windows.Forms.Padding(10);
            this.grpDiemTB.Size = new System.Drawing.Size(485, 380);
            this.grpDiemTB.TabIndex = 0;
            this.grpDiemTB.TabStop = false;
            this.grpDiemTB.Text = "Điểm trung bình các môn";

            // dgvDiemTB
            this.dgvDiemTB.AllowUserToAddRows = false;
            this.dgvDiemTB.AllowUserToDeleteRows = false;
            this.dgvDiemTB.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDiemTB.BackgroundColor = System.Drawing.Color.White;
            this.dgvDiemTB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDiemTB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDiemTB.Location = new System.Drawing.Point(10, 26);
            this.dgvDiemTB.Name = "dgvDiemTB";
            this.dgvDiemTB.ReadOnly = true;
            this.dgvDiemTB.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDiemTB.Size = new System.Drawing.Size(465, 344);
            this.dgvDiemTB.TabIndex = 0;

            // grpKetQua
            this.grpKetQua.Controls.Add(this.lblXepLoai);
            this.grpKetQua.Controls.Add(this.lblHanhKiem);
            this.grpKetQua.Controls.Add(this.lblDiemTBHK);
            this.grpKetQua.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grpKetQua.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpKetQua.Location = new System.Drawing.Point(5, 380);
            this.grpKetQua.Name = "grpKetQua";
            this.grpKetQua.Padding = new System.Windows.Forms.Padding(10);
            this.grpKetQua.Size = new System.Drawing.Size(485, 150);
            this.grpKetQua.TabIndex = 1;
            this.grpKetQua.TabStop = false;
            this.grpKetQua.Text = "Kết quả tổng kết";

            // lblDiemTBHK
            this.lblDiemTBHK.AutoSize = true;
            this.lblDiemTBHK.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblDiemTBHK.ForeColor = System.Drawing.Color.Blue;
            this.lblDiemTBHK.Location = new System.Drawing.Point(15, 35);
            this.lblDiemTBHK.Name = "lblDiemTBHK";
            this.lblDiemTBHK.Size = new System.Drawing.Size(170, 20);
            this.lblDiemTBHK.TabIndex = 0;
            this.lblDiemTBHK.Text = "Điểm TB học kỳ: 0.00";

            // lblHanhKiem
            this.lblHanhKiem.AutoSize = true;
            this.lblHanhKiem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblHanhKiem.Location = new System.Drawing.Point(15, 70);
            this.lblHanhKiem.Name = "lblHanhKiem";
            this.lblHanhKiem.Size = new System.Drawing.Size(155, 19);
            this.lblHanhKiem.TabIndex = 1;
            this.lblHanhKiem.Text = "Hạnh kiểm: Chưa đánh giá";

            // lblXepLoai
            this.lblXepLoai.AutoSize = true;
            this.lblXepLoai.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblXepLoai.ForeColor = System.Drawing.Color.Green;
            this.lblXepLoai.Location = new System.Drawing.Point(15, 105);
            this.lblXepLoai.Name = "lblXepLoai";
            this.lblXepLoai.Size = new System.Drawing.Size(173, 20);
            this.lblXepLoai.TabIndex = 2;
            this.lblXepLoai.Text = "Xếp loại: Chưa xếp loại";

            // frmXemDiem
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.panelFilter);
            this.Controls.Add(this.panelTop);
            this.Name = "frmXemDiem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Xem điểm học sinh";
            this.panelTop.ResumeLayout(false);
            this.panelFilter.ResumeLayout(false);
            this.grpFilter.ResumeLayout(false);
            this.grpFilter.PerformLayout();
            this.panelLeft.ResumeLayout(false);
            this.grpDiemChiTiet.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiem)).EndInit();
            this.panelRight.ResumeLayout(false);
            this.grpKetQua.ResumeLayout(false);
            this.grpKetQua.PerformLayout();
            this.grpDiemTB.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiemTB)).EndInit();
            this.ResumeLayout(false);
        }
    }
}