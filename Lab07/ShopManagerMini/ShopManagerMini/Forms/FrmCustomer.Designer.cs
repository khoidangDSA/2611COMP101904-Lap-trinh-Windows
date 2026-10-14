namespace ShopManagerMini.Forms
{
    partial class FrmCustomer
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
            lblQuanLyKH = new Label();
            grbKH = new GroupBox();
            lblLoaiKH = new Label();
            cboLoaiKH = new ComboBox();
            lblSDT = new Label();
            lblMaKH = new Label();
            lblTenKH = new Label();
            txtSDT = new TextBox();
            txtTenKH = new TextBox();
            txtMaKH = new TextBox();
            btnThem = new Button();
            btnSua = new Button();
            button3 = new Button();
            button4 = new Button();
            dgvKhachHang = new DataGridView();
            grbKH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKhachHang).BeginInit();
            SuspendLayout();
            // 
            // lblQuanLyKH
            // 
            lblQuanLyKH.AutoSize = true;
            lblQuanLyKH.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblQuanLyKH.ForeColor = Color.Navy;
            lblQuanLyKH.Location = new Point(575, 33);
            lblQuanLyKH.Name = "lblQuanLyKH";
            lblQuanLyKH.Size = new Size(385, 45);
            lblQuanLyKH.TabIndex = 2;
            lblQuanLyKH.Text = "QUẢN LÝ KHÁCH HÀNG";
            // 
            // grbKH
            // 
            grbKH.BackColor = Color.Cyan;
            grbKH.Controls.Add(lblLoaiKH);
            grbKH.Controls.Add(cboLoaiKH);
            grbKH.Controls.Add(lblSDT);
            grbKH.Controls.Add(lblMaKH);
            grbKH.Controls.Add(lblTenKH);
            grbKH.Controls.Add(txtSDT);
            grbKH.Controls.Add(txtTenKH);
            grbKH.Controls.Add(txtMaKH);
            grbKH.Location = new Point(44, 161);
            grbKH.Name = "grbKH";
            grbKH.Size = new Size(462, 346);
            grbKH.TabIndex = 3;
            grbKH.TabStop = false;
            grbKH.Text = "Thông tin khách hàng";
            // 
            // lblLoaiKH
            // 
            lblLoaiKH.AutoSize = true;
            lblLoaiKH.Location = new Point(18, 239);
            lblLoaiKH.Name = "lblLoaiKH";
            lblLoaiKH.Size = new Size(144, 25);
            lblLoaiKH.TabIndex = 7;
            lblLoaiKH.Text = "Loại khách hàng:";
            // 
            // cboLoaiKH
            // 
            cboLoaiKH.FormattingEnabled = true;
            cboLoaiKH.Location = new Point(175, 239);
            cboLoaiKH.Name = "cboLoaiKH";
            cboLoaiKH.Size = new Size(236, 33);
            cboLoaiKH.TabIndex = 6;
            // 
            // lblSDT
            // 
            lblSDT.AutoSize = true;
            lblSDT.Location = new Point(18, 178);
            lblSDT.Name = "lblSDT";
            lblSDT.Size = new Size(121, 25);
            lblSDT.TabIndex = 5;
            lblSDT.Text = "Số điện thoại:";
            // 
            // lblMaKH
            // 
            lblMaKH.AutoSize = true;
            lblMaKH.Location = new Point(18, 57);
            lblMaKH.Name = "lblMaKH";
            lblMaKH.Size = new Size(137, 25);
            lblMaKH.TabIndex = 4;
            lblMaKH.Text = "Mã khách hàng:";
            // 
            // lblTenKH
            // 
            lblTenKH.AutoSize = true;
            lblTenKH.Location = new Point(18, 115);
            lblTenKH.Name = "lblTenKH";
            lblTenKH.Size = new Size(138, 25);
            lblTenKH.TabIndex = 3;
            lblTenKH.Text = "Tên khách hàng:";
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(175, 178);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(236, 31);
            txtSDT.TabIndex = 2;
            // 
            // txtTenKH
            // 
            txtTenKH.Location = new Point(175, 115);
            txtTenKH.Name = "txtTenKH";
            txtTenKH.Size = new Size(236, 31);
            txtTenKH.TabIndex = 1;
            // 
            // txtMaKH
            // 
            txtMaKH.Location = new Point(175, 54);
            txtMaKH.Name = "txtMaKH";
            txtMaKH.Size = new Size(236, 31);
            txtMaKH.TabIndex = 0;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.LightCoral;
            btnThem.FlatStyle = FlatStyle.Popup;
            btnThem.ForeColor = Color.White;
            btnThem.Location = new Point(559, 161);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(120, 54);
            btnThem.TabIndex = 4;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.LightGreen;
            btnSua.FlatStyle = FlatStyle.Popup;
            btnSua.Location = new Point(559, 261);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(120, 54);
            btnSua.TabIndex = 5;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.DarkGray;
            button3.FlatStyle = FlatStyle.Popup;
            button3.ForeColor = Color.White;
            button3.Location = new Point(559, 360);
            button3.Name = "button3";
            button3.Size = new Size(120, 54);
            button3.TabIndex = 6;
            button3.Text = "Xóa";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Azure;
            button4.FlatStyle = FlatStyle.Popup;
            button4.Location = new Point(559, 453);
            button4.Name = "button4";
            button4.Size = new Size(120, 54);
            button4.TabIndex = 7;
            button4.Text = "Làm Mới";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // dgvKhachHang
            // 
            dgvKhachHang.BackgroundColor = SystemColors.ActiveCaption;
            dgvKhachHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKhachHang.Location = new Point(749, 161);
            dgvKhachHang.Name = "dgvKhachHang";
            dgvKhachHang.RowHeadersWidth = 62;
            dgvKhachHang.Size = new Size(692, 346);
            dgvKhachHang.TabIndex = 8;
            dgvKhachHang.CellClick += dgvKhachHang_CellClick;
            dgvKhachHang.CellContentClick += dgvKhachHang_CellContentClick;
            // 
            // FrmCustomer
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 192);
            ClientSize = new Size(1488, 567);
            Controls.Add(dgvKhachHang);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(grbKH);
            Controls.Add(lblQuanLyKH);
            Name = "FrmCustomer";
            Text = "Customer";
            Load += FrmCustomer_Load;
            grbKH.ResumeLayout(false);
            grbKH.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKhachHang).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblQuanLyKH;
        private GroupBox grbKH;
        private ComboBox cboLoaiKH;
        private Label lblSDT;
        private Label lblMaKH;
        private Label lblTenKH;
        private TextBox txtSDT;
        private TextBox txtTenKH;
        private TextBox txtMaKH;
        private Button btnThem;
        private Button btnSua;
        private Button button3;
        private Button button4;
        private DataGridView dgvKhachHang;
        private Label lblLoaiKH;
    }
}