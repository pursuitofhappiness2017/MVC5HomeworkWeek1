using MVC5HomeworkWeek1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC5HomeworkWeek1.Controllers
{
    public class HomeController : Controller
    {
        private 客戶資料Entities db = new 客戶資料Entities();
        public ActionResult Index()
        {
            return View(db.客戶資料概要.ToList());
        }
    }
}