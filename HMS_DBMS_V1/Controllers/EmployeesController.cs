using HMS_DBMS_V1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace HMS_DBMS_V1.Controllers
{
    public class EmployeesController : Controller
    {
        HMS_DBMS_V2Entities1 db = new HMS_DBMS_V2Entities1();
        // GET: Employees
        public ActionResult Index()
        {
            return View(db.tblEmployees.ToList());
        }

        public ActionResult Edit(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblEmployee employee = db.tblEmployees.Find(id);
            if (employee == null)
            {
                return HttpNotFound();
            }
            return View(employee);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "EmployeeID,Name,DateOfBirth,Gender,Address,PhoneNumber,HireDate,YearsOfExperience,EmployeeType,isActive")] tblEmployee employee)
        {
            if (ModelState.IsValid)
            {
                db.Entry(employee).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(employee);
        }

        // GET: Employee/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Employee/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "EmployeeID,Name,DateOfBirth,Gender,Address,PhoneNumber,HireDate,YearsOfExperience,EmployeeType,isActive")] tblEmployee employee)
        {
            if (ModelState.IsValid)
            {
                db.tblEmployees.Add(employee);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(employee);
        }
    }
}