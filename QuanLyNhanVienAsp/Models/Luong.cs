using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLyNhanVienAsp.Models
{
    public class Luong
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int idLuong { get; set; }

        public int idNhanVien { get; set; }

        public int tienLuong { get; set; }

        public int thang { get; set; }

        public string loaiTienLuong { get; set; }

        public virtual NhanVien NhanVien { get; set; }
    }
}