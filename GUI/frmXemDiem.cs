using QuanLyDiemHocTap.BUS;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace QuanLyDiemHocTap.GUI
{
    public partial class frmXemDiem : Form
    {
        private bool isLoading = false; // Flag để tránh sự kiện fire khi đang load

        public frmXemDiem()
        {
            InitializeComponent();
            this.Load += FrmXemDiem_Load;
        }

        private void FrmXemDiem_Load(object sender, EventArgs e)
        {
            try
            {
                isLoading = true;
                LoadComboBoxes();
                isLoading = false;

                if (cboNamHoc.SelectedValue != null)
                {
                    cboNamHoc_SelectedIndexChanged(null, null);

                    if (cboHocKy.SelectedValue != null)
                    {
                        cboHocKy_SelectedIndexChanged(null, null);

                        if (cboLop.SelectedValue != null)
                        {
                            cboLop_SelectedIndexChanged(null, null);
                        }
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
                MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message + "\n\nChi tiết: " + ex.StackTrace,
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                        cboHocSinh.DataSource = null;
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
                        cboHocSinh.DataSource = null;
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

        private void cboLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isLoading) return; // Bỏ qua khi đang load

            if (cboLop.SelectedValue != null && cboLop.SelectedValue.GetType() != typeof(DataRowView) &&
                cboHocKy.SelectedValue != null && cboHocKy.SelectedValue.GetType() != typeof(DataRowView))
            {
                try
                {
                    int maLop = Convert.ToInt32(cboLop.SelectedValue);
                    int maHocKy = Convert.ToInt32(cboHocKy.SelectedValue);

                    DataTable dtHS = HocSinhBUS.GetHocSinhByLop(maLop, maHocKy);

                    if (dtHS != null && dtHS.Rows.Count > 0)
                    {
                        cboHocSinh.DataSource = dtHS;
                        cboHocSinh.DisplayMember = "HoTen";
                        cboHocSinh.ValueMember = "MaHS";
                    }
                    else
                    {
                        cboHocSinh.DataSource = null;
                        MessageBox.Show("Lớp này chưa có học sinh!", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi tải học sinh: " + ex.Message, "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnXemDiem_Click(object sender, EventArgs e)
        {
            if (cboHocSinh.SelectedValue == null || cboHocKy.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn đầy đủ thông tin (Năm học, Học kỳ, Lớp, Học sinh)!",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int maHS = Convert.ToInt32(cboHocSinh.SelectedValue);
                int maHocKy = Convert.ToInt32(cboHocKy.SelectedValue);

                // Hiển thị điểm chi tiết
                DataTable dtDiem = DiemBUS.GetDiemByHocSinh(maHS, maHocKy);

                if (dtDiem != null)
                {
                    dgvDiem.DataSource = dtDiem;

                    if (dgvDiem.Columns.Count > 0)
                    {
                        // Ẩn các cột không cần thiết
                        if (dgvDiem.Columns.Contains("MaDiem"))
                            dgvDiem.Columns["MaDiem"].Visible = false;
                        if (dgvDiem.Columns.Contains("MaHS"))
                            dgvDiem.Columns["MaHS"].Visible = false;
                        if (dgvDiem.Columns.Contains("MaMonHoc"))
                            dgvDiem.Columns["MaMonHoc"].Visible = false;
                        if (dgvDiem.Columns.Contains("MaHocKy"))
                            dgvDiem.Columns["MaHocKy"].Visible = false;
                        if (dgvDiem.Columns.Contains("MaLoaiDiem"))
                            dgvDiem.Columns["MaLoaiDiem"].Visible = false;

                        // Đặt tiêu đề cho các cột
                        if (dgvDiem.Columns.Contains("TenMonHoc"))
                            dgvDiem.Columns["TenMonHoc"].HeaderText = "Môn học";
                        if (dgvDiem.Columns.Contains("TenLoaiDiem"))
                            dgvDiem.Columns["TenLoaiDiem"].HeaderText = "Loại điểm";
                        if (dgvDiem.Columns.Contains("DiemSo"))
                        {
                            dgvDiem.Columns["DiemSo"].HeaderText = "Điểm";
                            dgvDiem.Columns["DiemSo"].DefaultCellStyle.Format = "N2";
                        }
                        if (dgvDiem.Columns.Contains("HeSo"))
                            dgvDiem.Columns["HeSo"].HeaderText = "Hệ số";
                        if (dgvDiem.Columns.Contains("NgayNhap"))
                        {
                            dgvDiem.Columns["NgayNhap"].HeaderText = "Ngày nhập";
                            dgvDiem.Columns["NgayNhap"].DefaultCellStyle.Format = "dd/MM/yyyy";
                        }
                        if (dgvDiem.Columns.Contains("GhiChu"))
                            dgvDiem.Columns["GhiChu"].HeaderText = "Ghi chú";

                        // Tự động điều chỉnh độ rộng cột
                        dgvDiem.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    }

                    if (dtDiem.Rows.Count == 0)
                    {
                        MessageBox.Show("Học sinh này chưa có điểm!", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

                // Tính và hiển thị điểm trung bình các môn
                TinhDiemTrungBinhCacMon(maHS, maHocKy);

                // Hiển thị kết quả tổng kết
                HienThiKetQuaTongKet(maHS, maHocKy);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xem điểm: " + ex.Message + "\n\nChi tiết: " + ex.StackTrace,
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TinhDiemTrungBinhCacMon(int maHS, int maHocKy)
        {
            try
            {
                DataTable dtMonHoc = MonHocBUS.GetAllMonHoc();

                if (dtMonHoc == null || dtMonHoc.Rows.Count == 0)
                {
                    dgvDiemTB.DataSource = null;
                    return;
                }

                DataTable dtKetQua = new DataTable();
                dtKetQua.Columns.Add("MonHoc", typeof(string));
                dtKetQua.Columns.Add("DiemTB", typeof(decimal));

                foreach (DataRow row in dtMonHoc.Rows)
                {
                    int maMonHoc = Convert.ToInt32(row["MaMonHoc"]);
                    decimal diemTB = DiemBUS.TinhDiemTrungBinhMon(maHS, maMonHoc, maHocKy);

                    if (diemTB > 0)
                    {
                        DataRow newRow = dtKetQua.NewRow();
                        newRow["MonHoc"] = row["TenMonHoc"];
                        newRow["DiemTB"] = diemTB;
                        dtKetQua.Rows.Add(newRow);
                    }
                }

                dgvDiemTB.DataSource = dtKetQua;

                if (dgvDiemTB.Columns.Count > 0)
                {
                    dgvDiemTB.Columns["MonHoc"].HeaderText = "Môn học";
                    dgvDiemTB.Columns["DiemTB"].HeaderText = "Điểm TB";
                    dgvDiemTB.Columns["DiemTB"].DefaultCellStyle.Format = "N2";

                    // Tự động điều chỉnh độ rộng cột
                    dgvDiemTB.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }

                if (dtKetQua.Rows.Count == 0)
                {
                    // Không hiển thị thông báo ở đây vì có thể học sinh chưa có điểm
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tính điểm trung bình: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void HienThiKetQuaTongKet(int maHS, int maHocKy)
        {
            try
            {
                decimal diemTBHK = KetQuaHocTapBUS.TinhDiemTrungBinhHocKy(maHS, maHocKy);

                DataTable dtKetQua = KetQuaHocTapBUS.GetKetQuaByHocSinh(maHS, maHocKy);

                if (dtKetQua != null && dtKetQua.Rows.Count > 0)
                {
                    DataRow row = dtKetQua.Rows[0];

                    lblDiemTBHK.Text = $"Điểm TB học kỳ: {diemTBHK:N2}";

                    // Kiểm tra xem các cột có tồn tại không
                    if (row.Table.Columns.Contains("TenHanhKiem") && row["TenHanhKiem"] != DBNull.Value)
                    {
                        lblHanhKiem.Text = $"Hạnh kiểm: {row["TenHanhKiem"]}";
                    }
                    else
                    {
                        lblHanhKiem.Text = "Hạnh kiểm: Chưa đánh giá";
                    }

                    if (row.Table.Columns.Contains("TenXepLoai") && row["TenXepLoai"] != DBNull.Value)
                    {
                        lblXepLoai.Text = $"Xếp loại: {row["TenXepLoai"]}";
                    }
                    else
                    {
                        lblXepLoai.Text = "Xếp loại: Chưa xếp loại";
                    }
                }
                else
                {
                    lblDiemTBHK.Text = diemTBHK > 0 ? $"Điểm TB học kỳ: {diemTBHK:N2}" : "Điểm TB học kỳ: Chưa có";
                    lblHanhKiem.Text = "Hạnh kiểm: Chưa đánh giá";
                    lblXepLoai.Text = "Xếp loại: Chưa xếp loại";
                }

                // Đổi màu dựa vào điểm TB
                if (diemTBHK >= 8.0m)
                {
                    lblDiemTBHK.ForeColor = Color.Green;
                }
                else if (diemTBHK >= 6.5m)
                {
                    lblDiemTBHK.ForeColor = Color.Blue;
                }
                else if (diemTBHK >= 5.0m)
                {
                    lblDiemTBHK.ForeColor = Color.Orange;
                }
                else if (diemTBHK > 0)
                {
                    lblDiemTBHK.ForeColor = Color.Red;
                }
                else
                {
                    lblDiemTBHK.ForeColor = Color.Black;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hiển thị kết quả: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}