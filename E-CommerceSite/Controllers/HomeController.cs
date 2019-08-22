using E_CommerceSite.Bussiness.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace E_CommerceSite.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            SignUpHelper sign = new SignUpHelper();
            try
            {
               var data= sign.ListUser();
            }
            catch (Exception ex)
            {


            }
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
        public ActionResult testimonials()
        {
            return View();
        }
    }
}