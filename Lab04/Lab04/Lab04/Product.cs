using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04
{
    internal class Product : IEntity
    {
        public int MaSP { get; private set; }
        public string TenSP { get; private set; }
        public double Price { get; private set; }
        public int Quantity { get; private set; }
        public string Id
        {
            get
            {
                return MaSP.ToString();
            }
        }
        public Product(int maSP,string tenSP,double price,int quantity)
        {
            MaSP = maSP;
            TenSP = tenSP;

            if(price>=0) Price = price;
            else Price = 0; // khi âm thì gán =0

            if(quantity>=0) Quantity = quantity;
            else Quantity = 0;
        }
        public override string ToString()
        {
            return $"Mã SP: {MaSP} - Tên SP: {TenSP} - Giá: {Price:N0} VNĐ - Số lượng: {Quantity}";
        }

    }
}
