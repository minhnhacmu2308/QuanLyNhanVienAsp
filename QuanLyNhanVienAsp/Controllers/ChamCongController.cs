using QuanLyNhanVienAsp.Daos;
using QuanLyNhanVienAsp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QuanLyNhanVienAsp.Controllers
{
    public class ChamCongController : Controller
    {
        ChamCongDao chamCongDao = new ChamCongDao();
        NhanVienDao nhanVienDao = new NhanVienDao();
        // GET: ChamCong
        public ActionResult Index(string msg)
        {
            ViewBag.List = chamCongDao.GetAll();
            ViewBag.ListNhanVien = nhanVienDao.GetAll();
            ViewBag.Msg = msg;
            return View();
        }

        [HttpPost]
        public ActionResult Add(ChamCong chamCong)
        {
            bool checkExist = chamCongDao.CheckExist(chamCong.idNhanVien, chamCong.ngayChamCong);
            if (checkExist)
            {
                return RedirectToAction("Index", new { msg = "2" });
            }
            else
            {
                chamCongDao.Add(chamCong);
                return RedirectToAction("Index", new { msg = "1" });
            }
        }

        public ActionResult Update(ChamCong chamCong)
        {
            chamCongDao.Update(chamCong);
            return RedirectToAction("Index", new { msg = "1" });
        }

        [HttpPost]
        public ActionResult Delete(ChamCong chamCong)
        {
            chamCongDao.Delete(chamCong.idChamCong);
            return RedirectToAction("Index", new { msg = "1" });
        }
    }
}