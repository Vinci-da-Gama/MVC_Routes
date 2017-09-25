using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Routes_Practices.Controllers
{
    public class StudentsController : Controller
    {
        // GET: Students
        public ActionResult Index(int id, string name, int sid)
        {
            ViewBag.RouteInfo = "id: " + id + " name: " + name + " StudentId: " + sid;
            return View();
        }
    }
}