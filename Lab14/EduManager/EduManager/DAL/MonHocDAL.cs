using System.Collections.Generic;
using System.Linq;
using EduManager.Data;
using EduManager.Models;

namespace EduManager.DAL
{
    public class MonHocDAL
    {
        public List<MonHoc> GetAll()
        {
            using var db = new EduManagerContext();
            return db.MonHocs.ToList();
        }

        public MonHoc? GetById(string maMonHoc)
        {
            using var db = new EduManagerContext();
            return db.MonHocs.FirstOrDefault(m => m.MaMonHoc == maMonHoc);
        }

        public List<MonHoc> Search(string keyword)
        {
            using var db = new EduManagerContext();
            string kw = keyword.Trim().ToLower();
            return db.MonHocs
                     .Where(m => m.MaMonHoc.ToLower().Contains(kw) || m.TenMonHoc.ToLower().Contains(kw))
                     .ToList();
        }

        public bool Add(MonHoc monHoc)
        {
            using var db = new EduManagerContext();
            db.MonHocs.Add(monHoc);
            return db.SaveChanges() > 0;
        }

        public bool Update(MonHoc monHoc)
        {
            using var db = new EduManagerContext();
            var existing = db.MonHocs.FirstOrDefault(m => m.MaMonHoc == monHoc.MaMonHoc);
            if (existing == null) return false;

            existing.TenMonHoc = monHoc.TenMonHoc;
            existing.SoTinChi = monHoc.SoTinChi;
            existing.TrangThai = monHoc.TrangThai;

            return db.SaveChanges() > 0;
        }

        public bool Delete(string maMonHoc)
        {
            using var db = new EduManagerContext();
            var existing = db.MonHocs.FirstOrDefault(m => m.MaMonHoc == maMonHoc);
            if (existing == null) return false;

            db.MonHocs.Remove(existing);
            return db.SaveChanges() > 0;
        }
    }
}