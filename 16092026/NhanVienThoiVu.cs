using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16092026
{
    internal class NhanVienThoiVu : NhanVien
    {
        private int soGioLam;
        private double luongTheoGio;

        public NhanVienThoiVu(string maNV, string hoTen,double luongCoBan, int soGioLam, double luongTheoGio)
            : base(maNV, hoTen, luongCoBan)
        {
            SoGioLam = soGioLam;
            LuongTheoGio = luongTheoGio;
        }
        public int SoGioLam
        {
            get { return soGioLam; }
            set
            {
                if (value >= 0) soGioLam = value;
                else Console.WriteLine("Số giờ làm phải lớn hơn hoặc bằng 0.");
            }
        }
        public double LuongTheoGio
        {
            get { return luongTheoGio; }
            set
            {
                if (value > 0) luongTheoGio = value;
                else Console.WriteLine("Lương theo giờ phải lớn hơn hoặc bằng 0.");
            }
        }
        public override double TinhLuong()
        {
            return SoGioLam * LuongTheoGio;
        }
        public override void HienThiThongTin()
        {
            base.HienThiThongTin(); 
            Console.WriteLine($"Số giờ làm: {SoGioLam}"); 
            Console.WriteLine($"Lương theo giờ: {LuongTheoGio}"); 
            Console.WriteLine($"Lương: {TinhLuong()}");
        }
    }
}
