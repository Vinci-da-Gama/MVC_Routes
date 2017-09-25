using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Routes_Practices.Controllers
{
    public class TwoParamsController : Controller
    {
        // GET: TwoParams
        public ActionResult Index(int a, int b)
        {
            ViewBag.Message = "TwoParams/Index/" + a.ToString() + "/" + b.ToString();
            return View();
        }
    }
}