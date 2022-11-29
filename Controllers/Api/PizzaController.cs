using la_mia_pizzeria_static.Models.Repositories;
using la_mia_pizzeria_static.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace la_mia_pizzeria_static.Controllers.Api
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class PizzaController : ControllerBase
    {
        IDbPizzaRepository _pizzaRepository;
        public PizzaController(IDbPizzaRepository pizzaRepository)
        {
            _pizzaRepository = pizzaRepository;
        }
    

        public IActionResult Get()
        {
            List<Pizza> pizzas = _pizzaRepository.All();

            return Ok(pizzas);

        }

        public IActionResult Search(string? title)
        {

            List<Pizza> pizzas = _pizzaRepository.SearchByTitle(title);

            return Ok(pizzas);
        }
    }
}
