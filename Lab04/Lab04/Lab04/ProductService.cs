using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04
{
    internal class ProductService
    {
        private Repository<Product> repository = new Repository<Product>();

        public event Action<string> ProductChanged;

        // Thêm sản phẩm
        public void AddProduct(Product product)
        {
            Product sanPham = repository.FindById(product.Id);

            if (sanPham != null)
            {
                throw new DuplicateProductException(
                    "Mã sản phẩm đã bị trùng!"
                );
            }

            repository.Add(product);

            ProductChanged?.Invoke("Thêm sản phẩm thành công.");
        }

        // Xóa sản phẩm
        public void RemoveProduct(string maSP)
        {
            Product product = repository.FindById(maSP);

            if (product == null)
            {
                throw new ProductNotFoundException(
                    "Không tìm thấy sản phẩm cần xóa!"
                );
            }

            repository.Remove(product);

            ProductChanged?.Invoke("Xóa sản phẩm thành công.");
        }

        // Tìm theo mã
        public Product SearchById(string maSP)
        {
            return repository.FindById(maSP);
        }

        // Tìm theo tên
        public List<Product> Search(string keyword)
        {
            return repository.Find(product =>
                product.TenSP.ToLower().Contains(keyword.ToLower()));
        }

        // Lọc theo khoảng giá
        public List<Product> Filter(double minPrice, double maxPrice)
        {
            Func<Product, bool> dieuKien = product =>
                product.Price >= minPrice &&
                product.Price <= maxPrice;

            return repository.Find(dieuKien);
        }

        // Lấy toàn bộ sản phẩm
        public List<Product> GetAll()
        {
            return repository.GetAll();
        }

        // Tính tổng giá trị kho
        public double GetTotalValue()
        {
            double tong = 0;

            foreach (Product product in repository.GetAll())
            {
                tong += product.Price * product.Quantity;
            }

            return tong;
        }
    }
}