﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TextAnalyzer.Models;

namespace TextAnalyzer.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly TextAnalyzer _analyzer;

        public HomeController(ILogger<HomeController> logger, TextAnalyzer analyzer)
        {
            _logger = logger;
            _analyzer = analyzer;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
        }
        
        [HttpPost]
        public IActionResult UploadText(string text)
        {
            return View(new ResultViewModel(_analyzer.GetAnalysisResult(text)));
        }
        
        [HttpPost]
        public IActionResult UploadFile(IFormFile file)
        {
            var result = new StringBuilder();

            if (file == null) return BadRequest();
            if (file.Length > 0)
            {
                using var reader = new StreamReader(file.OpenReadStream());
                while (reader.Peek() >= 0)
                {
                    result.AppendLine(reader.ReadLine()); 
                }
            }

            return View(new ResultViewModel(_analyzer.GetAnalysisResult(result.ToString())));
        }
    }
}