using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TiConference.Controllers
{
    public class TemperatureController : Controller
    {
        //[Route("temp/{scale:values(celcius|fahrenheit)}")]
        public ActionResult Show(string scale)
        {
            return Content(string.Format("scale is {0}", scale));
        }
    }
}