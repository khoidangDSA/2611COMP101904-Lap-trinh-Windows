using System;
using System.Text;

namespace Lab03
{
    internal class Program
    {
        static QuanLySinhVien quanLy = new QuanLySinhVien();
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            int chon;

            do
            {
                HienThiMenu();
                Console.Write("Nhập lựa chọn: ");

                if (!int.TryParse(Console.ReadLine(), out chon))
                {
                    Console.WriteLine("Lựa chọn không hợp lệ!");
                    continue;
                }

                switch (chon)
                {
                    case 1:
                        ThemSinhVien();
                        break;

                    case 2:
                        HienThiDanhSach();
                        break;

                    case 3:
                        TimTheoMa();
                        break;

                    case 4:
                        TimTheoTen();
                        break;

                    case 5:
                        SuaDiem();
                        break;

                    case 6:
                        XoaSinhVien();
                        break;

                    case 7:
                        SapXepTheoDiem();
                        break;

                    case 8:
                        LocSinhVienDat();
                        break;

                    case 0:
                        Console.WriteLine("Đã thoát chương trình.");
                        break;

                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ!");
                        break;
                }

                Console.WriteLine();

            } while (chon != 0);
        }

        static void HienThiMenu()
        {
            Console.WriteLine("========== QUẢN LÝ SINH VIÊN ==========");
            Console.WriteLine("1. Thêm sinh viên");
            Console.WriteLine("2. Hiển thị danh sách sinh viên");
            Console.WriteLine("3. Tìm sinh viên theo mã");
            Console.WriteLine("4. Tìm sinh viên theo tên");
            Console.WriteLine("5. Sửa điểm trung bình");
            Console.WriteLine("6. Xóa sinh viên");
            Console.WriteLine("7. Sắp xếp theo điểm giảm dần");
            Console.WriteLine("8. Lọc sinh viên đạt");
            Console.WriteLine("0. Thoát");
            Console.WriteLine("========================================");
        }

        static void ThemSinhVien()
        {
            Console.WriteLine("\n--- THÊM SINH VIÊN ---");

            Console.Write("Nhập mã sinh viên: ");
            string maSinhVien = Console.ReadLine();

            Console.Write("Nhập họ tên: ");
            string hoTen = Console.ReadLine();

            DateTime ngaySinh = NhapNgaySinh();

            Console.Write("Nhập mã lớp: ");
            string maLop = Console.ReadLine();

            double diemTrungBinh = NhapDiem();

            SinhVien sinhVien = new SinhVien(
              hoTen,
              ngaySinh,
              maSinhVien,
              maLop,
              diemTrungBinh
            );

            Console.WriteLine(quanLy.Them(sinhVien) ? "Thêm sinh viên thành công!" : "Mã sinh viên đã tồn tại!");

        }

        static DateTime NhapNgaySinh()
        {
            DateTime ngaySinh;

            while (true)
            {
                Console.Write("Nhập ngày sinh (dd/MM/yyyy): ");

                if (DateTime.TryParse(Console.ReadLine(), out ngaySinh)) return ngaySinh;

                Console.WriteLine("Ngày sinh không hợp lệ, hãy nhập lại!");
            }
        }

        static double NhapDiem()
        {
            double diem;

            while (true)
            {
                Console.Write("Nhập điểm trung bình (0 - 10): ");

                if (double.TryParse(Console.ReadLine(), out diem))
                {
                    if (diem >= 0 && diem <= 10) return diem;

                }
                Console.WriteLine("Điểm phải nằm trong khoảng từ 0 đến 10!");
            }
        }

        static void HienThiDanhSach()
        {
            Console.WriteLine("\n--- DANH SÁCH SINH VIÊN ---");

            if (quanLy.LayDanhSach().Count == 0)
            {
                Console.WriteLine("Danh sách sinh viên đang trống!");
                return;
            }

            for (int i = 0; i < quanLy.LayDanhSach().Count; i++)
            {
                quanLy.LayDanhSach()[i].LayThongTin();
            }
        }

        static void TimTheoMa()
        {
            Console.WriteLine("\n--- TÌM SINH VIÊN THEO MÃ ---");

            Console.Write("Nhập mã sinh viên cần tìm: ");
            string maSinhVien = Console.ReadLine();

            SinhVien sinhVien = quanLy.TimTheoMa(maSinhVien);

            if (sinhVien == null) Console.WriteLine("Không tìm thấy sinh viên!");

            else sinhVien.LayThongTin();

        }

        static void TimTheoTen()
        {
            Console.WriteLine("\n--- TÌM SINH VIÊN THEO TÊN ---");

            Console.Write("Nhập tên cần tìm: ");
            string tuKhoa = Console.ReadLine();

            var ketQua = quanLy.TimTheoTen(tuKhoa);

            if (ketQua.Count == 0)
            {
                Console.WriteLine("Không tìm thấy sinh viên!");
                return;
            }

            for (int i = 0; i < ketQua.Count; i++)
            {
                ketQua[i].LayThongTin();
            }
        }

        static void SuaDiem()
        {
            Console.WriteLine("\n--- SỬA ĐIỂM ---");

            Console.Write("Nhập mã sinh viên: ");
            string maSinhVien = Console.ReadLine();

            SinhVien sinhVien = quanLy.TimTheoMa(maSinhVien);

            if (sinhVien == null)
            {
                Console.WriteLine("Không tìm thấy sinh viên!");
                return;
            }

            double diemMoi = NhapDiem();

            Console.WriteLine(quanLy.Sua(maSinhVien, diemMoi) ? "Sửa điểm thành công!" : "Sửa điểm thất bại!");
        }

        static void XoaSinhVien()
        {
            Console.WriteLine("\n--- XÓA SINH VIÊN ---");

            Console.Write("Nhập mã sinh viên cần xóa: ");
            string maSinhVien = Console.ReadLine();
            Console.WriteLine(quanLy.Xoa(maSinhVien) ? "Xóa sinh viên thành công!" : "Không tìm thấy sinh viên!");

        }

        static void SapXepTheoDiem()
        {
            Console.WriteLine("\n--- SẮP XẾP THEO ĐIỂM GIẢM DẦN ---");

            if (quanLy.LayDanhSach().Count == 0)
            {
                Console.WriteLine("Danh sách sinh viên đang trống!");
                return;
            }

            quanLy.SapXepTheoDiem();

            for (int i = 0; i < quanLy.LayDanhSach().Count; i++)
            {
                quanLy.LayDanhSach()[i].LayThongTin();
            }
        }

        static void LocSinhVienDat()
        {
            Console.WriteLine("\n--- SINH VIÊN ĐẠT ---");

            var ketQua = quanLy.LocSinhVienDat();

            if (ketQua.Count == 0)
            {
                Console.WriteLine("Không có sinh viên đạt!");
                return;
            }

            for (int i = 0; i < ketQua.Count; i++)
            {
                ketQua[i].LayThongTin();
            }
        }
    }
}
