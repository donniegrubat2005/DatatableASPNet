using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DatatableASPNet.Models;

namespace DatatableASPNet.Controllers
{
    public class EmployeeController : Controller
    {
        private DataContext dbemployee = new DataContext();
        // GET: Employee
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetEmployee()
        {
            var empList = dbemployee.Employees.ToList<Employee>();
            return Json(new { data=empList},JsonRequestBehavior.AllowGet);
        }
    }
}