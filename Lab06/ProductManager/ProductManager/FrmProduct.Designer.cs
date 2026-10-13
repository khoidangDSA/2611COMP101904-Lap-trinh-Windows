namespace ProductManager
{
    partial class FrmProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProduct));
            groupBox1 = new GroupBox();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            numSoLuong = new NumericUpDown();
            numDonGia = new NumericUpDown();
            cboLoaiSP = new ComboBox();
            btnChonAnh = new Button();
            dtpNgayNhap = new DateTimePicker();
            picSanPham = new PictureBox();
            lblLoaiSP = new Label();
            txtTenSP = new TextBox();
            txtMaSP = new TextBox();
            chkConKinhDoanh = new CheckBox();
            lblNgayNhap = new Label();
            lblSoLuong = new Label();
            lblDonGia = new Label();
            lblTenSP = new Label();
            lblMaSP = new Label();
            menuStrip1 = new MenuStrip();
            mnuFile = new ToolStripMenuItem();
            mnuFileExit = new ToolStripMenuItem();
            mnuQuanLy = new ToolStripMenuItem();
            mnuTroGiup = new ToolStripMenuItem();
            toolStrip1 = new ToolStrip();
            tbsThem = new ToolStripButton();
            tbsSua = new ToolStripButton();
            tbsXoa = new ToolStripButton();
            tbsLamMoi = new ToolStripButton();
            tbsTimKiem = new ToolStripButton();
            dgvProducts = new DataGridView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            cmsSua = new ToolStripMenuItem();
            cmsXoa = new ToolStripMenuItem();
            cmsXemChiTiet = new ToolStripMenuItem();
            txtTimKiem = new TextBox();
            lblTimKiem = new Label();
            btnTimKiem = new Button();
            statusStrip1 = new StatusStrip();
            lblStatus = new ToolStripStatusLabel();
            btnLamMoi = new Button();
            errorProvider1 = new ErrorProvider(components);
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numSoLuong).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numDonGia).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picSanPham).BeginInit();
            menuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            contextMenuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Controls.Add(btnSua);
            groupBox1.Controls.Add(btnThem);
            groupBox1.Controls.Add(numSoLuong);
            groupBox1.Controls.Add(numDonGia);
            groupBox1.Controls.Add(cboLoaiSP);
            groupBox1.Controls.Add(btnChonAnh);
            groupBox1.Controls.Add(dtpNgayNhap);
            groupBox1.Controls.Add(picSanPham);
            groupBox1.Controls.Add(lblLoaiSP);
            groupBox1.Controls.Add(txtTenSP);
            groupBox1.Controls.Add(txtMaSP);
            groupBox1.Controls.Add(chkConKinhDoanh);
            groupBox1.Controls.Add(lblNgayNhap);
            groupBox1.Controls.Add(lblSoLuong);
            groupBox1.Controls.Add(lblDonGia);
            groupBox1.Controls.Add(lblTenSP);
            groupBox1.Controls.Add(lblMaSP);
            groupBox1.ForeColor = Color.Blue;
            groupBox1.Location = new Point(12, 88);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1006, 412);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin sản phẩm";
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.Aquamarine;
            btnXoa.FlatStyle = FlatStyle.Popup;
            btnXoa.ForeColor = Color.Black;
            btnXoa.Location = new Point(726, 252);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(217, 49);
            btnXoa.TabIndex = 20;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.BackColor = SystemColors.Info;
            btnSua.FlatStyle = FlatStyle.Popup;
            btnSua.ForeColor = Color.Black;
            btnSua.Location = new Point(726, 156);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(217, 49);
            btnSua.TabIndex = 19;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.Coral;
            btnThem.FlatStyle = FlatStyle.Flat;
            btnThem.ForeColor = Color.Black;
            btnThem.Location = new Point(726, 57);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(217, 49);
            btnThem.TabIndex = 18;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // numSoLuong
            // 
            numSoLuong.Location = new Point(172, 252);
            numSoLuong.Name = "numSoLuong";
            numSoLuong.Size = new Size(187, 31);
            numSoLuong.TabIndex = 17;
            // 
            // numDonGia
            // 
            numDonGia.Location = new Point(172, 205);
            numDonGia.Name = "numDonGia";
            numDonGia.Size = new Size(187, 31);
            numDonGia.TabIndex = 16;
            // 
            // cboLoaiSP
            // 
            cboLoaiSP.FormattingEnabled = true;
            cboLoaiSP.Location = new Point(171, 156);
            cboLoaiSP.Name = "cboLoaiSP";
            cboLoaiSP.Size = new Size(188, 33);
            cboLoaiSP.TabIndex = 15;
            // 
            // btnChonAnh
            // 
            btnChonAnh.FlatStyle = FlatStyle.System;
            btnChonAnh.Location = new Point(499, 296);
            btnChonAnh.Name = "btnChonAnh";
            btnChonAnh.Size = new Size(112, 46);
            btnChonAnh.TabIndex = 4;
            btnChonAnh.Text = "Chọn ảnh";
            btnChonAnh.UseVisualStyleBackColor = true;
            btnChonAnh.Click += btnChonAnh_Click_1;
            // 
            // dtpNgayNhap
            // 
            dtpNgayNhap.Format = DateTimePickerFormat.Short;
            dtpNgayNhap.Location = new Point(171, 307);
            dtpNgayNhap.Name = "dtpNgayNhap";
            dtpNgayNhap.Size = new Size(188, 31);
            dtpNgayNhap.TabIndex = 14;
            // 
            // picSanPham
            // 
            picSanPham.BackColor = Color.WhiteSmoke;
            picSanPham.BorderStyle = BorderStyle.FixedSingle;
            picSanPham.Location = new Point(450, 57);
            picSanPham.Name = "picSanPham";
            picSanPham.Size = new Size(216, 221);
            picSanPham.SizeMode = PictureBoxSizeMode.Zoom;
            picSanPham.TabIndex = 3;
            picSanPham.TabStop = false;
            picSanPham.Click += picSanPham_Click;
            // 
            // lblLoaiSP
            // 
            lblLoaiSP.AutoSize = true;
            lblLoaiSP.Location = new Point(29, 159);
            lblLoaiSP.Name = "lblLoaiSP";
            lblLoaiSP.Size = new Size(136, 25);
            lblLoaiSP.TabIndex = 12;
            lblLoaiSP.Text = "Loại sản phẩm: ";
            // 
            // txtTenSP
            // 
            txtTenSP.Location = new Point(172, 106);
            txtTenSP.Name = "txtTenSP";
            txtTenSP.Size = new Size(187, 31);
            txtTenSP.TabIndex = 11;
            // 
            // txtMaSP
            // 
            txtMaSP.Location = new Point(172, 57);
            txtMaSP.Name = "txtMaSP";
            txtMaSP.Size = new Size(187, 31);
            txtMaSP.TabIndex = 6;
            // 
            // chkConKinhDoanh
            // 
            chkConKinhDoanh.AutoSize = true;
            chkConKinhDoanh.Location = new Point(171, 360);
            chkConKinhDoanh.Name = "chkConKinhDoanh";
            chkConKinhDoanh.Size = new Size(164, 29);
            chkConKinhDoanh.TabIndex = 5;
            chkConKinhDoanh.Text = "Còn kinh doanh";
            chkConKinhDoanh.UseVisualStyleBackColor = true;
            // 
            // lblNgayNhap
            // 
            lblNgayNhap.AutoSize = true;
            lblNgayNhap.Location = new Point(30, 307);
            lblNgayNhap.Name = "lblNgayNhap";
            lblNgayNhap.Size = new Size(103, 25);
            lblNgayNhap.TabIndex = 4;
            lblNgayNhap.Text = "Ngày nhập:";
            // 
            // lblSoLuong
            // 
            lblSoLuong.AutoSize = true;
            lblSoLuong.Location = new Point(30, 258);
            lblSoLuong.Name = "lblSoLuong";
            lblSoLuong.Size = new Size(89, 25);
            lblSoLuong.TabIndex = 3;
            lblSoLuong.Text = "Số lượng:";
            // 
            // lblDonGia
            // 
            lblDonGia.AutoSize = true;
            lblDonGia.Location = new Point(30, 211);
            lblDonGia.Name = "lblDonGia";
            lblDonGia.Size = new Size(79, 25);
            lblDonGia.TabIndex = 2;
            lblDonGia.Text = "Đơn giá:";
            // 
            // lblTenSP
            // 
            lblTenSP.AutoSize = true;
            lblTenSP.Location = new Point(29, 106);
            lblTenSP.Name = "lblTenSP";
            lblTenSP.Size = new Size(130, 25);
            lblTenSP.TabIndex = 1;
            lblTenSP.Text = "Tên sản phẩm: ";
            // 
            // lblMaSP
            // 
            lblMaSP.AutoSize = true;
            lblMaSP.Location = new Point(29, 57);
            lblMaSP.Name = "lblMaSP";
            lblMaSP.Size = new Size(129, 25);
            lblMaSP.TabIndex = 0;
            lblMaSP.Text = "Mã sản phẩm: ";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { mnuFile, mnuQuanLy, mnuTroGiup });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1030, 33);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            mnuFile.DropDownItems.AddRange(new ToolStripItem[] { mnuFileExit });
            mnuFile.Name = "mnuFile";
            mnuFile.Size = new Size(54, 29);
            mnuFile.Text = "File";
            // 
            // mnuFileExit
            // 
            mnuFileExit.Name = "mnuFileExit";
            mnuFileExit.Size = new Size(141, 34);
            mnuFileExit.Text = "Exit";
            mnuFileExit.Click += mnuFileExit_Click_1;
            // 
            // mnuQuanLy
            // 
            mnuQuanLy.Name = "mnuQuanLy";
            mnuQuanLy.Size = new Size(89, 29);
            mnuQuanLy.Text = "Quản lý";
            // 
            // mnuTroGiup
            // 
            mnuTroGiup.Name = "mnuTroGiup";
            mnuTroGiup.Size = new Size(93, 29);
            mnuTroGiup.Text = "Trợ giúp";
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(24, 24);
            toolStrip1.Items.AddRange(new ToolStripItem[] { tbsThem, tbsSua, tbsXoa, tbsLamMoi, tbsTimKiem });
            toolStrip1.Location = new Point(0, 33);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1030, 34);
            toolStrip1.TabIndex = 2;
            toolStrip1.Text = "toolStrip1";
            // 
            // tbsThem
            // 
            tbsThem.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tbsThem.Image = (Image)resources.GetObject("tbsThem.Image");
            tbsThem.ImageTransparentColor = Color.Magenta;
            tbsThem.Name = "tbsThem";
            tbsThem.Size = new Size(60, 29);
            tbsThem.Text = "Thêm";
            tbsThem.Click += tbsThem_Click;
            // 
            // tbsSua
            // 
            tbsSua.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tbsSua.Image = (Image)resources.GetObject("tbsSua.Image");
            tbsSua.ImageTransparentColor = Color.Magenta;
            tbsSua.Name = "tbsSua";
            tbsSua.Size = new Size(46, 29);
            tbsSua.Text = "Sửa";
            tbsSua.Click += tbsSua_Click;
            // 
            // tbsXoa
            // 
            tbsXoa.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tbsXoa.Image = (Image)resources.GetObject("tbsXoa.Image");
            tbsXoa.ImageTransparentColor = Color.Magenta;
            tbsXoa.Name = "tbsXoa";
            tbsXoa.Size = new Size(47, 29);
            tbsXoa.Text = "Xóa";
            tbsXoa.Click += tbsXoa_Click;
            // 
            // tbsLamMoi
            // 
            tbsLamMoi.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tbsLamMoi.Image = (Image)resources.GetObject("tbsLamMoi.Image");
            tbsLamMoi.ImageTransparentColor = Color.Magenta;
            tbsLamMoi.Name = "tbsLamMoi";
            tbsLamMoi.Size = new Size(85, 29);
            tbsLamMoi.Text = "Làm mới";
            tbsLamMoi.Click += tbsLamMoi_Click;
            // 
            // tbsTimKiem
            // 
            tbsTimKiem.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tbsTimKiem.Image = (Image)resources.GetObject("tbsTimKiem.Image");
            tbsTimKiem.ImageTransparentColor = Color.Magenta;
            tbsTimKiem.Name = "tbsTimKiem";
            tbsTimKiem.Size = new Size(88, 29);
            tbsTimKiem.Text = "Tìm kiếm";
            tbsTimKiem.Click += tbsTimKiem_Click;
            // 
            // dgvProducts
            // 
            dgvProducts.BackgroundColor = SystemColors.ScrollBar;
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.ContextMenuStrip = contextMenuStrip1;
            dgvProducts.Location = new Point(12, 605);
            dgvProducts.Name = "dgvProducts";
            dgvProducts.RowHeadersWidth = 62;
            dgvProducts.Size = new Size(1006, 312);
            dgvProducts.TabIndex = 3;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(24, 24);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { cmsSua, cmsXoa, cmsXemChiTiet });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(178, 100);
            contextMenuStrip1.Opening += contextMenuStrip1_Opening;
            // 
            // cmsSua
            // 
            cmsSua.Name = "cmsSua";
            cmsSua.Size = new Size(177, 32);
            cmsSua.Text = "Sửa";
            cmsSua.Click += cmsSua_Click;
            // 
            // cmsXoa
            // 
            cmsXoa.Name = "cmsXoa";
            cmsXoa.Size = new Size(177, 32);
            cmsXoa.Text = "Xóa";
            cmsXoa.Click += cmsXoa_Click;
            // 
            // cmsXemChiTiet
            // 
            cmsXemChiTiet.Name = "cmsXemChiTiet";
            cmsXemChiTiet.Size = new Size(177, 32);
            cmsXemChiTiet.Text = "Xem chi tiết";
            cmsXemChiTiet.Click += cmsXemChiTiet_Click;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(243, 549);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.PlaceholderText = "Nhập mã hoặc tên sản phẩm...";
            txtTimKiem.Size = new Size(270, 31);
            txtTimKiem.TabIndex = 4;
            txtTimKiem.TextChanged += txtTimKiem_TextChanged;
            // 
            // lblTimKiem
            // 
            lblTimKiem.AutoSize = true;
            lblTimKiem.Location = new Point(41, 555);
            lblTimKiem.Name = "lblTimKiem";
            lblTimKiem.Size = new Size(196, 25);
            lblTimKiem.TabIndex = 5;
            lblTimKiem.Text = "Tìm kiếm(mã hoặc tên):";
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(535, 541);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(113, 46);
            btnTimKiem.TabIndex = 6;
            btnTimKiem.Text = "Tìm Kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(24, 24);
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblStatus });
            statusStrip1.Location = new Point(0, 950);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1030, 32);
            statusStrip1.TabIndex = 7;
            statusStrip1.Text = "statusStrip1";
            statusStrip1.ItemClicked += statusStrip1_ItemClicked;
            // 
            // lblStatus
            // 
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(84, 25);
            lblStatus.Text = "Sẵn sàng";
            // 
            // btnLamMoi
            // 
            btnLamMoi.Location = new Point(674, 541);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(113, 46);
            btnLamMoi.TabIndex = 8;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = true;
            btnLamMoi.Click += btnLamMoi_Click_1;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // FrmProduct
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1030, 982);
            Controls.Add(btnLamMoi);
            Controls.Add(statusStrip1);
            Controls.Add(btnTimKiem);
            Controls.Add(lblTimKiem);
            Controls.Add(txtTimKiem);
            Controls.Add(dgvProducts);
            Controls.Add(toolStrip1);
            Controls.Add(groupBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FrmProduct";
            Text = "Quản lý sản phẩm";
            Load += FrmProduct_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numSoLuong).EndInit();
            ((System.ComponentModel.ISupportInitialize)numDonGia).EndInit();
            ((System.ComponentModel.ISupportInitialize)picSanPham).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label lblMaSP;
        private Label lblSoLuong;
        private Label lblDonGia;
        private Label lblTenSP;
        private Label lblNgayNhap;
        private CheckBox chkConKinhDoanh;
        private TextBox txtTenSP;
        private TextBox txtMaSP;
        private Label lblLoaiSP;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem mnuFile;
        private ToolStripMenuItem mnuQuanLy;
        private ToolStripMenuItem mnuTroGiup;
        private ToolStrip toolStrip1;
        private ToolStripButton tbsThem;
        private ToolStripButton tbsSua;
        private ToolStripButton tbsXoa;
        private ToolStripButton tbsLamMoi;
        private ToolStripButton tbsTimKiem;
        private DateTimePicker dtpNgayNhap;
        private PictureBox picSanPham;
        private Button btnChonAnh;
        private NumericUpDown numSoLuong;
        private NumericUpDown numDonGia;
        private ComboBox cboLoaiSP;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private DataGridView dgvProducts;
        private TextBox txtTimKiem;
        private Label lblTimKiem;
        private Button btnTimKiem;
        private ToolStripMenuItem mnuFileExit;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lblStatus;
        private Button btnLamMoi;
        private ErrorProvider errorProvider1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem cmsSua;
        private ToolStripMenuItem cmsXoa;
        private ToolStripMenuItem cmsXemChiTiet;
    }
}
