using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using nutracker.Models.Food;

namespace nutracker.Controllers.FoodController
{
    [ApiController]
    [Route("[controller]")]
    public class FoodController : ControllerBase
    {
        private readonly ILogger<FoodController> _logger;

        public FoodController(ILogger<FoodController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public string Get()
        {
            return "food";
        }

        [HttpPost]
        public Food Post(Food addFood)
        {
            Food food = new Food();
            food = addFood;
            // persist food
            return food;
        }
    }
}
