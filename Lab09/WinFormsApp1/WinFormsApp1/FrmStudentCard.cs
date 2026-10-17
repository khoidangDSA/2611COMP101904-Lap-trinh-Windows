using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class FrmStudentCard : Form
    {
        public FrmStudentCard()
        {
            InitializeComponent();
            InitializeData();
            RegisterEvents();
        }

        private void InitializeData()
        {
            // chọn thẳng về ngày quá khứ để tránh lỗi khi chọn ngày sinh
            dtpNgaySinh.Value = DateTime.Today.AddYears(-20);
            // Bật Double Buffering cho Form
            this.DoubleBuffered = true;

            // Bật Double Buffering cho Panel xem trước để chống chớp nháy khi vẽ GDI+
            typeof(Panel).InvokeMember("DoubleBuffered",
                System.Reflection.BindingFlags.SetProperty |
                System.Reflection.BindingFlags.Instance |
                System.Reflection.BindingFlags.NonPublic,
                null, pnlXemTruocThe, new object[] { true });

            cboLop.Items.AddRange(new object[] { "K49.CNTT.A", "K50.CNTT.A", "K51.CNTT.A", "K52.CNTT.A" });
            cboKhoa.Items.AddRange(new object[] { "Công nghệ thông tin", "Khoa Toán - Tin học","Khoa tiếng anh" });
            cboKhoaHoc.Items.AddRange(new object[] { "K49", "K50", "K51", "K52" });

            cboLop.SelectedIndex = 0;
            cboKhoa.SelectedIndex = 0;
            cboKhoaHoc.SelectedIndex = 0;

            // Không chọn giới tính mặc định
            radNam.Checked = false;
            radNu.Checked = false;
            radKhac.Checked = false;

            picAnh.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void RegisterEvents()
        {
            pnlXemTruocThe.Paint += pnlXemTruocThe_Paint;
            printDocument1.PrintPage += printDocument1_PrintPage;

            txtMaSV.TextChanged += DuLieuThayDoi;
            txtHoTen.TextChanged += DuLieuThayDoi;
            cboKhoaHoc.SelectedIndexChanged += DuLieuThayDoi;
            cboLop.SelectedIndexChanged += DuLieuThayDoi;
            cboKhoa.SelectedIndexChanged += DuLieuThayDoi;
            dtpNgaySinh.ValueChanged += DuLieuThayDoi;

            radNam.CheckedChanged += DuLieuThayDoi;
            radNu.CheckedChanged += DuLieuThayDoi;
            radKhac.CheckedChanged += DuLieuThayDoi;
        }

        private void DuLieuThayDoi(object? sender, EventArgs e)
        {
            pnlXemTruocThe.Invalidate();
        }

        private string LayGioiTinh()
        {
            if (radNam.Checked) return "Nam";
            if (radNu.Checked) return "Nữ";
            if (radKhac.Checked) return "Khác";
            return "";
        }

        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            using OpenFileDialog dlg = new OpenFileDialog();
            dlg.Title = "Chọn ảnh sinh viên";
            dlg.Filter = "File ảnh (*.jpg;*.jpeg;*.png;*.bmp)|*.jpg;*.jpeg;*.png;*.bmp";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using Image anhTam = Image.FromFile(dlg.FileName);
                    Image anhSaoChep = new Bitmap(anhTam);

                    picAnh.Image?.Dispose();
                    picAnh.Image = anhSaoChep;
                    pnlXemTruocThe.Invalidate();
                }
                catch
                {
                    MessageBox.Show("File được chọn không phải ảnh hợp lệ.",
                        "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Đã giữ nguyên kiểu trả về StudentCardInfo
        private StudentCardInfo GetStudentInfo()
        {
            return new StudentCardInfo
            {
                MaSinhVien = txtMaSV.Text.Trim(),
                HoTen = txtHoTen.Text.Trim(),
                Lop = cboLop.Text,
                Khoa = cboKhoa.Text,
                KhoaHoc = cboKhoaHoc.Text,
                NgaySinh = dtpNgaySinh.Value,
                GioiTinh = LayGioiTinh(),
                AnhDaiDien = picAnh.Image
            };
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtMaSV.Text))
            {
                MessageBox.Show("Vui lòng nhập mã sinh viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaSV.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                MessageBox.Show("Vui lòng nhập họ tên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHoTen.Focus();
                return false;
            }

            // Kiểm tra Ngày sinh phải nhỏ hơn ngày hiện tại
            if (dtpNgaySinh.Value.Date >= DateTime.Today)
            {
                MessageBox.Show("Ngày sinh phải nhỏ hơn ngày hiện tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpNgaySinh.Focus();
                return false;
            }

            if (picAnh.Image == null)
            {
                MessageBox.Show("Vui lòng chọn ảnh sinh viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void pnlXemTruocThe_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            Rectangle card = new Rectangle(20, 20,
                pnlXemTruocThe.Width - 40,
                pnlXemTruocThe.Height - 40);

            DrawStudentCard(e.Graphics, card, GetStudentInfo());
        }

        // Đã đổi tham số truyền vào thành StudentCardInfo s
        private void DrawStudentCard(Graphics g, Rectangle card, StudentCardInfo s)
        {
            g.SmoothingMode = SmoothingMode.AntiAlias;

            using Font schoolFont = new Font("Arial", 10, FontStyle.Bold);
            using Font titleFont = new Font("Arial", 16, FontStyle.Bold);
            using Font labelFont = new Font("Arial", 10, FontStyle.Bold);
            using Font normalFont = new Font("Arial", 10, FontStyle.Regular);
            using Pen borderPen = new Pen(Color.Navy, 2);
            using SolidBrush blueBrush = new SolidBrush(Color.Navy);
            using SolidBrush bgBrush = new SolidBrush(Color.FromArgb(238, 247, 247));

            g.FillRectangle(bgBrush, card);
            g.DrawRectangle(borderPen, card);

            int x = card.Left;
            int y = card.Top;

            g.DrawString("TRƯỜNG ĐẠI HỌC SƯ PHẠM TP. HỒ CHÍ MINH",
                schoolFont, blueBrush, x + 20, y + 15);
            g.DrawString("THẺ SINH VIÊN", titleFont, blueBrush, x + 20, y + 45);

            Rectangle photoBox = new Rectangle(x + 25, y + 90, 115, 150);
            g.FillRectangle(Brushes.White, photoBox);
            g.DrawRectangle(Pens.Gray, photoBox);

            if (s.AnhDaiDien != null)
                DrawImageZoom(g, s.AnhDaiDien, photoBox);
            else
                g.DrawString("Ảnh", normalFont, Brushes.Gray, photoBox.Left + 35, photoBox.Top + 65);

            int infoX = x + 165;
            int infoY = y + 95;

            DrawInfoLine(g, "MSSV:", s.MaSinhVien, labelFont, normalFont, infoX, infoY);
            DrawInfoLine(g, "Họ tên:", s.HoTen, labelFont, normalFont, infoX, infoY + 30);
            DrawInfoLine(g, "Giới tính:", s.GioiTinh, labelFont, normalFont, infoX, infoY + 60);
            DrawInfoLine(g, "Lớp:", s.Lop, labelFont, normalFont, infoX, infoY + 90);
            DrawInfoLine(g, "Khoa:", s.Khoa, labelFont, normalFont, infoX, infoY + 120);
            DrawInfoLine(g, "Khóa:", s.KhoaHoc, labelFont, normalFont, infoX, infoY + 150);
            DrawInfoLine(g, "Ngày sinh:", s.NgaySinh.ToString("dd/MM/yyyy"), labelFont, normalFont, infoX, infoY + 180);
        }

        private void DrawInfoLine(Graphics g, string label, string value, Font labelFont, Font normalFont, int x, int y)
        {
            g.DrawString(label, labelFont, Brushes.Black, x, y);
            g.DrawString(value, normalFont, Brushes.Black, x + 105, y);
        }

        private void DrawImageZoom(Graphics g, Image image, Rectangle box)
        {
            float ratio = Math.Min(
                (float)box.Width / image.Width,
                (float)box.Height / image.Height);

            int width = (int)(image.Width * ratio);
            int height = (int)(image.Height * ratio);
            int x = box.Left + (box.Width - width) / 2;
            int y = box.Top + (box.Height - height) / 2;

            g.DrawImage(image, new Rectangle(x, y, width, height));
        }

        private void btnXemTruocIn_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.Width = 900;
            printPreviewDialog1.Height = 700;
            printPreviewDialog1.ShowDialog();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaSV.Clear();
            txtHoTen.Clear();
            if (cboLop.Items.Count > 0) cboLop.SelectedIndex = 0;
            if (cboKhoa.Items.Count > 0) cboKhoa.SelectedIndex = 0;
            if (cboKhoaHoc.Items.Count > 0) cboKhoaHoc.SelectedIndex = 0;

            radNam.Checked = false;
            radNu.Checked = false;
            radKhac.Checked = false;

            dtpNgaySinh.Value = DateTime.Today.AddYears(-20);
            picAnh.Image?.Dispose();
            picAnh.Image = null;
            pnlXemTruocThe.Invalidate();
            txtMaSV.Focus();
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;
            printDialog1.Document = printDocument1;

            if (printDialog1.ShowDialog() == DialogResult.OK)
                printDocument1.Print();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            StudentCardInfo info = GetStudentInfo();
            Rectangle card = new Rectangle(e.MarginBounds.Left, e.MarginBounds.Top, 520, 320);
            DrawStudentCard(e.Graphics, card, info);
            e.HasMorePages = false;
        }

        private void cboLop_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}