    namespace QuanLyDiemHocTap.GUI
{
    partial class frmDangNhap
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelLogin;
        private System.Windows.Forms.Label lblTenDangNhap;
        private System.Windows.Forms.TextBox txtTenDangNhap;
        private System.Windows.Forms.Label lblMatKhau;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.Button btnDangNhap;
        private System.Windows.Forms.Button btnThoat;

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
            panelHeader = new Panel();
            lblTitle = new Label();
            panelLogin = new Panel();
            btnThoat = new Button();
            btnDangNhap = new Button();
            txtMatKhau = new TextBox();
            lblMatKhau = new Label();
            txtTenDangNhap = new TextBox();
            lblTenDangNhap = new Label();
            panelHeader.SuspendLayout();
            panelLogin.SuspendLayout();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(0, 123, 255);
            panelHeader.Controls.Add(lblTitle);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Margin = new Padding(5, 6, 5, 6);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(750, 154);
            panelHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.Dock = DockStyle.Fill;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(0, 0);
            lblTitle.Margin = new Padding(5, 0, 5, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(750, 154);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "ĐĂNG NHẬP HỆ THỐNG";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            lblTitle.Click += lblTitle_Click;
            // 
            // panelLogin
            // 
            panelLogin.Controls.Add(btnThoat);
            panelLogin.Controls.Add(btnDangNhap);
            panelLogin.Controls.Add(txtMatKhau);
            panelLogin.Controls.Add(lblMatKhau);
            panelLogin.Controls.Add(txtTenDangNhap);
            panelLogin.Controls.Add(lblTenDangNhap);
            panelLogin.Location = new Point(83, 231);
            panelLogin.Margin = new Padding(5, 6, 5, 6);
            panelLogin.Name = "panelLogin";
            panelLogin.Size = new Size(583, 385);
            panelLogin.TabIndex = 1;
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.FromArgb(220, 53, 69);
            btnThoat.FlatStyle = FlatStyle.Flat;
            btnThoat.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnThoat.ForeColor = Color.White;
            btnThoat.Location = new Point(317, 298);
            btnThoat.Margin = new Padding(5, 6, 5, 6);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(250, 67);
            btnThoat.TabIndex = 5;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnDangNhap
            // 
            btnDangNhap.BackColor = Color.FromArgb(0, 123, 255);
            btnDangNhap.FlatStyle = FlatStyle.Flat;
            btnDangNhap.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnDangNhap.ForeColor = Color.White;
            btnDangNhap.Location = new Point(17, 298);
            btnDangNhap.Margin = new Padding(5, 6, 5, 6);
            btnDangNhap.Name = "btnDangNhap";
            btnDangNhap.Size = new Size(250, 67);
            btnDangNhap.TabIndex = 4;
            btnDangNhap.Text = "Đăng nhập";
            btnDangNhap.UseVisualStyleBackColor = false;
            btnDangNhap.Click += btnDangNhap_Click;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Font = new Font("Segoe UI", 10F);
            txtMatKhau.Location = new Point(17, 212);
            txtMatKhau.Margin = new Padding(5, 6, 5, 6);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.PasswordChar = '●';
            txtMatKhau.Size = new Size(547, 34);
            txtMatKhau.TabIndex = 3;
            txtMatKhau.KeyDown += txtMatKhau_KeyDown;
            // 
            // lblMatKhau
            // 
            lblMatKhau.AutoSize = true;
            lblMatKhau.Font = new Font("Segoe UI", 10F);
            lblMatKhau.Location = new Point(17, 163);
            lblMatKhau.Margin = new Padding(5, 0, 5, 0);
            lblMatKhau.Name = "lblMatKhau";
            lblMatKhau.Size = new Size(98, 28);
            lblMatKhau.TabIndex = 2;
            lblMatKhau.Text = "Mật khẩu:";
            // 
            // txtTenDangNhap
            // 
            txtTenDangNhap.Font = new Font("Segoe UI", 10F);
            txtTenDangNhap.Location = new Point(17, 87);
            txtTenDangNhap.Margin = new Padding(5, 6, 5, 6);
            txtTenDangNhap.Name = "txtTenDangNhap";
            txtTenDangNhap.Size = new Size(547, 34);
            txtTenDangNhap.TabIndex = 1;
            // 
            // lblTenDangNhap
            // 
            lblTenDangNhap.AutoSize = true;
            lblTenDangNhap.Font = new Font("Segoe UI", 10F);
            lblTenDangNhap.Location = new Point(17, 38);
            lblTenDangNhap.Margin = new Padding(5, 0, 5, 0);
            lblTenDangNhap.Name = "lblTenDangNhap";
            lblTenDangNhap.Size = new Size(144, 28);
            lblTenDangNhap.TabIndex = 0;
            lblTenDangNhap.Text = "Tên đăng nhập:";
            // 
            // frmDangNhap
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(750, 673);
            Controls.Add(panelLogin);
            Controls.Add(panelHeader);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(5, 6, 5, 6);
            MaximizeBox = false;
            Name = "frmDangNhap";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng nhập";
            panelHeader.ResumeLayout(false);
            panelLogin.ResumeLayout(false);
            panelLogin.PerformLayout();
            ResumeLayout(false);
        }
    }
}