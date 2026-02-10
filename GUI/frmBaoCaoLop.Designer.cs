namespace QuanLyDiemHocTap.GUI
{
    partial class frmBaoCaoLop
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
        private System.Windows.Forms.Button btnXemBaoCao;
        private System.Windows.Forms.Button btnXuatExcel;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.GroupBox grpBaoCao;
        private System.Windows.Forms.DataGridView dgvBaoCao;
        private System.Windows.Forms.Panel panelThongKe;
        private System.Windows.Forms.Label lblThongKe;
        private System.Windows.Forms.Label lblDiemTBLop;

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
            this.btnXuatExcel = new System.Windows.Forms.Button();
            this.btnXemBaoCao = new System.Windows.Forms.Button();
            this.cboLop = new System.Windows.Forms.ComboBox();
            this.lblLop = new System.Windows.Forms.Label();
            this.cboHocKy = new System.Windows.Forms.ComboBox();
            this.lblHocKy = new System.Windows.Forms.Label();
            this.cboNamHoc = new System.Windows.Forms.ComboBox();
            this.lblNamHoc = new System.Windows.Forms.Label();
            this.panelContent = new System.Windows.Forms.Panel();
            this.grpBaoCao = new System.Windows.Forms.GroupBox();
            this.dgvBaoCao = new System.Windows.Forms.DataGridView();
            this.panelThongKe = new System.Windows.Forms.Panel();
            this.lblDiemTBLop = new System.Windows.Forms.Label();
            this.lblThongKe = new System.Windows.Forms.Label();
            this.panelTop.SuspendLayout();
            this.panelFilter.SuspendLayout();
            this.grpFilter.SuspendLayout();
            this.panelContent.SuspendLayout();
            this.grpBaoCao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaoCao)).BeginInit();
            this.panelThongKe.SuspendLayout();
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
            this.lblTitle.Text = "BÁO CÁO KẾT QUẢ THEO LỚP";
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
            this.grpFilter.Controls.Add(this.btnXuatExcel);
            this.grpFilter.Controls.Add(this.btnXemBaoCao);
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
            this.grpFilter.Text = "Chọn lớp và học kỳ";

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

            // btnXemBaoCao
            this.btnXemBaoCao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnXemBaoCao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXemBaoCao.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnXemBaoCao.ForeColor = System.Drawing.Color.White;
            this.btnXemBaoCao.Location = new System.Drawing.Point(660, 35);
            this.btnXemBaoCao.Name = "btnXemBaoCao";
            this.btnXemBaoCao.Size = new System.Drawing.Size(120, 35);
            this.btnXemBaoCao.TabIndex = 6;
            this.btnXemBaoCao.Text = "Xem báo cáo";
            this.btnXemBaoCao.UseVisualStyleBackColor = false;
            this.btnXemBaoCao.Click += new System.EventHandler(this.btnXemBaoCao_Click);

            // btnXuatExcel
            this.btnXuatExcel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(162)))), ((int)(((byte)(184)))));
            this.btnXuatExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXuatExcel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnXuatExcel.ForeColor = System.Drawing.Color.White;
            this.btnXuatExcel.Location = new System.Drawing.Point(790, 35);
            this.btnXuatExcel.Name = "btnXuatExcel";
            this.btnXuatExcel.Size = new System.Drawing.Size(120, 35);
            this.btnXuatExcel.TabIndex = 7;
            this.btnXuatExcel.Text = "Xuất Excel";
            this.btnXuatExcel.UseVisualStyleBackColor = false;
            this.btnXuatExcel.Click += new System.EventHandler(this.btnXuatExcel_Click);

            // panelContent
            this.panelContent.Controls.Add(this.grpBaoCao);
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(0, 160);
            this.panelContent.Name = "panelContent";
            this.panelContent.Padding = new System.Windows.Forms.Padding(10);
            this.panelContent.Size = new System.Drawing.Size(1200, 540);
            this.panelContent.TabIndex = 2;

            // grpBaoCao
            this.grpBaoCao.Controls.Add(this.dgvBaoCao);
            this.grpBaoCao.Controls.Add(this.panelThongKe);
            this.grpBaoCao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpBaoCao.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpBaoCao.Location = new System.Drawing.Point(10, 10);
            this.grpBaoCao.Name = "grpBaoCao";
            this.grpBaoCao.Padding = new System.Windows.Forms.Padding(10);
            this.grpBaoCao.Size = new System.Drawing.Size(1180, 520);
            this.grpBaoCao.TabIndex = 0;
            this.grpBaoCao.TabStop = false;
            this.grpBaoCao.Text = "Báo cáo kết quả học tập";

            // panelThongKe
            this.panelThongKe.BackColor = System.Drawing.Color.LightYellow;
            this.panelThongKe.Controls.Add(this.lblDiemTBLop);
            this.panelThongKe.Controls.Add(this.lblThongKe);
            this.panelThongKe.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelThongKe.Location = new System.Drawing.Point(10, 26);
            this.panelThongKe.Name = "panelThongKe";
            this.panelThongKe.Padding = new System.Windows.Forms.Padding(10);
            this.panelThongKe.Size = new System.Drawing.Size(1160, 60);
            this.panelThongKe.TabIndex = 1;

            // lblThongKe
            this.lblThongKe.AutoSize = true;
            this.lblThongKe.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblThongKe.Location = new System.Drawing.Point(10, 10);
            this.lblThongKe.Name = "lblThongKe";
            this.lblThongKe.Size = new System.Drawing.Size(350, 19);
            this.lblThongKe.TabIndex = 0;
            this.lblThongKe.Text = "Tổng số: 0 | Giỏi: 0 | Khá: 0 | TB: 0 | Yếu: 0";

            // lblDiemTBLop
            this.lblDiemTBLop.AutoSize = true;
            this.lblDiemTBLop.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblDiemTBLop.ForeColor = System.Drawing.Color.Blue;
            this.lblDiemTBLop.Location = new System.Drawing.Point(10, 35);
            this.lblDiemTBLop.Name = "lblDiemTBLop";
            this.lblDiemTBLop.Size = new System.Drawing.Size(126, 19);
            this.lblDiemTBLop.TabIndex = 1;
            this.lblDiemTBLop.Text = "Điểm TB lớp: 0.00";

            // dgvBaoCao
            this.dgvBaoCao.AllowUserToAddRows = false;
            this.dgvBaoCao.AllowUserToDeleteRows = false;
            this.dgvBaoCao.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBaoCao.BackgroundColor = System.Drawing.Color.White;
            this.dgvBaoCao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBaoCao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBaoCao.Location = new System.Drawing.Point(10, 86);
            this.dgvBaoCao.Name = "dgvBaoCao";
            this.dgvBaoCao.ReadOnly = true;
            this.dgvBaoCao.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBaoCao.Size = new System.Drawing.Size(1160, 424);
            this.dgvBaoCao.TabIndex = 0;

            // frmBaoCaoLop
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelFilter);
            this.Controls.Add(this.panelTop);
            this.Name = "frmBaoCaoLop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Báo cáo kết quả theo lớp";
            this.panelTop.ResumeLayout(false);
            this.panelFilter.ResumeLayout(false);
            this.grpFilter.ResumeLayout(false);
            this.grpFilter.PerformLayout();
            this.panelContent.ResumeLayout(false);
            this.grpBaoCao.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaoCao)).EndInit();
            this.panelThongKe.ResumeLayout(false);
            this.panelThongKe.PerformLayout();
            this.ResumeLayout(false);
        }
    }
}