using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Routine.Areas.Private.Controllers
{
    public class ListProductsInactiveController : Controller
    {
        // GET: Private/ListProductsInactive
        public ActionResult Index()
        {
            ViewBag.Message = "";
            ViewBag.Status = "";
            return View();
        }
    }
}