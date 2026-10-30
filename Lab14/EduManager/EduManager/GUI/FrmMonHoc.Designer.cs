namespace EduManager.GUI
{
    partial class FrmMonHoc
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
        /// Required method for Designer support - do not allow code editor;
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            grpThongTin = new GroupBox();
            chkTrangThai = new CheckBox();
            nudSoTinChi = new NumericUpDown();
            txtTenMonHoc = new TextBox();
            txtMaMonHoc = new TextBox();
            lblTrangThai = new Label();
            lblSoTinChi = new Label();
            lblTenMonHoc = new Label();
            lblMaMonHoc = new Label();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnLamMoi = new Button();
            lblTimKiem = new Label();
            txtTimKiem = new TextBox();
            btnTimKiem = new Button();
            dgvMonHoc = new DataGridView();
            grpThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudSoTinChi).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvMonHoc).BeginInit();
            SuspendLayout();
            // 
            // grpThongTin
            // 
            grpThongTin.Controls.Add(chkTrangThai);
            grpThongTin.Controls.Add(nudSoTinChi);
            grpThongTin.Controls.Add(txtTenMonHoc);
            grpThongTin.Controls.Add(txtMaMonHoc);
            grpThongTin.Controls.Add(lblTrangThai);
            grpThongTin.Controls.Add(lblSoTinChi);
            grpThongTin.Controls.Add(lblTenMonHoc);
            grpThongTin.Controls.Add(lblMaMonHoc);
            grpThongTin.Location = new Point(17, 20);
            grpThongTin.Margin = new Padding(4, 5, 4, 5);
            grpThongTin.Name = "grpThongTin";
            grpThongTin.Padding = new Padding(4, 5, 4, 5);
            grpThongTin.Size = new Size(1086, 200);
            grpThongTin.TabIndex = 0;
            grpThongTin.TabStop = false;
            grpThongTin.Text = "Thông tin môn học";
            // 
            // chkTrangThai
            // 
            chkTrangThai.AutoSize = true;
            chkTrangThai.Checked = true;
            chkTrangThai.CheckState = CheckState.Checked;
            chkTrangThai.Location = new Point(743, 125);
            chkTrangThai.Margin = new Padding(4, 5, 4, 5);
            chkTrangThai.Name = "chkTrangThai";
            chkTrangThai.Size = new Size(141, 29);
            chkTrangThai.TabIndex = 7;
            chkTrangThai.Text = "Còn sử dụng";
            chkTrangThai.UseVisualStyleBackColor = true;
            // 
            // nudSoTinChi
            // 
            nudSoTinChi.Location = new Point(743, 53);
            nudSoTinChi.Margin = new Padding(4, 5, 4, 5);
            nudSoTinChi.Minimum = new decimal(new int[] { 0, 0, 0, 0 });  
            nudSoTinChi.Maximum = new decimal(new int[] { 100, 0, 0, 0 });
            nudSoTinChi.Name = "nudSoTinChi";
            nudSoTinChi.Size = new Size(300, 31);
            nudSoTinChi.TabIndex = 5;
            nudSoTinChi.Value = new decimal(new int[] { 3, 0, 0, 0 });
            // 
            // txtTenMonHoc
            // 
            txtTenMonHoc.Location = new Point(157, 122);
            txtTenMonHoc.Margin = new Padding(4, 5, 4, 5);
            txtTenMonHoc.MaxLength = 100;
            txtTenMonHoc.Name = "txtTenMonHoc";
            txtTenMonHoc.Size = new Size(398, 31);
            txtTenMonHoc.TabIndex = 3;
            // 
            // txtMaMonHoc
            // 
            txtMaMonHoc.Location = new Point(157, 53);
            txtMaMonHoc.Margin = new Padding(4, 5, 4, 5);
            txtMaMonHoc.MaxLength = 10;
            txtMaMonHoc.Name = "txtMaMonHoc";
            txtMaMonHoc.Size = new Size(398, 31);
            txtMaMonHoc.TabIndex = 1;
            // 
            // lblTrangThai
            // 
            lblTrangThai.AutoSize = true;
            lblTrangThai.Location = new Point(614, 127);
            lblTrangThai.Margin = new Padding(4, 0, 4, 0);
            lblTrangThai.Name = "lblTrangThai";
            lblTrangThai.Size = new Size(93, 25);
            lblTrangThai.TabIndex = 6;
            lblTrangThai.Text = "Trạng thái:";
            // 
            // lblSoTinChi
            // 
            lblSoTinChi.AutoSize = true;
            lblSoTinChi.Location = new Point(614, 58);
            lblSoTinChi.Margin = new Padding(4, 0, 4, 0);
            lblSoTinChi.Name = "lblSoTinChi";
            lblSoTinChi.Size = new Size(89, 25);
            lblSoTinChi.TabIndex = 4;
            lblSoTinChi.Text = "Số tín chỉ:";
            // 
            // lblTenMonHoc
            // 
            lblTenMonHoc.AutoSize = true;
            lblTenMonHoc.Location = new Point(29, 127);
            lblTenMonHoc.Margin = new Padding(4, 0, 4, 0);
            lblTenMonHoc.Name = "lblTenMonHoc";
            lblTenMonHoc.Size = new Size(118, 25);
            lblTenMonHoc.TabIndex = 2;
            lblTenMonHoc.Text = "Tên môn học:";
            // 
            // lblMaMonHoc
            // 
            lblMaMonHoc.AutoSize = true;
            lblMaMonHoc.Location = new Point(29, 58);
            lblMaMonHoc.Margin = new Padding(4, 0, 4, 0);
            lblMaMonHoc.Name = "lblMaMonHoc";
            lblMaMonHoc.Size = new Size(117, 25);
            lblMaMonHoc.TabIndex = 0;
            lblMaMonHoc.Text = "Mã môn học:";
            // 
            // btnThem
            // 
            btnThem.Location = new Point(17, 247);
            btnThem.Margin = new Padding(4, 5, 4, 5);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(121, 50);
            btnThem.TabIndex = 1;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(150, 247);
            btnSua.Margin = new Padding(4, 5, 4, 5);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(121, 50);
            btnSua.TabIndex = 2;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(283, 247);
            btnXoa.Margin = new Padding(4, 5, 4, 5);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(121, 50);
            btnXoa.TabIndex = 3;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Location = new Point(416, 247);
            btnLamMoi.Margin = new Padding(4, 5, 4, 5);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(121, 50);
            btnLamMoi.TabIndex = 4;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = true;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // lblTimKiem
            // 
            lblTimKiem.AutoSize = true;
            lblTimKiem.Location = new Point(593, 260);
            lblTimKiem.Margin = new Padding(4, 0, 4, 0);
            lblTimKiem.Name = "lblTimKiem";
            lblTimKiem.Size = new Size(88, 25);
            lblTimKiem.TabIndex = 5;
            lblTimKiem.Text = "Tìm kiếm:";
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(689, 257);
            txtTimKiem.Margin = new Padding(4, 5, 4, 5);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.PlaceholderText = "Nhập mã hoặc tên môn học...";
            txtTimKiem.Size = new Size(284, 31);
            txtTimKiem.TabIndex = 6;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(981, 247);
            btnTimKiem.Margin = new Padding(4, 5, 4, 5);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(121, 50);
            btnTimKiem.TabIndex = 7;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // dgvMonHoc
            // 
            dgvMonHoc.AllowUserToAddRows = false;
            dgvMonHoc.AllowUserToDeleteRows = false;
            dgvMonHoc.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMonHoc.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMonHoc.Location = new Point(17, 320);
            dgvMonHoc.Margin = new Padding(4, 5, 4, 5);
            dgvMonHoc.MultiSelect = false;
            dgvMonHoc.Name = "dgvMonHoc";
            dgvMonHoc.ReadOnly = true;
            dgvMonHoc.RowHeadersWidth = 62;
            dgvMonHoc.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMonHoc.Size = new Size(1086, 412);
            dgvMonHoc.TabIndex = 8;
            dgvMonHoc.CellClick += dgvMonHoc_CellClick;
            // 
            // FrmMonHoc
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1120, 752);
            Controls.Add(dgvMonHoc);
            Controls.Add(btnTimKiem);
            Controls.Add(txtTimKiem);
            Controls.Add(lblTimKiem);
            Controls.Add(btnLamMoi);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(grpThongTin);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            Name = "FrmMonHoc";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý môn học - EduManager";
            Load += FrmMonHoc_Load;
            grpThongTin.ResumeLayout(false);
            grpThongTin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudSoTinChi).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvMonHoc).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grpThongTin;
        private Label lblMaMonHoc;
        private Label lblTenMonHoc;
        private Label lblSoTinChi;
        private Label lblTrangThai;
        private TextBox txtMaMonHoc;
        private TextBox txtTenMonHoc;
        private NumericUpDown nudSoTinChi;
        private CheckBox chkTrangThai;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private Button btnLamMoi;
        private Label lblTimKiem;
        private TextBox txtTimKiem;
        private Button btnTimKiem;
        private DataGridView dgvMonHoc;
    }
}