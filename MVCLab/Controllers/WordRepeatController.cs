using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MVCLab.Controllers
{
    public class WordRepeatController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Repeater(string word)
        {
            
            return View("word",word);
        }

    }
}