using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLyNhanVienAsp.Models
{
    public class NhanVien
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int idNhanVien { get; set; }

        [StringLength(255)]
        public string hoTen { get; set; }

        [StringLength(255)]
        public string soDienThoai { get; set; }

        [StringLength(255)]
        public string gioiTinh { get; set; }

        [StringLength(255)]
        public string diaChi { get; set; }

        [StringLength(255)]
        public string email { get; set; }

        [StringLength(255)]
        public string ngaySinh { get; set; }

        public virtual ICollection<Luong> Luongs { get; set; }
        public virtual ICollection<ChamCong> ChamCongs { get; set; }
    }
}