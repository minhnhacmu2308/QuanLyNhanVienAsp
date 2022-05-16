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
        public void Add(ChamCong chamCong)
        {
            myDb.chamCongs.Add(chamCong);
            myDb.SaveChanges();
        }

        public void Update(ChamCong chamCong)
        {
            var obj = myDb.chamCongs.FirstOrDefault(x => x.idChamCong == chamCong.idChamCong);
            obj.idNhanVien = chamCong.idNhanVien;
            obj.ngayChamCong = chamCong.ngayChamCong;
            myDb.SaveChanges();
        }

        public bool CheckExist(int idNhanVien, string ngayChamCong)
        {
            var obj = myDb.chamCongs.FirstOrDefault(x => x.idNhanVien == idNhanVien && x.ngayChamCong == ngayChamCong);
            if (obj != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Delete(int id)
        {
            var chamcong = myDb.chamCongs.FirstOrDefault(x => x.idChamCong == id);
            myDb.chamCongs.Remove(chamcong);
            myDb.SaveChanges();
        }
    }
}