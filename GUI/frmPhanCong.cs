using QuanLyDiemHocTap.BUS;
using QuanLyDiemHocTap.DTO;
using System;
using System.Data;
using System.Windows.Forms;

namespace QuanLyDiemHocTap.GUI
{
    public partial class frmPhanCong : Form
    {
        private int selectedMaPhanCong = -1;
        private bool isLoading = false;

        public frmPhanCong()
        {
            InitializeComponent();
            this.Load += FrmPhanCong_Load;
        }

        private void FrmPhanCong_Load(object sender, EventArgs e)
        {
            try
            {
                isLoading = true;
                LoadComboBoxes();
                LoadData();
                isLoading = false;

                // Load cascade các ComboBox con
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
                // Load Năm học
                DataTable dtNamHoc = NamHocBUS.GetAllNamHoc();
                if (dtNamHoc != null && dtNamHoc.Rows.Count > 0)
                {
                    cboNamHoc.DataSource = dtNamHoc;
                    cboNamHoc.DisplayMember = "TenNamHoc";
                    cboNamHoc.ValueMember = "MaNamHoc";
                }

                // Load Giáo viên
                DataTable dtGV = GiaoVienBUS.GetAllGiaoVien();
                if (dtGV != null && dtGV.Rows.Count > 0)
                {
                    cboGiaoVien.DataSource = dtGV;
                    cboGiaoVien.DisplayMember = "HoTen";
                    cboGiaoVien.ValueMember = "MaGV";
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
            if (isLoading) return;

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
                        cboMonHoc.DataSource = null;
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
            if (isLoading) return;

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
                        cboMonHoc.DataSource = null;
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
            if (isLoading) return;

            if (cboLop.SelectedValue != null && cboLop.SelectedValue.GetType() != typeof(DataRowView))
            {
                try
                {
                    int maLop = Convert.ToInt32(cboLop.SelectedValue);
                    DataTable dtLop = LopBUS.GetAllLop();
                    DataRow[] rows = dtLop.Select($"MaLop = {maLop}");

                    if (rows.Length > 0 && rows[0].Table.Columns.Contains("MaKhoi") && rows[0]["MaKhoi"] != DBNull.Value)
                    {
                        int maKhoi = Convert.ToInt32(rows[0]["MaKhoi"]);
                        DataTable dtMonHoc = MonHocBUS.GetMonHocByKhoi(maKhoi);

                        if (dtMonHoc != null && dtMonHoc.Rows.Count > 0)
                        {
                            cboMonHoc.DataSource = dtMonHoc;
                            cboMonHoc.DisplayMember = "TenMonHoc";
                            cboMonHoc.ValueMember = "MaMonHoc";
                        }
                        else
                        {
                            cboMonHoc.DataSource = null;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi tải môn học: " + ex.Message, "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void LoadData()
        {
            try
            {
                DataTable dt = PhanCongBUS.GetAllPhanCong();
                dgvPhanCong.DataSource = dt;

                if (dgvPhanCong.Columns.Count > 0)
                {
                    // Ẩn các cột ID
                    if (dgvPhanCong.Columns.Contains("MaPhanCong"))
                        dgvPhanCong.Columns["MaPhanCong"].Visible = false;
                    if (dgvPhanCong.Columns.Contains("MaGV"))
                        dgvPhanCong.Columns["MaGV"].Visible = false;
                    if (dgvPhanCong.Columns.Contains("MaLop"))
                        dgvPhanCong.Columns["MaLop"].Visible = false;
                    if (dgvPhanCong.Columns.Contains("MaMonHoc"))
                        dgvPhanCong.Columns["MaMonHoc"].Visible = false;
                    if (dgvPhanCong.Columns.Contains("MaHocKy"))
                        dgvPhanCong.Columns["MaHocKy"].Visible = false;

                    // Đặt tiêu đề
                    if (dgvPhanCong.Columns.Contains("TenGV"))
                        dgvPhanCong.Columns["TenGV"].HeaderText = "Giáo viên";
                    if (dgvPhanCong.Columns.Contains("TenLop"))
                        dgvPhanCong.Columns["TenLop"].HeaderText = "Lớp";
                    if (dgvPhanCong.Columns.Contains("TenMonHoc"))
                        dgvPhanCong.Columns["TenMonHoc"].HeaderText = "Môn học";
                    if (dgvPhanCong.Columns.Contains("TenHocKy"))
                        dgvPhanCong.Columns["TenHocKy"].HeaderText = "Học kỳ";

                    dgvPhanCong.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }

                lblTongSo.Text = $"Tổng số: {dt.Rows.Count} phân công";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (cboGiaoVien.SelectedValue == null || cboLop.SelectedValue == null ||
                cboMonHoc.SelectedValue == null || cboHocKy.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn đầy đủ thông tin!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                PhanCongDTO pc = new PhanCongDTO
                {
                    MaGV = Convert.ToInt32(cboGiaoVien.SelectedValue),
                    MaLop = Convert.ToInt32(cboLop.SelectedValue),
                    MaMonHoc = Convert.ToInt32(cboMonHoc.SelectedValue),
                    MaHocKy = Convert.ToInt32(cboHocKy.SelectedValue)
                };

                string error;
                if (PhanCongBUS.ThemPhanCong(pc, out error))
                {
                    MessageBox.Show("Phân công thành công!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
                else
                {
                    MessageBox.Show(error, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thêm phân công: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvPhanCong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvPhanCong.Rows.Count)
            {
                try
                {
                    DataGridViewRow row = dgvPhanCong.Rows[e.RowIndex];
                    if (row.Cells["MaPhanCong"].Value != null && row.Cells["MaPhanCong"].Value != DBNull.Value)
                    {
                        selectedMaPhanCong = Convert.ToInt32(row.Cells["MaPhanCong"].Value);
                        btnXoa.Enabled = true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi chọn phân công: " + ex.Message, "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (selectedMaPhanCong == -1)
            {
                MessageBox.Show("Vui lòng chọn phân công cần xóa!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa phân công này?",
                "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    string error;
                    if (PhanCongBUS.XoaPhanCong(selectedMaPhanCong, out error))
                    {
                        MessageBox.Show("Xóa phân công thành công!", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData();
                        selectedMaPhanCong = -1;
                        btnXoa.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show(error, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa phân công: " + ex.Message, "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}