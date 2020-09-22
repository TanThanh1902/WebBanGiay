using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebBanGiay.Models;

namespace WebBanGiay.Controllers
{
    public class HomeController : Controller
    {
        DBBanGiayEntities db = new DBBanGiayEntities();
        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult DSThuongHieu()
        {
            return PartialView();
        }

        public PartialViewResult SanPhamMoiNhat()
        {
            List<GIAYTable> tables = db.GIAYTables.OrderByDescending(t => t.NGAYTHEM).Take(8).ToList();
            return PartialView(tables);
        }

        public PartialViewResult SanPhamMuaNhieu()
        {
            List<GIAYTable> tables = db.CTHDTables.OrderByDescending(t => t.SOLUONG).DistinctBy(t => t.MAGIAY).Select(t => t.GIAYTable).ToList();
            return PartialView(tables);
        }
    }
}