using Microsoft.AspNetCore.Mvc;
using UserRegistrationAPI.Models;
using UserRegistrationAPI.Repositories;

namespace UserRegistrationAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        // POST: api/auth/register
        [HttpPost("register")]
        public IActionResult Register([FromBody] RegisterModel model)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            // Optionally, check if user with same email already exists.
            if (UserRepository.GetByEmail(model.Email) != null)
                return BadRequest(new { message = "User with this email already exists." });

            // Create a new user from the model.
            var user = new User
            {
                FullName = model.FullName,
                Email = model.Email,
                Password = model.Password  // In production, never store passwords in plain text.
            };

            var createdUser = UserRepository.Add(user);

            return Ok(new
            {
                status = 200,
                message = "User registered successfully",
                data = createdUser
            });
        }

        // GET: api/auth/users (to list all registered users)
        [HttpGet("users")]
        public IActionResult GetUsers()
        {
            var users = UserRepository.GetAll();
            return Ok(users);
        }
    }

    // Data Transfer Object (DTO) for registration.
    public class RegisterModel
    {
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
