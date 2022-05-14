using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLyNhanVienAsp.Models
{
    public class ChamCong
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int idChamCong { get; set; }

        public int idNhanVien { get; set; }

        public string ngayChamCong { get; set; }
        public virtual NhanVien NhanVien { get; set; }
    }
}