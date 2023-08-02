using Grilla.Models;
using Grilla.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

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
            MeasurerService measurerService = new MeasurerService();

            var measurers = measurerService.GetMeasurers().Result;
            //var measurers = new List<Measurer>();

            return View();
        }

        public IActionResult Index2()
        {
            MeasurerService measurerService = new MeasurerService();

            var measurers = measurerService.GetMeasurers().Result;
            //var measurers = new List<Measurer>();

            return View(measurers);
        }

        [HttpGet]
        public ActionResult GetMeasurers(int page = 1, int limit = 10)
        {
            MeasurerService measurerService = new MeasurerService();

            var measurers = measurerService.GetMeasurers().Result;

            var totalCount = measurers.Count();
            var totalPages = (int)Math.Ceiling((decimal)totalCount / limit);
            var measurersPerPage = measurers
                .Skip((page - 1) * limit)
                .Take(limit)
                .ToList();

            //return Json(new { data = measurersPerPage });
            return Json(new { records = measurersPerPage, total = totalCount });

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
