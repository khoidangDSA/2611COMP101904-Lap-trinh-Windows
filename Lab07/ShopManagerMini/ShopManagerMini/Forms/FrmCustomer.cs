using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ShopManagerMini.Models;
using System.Linq;
namespace ShopManagerMini.Forms
{
    public partial class FrmCustomer : Form
    {
        private BindingList<Customer> _listCustomer = new BindingList<Customer>();
        public FrmCustomer()
        {
            InitializeComponent();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void FrmCustomer_Load(object sender, EventArgs e)
        {
            dgvKhachHang.AllowUserToAddRows = false;
            cboLoaiKH.Items.Clear();
            cboLoaiKH.Items.AddRange(new object[] { "Thường", "Thân thiết", "VIP" });
            cboLoaiKH.DropDownStyle = ComboBoxStyle.DropDownList;
            cboLoaiKH.SelectedIndex = 0;

            // 2. Dữ liệu mẫu ban đầu
            _listCustomer.Add(new Customer { MaKH = "KH01", TenKH = "Đặng Hoàng Hải", SDT = "0901234567", LoaiKH = "VIP" });
            _listCustomer.Add(new Customer { MaKH = "KH02", TenKH = "Đặng Ngọc Ngân", SDT = "0987654321", LoaiKH = "Thân thiết" });
            _listCustomer.Add(new Customer { MaKH = "KH03", TenKH = "Đặng Nguyên Khôi", SDT = "0989898989", LoaiKH = "Thường" });
            // 3. Gán nguồn dữ liệu
            dgvKhachHang.DataSource = _listCustomer;
            FormatDataGridView();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string maKH = txtMaKH.Text.Trim();
            string hoTen = txtTenKH.Text.Trim();
            string sdt = txtSDT.Text.Trim();
            string loaiKH = cboLoaiKH.Text.Trim();
            // Validation: Kiểm tra bỏ trống
            if (string.IsNullOrEmpty(maKH) || string.IsNullOrEmpty(hoTen))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Mã khách hàng và Họ tên!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaKH.Focus();
                return;
            }

            // Validation: Kiểm tra trùng mã
            if (_listCustomer.Any(c => c.MaKH.Equals(maKH, StringComparison.OrdinalIgnoreCase)))
            {
                MessageBox.Show($"Mã khách hàng [{maKH}] đã tồn tại!", "Lỗi trùng mã", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMaKH.Focus();
                return;
            }

            // Thêm vào danh sách
            _listCustomer.Add(new Customer
            {
                MaKH = maKH,
                TenKH = hoTen,
                SDT = sdt,
                LoaiKH = string.IsNullOrEmpty(loaiKH) ? "Thường" : loaiKH
            });

            MessageBox.Show("Thêm khách hàng mới thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearInput();

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string maKH = txtMaKH.Text.Trim();
            var cust = _listCustomer.FirstOrDefault(c => c.MaKH.Equals(maKH, StringComparison.OrdinalIgnoreCase));

            if (cust == null)
            {
                MessageBox.Show("Vui lòng chọn hoặc nhập Mã khách hàng cần sửa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(txtTenKH.Text.Trim()))
            {
                MessageBox.Show("Họ tên không được để trống!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            cust.TenKH = txtTenKH.Text.Trim();
            cust.SDT = txtSDT.Text.Trim();
            cust.LoaiKH = cboLoaiKH.Text.Trim();

            dgvKhachHang.Refresh();
            MessageBox.Show("Cập nhật thông tin khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearInput();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string maKH = txtMaKH.Text.Trim();
            var cust = _listCustomer.FirstOrDefault(c => c.MaKH.Equals(maKH, StringComparison.OrdinalIgnoreCase));

            if (cust == null)
            {
                MessageBox.Show("Vui lòng chọn khách hàng cần xóa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirm = MessageBox.Show($"Bạn có chắc chắn muốn xóa khách hàng [{cust.TenKH}]?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                _listCustomer.Remove(cust);
                MessageBox.Show("Xóa khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearInput();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ClearInput();
        }

        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvKhachHang.Rows.Count)
            {
                DataGridViewRow row = dgvKhachHang.Rows[e.RowIndex];
                txtMaKH.Text = row.Cells["MaKH"].Value?.ToString();
                txtTenKH.Text = row.Cells["TenKH"].Value?.ToString();
                txtSDT.Text = row.Cells["SDT"].Value?.ToString();
                cboLoaiKH.Text = row.Cells["LoaiKH"].Value?.ToString();
            }
        }
        private void ClearInput()
        {
            txtMaKH.Clear();
            txtTenKH.Clear();
            txtSDT.Clear();
            cboLoaiKH.SelectedIndex = 0;
            txtMaKH.Focus();
        }

        private void FormatDataGridView()
        {
            dgvKhachHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            if (dgvKhachHang.Columns["MaKH"] != null) dgvKhachHang.Columns["MaKH"].HeaderText = "Mã khách hàng";
            if (dgvKhachHang.Columns["TenKH"] != null) dgvKhachHang.Columns["TenKH"].HeaderText = "Họ và tên";
            if (dgvKhachHang.Columns["SDT"] != null) dgvKhachHang.Columns["SDT"].HeaderText = "Số điện thoại";
            if (dgvKhachHang.Columns["LoaiKH"] != null) dgvKhachHang.Columns["LoaiKH"].HeaderText = "Loại khách hàng";
        }

        private void dgvKhachHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
