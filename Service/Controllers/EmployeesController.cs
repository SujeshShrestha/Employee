using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Service.IRepo;
using Service.Models;
using Service.Repositories;

namespace Service.Controllers
{
    public class EmployeesController : Controller
    {
        private IEmpolyee EmployeeRepositories;

        public EmployeesController()
        {

            this.db = new EmployeeDbEntities();
            //initialise
            this.EmployeeRepositories = new EmployeeRepositories(this.db);

        }
        private EmployeeDbEntities db = new EmployeeDbEntities();

        // GET: Employees
        public ActionResult Index()
        {

            return View(EmployeeRepositories.GetList());
        }

        // GET: Employees/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Employee employee = db.Employees.Find(id);
            if (employee == null)
            {
                return HttpNotFound();
            }
            return View(employee);
        }

        // GET: Employees/Create
        public ActionResult Create()
        {
            var values = from MonthEnum.months d in Enum.GetValues(typeof(MonthEnum.months))
                         select new
                         {
                             Text = d.ToString(),
                             Value = Convert.ToInt32(d).ToString()
                         };
            ViewBag.Months = new SelectList(values, "Value", "Text");
            return View();
        }

        // POST: Employees/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Employee employee)
        {
            if (ModelState.IsValid)
            {

                var test = employee.StartDay;
                var test2 = employee.StartMonth;
                var test3 = employee.StartYear;
                

                
                EmployeeRepositories.Insert(employee);
                EmployeeRepositories.Save();
                return RedirectToAction("Index");
            }
            var values = from MonthEnum.months d in Enum.GetValues(typeof(MonthEnum.months))
                         select new
                         {
                             Text = d.ToString(),
                             Value = Convert.ToInt32(d).ToString()
                         };
            ViewBag.Months = new SelectList(values, "Value", "Text");
            return View(employee);
        }

        // GET: Employees/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Employee employee = db.Employees.Find(id);
            if (employee == null)
            {
                return HttpNotFound();
            }
            var values = from MonthEnum.months d in Enum.GetValues(typeof(MonthEnum.months))
                         select new
                         {
                             Text = d.ToString(),
                             Value = Convert.ToInt32(d).ToString()
                         };
            ViewBag.Months = new SelectList(values, "Value", "Text");
            return View(employee);

        }

        // POST: Employees/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Employee employee)
        {
            if (ModelState.IsValid)
            {
                EmployeeRepositories.Update(employee);
                EmployeeRepositories.Save();

                return RedirectToAction("Index");
            }
            var values = from MonthEnum.months d in Enum.GetValues(typeof(MonthEnum.months))
                         select new
                         {
                             Text = d.ToString(),
                             Value = Convert.ToInt32(d).ToString()
                         };
            ViewBag.Months = new SelectList(values, "Value", "Text");

            return View(employee);
        }

        // GET: Employees/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Employee employee = this.EmployeeRepositories.GetByID(id.Value);
            if (employee == null)
            {
                return HttpNotFound();
            }

            return View(employee);
        }

        // POST: Employees/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {


            EmployeeRepositories.Delete(id);
            EmployeeRepositories.Save();
            return RedirectToAction("Index");

        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
