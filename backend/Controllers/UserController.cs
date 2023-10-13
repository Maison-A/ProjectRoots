using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
namespace backend.Controllers

{
    [ApiController]
    // [Route("[controller]")]// e.g. localhost:3000/User
    [Route("Users")]// e.g. localhost:3000/User
    public class UserController : ControllerBase
    {
        private readonly ILogger<UserController> _logger;

        public UserController(ILogger<UserController> logger)
        {
            _logger = logger;
        }

        [HttpGet("AllUsers")]
        public IEnumerable<User> Get()
        {
            // mock users for now to check if route works
            var users = new List<User>
            {
                new User { Id = 1, UserName = "LB_Surfer" },
                new User { Id = 2, UserName = "CaliKid_93" }
            };
            return users;
        }
    }
}
