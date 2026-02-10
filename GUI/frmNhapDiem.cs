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

        public frmNhapDiem()
        {
            InitializeComponent();
            this.Load += FrmNhapDiem_Load;
        }

        private void FrmNhapDiem_Load(object sender, EventArgs e)
        {
            LoadComboBoxes();
            dtpNgayNhap.Value = DateTime.Now;
        }

        private void LoadComboBoxes()
        {
            try
            {
                // Load Năm học
                DataTable dtNamHoc = NamHocBUS.GetAllNamHoc();
                cboNamHoc.DataSource = dtNamHoc;
                cboNamHoc.DisplayMember = "TenNamHoc";
                cboNamHoc.ValueMember = "MaNamHoc";

                // Load Loại điểm
                DataTable dtLoaiDiem = LoaiDiemBUS.GetAllLoaiDiem();
                cboLoaiDiem.DataSource = dtLoaiDiem;
                cboLoaiDiem.DisplayMember = "TenLoaiDiem";
                cboLoaiDiem.ValueMember = "MaLoaiDiem";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message, "Lỗi",
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
                    // Load danh sách lớp
                    DataTable dtLop = LopBUS.GetAllLop();
                    cboLop.DataSource = dtLop;
                    cboLop.DisplayMember = "TenLop";
                    cboLop.ValueMember = "MaLop";
                }
                catch { }
            }
        }

        private void cboLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboLop.SelectedValue != null && cboHocKy.SelectedValue != null)
            {
                try
                {
                    int maLop = Convert.ToInt32(cboLop.SelectedValue);

                    // Lấy khối của lớp
                    DataTable dtLop = LopBUS.GetAllLop();
                    DataRow[] rows = dtLop.Select($"MaLop = {maLop}");
                    if (rows.Length > 0)
                    {
                        int maKhoi = Convert.ToInt32(rows[0]["MaKhoi"]);

                        // Load môn học theo khối
                        DataTable dtMonHoc = MonHocBUS.GetMonHocByKhoi(maKhoi);
                        cboMonHoc.DataSource = dtMonHoc;
                        cboMonHoc.DisplayMember = "TenMonHoc";
                        cboMonHoc.ValueMember = "MaMonHoc";
                    }
                }
                catch { }
            }
        }

        private void btnTaiDanhSach_Click(object sender, EventArgs e)
        {
            if (cboLop.SelectedValue == null || cboMonHoc.SelectedValue == null || cboHocKy.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn đầy đủ thông tin!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int maLop = Convert.ToInt32(cboLop.SelectedValue);
                int maMonHoc = Convert.ToInt32(cboMonHoc.SelectedValue);
                int maHocKy = Convert.ToInt32(cboHocKy.SelectedValue);

                DataTable dt = DiemBUS.GetDiemLopMonHoc(maLop, maMonHoc, maHocKy);
                dgvDanhSach.DataSource = dt;

                if (dgvDanhSach.Columns.Count > 0)
                {
                    dgvDanhSach.Columns["MaHS"].HeaderText = "Mã HS";
                    dgvDanhSach.Columns["HoTen"].HeaderText = "Họ và tên";
                    dgvDanhSach.Columns["DiemSo"].HeaderText = "Điểm";
                    dgvDanhSach.Columns["TenLoaiDiem"].HeaderText = "Loại điểm";
                    dgvDanhSach.Columns["HeSo"].HeaderText = "Hệ số";

                    if (dgvDanhSach.Columns.Contains("MaDiem"))
                        dgvDanhSach.Columns["MaDiem"].Visible = false;
                    if (dgvDanhSach.Columns.Contains("MaLoaiDiem"))
                        dgvDanhSach.Columns["MaLoaiDiem"].Visible = false;
                }

                lblTongSo.Text = $"Tổng số: {dt.Rows.Count} học sinh";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải danh sách: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvDanhSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvDanhSach.Rows[e.RowIndex];

                txtHoTen.Text = row.Cells["HoTen"].Value.ToString();

                if (row.Cells["DiemSo"].Value != DBNull.Value)
                {
                    nudDiem.Value = Convert.ToDecimal(row.Cells["DiemSo"].Value);
                    selectedMaDiem = row.Cells["MaDiem"].Value != DBNull.Value ?
                        Convert.ToInt32(row.Cells["MaDiem"].Value) : -1;
                    btnSua.Enabled = true;
                    btnXoa.Enabled = true;
                }
                else
                {
                    nudDiem.Value = 0;
                    selectedMaDiem = -1;
                    btnSua.Enabled = false;
                    btnXoa.Enabled = false;
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (dgvDanhSach.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn học sinh!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cboLoaiDiem.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn loại điểm!", "Thông báo",
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
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (selectedMaDiem == -1)
            {
                MessageBox.Show("Vui lòng chọn điểm cần sửa!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

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

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (selectedMaDiem == -1)
            {
                MessageBox.Show("Vui lòng chọn điểm cần xóa!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa điểm này?",
                "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
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
