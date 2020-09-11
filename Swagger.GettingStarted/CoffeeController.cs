using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace Swagger.GettingStarted
{
    /// <summary>
    /// Coffee controller
    /// </summary>
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class CoffeeController : ControllerBase
    {
        /// <summary>
        /// Get all coffees
        /// </summary>
        /// <returns></returns>
        [Route("")]
        [HttpGet]
        public List<CoffeeDto> GetAll()
        {
            return new List<CoffeeDto>
            {
                new CoffeeDto{ Name = "Americano"},
                new CoffeeDto{ Name = "Latte"},
                new CoffeeDto{ Name = "Cappuccino"},
                new CoffeeDto{ Name = "Espresso"},
            };
        }
    }
}