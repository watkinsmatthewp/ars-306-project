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
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(string vexTab)
        {
            var melody = new RandomCompositionStrategy().Compose(new RandomCompositionStrategyInput
            {
                BeatsPerMeasure = 3,
                ChanceOfRestOneIn = 9,
                MaxNoteBeats = 1,
                MinNoteBeats = 1,
                MinOctaveOffset = 0,
                MaxOctaveOffset = 0,
                NumberOfMeasures = 24,
                AllowedIntervals = Scale.Major
            });

            return View(melody);
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
