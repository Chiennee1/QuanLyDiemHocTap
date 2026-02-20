using QuanLyDiemHocTap.BUS;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace QuanLyDiemHocTap.GUI
{
    public partial class frmBaoCaoLop : Form
    {
        private bool isLoading = false; // Thêm biến flag

        public frmBaoCaoLop()
        {
            InitializeComponent();
            this.Load += FrmBaoCaoLop_Load;
        }

        private void FrmBaoCaoLop_Load(object sender, EventArgs e)
        {
            try
            {
                isLoading = true;
                LoadComboBoxes();
                isLoading = false;

                // Load cascade các ComboBox con
                if (cboNamHoc.SelectedValue != null)
                {
                    cboNamHoc_SelectedIndexChanged(null, null);

                    if (cboHocKy.SelectedValue != null)
                    {
                        cboHocKy_SelectedIndexChanged(null, null);
                    }
                }
            }
            catch (Exception ex)
            {
                isLoading = false;
                MessageBox.Show("Lỗi khi tải form: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadComboBoxes()
        {
            try
            {
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
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cboNamHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isLoading) return; // Bỏ qua khi đang load

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
                    MessageBox.Show("Lỗi khi tải học kỳ: " + ex.Message, "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void cboHocKy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isLoading) return; // Bỏ qua khi đang load

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
                    MessageBox.Show("Lỗi khi tải lớp: " + ex.Message, "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnXemBaoCao_Click(object sender, EventArgs e)
        {
            if (cboLop.SelectedValue == null || cboHocKy.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn đầy đủ thông tin!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int maLop = Convert.ToInt32(cboLop.SelectedValue);
                int maHocKy = Convert.ToInt32(cboHocKy.SelectedValue);

                // Lấy kết quả tổng kết của lớp
                DataTable dt = KetQuaHocTapBUS.GetKetQuaByLop(maLop, maHocKy);
                dgvBaoCao.DataSource = dt;

                if (dgvBaoCao.Columns.Count > 0)
                {
                    // Ẩn các cột không cần thiết
                    if (dgvBaoCao.Columns.Contains("MaXepLoai"))
                        dgvBaoCao.Columns["MaXepLoai"].Visible = false;
                    if (dgvBaoCao.Columns.Contains("MaHanhKiem"))
                        dgvBaoCao.Columns["MaHanhKiem"].Visible = false;
                    if (dgvBaoCao.Columns.Contains("MaHocKy"))
                        dgvBaoCao.Columns["MaHocKy"].Visible = false;
                    if (dgvBaoCao.Columns.Contains("GhiChu"))
                        dgvBaoCao.Columns["GhiChu"].Visible = false;

                    // Đặt tiêu đề
                    if (dgvBaoCao.Columns.Contains("MaHS"))
                        dgvBaoCao.Columns["MaHS"].HeaderText = "Mã HS";
                    if (dgvBaoCao.Columns.Contains("HoTen"))
                        dgvBaoCao.Columns["HoTen"].HeaderText = "Họ và tên";
                    if (dgvBaoCao.Columns.Contains("DiemTrungBinh"))
                    {
                        dgvBaoCao.Columns["DiemTrungBinh"].HeaderText = "Điểm TB";
                        dgvBaoCao.Columns["DiemTrungBinh"].DefaultCellStyle.Format = "N2";
                    }
                    if (dgvBaoCao.Columns.Contains("TenHanhKiem"))
                        dgvBaoCao.Columns["TenHanhKiem"].HeaderText = "Hạnh kiểm";
                    if (dgvBaoCao.Columns.Contains("TenXepLoai"))
                        dgvBaoCao.Columns["TenXepLoai"].HeaderText = "Xếp loại";

                    dgvBaoCao.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }

                // Thống kê
                TinhThongKe(dt);

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Lớp này chưa có kết quả tổng kết!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TinhThongKe(DataTable dt)
        {
            int tongSo = dt.Rows.Count;
            int soGioi = 0, soKha = 0, soTB = 0, soYeu = 0;
            decimal tongDiem = 0;

            foreach (DataRow row in dt.Rows)
            {
                string xepLoai = row["TenXepLoai"]?.ToString() ?? "";

                if (row["DiemTrungBinh"] != DBNull.Value)
                    tongDiem += Convert.ToDecimal(row["DiemTrungBinh"]);

                switch (xepLoai)
                {
                    case "Giỏi": soGioi++; break;
                    case "Khá": soKha++; break;
                    case "Trung bình": soTB++; break;
                    case "Yếu": soYeu++; break;
                }
            }

            decimal diemTBLop = tongSo > 0 ? tongDiem / tongSo : 0;

            // Tính phần trăm
            double phanTramGioi = tongSo > 0 ? (soGioi * 100.0 / tongSo) : 0;
            double phanTramKha = tongSo > 0 ? (soKha * 100.0 / tongSo) : 0;
            double phanTramTB = tongSo > 0 ? (soTB * 100.0 / tongSo) : 0;
            double phanTramYeu = tongSo > 0 ? (soYeu * 100.0 / tongSo) : 0;

            lblThongKe.Text = $"Tổng số: {tongSo} | " +
                             $"Giỏi: {soGioi} ({phanTramGioi:F1}%) | " +
                             $"Khá: {soKha} ({phanTramKha:F1}%) | " +
                             $"TB: {soTB} ({phanTramTB:F1}%) | " +
                             $"Yếu: {soYeu} ({phanTramYeu:F1}%)";

            lblDiemTBLop.Text = $"Điểm TB lớp: {diemTBLop:N2}";
        }

        private void btnXuatExcel_Click(object sender, EventArgs e)
        {
            if (dgvBaoCao.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để xuất!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = "CSV Files|*.csv";
            saveDialog.Title = "Xuất báo cáo";
            saveDialog.FileName = $"BaoCaoLop_{DateTime.Now:yyyyMMdd_HHmmss}.csv";

            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    ExportToExcel(saveDialog.FileName);
                    MessageBox.Show("Xuất file thành công!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Mở file sau khi xuất
                    System.Diagnostics.Process.Start(saveDialog.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xuất file: " + ex.Message, "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ExportToExcel(string filePath)
        {
            // Phương pháp đơn giản: Xuất ra CSV (có thể mở bằng Excel)
            System.Text.StringBuilder sb = new System.Text.StringBuilder();

            // Header
            for (int i = 0; i < dgvBaoCao.Columns.Count; i++)
            {
                if (dgvBaoCao.Columns[i].Visible)
                {
                    sb.Append(dgvBaoCao.Columns[i].HeaderText);
                    if (i < dgvBaoCao.Columns.Count - 1)
                        sb.Append(",");
                }
            }
            sb.AppendLine();

            // Data rows
            foreach (DataGridViewRow row in dgvBaoCao.Rows)
            {
                for (int i = 0; i < dgvBaoCao.Columns.Count; i++)
                {
                    if (dgvBaoCao.Columns[i].Visible)
                    {
                        if (row.Cells[i].Value != null)
                            sb.Append(row.Cells[i].Value.ToString());

                        if (i < dgvBaoCao.Columns.Count - 1)
                            sb.Append(",");
                    }
                }
                sb.AppendLine();
            }

            // Thêm thống kê
            sb.AppendLine();
            sb.AppendLine(lblThongKe.Text);
            sb.AppendLine(lblDiemTBLop.Text);

            // Lưu file với UTF-8 BOM để Excel hiển thị tiếng Việt đúng
            System.IO.File.WriteAllText(filePath, sb.ToString(),
                new System.Text.UTF8Encoding(true));
        }
    }
}