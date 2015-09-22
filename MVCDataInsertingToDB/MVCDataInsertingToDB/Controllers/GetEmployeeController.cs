using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BusinessLayer;

namespace MVCDataInsertingToDB.Controllers
{
    public class GetEmployeeController : Controller
    {
        //
        // GET: /GetEmployee/

        public ActionResult Index()
        {
            EmployeeBusinessLayer BusinessLayer = new EmployeeBusinessLayer();
            List<Employee> employees = BusinessLayer.Employees.ToList();
            return View();
        }

    }
}
