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
    public class CommentController : Controller
    {
        // GET: /<controller>/

        IComment _icomment; // Need to change this to Icomment

        public CommentController(IComment comment)
        {
            _icomment = comment;
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View("Add");
        }

        [HttpPost]
        public ViewResult Create(Comment comment)
        {
            if (ModelState.IsValid)
            {
                _icomment.Add(comment);
                ViewBag.ValidationMessage = null;
            }
            else
            {
                ViewBag.ValidationMessage = "Validation not Passed.";
            }
            return View("Add");
        }
    }
}
