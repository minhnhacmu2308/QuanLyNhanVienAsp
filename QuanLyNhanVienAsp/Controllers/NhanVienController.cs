using QuanLyNhanVienAsp.Daos;
using QuanLyNhanVienAsp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QuanLyNhanVienAsp.Controllers
{
    public class NhanVienController : Controller
    {
        NhanVienDao nhanVienDao = new NhanVienDao();
        // GET: NhanVien
        public ActionResult Index(string msg)
        {
            var list = nhanVienDao.GetAll();
            ViewBag.List = list;
            ViewBag.Msg = msg;
            return View();
        }

        public ActionResult AddNhanVien(NhanVien nhanVien)
        {
            bool checkExist = nhanVienDao.checkExistEmail(nhanVien.email);
            if (checkExist)
            {
                return RedirectToAction("Index", new { msg = "2" });
            }
            else
            {
                nhanVienDao.Add(nhanVien);
                return RedirectToAction("Index", new { msg = "1" });
            }

        }

        public ActionResult UpdateNhanVien(NhanVien nhanVien)
        {
            nhanVienDao.Update(nhanVien);
            return RedirectToAction("Index", new { msg = "1" });
        }

        [HttpPost]
        public ActionResult DeleteNhanVien(NhanVien nhanVien)
        {
            nhanVienDao.Delete(nhanVien.idNhanVien);
            return RedirectToAction("Index", new { msg = "1" });
        }
    }
}