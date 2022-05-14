using QuanLyNhanVienAsp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuanLyNhanVienAsp.Daos
{
    public class LuongDao
    {
        DbContextQl myDb = new DbContextQl();
        public List<Luong> GetAll()
        {
            return myDb.luongs.ToList();
        }
        public void Add(Luong luong)
        {
            myDb.luongs.Add(luong);
            myDb.SaveChanges();
        }

        public void Update(Luong luong)
        {
            var obj = myDb.luongs.FirstOrDefault(x => x.idLuong == luong.idLuong);
            obj.idNhanVien = luong.idNhanVien;
            obj.thang = luong.thang;
            obj.loaiTienLuong = luong.loaiTienLuong;
            obj.tienLuong = luong.tienLuong;
            myDb.SaveChanges();
        }

        public bool CheckExist(int idNhanVien , int thang)
        {
            var obj = myDb.luongs.FirstOrDefault(x => x.idNhanVien == idNhanVien && x.thang == thang);
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
            var luong = myDb.luongs.FirstOrDefault(x => x.idLuong == id);
            myDb.luongs.Remove(luong);
            myDb.SaveChanges();
        }
    }
}