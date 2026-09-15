namespace Lab01
{
    partial class Form1
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
            lblTitle = new Label();
            txtHoTen = new TextBox();
            txtNamSinh = new TextBox();
            txtEmail = new TextBox();
            radGioiTinh = new GroupBox();
            radNu = new RadioButton();
            radNam = new RadioButton();
            cboKhoa = new ComboBox();
            btnHienThi = new Button();
            btnXoa = new Button();
            btnThoat = new Button();
            txtKetQua = new TextBox();
            lblHoTen = new Label();
            lblNamSinh = new Label();
            lblEmail = new Label();
            lblKhoa = new Label();
            radGioiTinh.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = SystemColors.MenuHighlight;
            lblTitle.Location = new Point(300, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(283, 38);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Thông Tin Sinh Viên";
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(205, 96);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(241, 34);
            txtHoTen.TabIndex = 1;
            // 
            // txtNamSinh
            // 
            txtNamSinh.Location = new Point(205, 148);
            txtNamSinh.Name = "txtNamSinh";
            txtNamSinh.Size = new Size(241, 34);
            txtNamSinh.TabIndex = 2;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(205, 193);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(241, 34);
            txtEmail.TabIndex = 3;
            // 
            // radGioiTinh
            // 
            radGioiTinh.Controls.Add(radNu);
            radGioiTinh.Controls.Add(radNam);
            radGioiTinh.Location = new Point(93, 313);
            radGioiTinh.Name = "radGioiTinh";
            radGioiTinh.Size = new Size(305, 81);
            radGioiTinh.TabIndex = 4;
            radGioiTinh.TabStop = false;
            radGioiTinh.Text = "Giới Tính";
            // 
            // radNu
            // 
            radNu.AutoSize = true;
            radNu.Location = new Point(175, 35);
            radNu.Name = "radNu";
            radNu.Size = new Size(64, 32);
            radNu.TabIndex = 1;
            radNu.TabStop = true;
            radNu.Text = "Nữ";
            radNu.UseVisualStyleBackColor = true;
            // 
            // radNam
            // 
            radNam.AutoSize = true;
            radNam.Location = new Point(44, 35);
            radNam.Name = "radNam";
            radNam.Size = new Size(79, 32);
            radNam.TabIndex = 0;
            radNam.TabStop = true;
            radNam.Text = "Nam";
            radNam.UseVisualStyleBackColor = true;
            // 
            // cboKhoa
            // 
            cboKhoa.FormattingEnabled = true;
            cboKhoa.Items.AddRange(new object[] { "Khoa Công Nghệ Thông Tin", "Khoa Toán-Tin", "Khoa Lịch Sử", "Khoa Tiếng Anh" });
            cboKhoa.Location = new Point(205, 251);
            cboKhoa.Name = "cboKhoa";
            cboKhoa.Size = new Size(241, 36);
            cboKhoa.TabIndex = 5;
            cboKhoa.SelectedIndexChanged += cboKhoa_SelectedIndexChanged;
            // 
            // btnHienThi
            // 
            btnHienThi.Location = new Point(93, 434);
            btnHienThi.Name = "btnHienThi";
            btnHienThi.Size = new Size(123, 38);
            btnHienThi.TabIndex = 6;
            btnHienThi.Text = "Hiển Thị";
            btnHienThi.UseVisualStyleBackColor = true;
            btnHienThi.Click += btnHienThi_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(268, 434);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(123, 38);
            btnXoa.TabIndex = 7;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(449, 434);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(123, 38);
            btnThoat.TabIndex = 8;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // txtKetQua
            // 
            txtKetQua.Location = new Point(503, 96);
            txtKetQua.Multiline = true;
            txtKetQua.Name = "txtKetQua";
            txtKetQua.ReadOnly = true;
            txtKetQua.ScrollBars = ScrollBars.Vertical;
            txtKetQua.Size = new Size(352, 298);
            txtKetQua.TabIndex = 9;
            // 
            // lblHoTen
            // 
            lblHoTen.AutoSize = true;
            lblHoTen.Location = new Point(93, 96);
            lblHoTen.Name = "lblHoTen";
            lblHoTen.Size = new Size(106, 28);
            lblHoTen.TabIndex = 10;
            lblHoTen.Text = "Họ và Tên: ";
            lblHoTen.Click += label1_Click;
            // 
            // lblNamSinh
            // 
            lblNamSinh.AutoSize = true;
            lblNamSinh.Location = new Point(93, 148);
            lblNamSinh.Name = "lblNamSinh";
            lblNamSinh.Size = new Size(101, 28);
            lblNamSinh.TabIndex = 11;
            lblNamSinh.Text = "Năm Sinh:";
            lblNamSinh.Click += label2_Click;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(93, 199);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(63, 28);
            lblEmail.TabIndex = 12;
            lblEmail.Text = "Email:";
            lblEmail.Click += lblEmail_Click;
            // 
            // lblKhoa
            // 
            lblKhoa.AutoSize = true;
            lblKhoa.Location = new Point(93, 251);
            lblKhoa.Name = "lblKhoa";
            lblKhoa.Size = new Size(102, 28);
            lblKhoa.TabIndex = 13;
            lblKhoa.Text = "Khoa/Lớp:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(880, 504);
            Controls.Add(lblKhoa);
            Controls.Add(lblEmail);
            Controls.Add(lblNamSinh);
            Controls.Add(lblHoTen);
            Controls.Add(txtKetQua);
            Controls.Add(btnThoat);
            Controls.Add(btnXoa);
            Controls.Add(btnHienThi);
            Controls.Add(cboKhoa);
            Controls.Add(radGioiTinh);
            Controls.Add(txtEmail);
            Controls.Add(txtNamSinh);
            Controls.Add(txtHoTen);
            Controls.Add(lblTitle);
            Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            radGioiTinh.ResumeLayout(false);
            radGioiTinh.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private TextBox txtHoTen;
        private TextBox txtNamSinh;
        private TextBox txtEmail;
        private GroupBox radGioiTinh;
        private RadioButton radNu;
        private RadioButton radNam;
        private ComboBox cboKhoa;
        private Button btnHienThi;
        private Button btnXoa;
        private Button btnThoat;
        private TextBox txtKetQua;
        private Label lblHoTen;
        private Label lblNamSinh;
        private Label lblEmail;
        private Label lblKhoa;
    }
}
