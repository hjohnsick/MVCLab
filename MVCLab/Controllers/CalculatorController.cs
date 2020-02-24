using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MVCLab.Controllers
{
    public class CalculatorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Result(double number1, double number2, string problemSolve)
        {
            double result = 0;
            if (problemSolve == "Add")
            {
                result = number1 + number2;
            }
            else if (problemSolve == "Subtract")
            {
                result = number1 - number2;
            }
            return View("Result", result);
        }

    }
}