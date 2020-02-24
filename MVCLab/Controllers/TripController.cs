using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVCLab.Models;

namespace MVCLab.Controllers
{
    public class TripController : Controller
    {
        public IActionResult MileageForm()
        {
            return View();
        }
        // double mpg, double gallons, double trip
        //Tripometer.MPG = mpg
        public IActionResult MileageResult(Tripometer trips)
        {
            return View(trips);
        }
    }
}