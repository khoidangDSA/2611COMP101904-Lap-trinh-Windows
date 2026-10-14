namespace ShopManagerMini.Forms
{
    partial class FrmLogin
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
            panel1 = new Panel();
            btnOut = new Button();
            btnLogin = new Button();
            txtMatKhau = new TextBox();
            txtUsername = new TextBox();
            lblMatKhau = new Label();
            lblUserName = new Label();
            lblTitle = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Azure;
            panel1.Controls.Add(btnOut);
            panel1.Controls.Add(btnLogin);
            panel1.Controls.Add(txtMatKhau);
            panel1.Controls.Add(txtUsername);
            panel1.Controls.Add(lblMatKhau);
            panel1.Controls.Add(lblUserName);
            panel1.Controls.Add(lblTitle);
            panel1.Location = new Point(168, 78);
            panel1.Name = "panel1";
            panel1.Size = new Size(504, 452);
            panel1.TabIndex = 2;
            // 
            // btnOut
            // 
            btnOut.BackColor = Color.Gray;
            btnOut.FlatStyle = FlatStyle.Popup;
            btnOut.ForeColor = Color.White;
            btnOut.Location = new Point(261, 372);
            btnOut.Name = "btnOut";
            btnOut.Size = new Size(197, 45);
            btnOut.TabIndex = 7;
            btnOut.Text = "Thoát";
            btnOut.UseVisualStyleBackColor = false;
            btnOut.Click += btnOut_Click;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Red;
            btnLogin.FlatStyle = FlatStyle.Popup;
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(44, 372);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(194, 45);
            btnLogin.TabIndex = 6;
            btnLogin.Text = "Đăng nhập";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMatKhau.ForeColor = Color.Black;
            txtMatKhau.Location = new Point(44, 281);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(414, 31);
            txtMatKhau.TabIndex = 5;
            txtMatKhau.UseSystemPasswordChar = true;
            txtMatKhau.TextChanged += txtMatKhau_TextChanged;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(44, 160);
            txtUsername.Multiline = true;
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(414, 44);
            txtUsername.TabIndex = 4;
            // 
            // lblMatKhau
            // 
            lblMatKhau.AutoSize = true;
            lblMatKhau.BackColor = Color.Azure;
            lblMatKhau.ForeColor = Color.Black;
            lblMatKhau.Location = new Point(44, 234);
            lblMatKhau.Name = "lblMatKhau";
            lblMatKhau.Size = new Size(98, 25);
            lblMatKhau.TabIndex = 3;
            lblMatKhau.Text = "*Mật khẩu:";
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.ForeColor = Color.Black;
            lblUserName.Location = new Point(44, 112);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(141, 25);
            lblUserName.TabIndex = 2;
            lblUserName.Text = "*Tên đăng nhập:";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.Black;
            lblTitle.Location = new Point(75, 43);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(340, 38);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "ĐĂNG NHẬP HỆ THỐNG";
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DodgerBlue;
            ClientSize = new Size(823, 612);
            Controls.Add(panel1);
            ForeColor = SystemColors.MenuHighlight;
            Name = "FrmLogin";
            Text = "Welcome";
            FormClosed += FrmLogin_FormClosed;
            Load += lblTitle_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox txtUsername;
        private Label lblMatKhau;
        private Label lblUserName;
        private Label lblTitle;
        private TextBox txtMatKhau;
        private Button btnOut;
        private Button btnLogin;
    }
}