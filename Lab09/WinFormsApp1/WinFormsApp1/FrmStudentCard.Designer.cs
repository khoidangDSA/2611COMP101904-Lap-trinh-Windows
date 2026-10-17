namespace WinFormsApp1
{
    partial class FrmStudentCard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmStudentCard));
            grbThongTinSV = new GroupBox();
            cboKhoa = new ComboBox();
            radNam = new RadioButton();
            radKhac = new RadioButton();
            radNu = new RadioButton();
            dtpNgaySinh = new DateTimePicker();
            cboKhoaHoc = new ComboBox();
            cboLop = new ComboBox();
            txtHoTen = new TextBox();
            txtMaSV = new TextBox();
            lblGioiTinh = new Label();
            lblKhoaHoc = new Label();
            lblKhoa = new Label();
            lblLop = new Label();
            lblNgaySinh = new Label();
            lblHoTen = new Label();
            lblMaSV = new Label();
            lblAnhDaiDien = new Label();
            grpAnhDaiDien = new GroupBox();
            picAnh = new PictureBox();
            btnChonAnh = new Button();
            pnlXemTruocThe = new Panel();
            btnLamMoi = new Button();
            btnIn = new Button();
            btnXemTruocIn = new Button();
            btnThoat = new Button();
            openFileDialog1 = new OpenFileDialog();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            printPreviewDialog1 = new PrintPreviewDialog();
            printDialog1 = new PrintDialog();
            grbThongTinSV.SuspendLayout();
            grpAnhDaiDien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picAnh).BeginInit();
            SuspendLayout();
            // 
            // grbThongTinSV
            // 
            grbThongTinSV.BackColor = SystemColors.GradientActiveCaption;
            grbThongTinSV.Controls.Add(cboKhoa);
            grbThongTinSV.Controls.Add(radNam);
            grbThongTinSV.Controls.Add(radKhac);
            grbThongTinSV.Controls.Add(radNu);
            grbThongTinSV.Controls.Add(dtpNgaySinh);
            grbThongTinSV.Controls.Add(cboKhoaHoc);
            grbThongTinSV.Controls.Add(cboLop);
            grbThongTinSV.Controls.Add(txtHoTen);
            grbThongTinSV.Controls.Add(txtMaSV);
            grbThongTinSV.Controls.Add(lblGioiTinh);
            grbThongTinSV.Controls.Add(lblKhoaHoc);
            grbThongTinSV.Controls.Add(lblKhoa);
            grbThongTinSV.Controls.Add(lblLop);
            grbThongTinSV.Controls.Add(lblNgaySinh);
            grbThongTinSV.Controls.Add(lblHoTen);
            grbThongTinSV.Controls.Add(lblMaSV);
            grbThongTinSV.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grbThongTinSV.Location = new Point(53, 71);
            grbThongTinSV.Name = "grbThongTinSV";
            grbThongTinSV.Size = new Size(442, 389);
            grbThongTinSV.TabIndex = 0;
            grbThongTinSV.TabStop = false;
            grbThongTinSV.Text = "Thông tin sinh viên";
            // 
            // cboKhoa
            // 
            cboKhoa.FormattingEnabled = true;
            cboKhoa.Location = new Point(159, 182);
            cboKhoa.Name = "cboKhoa";
            cboKhoa.Size = new Size(205, 33);
            cboKhoa.TabIndex = 18;
            // 
            // radNam
            // 
            radNam.AutoSize = true;
            radNam.Location = new Point(154, 336);
            radNam.Name = "radNam";
            radNam.Size = new Size(75, 29);
            radNam.TabIndex = 17;
            radNam.TabStop = true;
            radNam.Text = "Nam";
            radNam.UseVisualStyleBackColor = true;
            // 
            // radKhac
            // 
            radKhac.AutoSize = true;
            radKhac.Location = new Point(302, 336);
            radKhac.Name = "radKhac";
            radKhac.Size = new Size(74, 29);
            radKhac.TabIndex = 16;
            radKhac.TabStop = true;
            radKhac.Text = "Khác";
            radKhac.UseVisualStyleBackColor = true;
            // 
            // radNu
            // 
            radNu.AutoSize = true;
            radNu.Location = new Point(235, 336);
            radNu.Name = "radNu";
            radNu.Size = new Size(61, 29);
            radNu.TabIndex = 15;
            radNu.TabStop = true;
            radNu.Text = "Nữ";
            radNu.UseVisualStyleBackColor = true;
            // 
            // dtpNgaySinh
            // 
            dtpNgaySinh.Format = DateTimePickerFormat.Short;
            dtpNgaySinh.Location = new Point(159, 279);
            dtpNgaySinh.Name = "dtpNgaySinh";
            dtpNgaySinh.Size = new Size(147, 31);
            dtpNgaySinh.TabIndex = 14;
            // 
            // cboKhoaHoc
            // 
            cboKhoaHoc.FormattingEnabled = true;
            cboKhoaHoc.Location = new Point(159, 230);
            cboKhoaHoc.Name = "cboKhoaHoc";
            cboKhoaHoc.Size = new Size(101, 33);
            cboKhoaHoc.TabIndex = 13;
            // 
            // cboLop
            // 
            cboLop.FormattingEnabled = true;
            cboLop.Location = new Point(159, 138);
            cboLop.Name = "cboLop";
            cboLop.Size = new Size(205, 33);
            cboLop.TabIndex = 12;
            cboLop.SelectedIndexChanged += cboLop_SelectedIndexChanged;
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(159, 90);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(205, 31);
            txtHoTen.TabIndex = 9;
            // 
            // txtMaSV
            // 
            txtMaSV.Location = new Point(159, 43);
            txtMaSV.Name = "txtMaSV";
            txtMaSV.Size = new Size(205, 31);
            txtMaSV.TabIndex = 8;
            // 
            // lblGioiTinh
            // 
            lblGioiTinh.AutoSize = true;
            lblGioiTinh.Location = new Point(25, 333);
            lblGioiTinh.Name = "lblGioiTinh";
            lblGioiTinh.Size = new Size(82, 25);
            lblGioiTinh.TabIndex = 7;
            lblGioiTinh.Text = "Giới tính:";
            // 
            // lblKhoaHoc
            // 
            lblKhoaHoc.AutoSize = true;
            lblKhoaHoc.Location = new Point(25, 233);
            lblKhoaHoc.Name = "lblKhoaHoc";
            lblKhoaHoc.Size = new Size(90, 25);
            lblKhoaHoc.TabIndex = 6;
            lblKhoaHoc.Text = "Khóa học:";
            // 
            // lblKhoa
            // 
            lblKhoa.AutoSize = true;
            lblKhoa.Location = new Point(25, 185);
            lblKhoa.Name = "lblKhoa";
            lblKhoa.Size = new Size(56, 25);
            lblKhoa.TabIndex = 4;
            lblKhoa.Text = "Khoa:";
            // 
            // lblLop
            // 
            lblLop.AutoSize = true;
            lblLop.Location = new Point(25, 141);
            lblLop.Name = "lblLop";
            lblLop.Size = new Size(46, 25);
            lblLop.TabIndex = 3;
            lblLop.Text = "Lớp:";
            // 
            // lblNgaySinh
            // 
            lblNgaySinh.AutoSize = true;
            lblNgaySinh.Location = new Point(25, 284);
            lblNgaySinh.Name = "lblNgaySinh";
            lblNgaySinh.Size = new Size(95, 25);
            lblNgaySinh.TabIndex = 2;
            lblNgaySinh.Text = "Ngày sinh:";
            // 
            // lblHoTen
            // 
            lblHoTen.AutoSize = true;
            lblHoTen.Location = new Point(25, 93);
            lblHoTen.Name = "lblHoTen";
            lblHoTen.Size = new Size(70, 25);
            lblHoTen.TabIndex = 1;
            lblHoTen.Text = "Họ tên:";
            // 
            // lblMaSV
            // 
            lblMaSV.AutoSize = true;
            lblMaSV.Location = new Point(25, 46);
            lblMaSV.Name = "lblMaSV";
            lblMaSV.Size = new Size(115, 25);
            lblMaSV.TabIndex = 0;
            lblMaSV.Text = "Mã sinh viên:";
            // 
            // lblAnhDaiDien
            // 
            lblAnhDaiDien.AutoSize = true;
            lblAnhDaiDien.Location = new Point(495, 479);
            lblAnhDaiDien.Name = "lblAnhDaiDien";
            lblAnhDaiDien.Size = new Size(0, 25);
            lblAnhDaiDien.TabIndex = 5;
            // 
            // grpAnhDaiDien
            // 
            grpAnhDaiDien.BackColor = SystemColors.GradientActiveCaption;
            grpAnhDaiDien.Controls.Add(picAnh);
            grpAnhDaiDien.Controls.Add(btnChonAnh);
            grpAnhDaiDien.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grpAnhDaiDien.Location = new Point(53, 479);
            grpAnhDaiDien.Name = "grpAnhDaiDien";
            grpAnhDaiDien.Size = new Size(442, 237);
            grpAnhDaiDien.TabIndex = 6;
            grpAnhDaiDien.TabStop = false;
            grpAnhDaiDien.Text = "Ảnh đại diện";
            // 
            // picAnh
            // 
            picAnh.BackColor = Color.White;
            picAnh.Location = new Point(25, 39);
            picAnh.Name = "picAnh";
            picAnh.Size = new Size(150, 181);
            picAnh.TabIndex = 1;
            picAnh.TabStop = false;
            // 
            // btnChonAnh
            // 
            btnChonAnh.Location = new Point(252, 95);
            btnChonAnh.Name = "btnChonAnh";
            btnChonAnh.Size = new Size(112, 59);
            btnChonAnh.TabIndex = 0;
            btnChonAnh.Text = "Chọn ảnh";
            btnChonAnh.UseVisualStyleBackColor = true;
            btnChonAnh.Click += btnChonAnh_Click;
            // 
            // pnlXemTruocThe
            // 
            pnlXemTruocThe.BackColor = Color.Lavender;
            pnlXemTruocThe.Location = new Point(544, 71);
            pnlXemTruocThe.Name = "pnlXemTruocThe";
            pnlXemTruocThe.Size = new Size(605, 389);
            pnlXemTruocThe.TabIndex = 7;
            pnlXemTruocThe.Paint += pnlXemTruocThe_Paint;
            // 
            // btnLamMoi
            // 
            btnLamMoi.BackColor = Color.DodgerBlue;
            btnLamMoi.FlatStyle = FlatStyle.Popup;
            btnLamMoi.Location = new Point(544, 518);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(124, 67);
            btnLamMoi.TabIndex = 8;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = false;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // btnIn
            // 
            btnIn.BackColor = Color.Thistle;
            btnIn.FlatStyle = FlatStyle.Popup;
            btnIn.Location = new Point(736, 518);
            btnIn.Name = "btnIn";
            btnIn.Size = new Size(124, 67);
            btnIn.TabIndex = 9;
            btnIn.Text = "In";
            btnIn.UseVisualStyleBackColor = false;
            btnIn.Click += btnIn_Click;
            // 
            // btnXemTruocIn
            // 
            btnXemTruocIn.BackColor = Color.FromArgb(192, 192, 255);
            btnXemTruocIn.FlatStyle = FlatStyle.Popup;
            btnXemTruocIn.Location = new Point(544, 632);
            btnXemTruocIn.Name = "btnXemTruocIn";
            btnXemTruocIn.Size = new Size(124, 67);
            btnXemTruocIn.TabIndex = 10;
            btnXemTruocIn.Text = "Xem trước in";
            btnXemTruocIn.UseVisualStyleBackColor = false;
            btnXemTruocIn.Click += btnXemTruocIn_Click;
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.FromArgb(192, 255, 192);
            btnThoat.FlatStyle = FlatStyle.Popup;
            btnThoat.Location = new Point(736, 632);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(124, 67);
            btnThoat.TabIndex = 11;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            // 
            // printDialog1
            // 
            printDialog1.UseEXDialog = true;
            // 
            // FrmStudentCard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(1177, 830);
            Controls.Add(btnThoat);
            Controls.Add(btnXemTruocIn);
            Controls.Add(btnIn);
            Controls.Add(btnLamMoi);
            Controls.Add(pnlXemTruocThe);
            Controls.Add(grpAnhDaiDien);
            Controls.Add(grbThongTinSV);
            Controls.Add(lblAnhDaiDien);
            ForeColor = SystemColors.ActiveCaptionText;
            Name = "FrmStudentCard";
            Text = "FrmStudentCard";
            grbThongTinSV.ResumeLayout(false);
            grbThongTinSV.PerformLayout();
            grpAnhDaiDien.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picAnh).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grbThongTinSV;
        private Label lblKhoaHoc;
        private Label lblAnhDaiDien;
        private Label lblKhoa;
        private Label lblLop;
        private Label lblNgaySinh;
        private Label lblHoTen;
        private Label lblMaSV;
        private Label lblGioiTinh;
        private GroupBox grpAnhDaiDien;
        private PictureBox picAnh;
        private Button btnChonAnh;
        private RadioButton radNam;
        private RadioButton radKhac;
        private RadioButton radNu;
        private DateTimePicker dtpNgaySinh;
        private ComboBox cboKhoaHoc;
        private ComboBox cboLop;
        private TextBox txtHoTen;
        private TextBox txtMaSV;
        private ComboBox cboKhoa;
        private Panel pnlXemTruocThe;
        private Button btnLamMoi;
        private Button btnIn;
        private Button btnXemTruocIn;
        private Button btnThoat;
        private OpenFileDialog openFileDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private PrintPreviewDialog printPreviewDialog1;
        private PrintDialog printDialog1;
    }
}