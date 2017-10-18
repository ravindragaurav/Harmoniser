using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Web.Models;
using Web.Business;

namespace Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Harmoniser()
        {
            ViewData["Message"] = "Harmoniser";
            ViewData["AnotherMessage"] = "Another Harmoniser";
            return View();
        }

        public JsonResult GetChord(string soprano)
        {
            ChordLogic logic = new ChordLogic();
            var chord = logic.GetChord(soprano);
            if (chord == null)
            {
                return Json("did not return anything");
            }
            return Json(chord);
        }


        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
