using QuanLyNhanVienAsp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuanLyNhanVienAsp.Daos
{
    public class NhanVienDao
    {
        DbContextQl myDb = new DbContextQl();
        public List<NhanVien> GetAll()
        {
            return myDb.nhanViens.ToList();
        }

        public void Add(NhanVien nhanVien)
        {
            myDb.nhanViens.Add(nhanVien);
            myDb.SaveChanges();
        }

        public void Delete(int id)
        {
            var nhanVien = myDb.nhanViens.FirstOrDefault(x => x.idNhanVien == id);
            myDb.nhanViens.Remove(nhanVien);
            myDb.SaveChanges();
        }

        public void Update(NhanVien nhanVien)
        {
            var obj = myDb.nhanViens.FirstOrDefault(x => x.idNhanVien == nhanVien.idNhanVien);
            obj.hoTen = nhanVien.hoTen;
            obj.soDienThoai = nhanVien.soDienThoai;
            obj.diaChi = nhanVien.diaChi;
            obj.gioiTinh = nhanVien.gioiTinh;
            obj.email = nhanVien.email;
            obj.ngaySinh = nhanVien.ngaySinh;
            myDb.SaveChanges();
        }

        public bool checkExistEmail(string email)
        {
            var obj = myDb.nhanViens.FirstOrDefault(x => x.email == email);
            if (obj != null) { return true; }
            return false;
        }
    }
}