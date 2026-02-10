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
    public partial class frmLop : Form
    {
        private int selectedMaLop = -1;

        public frmLop()
        {
            InitializeComponent();
            this.Load += FrmLop_Load;
        }

        private void FrmLop_Load(object sender, EventArgs e)
        {
            LoadComboBoxes();
            LoadData();
        }

        private void LoadComboBoxes()
        {
            try
            {
                DataTable dtKhoi = KhoiBUS.GetAllKhoi();
                cboKhoi.DataSource = dtKhoi;
                cboKhoi.DisplayMember = "TenKhoi";
                cboKhoi.ValueMember = "MaKhoi";

                DataTable dtNamHoc = NamHocBUS.GetAllNamHoc();
                cboNamHoc.DataSource = dtNamHoc;
                cboNamHoc.DisplayMember = "TenNamHoc";
                cboNamHoc.ValueMember = "MaNamHoc";

                DataTable dtGV = GiaoVienBUS.GetAllGiaoVien();
                cboGVCN.DataSource = dtGV;
                cboGVCN.DisplayMember = "HoTen";
                cboGVCN.ValueMember = "MaGV";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message);
            }
        }

        private void LoadData()
        {
            try
            {
                DataTable dt = LopBUS.GetAllLop();
                dgvLop.DataSource = dt;

                if (dgvLop.Columns.Count > 0)
                {
                    dgvLop.Columns["MaLop"].HeaderText = "Mã lớp";
                    dgvLop.Columns["TenLop"].HeaderText = "Tên lớp";
                    dgvLop.Columns["TenKhoi"].HeaderText = "Khối";
                    dgvLop.Columns["TenNamHoc"].HeaderText = "Năm học";
                    dgvLop.Columns["SiSo"].HeaderText = "Sĩ số";
                    dgvLop.Columns["TenGVCN"].HeaderText = "GVCN";
                    dgvLop.Columns["MaKhoi"].Visible = false;
                    dgvLop.Columns["MaNamHoc"].Visible = false;
                    dgvLop.Columns["MaGVCN"].Visible = false;
                }

                lblTongSo.Text = $"Tổng số: {dt.Rows.Count} lớp";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenLop.Text))
            {
                MessageBox.Show("Vui lòng nhập tên lớp!");
                return;
            }

            LopDTO lop = new LopDTO
            {
                TenLop = txtTenLop.Text.Trim(),
                MaKhoi = Convert.ToInt32(cboKhoi.SelectedValue),
                MaNamHoc = Convert.ToInt32(cboNamHoc.SelectedValue),
                MaGVCN = cboGVCN.SelectedValue != null ? (int?)Convert.ToInt32(cboGVCN.SelectedValue) : null
            };

            string error;
            if (LopBUS.ThemLop(lop, out error))
            {
                MessageBox.Show("Thêm lớp thành công!");
                LoadData();
                txtTenLop.Clear();
            }
            else
            {
                MessageBox.Show(error);
            }
        }

        private void dgvLop_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvLop.Rows[e.RowIndex];
                selectedMaLop = Convert.ToInt32(row.Cells["MaLop"].Value);
                txtTenLop.Text = row.Cells["TenLop"].Value.ToString();
                cboKhoi.SelectedValue = row.Cells["MaKhoi"].Value;
                cboNamHoc.SelectedValue = row.Cells["MaNamHoc"].Value;
                if (row.Cells["MaGVCN"].Value != DBNull.Value)
                    cboGVCN.SelectedValue = row.Cells["MaGVCN"].Value;

                btnSua.Enabled = true;
                btnXoa.Enabled = true;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (selectedMaLop == -1)
            {
                MessageBox.Show("Vui lòng chọn lớp cần sửa!");
                return;
            }

            LopDTO lop = new LopDTO
            {
                MaLop = selectedMaLop,
                TenLop = txtTenLop.Text.Trim(),
                MaKhoi = Convert.ToInt32(cboKhoi.SelectedValue),
                MaNamHoc = Convert.ToInt32(cboNamHoc.SelectedValue),
                MaGVCN = cboGVCN.SelectedValue != null ? (int?)Convert.ToInt32(cboGVCN.SelectedValue) : null
            };

            string error;
            if (LopBUS.SuaLop(lop, out error))
            {
                MessageBox.Show("Cập nhật lớp thành công!");
                LoadData();
            }
            else
            {
                MessageBox.Show(error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (selectedMaLop == -1)
            {
                MessageBox.Show("Vui lòng chọn lớp cần xóa!");
                return;
            }

            DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa lớp này?",
                "Xác nhận", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                string error;
                if (LopBUS.XoaLop(selectedMaLop, out error))
                {
                    MessageBox.Show("Xóa lớp thành công!");
                    LoadData();
                }
                else
                {
                    MessageBox.Show(error);
                }
            }
        }
    }
}
