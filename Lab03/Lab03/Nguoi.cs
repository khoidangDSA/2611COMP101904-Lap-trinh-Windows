using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03
{
    internal class Nguoi
    {
        private string hoTen;
        private DateTime ngaySinh;

        public string HoTen
        {
            get { return hoTen; }
            set { hoTen = value; }
        }

        public DateTime NgaySinh
        {
            get { return ngaySinh; }
            set { ngaySinh = value; }
        }

        public Nguoi(string _hoTen, DateTime _ngaySinh)
        {
            hoTen = _hoTen;
            ngaySinh = _ngaySinh;
        }

        public virtual void LayThongTin()
        {
            Console.WriteLine($"Họ tên: {hoTen} | Ngày sinh: {ngaySinh:dd/MM/yyyy}");
        }
    }
}