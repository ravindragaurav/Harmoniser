using Web.Models;
using Web.Business;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Web.Controllers
{
    public class HomeController : Controller
    {
        private Recorder recorder;
       
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

        public void StartRecording()
        {
            recorder = new Recorder();
            recorder.start();
        }

        public void StopRecording()
        {
            recorder.stop();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
