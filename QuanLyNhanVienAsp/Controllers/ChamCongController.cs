using QuanLyNhanVienAsp.Daos;
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
        // GET: ChamCong
        public ActionResult Index()
        {
            ViewBag.List = chamCongDao.GetAll();
            return View();
        }
    }
}