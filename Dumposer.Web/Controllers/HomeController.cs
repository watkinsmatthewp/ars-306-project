using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Dumposer.Web.Models;
using Dumbposer.Composition;
using Dumbposer.Entities;

namespace Dumposer.Web.Controllers
{
    public class HomeController : Controller
    {
        Dictionary<string, int[]> SCALES = new Dictionary<string, int[]>
        {
            [nameof(Scale.Major)] = Scale.Major,
            [nameof(Scale.NaturalMinor)] = Scale.NaturalMinor,
            [nameof(Scale.HarmonicMinor)] = Scale.HarmonicMinor,
            [nameof(Scale.MelodicMinorScale)] = Scale.MelodicMinorScale
        };

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Random()
        {
            return View(new RandomCompositionStrategyInput());
        }

        [HttpPost]
        public IActionResult Random(RandomCompositionStrategyInput model, string scale)
        {
            model.AllowedIntervals = SCALES[scale];
            ViewData["Melody"] = new RandomCompositionStrategy().Compose(model);
            return View(model);
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
