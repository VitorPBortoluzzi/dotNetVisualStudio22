﻿using Microsoft.AspNetCore.Mvc;
using MVCPrimeiraCriacao.Models;
using System.Diagnostics;

namespace MVCPrimeiraCriacao.Controllers
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
            Console.WriteLine("Estou no index");
            return View();
        }

        public IActionResult Privacy()
        {
            Console.WriteLine("Estou no Privacy");
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}