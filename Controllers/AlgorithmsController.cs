﻿using Microsoft.AspNetCore.Mvc;

namespace CReshetka.Controllers
{
    public class AlgorithmsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult AlgorithmicComplexity()
        {
            return View();
        }
        public IActionResult BubbleSort()
        {
            return View();
        }
    }
}