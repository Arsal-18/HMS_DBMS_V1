using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HMS_DBMS_V1.Models;

namespace HMS_DBMS_V1.Controllers
{
    public class HomeController : Controller
    {
        HMS_DBMS_V2Entities2 db = new HMS_DBMS_V2Entities2();
        public ActionResult Index()
        {
            return View();
        }
    }
}