namespace ShopManagerMini.Forms
{
    partial class FrmMain
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
            menuStrip1 = new MenuStrip();
            mnuHeThong = new ToolStripMenuItem();
            mnuHeThongDangXuat = new ToolStripMenuItem();
            mnuHeThongThoat = new ToolStripMenuItem();
            mnuDanhMuc = new ToolStripMenuItem();
            mnuDanhMucQuanLySP = new ToolStripMenuItem();
            mnuDanhmucQuanLyKH = new ToolStripMenuItem();
            mnuTroGiup = new ToolStripMenuItem();
            mnuTroGiupGioiThieu = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            lblXinChao = new ToolStripStatusLabel();
            lblQuyen = new ToolStripStatusLabel();
            lblThoiGian = new ToolStripStatusLabel();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { mnuHeThong, mnuDanhMuc, mnuTroGiup });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(928, 33);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // mnuHeThong
            // 
            mnuHeThong.DropDownItems.AddRange(new ToolStripItem[] { mnuHeThongDangXuat, mnuHeThongThoat });
            mnuHeThong.Name = "mnuHeThong";
            mnuHeThong.Size = new Size(103, 29);
            mnuHeThong.Text = "Hệ thống";
            // 
            // mnuHeThongDangXuat
            // 
            mnuHeThongDangXuat.Name = "mnuHeThongDangXuat";
            mnuHeThongDangXuat.Size = new Size(270, 34);
            mnuHeThongDangXuat.Text = "Đăng xuất";
            mnuHeThongDangXuat.Click += mnuHeThongDangXuat_Click;
            // 
            // mnuHeThongThoat
            // 
            mnuHeThongThoat.Name = "mnuHeThongThoat";
            mnuHeThongThoat.Size = new Size(270, 34);
            mnuHeThongThoat.Text = "Thoát";
            mnuHeThongThoat.Click += mnuHeThongThoat_Click;
            // 
            // mnuDanhMuc
            // 
            mnuDanhMuc.DropDownItems.AddRange(new ToolStripItem[] { mnuDanhMucQuanLySP, mnuDanhmucQuanLyKH });
            mnuDanhMuc.Name = "mnuDanhMuc";
            mnuDanhMuc.Size = new Size(109, 29);
            mnuDanhMuc.Text = "Danh Mục";
            // 
            // mnuDanhMucQuanLySP
            // 
            mnuDanhMucQuanLySP.Name = "mnuDanhMucQuanLySP";
            mnuDanhMucQuanLySP.Size = new Size(271, 34);
            mnuDanhMucQuanLySP.Text = "Quản lý sản phẩm";
            mnuDanhMucQuanLySP.Click += mnuDanhMucQuanLySP_Click;
            // 
            // mnuDanhmucQuanLyKH
            // 
            mnuDanhmucQuanLyKH.Name = "mnuDanhmucQuanLyKH";
            mnuDanhmucQuanLyKH.Size = new Size(271, 34);
            mnuDanhmucQuanLyKH.Text = "Quản lý khách hàng";
            mnuDanhmucQuanLyKH.Click += mnuDanhmucQuanLyKH_Click;
            // 
            // mnuTroGiup
            // 
            mnuTroGiup.DropDownItems.AddRange(new ToolStripItem[] { mnuTroGiupGioiThieu });
            mnuTroGiup.Name = "mnuTroGiup";
            mnuTroGiup.Size = new Size(93, 29);
            mnuTroGiup.Text = "Trợ giúp";
            // 
            // mnuTroGiupGioiThieu
            // 
            mnuTroGiupGioiThieu.Name = "mnuTroGiupGioiThieu";
            mnuTroGiupGioiThieu.Size = new Size(270, 34);
            mnuTroGiupGioiThieu.Text = "Giới thiệu";
            mnuTroGiupGioiThieu.Click += mnuTroGiupGioiThieu_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(24, 24);
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblXinChao, lblQuyen, lblThoiGian });
            statusStrip1.Location = new Point(0, 471);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(928, 32);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            statusStrip1.ItemClicked += statusStrip1_ItemClicked;
            // 
            // lblXinChao
            // 
            lblXinChao.Name = "lblXinChao";
            lblXinChao.Size = new Size(89, 25);
            lblXinChao.Text = "Xin chào: ";
            // 
            // lblQuyen
            // 
            lblQuyen.Name = "lblQuyen";
            lblQuyen.Size = new Size(73, 25);
            lblQuyen.Text = "Quyền: ";
            // 
            // lblThoiGian
            // 
            lblThoiGian.Name = "lblThoiGian";
            lblThoiGian.Size = new Size(89, 25);
            lblThoiGian.Text = "Thời gian:";
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(928, 503);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FrmMain";
            Text = "ShopManagerMini";
            Load += FrmMain_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem mnuHeThong;
        private ToolStripMenuItem mnuHeThongDangXuat;
        private ToolStripMenuItem mnuHeThongThoat;
        private ToolStripMenuItem mnuDanhMuc;
        private ToolStripMenuItem mnuDanhMucQuanLySP;
        private ToolStripMenuItem mnuDanhmucQuanLyKH;
        private ToolStripMenuItem mnuTroGiup;
        private ToolStripMenuItem mnuTroGiupGioiThieu;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lblXinChao;
        private ToolStripStatusLabel lblQuyen;
        private ToolStripStatusLabel lblThoiGian;
    }
}