using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16092026
{
    internal class NhanVien
    {
        private string maNV;
        private string hoTen;
        private double luongCoBan;
        public NhanVien(string maNV, string hoTen,double luongCoBan)
        {
            MaNV = maNV;
            HoTen = hoTen;
            LuongCoBan = luongCoBan;
        }
        public string MaNV
        {
            get { return maNV; }
            set { maNV = value; }
        }

        public string HoTen
        {
            get { return hoTen; }
            set { hoTen = value; }
        }

        public double LuongCoBan
        {
            get { return luongCoBan; }

            set {
                if (value > 0) { luongCoBan = value; }
                else {
                    Console.WriteLine("Lương cơ bản phải > 0");
                }
            }
        }
        //Phương thức virtual tính lương
        public virtual double TinhLuong()
        {
            return luongCoBan;
        }
        // Phương thức virtual hiển thị thông tin
        public virtual void HienThiThongTin()
        {
            Console.WriteLine($"Mã Nhân viên: {MaNV}");
            Console.WriteLine($"Tên Nhân Viên: {HoTen}");
            Console.WriteLine($"Lương cơ bản: {LuongCoBan}");
        }
        

        
        
    }
}
