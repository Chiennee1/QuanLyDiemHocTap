namespace QuanLyDiemHocTap.GUI
{
    partial class frmPhanCong
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.GroupBox grpThongTin;
        private System.Windows.Forms.Label lblNamHoc;
        private System.Windows.Forms.ComboBox cboNamHoc;
        private System.Windows.Forms.Label lblHocKy;
        private System.Windows.Forms.ComboBox cboHocKy;
        private System.Windows.Forms.Label lblLop;
        private System.Windows.Forms.ComboBox cboLop;
        private System.Windows.Forms.Label lblMonHoc;
        private System.Windows.Forms.ComboBox cboMonHoc;
        private System.Windows.Forms.Label lblGiaoVien;
        private System.Windows.Forms.ComboBox cboGiaoVien;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.GroupBox grpDanhSach;
        private System.Windows.Forms.DataGridView dgvPhanCong;
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
            cboGiaoVien = new ComboBox();
            lblGiaoVien = new Label();
            cboMonHoc = new ComboBox();
            lblMonHoc = new Label();
            cboLop = new ComboBox();
            lblLop = new Label();
            cboHocKy = new ComboBox();
            lblHocKy = new Label();
            cboNamHoc = new ComboBox();
            lblNamHoc = new Label();
            panelButtons = new Panel();
            btnXoa = new Button();
            btnThem = new Button();
            panelRight = new Panel();
            grpDanhSach = new GroupBox();
            dgvPhanCong = new DataGridView();
            lblTongSo = new Label();
            panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPhanCong).BeginInit();
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
            lblTitle.Text = "PHÂN CÔNG GIẢNG DẠY";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelLeft
            // 
            panelLeft.Location = new Point(0, 0);
            panelLeft.Margin = new Padding(5, 6, 5, 6);
            panelLeft.Name = "panelLeft";
            panelLeft.Size = new Size(333, 192);
            panelLeft.TabIndex = 1;
            // 
            // grpThongTin
            // 
            grpThongTin.Location = new Point(0, 0);
            grpThongTin.Name = "grpThongTin";
            grpThongTin.Size = new Size(200, 100);
            grpThongTin.TabIndex = 0;
            grpThongTin.TabStop = false;
            // 
            // cboGiaoVien
            // 
            cboGiaoVien.Location = new Point(0, 0);
            cboGiaoVien.Name = "cboGiaoVien";
            cboGiaoVien.Size = new Size(121, 33);
            cboGiaoVien.TabIndex = 0;
            // 
            // lblGiaoVien
            // 
            lblGiaoVien.Location = new Point(0, 0);
            lblGiaoVien.Name = "lblGiaoVien";
            lblGiaoVien.Size = new Size(100, 23);
            lblGiaoVien.TabIndex = 0;
            // 
            // cboMonHoc
            // 
            cboMonHoc.Location = new Point(0, 0);
            cboMonHoc.Name = "cboMonHoc";
            cboMonHoc.Size = new Size(121, 33);
            cboMonHoc.TabIndex = 0;
            // 
            // lblMonHoc
            // 
            lblMonHoc.Location = new Point(0, 0);
            lblMonHoc.Name = "lblMonHoc";
            lblMonHoc.Size = new Size(100, 23);
            lblMonHoc.TabIndex = 0;
            // 
            // cboLop
            // 
            cboLop.Location = new Point(0, 0);
            cboLop.Name = "cboLop";
            cboLop.Size = new Size(121, 33);
            cboLop.TabIndex = 0;
            // 
            // lblLop
            // 
            lblLop.Location = new Point(0, 0);
            lblLop.Name = "lblLop";
            lblLop.Size = new Size(100, 23);
            lblLop.TabIndex = 0;
            // 
            // cboHocKy
            // 
            cboHocKy.Location = new Point(0, 0);
            cboHocKy.Name = "cboHocKy";
            cboHocKy.Size = new Size(121, 33);
            cboHocKy.TabIndex = 0;
            // 
            // lblHocKy
            // 
            lblHocKy.Location = new Point(0, 0);
            lblHocKy.Name = "lblHocKy";
            lblHocKy.Size = new Size(100, 23);
            lblHocKy.TabIndex = 0;
            // 
            // cboNamHoc
            // 
            cboNamHoc.Location = new Point(0, 0);
            cboNamHoc.Name = "cboNamHoc";
            cboNamHoc.Size = new Size(121, 33);
            cboNamHoc.TabIndex = 0;
            // 
            // lblNamHoc
            // 
            lblNamHoc.Location = new Point(0, 0);
            lblNamHoc.Name = "lblNamHoc";
            lblNamHoc.Size = new Size(100, 23);
            lblNamHoc.TabIndex = 0;
            // 
            // panelButtons
            // 
            panelButtons.Location = new Point(0, 0);
            panelButtons.Name = "panelButtons";
            panelButtons.Size = new Size(200, 100);
            panelButtons.TabIndex = 0;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(0, 0);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(75, 23);
            btnXoa.TabIndex = 0;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(0, 0);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(75, 23);
            btnThem.TabIndex = 0;
            // 
            // panelRight
            // 
            panelRight.Location = new Point(0, 0);
            panelRight.Margin = new Padding(5, 6, 5, 6);
            panelRight.Name = "panelRight";
            panelRight.Size = new Size(333, 192);
            panelRight.TabIndex = 0;
            panelRight.Paint += panelRight_Paint;
            // 
            // grpDanhSach
            // 
            grpDanhSach.Location = new Point(0, 0);
            grpDanhSach.Name = "grpDanhSach";
            grpDanhSach.Size = new Size(200, 100);
            grpDanhSach.TabIndex = 0;
            grpDanhSach.TabStop = false;
            // 
            // dgvPhanCong
            // 
            dgvPhanCong.ColumnHeadersHeight = 34;
            dgvPhanCong.Location = new Point(0, 0);
            dgvPhanCong.Name = "dgvPhanCong";
            dgvPhanCong.RowHeadersWidth = 62;
            dgvPhanCong.Size = new Size(240, 150);
            dgvPhanCong.TabIndex = 0;
            // 
            // lblTongSo
            // 
            lblTongSo.Location = new Point(0, 0);
            lblTongSo.Name = "lblTongSo";
            lblTongSo.Size = new Size(100, 23);
            lblTongSo.TabIndex = 0;
            // 
            // frmPhanCong
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2000, 1346);
            Controls.Add(panelRight);
            Controls.Add(panelLeft);
            Controls.Add(panelTop);
            Margin = new Padding(5, 6, 5, 6);
            Name = "frmPhanCong";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Phân công giảng dạy";
            panelTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPhanCong).EndInit();
            ResumeLayout(false);
        }
    }
}