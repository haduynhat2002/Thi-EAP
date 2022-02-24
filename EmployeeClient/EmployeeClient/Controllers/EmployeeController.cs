using EmployeeClient.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EmployeeClient.Controllers
{
    public class EmployeeController : Controller
    {
        ServiceReference1.Service1Client service1Client = new ServiceReference1.Service1Client();
        public ActionResult Index()
        {
            var listProduct = service1Client.GetList();
            return View();
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Save(Employee employee)
        {
            service1Client.Save(employee);
            return RedirectToAction("Index");
        }
    }
}