using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EduManager.Models
{
    [Table("MONHOC")]
    public class MonHoc
    {
        [Key]
        [StringLength(10)]
        public string MaMonHoc { get; set; } = null!;

        [Required]
        [StringLength(100)]
        public string TenMonHoc { get; set; } = null!;

        [Range(1, 6)]
        public int SoTinChi { get; set; }

        public bool TrangThai { get; set; } = true;
    }
}
