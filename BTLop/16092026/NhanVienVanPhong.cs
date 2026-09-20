using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16092026
{
    internal class NhanVienVanPhong: NhanVien
    {
        private int soNgayLamViec;
        public NhanVienVanPhong(string maNV, string hoTen, double luongCoBan, int soNgayLamViec): base(maNV, hoTen, luongCoBan)
        {
            SoNgayLamViec = soNgayLamViec;
        }
        public int SoNgayLamViec
        {
            get { return soNgayLamViec; }
            set
            {
                if (value >= 0 && value <= 31)
                {
                    soNgayLamViec = value;
                }
                else Console.WriteLine("Số ngày làm việc phải từ 0 đến 31 ngày.");
            }
        }
        public override double TinhLuong()
        {
            return LuongCoBan + SoNgayLamViec * 200000;    
        }
        public override void HienThiThongTin()
        {
            base.HienThiThongTin();
            Console.WriteLine($"Số ngày làm việc: {SoNgayLamViec}");
            Console.WriteLine($"Lương được nhận: {TinhLuong()}");

        }
    }
}
