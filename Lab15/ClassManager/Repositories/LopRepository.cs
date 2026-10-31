using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using ClassManager.Models;

namespace ClassManager.Repositories
{
    public class LopRepository : ILopRepository
    {
        private readonly string connectionString =
            @"Server=localhost,1433;Database=EduManagerDB;User Id=sa;Password=YourPassword123!;TrustServerCertificate=True";

        public List<Lop> GetAll()
        {
            List<Lop> list = new List<Lop>();
            string sql = @"SELECT l.MaLop, l.TenLop, 
                                  COUNT(sv.MaSV) AS SoSinhVien 
                           FROM LOP l 
                           LEFT JOIN SINHVIEN sv ON l.MaLop = sv.MaLop 
                           GROUP BY l.MaLop, l.TenLop 
                           ORDER BY l.MaLop";

            using SqlConnection conn = new SqlConnection(connectionString);
            using SqlCommand cmd = new SqlCommand(sql, conn);
            conn.Open();
            using SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                list.Add(new Lop
                {
                    MaLop = reader["MaLop"].ToString() ?? "",
                    TenLop = reader["TenLop"].ToString() ?? "",
                    SoSinhVien = Convert.ToInt32(reader["SoSinhVien"])
                });
            }
            return list;
        }

        public bool IsMaLopExists(string maLop)
        {
            string sql = "SELECT COUNT(*) FROM LOP WHERE MaLop = @ma";
            using SqlConnection conn = new SqlConnection(connectionString);
            using SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@ma", maLop);

            conn.Open();
            return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
        }

        public int CountSinhVienByLop(string maLop)
        {
            string sql = "SELECT COUNT(*) FROM SINHVIEN WHERE MaLop = @ma";
            using SqlConnection conn = new SqlConnection(connectionString);
            using SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@ma", maLop);

            conn.Open();
            return Convert.ToInt32(cmd.ExecuteScalar());
        }

        public bool Add(Lop lop)
        {
            string sql = "INSERT INTO LOP(MaLop, TenLop) VALUES(@ma, @ten)";
            using SqlConnection conn = new SqlConnection(connectionString);
            using SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@ma", lop.MaLop);
            cmd.Parameters.AddWithValue("@ten", lop.TenLop);

            conn.Open();
            return cmd.ExecuteNonQuery() > 0;
        }

        public bool Update(Lop lop)
        {
            string sql = "UPDATE LOP SET TenLop = @ten WHERE MaLop = @ma";
            using SqlConnection conn = new SqlConnection(connectionString);
            using SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@ma", lop.MaLop);
            cmd.Parameters.AddWithValue("@ten", lop.TenLop);

            conn.Open();
            return cmd.ExecuteNonQuery() > 0;
        }

        public bool Delete(string maLop)
        {
            string sql = "DELETE FROM LOP WHERE MaLop = @ma";
            using SqlConnection conn = new SqlConnection(connectionString);
            using SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@ma", maLop);

            conn.Open();
            return cmd.ExecuteNonQuery() > 0;
        }

        public List<Lop> Search(string keyword)
        {
            List<Lop> list = new List<Lop>();
            string sql = @"SELECT l.MaLop, l.TenLop, 
                                  COUNT(sv.MaSV) AS SoSinhVien 
                           FROM LOP l 
                           LEFT JOIN SINHVIEN sv ON l.MaLop = sv.MaLop 
                           WHERE l.MaLop LIKE @kw OR l.TenLop LIKE @kw 
                           GROUP BY l.MaLop, l.TenLop 
                           ORDER BY l.MaLop";

            using SqlConnection conn = new SqlConnection(connectionString);
            using SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@kw", "%" + keyword + "%");

            conn.Open();
            using SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                list.Add(new Lop
                {
                    MaLop = reader["MaLop"].ToString() ?? "",
                    TenLop = reader["TenLop"].ToString() ?? "",
                    SoSinhVien = Convert.ToInt32(reader["SoSinhVien"])
                });
            }
            return list;
        }
    }
}