using QuanLyDiemHocTap.BUS;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace QuanLyDienHocTap.GUI
{
    public partial class frmTongKet : Form
    {
        #region Fields
        private int _currentMaHS = 0;
        private bool _isLoading = false;
        #endregion

        #region Constructor
        public frmTongKet()
        {
            InitializeComponent();
            this.Load += FrmTongKet_Load;
        }
        #endregion

        #region Form Events
        private void FrmTongKet_Load(object sender, EventArgs e)
        {
            try
            {
                _isLoading = true;
                LoadComboBoxes();
                _isLoading = false;

                // Load cascade các ComboBox con
                if (cboNamHoc.SelectedValue != null)
                {
                    cboNamHoc_SelectedIndexChanged(null, null);

                    if (cboHocKy.SelectedValue != null)
                    {
                        cboHocKy_SelectedIndexChanged(null, null);
                    }
                }

                ClearForm();
                SetButtonStates(false);
            }
            catch (Exception ex)
            {
                _isLoading = false;
                MessageBox.Show($"Lỗi khởi tạo form: {ex.Message}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Load Data Methods
        private void LoadComboBoxes()
        {
            try
            {
                // Load Năm học
                DataTable dtNamHoc = NamHocBUS.GetAllNamHoc();
                if (dtNamHoc != null && dtNamHoc.Rows.Count > 0)
                {
                    cboNamHoc.DataSource = dtNamHoc;
                    cboNamHoc.DisplayMember = "TenNamHoc";
                    cboNamHoc.ValueMember = "MaNamHoc";
                }
                else
                {
                    MessageBox.Show("Không có dữ liệu năm học. Vui lòng thêm năm học trước!",
                        "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                // Load Hạnh kiểm
                DataTable dtHanhKiem = HanhKiemBUS.GetAllHanhKiem();
                if (dtHanhKiem != null && dtHanhKiem.Rows.Count > 0)
                {
                    cboHanhKiem.DataSource = dtHanhKiem;
                    cboHanhKiem.DisplayMember = "TenHanhKiem";
                    cboHanhKiem.ValueMember = "MaHanhKiem";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi tải dữ liệu: {ex.Message}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadDanhSachHocSinh()
        {
            if (!ValidateFilter())
            {
                return;
            }

            try
            {
                int maLop = Convert.ToInt32(cboLop.SelectedValue);
                int maHocKy = Convert.ToInt32(cboHocKy.SelectedValue);

                // Tải danh sách học sinh với điểm và xếp loại
                DataTable dt = KetQuaHocTapBUS.GetKetQuaByLop(maLop, maHocKy);

                // Tính điểm trung bình cho từng học sinh nếu chưa có
                foreach (DataRow row in dt.Rows)
                {
                    if (row["DiemTrungBinh"] == DBNull.Value || Convert.ToDecimal(row["DiemTrungBinh"]) == 0)
                    {
                        int maHS = Convert.ToInt32(row["MaHS"]);
                        decimal diemTB = KetQuaHocTapBUS.TinhDiemTrungBinhHocKy(maHS, maHocKy);
                        row["DiemTrungBinh"] = diemTB;
                    }
                }

                dgvDanhSach.DataSource = dt;
                ConfigureDataGridView();

                lblTongSo.Text = $"Tổng số: {dt.Rows.Count} học sinh";
                TinhThongKe(dt);

                ClearForm();
                SetButtonStates(false);

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Lớp này chưa có học sinh hoặc chưa có kết quả!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi tải danh sách: {ex.Message}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConfigureDataGridView()
        {
            if (dgvDanhSach.Columns.Count > 0)
            {
                // Ẩn các cột không cần thiết
                if (dgvDanhSach.Columns.Contains("MaHanhKiem"))
                    dgvDanhSach.Columns["MaHanhKiem"].Visible = false;
                if (dgvDanhSach.Columns.Contains("MaXepLoai"))
                    dgvDanhSach.Columns["MaXepLoai"].Visible = false;
                if (dgvDanhSach.Columns.Contains("MaHocKy"))
                    dgvDanhSach.Columns["MaHocKy"].Visible = false;
                if (dgvDanhSach.Columns.Contains("GhiChu"))
                    dgvDanhSach.Columns["GhiChu"].Visible = false;

                // Đặt tiêu đề và format
                dgvDanhSach.Columns["MaHS"].HeaderText = "Mã HS";
                dgvDanhSach.Columns["MaHS"].Width = 80;
                dgvDanhSach.Columns["HoTen"].HeaderText = "Họ và tên";
                dgvDanhSach.Columns["HoTen"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvDanhSach.Columns["DiemTrungBinh"].HeaderText = "Điểm TB";
                dgvDanhSach.Columns["DiemTrungBinh"].Width = 100;
                dgvDanhSach.Columns["DiemTrungBinh"].DefaultCellStyle.Format = "N2";
                dgvDanhSach.Columns["DiemTrungBinh"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                if (dgvDanhSach.Columns.Contains("TenHanhKiem"))
                {
                    dgvDanhSach.Columns["TenHanhKiem"].HeaderText = "Hạnh kiểm";
                    dgvDanhSach.Columns["TenHanhKiem"].Width = 120;
                }

                if (dgvDanhSach.Columns.Contains("TenXepLoai"))
                {
                    dgvDanhSach.Columns["TenXepLoai"].HeaderText = "Xếp loại";
                    dgvDanhSach.Columns["TenXepLoai"].Width = 120;
                }
            }
        }
        #endregion

        #region ComboBox Events
        private void cboNamHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_isLoading) return; // Bỏ qua khi đang load

            if (cboNamHoc.SelectedValue != null && cboNamHoc.SelectedValue.GetType() != typeof(DataRowView))
            {
                try
                {
                    int maNamHoc = Convert.ToInt32(cboNamHoc.SelectedValue);
                    DataTable dtHocKy = HocKyBUS.GetHocKyByNamHoc(maNamHoc);

                    if (dtHocKy != null && dtHocKy.Rows.Count > 0)
                    {
                        cboHocKy.DataSource = dtHocKy;
                        cboHocKy.DisplayMember = "TenHocKy";
                        cboHocKy.ValueMember = "MaHocKy";
                    }
                    else
                    {
                        cboHocKy.DataSource = null;
                        cboLop.DataSource = null;
                        MessageBox.Show("Năm học này chưa có học kỳ!", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi tải học kỳ: {ex.Message}", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void cboHocKy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_isLoading) return; // Bỏ qua khi đang load

            if (cboHocKy.SelectedValue != null && cboHocKy.SelectedValue.GetType() != typeof(DataRowView))
            {
                try
                {
                    DataTable dtLop = LopBUS.GetAllLop();

                    if (dtLop != null && dtLop.Rows.Count > 0)
                    {
                        cboLop.DataSource = dtLop;
                        cboLop.DisplayMember = "TenLop";
                        cboLop.ValueMember = "MaLop";
                    }
                    else
                    {
                        cboLop.DataSource = null;
                        MessageBox.Show("Chưa có lớp học!", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi tải lớp: {ex.Message}", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void cboLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Không cần xử lý gì, chỉ để event handler tồn tại
        }
        #endregion

        #region Button Events
        private void btnTaiDanhSach_Click(object sender, EventArgs e)
        {
            LoadDanhSachHocSinh();
        }

        private void btnTongKet_Click(object sender, EventArgs e)
        {
            if (_currentMaHS == 0)
            {
                MessageBox.Show("Vui lòng chọn học sinh!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cboHanhKiem.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn hạnh kiểm!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int maHocKy = Convert.ToInt32(cboHocKy.SelectedValue);
                int maHanhKiem = Convert.ToInt32(cboHanhKiem.SelectedValue);

                string error;
                if (KetQuaHocTapBUS.TongKetHocKy(_currentMaHS, maHocKy, maHanhKiem, out error))
                {
                    MessageBox.Show("Tổng kết thành công!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDanhSachHocSinh();
                }
                else
                {
                    MessageBox.Show(error, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTongKetTatCa_Click(object sender, EventArgs e)
        {
            if (!ValidateFilter())
            {
                MessageBox.Show("Vui lòng chọn đầy đủ thông tin!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dgvDanhSach.Rows.Count == 0)
            {
                MessageBox.Show("Không có học sinh nào để tổng kết!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cboHanhKiem.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn hạnh kiểm mặc định!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show(
                "Bạn có chắc muốn tổng kết cho tất cả học sinh trong lớp?\n" +
                "Hạnh kiểm mặc định sẽ được áp dụng cho tất cả học sinh.",
                "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    int maHocKy = Convert.ToInt32(cboHocKy.SelectedValue);
                    int maHanhKiem = Convert.ToInt32(cboHanhKiem.SelectedValue);
                    int success = 0;
                    int total = dgvDanhSach.Rows.Count;

                    SetButtonStates(false);
                    Cursor = Cursors.WaitCursor;

                    foreach (DataGridViewRow row in dgvDanhSach.Rows)
                    {
                        if (row.Cells["MaHS"].Value != null)
                        {
                            int maHS = Convert.ToInt32(row.Cells["MaHS"].Value);
                            string error;
                            if (KetQuaHocTapBUS.TongKetHocKy(maHS, maHocKy, maHanhKiem, out error))
                            {
                                success++;
                            }
                        }
                    }

                    Cursor = Cursors.Default;
                    MessageBox.Show($"Tổng kết thành công {success}/{total} học sinh!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDanhSachHocSinh();
                }
                catch (Exception ex)
                {
                    Cursor = Cursors.Default;
                    MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnXuatExcel_Click(object sender, EventArgs e)
        {
            if (dgvDanhSach.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để xuất!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SaveFileDialog saveDialog = new SaveFileDialog
            {
                Filter = "CSV Files|*.csv",
                Title = "Xuất kết quả tổng kết",
                FileName = $"KetQuaTongKet_{DateTime.Now:yyyyMMdd_HHmmss}.csv"
            };

            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    ExportToCsv(saveDialog.FileName);
                    MessageBox.Show("Xuất file thành công!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Mở file sau khi xuất
                    System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                    {
                        FileName = saveDialog.FileName,
                        UseShellExecute = true
                    });
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi xuất file: {ex.Message}", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        #endregion

        #region DataGridView Events
        private void dgvDanhSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvDanhSach.Rows.Count)
            {
                DataGridViewRow row = dgvDanhSach.Rows[e.RowIndex];

                if (row.Cells["MaHS"].Value != null)
                {
                    _currentMaHS = Convert.ToInt32(row.Cells["MaHS"].Value);
                    txtHoTen.Text = row.Cells["HoTen"].Value?.ToString() ?? "";

                    if (row.Cells["DiemTrungBinh"].Value != DBNull.Value)
                    {
                        decimal diemTB = Convert.ToDecimal(row.Cells["DiemTrungBinh"].Value);
                        txtDiemTB.Text = diemTB.ToString("N2");

                        // Đổi màu điểm theo mức xếp loại
                        if (diemTB >= 8.0m)
                            txtDiemTB.ForeColor = Color.Green;
                        else if (diemTB >= 6.5m)
                            txtDiemTB.ForeColor = Color.Blue;
                        else if (diemTB >= 5.0m)
                            txtDiemTB.ForeColor = Color.Orange;
                        else
                            txtDiemTB.ForeColor = Color.Red;
                    }
                    else
                    {
                        txtDiemTB.Text = "0.00";
                        txtDiemTB.ForeColor = Color.Black;
                    }

                    SetButtonStates(true);
                }
            }
        }
        #endregion

        #region Helper Methods
        private void ClearForm()
        {
            _currentMaHS = 0;
            txtHoTen.Clear();
            txtDiemTB.Clear();
            txtDiemTB.ForeColor = Color.Black;
            if (cboHanhKiem.Items.Count > 0)
                cboHanhKiem.SelectedIndex = 0;
        }

        private void SetButtonStates(bool hasSelection)
        {
            btnTongKet.Enabled = hasSelection;
        }

        private bool ValidateFilter()
        {
            if (cboNamHoc.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn năm học!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboNamHoc.Focus();
                return false;
            }

            if (cboHocKy.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn học kỳ!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboHocKy.Focus();
                return false;
            }

            if (cboLop.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn lớp!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboLop.Focus();
                return false;
            }

            return true;
        }

        private void TinhThongKe(DataTable dt)
        {
            int tongSo = dt.Rows.Count;
            int soGioi = 0, soKha = 0, soTrungBinh = 0, soYeu = 0;

            foreach (DataRow row in dt.Rows)
            {
                string xepLoai = row["TenXepLoai"]?.ToString() ?? "";
                switch (xepLoai)
                {
                    case "Giỏi":
                        soGioi++;
                        break;
                    case "Khá":
                        soKha++;
                        break;
                    case "Trung bình":
                        soTrungBinh++;
                        break;
                    case "Yếu":
                        soYeu++;
                        break;
                }
            }

            double phanTramGioi = tongSo > 0 ? (soGioi * 100.0 / tongSo) : 0;
            double phanTramKha = tongSo > 0 ? (soKha * 100.0 / tongSo) : 0;
            double phanTramTB = tongSo > 0 ? (soTrungBinh * 100.0 / tongSo) : 0;
            double phanTramYeu = tongSo > 0 ? (soYeu * 100.0 / tongSo) : 0;

            lblThongKe.Text = $"Giỏi: {soGioi} ({phanTramGioi:F1}%)  |  " +
                             $"Khá: {soKha} ({phanTramKha:F1}%)  |  " +
                             $"TB: {soTrungBinh} ({phanTramTB:F1}%)  |  " +
                             $"Yếu: {soYeu} ({phanTramYeu:F1}%)";
        }

        private void ExportToCsv(string filePath)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();

            // Header
            for (int i = 0; i < dgvDanhSach.Columns.Count; i++)
            {
                if (dgvDanhSach.Columns[i].Visible)
                {
                    sb.Append(dgvDanhSach.Columns[i].HeaderText);
                    if (i < dgvDanhSach.Columns.Count - 1)
                        sb.Append(",");
                }
            }
            sb.AppendLine();

            // Data rows
            foreach (DataGridViewRow row in dgvDanhSach.Rows)
            {
                for (int i = 0; i < dgvDanhSach.Columns.Count; i++)
                {
                    if (dgvDanhSach.Columns[i].Visible)
                    {
                        if (row.Cells[i].Value != null)
                            sb.Append(row.Cells[i].Value.ToString());

                        if (i < dgvDanhSach.Columns.Count - 1)
                            sb.Append(",");
                    }
                }
                sb.AppendLine();
            }

            // Thêm thống kê
            sb.AppendLine();
            sb.AppendLine(lblThongKe.Text);
            sb.AppendLine(lblTongSo.Text);

            // Lưu file với UTF-8 BOM để Excel hiển thị tiếng Việt đúng
            System.IO.File.WriteAllText(filePath, sb.ToString(),
                new System.Text.UTF8Encoding(true));
        }
        #endregion
    }
}