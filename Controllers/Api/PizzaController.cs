using la_mia_pizzeria_static.Models.Repositories;
using la_mia_pizzeria_static.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;

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

        [HttpGet("{id}")]
        public IActionResult Details(int id)
        {
            Pizza pizzas = _pizzaRepository.getById(id);

            return Ok(pizzas);
        }
    }
}
