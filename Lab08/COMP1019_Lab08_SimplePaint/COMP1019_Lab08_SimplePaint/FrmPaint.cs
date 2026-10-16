using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace COMP1019_Lab08_SimplePaint
{
    public partial class FrmPaint : Form
    {
        private readonly List<DrawItem> items = new List<DrawItem>();
        private DrawItem currentItem;
        private bool isDrawing = false;
        private Color currentColor = Color.Black;

        //  Biến lưu màu nền Canvas và Ảnh nền
        private Color canvasBgColor = Color.White;
        private Image bgImage = null;

        public FrmPaint()
        {
            InitializeComponent();
            Text = "COMP1019 - Simple Paint";
            StartPosition = FormStartPosition.CenterScreen;

            RegisterEvents();
        }

        private void RegisterEvents()
        {
            canvas.Paint += canvas_Paint;
            canvas.MouseDown += canvas_MouseDown;
            canvas.MouseMove += canvas_MouseMove;
            canvas.MouseUp += canvas_MouseUp;
        }

        //  CTRL + Z 
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Control | Keys.Z))
            {
                btnUndo_Click(null, null);
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private DrawMode CurrentMode
        {
            get
            {
                string mode = cboMode.SelectedItem.ToString();
                return (DrawMode)Enum.Parse(typeof(DrawMode), mode);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
               "Xóa toàn bộ vùng vẽ?",
               "Xác nhận",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                items.Clear();
                bgImage?.Dispose();
                bgImage = null;
                canvasBgColor = Color.White;
                canvas.Invalidate();
            }
        }

        private void cboMode_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            using ColorDialog dialog = new ColorDialog();
            dialog.Color = currentColor;

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                currentColor = dialog.Color;
                UpdateColorButtonImage(currentColor);
            }
        }

        // CHỨC NĂNG ĐỔI MÀU NỀN CANVAS
        private void btnBgColor_Click(object sender, EventArgs e)
        {
            using ColorDialog dialog = new ColorDialog();
            dialog.Color = canvasBgColor;

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                canvasBgColor = dialog.Color;
                canvas.Invalidate();
            }
        }

        // CHỨC NĂNG MỞ ẢNH NỀN
        private void btnOpen_Click(object sender, EventArgs e)
        {
            using OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image Files (*.jpg;*.jpeg;*.png;*.bmp)|*.jpg;*.jpeg;*.png;*.bmp";
            dialog.Title = "Chọn ảnh nền";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                bgImage?.Dispose();
                bgImage = Image.FromFile(dialog.FileName);
                canvas.Invalidate();
            }
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            if (items.Count == 0) return;

            items.RemoveAt(items.Count - 1);
            canvas.Invalidate();
        }

        private void canvas_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;

            isDrawing = true;

            currentItem = new DrawItem
            {
                Mode = CurrentMode,
                Start = e.Location,
                End = e.Location,
                Color = currentColor,
                Width = (float)nudWidth.Value
            };

            if (currentItem.Mode == DrawMode.Pen)
                currentItem.Points.Add(e.Location);
        }

        private void canvas_MouseMove(object sender, MouseEventArgs e)
        {
            lblStatus.Text = $"X = {e.X}, Y = {e.Y}, Items = {items.Count}";

            if (!isDrawing || currentItem == null) return;

            currentItem.End = e.Location;

            if (currentItem.Mode == DrawMode.Pen)
                currentItem.Points.Add(e.Location);

            canvas.Invalidate();
        }

        private void canvas_MouseUp(object sender, MouseEventArgs e)
        {
            if (!isDrawing || currentItem == null) return;

            currentItem.End = e.Location;
            items.Add(currentItem);

            currentItem = null;
            isDrawing = false;
            canvas.Invalidate();
        }

        private void canvas_Paint(object sender, PaintEventArgs e)
        {
            RenderCanvas(e.Graphics);
        }

        // HÀM CHUNG VẼ NỀN, ẢNH VÀ CÁC NÉT VẼ
        private void RenderCanvas(Graphics g)
        {
            g.SmoothingMode = SmoothingMode.AntiAlias;

            // 1. Tô màu nền Canvas
            g.Clear(canvasBgColor);

            // 2. Vẽ ảnh nền (nếu có)
            if (bgImage != null)
            {
                g.DrawImage(bgImage, 0, 0, canvas.Width, canvas.Height);
            }

            // 3. Vẽ danh sách các hình đã vẽ
            foreach (DrawItem item in items)
                DrawOneItem(g, item);

            // 4. Vẽ hình đang kéo rê chuột
            if (currentItem != null)
                DrawOneItem(g, currentItem);
        }

        private void DrawOneItem(Graphics g, DrawItem item)
        {
            using Pen pen = new Pen(item.Color, item.Width)
            {
                StartCap = LineCap.Round,
                EndCap = LineCap.Round,
                LineJoin = LineJoin.Round
            };
            using SolidBrush brush = new SolidBrush(item.Color);

            Rectangle rect = GetRectangle(item.Start, item.End);

            switch (item.Mode)
            {
                case DrawMode.Pen:
                    DrawFreePen(g, pen, item.Points);
                    break;
                case DrawMode.Line:
                    g.DrawLine(pen, item.Start, item.End);
                    break;
                case DrawMode.Rectangle:
                    g.DrawRectangle(pen, rect);
                    break;
                case DrawMode.Ellipse:
                    g.DrawEllipse(pen, rect);
                    break;
                case DrawMode.FillRectangle: //  Tô đặc hình chữ nhật
                    g.FillRectangle(brush, rect);
                    break;
                case DrawMode.FillEllipse: // Tô đặc hình ellipse
                    g.FillEllipse(brush, rect);
                    break;
            }
        }

       
        private void DrawFreePen(Graphics g, Pen pen, List<Point> points)
        {
            if (points.Count < 2) return;

            for (int i = 1; i < points.Count; i++)
            {
                g.DrawLine(pen, points[i - 1], points[i]);
            }
        }

        private Rectangle GetRectangle(Point start, Point end)
        {
            int x = Math.Min(start.X, end.X);
            int y = Math.Min(start.Y, end.Y);
            int width = Math.Abs(start.X - end.X);
            int height = Math.Abs(start.Y - end.Y);

            return new Rectangle(x, y, width, height);
        }

        private void FrmPaint_Load(object sender, EventArgs e)
        {
            // BẬT DOUBLE BUFFERING CHỐNG CHỚP
            typeof(Panel).GetProperty("DoubleBuffered", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance)
                ?.SetValue(canvas, true, null);

            cboMode.DropDownStyle = ComboBoxStyle.DropDownList;
            cboMode.Items.Clear();
            cboMode.Items.AddRange(Enum.GetNames(typeof(DrawMode)));
            cboMode.SelectedIndex = 0;
            nudWidth.Value = 2;
            nudWidth.Minimum = 1;
            nudWidth.Maximum = 20;

            UpdateColorButtonImage(currentColor);
        }

        private void UpdateColorButtonImage(Color color)
        {
            Bitmap bmp = new Bitmap(36, 18);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                using (SolidBrush brush = new SolidBrush(color))
                {
                    g.FillRectangle(brush, 0, 0, bmp.Width, bmp.Height);
                }

                using (Pen pen = new Pen(Color.Gray, 1))
                {
                    g.DrawRectangle(pen, 0, 0, bmp.Width - 1, bmp.Height - 1);
                }
            }

            btnColor.Image = bmp;
            btnColor.ImageAlign = ContentAlignment.MiddleLeft;
            btnColor.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnColor.TextAlign = ContentAlignment.MiddleCenter;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (items.Count == 0 && bgImage == null)
            {
                MessageBox.Show("Chưa có nét vẽ hay ảnh nào trên vùng vẽ để lưu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "PNG Image (*.png)|*.png|JPEG Image (*.jpg;*.jpeg)|*.jpg;*.jpeg|Bitmap Image (*.bmp)|*.bmp";
            dialog.Title = "Lưu hình vẽ";
            dialog.DefaultExt = "png";
            dialog.FileName = "MyDrawing.png";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using Bitmap bmp = new Bitmap(canvas.Width, canvas.Height);
                    using (Graphics g = Graphics.FromImage(bmp))
                    {
                        RenderCanvas(g); // Gọi RenderCanvas để lưu cả Nền + Ảnh nền + Các nét vẽ
                    }

                    System.Drawing.Imaging.ImageFormat format = System.Drawing.Imaging.ImageFormat.Png;
                    string ext = System.IO.Path.GetExtension(dialog.FileName).ToLower();

                    if (ext == ".jpg" || ext == ".jpeg")
                        format = System.Drawing.Imaging.ImageFormat.Jpeg;
                    else if (ext == ".bmp")
                        format = System.Drawing.Imaging.ImageFormat.Bmp;

                    bmp.Save(dialog.FileName, format);

                    MessageBox.Show("Lưu hình vẽ thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi lưu file: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}