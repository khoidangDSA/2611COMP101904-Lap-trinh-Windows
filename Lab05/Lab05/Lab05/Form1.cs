using System.Drawing.Drawing2D;

namespace Lab05
{
    public partial class dangKyKhoaHoc : Form
    {
        // Lớp Khóa học
        public class KhoaHoc
        {
            public string TenKhoaHoc { get; }
            public decimal HocPhi { get; }

            public KhoaHoc(string ten, decimal hocPhi)
            {
                TenKhoaHoc = ten;
                HocPhi = hocPhi;
            }

            public override string ToString()
            {
                return TenKhoaHoc;
            }
        }
        public dangKyKhoaHoc()
        {
            this.ResizeRedraw = true;
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dangKyKhoaHoc_Load(object sender, EventArgs e)
        {
            cboKhoaHoc.Items.Clear();
            cboKhoaHoc.Items.Add(new KhoaHoc("C# WinForms cơ bản", 800000));
            cboKhoaHoc.Items.Add(new KhoaHoc("SQL Server cơ bản", 700000));
            cboKhoaHoc.Items.Add(new KhoaHoc("Web Frontend cơ bản", 750000));
            cboKhoaHoc.Items.Add(new KhoaHoc("Lập trình Python cơ bản", 650000));

            // mặc định chọn khóa học đầu
            if (cboKhoaHoc.Items.Count > 0) cboKhoaHoc.SelectedIndex = 0;



            // HP ban đầu
            TinhHocPhi();

        }
       
        private void TinhHocPhi()
        {
            if (cboKhoaHoc.SelectedItem is KhoaHoc kh)
            {
                decimal tongTien = kh.HocPhi * numSoThang.Value;
                lblTongTien.Text = tongTien.ToString("N0") + " VNĐ";
            }
        }

        private void grpHocVien_Paint(object sender, PaintEventArgs e) 
        {
            using (LinearGradientBrush brush = new LinearGradientBrush(
        this.ClientRectangle,
        Color.FromArgb(180, 225, 230),  // Màu góc trên-trái (Xanh ngọc nhẹ)
        Color.FromArgb(240, 210, 220),  // Màu góc dưới-phải (Hồng nhạt)
        45F))                           // Góc nghiêng 45 độ
            {
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }
        }
        
        private void lbldangKyKhoaHoc_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void grpKhoaHoc_Enter(object sender, EventArgs e)
        {

        }

        private void lblTongTien_Click(object sender, EventArgs e)
        {

        }

        private void chkNhanEmail_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            //Xóa họ tên và số điện thoại
            txtHoTen.Clear();
            txtSoDienThoai.Clear();

            //  Đưa ngày sinh về ngày hiện tại
            dtpNgaySinh.Value = DateTime.Today;

            // Bỏ chọn nhận email
            chkNhanEmail.Checked = false;

            // Chọn lại khóa học đầu tiên 
            if (cboKhoaHoc.Items.Count > 0) cboKhoaHoc.SelectedIndex = 0;

            // Chọn lại hình thức Online
            radOnline.Checked = true;

            // tháng về 1
            numSoThang.Value = 1;

            // 7. Cập nhật lại tổng tiền theo giá trị mới
            TinhHocPhi();

            // 8. Đưa con trỏ về ô họ tên
            txtHoTen.Focus();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Bạn có chắc muốn thoát?",
                "Xác Nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }

        }

        private void cboKhoaHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            TinhHocPhi();
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            //1. check họ tên

            // họ tên k được để trống
            if (string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                MessageBox.Show("Vui lòng nhập họ và tên!", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHoTen.Focus();
                return;
            }
            // k được có số in họ tên
            if (txtHoTen.Text.Any(char.IsDigit))
            {
                MessageBox.Show("Họ tên hợp lệ không được chứa chữ số!", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHoTen.Focus();
                return;
            }
            //2. check SĐT

            // sdt not trống
            if (string.IsNullOrWhiteSpace(txtSoDienThoai.Text))
            {
                MessageBox.Show("Vui lòng nhập số điện thoại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoDienThoai.Focus();
                return;
            }
            // sdt đúng 10 số không > không <
            if (txtSoDienThoai.Text.Trim().Length != 10)
            {
                MessageBox.Show("Số điện thoại phải có đúng 10 chữ số!", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoDienThoai.Focus();
                return;
            }
            // sdt k có chữ
            if (!txtSoDienThoai.Text.All(char.IsDigit))
            {
                MessageBox.Show("Số điện thoại chỉ được bao gồm các chữ số!", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoDienThoai.Focus();
                return;
            }

            //3 check khóa học
            if (cboKhoaHoc.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn khóa học!", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string hinhThuc = radOnline.Checked ? "Online" : "Trực tiếp";
            string email = chkNhanEmail.Checked ? "Có" : "Không";

            // check ngày sinh
            if (dtpNgaySinh.Value.Date >= DateTime.Today)
            {
                MessageBox.Show("Ngày sinh phải nhỏ hơn ngày hiện tại!", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpNgaySinh.Focus();
                return;
            }

            // Chuẩn hóa chuỗi hiển thị đúng theo các biến bạn đã đặt trên Form:
            string thongTin =
                "========================================\n" +
                "         PHIẾU ĐĂNG KÝ KHÓA HỌC         \n" +
                "========================================\n\n" +
                $"• Họ và tên:\t\t{txtHoTen.Text.Trim()}\n" +
                $"• Số điện thoại:\t{txtSoDienThoai.Text.Trim()}\n" +
                $"• Ngày sinh:\t\t{dtpNgaySinh.Value:dd/MM/yyyy}\n" + // Bổ sung theo đề
                $"• Khóa học:\t\t{cboKhoaHoc.Text}\n" +
                $"• Hình thức:\t\t{hinhThuc}\n" +
                $"• Số tháng:\t\t{numSoThang.Value} tháng\n" +       // Bổ sung theo đề
                $"• Nhận email:\t\t{email}\n\n" +
                "----------------------------------------\n" +
                $"► TỔNG HỌC PHÍ:\t{lblTongTien.Text}\n" +
                "========================================";

            MessageBox.Show(thongTin, "Phiếu đăng ký", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void lblTongHocPhi_Click(object sender, EventArgs e)
        {

        }

        private void numSoThang_ValueChanged(object sender, EventArgs e)
        {
            TinhHocPhi();
        }
    }
}
