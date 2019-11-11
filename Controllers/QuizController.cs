using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Quiz_App.Infrastructure;


namespace Quiz_App.Controllers
{
    public class QuizController : Controller
    {
        private readonly IRepository repository;

        public QuizController(IRepository repository)
        {
            this.repository = repository;
        }

        public IActionResult Index()
        {

            return View();
        }

        [HttpGet]
        public IActionResult Index(int id)
        {
            var model = repository.Quizzes.First(x => x.QuizID == id);
            return View(model);
        }

        //[HttpPost]
        //public IActionResult Result()
        //{

        //}

    }
}