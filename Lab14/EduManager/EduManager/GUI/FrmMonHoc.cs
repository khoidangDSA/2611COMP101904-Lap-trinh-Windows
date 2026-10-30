using System;
using System.Windows.Forms;
using EduManager.BLL;
using EduManager.Models;

namespace EduManager.GUI
{
    public partial class FrmMonHoc : Form
    {
        private readonly MonHocBLL _bll = new();

        public FrmMonHoc()
        {
            InitializeComponent();
        }

        private void FrmMonHoc_Load(object sender, EventArgs e)
        {
            LoadData();
            ClearInput();
        }

        private void LoadData()
        {
            try
            {
                dgvMonHoc.DataSource = _bll.GetAllMonHoc();

                // Đổi tên tiêu đề các cột sang tiếng Việt
                if (dgvMonHoc.Columns["MaMonHoc"] != null)
                    dgvMonHoc.Columns["MaMonHoc"].HeaderText = "Mã môn học";

                if (dgvMonHoc.Columns["TenMonHoc"] != null)
                    dgvMonHoc.Columns["TenMonHoc"].HeaderText = "Tên môn học";

                if (dgvMonHoc.Columns["SoTinChi"] != null)
                    dgvMonHoc.Columns["SoTinChi"].HeaderText = "Số tín chỉ";

                if (dgvMonHoc.Columns["TrangThai"] != null)
                    dgvMonHoc.Columns["TrangThai"].HeaderText = "Trạng thái";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi tải dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearInput()
        {
            txtTimKiem.Clear();
            txtMaMonHoc.Clear();
            txtTenMonHoc.Clear();
            nudSoTinChi.Value = 3;
            chkTrangThai.Checked = true;
            txtMaMonHoc.Enabled = true;
            txtMaMonHoc.Focus();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                var mh = new MonHoc
                {
                    MaMonHoc = txtMaMonHoc.Text.Trim(),
                    TenMonHoc = txtTenMonHoc.Text.Trim(),
                    SoTinChi = (int)nudSoTinChi.Value,
                    TrangThai = chkTrangThai.Checked
                };

                _bll.AddMonHoc(mh);
                MessageBox.Show("Thêm môn học thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
                ClearInput();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Cảnh báo Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                var mh = new MonHoc
                {
                    MaMonHoc = txtMaMonHoc.Text.Trim(),
                    TenMonHoc = txtTenMonHoc.Text.Trim(),
                    SoTinChi = (int)nudSoTinChi.Value,
                    TrangThai = chkTrangThai.Checked
                };

                _bll.UpdateMonHoc(mh);
                MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
                ClearInput();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maMH = txtMaMonHoc.Text.Trim();
            if (string.IsNullOrEmpty(maMH))
            {
                MessageBox.Show("Vui lòng chọn môn học cần xóa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var dialog = MessageBox.Show($"Bạn có chắc chắn muốn xóa môn học {maMH}?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                try
                {
                    _bll.DeleteMonHoc(maMH);
                    MessageBox.Show("Xóa môn học thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                    ClearInput();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            ClearInput();
            LoadData();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                string kw = txtTimKiem.Text.Trim();
                dgvMonHoc.DataSource = _bll.SearchMonHoc(kw);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi tìm kiếm: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvMonHoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvMonHoc.Rows[e.RowIndex].DataBoundItem is MonHoc selected)
            {
                txtMaMonHoc.Text = selected.MaMonHoc;
                txtTenMonHoc.Text = selected.TenMonHoc;
                nudSoTinChi.Value = selected.SoTinChi;
                chkTrangThai.Checked = selected.TrangThai;

                txtMaMonHoc.Enabled = false; // Khóa Primary Key khi chọn để sửa
            }
        }
    }
}