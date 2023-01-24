using App.Models;
using Microsoft.AspNetCore.Mvc;
//using App.Models;

namespace App.Controllers
{
    public class HelloWorldController : Controller
    {
        public IActionResult Index()
        {
            DogViewModel doggo = new DogViewModel()
            { Name = "Sif", Age = 2};
            return View(doggo);
        }

        public IActionResult Create()
        {
            return View();
        }
    }
}
