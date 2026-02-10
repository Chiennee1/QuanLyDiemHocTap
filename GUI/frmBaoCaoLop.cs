using QuanLyDiemHocTap.BUS;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace QuanLyDiemHocTap.GUI
{
    public partial class frmBaoCaoLop : Form
    {
        public frmBaoCaoLop()
        {
            InitializeComponent();
            this.Load += FrmBaoCaoLop_Load;
        }

        private void FrmBaoCaoLop_Load(object sender, EventArgs e)
        {
            LoadComboBoxes();
        }

        private void LoadComboBoxes()
        {
            try
            {
                DataTable dtNamHoc = NamHocBUS.GetAllNamHoc();
                cboNamHoc.DataSource = dtNamHoc;
                cboNamHoc.DisplayMember = "TenNamHoc";
                cboNamHoc.ValueMember = "MaNamHoc";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cboNamHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboNamHoc.SelectedValue != null)
            {
                try
                {
                    int maNamHoc = Convert.ToInt32(cboNamHoc.SelectedValue);
                    DataTable dtHocKy = HocKyBUS.GetHocKyByNamHoc(maNamHoc);
                    cboHocKy.DataSource = dtHocKy;
                    cboHocKy.DisplayMember = "TenHocKy";
                    cboHocKy.ValueMember = "MaHocKy";
                }
                catch { }
            }
        }

        private void cboHocKy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboHocKy.SelectedValue != null)
            {
                try
                {
                    DataTable dtLop = LopBUS.GetAllLop();
                    cboLop.DataSource = dtLop;
                    cboLop.DisplayMember = "TenLop";
                    cboLop.ValueMember = "MaLop";
                }
                catch { }
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
                    dgvBaoCao.Columns["MaHS"].HeaderText = "Mã HS";
                    dgvBaoCao.Columns["HoTen"].HeaderText = "Họ và tên";
                    dgvBaoCao.Columns["DiemTrungBinh"].HeaderText = "Điểm TB";
                    dgvBaoCao.Columns["TenHanhKiem"].HeaderText = "Hạnh kiểm";
                    dgvBaoCao.Columns["TenXepLoai"].HeaderText = "Xếp loại";

                    if (dgvBaoCao.Columns.Contains("DiemTrungBinh"))
                        dgvBaoCao.Columns["DiemTrungBinh"].DefaultCellStyle.Format = "N2";
                }

                // Thống kê
                TinhThongKe(dt);
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
            saveDialog.Filter = "Excel Files|*.xlsx";
            saveDialog.Title = "Xuất báo cáo";
            saveDialog.FileName = $"BaoCaoLop_{DateTime.Now:yyyyMMdd_HHmmss}.xlsx";

            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Xuất Excel đơn giản bằng cách export sang CSV
                    // Hoặc sử dụng thư viện EPPlus/NPOI cho file Excel thực
                    ExportToExcel(saveDialog.FileName);
                    MessageBox.Show("Xuất file Excel thành công!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            // Để xuất file .xlsx thật, cần cài thư viện EPPlus hoặc NPOI

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

            // Lưu file
            System.IO.File.WriteAllText(filePath.Replace(".xlsx", ".csv"),
                sb.ToString(), System.Text.Encoding.UTF8);
        }
    }
}
