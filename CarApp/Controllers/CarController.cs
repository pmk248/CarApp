using CarApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace CarApp.Controllers
{
    public class CarController : Controller
    {
        public IActionResult Model(string name, string year, string background)
        {
            Car car = new Car { CarModel = name ?? "Unknown", Year = year ?? "Unknown", Background = background ?? "white"};
            return View(car);
        }
    }
}
