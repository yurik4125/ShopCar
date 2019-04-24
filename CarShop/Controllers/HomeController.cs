using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Antlr.Runtime;
using CarShop.Models;

namespace CarShop.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        private  Models.ShopDBEntities db = new ShopDBEntities();
        public ActionResult Index()
        {
            var  Items = db.Cars;
            return View();
        }
    }
}