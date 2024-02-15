using Microsoft.AspNetCore.Mvc;
using mission6EmilyPeterson.Models;
using System.Diagnostics;

namespace mission6EmilyPeterson.Controllers
{
    public class HomeController : Controller //constructor
    {
        private FormContext _context;

        public HomeController(FormContext temp) //constructor
        {
            _context = temp;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Joel() //about joel
        {
            return View();
        }
        public IActionResult Form() //add movies
        {
            return View();
        }

        [HttpPost]
        public IActionResult Form(Form response) 
        {
        _context.Forms.Add(response); //add record to database
        _context.SaveChanges();
        return View("Confirmation");
        }
    }
}
