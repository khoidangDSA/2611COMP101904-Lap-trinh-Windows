using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using BaoCaoSinhVien.Models;

namespace BaoCaoSinhVien
{
    public partial class FrmBaoCaoSinhVien : Form
    {
        private List<SinhVien> danhSachSinhVien = new List<SinhVien>();
        public FrmBaoCaoSinhVien()
        {
            InitializeComponent();
        }

        private void FrmBaoCaoSinhVien_Load(object sender, EventArgs e)
        {
            TaoDuLieuMau();
            LoadComboBox();
            XemBaoCao();
        }
        // 1. Tạo dữ liệu mẫu (ít nhất 12 SV, 3 lớp)
        private void TaoDuLieuMau()
        {
            danhSachSinhVien = new List<SinhVien>
            {
                new SinhVien { MaSV = "SV001", HoTen = "Mai Minh Tiến", MaLop = "CTK47A", TenLop = "CNTT K47A", Diem = 8.2 },
                new SinhVien { MaSV = "SV002", HoTen = "Đặng Nguyên Khôi", MaLop = "CTK47A", TenLop = "CNTT K47A", Diem = 10 },
                new SinhVien { MaSV = "SV003", HoTen = "Đặng Ngọc Tuyết Anh", MaLop = "CTK47A", TenLop = "CNTT K47A", Diem = 4.8 },
                new SinhVien { MaSV = "SV004", HoTen = "Đoàn Tuấn Khôi", MaLop = "CTK47A", TenLop = "CNTT K47A", Diem = 9.1 },
                new SinhVien { MaSV = "SV005", HoTen = "Trương Hoàng Gia Huy", MaLop = "CTK47B", TenLop = "CNTT K47B", Diem = 7.4 },
                new SinhVien { MaSV = "SV006", HoTen = "Nguyễn Thái An Khang", MaLop = "CTK47B", TenLop = "CNTT K47B", Diem = 3.9 },
                new SinhVien { MaSV = "SV007", HoTen = "Huỳnh Đăng Khoa", MaLop = "CTK47B", TenLop = "CNTT K47B", Diem = 5.5 },
                new SinhVien { MaSV = "SV008", HoTen = "Lê Minh Tuấn", MaLop = "CTK47B", TenLop = "CNTT K47B", Diem = 8.0 },
                new SinhVien { MaSV = "SV009", HoTen = "Ngô Tuấn Minh", MaLop = "CTK48A", TenLop = "CNTT K48A", Diem = 6.0 },
                new SinhVien { MaSV = "SV010", HoTen = "Nguyễn Minh Chiến", MaLop = "CTK48A", TenLop = "CNTT K48A", Diem = 9.3 },
                new SinhVien { MaSV = "SV011", HoTen = "Đỗ Nguyễn Duy Khang", MaLop = "CTK48A", TenLop = "CNTT K48A", Diem = 4.2 },
                new SinhVien { MaSV = "SV012", HoTen = "Lê Gia Bảo", MaLop = "CTK48A", TenLop = "CNTT K48A", Diem = 7.8 }
            };
        }
        // 2. Load dữ liệu vào cboLop và cboKetQua
        private void LoadComboBox()
        {
            var dsLop = danhSachSinhVien
                .Select(sv => new { sv.MaLop, sv.TenLop })
                .Distinct()
                .OrderBy(l => l.MaLop)
                .ToList();

            cboLop.DataSource = dsLop;
            cboLop.DisplayMember = "TenLop";
            cboLop.ValueMember = "MaLop";

            cboKetQua.Items.Clear();
            cboKetQua.Items.Add("Tất cả");
            cboKetQua.Items.Add("Đạt");
            cboKetQua.Items.Add("Không đạt");
            cboKetQua.SelectedIndex = 0;
        }
        // 3. Chức năng Lọc dữ liệu bằng LINQ
        private void XemBaoCao()
        {
            if (cboLop.SelectedValue == null) return;

            string maLop = cboLop.SelectedValue.ToString();
            string ketQua = cboKetQua.SelectedItem?.ToString() ?? "Tất cả";
            string tuKhoa = txtTuKhoa.Text.Trim().ToLower();

            var query = danhSachSinhVien.Where(sv => sv.MaLop == maLop);

            if (ketQua == "Đạt")
            {
                query = query.Where(sv => sv.Diem >= 5);
            }
            else if (ketQua == "Không đạt")
            {
                query = query.Where(sv => sv.Diem < 5);
            }

            // Kiểm tra từ khóa (tránh bị dính chữ gợi ý)
            if (!string.IsNullOrWhiteSpace(tuKhoa) && tuKhoa != "nhập mã sv hoặc họ tên...")
            {
                query = query.Where(sv =>
                    sv.MaSV.ToLower().Contains(tuKhoa) ||
                    sv.HoTen.ToLower().Contains(tuKhoa));
            }

            var baoCao = query
                .OrderByDescending(sv => sv.Diem)
                .ThenBy(sv => sv.HoTen)
                .Select(sv => new
                {
                    sv.MaSV,
                    sv.HoTen,
                    sv.TenLop,
                    sv.Diem,
                    sv.KetQua
                })
                .ToList();

            dgvBaoCao.DataSource = baoCao;
            CapNhatThongKe(baoCao.Count);
            dgvBaoCao.DataSource = baoCao;
            DinhDangBangBaoCao();
            CapNhatThongKe(baoCao.Count);
        }
        // 4. Cập nhật nhãn thống kê phía dưới
        private void CapNhatThongKe(int soDongHienThi)
        {
            string maLop = cboLop.SelectedValue?.ToString() ?? "";
            var dsLop = danhSachSinhVien.Where(sv => sv.MaLop == maLop).ToList();

            int tongSo = dsLop.Count;
            int soDat = dsLop.Count(sv => sv.Diem >= 5);
            int soKhongDat = dsLop.Count(sv => sv.Diem < 5);
            double diemTB = tongSo > 0 ? dsLop.Average(sv => sv.Diem) : 0;

            lblThongKe.Text = $"Đang hiển thị: {soDongHienThi} | Tổng lớp: {tongSo} | Đạt: {soDat} | Không đạt: {soKhongDat} | Điểm TB: {diemTB:0.00}";
        }

