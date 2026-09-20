using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16092026
{
    internal class NhanVienKinhDoanh : NhanVien
    {
        private double doanhSo;
        public NhanVienKinhDoanh(string maNV, string hoTen, double luongCoBan, double doanhSo): base(maNV, hoTen, luongCoBan)
        {
            DoanhSo = doanhSo;
        }

        public double DoanhSo
        {
            get { return doanhSo; }
            set
            {
                if (value >= 0)
                {
                    doanhSo = value;
                }
                else
                {
                    Console.WriteLine("Doanh số phải lớn hơn hoặc bằng 0.");
                }
            }
        }
        public override double TinhLuong()
        {
            return LuongCoBan + 0.05 * DoanhSo;
        }
        public override void HienThiThongTin()
        {
            base.HienThiThongTin();
            Console.WriteLine($"Doanh số: {DoanhSo}");
            Console.WriteLine($"Lương: {TinhLuong()}");
        }
    }
}
