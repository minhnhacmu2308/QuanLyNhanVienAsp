using QuanLyNhanVienAsp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuanLyNhanVienAsp.Daos
{
    public class ChamCongDao
    {
        DbContextQl myDb = new DbContextQl();
        public List<ChamCong> GetAll()
        {
            return myDb.chamCongs.ToList();
        }
    }
}