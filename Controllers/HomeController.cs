using System;
using Microsoft.AspNetCore.Mvc;

namespace MoviesAPI.Controllers
{
    [Route("/home")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
