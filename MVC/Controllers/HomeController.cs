using MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Books()
        {
            Books b = new Books();
            b.serialno = 1432;
            b.booksname = "Çalıkuşu";
            b.authorsname = "Reşat Nuri";
            b.age = 22;
            return View(b);
        }
        [HttpPost]
        public ActionResult Books(Books model)
        {
            return View(model);
        }
    }
}