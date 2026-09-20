using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _16092026
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            List<NhanVien> danhSach = new List<NhanVien>();

            NhapDanhSachBanDau(danhSach);

            int chon = -1;
            do
            {
                Console.WriteLine("\n========== MENU ==========");
                Console.WriteLine("1. Xuất danh sách nhân viên");
                Console.WriteLine("2. Tìm nhân viên theo mã");
                Console.WriteLine("3. Tìm nhân viên có lương cao nhất");
                Console.WriteLine("4. Tính tổng lương công ty phải trả");
                Console.WriteLine("0. Thoát");
                Console.WriteLine("==========================");
                Console.Write("Lựa chọn của bạn: ");

                while (!int.TryParse(Console.ReadLine(), out chon))
                {
                    Console.Write("Vui lòng nhập số hợp lệ: ");
                }

                Console.WriteLine();

                switch (chon)
                {
                    case 1:
                        XuatDanhSach(danhSach);
                        break;

                    case 2:
                        TimTheoMa(danhSach);
                        break;

                    case 3:
                        TimLuongCaoNhat(danhSach);
                        break;

                    case 4:
                        TinhTongLuong(danhSach);
                        break;

                    case 0:
                        Console.WriteLine("Đã thoát chương trình.");
                        break;

                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ!");
                        break;
                }

            } while (chon != 0);
        }

        //Nhập ít nhất 5 nhân viên
        static void NhapDanhSachBanDau(List<NhanVien> danhSach)
        {
            Console.WriteLine("=== NHẬP DANH SÁCH NHÂN VIÊN BAN ĐẦU ===");
            Console.Write("Nhập số lượng nhân viên (tối thiểu 5): ");
            int n = 0;
            while (!int.TryParse(Console.ReadLine(), out n) || n < 5)
            {
                Console.Write("Số lượng phải >= 5. Vui lòng nhập lại: ");
            }

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"\n--- Nhập thông tin nhân viên thứ {i}/{n} ---");
                Console.WriteLine("1. Nhân viên Văn phòng");
                Console.WriteLine("2. Nhân viên Kinh doanh");
                Console.Write("Chọn loại (1 hoặc 2): ");

                int loai = 0;
                while (!int.TryParse(Console.ReadLine(), out loai) || (loai != 1 && loai != 2))
                {
                    Console.Write("Chỉ được chọn 1 (Văn phòng) hoặc 2 (Kinh doanh): ");
                }

                Console.Write("Nhập mã NV: ");
                string maNV = Console.ReadLine()?.Trim();

                Console.Write("Nhập họ tên: ");
                string hoTen = Console.ReadLine()?.Trim();

                double luongCB = NhapSoThucDuong("Nhập lương cơ bản (> 0): ");

                if (loai == 1) // Văn phòng
                {
                    int soNgay = (int)NhapSoThucTrongKhoang("Nhập số ngày làm việc (0 - 31): ", 0, 31);
                    danhSach.Add(new NhanVienVanPhong(maNV, hoTen, luongCB, soNgay));
                }
                else // Kinh doanh
                {
                    double doanhSo = NhapSoThucKhongAm("Nhập doanh số (>= 0): ");
                    danhSach.Add(new NhanVienKinhDoanh(maNV, hoTen, luongCB, doanhSo));
                }
            }

            Console.WriteLine("\n=> Nhập thành công! Mở menu điều khiển...\n");
        }

        // 1. XUẤT DANH SÁCH
        static void XuatDanhSach(List<NhanVien> danhSach)
        {
            Console.WriteLine("=== DANH SÁCH NHÂN VIÊN ===");
            foreach (NhanVien nv in danhSach)
            {
                nv.HienThiThongTin(); // Đa hình gọi HienThiThongTin()
                Console.WriteLine("-----------------------------------");
            }
        }

        // 2. TÌM THEO MÃ
        static void TimTheoMa(List<NhanVien> danhSach)
        {
            Console.Write("Nhập mã nhân viên cần tìm: ");
            string ma = Console.ReadLine()?.Trim();

            NhanVien nv = danhSach.FirstOrDefault(x => x.MaNV.Equals(ma, StringComparison.OrdinalIgnoreCase));

            if (nv != null)
            {
                Console.WriteLine("\n--- THÔNG TIN NHÂN VIÊN TÌM THẤY ---");
                nv.HienThiThongTin();
                Console.WriteLine("-----------------------------------");
            }
            else
            {
                Console.WriteLine($"Không tìm thấy nhân viên nào có mã: {ma}");
            }
        }

        // 3. TÌM LƯƠNG CAO NHẤT 
        static void TimLuongCaoNhat(List<NhanVien> danhSach)
        {
            double maxLuong = danhSach.Max(x => x.TinhLuong()); 
            var dsMax = danhSach.Where(x => x.TinhLuong() == maxLuong);

            Console.WriteLine($"=== NHÂN VIÊN CÓ LƯƠNG CAO NHẤT ({maxLuong:N0} VNĐ) ===");
            foreach (NhanVien nv in dsMax)
            {
                nv.HienThiThongTin();
                Console.WriteLine("-----------------------------------");
            }
        }

        // 4. TÍNH TỔNG LƯƠNG CÔNG TY PHẢI TRẢ
        static void TinhTongLuong(List<NhanVien> danhSach)
        {
            double tongLuong = danhSach.Sum(x => x.TinhLuong()); 
            Console.WriteLine($"=> Tổng lương công ty phải trả: {tongLuong:N0} VNĐ");
        }

        // Các hàm kiểm tra nhập dữ liệu an toàn
        static double NhapSoThucDuong(string thongBao)
        {
            double val;
            Console.Write(thongBao);
            while (!double.TryParse(Console.ReadLine(), out val) || val <= 0)
            {
                Console.Write("Phải nhập số > 0. Nhập lại: ");
            }
            return val;
        }

        static double NhapSoThucKhongAm(string thongBao)
        {
            double val;
            Console.Write(thongBao);
            while (!double.TryParse(Console.ReadLine(), out val) || val < 0)
            {
                Console.Write("Phải nhập số >= 0. Nhập lại: ");
            }
            return val;
        }

        static double NhapSoThucTrongKhoang(string thongBao, double min, double max)
        {
            double val;
            Console.Write(thongBao);
            while (!double.TryParse(Console.ReadLine(), out val) || val < min || val > max)
            {
                Console.Write($"Phải trong khoảng từ {min} đến {max}. Nhập lại: ");
            }
            return val;
        }
    }
}