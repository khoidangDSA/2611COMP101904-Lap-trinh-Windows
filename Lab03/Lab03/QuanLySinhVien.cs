using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03
{
    internal class QuanLySinhVien
    {
        private List<SinhVien> danhSachSV;
        public QuanLySinhVien()
        {
            danhSachSV = new List<SinhVien>();
        }

        public bool Them(SinhVien sinhVien)
        { // Kiểm tra mã sinh viên đã tồn tại chưa
            for (int i = 0; i < danhSachSV.Count; i++)
            {
                if (danhSachSV[i].MaSinhVien == sinhVien.MaSinhVien)
                {
                    return false;
                }
            }
            danhSachSV.Add(sinhVien);
            return true;
        }
        public List<SinhVien> LayDanhSach()
        {
            return danhSachSV;
        }
        public SinhVien TimTheoMa(string maSinhVien)
        {
            for (int i = 0; i < danhSachSV.Count; i++)
            {
                if (danhSachSV[i].MaSinhVien == maSinhVien)
                {
                    return danhSachSV[i];
                }
            }

            return null;
        }
        public List<SinhVien> TimTheoTen(string tuKhoa)  //LINQ
        {
            return danhSachSV.Where(sv => sv.HoTen.ToLower().Contains(tuKhoa.ToLower())).ToList();
        }
        public bool Sua(string maSinhVien, double diemMoi)
        {
            SinhVien sinhVien = TimTheoMa(maSinhVien);
            if (sinhVien == null) return false;
            sinhVien.DiemTrungBinh = diemMoi;
            return true;
        }
        public bool Xoa(string maSinhVien)
        {
            SinhVien sinhVien = TimTheoMa(maSinhVien);
            if (sinhVien == null) return false;
            danhSachSV.Remove(sinhVien);
            return true;
        }

        public List<SinhVien> SapXepTheoDiem()
        {
            for (int i = 0; i < danhSachSV.Count - 1; i++)
            {
                for (int j = i + 1; j < danhSachSV.Count; j++)
                {
                    if (danhSachSV[i].DiemTrungBinh < danhSachSV[j].DiemTrungBinh)
                    {
                        SinhVien temp = danhSachSV[i];
                        danhSachSV[i] = danhSachSV[j];
                        danhSachSV[j] = temp;
                    }
                }
            }

            return danhSachSV;
        }
        public List<SinhVien> LocSinhVienDat()
        {
            List<SinhVien> ketQua = new List<SinhVien>();

            for (int i = 0; i < danhSachSV.Count; i++)
            {
                if (danhSachSV[i].DiemTrungBinh >= 5)
                {
                    ketQua.Add(danhSachSV[i]);
                }
            }

            return ketQua;
        }


    }

}

