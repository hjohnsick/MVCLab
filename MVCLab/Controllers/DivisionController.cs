using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVCLab.Models;

namespace MVCLab.Controllers
{
    public class DivisionController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Answer(AnswerModel remainderQuotient)
        {
            
            return View(remainderQuotient);
        }

      
    }
}