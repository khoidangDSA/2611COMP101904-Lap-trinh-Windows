using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03
{
    internal class SinhVien : Nguoi
    {
        private string maSinhVien;
        private string maLop;
        private double diemTrungBinh;
        public string MaSinhVien
        {
            get { return maSinhVien; }
            set { maSinhVien = value; }
        }
        public double DiemTrungBinh
        {
            get { return diemTrungBinh; }

            set
            {
                if (value >= 0 && value <= 10) diemTrungBinh = value;
            }
        }
        public string MaLop
        {
            get { return maLop; }
            set { maLop = value; }
        }
        public SinhVien(string hoTen, DateTime ngaySinh, string maSinhVien, string maLop, double diemTrungBinh) : base(hoTen, ngaySinh)
        {
            MaSinhVien = maSinhVien;
            MaLop = maLop;
            DiemTrungBinh = diemTrungBinh;
        }
        public string XepLoai()
        {
            if (DiemTrungBinh >= 9) return "Xuất sắc";
            else if (DiemTrungBinh >= 8) return "Giỏi";
            else if (DiemTrungBinh >= 6.5) return "Khá";
            else if (DiemTrungBinh >= 5) return "Trung bình";
            else return "Yếu";
        }
        public override void LayThongTin()
        {
            Console.WriteLine($"Mã SV: {MaSinhVien} | " +
              $"Họ tên: {HoTen} | " + $"Ngày sinh: {NgaySinh:dd/MM/yyyy} | " +
              $"Lớp: {MaLop} | " + $"Điểm: {DiemTrungBinh:F1} | " +
              $"Xếp loại: {XepLoai()}");
        }
    }
}

