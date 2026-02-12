using QuanLyDiemHocTap.BUS;
using QuanLyDiemHocTap.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDiemHocTap.GUI
{
    public partial class frmNhapDiem : Form
    {
        private int selectedMaDiem = -1;
        private bool isLoading = false; // Flag để tránh sự kiện fire khi đang load

        public frmNhapDiem()
        {
            InitializeComponent();
            this.Load += FrmNhapDiem_Load;
        }

        private void FrmNhapDiem_Load(object sender, EventArgs e)
        {
            try
            {
                isLoading = true;
                LoadComboBoxes();
                dtpNgayNhap.Value = DateTime.Now;

                // Vô hiệu hóa các nút khi mới load
                btnSua.Enabled = false;
                btnXoa.Enabled = false;

                isLoading = false;
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
                else
                {
                    MessageBox.Show("Không có dữ liệu năm học. Vui lòng thêm năm học trước!",
                        "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                // Load Loại điểm
                DataTable dtLoaiDiem = LoaiDiemBUS.GetAllLoaiDiem();
                if (dtLoaiDiem != null && dtLoaiDiem.Rows.Count > 0)
                {
                    cboLoaiDiem.DataSource = dtLoaiDiem;
                    cboLoaiDiem.DisplayMember = "TenLoaiDiem";
                    cboLoaiDiem.ValueMember = "MaLoaiDiem";
                }
                else
                {
                    MessageBox.Show("Không có dữ liệu loại điểm. Vui lòng thêm loại điểm trước!",
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
                        cboMonHoc.DataSource = null;
                        MessageBox.Show("Năm học này chưa có học kỳ. Vui lòng thêm học kỳ!",
                            "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    // Load danh sách lớp
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
                        MessageBox.Show("Chưa có lớp học. Vui lòng thêm lớp học!",
                            "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

                    // Lấy khối của lớp
                    DataTable dtLop = LopBUS.GetAllLop();
                    DataRow[] rows = dtLop.Select($"MaLop = {maLop}");

                    if (rows.Length > 0)
                    {
                        // Kiểm tra nếu cột MaKhoi tồn tại
                        if (rows[0].Table.Columns.Contains("MaKhoi") && rows[0]["MaKhoi"] != DBNull.Value)
                        {
                            int maKhoi = Convert.ToInt32(rows[0]["MaKhoi"]);

                            // Load môn học theo khối
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
                                MessageBox.Show("Khối này chưa có môn học. Vui lòng thêm môn học!",
                                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Lớp chưa được phân khối. Vui lòng cập nhật thông tin lớp!",
                                "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void btnTaiDanhSach_Click(object sender, EventArgs e)
        {
            if (cboLop.SelectedValue == null || cboMonHoc.SelectedValue == null || cboHocKy.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn đầy đủ thông tin (Năm học, Học kỳ, Lớp, Môn học)!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int maLop = Convert.ToInt32(cboLop.SelectedValue);
                int maMonHoc = Convert.ToInt32(cboMonHoc.SelectedValue);
                int maHocKy = Convert.ToInt32(cboHocKy.SelectedValue);

                DataTable dt = DiemBUS.GetDiemLopMonHoc(maLop, maMonHoc, maHocKy);

                if (dt != null)
                {
                    dgvDanhSach.DataSource = dt;

                    if (dgvDanhSach.Columns.Count > 0)
                    {
                        // Ẩn các cột không cần thiết trước
                        if (dgvDanhSach.Columns.Contains("MaDiem"))
                            dgvDanhSach.Columns["MaDiem"].Visible = false;
                        if (dgvDanhSach.Columns.Contains("MaLoaiDiem"))
                            dgvDanhSach.Columns["MaLoaiDiem"].Visible = false;

                        // Đặt tiêu đề cho các cột
                        if (dgvDanhSach.Columns.Contains("MaHS"))
                            dgvDanhSach.Columns["MaHS"].HeaderText = "Mã HS";
                        if (dgvDanhSach.Columns.Contains("HoTen"))
                            dgvDanhSach.Columns["HoTen"].HeaderText = "Họ và tên";
                        if (dgvDanhSach.Columns.Contains("DiemSo"))
                            dgvDanhSach.Columns["DiemSo"].HeaderText = "Điểm";
                        if (dgvDanhSach.Columns.Contains("TenLoaiDiem"))
                            dgvDanhSach.Columns["TenLoaiDiem"].HeaderText = "Loại điểm";
                        if (dgvDanhSach.Columns.Contains("HeSo"))
                            dgvDanhSach.Columns["HeSo"].HeaderText = "Hệ số";

                        // Tự động điều chỉnh độ rộng cột
                        dgvDanhSach.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    }

                    lblTongSo.Text = $"Tổng số: {dt.Rows.Count} học sinh";

                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("Không có học sinh nào trong lớp này!", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    dgvDanhSach.DataSource = null;
                    lblTongSo.Text = "Tổng số: 0 học sinh";
                    MessageBox.Show("Không thể tải danh sách học sinh!", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải danh sách: " + ex.Message + "\n\nChi tiết: " + ex.StackTrace,
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvDanhSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvDanhSach.Rows.Count)
            {
                try
                {
                    DataGridViewRow row = dgvDanhSach.Rows[e.RowIndex];

                    // Kiểm tra xem row có dữ liệu không
                    if (row.Cells["HoTen"].Value != null)
                    {
                        txtHoTen.Text = row.Cells["HoTen"].Value.ToString();

                        if (row.Cells["DiemSo"].Value != null && row.Cells["DiemSo"].Value != DBNull.Value)
                        {
                            nudDiem.Value = Convert.ToDecimal(row.Cells["DiemSo"].Value);

                            if (row.Cells["MaDiem"].Value != null && row.Cells["MaDiem"].Value != DBNull.Value)
                            {
                                selectedMaDiem = Convert.ToInt32(row.Cells["MaDiem"].Value);
                            }
                            else
                            {
                                selectedMaDiem = -1;
                            }

                            // Lấy ghi chú nếu có
                            if (dgvDanhSach.Columns.Contains("GhiChu") &&
                                row.Cells["GhiChu"].Value != null &&
                                row.Cells["GhiChu"].Value != DBNull.Value)
                            {
                                txtGhiChu.Text = row.Cells["GhiChu"].Value.ToString();
                            }
                            else
                            {
                                txtGhiChu.Clear();
                            }

                            btnSua.Enabled = true;
                            btnXoa.Enabled = true;
                        }
                        else
                        {
                            nudDiem.Value = 0;
                            txtGhiChu.Clear();
                            selectedMaDiem = -1;
                            btnSua.Enabled = false;
                            btnXoa.Enabled = false;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi chọn học sinh: " + ex.Message, "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (dgvDanhSach.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn học sinh từ danh sách!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cboLoaiDiem.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn loại điểm!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (nudDiem.Value < 0 || nudDiem.Value > 10)
            {
                MessageBox.Show("Điểm phải trong khoảng 0-10!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int maHS = Convert.ToInt32(dgvDanhSach.CurrentRow.Cells["MaHS"].Value);
                int maMonHoc = Convert.ToInt32(cboMonHoc.SelectedValue);
                int maHocKy = Convert.ToInt32(cboHocKy.SelectedValue);
                int maLoaiDiem = Convert.ToInt32(cboLoaiDiem.SelectedValue);

                DiemDTO diem = new DiemDTO
                {
                    MaHS = maHS,
                    MaMonHoc = maMonHoc,
                    MaHocKy = maHocKy,
                    MaLoaiDiem = maLoaiDiem,
                    DiemSo = nudDiem.Value,
                    GhiChu = txtGhiChu.Text.Trim()
                };

                string error;
                if (DiemBUS.ThemDiem(diem, out error))
                {
                    MessageBox.Show("Thêm điểm thành công!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnTaiDanhSach_Click(sender, e);
                    ClearInputs();
                }
                else
                {
                    MessageBox.Show(error, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thêm điểm: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (selectedMaDiem == -1)
            {
                MessageBox.Show("Vui lòng chọn điểm cần sửa từ danh sách!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (nudDiem.Value < 0 || nudDiem.Value > 10)
            {
                MessageBox.Show("Điểm phải trong khoảng 0-10!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string error;
                if (DiemBUS.SuaDiem(selectedMaDiem, nudDiem.Value, txtGhiChu.Text.Trim(), out error))
                {
                    MessageBox.Show("Cập nhật điểm thành công!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnTaiDanhSach_Click(sender, e);
                    ClearInputs();
                }
                else
                {
                    MessageBox.Show(error, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi cập nhật điểm: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (selectedMaDiem == -1)
            {
                MessageBox.Show("Vui lòng chọn điểm cần xóa từ danh sách!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show(
                "Bạn có chắc chắn muốn xóa điểm này không?\n\nHọc sinh: " + txtHoTen.Text + "\nĐiểm: " + nudDiem.Value,
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    string error;
                    if (DiemBUS.XoaDiem(selectedMaDiem, out error))
                    {
                        MessageBox.Show("Xóa điểm thành công!", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnTaiDanhSach_Click(sender, e);
                        ClearInputs();
                    }
                    else
                    {
                        MessageBox.Show(error, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa điểm: " + ex.Message, "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void ClearInputs()
        {
            txtHoTen.Clear();
            nudDiem.Value = 0;
            txtGhiChu.Clear();
            selectedMaDiem = -1;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }
    }
}