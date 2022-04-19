using System;
using Microsoft.AspNetCore.Mvc;

namespace  CoffeeAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CoffeeController : ControllerBase
    {
        private static readonly string[] Coffees = new []
        {
            "Flat White", "Long Black","Latte","Americano","Cappuccino"
        };

        [HttpGet]
        public ActionResult Get(){
            var rng =  new Random();

            return Ok(Coffees[rng.Next(Coffees.Length)]);
        }
    }
}