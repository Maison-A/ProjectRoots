using Microsoft.AspNetCore.Mvc;
using ProjectRoots.Models;
using System.Collections.Generic;
namespace backend.Controllers

{
    [ApiController]
    // [Route("[controller]")]// e.g. localhost:3000/User
    [Route("Users")]// e.g. localhost:3000/User
    public class UserController : ControllerBase
    {
        private readonly ILogger<UserController> _logger;
        private readonly ProjectRootsDb _context;
        
        public UserController(ILogger<UserController> logger, ProjectRootsDb context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet("AllUsers")]
        [HttpGet("AllUsersDB")]
        public ActionResult<IEnumerable<User>> GetAllUsers()
        {
            return Ok(_context.Users.ToList());
        }
    }
}
