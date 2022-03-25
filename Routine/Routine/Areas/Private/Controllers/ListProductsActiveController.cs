using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Routine.Areas.Private.Controllers
{
    public class ListProductsActiveController : Controller
    {
        // GET: Private/ListProductsActive
        public ActionResult Index()
        {
            ViewBag.Message = "";
            ViewBag.Status = "";
            return View();
        }
    }
}