        private void btnXemBaoCao_Click(object sender, EventArgs e)
        {
            XemBaoCao();
            if (dgvBaoCao.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu phù hợp.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            var thongKe = danhSachSinhVien
                .GroupBy(sv => new { sv.MaLop, sv.TenLop })
                .Select(g => new
                {
                    MaLop = g.Key.MaLop,
                    TenLop = g.Key.TenLop,
                    SoLuong = g.Count(),
                    SoDat = g.Count(sv => sv.Diem >= 5),
                    SoKhongDat = g.Count(sv => sv.Diem < 5),
                    DiemTrungBinh = Math.Round(g.Average(sv => sv.Diem), 2)
                })
                .OrderBy(x => x.MaLop)
                .ToList();

            // Gán dữ liệu
            dgvBaoCao.DataSource = thongKe;

            // Định dạng tiêu đề cột tiếng Việt
            DinhDangBangThongKe();

            // Cập nhật nhãn trạng thái
            lblThongKe.Text = "Thống kê tổng hợp theo tất cả các lớp trong hệ thống.";
        }

        private void btnXuatFile_Click(object sender, EventArgs e)
        {
            if (dgvBaoCao.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để xuất.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "CSV file (*.csv)|*.csv|Text file (*.txt)|*.txt";
                sfd.FileName = "BaoCaoSinhVien.csv";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        StringBuilder sb = new StringBuilder();

                        // Xuất tiêu đề cột
                        for (int i = 0; i < dgvBaoCao.Columns.Count; i++)
                        {
                            sb.Append(dgvBaoCao.Columns[i].HeaderText);
                            if (i < dgvBaoCao.Columns.Count - 1) sb.Append(",");
                        }
                        sb.AppendLine();

                        // Xuất dòng dữ liệu
                        foreach (DataGridViewRow row in dgvBaoCao.Rows)
                        {
                            if (row.IsNewRow) continue;

                            for (int i = 0; i < dgvBaoCao.Columns.Count; i++)
                            {
                                string val = row.Cells[i].Value?.ToString() ?? "";
                                val = val.Replace(",", " "); // Tránh lỗi chia ô trong CSV
                                sb.Append(val);
                                if (i < dgvBaoCao.Columns.Count - 1) sb.Append(",");
                            }
                            sb.AppendLine();
                        }

                        File.WriteAllText(sfd.FileName, sb.ToString(), Encoding.UTF8);
                        MessageBox.Show("Xuất file báo cáo thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi xuất file: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void cboLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboLop.SelectedValue != null)
            {
                XemBaoCao();
            }
        }

        private void cboKetQua_SelectedIndexChanged(object sender, EventArgs e)
        {
            XemBaoCao();
        }

        private void txtTuKhoa_TextChanged(object sender, EventArgs e)
        {
            XemBaoCao();
        }
        // 1. Định dạng tiêu đề và lề cho bảng Xem báo cáo
        private void DinhDangBangBaoCao()
        {
            if (dgvBaoCao.Columns["MaSV"] != null) dgvBaoCao.Columns["MaSV"].HeaderText = "Mã sinh viên";
            if (dgvBaoCao.Columns["HoTen"] != null) dgvBaoCao.Columns["HoTen"].HeaderText = "Họ và tên";
            if (dgvBaoCao.Columns["TenLop"] != null) dgvBaoCao.Columns["TenLop"].HeaderText = "Tên lớp";
            if (dgvBaoCao.Columns["Diem"] != null) dgvBaoCao.Columns["Diem"].HeaderText = "Điểm trung bình";
            if (dgvBaoCao.Columns["KetQua"] != null) dgvBaoCao.Columns["KetQua"].HeaderText = "Kết quả";

            // Tự động dãn full chiều rộng DataGridView
            dgvBaoCao.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Chọn nguyên dòng khi click
            dgvBaoCao.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBaoCao.ReadOnly = true;
            dgvBaoCao.AllowUserToAddRows = false;
        }

        // 2. Định dạng tiêu đề cho bảng Thống kê
        private void DinhDangBangThongKe()
        {
            if (dgvBaoCao.Columns["MaLop"] != null) dgvBaoCao.Columns["MaLop"].HeaderText = "Mã lớp";
            if (dgvBaoCao.Columns["TenLop"] != null) dgvBaoCao.Columns["TenLop"].HeaderText = "Tên lớp";
            if (dgvBaoCao.Columns["SoLuong"] != null) dgvBaoCao.Columns["SoLuong"].HeaderText = "Số lượng SV";
            if (dgvBaoCao.Columns["SoDat"] != null) dgvBaoCao.Columns["SoDat"].HeaderText = "Số đạt";
            if (dgvBaoCao.Columns["SoKhongDat"] != null) dgvBaoCao.Columns["SoKhongDat"].HeaderText = "Số không đạt";
            if (dgvBaoCao.Columns["DiemTrungBinh"] != null) dgvBaoCao.Columns["DiemTrungBinh"].HeaderText = "Điểm TB lớp";

            dgvBaoCao.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
