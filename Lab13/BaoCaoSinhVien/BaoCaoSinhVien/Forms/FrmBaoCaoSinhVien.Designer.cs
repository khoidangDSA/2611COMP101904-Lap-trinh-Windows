namespace BaoCaoSinhVien
{
    partial class FrmBaoCaoSinhVien
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
            grbLoc = new GroupBox();
            btnXuatFile = new Button();
            btnThongKe = new Button();
            btnXemBaoCao = new Button();
            txtTuKhoa = new TextBox();
            lblTuKhoa = new Label();
            cboKetQua = new ComboBox();
            cboLop = new ComboBox();
            lblKetQua = new Label();
            lblLop = new Label();
            lblThongKe = new Label();
            grbSinhVien = new GroupBox();
            dgvBaoCao = new DataGridView();
            grbLoc.SuspendLayout();
            grbSinhVien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBaoCao).BeginInit();
            SuspendLayout();
            // 
            // grbLoc
            // 
            grbLoc.BackColor = Color.White;
            grbLoc.Controls.Add(btnXuatFile);
            grbLoc.Controls.Add(btnThongKe);
            grbLoc.Controls.Add(btnXemBaoCao);
            grbLoc.Controls.Add(txtTuKhoa);
            grbLoc.Controls.Add(lblTuKhoa);
            grbLoc.Controls.Add(cboKetQua);
            grbLoc.Controls.Add(cboLop);
            grbLoc.Controls.Add(lblKetQua);
            grbLoc.Controls.Add(lblLop);
            grbLoc.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grbLoc.Location = new Point(7, 25);
            grbLoc.Name = "grbLoc";
            grbLoc.Size = new Size(1061, 168);
            grbLoc.TabIndex = 0;
            grbLoc.TabStop = false;
            grbLoc.Text = "Bộ lọc và Chức năng";
            // 
            // btnXuatFile
            // 
            btnXuatFile.BackColor = Color.MediumOrchid;
            btnXuatFile.FlatStyle = FlatStyle.Popup;
            btnXuatFile.Font = new Font("Segoe UI", 9F);
            btnXuatFile.ForeColor = Color.White;
            btnXuatFile.Location = new Point(918, 56);
            btnXuatFile.Name = "btnXuatFile";
            btnXuatFile.Size = new Size(137, 71);
            btnXuatFile.TabIndex = 8;
            btnXuatFile.Text = "Xuất File";
            btnXuatFile.UseVisualStyleBackColor = false;
            btnXuatFile.Click += btnXuatFile_Click;
            // 
            // btnThongKe
            // 
            btnThongKe.BackColor = Color.FromArgb(0, 192, 0);
            btnThongKe.FlatStyle = FlatStyle.Popup;
            btnThongKe.Font = new Font("Segoe UI", 9F);
            btnThongKe.ForeColor = Color.White;
            btnThongKe.Location = new Point(751, 56);
            btnThongKe.Name = "btnThongKe";
            btnThongKe.Size = new Size(137, 71);
            btnThongKe.TabIndex = 7;
            btnThongKe.Text = "Thống kê";
            btnThongKe.UseVisualStyleBackColor = false;
            btnThongKe.Click += btnThongKe_Click;
            // 
            // btnXemBaoCao
            // 
            btnXemBaoCao.BackColor = SystemColors.MenuHighlight;
            btnXemBaoCao.FlatStyle = FlatStyle.Popup;
            btnXemBaoCao.Font = new Font("Segoe UI", 9F);
            btnXemBaoCao.ForeColor = Color.White;
            btnXemBaoCao.Location = new Point(581, 56);
            btnXemBaoCao.Name = "btnXemBaoCao";
            btnXemBaoCao.Size = new Size(137, 71);
            btnXemBaoCao.TabIndex = 6;
            btnXemBaoCao.Text = "Xem báo cáo";
            btnXemBaoCao.UseVisualStyleBackColor = false;
            btnXemBaoCao.Click += btnXemBaoCao_Click;
            // 
            // txtTuKhoa
            // 
            txtTuKhoa.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTuKhoa.Location = new Point(185, 108);
            txtTuKhoa.Name = "txtTuKhoa";
            txtTuKhoa.PlaceholderText = "Nhập mã SV hoặc họ tên...";
            txtTuKhoa.Size = new Size(364, 31);
            txtTuKhoa.TabIndex = 5;
            txtTuKhoa.TextChanged += txtTuKhoa_TextChanged;
            // 
            // lblTuKhoa
            // 
            lblTuKhoa.AutoSize = true;
            lblTuKhoa.Font = new Font("Segoe UI", 9F);
            lblTuKhoa.Location = new Point(25, 111);
            lblTuKhoa.Name = "lblTuKhoa";
            lblTuKhoa.Size = new Size(154, 25);
            lblTuKhoa.TabIndex = 4;
            lblTuKhoa.Text = "Từ khóa tìm kiếm:";
            // 
            // cboKetQua
            // 
            cboKetQua.FormattingEnabled = true;
            cboKetQua.Location = new Point(396, 43);
            cboKetQua.Name = "cboKetQua";
            cboKetQua.Size = new Size(153, 33);
            cboKetQua.TabIndex = 3;
            cboKetQua.SelectedIndexChanged += cboKetQua_SelectedIndexChanged;
            // 
            // cboLop
            // 
            cboLop.FormattingEnabled = true;
            cboLop.Location = new Point(77, 43);
            cboLop.Name = "cboLop";
            cboLop.Size = new Size(153, 33);
            cboLop.TabIndex = 2;
            cboLop.SelectedIndexChanged += cboLop_SelectedIndexChanged;
            // 
            // lblKetQua
            // 
            lblKetQua.AutoSize = true;
            lblKetQua.Font = new Font("Segoe UI", 9F);
            lblKetQua.Location = new Point(249, 46);
            lblKetQua.Name = "lblKetQua";
            lblKetQua.Size = new Size(141, 25);
            lblKetQua.TabIndex = 1;
            lblKetQua.Text = "Kết quả học tập:";
            // 
            // lblLop
            // 
            lblLop.AutoSize = true;
            lblLop.Font = new Font("Segoe UI", 9F);
            lblLop.Location = new Point(25, 46);
            lblLop.Name = "lblLop";
            lblLop.Size = new Size(46, 25);
            lblLop.TabIndex = 0;
            lblLop.Text = "Lớp:";
            // 
            // lblThongKe
            // 
            lblThongKe.AutoSize = true;
            lblThongKe.Location = new Point(7, 623);
            lblThongKe.Name = "lblThongKe";
            lblThongKe.Size = new Size(122, 25);
            lblThongKe.TabIndex = 1;
            lblThongKe.Text = "Đang hiển thị:";
            // 
            // grbSinhVien
            // 
            grbSinhVien.BackColor = Color.White;
            grbSinhVien.Controls.Add(dgvBaoCao);
            grbSinhVien.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grbSinhVien.Location = new Point(7, 221);
            grbSinhVien.Name = "grbSinhVien";
            grbSinhVien.Padding = new Padding(20, 3, 3, 3);
            grbSinhVien.Size = new Size(1061, 399);
            grbSinhVien.TabIndex = 2;
            grbSinhVien.TabStop = false;
            grbSinhVien.Text = "Danh sách sinh viên";
            // 
            // dgvBaoCao
            // 
            dgvBaoCao.BackgroundColor = Color.FromArgb(255, 192, 128);
            dgvBaoCao.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBaoCao.Location = new Point(6, 30);
            dgvBaoCao.Name = "dgvBaoCao";
            dgvBaoCao.RowHeadersWidth = 62;
            dgvBaoCao.Size = new Size(1049, 363);
            dgvBaoCao.TabIndex = 0;
            // 
            // FrmBaoCaoSinhVien
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1080, 657);
            Controls.Add(grbSinhVien);
            Controls.Add(lblThongKe);
            Controls.Add(grbLoc);
            Name = "FrmBaoCaoSinhVien";
            Text = "Báo cáo sinh viên";
            Load += FrmBaoCaoSinhVien_Load;
            grbLoc.ResumeLayout(false);
            grbLoc.PerformLayout();
            grbSinhVien.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvBaoCao).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grbLoc;
        private ComboBox cboKetQua;
        private ComboBox cboLop;
        private Label lblKetQua;
        private Label lblLop;
        private Label lblTuKhoa;
        private Button btnXuatFile;
        private Button btnThongKe;
        private Button btnXemBaoCao;
        private TextBox txtTuKhoa;
        private Label lblThongKe;
        private GroupBox grbSinhVien;
        private DataGridView dgvBaoCao;
    }
}
