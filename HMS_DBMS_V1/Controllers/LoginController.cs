using HMS_DBMS_V1.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace HMS_DBMS_V1.Controllers
{
    public class LoginController : Controller
    {
        HMS_DBMS_V2Entities2 db = new HMS_DBMS_V2Entities2();
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }
    }
}