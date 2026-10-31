using System.Drawing;
using System.Windows.Forms;

namespace ClassManager.Views
{
    partial class FrmLop
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
            lblQuanLy = new Label();
            lblMaLop = new Label();
            lblTenLop = new Label();
            txtMaLop = new TextBox();
            txtTimKiem = new TextBox();
            txtTenLop = new TextBox();
            btnThem = new Button();
            dgvLop = new DataGridView();
            btnSua = new Button();
            btnLamMoi = new Button();
            btnXoa = new Button();
            btnTimKiem = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvLop).BeginInit();
            SuspendLayout();
            // 
            // lblQuanLy
            // 
            lblQuanLy.AutoSize = true;
            lblQuanLy.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            lblQuanLy.ForeColor = SystemColors.Highlight;
            lblQuanLy.Location = new Point(340, 39);
            lblQuanLy.Name = "lblQuanLy";
            lblQuanLy.Size = new Size(255, 45);
            lblQuanLy.TabIndex = 0;
            lblQuanLy.Text = "Quản lý lớp học";
            // 
            // lblMaLop
            // 
            lblMaLop.AutoSize = true;
            lblMaLop.Location = new Point(61, 114);
            lblMaLop.Name = "lblMaLop";
            lblMaLop.Size = new Size(72, 25);
            lblMaLop.TabIndex = 1;
            lblMaLop.Text = "Mã lớp:";
            // 
            // lblTenLop
            // 
            lblTenLop.AutoSize = true;
            lblTenLop.Location = new Point(506, 114);
            lblTenLop.Name = "lblTenLop";
            lblTenLop.Size = new Size(73, 25);
            lblTenLop.TabIndex = 2;
            lblTenLop.Text = "Tên lớp:";
            // 
            // txtMaLop
            // 
            txtMaLop.Location = new Point(61, 161);
            txtMaLop.Name = "txtMaLop";
            txtMaLop.Size = new Size(317, 31);
            txtMaLop.TabIndex = 4;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(61, 321);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.PlaceholderText = "Nhập mã hoặc tên lớp...";
            txtTimKiem.Size = new Size(304, 31);
            txtTimKiem.TabIndex = 5;
            // 
            // txtTenLop
            // 
            txtTenLop.Location = new Point(506, 161);
            txtTenLop.Name = "txtTenLop";
            txtTenLop.Size = new Size(317, 31);
            txtTenLop.TabIndex = 6;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.CornflowerBlue;
            btnThem.FlatStyle = FlatStyle.Popup;
            btnThem.Location = new Point(61, 219);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(104, 58);
            btnThem.TabIndex = 7;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // dgvLop
            // 
            dgvLop.BackgroundColor = Color.FromArgb(255, 255, 192);
            dgvLop.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLop.Location = new Point(12, 384);
            dgvLop.Name = "dgvLop";
            dgvLop.RowHeadersWidth = 62;
            dgvLop.Size = new Size(921, 372);
            dgvLop.TabIndex = 8;
            dgvLop.CellClick += dgvLop_CellClick;
            dgvLop.CellContentClick += dgvLop_CellContentClick;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.OrangeRed;
            btnSua.FlatStyle = FlatStyle.Popup;
            btnSua.Location = new Point(195, 219);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(104, 58);
            btnSua.TabIndex = 9;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // btnLamMoi
            // 
            btnLamMoi.BackColor = Color.YellowGreen;
            btnLamMoi.FlatStyle = FlatStyle.Popup;
            btnLamMoi.Location = new Point(461, 219);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(104, 58);
            btnLamMoi.TabIndex = 10;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = false;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.Gray;
            btnXoa.FlatStyle = FlatStyle.Popup;
            btnXoa.ForeColor = Color.White;
            btnXoa.Location = new Point(329, 219);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(104, 58);
            btnXoa.TabIndex = 11;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnTimKiem
            // 
            btnTimKiem.BackColor = Color.Cornsilk;
            btnTimKiem.FlatStyle = FlatStyle.Popup;
            btnTimKiem.Location = new Point(395, 307);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(104, 58);
            btnTimKiem.TabIndex = 12;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = false;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // FrmLop
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Bisque;
            ClientSize = new Size(945, 801);
            Controls.Add(btnTimKiem);
            Controls.Add(btnXoa);
            Controls.Add(btnLamMoi);
            Controls.Add(btnSua);
            Controls.Add(dgvLop);
            Controls.Add(btnThem);
            Controls.Add(txtTenLop);
            Controls.Add(txtTimKiem);
            Controls.Add(txtMaLop);
            Controls.Add(lblTenLop);
            Controls.Add(lblMaLop);
            Controls.Add(lblQuanLy);
            Name = "FrmLop";
            Text = "ClassManager";
            Load += FrmLop_Load;
            ((System.ComponentModel.ISupportInitialize)dgvLop).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblQuanLy;
        private Label lblMaLop;
        private Label lblTenLop;
        private TextBox txtMaLop;
        private TextBox txtTimKiem;
        private TextBox txtTenLop;
        private Button btnThem;
        private DataGridView dgvLop;
        private Button btnSua;
        private Button btnLamMoi;
        private Button btnXoa;
        private Button btnTimKiem;
    }
}