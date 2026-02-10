
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
            this.panelContent = new System.Windows.Forms.Panel();
            this.grpDanhSach = new System.Windows.Forms.GroupBox();
            this.dgvDanhSach = new System.Windows.Forms.DataGridView();
            this.lblThongKe = new System.Windows.Forms.Label();
            this.lblTongSo = new System.Windows.Forms.Label();
            this.panelRight = new System.Windows.Forms.Panel();
            this.grpTongKet = new System.Windows.Forms.GroupBox();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.btnXuatExcel = new System.Windows.Forms.Button();
            this.btnTongKetTatCa = new System.Windows.Forms.Button();
            this.btnTongKet = new System.Windows.Forms.Button();
            this.cboHanhKiem = new System.Windows.Forms.ComboBox();
            this.lblHanhKiem = new System.Windows.Forms.Label();
            this.txtDiemTB = new System.Windows.Forms.TextBox();
            this.lblDiemTB = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.panelTop.SuspendLayout();
            this.panelFilter.SuspendLayout();
            this.grpFilter.SuspendLayout();
            this.panelContent.SuspendLayout();
            this.grpDanhSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).BeginInit();
            this.panelRight.SuspendLayout();
            this.grpTongKet.SuspendLayout();
            this.panelButtons.SuspendLayout();
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
            this.lblTitle.Text = "TỔNG KẾT HỌC KỲ";
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

            // Labels and ComboBoxes similar to frmNhapDiem

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
            this.grpDanhSach.Controls.Add(this.lblThongKe);
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

            // lblThongKe
            this.lblThongKe.BackColor = System.Drawing.Color.LightBlue;
            this.lblThongKe.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblThongKe.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblThongKe.Location = new System.Drawing.Point(10, 26);
            this.lblThongKe.Name = "lblThongKe";
            this.lblThongKe.Padding = new System.Windows.Forms.Padding(5);
            this.lblThongKe.Size = new System.Drawing.Size(760, 30);
            this.lblThongKe.TabIndex = 2;
            this.lblThongKe.Text = "Giỏi: 0 | Khá: 0 | TB: 0 | Yếu: 0";
            this.lblThongKe.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            // dgvDanhSach
            this.dgvDanhSach.AllowUserToAddRows = false;
            this.dgvDanhSach.AllowUserToDeleteRows = false;
            this.dgvDanhSach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhSach.BackgroundColor = System.Drawing.Color.White;
            this.dgvDanhSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDanhSach.Location = new System.Drawing.Point(10, 56);
            this.dgvDanhSach.Name = "dgvDanhSach";
            this.dgvDanhSach.ReadOnly = true;
            this.dgvDanhSach.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDanhSach.Size = new System.Drawing.Size(760, 447);
            this.dgvDanhSach.TabIndex = 0;
            this.dgvDanhSach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSach_CellClick);

            // panelRight
            this.panelRight.Controls.Add(this.grpTongKet);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelRight.Location = new System.Drawing.Point(800, 160);
            this.panelRight.Name = "panelRight";
            this.panelRight.Padding = new System.Windows.Forms.Padding(0, 0, 10, 10);
            this.panelRight.Size = new System.Drawing.Size(400, 540);
            this.panelRight.TabIndex = 3;

            // grpTongKet
            this.grpTongKet.Controls.Add(this.panelButtons);
            this.grpTongKet.Controls.Add(this.cboHanhKiem);
            this.grpTongKet.Controls.Add(this.lblHanhKiem);
            this.grpTongKet.Controls.Add(this.txtDiemTB);
            this.grpTongKet.Controls.Add(this.lblDiemTB);
            this.grpTongKet.Controls.Add(this.txtHoTen);
            this.grpTongKet.Controls.Add(this.lblHoTen);
            this.grpTongKet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpTongKet.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpTongKet.Location = new System.Drawing.Point(0, 0);
            this.grpTongKet.Name = "grpTongKet";
            this.grpTongKet.Padding = new System.Windows.Forms.Padding(10);
            this.grpTongKet.Size = new System.Drawing.Size(390, 530);
            this.grpTongKet.TabIndex = 0;
            this.grpTongKet.TabStop = false;
            this.grpTongKet.Text = "Tổng kết";

            // lblHoTen
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblHoTen.Location = new System.Drawing.Point(15, 30);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(65, 15);
            this.lblHoTen.TabIndex = 0;
            this.lblHoTen.Text = "Họ và tên:";

            // txtHoTen
            this.txtHoTen.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtHoTen.Location = new System.Drawing.Point(15, 50);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.ReadOnly = true;
            this.txtHoTen.Size = new System.Drawing.Size(360, 23);
            this.txtHoTen.TabIndex = 1;

            // lblDiemTB
            this.lblDiemTB.AutoSize = true;
            this.lblDiemTB.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblDiemTB.Location = new System.Drawing.Point(15, 90);
            this.lblDiemTB.Name = "lblDiemTB";
            this.lblDiemTB.Size = new System.Drawing.Size(102, 15);
            this.lblDiemTB.TabIndex = 2;
            this.lblDiemTB.Text = "Điểm trung bình:";

            // txtDiemTB
            this.txtDiemTB.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDiemTB.Location = new System.Drawing.Point(15, 110);
            this.txtDiemTB.Name = "txtDiemTB";
            this.txtDiemTB.ReadOnly = true;
            this.txtDiemTB.Size = new System.Drawing.Size(360, 23);
            this.txtDiemTB.TabIndex = 3;

            // lblHanhKiem
            this.lblHanhKiem.AutoSize = true;
            this.lblHanhKiem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblHanhKiem.Location = new System.Drawing.Point(15, 150);
            this.lblHanhKiem.Name = "lblHanhKiem";
            this.lblHanhKiem.Size = new System.Drawing.Size(68, 15);
            this.lblHanhKiem.TabIndex = 4;
            this.lblHanhKiem.Text = "Hạnh kiểm:";

            // cboHanhKiem
            this.cboHanhKiem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboHanhKiem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cboHanhKiem.FormattingEnabled = true;
            this.cboHanhKiem.Location = new System.Drawing.Point(15, 170);
            this.cboHanhKiem.Name = "cboHanhKiem";
            this.cboHanhKiem.Size = new System.Drawing.Size(360, 23);
            this.cboHanhKiem.TabIndex = 5;

            // panelButtons
            this.panelButtons.Controls.Add(this.btnXuatExcel);
            this.panelButtons.Controls.Add(this.btnTongKetTatCa);
            this.panelButtons.Controls.Add(this.btnTongKet);
            this.panelButtons.Location = new System.Drawing.Point(15, 220);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(360, 150);
            this.panelButtons.TabIndex = 6;

            // btnTongKet
            this.btnTongKet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnTongKet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTongKet.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnTongKet.ForeColor = System.Drawing.Color.White;
            this.btnTongKet.Location = new System.Drawing.Point(5, 10);
            this.btnTongKet.Name = "btnTongKet";
            this.btnTongKet.Size = new System.Drawing.Size(350, 35);
            this.btnTongKet.TabIndex = 0;
            this.btnTongKet.Text = "Tổng kết học sinh này";
            this.btnTongKet.UseVisualStyleBackColor = false;
            this.btnTongKet.Click += new System.EventHandler(this.btnTongKet_Click);

            // btnTongKetTatCa
            this.btnTongKetTatCa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btnTongKetTatCa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTongKetTatCa.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnTongKetTatCa.ForeColor = System.Drawing.Color.White;
            this.btnTongKetTatCa.Location = new System.Drawing.Point(5, 55);
            this.btnTongKetTatCa.Name = "btnTongKetTatCa";
            this.btnTongKetTatCa.Size = new System.Drawing.Size(350, 35);
            this.btnTongKetTatCa.TabIndex = 1;
            this.btnTongKetTatCa.Text = "Tổng kết tất cả";
            this.btnTongKetTatCa.UseVisualStyleBackColor = false;
            this.btnTongKetTatCa.Click += new System.EventHandler(this.btnTongKetTatCa_Click);

            // btnXuatExcel
            this.btnXuatExcel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(162)))), ((int)(((byte)(184)))));
            this.btnXuatExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXuatExcel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnXuatExcel.ForeColor = System.Drawing.Color.White;
            this.btnXuatExcel.Location = new System.Drawing.Point(5, 100);
            this.btnXuatExcel.Name = "btnXuatExcel";
            this.btnXuatExcel.Size = new System.Drawing.Size(350, 35);
            this.btnXuatExcel.TabIndex = 2;
            this.btnXuatExcel.Text = "Xuất Excel";
            this.btnXuatExcel.UseVisualStyleBackColor = false;
            this.btnXuatExcel.Click += new System.EventHandler(this.btnXuatExcel_Click);

            // frmTongKet
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.panelFilter);
            this.Controls.Add(this.panelTop);
            this.Name = "frmTongKet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tổng kết học kỳ";
            this.ResumeLayout(false);
        }
    }
}