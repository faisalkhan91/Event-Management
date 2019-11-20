using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EventManagement.Models;
using EventManagement.ModelsLogic;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EventManagement.Controllers
{
    public class EventController : Controller
    {
        // GET: /<controller>/

        IEvent _ievent;

        public EventController(IEvent _event)
        {
            _ievent = _event;
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View("Create");
        }

        [HttpPost]
        public ViewResult Create(Event _event)
        {
            if (ModelState.IsValid)
            {
                _ievent.Add(_event);
                ViewBag.ValidationMessage = null;
            }
            else
            {
                ViewBag.ValidationMessage = "Validation not Passed.";
            }
            return View("Create");
        }
    }
}
