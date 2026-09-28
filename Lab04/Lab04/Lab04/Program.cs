// See https://aka.ms/new-console-template for more information
using System.Text;

namespace Lab04
{
    internal class Program
    {
        static ProductService service = new ProductService();

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            service.ProductChanged += ProductChangedHandler;

            int choice;

            do
            {
                Console.WriteLine();
                Console.WriteLine("===== PRODUCT MANAGER =====");
                Console.WriteLine("1. Them san pham");
                Console.WriteLine("2. Xuat danh sach");
                Console.WriteLine("3. Tim theo ma");
                Console.WriteLine("4. Tim theo ten");
                Console.WriteLine("5. Loc theo khoang gia");
                Console.WriteLine("6. Xoa san pham");
                Console.WriteLine("7. Tinh tong gia tri kho");
                Console.WriteLine("0. Thoat");
                Console.Write("Chon: ");

                try
                {
                    choice = int.Parse(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            ThemSanPham();
                            break;

                        case 2:
                            XuatDanhSach();
                            break;

                        case 3:
                            TimTheoMa();
                            break;

                        case 4:
                            TimTheoTen();
                            break;

                        case 5:
                            LocTheoGia();
                            break;

                        case 6:
                            XoaSanPham();
                            break;

                        case 7:
                            TinhTongGiaTriKho();
                            break;

                        case 0:
                            Console.WriteLine("Ket thuc chuong trinh.");
                            break;

                        default:
                            Console.WriteLine("Lua chon khong hop le.");
                            break;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Du lieu nhap khong hop le.");
                    choice = -1;
                }
                catch (DuplicateProductException ex)
                {
                    Console.WriteLine("Loi: " + ex.Message);
                    choice = -1;
                }
                catch (ProductNotFoundException ex)
                {
                    Console.WriteLine("Loi: " + ex.Message);
                    choice = -1;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Loi: " + ex.Message);
                    choice = -1;
                }

            } while (choice != 0);
        }

        // Event
        static void ProductChangedHandler(string message)
        {
            Console.WriteLine("[EVENT] " + message);
        }

        // 1. Thêm sản phẩm
        static void ThemSanPham()
        {
            Console.Write("Nhap ma san pham: ");
            int maSP = int.Parse(Console.ReadLine());

            Console.Write("Nhap ten san pham: ");
            string tenSP = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(tenSP))
            {
                Console.WriteLine("Ten san pham khong duoc rong.");
                return;
            }

            Console.Write("Nhap don gia: ");
            double price = double.Parse(Console.ReadLine());

            if (price < 0)
            {
                Console.WriteLine("Don gia khong duoc am.");
                return;
            }

            Console.Write("Nhap so luong: ");
            int quantity = int.Parse(Console.ReadLine());

            if (quantity < 0)
            {
                Console.WriteLine("So luong khong duoc am.");
                return;
            }

            Product product = new Product(
                maSP,
                tenSP,
                price,
                quantity
            );

            service.AddProduct(product);
        }

        // 2. Xuất danh sách
        static void XuatDanhSach()
        {
            List<Product> danhSach = service.GetAll();

            if (danhSach.Count == 0)
            {
                Console.WriteLine("Danh sach san pham dang rong.");
                return;
            }

            foreach (Product product in danhSach)
            {
                Console.WriteLine(product);
            }
        }

        // 3. Tìm theo mã
        static void TimTheoMa()
        {
            Console.Write("Nhap ma san pham: ");
            string maSP = Console.ReadLine();

            Product product = service.SearchById(maSP);

            if (product == null)
            {
                Console.WriteLine("Khong tim thay san pham.");
            }
            else
            {
                Console.WriteLine(product);
            }
        }

        // 4. Tìm theo tên
        static void TimTheoTen()
        {
            Console.Write("Nhap tu khoa: ");
            string keyword = Console.ReadLine();

            List<Product> ketQua = service.Search(keyword);

            if (ketQua.Count == 0)
            {
                Console.WriteLine("Khong tim thay san pham.");
                return;
            }

            foreach (Product product in ketQua)
            {
                Console.WriteLine(product);
            }
        }

        // 5. Lọc theo khoảng giá
        static void LocTheoGia()
        {
            Console.Write("Nhap gia nho nhat: ");
            double minPrice = double.Parse(Console.ReadLine());

            Console.Write("Nhap gia lon nhat: ");
            double maxPrice = double.Parse(Console.ReadLine());

            if (minPrice < 0 || maxPrice < 0)
            {
                Console.WriteLine("Gia khong duoc am.");
                return;
            }

            if (minPrice > maxPrice)
            {
                Console.WriteLine("Gia nho nhat phai <= gia lon nhat.");
                return;
            }

            List<Product> ketQua =
                service.Filter(minPrice, maxPrice);

            if (ketQua.Count == 0)
            {
                Console.WriteLine("Khong co san pham phu hop.");
                return;
            }

            foreach (Product product in ketQua)
            {
                Console.WriteLine(product);
            }
        }

        // 6. Xóa sản phẩm
        static void XoaSanPham()
        {
            Console.Write("Nhap ma san pham can xoa: ");
            string maSP = Console.ReadLine();

            service.RemoveProduct(maSP);
        }

        // 7. Tính tổng giá trị kho
        static void TinhTongGiaTriKho()
        {
            double tong = service.GetTotalValue();

            Console.WriteLine(
                $"Tong gia tri kho: {tong:N0} VNĐ"
            );
        }
    }
}