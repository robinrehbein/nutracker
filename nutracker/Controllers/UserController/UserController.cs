using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using nutracker.Models.User;

namespace nutracker.Controllers.UserController
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly ILogger<UserController> _logger;

        public UserController(ILogger<UserController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public string Get()
        {
            return "user";
        }

        [HttpPost]
        public User Post(User addUser)
        {
            User user = new User();
            user = addUser;
            // persist user
            return user;
        }
    }
}
