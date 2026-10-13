using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace ProductManager
{
    public partial class FrmProduct : Form
    {
        private readonly BindingList<Product> products = new BindingList<Product>();
        private readonly BindingSource productSource = new BindingSource();
        private string selectedImagePath = string.Empty;

        public FrmProduct()
        {
            InitializeComponent();
        }

        private void FrmProduct_Load(object sender, EventArgs e)
        {
            numDonGia.Minimum = 0;
            numDonGia.Maximum = 1000000000;
            numSoLuong.Minimum = 0; // Cho phép số lượng bằng 0.
            numSoLuong.Maximum = 1000000;

            // Cho phép chọn ngày để ValidateInput hiển thị lỗi rõ ràng nếu chọn ngày tương lai.
            // Điều kiện ngày được kiểm tra khi Thêm hoặc Sửa.

            cboLoaiSP.DropDownStyle = ComboBoxStyle.DropDownList;
            cboLoaiSP.Items.Clear();
            cboLoaiSP.Items.AddRange(new object[] { "Điện tử", "Văn phòng", "Gia dụng", "Thời trang" });
            cboLoaiSP.SelectedIndex = 0;
            picSanPham.SizeMode = PictureBoxSizeMode.Zoom;

            products.Add(new Product { MaSP = "SP01", TenSP = "Chuột không dây", LoaiSP = "Điện tử", DonGia = 150000, SoLuong = 20, NgayNhap = DateTime.Today, ConKinhDoanh = true });
            products.Add(new Product { MaSP = "SP02", TenSP = "Bút bi", LoaiSP = "Văn phòng", DonGia = 5000, SoLuong = 100, NgayNhap = DateTime.Today, ConKinhDoanh = true });
            products.Add(new Product { MaSP = "SP03", TenSP = "Nồi cơm điện", LoaiSP = "Gia dụng", DonGia = 850000, SoLuong = 10, NgayNhap = DateTime.Today, ConKinhDoanh = true });

            productSource.DataSource = products;
            dgvProducts.AutoGenerateColumns = true;
            dgvProducts.DataSource = productSource;
            ConfigureProductGrid();

            dgvProducts.ReadOnly = true;
            dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProducts.MultiSelect = false;
            dgvProducts.AllowUserToAddRows = false;
            dgvProducts.CellClick += dgvProducts_CellClick;
            dgvProducts.CellMouseDown += dgvProducts_CellMouseDown;

            UpdateStatus("Sẵn sàng");
        }

        private void ConfigureProductGrid()
        {
            if (dgvProducts.Columns["DuongDanAnh"] != null)
                dgvProducts.Columns["DuongDanAnh"].Visible = false;

            SetColumnHeader("MaSP", "Mã SP");
            SetColumnHeader("TenSP", "Tên sản phẩm");
            SetColumnHeader("LoaiSP", "Loại SP");
            SetColumnHeader("DonGia", "Đơn giá");
            SetColumnHeader("SoLuong", "Số lượng");
            SetColumnHeader("NgayNhap", "Ngày nhập");
            SetColumnHeader("ConKinhDoanh", "Còn KD");
            SetColumnHeader("ThanhTien", "Thành tiền");

            if (dgvProducts.Columns["DonGia"] != null)
                dgvProducts.Columns["DonGia"].DefaultCellStyle.Format = "N0";
            if (dgvProducts.Columns["ThanhTien"] != null)
                dgvProducts.Columns["ThanhTien"].DefaultCellStyle.Format = "N0";
            if (dgvProducts.Columns["NgayNhap"] != null)
                dgvProducts.Columns["NgayNhap"].DefaultCellStyle.Format = "dd/MM/yyyy";

            dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            if (dgvProducts.Columns["TenSP"] != null)
                dgvProducts.Columns["TenSP"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void SetColumnHeader(string columnName, string headerText)
        {
            if (dgvProducts.Columns[columnName] != null)
                dgvProducts.Columns[columnName].HeaderText = headerText;
        }

        private bool ValidateInput(bool isEdit)
        {
            bool isValid = true;
            errorProvider1.Clear();
            string maSP = txtMaSP.Text.Trim();

            if (string.IsNullOrWhiteSpace(maSP))
            {
                errorProvider1.SetError(txtMaSP, "Vui lòng nhập mã sản phẩm!");
                isValid = false;
            }
            else if (!isEdit && products.Any(p => string.Equals(p.MaSP, maSP, StringComparison.OrdinalIgnoreCase)))
            {
                errorProvider1.SetError(txtMaSP, "Mã sản phẩm đã tồn tại!");
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(txtTenSP.Text))
            {
                errorProvider1.SetError(txtTenSP, "Vui lòng nhập tên sản phẩm!");
                isValid = false;
            }

            if (cboLoaiSP.SelectedIndex < 0)
            {
                errorProvider1.SetError(cboLoaiSP, "Vui lòng chọn loại sản phẩm!");
                isValid = false;
            }

            if (numDonGia.Value <= 0)
            {
                errorProvider1.SetError(numDonGia, "Đơn giá phải lớn hơn 0!");
                isValid = false;
            }

            // Điều kiện là số lượng >= 0, vì vậy chỉ giá trị âm mới sai.
            if (numSoLuong.Value < 0)
            {
                errorProvider1.SetError(numSoLuong, "Số lượng không được âm!");
                isValid = false;
            }

            // Kiểm tra dự phòng; MaxDate bên trên cũng chặn ngày tương lai.
            if (dtpNgayNhap.Value.Date > DateTime.Today)
            {
                errorProvider1.SetError(dtpNgayNhap, "Ngày nhập không được vượt quá ngày hiện tại!");
                isValid = false;
            }

            return isValid;
        }

        private Product? GetSelectedProduct(bool showMessage = true)
        {
            // Lấy từ dòng hiện tại của DataGridView để vẫn đúng khi đang tìm kiếm.
            Product? product = dgvProducts.CurrentRow?.DataBoundItem as Product;
            if (product == null || dgvProducts.CurrentRow == null || !dgvProducts.CurrentRow.Selected)
            {
                if (showMessage)
                    MessageBox.Show("Vui lòng chọn một sản phẩm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return null;
            }
            return product;
        }

        private void LoadProductToForm(Product p)
        {
            txtMaSP.Text = p.MaSP;
            txtMaSP.ReadOnly = true;
            txtTenSP.Text = p.TenSP;
            cboLoaiSP.Text = p.LoaiSP;
            numDonGia.Value = Math.Min(numDonGia.Maximum, Math.Max(numDonGia.Minimum, p.DonGia));
            numSoLuong.Value = Math.Min(numSoLuong.Maximum, Math.Max(numSoLuong.Minimum, p.SoLuong));
            dtpNgayNhap.Value = p.NgayNhap.Date > DateTime.Today ? DateTime.Today : p.NgayNhap.Date;
            chkConKinhDoanh.Checked = p.ConKinhDoanh;

            selectedImagePath = !string.IsNullOrWhiteSpace(p.DuongDanAnh) && File.Exists(p.DuongDanAnh)
                ? p.DuongDanAnh : string.Empty;
            ShowProductImage(selectedImagePath);
            errorProvider1.Clear();
        }

        private void ShowProductImage(string path)
        {
            ClearProductImage();
            if (string.IsNullOrWhiteSpace(path) || !File.Exists(path))
                return;

            try
            {
                using Image sourceImage = Image.FromFile(path);
                picSanPham.Image = new Bitmap(sourceImage); // Bản sao để không khóa file nguồn.
            }
            catch (Exception)
            {
                picSanPham.Image = null;
                selectedImagePath = string.Empty;
            }
        }

        private void ClearProductImage()
        {
            Image? oldImage = picSanPham.Image;
            picSanPham.Image = null;
            oldImage?.Dispose();
        }

        private void dgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return; // Không xử lý khi nhấn vào tiêu đề cột.

            Product? p = dgvProducts.Rows[e.RowIndex].DataBoundItem as Product;
            if (p != null)
                LoadProductToForm(p);
        }

        private void dgvProducts_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                dgvProducts.ClearSelection();
                dgvProducts.Rows[e.RowIndex].Selected = true;
                dgvProducts.CurrentCell = dgvProducts.Rows[e.RowIndex].Cells[e.ColumnIndex];
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!ValidateInput(isEdit: false))
                return;

            Product p = new Product
            {
                MaSP = txtMaSP.Text.Trim(),
                TenSP = txtTenSP.Text.Trim(),
                LoaiSP = cboLoaiSP.Text,
                DonGia = numDonGia.Value,
                SoLuong = (int)numSoLuong.Value,
                NgayNhap = dtpNgayNhap.Value.Date,
                ConKinhDoanh = chkConKinhDoanh.Checked,
                DuongDanAnh = selectedImagePath
            };

            products.Add(p);
            txtTimKiem.Clear(); // Bỏ lọc để nhìn thấy sản phẩm vừa thêm.
            dgvProducts.DataSource = productSource;
            ConfigureProductGrid();
            ClearInput();
            UpdateStatus("Đã thêm sản phẩm mới");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Product? p = GetSelectedProduct();
            if (p == null || !ValidateInput(isEdit: true))
                return;

            p.TenSP = txtTenSP.Text.Trim();
            p.LoaiSP = cboLoaiSP.Text;
            p.DonGia = numDonGia.Value;
            p.SoLuong = (int)numSoLuong.Value;
            p.NgayNhap = dtpNgayNhap.Value.Date;
            p.ConKinhDoanh = chkConKinhDoanh.Checked;
            p.DuongDanAnh = selectedImagePath;

            ApplySearch();
            ClearInput();
            UpdateStatus("Đã cập nhật sản phẩm");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            Product? p = GetSelectedProduct();
            if (p == null)
                return;

            DialogResult answer = MessageBox.Show(
                $"Bạn có chắc muốn xóa sản phẩm {p.TenSP}?", "Xác nhận xóa",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (answer != DialogResult.Yes)
                return;

            products.Remove(p);
            ApplySearch();
            ClearInput();
            UpdateStatus("Đã xóa sản phẩm");
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            ApplySearch();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtTimKiem.Clear();
            dgvProducts.DataSource = productSource;
            ConfigureProductGrid();
            ClearInput();
            UpdateStatus("Đã làm mới dữ liệu");
        }

        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            using OpenFileDialog dialog = new OpenFileDialog
            {
                Title = "Chọn ảnh sản phẩm",
                Filter = "Tệp hình ảnh|*.jpg;*.jpeg;*.png;*.bmp",
                CheckFileExists = true,
                Multiselect = false
            };

            if (dialog.ShowDialog() != DialogResult.OK)
                return;

            try
            {
                using Image sourceImage = Image.FromFile(dialog.FileName);
                Image newImage = new Bitmap(sourceImage);
                ClearProductImage();
                picSanPham.Image = newImage;
                selectedImagePath = dialog.FileName;
                UpdateStatus("Đã chọn ảnh sản phẩm");
            }
            catch (Exception)
            {
                MessageBox.Show("Không thể mở tệp ảnh đã chọn. Vui lòng chọn ảnh khác.",
                    "Lỗi ảnh", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearInput()
        {
            txtMaSP.Clear();
            txtMaSP.ReadOnly = false;
            txtTenSP.Clear();
            if (cboLoaiSP.Items.Count > 0)
                cboLoaiSP.SelectedIndex = 0;

            numDonGia.Value = Math.Min(numDonGia.Maximum, Math.Max(numDonGia.Minimum, 1000));
            numSoLuong.Value = 0;
            dtpNgayNhap.Value = DateTime.Today;
            chkConKinhDoanh.Checked = true;
            ClearProductImage();
            selectedImagePath = string.Empty;
            errorProvider1.Clear();

            dgvProducts.ClearSelection();
            dgvProducts.CurrentCell = null;
            txtMaSP.Focus();
        }

        private void UpdateStatus(string message)
        {
            int totalStock = products.Sum(p => p.SoLuong);
            lblStatus.Text = $"{message} | Tổng số mặt hàng: {products.Count} | Tổng tồn kho: {totalStock:N0}";
        }

        private void ApplySearch()
        {
            string keyword = txtTimKiem.Text.Trim();
            if (string.IsNullOrWhiteSpace(keyword))
            {
                dgvProducts.DataSource = productSource;
                ConfigureProductGrid();
                UpdateStatus("Sẵn sàng");
                return;
            }

            var result = products.Where(p =>
                p.MaSP.Contains(keyword, StringComparison.OrdinalIgnoreCase) ||
                p.TenSP.Contains(keyword, StringComparison.OrdinalIgnoreCase)).ToList();

            dgvProducts.DataSource = result;
            ConfigureProductGrid();
            int totalStock = products.Sum(p => p.SoLuong);
            lblStatus.Text = $"Tìm thấy {result.Count} sản phẩm | Tổng mặt hàng: {products.Count} | Tổng tồn kho: {totalStock:N0}";
        }

        private void cmsChiTiet_Click(object sender, EventArgs e)
        {
            ShowSelectedProductDetails();
        }

        // Designer đang nối nút Làm mới với handler này.
        private void btnLamMoi_Click_1(object sender, EventArgs e)
        {
            btnLamMoi_Click(sender, e);
        }

        private void picSanPham_Click(object sender, EventArgs e)
        {
            // Không cần xử lý khi nhấn vào ảnh.
        }

        // Designer đang nối nút Chọn ảnh với handler này.
        private void btnChonAnh_Click_1(object sender, EventArgs e)
        {
            btnChonAnh_Click(sender, e);
        }

        private void mnuFileExit_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void tbsThem_Click(object sender, EventArgs e)
        {
            btnThem.PerformClick();
        }

        private void tbsXoa_Click(object sender, EventArgs e)
        {
            btnXoa.PerformClick();
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            // Không cần xử lý khi nhấn StatusStrip.
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            // Giữ handler theo Designer.
        }

        private void cmsXoa_Click(object sender, EventArgs e)
        {
            btnXoa.PerformClick();
        }

        private void cmsXemChiTiet_Click(object sender, EventArgs e)
        {
            ShowSelectedProductDetails();
        }

        private void ShowSelectedProductDetails()
        {
            Product? p = GetSelectedProduct();
            if (p == null)
                return;

            MessageBox.Show(
                $"Mã SP: {p.MaSP}\nTên SP: {p.TenSP}\nLoại SP: {p.LoaiSP}\n" +
                $"Đơn giá: {p.DonGia:N0} VNĐ\nSố lượng: {p.SoLuong}\n" +
                $"Thành tiền: {p.ThanhTien:N0} VNĐ\nNgày nhập: {p.NgayNhap:dd/MM/yyyy}",
                "Chi tiết sản phẩm", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if (IsHandleCreated && productSource.DataSource != null)
                ApplySearch();
        }

        private void cmsSua_Click(object sender, EventArgs e)
        {
            btnSua.PerformClick();
        }

        private void tbsSua_Click(object sender, EventArgs e)
        {
            btnSua.PerformClick();
        }

        private void tbsLamMoi_Click(object sender, EventArgs e)
        {
            btnLamMoi.PerformClick();
        }

        private void tbsTimKiem_Click(object sender, EventArgs e)
        {
            btnTimKiem.PerformClick();
            txtTimKiem.Focus();
            txtTimKiem.SelectAll();
        }
    }
}
