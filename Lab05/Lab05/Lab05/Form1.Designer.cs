namespace Lab05
{
    partial class dangKyKhoaHoc
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dangKyKhoaHoc));
            lblDangKyKhoaHoc = new Label();
            label1 = new Label();
            grpSinhVien = new GroupBox();
            chkNhanEmail = new CheckBox();
            dtpNgaySinh = new DateTimePicker();
            lblNgaySinh = new Label();
            txtSoDienThoai = new TextBox();
            txtHoTen = new TextBox();
            lblSoDienThoai = new Label();
            lblHoTen = new Label();
            grpKhoaHoc = new GroupBox();
            lblTongTien = new Label();
            lblTongHocPhi = new Label();
            numSoThang = new NumericUpDown();
            lblSoThangDangKy = new Label();
            radOffline = new RadioButton();
            radOnline = new RadioButton();
            cboKhoaHoc = new ComboBox();
            lblHinhThucHoc = new Label();
            lblKhoaHoc = new Label();
            btnDangKy = new Button();
            imageList1 = new ImageList(components);
            btnLamMoi = new Button();
            btnThoat = new Button();
            grpSinhVien.SuspendLayout();
            grpKhoaHoc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numSoThang).BeginInit();
            SuspendLayout();
            // 
            // lblDangKyKhoaHoc
            // 
            lblDangKyKhoaHoc.AutoSize = true;
            lblDangKyKhoaHoc.BackColor = Color.Transparent;
            lblDangKyKhoaHoc.Font = new Font("Arial", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDangKyKhoaHoc.ForeColor = Color.RoyalBlue;
            lblDangKyKhoaHoc.Location = new Point(304, 9);
            lblDangKyKhoaHoc.Name = "lblDangKyKhoaHoc";
            lblDangKyKhoaHoc.Size = new Size(300, 33);
            lblDangKyKhoaHoc.TabIndex = 0;
            lblDangKyKhoaHoc.Text = "ĐĂNG KÝ KHÓA HỌC";
            lblDangKyKhoaHoc.Click += lbldangKyKhoaHoc_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(169, 150);
            label1.Name = "label1";
            label1.Size = new Size(0, 25);
            label1.TabIndex = 1;
            // 
            // grpSinhVien
            // 
            grpSinhVien.BackColor = Color.Honeydew;
            grpSinhVien.Controls.Add(chkNhanEmail);
            grpSinhVien.Controls.Add(dtpNgaySinh);
            grpSinhVien.Controls.Add(lblNgaySinh);
            grpSinhVien.Controls.Add(txtSoDienThoai);
            grpSinhVien.Controls.Add(txtHoTen);
            grpSinhVien.Controls.Add(lblSoDienThoai);
            grpSinhVien.Controls.Add(lblHoTen);
            grpSinhVien.Font = new Font("Arial", 9F);
            grpSinhVien.Location = new Point(54, 67);
            grpSinhVien.Name = "grpSinhVien";
            grpSinhVien.Size = new Size(346, 319);
            grpSinhVien.TabIndex = 2;
            grpSinhVien.TabStop = false;
            grpSinhVien.Text = "Thông tin sinh viên";
            // 
            // chkNhanEmail
            // 
            chkNhanEmail.AutoSize = true;
            chkNhanEmail.Location = new Point(68, 263);
            chkNhanEmail.Name = "chkNhanEmail";
            chkNhanEmail.Size = new Size(211, 25);
            chkNhanEmail.TabIndex = 7;
            chkNhanEmail.Text = "Nhận email thông báo";
            chkNhanEmail.UseVisualStyleBackColor = true;
            chkNhanEmail.CheckedChanged += chkNhanEmail_CheckedChanged;
            // 
            // dtpNgaySinh
            // 
            dtpNgaySinh.Format = DateTimePickerFormat.Short;
            dtpNgaySinh.Location = new Point(129, 195);
            dtpNgaySinh.Name = "dtpNgaySinh";
            dtpNgaySinh.Size = new Size(168, 28);
            dtpNgaySinh.TabIndex = 6;
            // 
            // lblNgaySinh
            // 
            lblNgaySinh.AutoSize = true;
            lblNgaySinh.Location = new Point(6, 201);
            lblNgaySinh.Name = "lblNgaySinh";
            lblNgaySinh.Size = new Size(95, 21);
            lblNgaySinh.TabIndex = 4;
            lblNgaySinh.Text = "Ngày sinh:";
            lblNgaySinh.Click += label2_Click;
            // 
            // txtSoDienThoai
            // 
            txtSoDienThoai.Location = new Point(129, 134);
            txtSoDienThoai.MaxLength = 10;
            txtSoDienThoai.Name = "txtSoDienThoai";
            txtSoDienThoai.Size = new Size(195, 28);
            txtSoDienThoai.TabIndex = 3;
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(129, 76);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(195, 28);
            txtHoTen.TabIndex = 2;
            txtHoTen.TextChanged += textBox1_TextChanged;
            // 
            // lblSoDienThoai
            // 
            lblSoDienThoai.AutoSize = true;
            lblSoDienThoai.Location = new Point(0, 141);
            lblSoDienThoai.Name = "lblSoDienThoai";
            lblSoDienThoai.Size = new Size(120, 21);
            lblSoDienThoai.TabIndex = 1;
            lblSoDienThoai.Text = "Số điện thoại:";
            // 
            // lblHoTen
            // 
            lblHoTen.AutoSize = true;
            lblHoTen.Location = new Point(6, 83);
            lblHoTen.Name = "lblHoTen";
            lblHoTen.Size = new Size(92, 21);
            lblHoTen.TabIndex = 0;
            lblHoTen.Text = "Họ và tên:";
            // 
            // grpKhoaHoc
            // 
            grpKhoaHoc.BackColor = Color.Honeydew;
            grpKhoaHoc.Controls.Add(lblTongTien);
            grpKhoaHoc.Controls.Add(lblTongHocPhi);
            grpKhoaHoc.Controls.Add(numSoThang);
            grpKhoaHoc.Controls.Add(lblSoThangDangKy);
            grpKhoaHoc.Controls.Add(radOffline);
            grpKhoaHoc.Controls.Add(radOnline);
            grpKhoaHoc.Controls.Add(cboKhoaHoc);
            grpKhoaHoc.Controls.Add(lblHinhThucHoc);
            grpKhoaHoc.Controls.Add(lblKhoaHoc);
            grpKhoaHoc.Font = new Font("Arial", 9F);
            grpKhoaHoc.Location = new Point(512, 67);
            grpKhoaHoc.Name = "grpKhoaHoc";
            grpKhoaHoc.Size = new Size(366, 319);
            grpKhoaHoc.TabIndex = 3;
            grpKhoaHoc.TabStop = false;
            grpKhoaHoc.Text = "Thông tin khóa học";
            grpKhoaHoc.Enter += grpKhoaHoc_Enter;
            // 
            // lblTongTien
            // 
            lblTongTien.AutoSize = true;
            lblTongTien.BackColor = Color.Cyan;
            lblTongTien.BorderStyle = BorderStyle.FixedSingle;
            lblTongTien.ForeColor = Color.MidnightBlue;
            lblTongTien.Location = new Point(140, 250);
            lblTongTien.Name = "lblTongTien";
            lblTongTien.Size = new Size(134, 23);
            lblTongTien.TabIndex = 10;
            lblTongTien.Text = "2,400,000 VNĐ";
            lblTongTien.TextAlign = ContentAlignment.MiddleCenter;
            lblTongTien.Click += lblTongTien_Click;
            // 
            // lblTongHocPhi
            // 
            lblTongHocPhi.AutoSize = true;
            lblTongHocPhi.Location = new Point(6, 250);
            lblTongHocPhi.Name = "lblTongHocPhi";
            lblTongHocPhi.Size = new Size(121, 21);
            lblTongHocPhi.TabIndex = 9;
            lblTongHocPhi.Text = "Tổng học phí:";
            lblTongHocPhi.Click += lblTongHocPhi_Click;
            // 
            // numSoThang
            // 
            numSoThang.Location = new Point(167, 199);
            numSoThang.Maximum = new decimal(new int[] { 12, 0, 0, 0 });
            numSoThang.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numSoThang.Name = "numSoThang";
            numSoThang.Size = new Size(60, 28);
            numSoThang.TabIndex = 8;
            numSoThang.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numSoThang.ValueChanged += numSoThang_ValueChanged;
            // 
            // lblSoThangDangKy
            // 
            lblSoThangDangKy.AutoSize = true;
            lblSoThangDangKy.Location = new Point(6, 201);
            lblSoThangDangKy.Name = "lblSoThangDangKy";
            lblSoThangDangKy.Size = new Size(155, 21);
            lblSoThangDangKy.TabIndex = 7;
            lblSoThangDangKy.Text = "Số tháng đăng ký:";
            // 
            // radOffline
            // 
            radOffline.AutoSize = true;
            radOffline.Location = new Point(233, 141);
            radOffline.Name = "radOffline";
            radOffline.Size = new Size(107, 25);
            radOffline.TabIndex = 6;
            radOffline.Text = "Trực tiếp";
            radOffline.UseVisualStyleBackColor = true;
            // 
            // radOnline
            // 
            radOnline.AutoSize = true;
            radOnline.Checked = true;
            radOnline.Location = new Point(140, 141);
            radOnline.Name = "radOnline";
            radOnline.Size = new Size(87, 25);
            radOnline.TabIndex = 5;
            radOnline.TabStop = true;
            radOnline.Text = "Online";
            radOnline.UseVisualStyleBackColor = true;
            // 
            // cboKhoaHoc
            // 
            cboKhoaHoc.FormattingEnabled = true;
            cboKhoaHoc.Location = new Point(122, 75);
            cboKhoaHoc.Name = "cboKhoaHoc";
            cboKhoaHoc.Size = new Size(218, 29);
            cboKhoaHoc.TabIndex = 4;
            cboKhoaHoc.SelectedIndexChanged += cboKhoaHoc_SelectedIndexChanged;
            // 
            // lblHinhThucHoc
            // 
            lblHinhThucHoc.AutoSize = true;
            lblHinhThucHoc.Location = new Point(6, 141);
            lblHinhThucHoc.Name = "lblHinhThucHoc";
            lblHinhThucHoc.Size = new Size(128, 21);
            lblHinhThucHoc.TabIndex = 2;
            lblHinhThucHoc.Text = "Hình thức học:";
            lblHinhThucHoc.Click += label4_Click;
            // 
            // lblKhoaHoc
            // 
            lblKhoaHoc.AutoSize = true;
            lblKhoaHoc.Location = new Point(6, 83);
            lblKhoaHoc.Name = "lblKhoaHoc";
            lblKhoaHoc.Size = new Size(91, 21);
            lblKhoaHoc.TabIndex = 3;
            lblKhoaHoc.Text = "Khóa học:";
            // 
            // btnDangKy
            // 
            btnDangKy.BackColor = Color.Khaki;
            btnDangKy.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDangKy.ForeColor = Color.Black;
            btnDangKy.ImageAlign = ContentAlignment.MiddleLeft;
            btnDangKy.ImageIndex = 0;
            btnDangKy.ImageList = imageList1;
            btnDangKy.Location = new Point(169, 408);
            btnDangKy.Name = "btnDangKy";
            btnDangKy.Size = new Size(143, 47);
            btnDangKy.TabIndex = 4;
            btnDangKy.Text = "Đăng Ký";
            btnDangKy.UseVisualStyleBackColor = false;
            btnDangKy.Click += btnDangKy_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "Sub.png");
            imageList1.Images.SetKeyName(1, "reload.png");
            imageList1.Images.SetKeyName(2, "exit.png");
            // 
            // btnLamMoi
            // 
            btnLamMoi.BackColor = Color.OldLace;
            btnLamMoi.Font = new Font("Arial", 9F);
            btnLamMoi.ImageAlign = ContentAlignment.MiddleLeft;
            btnLamMoi.ImageIndex = 1;
            btnLamMoi.ImageList = imageList1;
            btnLamMoi.Location = new Point(386, 408);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(143, 47);
            btnLamMoi.TabIndex = 5;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = false;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.Azure;
            btnThoat.Font = new Font("Arial", 9F);
            btnThoat.ImageAlign = ContentAlignment.MiddleLeft;
            btnThoat.ImageIndex = 2;
            btnThoat.ImageList = imageList1;
            btnThoat.Location = new Point(596, 408);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(143, 47);
            btnThoat.TabIndex = 6;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // dangKyKhoaHoc
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(927, 474);
            Controls.Add(btnThoat);
            Controls.Add(btnLamMoi);
            Controls.Add(btnDangKy);
            Controls.Add(grpKhoaHoc);
            Controls.Add(grpSinhVien);
            Controls.Add(label1);
            Controls.Add(lblDangKyKhoaHoc);
            Name = "dangKyKhoaHoc";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CourseRegistrationApp";
            Load += dangKyKhoaHoc_Load;
            Paint += grpHocVien_Paint;
            grpSinhVien.ResumeLayout(false);
            grpSinhVien.PerformLayout();
            grpKhoaHoc.ResumeLayout(false);
            grpKhoaHoc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numSoThang).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDangKyKhoaHoc;
        private Label label1;
        private GroupBox grpSinhVien;
        private GroupBox grpKhoaHoc;
        private Label lblSoDienThoai;
        private Label lblHoTen;
        private Label lblHinhThucHoc;
        private Label lblKhoaHoc;
        private TextBox txtSoDienThoai;
        private TextBox txtHoTen;
        private Label lblNgaySinh;
        private DateTimePicker dtpNgaySinh;
        private CheckBox chkNhanEmail;
        private ComboBox cboKhoaHoc;
        private RadioButton radOffline;
        private RadioButton radOnline;
        private Label lblTongTien;
        private Label lblTongHocPhi;
        private NumericUpDown numSoThang;
        private Label lblSoThangDangKy;
        private Button btnDangKy;
        private Button btnLamMoi;
        private Button btnThoat;
        private ImageList imageList1;
    }
}
