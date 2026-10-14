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
    public partial class FrmLogin : Form
    {
        public User CurrentUser { get; private set; }
        public FrmLogin()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen; // Mở giữa màn hình
            this.FormBorderStyle = FormBorderStyle.FixedDialog; // Không cho kéo giãn Form
            this.MaximizeBox = false; // Tắt nút phóng to
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtMatKhau_TextChanged(object sender, EventArgs e)
        {
            txtMatKhau.PasswordChar = '*';  // Che ký tự nhập vào bằng dấu *
        }

        private void lblTitle_Load(object sender, EventArgs e)
        {
            txtMatKhau.AutoSize = false;
            txtMatKhau.Height = 44; //
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtMatKhau.Text.Trim();

            // check trống
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Tên đăng nhập và Mật khẩu!",
                                "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Kiểm tra tài khoản mẫu bài lab (admin / user)
            if (username == "admin" && password == "123")
            {
                CurrentUser = new User
                {
                    Username = "admin",
                    FullName = "Quản trị viên",
                    Role = "Admin"
                };

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else if (username == "user" && password == "123")
            {
                CurrentUser = new User
                {
                    Username = "user",
                    FullName = "Nhân viên bán hàng",
                    Role = "User"
                };

                this.DialogResult = DialogResult.OK; // Trả kết quả thành công cho Program.cs
                this.Close();
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!",
                                "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMatKhau.Clear();
                txtMatKhau.Focus();
            }
        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel; // Trả về Cancel để dừng chương trình
            this.Close();
        }

        private void FrmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}
