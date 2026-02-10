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
    public partial class frmMonHoc : Form
    {
        private int selectedMaMonHoc = -1;

        public frmMonHoc()
        {
            InitializeComponent();
            this.Load += FrmMonHoc_Load;
        }

        private void FrmMonHoc_Load(object sender, EventArgs e)
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
                DataTable dt = MonHocBUS.GetAllMonHoc();
                dgvMonHoc.DataSource = dt;

                if (dgvMonHoc.Columns.Count > 0)
                {
                    dgvMonHoc.Columns["MaMonHoc"].HeaderText = "Mã MH";
                    dgvMonHoc.Columns["TenMonHoc"].HeaderText = "Tên môn học";
                    dgvMonHoc.Columns["TenKhoi"].HeaderText = "Khối";
                    dgvMonHoc.Columns["SoTietLyThuyet"].HeaderText = "Số tiết LT";
                    dgvMonHoc.Columns["SoTietThucHanh"].HeaderText = "Số tiết TH";
                    dgvMonHoc.Columns["HeSo"].HeaderText = "Hệ số";
                    dgvMonHoc.Columns["MaKhoi"].Visible = false;
                    dgvMonHoc.Columns["TrangThai"].Visible = false;
                }

                lblTongSo.Text = $"Tổng số: {dt.Rows.Count} môn học";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenMonHoc.Text))
            {
                MessageBox.Show("Vui lòng nhập tên môn học!");
                return;
            }

            MonHocDTO mh = new MonHocDTO
            {
                TenMonHoc = txtTenMonHoc.Text.Trim(),
                MaKhoi = Convert.ToInt32(cboKhoi.SelectedValue),
                SoTietLyThuyet = Convert.ToInt32(nudSoTietLT.Value),
                SoTietThucHanh = Convert.ToInt32(nudSoTietTH.Value),
                HeSo = Convert.ToInt32(nudHeSo.Value)
            };

            string error;
            if (MonHocBUS.ThemMonHoc(mh, out error))
            {
                MessageBox.Show("Thêm môn học thành công!");
                LoadData();
                txtTenMonHoc.Clear();
                nudSoTietLT.Value = 0;
                nudSoTietTH.Value = 0;
                nudHeSo.Value = 1;
            }
            else
            {
                MessageBox.Show(error);
            }
        }

        private void dgvMonHoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvMonHoc.Rows[e.RowIndex];
                selectedMaMonHoc = Convert.ToInt32(row.Cells["MaMonHoc"].Value);
                txtTenMonHoc.Text = row.Cells["TenMonHoc"].Value.ToString();
                cboKhoi.SelectedValue = row.Cells["MaKhoi"].Value;
                nudSoTietLT.Value = Convert.ToInt32(row.Cells["SoTietLyThuyet"].Value);
                nudSoTietTH.Value = Convert.ToInt32(row.Cells["SoTietThucHanh"].Value);
                nudHeSo.Value = Convert.ToInt32(row.Cells["HeSo"].Value);

                btnSua.Enabled = true;
                btnXoa.Enabled = true;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (selectedMaMonHoc == -1)
            {
                MessageBox.Show("Vui lòng chọn môn học cần sửa!");
                return;
            }

            MonHocDTO mh = new MonHocDTO
            {
                MaMonHoc = selectedMaMonHoc,
                TenMonHoc = txtTenMonHoc.Text.Trim(),
                MaKhoi = Convert.ToInt32(cboKhoi.SelectedValue),
                SoTietLyThuyet = Convert.ToInt32(nudSoTietLT.Value),
                SoTietThucHanh = Convert.ToInt32(nudSoTietTH.Value),
                HeSo = Convert.ToInt32(nudHeSo.Value)
            };

            string error;
            if (MonHocBUS.SuaMonHoc(mh, out error))
            {
                MessageBox.Show("Cập nhật môn học thành công!");
                LoadData();
            }
            else
            {
                MessageBox.Show(error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (selectedMaMonHoc == -1)
            {
                MessageBox.Show("Vui lòng chọn môn học cần xóa!");
                return;
            }

            DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa môn học này?",
                "Xác nhận", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                string error;
                if (MonHocBUS.XoaMonHoc(selectedMaMonHoc, out error))
                {
                    MessageBox.Show("Xóa môn học thành công!");
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
