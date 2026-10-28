namespace QLSinhVienLab12
{
    partial class FrmNhapDiemTheoLop
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
            lblTieuDe = new Label();
            lblLop = new Label();
            cboLop = new ComboBox();
            lblMonHoc = new Label();
            cboMonHoc = new ComboBox();
            btnTaiDanhSach = new Button();
            dgvKetQua = new DataGridView();
            btnLuuTatCa = new Button();
            lblTrangThai = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvKetQua).BeginInit();
            SuspendLayout();
            // 
            // lblTieuDe
            // 
            lblTieuDe.AutoSize = true;
            lblTieuDe.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTieuDe.Location = new Point(279, 35);
            lblTieuDe.Name = "lblTieuDe";
            lblTieuDe.Size = new Size(392, 38);
            lblTieuDe.TabIndex = 0;
            lblTieuDe.Text = "QUẢN LÝ KẾT QUẢ HỌC TẬP";
            lblTieuDe.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblLop
            // 
            lblLop.AutoSize = true;
            lblLop.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLop.Location = new Point(70, 99);
            lblLop.Name = "lblLop";
            lblLop.Size = new Size(47, 28);
            lblLop.TabIndex = 1;
            lblLop.Text = "Lớp";
            // 
            // cboLop
            // 
            cboLop.BackColor = Color.White;
            cboLop.ForeColor = Color.Black;
            cboLop.FormattingEnabled = true;
            cboLop.Location = new Point(70, 148);
            cboLop.Name = "cboLop";
            cboLop.Size = new Size(341, 36);
            cboLop.TabIndex = 2;
            cboLop.SelectedIndexChanged += cboLop_SelectedIndexChanged;
            // 
            // lblMonHoc
            // 
            lblMonHoc.AutoSize = true;
            lblMonHoc.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMonHoc.Location = new Point(454, 99);
            lblMonHoc.Name = "lblMonHoc";
            lblMonHoc.Size = new Size(95, 28);
            lblMonHoc.TabIndex = 3;
            lblMonHoc.Text = "Môn học";
            // 
            // cboMonHoc
            // 
            cboMonHoc.BackColor = Color.White;
            cboMonHoc.ForeColor = Color.Black;
            cboMonHoc.FormattingEnabled = true;
            cboMonHoc.Location = new Point(454, 148);
            cboMonHoc.Name = "cboMonHoc";
            cboMonHoc.Size = new Size(341, 36);
            cboMonHoc.TabIndex = 4;
            // 
            // btnTaiDanhSach
            // 
            btnTaiDanhSach.BackColor = SystemColors.Highlight;
            btnTaiDanhSach.FlatStyle = FlatStyle.Popup;
            btnTaiDanhSach.ForeColor = Color.Transparent;
            btnTaiDanhSach.Location = new Point(70, 221);
            btnTaiDanhSach.Name = "btnTaiDanhSach";
            btnTaiDanhSach.Size = new Size(171, 65);
            btnTaiDanhSach.TabIndex = 5;
            btnTaiDanhSach.Text = "Tải danh sách";
            btnTaiDanhSach.UseVisualStyleBackColor = false;
            btnTaiDanhSach.Click += btnTaiDanhSach_Click;
            // 
            // dgvKetQua
            // 
            dgvKetQua.BackgroundColor = Color.White;
            dgvKetQua.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKetQua.Location = new Point(70, 330);
            dgvKetQua.Name = "dgvKetQua";
            dgvKetQua.RowHeadersWidth = 62;
            dgvKetQua.Size = new Size(829, 275);
            dgvKetQua.TabIndex = 6;
            // 
            // btnLuuTatCa
            // 
            btnLuuTatCa.BackColor = Color.LimeGreen;
            btnLuuTatCa.FlatStyle = FlatStyle.Popup;
            btnLuuTatCa.Location = new Point(728, 636);
            btnLuuTatCa.Name = "btnLuuTatCa";
            btnLuuTatCa.Size = new Size(171, 65);
            btnLuuTatCa.TabIndex = 7;
            btnLuuTatCa.Text = "Lưu tất cả";
            btnLuuTatCa.UseVisualStyleBackColor = false;
            btnLuuTatCa.Click += btnLuuTatCa_Click;
            // 
            // lblTrangThai
            // 
            lblTrangThai.AutoSize = true;
            lblTrangThai.Location = new Point(12, 717);
            lblTrangThai.Name = "lblTrangThai";
            lblTrangThai.Size = new Size(113, 28);
            lblTrangThai.TabIndex = 8;
            lblTrangThai.Text = "Trạng thái:";
            // 
            // FrmNhapDiemTheoLop
            // 
            AutoScaleDimensions = new SizeF(12F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(943, 756);
            Controls.Add(lblTrangThai);
            Controls.Add(btnLuuTatCa);
            Controls.Add(dgvKetQua);
            Controls.Add(btnTaiDanhSach);
            Controls.Add(cboMonHoc);
            Controls.Add(lblMonHoc);
            Controls.Add(cboLop);
            Controls.Add(lblLop);
            Controls.Add(lblTieuDe);
            Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = Color.Black;
            Name = "FrmNhapDiemTheoLop";
            Text = "QuanLySinhVien";
            Load += FrmNhapDiemTheoLop_Load;
            ((System.ComponentModel.ISupportInitialize)dgvKetQua).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTieuDe;
        private Label lblLop;
        private ComboBox cboLop;
        private Label lblMonHoc;
        private ComboBox cboMonHoc;
        private Button btnTaiDanhSach;
        private DataGridView dgvKetQua;
        private Button btnLuuTatCa;
        private Label lblTrangThai;
    }
}
