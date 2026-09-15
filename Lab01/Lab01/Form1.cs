using System;
using System.Windows.Forms;

namespace Lab01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // 1. Khởi tạo dữ liệu ban đầu cho ComboBox khi load Form
        private void Form1_Load(object sender, EventArgs e)
        {
            
       


        }

        // 2. Nút Hiển thị
        private void btnHienThi_Click(object sender, EventArgs e)
        {
            // Kiểm tra Họ tên
            if (string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                MessageBox.Show("Họ tên không được để rỗng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHoTen.Focus();
                return;
            }

            // Kiểm tra Năm sinh
            int namHienTai = DateTime.Now.Year;
            if (string.IsNullOrWhiteSpace(txtNamSinh.Text))
            {
                MessageBox.Show("Năm sinh không được để rỗng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNamSinh.Focus();
                return;
            }

            if (!int.TryParse(txtNamSinh.Text.Trim(), out int namSinh) || namSinh < 1900 || namSinh > namHienTai)
            {
                MessageBox.Show($"Năm sinh phải là số nguyên từ 1900 đến {namHienTai}!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNamSinh.SelectAll();
                txtNamSinh.Focus();
                return;
            }

            // Kiểm tra Email
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Email không được để rỗng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return;
            }

            // Kiểm tra Giới tính
            if (!radNam.Checked && !radNu.Checked)
            {
                MessageBox.Show("Vui lòng chọn giới tính!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra Khoa / Lớp
            if (cboKhoa.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn Khoa hoặc Lớp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Tính toán và định dạng thông tin
            int tuoi = namHienTai - namSinh;
            string gioiTinh = radNam.Checked ? "Nam" : "Nữ";
            string khoa = cboKhoa.SelectedItem.ToString();

            // Hiển thị ra ô txtKetQua
            txtKetQua.Text = $"THÔNG TIN SINH VIÊN\r\n" +
                            $"Họ tên: {txtHoTen.Text.Trim()}\r\n" +
                            $"Tuổi: {tuoi}\r\n" +
                            $"Email: {txtEmail.Text.Trim()}\r\n" +
                            $"Giới tính: {gioiTinh}\r\n" +
                            $"Khoa/Lớp: {khoa}";
        }

        // 3. Nút Xóa
        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtHoTen.Clear();
            txtNamSinh.Clear();
            txtEmail.Clear();
            txtKetQua.Clear();

            radNam.Checked = false;
            radNu.Checked = false;

            if (cboKhoa.Items.Count > 0)
            {
                cboKhoa.SelectedIndex = 0;
            }

            txtHoTen.Focus();
        }

        // 4. Nút Thoát
        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show(
                "Bạn có chắc chắn muốn thoát chương trình?",
                "Xác nhận thoát",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (dr == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lblEmail_Click(object sender, EventArgs e)
        {

        }

        private void cboKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}