namespace QuanLyDienHocTap.GUI
{
    partial class frmTongKet
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
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.GroupBox grpDanhSach;
        private System.Windows.Forms.DataGridView dgvDanhSach;
        private System.Windows.Forms.Label lblTongSo;
        private System.Windows.Forms.Label lblThongKe;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.GroupBox grpTongKet;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label lblDiemTB;
        private System.Windows.Forms.TextBox txtDiemTB;
        private System.Windows.Forms.Label lblHanhKiem;
        private System.Windows.Forms.ComboBox cboHanhKiem;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Button btnTongKet;
        private System.Windows.Forms.Button btnTongKetTatCa;
        private System.Windows.Forms.Button btnXuatExcel;

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
            panelFilter = new Panel();
            grpFilter = new GroupBox();
            btnTaiDanhSach = new Button();
            cboLop = new ComboBox();
            lblLop = new Label();
            cboHocKy = new ComboBox();
            lblHocKy = new Label();
            cboNamHoc = new ComboBox();
            lblNamHoc = new Label();
            panelContent = new Panel();
            grpDanhSach = new GroupBox();
            dgvDanhSach = new DataGridView();
            lblThongKe = new Label();
            lblTongSo = new Label();
            panelRight = new Panel();
            grpTongKet = new GroupBox();
            panelButtons = new Panel();
            btnXuatExcel = new Button();
            btnTongKetTatCa = new Button();
            btnTongKet = new Button();
            cboHanhKiem = new ComboBox();
            lblHanhKiem = new Label();
            txtDiemTB = new TextBox();
            lblDiemTB = new Label();
            txtHoTen = new TextBox();
            lblHoTen = new Label();
            panelTop.SuspendLayout();
            panelFilter.SuspendLayout();
            grpFilter.SuspendLayout();
            panelContent.SuspendLayout();
            grpDanhSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDanhSach).BeginInit();
            panelRight.SuspendLayout();
            grpTongKet.SuspendLayout();
            panelButtons.SuspendLayout();
            SuspendLayout();
            // 
            // panelTop
            // 
            panelTop.BackColor = Color.FromArgb(0, 123, 255);
            panelTop.Controls.Add(lblTitle);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Margin = new Padding(4, 5, 4, 5);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(1714, 100);
            panelTop.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.Dock = DockStyle.Fill;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(0, 0);
            lblTitle.Margin = new Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(1714, 100);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "TỔNG KẾT HỌC KỲ";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelFilter
            // 
            panelFilter.Controls.Add(grpFilter);
            panelFilter.Dock = DockStyle.Top;
            panelFilter.Location = new Point(0, 100);
            panelFilter.Margin = new Padding(4, 5, 4, 5);
            panelFilter.Name = "panelFilter";
            panelFilter.Padding = new Padding(14, 17, 14, 17);
            panelFilter.Size = new Size(1714, 167);
            panelFilter.TabIndex = 1;
            // 
            // grpFilter
            // 
            grpFilter.Controls.Add(btnTaiDanhSach);
            grpFilter.Controls.Add(cboLop);
            grpFilter.Controls.Add(lblLop);
            grpFilter.Controls.Add(cboHocKy);
            grpFilter.Controls.Add(lblHocKy);
            grpFilter.Controls.Add(cboNamHoc);
            grpFilter.Controls.Add(lblNamHoc);
            grpFilter.Dock = DockStyle.Fill;
            grpFilter.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            grpFilter.Location = new Point(14, 17);
            grpFilter.Margin = new Padding(4, 5, 4, 5);
            grpFilter.Name = "grpFilter";
            grpFilter.Padding = new Padding(4, 5, 4, 5);
            grpFilter.Size = new Size(1686, 133);
            grpFilter.TabIndex = 0;
            grpFilter.TabStop = false;
            grpFilter.Text = "Chọn lớp";
            // 
            // btnTaiDanhSach
            // 
            btnTaiDanhSach.BackColor = Color.FromArgb(40, 167, 69);
            btnTaiDanhSach.FlatStyle = FlatStyle.Flat;
            btnTaiDanhSach.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnTaiDanhSach.ForeColor = Color.White;
            btnTaiDanhSach.Location = new Point(943, 58);
            btnTaiDanhSach.Margin = new Padding(4, 5, 4, 5);
            btnTaiDanhSach.Name = "btnTaiDanhSach";
            btnTaiDanhSach.Size = new Size(171, 58);
            btnTaiDanhSach.TabIndex = 6;
            btnTaiDanhSach.Text = "Tải danh sách";
            btnTaiDanhSach.UseVisualStyleBackColor = false;
            btnTaiDanhSach.Click += btnTaiDanhSach_Click;
            // 
            // cboLop
            // 
            cboLop.DropDownStyle = ComboBoxStyle.DropDownList;
            cboLop.Font = new Font("Segoe UI", 9F);
            cboLop.FormattingEnabled = true;
            cboLop.Location = new Point(636, 75);
            cboLop.Margin = new Padding(4, 5, 4, 5);
            cboLop.Name = "cboLop";
            cboLop.Size = new Size(284, 33);
            cboLop.TabIndex = 5;
            cboLop.SelectedIndexChanged += cboLop_SelectedIndexChanged;
            // 
            // lblLop
            // 
            lblLop.AutoSize = true;
            lblLop.Font = new Font("Segoe UI", 9F);
            lblLop.Location = new Point(636, 42);
            lblLop.Margin = new Padding(4, 0, 4, 0);
            lblLop.Name = "lblLop";
            lblLop.Size = new Size(46, 25);
            lblLop.TabIndex = 4;
            lblLop.Text = "Lớp:";
            // 
            // cboHocKy
            // 
            cboHocKy.DropDownStyle = ComboBoxStyle.DropDownList;
            cboHocKy.Font = new Font("Segoe UI", 9F);
            cboHocKy.FormattingEnabled = true;
            cboHocKy.Location = new Point(329, 75);
            cboHocKy.Margin = new Padding(4, 5, 4, 5);
            cboHocKy.Name = "cboHocKy";
            cboHocKy.Size = new Size(284, 33);
            cboHocKy.TabIndex = 3;
            cboHocKy.SelectedIndexChanged += cboHocKy_SelectedIndexChanged;
            // 
            // lblHocKy
            // 
            lblHocKy.AutoSize = true;
            lblHocKy.Font = new Font("Segoe UI", 9F);
            lblHocKy.Location = new Point(329, 42);
            lblHocKy.Margin = new Padding(4, 0, 4, 0);
            lblHocKy.Name = "lblHocKy";
            lblHocKy.Size = new Size(71, 25);
            lblHocKy.TabIndex = 2;
            lblHocKy.Text = "Học kỳ:";
            // 
            // cboNamHoc
            // 
            cboNamHoc.DropDownStyle = ComboBoxStyle.DropDownList;
            cboNamHoc.Font = new Font("Segoe UI", 9F);
            cboNamHoc.FormattingEnabled = true;
            cboNamHoc.Location = new Point(21, 75);
            cboNamHoc.Margin = new Padding(4, 5, 4, 5);
            cboNamHoc.Name = "cboNamHoc";
            cboNamHoc.Size = new Size(284, 33);
            cboNamHoc.TabIndex = 1;
            cboNamHoc.SelectedIndexChanged += cboNamHoc_SelectedIndexChanged;
            // 
            // lblNamHoc
            // 
            lblNamHoc.AutoSize = true;
            lblNamHoc.Font = new Font("Segoe UI", 9F);
            lblNamHoc.Location = new Point(21, 42);
            lblNamHoc.Margin = new Padding(4, 0, 4, 0);
            lblNamHoc.Name = "lblNamHoc";
            lblNamHoc.Size = new Size(88, 25);
            lblNamHoc.TabIndex = 0;
            lblNamHoc.Text = "Năm học:";
            // 
            // panelContent
            // 
            panelContent.Controls.Add(grpDanhSach);
            panelContent.Dock = DockStyle.Fill;
            panelContent.Location = new Point(0, 267);
            panelContent.Margin = new Padding(4, 5, 4, 5);
            panelContent.Name = "panelContent";
            panelContent.Padding = new Padding(14, 0, 14, 17);
            panelContent.Size = new Size(1143, 900);
            panelContent.TabIndex = 2;
            // 
            // grpDanhSach
            // 
            grpDanhSach.Controls.Add(dgvDanhSach);
            grpDanhSach.Controls.Add(lblThongKe);
            grpDanhSach.Controls.Add(lblTongSo);
            grpDanhSach.Dock = DockStyle.Fill;
            grpDanhSach.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            grpDanhSach.Location = new Point(14, 0);
            grpDanhSach.Margin = new Padding(4, 5, 4, 5);
            grpDanhSach.Name = "grpDanhSach";
            grpDanhSach.Padding = new Padding(14, 17, 14, 17);
            grpDanhSach.Size = new Size(1115, 883);
            grpDanhSach.TabIndex = 0;
            grpDanhSach.TabStop = false;
            grpDanhSach.Text = "Danh sách học sinh";
            // 
            // dgvDanhSach
            // 
            dgvDanhSach.AllowUserToAddRows = false;
            dgvDanhSach.AllowUserToDeleteRows = false;
            dgvDanhSach.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDanhSach.BackgroundColor = Color.White;
            dgvDanhSach.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDanhSach.Dock = DockStyle.Fill;
            dgvDanhSach.Location = new Point(14, 102);
            dgvDanhSach.Margin = new Padding(4, 5, 4, 5);
            dgvDanhSach.MultiSelect = false;
            dgvDanhSach.Name = "dgvDanhSach";
            dgvDanhSach.ReadOnly = true;
            dgvDanhSach.RowHeadersWidth = 62;
            dgvDanhSach.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDanhSach.Size = new Size(1087, 736);
            dgvDanhSach.TabIndex = 0;
            dgvDanhSach.CellClick += dgvDanhSach_CellClick;
            // 
            // lblThongKe
            // 
            lblThongKe.BackColor = Color.FromArgb(173, 216, 230);
            lblThongKe.Dock = DockStyle.Top;
            lblThongKe.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            lblThongKe.ForeColor = Color.FromArgb(0, 64, 0);
            lblThongKe.Location = new Point(14, 44);
            lblThongKe.Margin = new Padding(4, 0, 4, 0);
            lblThongKe.Name = "lblThongKe";
            lblThongKe.Padding = new Padding(7, 8, 7, 8);
            lblThongKe.Size = new Size(1087, 58);
            lblThongKe.TabIndex = 1;
            lblThongKe.Text = "Giỏi: 0 (0.0%)  |  Khá: 0 (0.0%)  |  TB: 0 (0.0%)  |  Yếu: 0 (0.0%)";
            lblThongKe.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTongSo
            // 
            lblTongSo.Dock = DockStyle.Bottom;
            lblTongSo.Font = new Font("Segoe UI", 9F);
            lblTongSo.Location = new Point(14, 838);
            lblTongSo.Margin = new Padding(4, 0, 4, 0);
            lblTongSo.Name = "lblTongSo";
            lblTongSo.Size = new Size(1087, 28);
            lblTongSo.TabIndex = 2;
            lblTongSo.Text = "Tổng số: 0 học sinh";
            // 
            // panelRight
            // 
            panelRight.Controls.Add(grpTongKet);
            panelRight.Dock = DockStyle.Right;
            panelRight.Location = new Point(1143, 267);
            panelRight.Margin = new Padding(4, 5, 4, 5);
            panelRight.Name = "panelRight";
            panelRight.Padding = new Padding(0, 0, 14, 17);
            panelRight.Size = new Size(571, 900);
            panelRight.TabIndex = 3;
            // 
            // grpTongKet
            // 
            grpTongKet.Controls.Add(panelButtons);
            grpTongKet.Controls.Add(cboHanhKiem);
            grpTongKet.Controls.Add(lblHanhKiem);
            grpTongKet.Controls.Add(txtDiemTB);
            grpTongKet.Controls.Add(lblDiemTB);
            grpTongKet.Controls.Add(txtHoTen);
            grpTongKet.Controls.Add(lblHoTen);
            grpTongKet.Dock = DockStyle.Fill;
            grpTongKet.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            grpTongKet.Location = new Point(0, 0);
            grpTongKet.Margin = new Padding(4, 5, 4, 5);
            grpTongKet.Name = "grpTongKet";
            grpTongKet.Padding = new Padding(14, 17, 14, 17);
            grpTongKet.Size = new Size(557, 883);
            grpTongKet.TabIndex = 0;
            grpTongKet.TabStop = false;
            grpTongKet.Text = "Tổng kết";
            // 
            // panelButtons
            // 
            panelButtons.Controls.Add(btnXuatExcel);
            panelButtons.Controls.Add(btnTongKetTatCa);
            panelButtons.Controls.Add(btnTongKet);
            panelButtons.Location = new Point(21, 367);
            panelButtons.Margin = new Padding(4, 5, 4, 5);
            panelButtons.Name = "panelButtons";
            panelButtons.Size = new Size(514, 250);
            panelButtons.TabIndex = 6;
            // 
            // btnXuatExcel
            // 
            btnXuatExcel.BackColor = Color.FromArgb(23, 162, 184);
            btnXuatExcel.FlatStyle = FlatStyle.Flat;
            btnXuatExcel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnXuatExcel.ForeColor = Color.White;
            btnXuatExcel.Location = new Point(7, 167);
            btnXuatExcel.Margin = new Padding(4, 5, 4, 5);
            btnXuatExcel.Name = "btnXuatExcel";
            btnXuatExcel.Size = new Size(500, 58);
            btnXuatExcel.TabIndex = 2;
            btnXuatExcel.Text = "Xuất Excel";
            btnXuatExcel.UseVisualStyleBackColor = false;
            btnXuatExcel.Click += btnXuatExcel_Click;
            // 
            // btnTongKetTatCa
            // 
            btnTongKetTatCa.BackColor = Color.FromArgb(0, 123, 255);
            btnTongKetTatCa.FlatStyle = FlatStyle.Flat;
            btnTongKetTatCa.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnTongKetTatCa.ForeColor = Color.White;
            btnTongKetTatCa.Location = new Point(7, 92);
            btnTongKetTatCa.Margin = new Padding(4, 5, 4, 5);
            btnTongKetTatCa.Name = "btnTongKetTatCa";
            btnTongKetTatCa.Size = new Size(500, 58);
            btnTongKetTatCa.TabIndex = 1;
            btnTongKetTatCa.Text = "Tổng kết tất cả";
            btnTongKetTatCa.UseVisualStyleBackColor = false;
            btnTongKetTatCa.Click += btnTongKetTatCa_Click;
            // 
            // btnTongKet
            // 
            btnTongKet.BackColor = Color.FromArgb(40, 167, 69);
            btnTongKet.Enabled = false;
            btnTongKet.FlatStyle = FlatStyle.Flat;
            btnTongKet.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnTongKet.ForeColor = Color.White;
            btnTongKet.Location = new Point(7, 17);
            btnTongKet.Margin = new Padding(4, 5, 4, 5);
            btnTongKet.Name = "btnTongKet";
            btnTongKet.Size = new Size(500, 58);
            btnTongKet.TabIndex = 0;
            btnTongKet.Text = "Tổng kết học sinh này";
            btnTongKet.UseVisualStyleBackColor = false;
            btnTongKet.Click += btnTongKet_Click;
            // 
            // cboHanhKiem
            // 
            cboHanhKiem.DropDownStyle = ComboBoxStyle.DropDownList;
            cboHanhKiem.Font = new Font("Segoe UI", 9F);
            cboHanhKiem.FormattingEnabled = true;
            cboHanhKiem.Location = new Point(21, 292);
            cboHanhKiem.Margin = new Padding(4, 5, 4, 5);
            cboHanhKiem.Name = "cboHanhKiem";
            cboHanhKiem.Size = new Size(513, 33);
            cboHanhKiem.TabIndex = 5;
            // 
            // lblHanhKiem
            // 
            lblHanhKiem.AutoSize = true;
            lblHanhKiem.Font = new Font("Segoe UI", 9F);
            lblHanhKiem.Location = new Point(21, 258);
            lblHanhKiem.Margin = new Padding(4, 0, 4, 0);
            lblHanhKiem.Name = "lblHanhKiem";
            lblHanhKiem.Size = new Size(101, 25);
            lblHanhKiem.TabIndex = 4;
            lblHanhKiem.Text = "Hạnh kiểm:";
            // 
            // txtDiemTB
            // 
            txtDiemTB.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            txtDiemTB.Location = new Point(21, 183);
            txtDiemTB.Margin = new Padding(4, 5, 4, 5);
            txtDiemTB.Name = "txtDiemTB";
            txtDiemTB.ReadOnly = true;
            txtDiemTB.Size = new Size(513, 37);
            txtDiemTB.TabIndex = 3;
            txtDiemTB.TextAlign = HorizontalAlignment.Center;
            // 
            // lblDiemTB
            // 
            lblDiemTB.AutoSize = true;
            lblDiemTB.Font = new Font("Segoe UI", 9F);
            lblDiemTB.Location = new Point(21, 150);
            lblDiemTB.Margin = new Padding(4, 0, 4, 0);
            lblDiemTB.Name = "lblDiemTB";
            lblDiemTB.Size = new Size(146, 25);
            lblDiemTB.TabIndex = 2;
            lblDiemTB.Text = "Điểm trung bình:";
            // 
            // txtHoTen
            // 
            txtHoTen.Font = new Font("Segoe UI", 9F);
            txtHoTen.Location = new Point(21, 83);
            txtHoTen.Margin = new Padding(4, 5, 4, 5);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.ReadOnly = true;
            txtHoTen.Size = new Size(513, 31);
            txtHoTen.TabIndex = 1;
            // 
            // lblHoTen
            // 
            lblHoTen.AutoSize = true;
            lblHoTen.Font = new Font("Segoe UI", 9F);
            lblHoTen.Location = new Point(21, 50);
            lblHoTen.Margin = new Padding(4, 0, 4, 0);
            lblHoTen.Name = "lblHoTen";
            lblHoTen.Size = new Size(93, 25);
            lblHoTen.TabIndex = 0;
            lblHoTen.Text = "Họ và tên:";
            // 
            // frmTongKet
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1714, 1167);
            Controls.Add(panelContent);
            Controls.Add(panelRight);
            Controls.Add(panelFilter);
            Controls.Add(panelTop);
            Font = new Font("Segoe UI", 9F);
            Margin = new Padding(4, 5, 4, 5);
            MinimumSize = new Size(1728, 1194);
            Name = "frmTongKet";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tổng kết học kỳ";
            panelTop.ResumeLayout(false);
            panelFilter.ResumeLayout(false);
            grpFilter.ResumeLayout(false);
            grpFilter.PerformLayout();
            panelContent.ResumeLayout(false);
            grpDanhSach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDanhSach).EndInit();
            panelRight.ResumeLayout(false);
            grpTongKet.ResumeLayout(false);
            grpTongKet.PerformLayout();
            panelButtons.ResumeLayout(false);
            ResumeLayout(false);
        }
    }
}