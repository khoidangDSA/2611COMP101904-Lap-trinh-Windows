using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using ClassManager.Models;
using ClassManager.Presenters;
using ClassManager.Repositories;

namespace ClassManager.Views
{
    public partial class FrmLop : Form, ILopView
    {
        private LopPresenter? _presenter;

        public FrmLop()
        {
            InitializeComponent();
        }

        // Khai báo ẩn Serialization để khắc phục lỗi WFO1000
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Browsable(false)]
        public string MaLop
        {
            get => txtMaLop.Text;
            set => txtMaLop.Text = value;
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Browsable(false)]
        public string TenLop
        {
            get => txtTenLop.Text;
            set => txtTenLop.Text = value;
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Browsable(false)]
        public string SearchKeyword
        {
            get => txtTimKiem.Text;
            set => txtTimKiem.Text = value;
        }

        private void FrmLop_Load(object sender, EventArgs e)
        {
            ILopRepository repository = new LopRepository();
            _presenter = new LopPresenter(this, repository);
            _presenter.LoadData();

            dgvLop.AllowUserToAddRows = false;
        }

        public void DisplayLopList(List<Lop> list)
        {
            dgvLop.DataSource = null;
            dgvLop.DataSource = list;

            if (dgvLop.Columns["MaLop"] != null) dgvLop.Columns["MaLop"].HeaderText = "Mã Lớp";
            if (dgvLop.Columns["TenLop"] != null) dgvLop.Columns["TenLop"].HeaderText = "Tên Lớp";
            if (dgvLop.Columns["SoSinhVien"] != null) dgvLop.Columns["SoSinhVien"].HeaderText = "Sỉ Số SV";

            dgvLop.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        public void ShowMessage(string message, string caption, MessageBoxButtons buttons, MessageBoxIcon icon)
        {
            MessageBox.Show(message, caption, buttons, icon);
        }

        public bool ConfirmAction(string message, string caption)
        {
            return MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
        }

        public void ClearInput()
        {
            txtMaLop.Clear();
            txtTenLop.Clear();
            txtTimKiem.Clear();
        }

        public void SetMaLopEnabled(bool enabled)
        {
            txtMaLop.Enabled = enabled;
        }

        public void FocusMaLop()
        {
            txtMaLop.Focus();
        }

        public void FocusTenLop()
        {
            txtTenLop.Focus();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            _presenter?.AddLop();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            _presenter?.UpdateLop();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            _presenter?.DeleteLop();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            _presenter?.RefreshInput();
            _presenter?.LoadData();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            _presenter?.SearchLop();
        }

        private void dgvLop_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= dgvLop.Rows.Count) return;

            DataGridViewRow row = dgvLop.Rows[e.RowIndex];
            string maLop = row.Cells["MaLop"].Value?.ToString() ?? "";
            string tenLop = row.Cells["TenLop"].Value?.ToString() ?? "";

            _presenter?.SelectRow(maLop, tenLop);
        }

        private void dgvLop_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}