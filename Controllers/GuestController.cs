using Microsoft.AspNetCore.Mvc;
using la_mia_pizzeria_static.Models;

namespace la_mia_pizzeria_static.Controllers
{
    public class GuestController : Controller
    {
        public IActionResult Index()
        {

            ViewData["title"] = "Guest side";
            return View();
        }

        public  IActionResult Details(int id)
        {
            ViewData["title"] = "Dettaglio Post";
            return View(id);
        }


        public IActionResult Contact()
        {
            ViewData["title"] = "Contattaci";
            return View();
        }
    }
}