using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;


namespace EarthRocket.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            Dictionary<string, float> model = new Dictionary<string, float>();
            double lon = -31.2357 * Math.PI / 180;
            double lat = 30.0444 * Math.PI / 180;
            double a = Math.Cos(lat) * 1.25;
            double y = Math.Sin(lat) * 1.25;
            double x = Math.Cos(lon) * a;
            double z = Math.Sin(lon) * a;

            model["x"] = (float)x;
            model["y"] = (float)y;
            model["z"] = (float)z;
            return View(model);
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

        public IActionResult Error()
        {
            return View();
        }
    }
}
