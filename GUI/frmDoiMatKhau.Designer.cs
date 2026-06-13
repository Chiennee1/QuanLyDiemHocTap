namespace QuanLyDiemHocTap.GUI
{
    partial class frmDoiMatKhau
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Label lblMatKhauCu;
        private System.Windows.Forms.TextBox txtMatKhauCu;
        private System.Windows.Forms.Label lblMatKhauMoi;
        private System.Windows.Forms.TextBox txtMatKhauMoi;
        private System.Windows.Forms.Label lblXacNhanMatKhau;
        private System.Windows.Forms.TextBox txtXacNhanMatKhau;
        private System.Windows.Forms.CheckBox chkHienMatKhau;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Button btnDoiMatKhau;
        private System.Windows.Forms.Button btnHuy;

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
            panelContent = new Panel();
            chkHienMatKhau = new CheckBox();
            txtXacNhanMatKhau = new TextBox();
            lblXacNhanMatKhau = new Label();
            txtMatKhauMoi = new TextBox();
            lblMatKhauMoi = new Label();
            txtMatKhauCu = new TextBox();
            lblMatKhauCu = new Label();
            panelButtons = new Panel();
            btnHuy = new Button();
            btnDoiMatKhau = new Button();
            panelHeader.SuspendLayout();
            panelContent.SuspendLayout();
            panelButtons.SuspendLayout();
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
            panelHeader.Size = new Size(750, 115);
            panelHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.Dock = DockStyle.Fill;
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(0, 0);
            lblTitle.Margin = new Padding(5, 0, 5, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(750, 115);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "ĐỔI MẬT KHẨU";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelContent
            // 
            panelContent.Controls.Add(chkHienMatKhau);
            panelContent.Controls.Add(txtXacNhanMatKhau);
            panelContent.Controls.Add(lblXacNhanMatKhau);
            panelContent.Controls.Add(txtMatKhauMoi);
            panelContent.Controls.Add(lblMatKhauMoi);
            panelContent.Controls.Add(txtMatKhauCu);
            panelContent.Controls.Add(lblMatKhauCu);
            panelContent.Dock = DockStyle.Fill;
            panelContent.Location = new Point(0, 115);
            panelContent.Margin = new Padding(5, 6, 5, 6);
            panelContent.Name = "panelContent";
            panelContent.Padding = new Padding(50, 38, 50, 38);
            panelContent.Size = new Size(750, 519);
            panelContent.TabIndex = 1;
            // 
            // chkHienMatKhau
            // 
            chkHienMatKhau.AutoSize = true;
            chkHienMatKhau.Font = new Font("Segoe UI", 9F);
            chkHienMatKhau.Location = new Point(50, 433);
            chkHienMatKhau.Margin = new Padding(5, 6, 5, 6);
            chkHienMatKhau.Name = "chkHienMatKhau";
            chkHienMatKhau.Size = new Size(178, 29);
            chkHienMatKhau.TabIndex = 6;
            chkHienMatKhau.Text = "Hiển thị mật khẩu";
            chkHienMatKhau.UseVisualStyleBackColor = true;
            chkHienMatKhau.CheckedChanged += chkHienMatKhau_CheckedChanged;
            // 
            // txtXacNhanMatKhau
            // 
            txtXacNhanMatKhau.Font = new Font("Segoe UI", 10F);
            txtXacNhanMatKhau.Location = new Point(50, 356);
            txtXacNhanMatKhau.Margin = new Padding(5, 6, 5, 6);
            txtXacNhanMatKhau.Name = "txtXacNhanMatKhau";
            txtXacNhanMatKhau.PasswordChar = '●';
            txtXacNhanMatKhau.Size = new Size(647, 34);
            txtXacNhanMatKhau.TabIndex = 5;
            // 
            // lblXacNhanMatKhau
            // 
            lblXacNhanMatKhau.AutoSize = true;
            lblXacNhanMatKhau.Font = new Font("Segoe UI", 10F);
            lblXacNhanMatKhau.Location = new Point(50, 308);
            lblXacNhanMatKhau.Margin = new Padding(5, 0, 5, 0);
            lblXacNhanMatKhau.Name = "lblXacNhanMatKhau";
            lblXacNhanMatKhau.Size = new Size(181, 28);
            lblXacNhanMatKhau.TabIndex = 4;
            lblXacNhanMatKhau.Text = "Xác nhận mật khẩu:";
            // 
            // txtMatKhauMoi
            // 
            txtMatKhauMoi.Font = new Font("Segoe UI", 10F);
            txtMatKhauMoi.Location = new Point(50, 231);
            txtMatKhauMoi.Margin = new Padding(5, 6, 5, 6);
            txtMatKhauMoi.Name = "txtMatKhauMoi";
            txtMatKhauMoi.PasswordChar = '●';
            txtMatKhauMoi.Size = new Size(647, 34);
            txtMatKhauMoi.TabIndex = 3;
            txtMatKhauMoi.TextChanged += txtMatKhauMoi_TextChanged;
            // 
            // lblMatKhauMoi
            // 
            lblMatKhauMoi.AutoSize = true;
            lblMatKhauMoi.Font = new Font("Segoe UI", 10F);
            lblMatKhauMoi.Location = new Point(50, 183);
            lblMatKhauMoi.Margin = new Padding(5, 0, 5, 0);
            lblMatKhauMoi.Name = "lblMatKhauMoi";
            lblMatKhauMoi.Size = new Size(137, 28);
            lblMatKhauMoi.TabIndex = 2;
            lblMatKhauMoi.Text = "Mật khẩu mới:";
            // 
            // txtMatKhauCu
            // 
            txtMatKhauCu.Font = new Font("Segoe UI", 10F);
            txtMatKhauCu.Location = new Point(50, 106);
            txtMatKhauCu.Margin = new Padding(5, 6, 5, 6);
            txtMatKhauCu.Name = "txtMatKhauCu";
            txtMatKhauCu.PasswordChar = '●';
            txtMatKhauCu.Size = new Size(647, 34);
            txtMatKhauCu.TabIndex = 1;
            txtMatKhauCu.TextChanged += txtMatKhauCu_TextChanged;
            // 
            // lblMatKhauCu
            // 
            lblMatKhauCu.AutoSize = true;
            lblMatKhauCu.Font = new Font("Segoe UI", 10F);
            lblMatKhauCu.Location = new Point(50, 58);
            lblMatKhauCu.Margin = new Padding(5, 0, 5, 0);
            lblMatKhauCu.Name = "lblMatKhauCu";
            lblMatKhauCu.Size = new Size(123, 28);
            lblMatKhauCu.TabIndex = 0;
            lblMatKhauCu.Text = "Mật khẩu cũ:";
            // 
            // panelButtons
            // 
            panelButtons.Controls.Add(btnHuy);
            panelButtons.Controls.Add(btnDoiMatKhau);
            panelButtons.Dock = DockStyle.Bottom;
            panelButtons.Location = new Point(0, 634);
            panelButtons.Margin = new Padding(5, 6, 5, 6);
            panelButtons.Name = "panelButtons";
            panelButtons.Padding = new Padding(50, 19, 50, 38);
            panelButtons.Size = new Size(750, 135);
            panelButtons.TabIndex = 2;
            // 
            // btnHuy
            // 
            btnHuy.BackColor = Color.FromArgb(108, 117, 125);
            btnHuy.FlatStyle = FlatStyle.Flat;
            btnHuy.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnHuy.ForeColor = Color.White;
            btnHuy.Location = new Point(467, 29);
            btnHuy.Margin = new Padding(5, 6, 5, 6);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(233, 77);
            btnHuy.TabIndex = 1;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = false;
            btnHuy.Click += btnHuy_Click;
            // 
            // btnDoiMatKhau
            // 
            btnDoiMatKhau.BackColor = Color.FromArgb(0, 123, 255);
            btnDoiMatKhau.FlatStyle = FlatStyle.Flat;
            btnDoiMatKhau.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnDoiMatKhau.ForeColor = Color.White;
            btnDoiMatKhau.Location = new Point(217, 29);
            btnDoiMatKhau.Margin = new Padding(5, 6, 5, 6);
            btnDoiMatKhau.Name = "btnDoiMatKhau";
            btnDoiMatKhau.Size = new Size(233, 77);
            btnDoiMatKhau.TabIndex = 0;
            btnDoiMatKhau.Text = "Đổi mật khẩu";
            btnDoiMatKhau.UseVisualStyleBackColor = false;
            btnDoiMatKhau.Click += btnDoiMatKhau_Click;
            // 
            // frmDoiMatKhau
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(750, 769);
            Controls.Add(panelContent);
            Controls.Add(panelButtons);
            Controls.Add(panelHeader);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(5, 6, 5, 6);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmDoiMatKhau";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Đổi mật khẩu";
            panelHeader.ResumeLayout(false);
            panelContent.ResumeLayout(false);
            panelContent.PerformLayout();
            panelButtons.ResumeLayout(false);
            ResumeLayout(false);
        }
    }
}