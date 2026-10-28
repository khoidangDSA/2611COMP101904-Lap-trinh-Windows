using System;
using System.Data;
using System.Windows.Forms;
using QLSinhVienLab12.DAL;
using System.Drawing;
namespace QLSinhVienLab12
{
    public partial class FrmNhapDiemTheoLop : Form
    {
        private readonly KetQuaDAL ketQuaDAL = new KetQuaDAL();
        private readonly BindingSource ketQuaSource = new BindingSource();
        public FrmNhapDiemTheoLop()
        {
            InitializeComponent();
            
        }

        private void FrmNhapDiemTheoLop_Load(object sender, EventArgs e)
        {
            try
            {
                LoadComboBox();

                dgvKetQua.AutoGenerateColumns = true;
                dgvKetQua.DataSource = ketQuaSource;
                //
                // Khung tổng thể của bảng
                dgvKetQua.BorderStyle = BorderStyle.FixedSingle;
                dgvKetQua.CellBorderStyle = DataGridViewCellBorderStyle.Single;
                dgvKetQua.GridColor = Color.LightGray;

                // Màu nền bảng
                dgvKetQua.BackgroundColor = Color.White;
                dgvKetQua.DefaultCellStyle.BackColor = Color.White;
                dgvKetQua.DefaultCellStyle.ForeColor = Color.Black;

                // Tiêu đề cột
                dgvKetQua.EnableHeadersVisualStyles = false;
                dgvKetQua.ColumnHeadersBorderStyle =
                    DataGridViewHeaderBorderStyle.Single;
                dgvKetQua.ColumnHeadersDefaultCellStyle.BackColor =
                    Color.FromArgb(35, 55, 85);
                dgvKetQua.ColumnHeadersDefaultCellStyle.ForeColor =
                    Color.White;
                dgvKetQua.ColumnHeadersDefaultCellStyle.Font =
                    new Font("Segoe UI", 10, FontStyle.Bold);

                // Tự căn độ rộng các cột
                dgvKetQua.AutoSizeColumnsMode =
                    DataGridViewAutoSizeColumnsMode.Fill;

                // Chọn cả dòng khi bấm
                dgvKetQua.SelectionMode =
                    DataGridViewSelectionMode.FullRowSelect;
                dgvKetQua.AllowUserToAddRows = false;
                //
                lblTrangThai.Text = "Sẵn sàng";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message);
            }
        }

        private void LoadComboBox()
        {
            cboLop.DataSource = ketQuaDAL.GetLop();
            cboLop.DisplayMember = "TenLop";
            cboLop.ValueMember = "MaLop";

            cboMonHoc.DataSource = ketQuaDAL.GetMonHoc();
            cboMonHoc.DisplayMember = "TenMon";
            cboMonHoc.ValueMember = "MaMon";

        }

        private void btnTaiDanhSach_Click(object sender, EventArgs e)
        {
            string maLop = cboLop.SelectedValue?.ToString() ?? "";
            string maMon = cboMonHoc.SelectedValue?.ToString() ?? "";

            if (maLop.Length == 0 || maMon.Length == 0)
            {
                MessageBox.Show("Vui lòng chọn lớp và môn học.");
                return;
            }

            try
            {
                DataTable table = ketQuaDAL.GetKetQuaByLopMon(maLop, maMon);
                ketQuaSource.DataSource = table;
                dgvKetQua.Columns["MaSV"].HeaderText = "Mã sinh viên";
                dgvKetQua.Columns["HoTen"].HeaderText = "Họ và tên";
                dgvKetQua.Columns["Diem"].HeaderText = "Điểm";
                dgvKetQua.Columns["GhiChu"].HeaderText = "Ghi chú";

                lblTrangThai.Text = "Đã tải danh sách sinh viên.";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải danh sách: " + ex.Message);
            }
        }

        private void btnLuuTatCa_Click(object sender, EventArgs e)
        {
            try
            {
                ketQuaSource.EndEdit();

                DataTable table = (DataTable)ketQuaSource.DataSource;
                ValidateData(table);

                string maMon = cboMonHoc.SelectedValue?.ToString() ?? "";

                int count = ketQuaDAL.SaveAll(maMon, table);

                MessageBox.Show($"Đã lưu thành công {count} dòng.");
                lblTrangThai.Text = $"Đã lưu thành công {count} dòng.";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể lưu dữ liệu: " + ex.Message);
                lblTrangThai.Text = "Lưu thất bại.";
            }
        }

        private void ValidateData(DataTable table)
        {
            foreach (DataRow row in table.Rows)
            {
                string maSV = row["MaSV"].ToString() ?? "";
                string diemText = row["Diem"].ToString() ?? "";

                if (!double.TryParse(diemText, out double diem))
                {
                    throw new Exception(
                        $"Điểm của sinh viên {maSV} không hợp lệ.");
                }

                if (diem < 0 || diem > 10)
                {
                    throw new Exception(
                        $"Điểm của sinh viên {maSV} phải từ 0 đến 10.");
                }
            }
        }

        private void cboLop_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
