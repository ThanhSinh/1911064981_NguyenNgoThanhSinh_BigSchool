using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _1911064981_NguyenNgoThanhSinh_BigSchool.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        //Commit luc 11h ngay 21/03
        public ActionResult Contact1()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}