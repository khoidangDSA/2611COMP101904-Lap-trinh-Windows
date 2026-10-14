namespace ShopManagerMini.Forms
{
    partial class FrmProduct
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
            grbThongTinSP = new GroupBox();
            nudSoLuong = new NumericUpDown();
            nudDonGia = new NumericUpDown();
            cboLoaiSP = new ComboBox();
            lblLoaiSP = new Label();
            lblSoLuong = new Label();
            lblDonGia = new Label();
            lblTenSP = new Label();
            lblMaSP = new Label();
            txtTenSP = new TextBox();
            txtMaSP = new TextBox();
            lblQuanLySP = new Label();
            btnThem = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnLamMoi = new Button();
            lblTimKiem = new Label();
            txtTimKiem = new TextBox();
            btnTim = new Button();
            dgvSanPham = new DataGridView();
            grbThongTinSP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudSoLuong).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudDonGia).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvSanPham).BeginInit();
            SuspendLayout();
            // 
            // grbThongTinSP
            // 
            grbThongTinSP.BackColor = SystemColors.Info;
            grbThongTinSP.Controls.Add(nudSoLuong);
            grbThongTinSP.Controls.Add(nudDonGia);
            grbThongTinSP.Controls.Add(cboLoaiSP);
            grbThongTinSP.Controls.Add(lblLoaiSP);
            grbThongTinSP.Controls.Add(lblSoLuong);
            grbThongTinSP.Controls.Add(lblDonGia);
            grbThongTinSP.Controls.Add(lblTenSP);
            grbThongTinSP.Controls.Add(lblMaSP);
            grbThongTinSP.Controls.Add(txtTenSP);
            grbThongTinSP.Controls.Add(txtMaSP);
            grbThongTinSP.Location = new Point(181, 148);
            grbThongTinSP.Name = "grbThongTinSP";
            grbThongTinSP.Size = new Size(854, 285);
            grbThongTinSP.TabIndex = 0;
            grbThongTinSP.TabStop = false;
            grbThongTinSP.Text = "Thông tin sản phẩm";
            // 
            // nudSoLuong
            // 
            nudSoLuong.Location = new Point(567, 120);
            nudSoLuong.Name = "nudSoLuong";
            nudSoLuong.Size = new Size(181, 31);
            nudSoLuong.TabIndex = 10;
            // 
            // nudDonGia
            // 
            nudDonGia.Location = new Point(567, 53);
            nudDonGia.Name = "nudDonGia";
            nudDonGia.Size = new Size(181, 31);
            nudDonGia.TabIndex = 9;
            // 
            // cboLoaiSP
            // 
            cboLoaiSP.FormattingEnabled = true;
            cboLoaiSP.Location = new Point(152, 183);
            cboLoaiSP.Name = "cboLoaiSP";
            cboLoaiSP.Size = new Size(240, 33);
            cboLoaiSP.TabIndex = 8;
            // 
            // lblLoaiSP
            // 
            lblLoaiSP.AutoSize = true;
            lblLoaiSP.Location = new Point(22, 186);
            lblLoaiSP.Name = "lblLoaiSP";
            lblLoaiSP.Size = new Size(131, 25);
            lblLoaiSP.TabIndex = 7;
            lblLoaiSP.Text = "Loại sản phẩm:";
            // 
            // lblSoLuong
            // 
            lblSoLuong.AutoSize = true;
            lblSoLuong.Location = new Point(456, 126);
            lblSoLuong.Name = "lblSoLuong";
            lblSoLuong.Size = new Size(89, 25);
            lblSoLuong.TabIndex = 6;
            lblSoLuong.Text = "Số lượng:";
            // 
            // lblDonGia
            // 
            lblDonGia.AutoSize = true;
            lblDonGia.Location = new Point(456, 58);
            lblDonGia.Name = "lblDonGia";
            lblDonGia.Size = new Size(79, 25);
            lblDonGia.TabIndex = 5;
            lblDonGia.Text = "Đơn giá:";
            // 
            // lblTenSP
            // 
            lblTenSP.AutoSize = true;
            lblTenSP.Location = new Point(22, 120);
            lblTenSP.Name = "lblTenSP";
            lblTenSP.Size = new Size(125, 25);
            lblTenSP.TabIndex = 4;
            lblTenSP.Text = "Tên sản phẩm:";
            // 
            // lblMaSP
            // 
            lblMaSP.AutoSize = true;
            lblMaSP.Location = new Point(22, 55);
            lblMaSP.Name = "lblMaSP";
            lblMaSP.Size = new Size(124, 25);
            lblMaSP.TabIndex = 2;
            lblMaSP.Text = "Mã sản phẩm:";
            // 
            // txtTenSP
            // 
            txtTenSP.Location = new Point(152, 120);
            txtTenSP.Name = "txtTenSP";
            txtTenSP.Size = new Size(240, 31);
            txtTenSP.TabIndex = 1;
            // 
            // txtMaSP
            // 
            txtMaSP.Location = new Point(152, 55);
            txtMaSP.Name = "txtMaSP";
            txtMaSP.Size = new Size(240, 31);
            txtMaSP.TabIndex = 0;
            // 
            // lblQuanLySP
            // 
            lblQuanLySP.AutoSize = true;
            lblQuanLySP.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblQuanLySP.ForeColor = Color.Navy;
            lblQuanLySP.Location = new Point(448, 78);
            lblQuanLySP.Name = "lblQuanLySP";
            lblQuanLySP.Size = new Size(340, 45);
            lblQuanLySP.TabIndex = 1;
            lblQuanLySP.Text = "QUẢN LÝ SẢN PHẨM";
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.Red;
            btnThem.FlatStyle = FlatStyle.Popup;
            btnThem.ForeColor = Color.White;
            btnThem.Location = new Point(236, 463);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(133, 56);
            btnThem.TabIndex = 2;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.Gray;
            btnXoa.FlatStyle = FlatStyle.Popup;
            btnXoa.ForeColor = Color.White;
            btnXoa.Location = new Point(440, 463);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(133, 56);
            btnXoa.TabIndex = 3;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.Lime;
            btnSua.FlatStyle = FlatStyle.Popup;
            btnSua.Location = new Point(655, 463);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(133, 56);
            btnSua.TabIndex = 4;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // btnLamMoi
            // 
            btnLamMoi.BackColor = Color.Salmon;
            btnLamMoi.FlatStyle = FlatStyle.Popup;
            btnLamMoi.Location = new Point(856, 463);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(133, 56);
            btnLamMoi.TabIndex = 5;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = false;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // lblTimKiem
            // 
            lblTimKiem.AutoSize = true;
            lblTimKiem.Location = new Point(79, 577);
            lblTimKiem.Name = "lblTimKiem";
            lblTimKiem.Size = new Size(88, 25);
            lblTimKiem.TabIndex = 6;
            lblTimKiem.Text = "Tìm kiếm:";
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(181, 574);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(214, 31);
            txtTimKiem.TabIndex = 7;
            txtTimKiem.TextChanged += txtTimKiem_TextChanged;
            // 
            // btnTim
            // 
            btnTim.Location = new Point(428, 572);
            btnTim.Name = "btnTim";
            btnTim.Size = new Size(112, 34);
            btnTim.TabIndex = 8;
            btnTim.Text = "Tìm";
            btnTim.UseVisualStyleBackColor = true;
            btnTim.Click += btnTim_Click;
            // 
            // dgvSanPham
            // 
            dgvSanPham.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSanPham.Location = new Point(79, 632);
            dgvSanPham.Name = "dgvSanPham";
            dgvSanPham.RowHeadersWidth = 62;
            dgvSanPham.Size = new Size(1063, 376);
            dgvSanPham.TabIndex = 9;
            dgvSanPham.CellClick += dgvSanPham_CellClick;
            // 
            // FrmProduct
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1227, 1050);
            Controls.Add(dgvSanPham);
            Controls.Add(btnTim);
            Controls.Add(txtTimKiem);
            Controls.Add(lblTimKiem);
            Controls.Add(btnLamMoi);
            Controls.Add(btnSua);
            Controls.Add(btnXoa);
            Controls.Add(btnThem);
            Controls.Add(lblQuanLySP);
            Controls.Add(grbThongTinSP);
            Name = "FrmProduct";
            Text = "Product";
            Load += FrmProduct_Load;
            grbThongTinSP.ResumeLayout(false);
            grbThongTinSP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudSoLuong).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudDonGia).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvSanPham).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grbThongTinSP;
        private Label lblLoaiSP;
        private Label lblSoLuong;
        private Label lblDonGia;
        private Label lblTenSP;
        private Label lblMaSP;
        private TextBox txtTenSP;
        private TextBox txtMaSP;
        private NumericUpDown nudSoLuong;
        private NumericUpDown nudDonGia;
        private ComboBox cboLoaiSP;
        private Label lblQuanLySP;
        private Button btnThem;
        private Button btnXoa;
        private Button btnSua;
        private Button btnLamMoi;
        private Label lblTimKiem;
        private TextBox txtTimKiem;
        private Button btnTim;
        private DataGridView dgvSanPham;
    }
}