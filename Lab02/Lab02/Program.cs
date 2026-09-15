using System;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;

            int[] a = null;
            int x;

            do
            {
                Menu();
                x = NhapSoNguyen("\nHãy lựa chọn chức năng: ");
                Console.WriteLine();

                // Kiểm tra chưa nhập mảng 
                if (x >= 2 && x <= 7 && a == null)
                {
                    Console.WriteLine(" Vui lòng nhập mảng trước! (Chức năng 1)\n");
                    continue;
                }

                switch (x)
                {
                    case 1:
                        a = NhapMang(); 
                        break;
                    case 2:
                        XuatMang(a);
                        break;
                    case 3:
                        Console.WriteLine($"Tổng các phần tử trong mảng: {TinhTong(a)}");
                        break;
                    case 4:
                        Console.WriteLine($"Giá trị lớn nhất là: {TimMax(a)}");
                        Console.WriteLine($"Giá trị nhỏ nhất là: {TimMin(a)}");
                        break;
                    case 5:
                        Console.WriteLine($"Số lượng phần tử chẵn là: {DemChan(a)}");
                        Console.WriteLine($"Số lượng phần tử lẻ là: {DemLe(a)}");
                        break;
                    case 6:
                        Console.Write("Mảng ban đầu: ");
                        XuatMang(a);
                        SapXepTangDan(a);
                        Console.WriteLine("Mảng sau khi sắp xếp tăng dần");
                        XuatMang(a);
                        break;
                    case 7:
                        Console.Write("Nhập giá trị x cần tìm: ");
                        int valuee;
                        while (!int.TryParse(Console.ReadLine(), out valuee))
                        {
                            Console.Write("Vui lòng nhập số nguyên hợp lệ: ");
                        }

                        int vt = TimKiem(a, valuee);
                        Console.WriteLine(vt != -1? $"Tìm thấy {valuee} tại vị trí chỉ số {vt}": $"Không tìm thấy {valuee} trong mảng.");
                        break;
                    case 0:
                        Console.WriteLine("Thoát chương trình.");
                        break;
                }
                Console.WriteLine("\n-------------------------------------------");
            } while (x != 0);
        }

        // Hàm hiển thị menu
        static void Menu()
        {
            Console.WriteLine("===== MENU =====");
            Console.WriteLine("1. Nhập mảng");
            Console.WriteLine("2. Xuất mảng");
            Console.WriteLine("3. Tính tổng");
            Console.WriteLine("4. Tìm giá trị lớn nhất và nhỏ nhất");
            Console.WriteLine("5. Đếm số lượng phần tử chẵn và lẻ");
            Console.WriteLine("6. Sắp xếp mảng theo thứ tự tăng dần");
            Console.WriteLine("7. Tìm kiếm một giá trị trong mảng");
            Console.WriteLine("0. Thoát");
        }

        // Hàm yêu cầu nhập số nguyên từ 0 đến 7
        static int NhapSoNguyen(string message)
        {
            int n;
            do
            {
                Console.Write(message);
                if (!int.TryParse(Console.ReadLine(), out n)|| n < 0 || n > 7)
                {
                    n = -1; // gán -1 để đánh dấu dữ liệu không hợp lệ
                    Console.WriteLine("Xin Vui lòng nhập một số nguyên từ 0 đến 7.");
                }
            } while (n < 0 || n > 7);

            return n;
        }

        // Hàm yêu cầu nhập số nguyên dương là số n của mảng
        static int NhapSoNguyenDuong(string message)
        {
            int n;
            do
            {
                Console.Write(message);
                if (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
                {
                    n = -1; // 
                    Console.WriteLine("Phần tử của mảng phải là một số nguyên dương");
                }
            }    while (n <= 0);
            return n;
        }

        // Hàm nhập mảng
        static int[] NhapMang()
        {
            int n = NhapSoNguyenDuong("Nhập số lượng phần tử cho mảng: ");
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Nhập phần tử thứ {i + 1}: ");
                while (!int.TryParse(Console.ReadLine(), out a[i]))
                {
                    Console.WriteLine("Vui lòng nhập một số nguyên hợp lệ.");
                    Console.Write($"Nhập phần tử thứ {i + 1}: ");
                }
            }
            return a;
        }


        // Hàm xuất mảng
        static void XuatMang(int[] a)
        {
            if (a == null || a.Length == 0)
            {
                Console.WriteLine("Mảng rỗng.");
                return;
            }

            // string.Join sẽ tự nối các số lại và chèn ", " vào giữa
            Console.WriteLine($"Các phần tử trong mảng là: [{string.Join(", ", a)}]");
        }
 
        static int TinhTong(int[] a)
        {
            int sum = 0;
            foreach(int num in a)
            {
                sum += num;
            }    
            return sum;
        }
        static int TimMax(int[] a)
        {
            int M = a[0];
            for(int i = 1;i<a.Length; i++)
            {
                if (M < a[i]) M = a[i];
            }
            return M;
        }
        static int TimMin(int[] a)
        {
            int m = a[0];
            for(int i=1;i<a.Length;i++)
            {
                if (m > a[i]) m = a[i];
            }    
            return m;
        }
        static int DemChan(int[] a)
        {
            int count=0;
            foreach (int num in a)
            {
                if (num % 2 == 0) count++;
            }
            return count;
        }
        static int DemLe(int[] a)
        {
           return a.Length - DemChan(a);
        }
        static void SapXepTangDan(int[] a)
        {
            Array.Sort(a);
        }
        
        // hàm tìm kiếm tuần tự
        static int TimKiem(int[] a, int x)
        {
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == x)
                    return i; 
            }
            return -1;

        }

    }
}