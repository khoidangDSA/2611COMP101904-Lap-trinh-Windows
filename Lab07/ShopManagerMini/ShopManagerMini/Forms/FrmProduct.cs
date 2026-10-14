using ShopManagerMini.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
namespace ShopManagerMini.Forms
{
    public partial class FrmProduct : Form
    {
        private BindingList<Product> _listProduct = new BindingList<Product>();

        public FrmProduct()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void FrmProduct_Load(object sender, EventArgs e)
        {
            dgvSanPham.AllowUserToAddRows = false;
            nudDonGia.Maximum = 1000000000; 
            nudSoLuong.Maximum = 1000000;    
            cboLoaiSP.Items.AddRange(new object[] { "Đồ uống", "Bánh kẹo", "Gia dụng", "Điểm tâm", "Bữa chính" });

            _listProduct.Add(new Product { MaSP = "SP01", TenSP = "Nước ngọt Coca", LoaiSP = "Đồ uống", DonGia = 10000, SoLuong = 50 });
            _listProduct.Add(new Product { MaSP = "SP02", TenSP = "Bánh Chocopie", LoaiSP = "Bánh kẹo", DonGia = 35000, SoLuong = 20 });
            _listProduct.Add(new Product { MaSP = "SP03", TenSP = "Bánh Pudding", LoaiSP = "Điểm tâm", DonGia = 25000, SoLuong = 5 });

            dgvSanPham.DataSource = _listProduct;

            FormatDataGridView();

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string maSP = txtMaSP.Text.Trim();
            string tenSP = txtTenSP.Text.Trim();
            string loaiSP = cboLoaiSP.Text.Trim();
            decimal donGia = nudDonGia.Value;
            int soLuong = (int)nudSoLuong.Value;

            // Bỏ trống dữ liệu
            if (string.IsNullOrEmpty(maSP) || string.IsNullOrEmpty(tenSP))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Mã sản phẩm và Tên sản phẩm!",
                                "Cảnh báo validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaSP.Focus();
                return;
            }

