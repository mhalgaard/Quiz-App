using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Quiz_App.Infrastructure;

namespace Quiz_App.Controllers
{
    public class HomeController : Controller
    {
        private readonly IRepository repository;

        public HomeController(IRepository repository)
        {
            this.repository = repository;
        }
        public IActionResult Index()
        {
            ViewData["Quizzes"] = repository.Quizzes;
            return View();
        }
    }
}