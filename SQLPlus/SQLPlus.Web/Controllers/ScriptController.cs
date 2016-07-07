using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SQLPlus.Web.Controllers
{
    public class ScriptController : Controller
    {
        // GET: Script
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Viewer()
        {
            return View();
        }
    }
}