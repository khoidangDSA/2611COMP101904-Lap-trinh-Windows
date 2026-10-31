using System.Collections.Generic;
using ClassManager.Models;

namespace ClassManager.Repositories
{
    public interface ILopRepository
    {
        List<Lop> GetAll();
        bool IsMaLopExists(string maLop);
        int CountSinhVienByLop(string maLop);
        bool Add(Lop lop);
        bool Update(Lop lop);
        bool Delete(string maLop);
        List<Lop> Search(string keyword);
    }
}