            //  Không cho thêm sản phẩm trùng mã 
            bool isDuplicate = _listProduct.Any(p => p.MaSP.Equals(maSP, StringComparison.OrdinalIgnoreCase));
            if (isDuplicate)
            {
                MessageBox.Show($"Mã sản phẩm [{maSP}] đã tồn tại trong hệ thống. Vui lòng nhập mã khác!",
                                "Lỗi trùng mã", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMaSP.Focus();
                txtMaSP.SelectAll();
                return;
            }

            // Không cho đơn giá hoặc số lượng âm (Yêu cầu 7.3)
            if (donGia < 0 || soLuong < 0)
            {
                MessageBox.Show("Đơn giá và Số lượng phải lớn hơn hoặc bằng 0!",
                                "Lỗi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Tạo đối tượng và thêm vào danh sách
            Product newProduct = new Product
            {
                MaSP = maSP,
                TenSP = tenSP,
                LoaiSP = string.IsNullOrEmpty(loaiSP) ? "Khác" : loaiSP,
                DonGia = donGia,
                SoLuong = soLuong
            };
            if (donGia <= 0)
            {
                MessageBox.Show("Đơn giá phải lớn hơn 0!", "Cảnh báo validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                nudDonGia.Focus();
                return;
            }

            if (soLuong <= 0)
            {
                MessageBox.Show("Số lượng phải lớn hơn 0!", "Cảnh báo validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                nudSoLuong.Focus();
                return;
            }
            _listProduct.Add(newProduct);

            // Hiển thị lại toàn bộ danh sách sản phẩm
            dgvSanPham.DataSource = null;
            dgvSanPham.DataSource = _listProduct;
            FormatDataGridView();

            MessageBox.Show("Thêm sản phẩm mới thành công!",
                            "Thông báo",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

            ClearInput();


        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string maSP = txtMaSP.Text.Trim();

            if (string.IsNullOrEmpty(maSP))
            {
                MessageBox.Show("Vui lòng chọn hoặc nhập Mã sản phẩm cần sửa!",
                                "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Tìm sản phẩm theo mã
            var prod = _listProduct.FirstOrDefault(p => p.MaSP.Equals(maSP, StringComparison.OrdinalIgnoreCase));
            if (prod == null)
            {
                MessageBox.Show($"Không tìm thấy sản phẩm có mã [{maSP}] để cập nhật!",
                                "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Kiểm tra thông tin hợp lệ
            if (string.IsNullOrEmpty(txtTenSP.Text.Trim()))
            {
                MessageBox.Show("Tên sản phẩm không được để trống!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Cập nhật thông tin
            prod.TenSP = txtTenSP.Text.Trim();
            prod.LoaiSP = cboLoaiSP.Text.Trim();
            prod.DonGia = nudDonGia.Value;
            prod.SoLuong = (int)nudSoLuong.Value;

            // Làm mới giao diện DataGridView
            dgvSanPham.Refresh();
            MessageBox.Show("Cập nhật thông tin sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            ClearInput();

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maSP = txtMaSP.Text.Trim();

            if (string.IsNullOrEmpty(maSP))
            {
                MessageBox.Show("Vui lòng chọn dòng cần xóa trên bảng hoặc nhập Mã sản phẩm!",
                                "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var prod = _listProduct.FirstOrDefault(p => p.MaSP.Equals(maSP, StringComparison.OrdinalIgnoreCase));
            if (prod == null)
            {
                MessageBox.Show($"Không tìm thấy sản phẩm có mã [{maSP}]!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Yêu cầu 7.3: Hỏi xác nhận bằng MessageBox trước khi xóa
            DialogResult confirm = MessageBox.Show($"Bạn có chắc chắn muốn xóa sản phẩm [{prod.TenSP}] (Mã: {prod.MaSP}) không?",
                                                 "Xác nhận xóa",
                                                 MessageBoxButtons.YesNo,
                                                 MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                _listProduct.Remove(prod);
                MessageBox.Show("Đã xóa sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearInput();
            }

        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            ClearInput();
            // Trả DataGridView về danh sách đầy đủ ban đầu
            dgvSanPham.DataSource = _listProduct;

        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            string keyword = txtTimKiem.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(keyword))
            {
                // Nếu không nhập từ khóa, hiển thị lại toàn bộ danh sách
                dgvSanPham.DataSource = _listProduct;
                return;
            }

            // Tìm tương đối theo Mã SP hoặc Tên SP
            var filteredList = _listProduct.Where(p => p.MaSP.ToLower().Contains(keyword) ||
                                                       p.TenSP.ToLower().Contains(keyword)).ToList();

            dgvSanPham.DataSource = new BindingList<Product>(filteredList);

            if (filteredList.Count == 0)
            {
                MessageBox.Show("Không tìm thấy sản phẩm nào khớp với từ khóa!", "Kết quả tìm kiếm", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void dgvSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvSanPham.Rows.Count)
            {
                DataGridViewRow row = dgvSanPham.Rows[e.RowIndex];

                txtMaSP.Text = row.Cells["MaSP"].Value?.ToString();
                txtTenSP.Text = row.Cells["TenSP"].Value?.ToString();
                cboLoaiSP.Text = row.Cells["LoaiSP"].Value?.ToString();

                if (decimal.TryParse(row.Cells["DonGia"].Value?.ToString(), out decimal donGia))
                    nudDonGia.Value = donGia;

                if (int.TryParse(row.Cells["SoLuong"].Value?.ToString(), out int soLuong))
                    nudSoLuong.Value = soLuong;
            }


        }
        private void ClearInput()
        {
            txtMaSP.Clear();
            txtTenSP.Clear();
            cboLoaiSP.SelectedIndex = -1;
            nudDonGia.Value = 0;
            nudSoLuong.Value = 0;
            txtTimKiem.Clear();

            txtMaSP.Focus(); // Đưa con trỏ chuột về ô Mã SP
        }
        private void FormatDataGridView()
        {
            dgvSanPham.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            if (dgvSanPham.Columns["MaSP"] != null) dgvSanPham.Columns["MaSP"].HeaderText = "Mã sản phẩm";
            if (dgvSanPham.Columns["TenSP"] != null) dgvSanPham.Columns["TenSP"].HeaderText = "Tên sản phẩm";
            if (dgvSanPham.Columns["LoaiSP"] != null) dgvSanPham.Columns["LoaiSP"].HeaderText = "Loại sản phẩm";
            if (dgvSanPham.Columns["DonGia"] != null) dgvSanPham.Columns["DonGia"].HeaderText = "Đơn giá (VNĐ)";
            if (dgvSanPham.Columns["SoLuong"] != null) dgvSanPham.Columns["SoLuong"].HeaderText = "Số lượng";
        }


    }
}
