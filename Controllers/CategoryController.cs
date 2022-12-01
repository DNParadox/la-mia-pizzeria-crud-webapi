using la_mia_pizzeria_static.data;
using la_mia_pizzeria_static.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using la_mia_pizzeria_static.Models.Repositories;

namespace la_mia_pizzeria_static.Controllers
{
    public class CategoryController : Controller
    {
        PizzeriaDbContext db;

        public CategoryController(IDbPizzaRepository _pizzaRepository, PizzeriaDbContext _db) : base()
        {
            
            db = _db;
        }

     
        public IActionResult Index()
        {

            List<Category> categories = db.Categories.ToList();

            return View(categories);
        }

        public IActionResult Detail(int id)
        {

            // Mostriamo nel dettaglio l'oggetto instanziato per ID includendo a sua volta la tabella Category
            Category categories = db.Categories.Where(p => p.Id == id).FirstOrDefault();

            return View(categories);
        }
    }
}
