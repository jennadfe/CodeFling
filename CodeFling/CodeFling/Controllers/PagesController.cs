using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CodeFling.Controllers
{
    public class PagesController : Controller
    {
        // GET: Pages
        public ActionResult GoogleMap_markers()
        {
            return View();
        }

        public ActionResult ImageLinks()
        {
            return View();
        }

        public ActionResult GoogleMap_shapes()
        {
            return View();
        }

        public ActionResult RandomAnimatedColours()
        {
            return View();
        }

        public ActionResult ColourPicker()
        {
            return View();
        }

        public ActionResult BackToTheTop()
        {
            return View();
        }

        public ActionResult Time()
        {
            return View();
        }

    }
}