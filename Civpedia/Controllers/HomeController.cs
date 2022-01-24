using Civpedia.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Civpedia.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly CivpediaModel _civPediaModel;

        public HomeController(ILogger<HomeController> logger, CivpediaModel civPediaModel)
        {
            _logger = logger;
            _civPediaModel = civPediaModel;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Merveilles()
        {
            return View();
        }

        public IActionResult Civilisations(string recherche)
        {
            ViewBag.Civilisations = _civPediaModel.getCivilisations("");
            return View();
        }


        public IActionResult CitesEtats()
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
