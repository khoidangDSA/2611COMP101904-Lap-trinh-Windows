namespace ShopManagerMini.Forms
{
    partial class FrmAbout
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
            lblUngDung = new Label();
            label1 = new Label();
            grbThongTin = new GroupBox();
            lblNameApp = new Label();
            lblDescribe = new Label();
            lblMoTa = new Label();
            lblTenUngDung = new Label();
            lblGioiThieu = new Label();
            lblLop = new Label();
            lblTenSV = new Label();
            groupBox1 = new GroupBox();
            lblClass = new Label();
            lblNameStu = new Label();
            btnExit = new Button();
            grbThongTin.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // lblUngDung
            // 
            lblUngDung.AutoSize = true;
            lblUngDung.Location = new Point(67, 86);
            lblUngDung.Name = "lblUngDung";
            lblUngDung.Size = new Size(0, 25);
            lblUngDung.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(202, 164);
            label1.Name = "label1";
            label1.Size = new Size(59, 25);
            label1.TabIndex = 3;
            label1.Text = "label1";
            // 
            // grbThongTin
            // 
            grbThongTin.BackColor = Color.SkyBlue;
            grbThongTin.Controls.Add(lblNameApp);
            grbThongTin.Controls.Add(lblDescribe);
            grbThongTin.Controls.Add(lblMoTa);
            grbThongTin.Controls.Add(lblTenUngDung);
            grbThongTin.Location = new Point(33, 99);
            grbThongTin.Name = "grbThongTin";
            grbThongTin.Size = new Size(392, 318);
            grbThongTin.TabIndex = 4;
            grbThongTin.TabStop = false;
            grbThongTin.Text = "Thông tin ứng dụng";
            // 
            // lblNameApp
            // 
            lblNameApp.AutoSize = true;
            lblNameApp.Location = new Point(147, 76);
            lblNameApp.Name = "lblNameApp";
            lblNameApp.Size = new Size(158, 25);
            lblNameApp.TabIndex = 7;
            lblNameApp.Text = "ShopManagerMini";
            lblNameApp.Click += label3_Click_1;
            // 
            // lblDescribe
            // 
            lblDescribe.Location = new Point(147, 164);
            lblDescribe.Name = "lblDescribe";
            lblDescribe.Size = new Size(245, 114);
            lblDescribe.TabIndex = 5;
            lblDescribe.Text = "Ứng dụng quản lý sản phẩm và khách hàng dành cho cửa hàng mini, phát triển trên nền nền tảng C# WinForms.";
            lblDescribe.Click += label3_Click;
            // 
            // lblMoTa
            // 
            lblMoTa.AutoSize = true;
            lblMoTa.Location = new Point(15, 164);
            lblMoTa.Name = "lblMoTa";
            lblMoTa.Size = new Size(108, 25);
            lblMoTa.TabIndex = 1;
            lblMoTa.Text = "Mô tả ngắn:";
            // 
            // lblTenUngDung
            // 
            lblTenUngDung.AutoSize = true;
            lblTenUngDung.Location = new Point(15, 76);
            lblTenUngDung.Name = "lblTenUngDung";
            lblTenUngDung.Size = new Size(126, 25);
            lblTenUngDung.TabIndex = 0;
            lblTenUngDung.Text = "Tên ứng dụng:";
            // 
            // lblGioiThieu
            // 
            lblGioiThieu.AutoSize = true;
            lblGioiThieu.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGioiThieu.Location = new Point(319, 28);
            lblGioiThieu.Name = "lblGioiThieu";
            lblGioiThieu.Size = new Size(283, 32);
            lblGioiThieu.TabIndex = 6;
            lblGioiThieu.Text = "GIỚI THIỆU ỨNG DỤNG";
            lblGioiThieu.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblLop
            // 
            lblLop.AutoSize = true;
            lblLop.Location = new Point(21, 164);
            lblLop.Name = "lblLop";
            lblLop.Size = new Size(125, 25);
            lblLop.TabIndex = 2;
            lblLop.Text = "Lớp học phần:";
            // 
            // lblTenSV
            // 
            lblTenSV.AutoSize = true;
            lblTenSV.Location = new Point(21, 76);
            lblTenSV.Name = "lblTenSV";
            lblTenSV.Size = new Size(120, 25);
            lblTenSV.TabIndex = 1;
            lblTenSV.Text = "Tên Sinh Viên:";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Turquoise;
            groupBox1.Controls.Add(lblClass);
            groupBox1.Controls.Add(lblNameStu);
            groupBox1.Controls.Add(lblTenSV);
            groupBox1.Controls.Add(lblLop);
            groupBox1.Location = new Point(472, 99);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(392, 318);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin sinh viên";
            // 
            // lblClass
            // 
            lblClass.Location = new Point(147, 164);
            lblClass.Name = "lblClass";
            lblClass.Size = new Size(239, 114);
            lblClass.TabIndex = 6;
            lblClass.Text = "COMP1019 - Lập trình trên Windows";
            // 
            // lblNameStu
            // 
            lblNameStu.AutoSize = true;
            lblNameStu.Location = new Point(147, 76);
            lblNameStu.Name = "lblNameStu";
            lblNameStu.Size = new Size(162, 25);
            lblNameStu.TabIndex = 5;
            lblNameStu.Text = "Đặng Nguyên Khôi";
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Ivory;
            btnExit.FlatStyle = FlatStyle.Popup;
            btnExit.Location = new Point(351, 448);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(188, 58);
            btnExit.TabIndex = 7;
            btnExit.Text = "Đóng";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // FrmAbout
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            ClientSize = new Size(887, 518);
            Controls.Add(btnExit);
            Controls.Add(lblGioiThieu);
            Controls.Add(groupBox1);
            Controls.Add(grbThongTin);
            Controls.Add(label1);
            Controls.Add(lblUngDung);
            Name = "FrmAbout";
            Text = "About ";
            grbThongTin.ResumeLayout(false);
            grbThongTin.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUngDung;
        private Label label1;
        private GroupBox grbThongTin;
        private Label lblMoTa;
        private Label lblTenUngDung;
        private TextBox textBox4;
        private Label lblGioiThieu;
        private Label label2;
        private Label lblDescribe;
        private Label lblLop;
        private Label lblTenSV;
        private GroupBox groupBox1;
        private Label lblClass;
        private Label lblNameStu;
        private Button btnExit;
        private Label lblNameApp;
    }
}