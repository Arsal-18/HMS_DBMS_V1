using HMS_DBMS_V1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HMS_DBMS_V1.Controllers
{
    public class ScheduleController : Controller
    {
        HMS_DBMS_V2Entities5 db = new HMS_DBMS_V2Entities5();
        // GET: Schedule
        public ActionResult Index()
        {
            var data = db.tblSchedules.ToList();
            return View(data);
        }
    }
}