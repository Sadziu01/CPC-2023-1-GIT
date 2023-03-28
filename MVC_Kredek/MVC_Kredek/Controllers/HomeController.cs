using Microsoft.AspNetCore.Mvc;
using MVC_Kredek.Models;
using MVC_Kredek.Repositories;
using System.Diagnostics;

namespace MVC_Kredek.Controllers
{
    public class HomeController : Controller
    {
        private readonly IMotorcycleRepository _motorcycleRepository;

        public HomeController(IMotorcycleRepository motorcycleRepository)
        {
            _motorcycleRepository = motorcycleRepository;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AllMotorcycles()
        {
            var motorcycles = _motorcycleRepository.GetAll();
            return View(motorcycles);
        }

        public IActionResult MotorcycleDetails(int id)
        {
            var motorcycle = _motorcycleRepository.GetMotorcycle(id);
            return View(motorcycle);
        }

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