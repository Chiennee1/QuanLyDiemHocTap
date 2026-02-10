namespace QuanLyDiemHocTap.GUI
{
    partial class frmBaoCaoHocSinh
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelFilter;
        private System.Windows.Forms.GroupBox grpFilter;
        private System.Windows.Forms.Label lblHocSinh;
        private System.Windows.Forms.ComboBox cboHocSinh;
        private System.Windows.Forms.Button btnXemBaoCao;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.GroupBox grpThongTin;
        private System.Windows.Forms.Label lblThongTinHS;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.GroupBox grpKetQua;
        private System.Windows.Forms.DataGridView dgvKetQua;

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
            this.btnXemBaoCao = new System.Windows.Forms.Button();
            this.cboHocSinh = new System.Windows.Forms.ComboBox();
            this.lblHocSinh = new System.Windows.Forms.Label();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.grpThongTin = new System.Windows.Forms.GroupBox();
            this.lblThongTinHS = new System.Windows.Forms.Label();
            this.panelRight = new System.Windows.Forms.Panel();
            this.grpKetQua = new System.Windows.Forms.GroupBox();
            this.dgvKetQua = new System.Windows.Forms.DataGridView();
            this.panelTop.SuspendLayout();
            this.panelFilter.SuspendLayout();
            this.grpFilter.SuspendLayout();
            this.panelLeft.SuspendLayout();
            this.grpThongTin.SuspendLayout();
            this.panelRight.SuspendLayout();
            this.grpKetQua.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKetQua)).BeginInit();
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
            this.lblTitle.Text = "BÁO CÁO KẾT QUẢ HỌC SINH";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // panelFilter
            this.panelFilter.Controls.Add(this.grpFilter);
            this.panelFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFilter.Location = new System.Drawing.Point(0, 60);
            this.panelFilter.Name = "panelFilter";
            this.panelFilter.Padding = new System.Windows.Forms.Padding(10);
            this.panelFilter.Size = new System.Drawing.Size(1200, 80);
            this.panelFilter.TabIndex = 1;

            // grpFilter
            this.grpFilter.Controls.Add(this.btnXemBaoCao);
            this.grpFilter.Controls.Add(this.cboHocSinh);
            this.grpFilter.Controls.Add(this.lblHocSinh);
            this.grpFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpFilter.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpFilter.Location = new System.Drawing.Point(10, 10);
            this.grpFilter.Name = "grpFilter";
            this.grpFilter.Size = new System.Drawing.Size(1180, 60);
            this.grpFilter.TabIndex = 0;
            this.grpFilter.TabStop = false;
            this.grpFilter.Text = "Chọn học sinh";

            // lblHocSinh
            this.lblHocSinh.AutoSize = true;
            this.lblHocSinh.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblHocSinh.Location = new System.Drawing.Point(15, 22);
            this.lblHocSinh.Name = "lblHocSinh";
            this.lblHocSinh.Size = new System.Drawing.Size(58, 15);
            this.lblHocSinh.TabIndex = 0;
            this.lblHocSinh.Text = "Học sinh:";

            // cboHocSinh
            this.cboHocSinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboHocSinh.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cboHocSinh.FormattingEnabled = true;
            this.cboHocSinh.Location = new System.Drawing.Point(80, 19);
            this.cboHocSinh.Name = "cboHocSinh";
            this.cboHocSinh.Size = new System.Drawing.Size(350, 23);
            this.cboHocSinh.TabIndex = 1;

            // btnXemBaoCao
            this.btnXemBaoCao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnXemBaoCao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXemBaoCao.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnXemBaoCao.ForeColor = System.Drawing.Color.White;
            this.btnXemBaoCao.Location = new System.Drawing.Point(445, 13);
            this.btnXemBaoCao.Name = "btnXemBaoCao";
            this.btnXemBaoCao.Size = new System.Drawing.Size(120, 35);
            this.btnXemBaoCao.TabIndex = 2;
            this.btnXemBaoCao.Text = "Xem báo cáo";
            this.btnXemBaoCao.UseVisualStyleBackColor = false;
            this.btnXemBaoCao.Click += new System.EventHandler(this.btnXemBaoCao_Click);

            // panelLeft
            this.panelLeft.Controls.Add(this.grpThongTin);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 140);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Padding = new System.Windows.Forms.Padding(10, 0, 5, 10);
            this.panelLeft.Size = new System.Drawing.Size(400, 560);
            this.panelLeft.TabIndex = 2;

            // grpThongTin
            this.grpThongTin.Controls.Add(this.lblThongTinHS);
            this.grpThongTin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpThongTin.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpThongTin.Location = new System.Drawing.Point(10, 0);
            this.grpThongTin.Name = "grpThongTin";
            this.grpThongTin.Padding = new System.Windows.Forms.Padding(10);
            this.grpThongTin.Size = new System.Drawing.Size(385, 550);
            this.grpThongTin.TabIndex = 0;
            this.grpThongTin.TabStop = false;
            this.grpThongTin.Text = "Thông tin học sinh";

            // lblThongTinHS
            this.lblThongTinHS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblThongTinHS.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblThongTinHS.Location = new System.Drawing.Point(10, 26);
            this.lblThongTinHS.Name = "lblThongTinHS";
            this.lblThongTinHS.Padding = new System.Windows.Forms.Padding(5);
            this.lblThongTinHS.Size = new System.Drawing.Size(365, 514);
            this.lblThongTinHS.TabIndex = 0;
            this.lblThongTinHS.Text = "Chọn học sinh để xem thông tin";

            // panelRight
            this.panelRight.Controls.Add(this.grpKetQua);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRight.Location = new System.Drawing.Point(400, 140);
            this.panelRight.Name = "panelRight";
            this.panelRight.Padding = new System.Windows.Forms.Padding(5, 0, 10, 10);
            this.panelRight.Size = new System.Drawing.Size(800, 560);
            this.panelRight.TabIndex = 3;

            // grpKetQua
            this.grpKetQua.Controls.Add(this.dgvKetQua);
            this.grpKetQua.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpKetQua.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpKetQua.Location = new System.Drawing.Point(5, 0);
            this.grpKetQua.Name = "grpKetQua";
            this.grpKetQua.Padding = new System.Windows.Forms.Padding(10);
            this.grpKetQua.Size = new System.Drawing.Size(785, 550);
            this.grpKetQua.TabIndex = 0;
            this.grpKetQua.TabStop = false;
            this.grpKetQua.Text = "Kết quả học tập qua các học kỳ";

            // dgvKetQua
            this.dgvKetQua.AllowUserToAddRows = false;
            this.dgvKetQua.AllowUserToDeleteRows = false;
            this.dgvKetQua.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKetQua.BackgroundColor = System.Drawing.Color.White;
            this.dgvKetQua.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKetQua.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvKetQua.Location = new System.Drawing.Point(10, 26);
            this.dgvKetQua.Name = "dgvKetQua";
            this.dgvKetQua.ReadOnly = true;
            this.dgvKetQua.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKetQua.Size = new System.Drawing.Size(765, 514);
            this.dgvKetQua.TabIndex = 0;

            // frmBaoCaoHocSinh
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.panelFilter);
            this.Controls.Add(this.panelTop);
            this.Name = "frmBaoCaoHocSinh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Báo cáo kết quả học sinh";
            this.panelTop.ResumeLayout(false);
            this.panelFilter.ResumeLayout(false);
            this.grpFilter.ResumeLayout(false);
            this.grpFilter.PerformLayout();
            this.panelLeft.ResumeLayout(false);
            this.grpThongTin.ResumeLayout(false);
            this.panelRight.ResumeLayout(false);
            this.grpKetQua.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKetQua)).EndInit();
            this.ResumeLayout(false);
        }
    }
}