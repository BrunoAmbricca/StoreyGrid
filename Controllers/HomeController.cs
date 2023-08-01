using Grilla.Models;
using Grilla.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Helpers;

namespace Grilla.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            MeasurerService measurerService = new();

            var measurers = measurerService.GetMeasurers().Result;
            //var measurers = new List<Measurer>();

            return View();
        }

        public IActionResult Index2()
        {
            MeasurerService measurerService = new();

            var measurers = measurerService.GetMeasurers().Result;
            //var measurers = new List<Measurer>();

            return View(measurers);
        }

        [HttpGet]
        public ActionResult GetMeasurers()
        {
            MeasurerService measurerService = new();

            var measurers = measurerService.GetMeasurers().Result;

            var recordsTotal = measurers.Count();

            return Json(new { draw = "", recordsFiltered = recordsTotal, recordsTotal = recordsTotal, data = measurers});
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
