using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ShopManagerMini.Models;

namespace ShopManagerMini.Forms
{
    public partial class FrmMain : Form
    {
        private bool _isLogout = false;
        private readonly User _currentUser;
        private System.Windows.Forms.Timer _clockTimer;
        public FrmMain()
        {
            InitializeComponent();
            this.IsMdiContainer = true; // Biến Form này thành khung MDI Parent
            this.WindowState = FormWindowState.Maximized; // Phóng to màn hình chính
        }

        public FrmMain(User user) : this()
        {
            this._currentUser = user;
        }


        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            //StatusStrip
            if (_currentUser != null)
            {
                lblXinChao.Text = $"Xin chào: {_currentUser.FullName}";
                lblQuyen.Text = $"Quyền: {_currentUser.Role}";
            }
            else
            {
                lblXinChao.Text = "Xin chào: Admin";
                lblQuyen.Text = "Quyền: Quản trị viên";
            }
            // Khởi tạo đồng hồ thời gian thực
            _clockTimer = new System.Windows.Forms.Timer();
            _clockTimer.Interval = 1000;
            _clockTimer.Tick += ClockTimer_Tick;
            _clockTimer.Start();
            UpdateClock();

        }
        private void ClockTimer_Tick(object sender, EventArgs e)
        {
            UpdateClock();
        }

        private void UpdateClock()
        {
            lblThoiGian.Text = $"Thời gian: {DateTime.Now:dd/MM/yyyy HH:mm:ss}";
        }
        // Form con không trùng
        private void OpenChildForm(Form childForm)
        {
            foreach (Form form in this.MdiChildren)
            {
                if (form.GetType() == childForm.GetType())
                {
                    MessageBox.Show(
                        "Form này đang được mở!",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );

                    form.Activate();
                    childForm.Dispose();
                    return;
                }
            }

            childForm.MdiParent = this;
            childForm.Show();
        }

        private void mnuHeThongDangXuat_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show(
               "Bạn có chắc chắn muốn đăng xuất?",
               "Xác nhận đăng xuất",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                _isLogout = true;
                this.Close();
            }

        }

        private void mnuHeThongThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void mnuDanhMucQuanLySP_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmProduct());

        }

        private void mnuDanhmucQuanLyKH_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmCustomer());

        }

        private void mnuTroGiupGioiThieu_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmAbout());

        }
        // Xác nhận out ứng dụng
        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_isLogout) return;

            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult confirm = MessageBox.Show("Bạn có chắc chắn muốn thoát chương trình?",
                                                     "Xác nhận thoát",
                                                     MessageBoxButtons.YesNo,
                                                     MessageBoxIcon.Question);
                if (confirm != DialogResult.Yes)
                {
                    e.Cancel = true; // Hủy đóng form
                }
            }
        }

        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}
