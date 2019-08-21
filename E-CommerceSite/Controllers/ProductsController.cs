using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace E_CommerceSite.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        public ActionResult Product()
        {
            return View();
        }
    }
}