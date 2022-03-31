using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MySQLFun.Models;

namespace MySQLFun.Controllers
{
    public class HomeController : Controller
    {
        //private readonly ILogger<HomeController> _logger;

        private BowlingLeagueDbContext _context { get; set; }

        public HomeController(BowlingLeagueDbContext temp)
        {
            _context = temp;
        }

        public IActionResult Index()
        {
            var blah = _context.Bowlers.ToList();

            return View(blah);
        }

        public IActionResult Privacy()
        {
            var blah = _context.Bowlers.ToList();

            return View(blah);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
