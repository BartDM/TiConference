using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TiConference.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var stations= Helper.Data.GetAllStations();
            return View(stations);
        }

        public ActionResult Detail(string id)
        {
            var station = Helper.Data.GetStationById(id);
            return View(station);
        }

        public ActionResult Greet(string message)
        {
            return Content(message);

        }
    }
}