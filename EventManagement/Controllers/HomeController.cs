using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using EventManagement.Models;
using EventManagement.ModelsLogic;

namespace EventManagement.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        IEvent _ievent;

        public HomeController(ILogger<HomeController> logger, IEvent _event)
        {
            _logger = logger;
            _ievent = _event;
        }

        public ViewResult Index()
        {
            IEnumerable<Event> model = _ievent.GetAllEvents();
            ViewBag.PageTitle = "Event Details from View Bag";
            ViewBag.Event = model;

            return View();
        }

        /*
        public IActionResult Index()
        {
            return View();
        }
        */

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
