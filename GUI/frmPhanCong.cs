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
    public partial class frmPhanCong : Form
    {
        private int selectedMaPhanCong = -1;

        public frmPhanCong()
        {
            InitializeComponent();
            this.Load += FrmPhanCong_Load;
        }

        private void FrmPhanCong_Load(object sender, EventArgs e)
        {
            LoadComboBoxes();
            LoadData();
        }

        private void LoadComboBoxes()
        {
            try
            {
                DataTable dtNamHoc = NamHocBUS.GetAllNamHoc();
                cboNamHoc.DataSource = dtNamHoc;
                cboNamHoc.DisplayMember = "TenNamHoc";
                cboNamHoc.ValueMember = "MaNamHoc";

                DataTable dtGV = GiaoVienBUS.GetAllGiaoVien();
                cboGiaoVien.DataSource = dtGV;
                cboGiaoVien.DisplayMember = "HoTen";
                cboGiaoVien.ValueMember = "MaGV";
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

        private void cboLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboLop.SelectedValue != null)
            {
                try
                {
                    DataTable dtLop = LopBUS.GetAllLop();
                    DataRow[] rows = dtLop.Select($"MaLop = {cboLop.SelectedValue}");
                    if (rows.Length > 0)
                    {
                        int maKhoi = Convert.ToInt32(rows[0]["MaKhoi"]);
                        DataTable dtMonHoc = MonHocBUS.GetMonHocByKhoi(maKhoi);
                        cboMonHoc.DataSource = dtMonHoc;
                        cboMonHoc.DisplayMember = "TenMonHoc";
                        cboMonHoc.ValueMember = "MaMonHoc";
                    }
                }
                catch { }
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
                    dgvPhanCong.Columns["MaPhanCong"].HeaderText = "Mã PC";
                    dgvPhanCong.Columns["TenGV"].HeaderText = "Giáo viên";
                    dgvPhanCong.Columns["TenLop"].HeaderText = "Lớp";
                    dgvPhanCong.Columns["TenMonHoc"].HeaderText = "Môn học";
                    dgvPhanCong.Columns["TenHocKy"].HeaderText = "Học kỳ";
                    dgvPhanCong.Columns["MaGV"].Visible = false;
                    dgvPhanCong.Columns["MaLop"].Visible = false;
                    dgvPhanCong.Columns["MaMonHoc"].Visible = false;
                    dgvPhanCong.Columns["MaHocKy"].Visible = false;
                }

                lblTongSo.Text = $"Tổng số: {dt.Rows.Count} phân công";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (cboGiaoVien.SelectedValue == null || cboLop.SelectedValue == null ||
                cboMonHoc.SelectedValue == null || cboHocKy.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn đầy đủ thông tin!");
                return;
            }

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
                MessageBox.Show("Phân công thành công!");
                LoadData();
            }
            else
            {
                MessageBox.Show(error);
            }
        }

        private void dgvPhanCong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvPhanCong.Rows[e.RowIndex];
                selectedMaPhanCong = Convert.ToInt32(row.Cells["MaPhanCong"].Value);
                btnXoa.Enabled = true;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (selectedMaPhanCong == -1)
            {
                MessageBox.Show("Vui lòng chọn phân công cần xóa!");
                return;
            }

            DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa phân công này?",
                "Xác nhận", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                string error;
                if (PhanCongBUS.XoaPhanCong(selectedMaPhanCong, out error))
                {
                    MessageBox.Show("Xóa phân công thành công!");
                    LoadData();
                    selectedMaPhanCong = -1;
                    btnXoa.Enabled = false;
                }
                else
                {
                    MessageBox.Show(error);
                }
            }
        }

        private void panelRight_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
