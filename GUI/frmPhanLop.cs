using QuanLyDiemHocTap.BUS;
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
    public partial class frmPhanLop : Form
    {
        public frmPhanLop()
        {
            InitializeComponent();
            this.Load += FrmPhanLop_Load;
        }

        private void FrmPhanLop_Load(object sender, EventArgs e)
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
                MessageBox.Show("Lỗi: " + ex.Message);
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

        private void btnTaiDanhSach_Click(object sender, EventArgs e)
        {
            if (cboLop.SelectedValue == null || cboHocKy.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn đầy đủ thông tin!");
                return;
            }

            try
            {
                int maLop = Convert.ToInt32(cboLop.SelectedValue);
                int maHocKy = Convert.ToInt32(cboHocKy.SelectedValue);

                // Tải danh sách học sinh trong lớp
                DataTable dtTrongLop = PhanLopBUS.GetHocSinhByLop(maLop, maHocKy);
                dgvHocSinhTrongLop.DataSource = dtTrongLop;

                if (dgvHocSinhTrongLop.Columns.Count > 0)
                {
                    dgvHocSinhTrongLop.Columns["MaHS"].HeaderText = "Mã HS";
                    dgvHocSinhTrongLop.Columns["HoTen"].HeaderText = "Họ và tên";
                    dgvHocSinhTrongLop.Columns["NgaySinh"].HeaderText = "Ngày sinh";
                    dgvHocSinhTrongLop.Columns["GioiTinh"].HeaderText = "Giới tính";

                    if (dgvHocSinhTrongLop.Columns.Contains("MaPhanLop"))
                        dgvHocSinhTrongLop.Columns["MaPhanLop"].Visible = false;
                }

                // Tải tất cả học sinh
                DataTable dtTatCa = HocSinhBUS.GetAllHocSinh();
                dgvTatCaHocSinh.DataSource = dtTatCa;

                if (dgvTatCaHocSinh.Columns.Count > 0)
                {
                    dgvTatCaHocSinh.Columns["MaHS"].HeaderText = "Mã HS";
                    dgvTatCaHocSinh.Columns["HoTen"].HeaderText = "Họ và tên";
                    dgvTatCaHocSinh.Columns["NgaySinh"].HeaderText = "Ngày sinh";
                    dgvTatCaHocSinh.Columns["GioiTinh"].HeaderText = "Giới tính";
                    dgvTatCaHocSinh.Columns["TrangThai"].Visible = false;
                    dgvTatCaHocSinh.Columns["NgayNhapHoc"].Visible = false;
                    dgvTatCaHocSinh.Columns["DiaChi"].Visible = false;
                    dgvTatCaHocSinh.Columns["DienThoai"].Visible = false;
                    dgvTatCaHocSinh.Columns["Email"].Visible = false;
                }

                lblTrongLop.Text = $"Trong lớp: {dtTrongLop.Rows.Count} học sinh";
                lblTatCa.Text = $"Tất cả: {dtTatCa.Rows.Count} học sinh";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnThemVaoLop_Click(object sender, EventArgs e)
        {
            if (dgvTatCaHocSinh.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn học sinh!");
                return;
            }

            if (cboLop.SelectedValue == null || cboHocKy.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn lớp và học kỳ!");
                return;
            }

            try
            {
                int maHS = Convert.ToInt32(dgvTatCaHocSinh.CurrentRow.Cells["MaHS"].Value);
                int maLop = Convert.ToInt32(cboLop.SelectedValue);
                int maHocKy = Convert.ToInt32(cboHocKy.SelectedValue);

                string error;
                if (PhanLopBUS.ThemHocSinhVaoLop(maHS, maLop, maHocKy, out error))
                {
                    MessageBox.Show("Thêm học sinh vào lớp thành công!");
                    btnTaiDanhSach_Click(sender, e);
                }
                else
                {
                    MessageBox.Show(error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnXoaKhoiLop_Click(object sender, EventArgs e)
        {
            if (dgvHocSinhTrongLop.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn học sinh!");
                return;
            }

            DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa học sinh khỏi lớp?",
                "Xác nhận", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                try
                {
                    int maHS = Convert.ToInt32(dgvHocSinhTrongLop.CurrentRow.Cells["MaHS"].Value);
                    int maLop = Convert.ToInt32(cboLop.SelectedValue);
                    int maHocKy = Convert.ToInt32(cboHocKy.SelectedValue);

                    string error;
                    if (PhanLopBUS.XoaHocSinhKhoiLop(maHS, maLop, maHocKy, out error))
                    {
                        MessageBox.Show("Xóa học sinh khỏi lớp thành công!");
                        btnTaiDanhSach_Click(sender, e);
                    }
                    else
                    {
                        MessageBox.Show(error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }
    }
}
