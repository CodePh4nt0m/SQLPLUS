using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SQLPlus.Web.Models.ViewModels;

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
            var model = new ScriptViewerViewModel();
            model.Query = @"CREATE TABLE ""topic"" (
    ""id"" serial NOT NULL PRIMARY KEY,
    ""forum_id"" integer NOT NULL,
    ""subject"" varchar(255) NOT NULL
);
ALTER TABLE ""topic""
ADD CONSTRAINT forum_id FOREIGN KEY (""forum_id"")
REFERENCES ""forum"" (""id"");
-- Initials
insert into ""topic"" (""forum_id"", ""subject"")
values (2, 'D''artagnian');";
            return View(model);
        }
    }
}