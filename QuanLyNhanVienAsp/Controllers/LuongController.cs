using QuanLyNhanVienAsp.Daos;
using QuanLyNhanVienAsp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QuanLyNhanVienAsp.Controllers
{
    public class LuongController : Controller
    {
        NhanVienDao nhanVienDao = new NhanVienDao();
        LuongDao luongDao = new LuongDao();
        // GET: Luong
        public ActionResult Index(string msg)
        {
            ViewBag.List = luongDao.GetAll();
            ViewBag.ListNhanVien = nhanVienDao.GetAll();
            ViewBag.Msg = msg;
            return View();
        }
        [HttpPost]
        public ActionResult Add(Luong luong)
        {
            bool checkExist = luongDao.CheckExist(luong.idNhanVien,luong.thang);
            if (checkExist)
            {
                return RedirectToAction("Index", new { msg = "2" });
            }
            else
            {
                luongDao.Add(luong);
                return RedirectToAction("Index", new { msg = "1" });
            }
        }

        public ActionResult Update(Luong luong)
        {
            luongDao.Update(luong);
            return RedirectToAction("Index", new { msg = "1" });
        }

        [HttpPost]
        public ActionResult Delete(Luong luong)
        {
            luongDao.Delete(luong.idLuong);
            return RedirectToAction("Index", new { msg = "1" });
        }
    }
}