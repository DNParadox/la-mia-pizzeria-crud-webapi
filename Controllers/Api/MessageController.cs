using Microsoft.AspNetCore.Http;
using la_mia_pizzeria_static.Models;
using la_mia_pizzeria_static.data;
using Microsoft.AspNetCore.Mvc;
using la_mia_pizzeria_static.Models.Repositories;
using System.ComponentModel.DataAnnotations;

namespace la_mia_pizzeria_static.Controllers.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessageController : ControllerBase
    {
        PizzeriaDbContext db;


      

        //public MessageController()
        //{
        //    db = new PizzeriaDbContext();
        //}

        [HttpPost]
        public IActionResult Create([FromBody] Message message)
        {
           
            try
            {


                ModelState.AddModelError("message.email", "Aggiungi un parametro");
                BadRequest(ModelState);

                db.Messages.Add(message);
                db.SaveChanges();

            }
            catch (Exception e)
            {
                return UnprocessableEntity(e.Message);
            }
            return Ok(message);
        }
  
}
}
