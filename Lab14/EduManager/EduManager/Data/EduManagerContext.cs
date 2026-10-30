using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using EduManager.Models;

namespace EduManager.Data
{
    public class EduManagerContext : DbContext
    {
        public DbSet<MonHoc> MonHocs { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                
                optionsBuilder.UseSqlServer(@"Server=localhost,1433;Database=EduManagerDB_V2;User Id=sa;Password=YourPassword123!;TrustServerCertificate=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MonHoc>(entity =>
            {
                entity.HasKey(e => e.MaMonHoc);
                entity.Property(e => e.TrangThai).HasDefaultValue(true);
            });
        }
    }
}
