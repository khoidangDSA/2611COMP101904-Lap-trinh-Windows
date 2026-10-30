using System;
using System.Collections.Generic;
using EduManager.DAL;
using EduManager.Models;

namespace EduManager.BLL
{
    public class MonHocBLL
    {
        private readonly MonHocDAL _dal = new();

        public List<MonHoc> GetAllMonHoc() => _dal.GetAll();

        public List<MonHoc> SearchMonHoc(string keyword) => _dal.Search(keyword);

        public void AddMonHoc(MonHoc mh)
        {
            ValidateMonHoc(mh);

            if (_dal.GetById(mh.MaMonHoc) != null)
                throw new ArgumentException("Mã môn học đã tồn tại trong hệ thống!");

            if (!_dal.Add(mh))
                throw new Exception("Thêm môn học thất bại!");
        }

        public void UpdateMonHoc(MonHoc mh)
        {
            ValidateMonHoc(mh);

            if (_dal.GetById(mh.MaMonHoc) == null)
                throw new KeyNotFoundException("Không tìm thấy môn học cần cập nhật!");

            if (!_dal.Update(mh))
                throw new Exception("Cập nhật môn học thất bại!");
        }

        public void DeleteMonHoc(string maMonHoc)
        {
            if (string.IsNullOrWhiteSpace(maMonHoc))
                throw new ArgumentException("Mã môn học không được để trống!");

            if (_dal.GetById(maMonHoc) == null)
                throw new KeyNotFoundException("Mã môn học không tồn tại!");

            if (!_dal.Delete(maMonHoc))
                throw new Exception("Xóa môn học thất bại!");
        }

        private static void ValidateMonHoc(MonHoc mh)
        {
            if (string.IsNullOrWhiteSpace(mh.MaMonHoc))
                throw new ArgumentException("Mã môn học không được để trống!");

            if (string.IsNullOrWhiteSpace(mh.TenMonHoc))
                throw new ArgumentException("Tên môn học không được để trống!");

            // Khi gõ số < 1 hoặc > 6, đoạn này sẽ quăng lỗi để GUI hiện MessageBox
            if (mh.SoTinChi < 1 || mh.SoTinChi > 6)
                throw new ArgumentException("Số tín chỉ phải nằm trong khoảng từ 1 đến 6!");
        }
    }
}