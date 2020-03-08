using System.Threading.Tasks;
using App.API.Data;
using App.API.Dtos;
using App.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace App.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthRepository _repo;
        public AuthController(IAuthRepository repo)
        {
            _repo = repo;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register(UserForRegisterDto userForRegisterDto)
        {
            userForRegisterDto.username = userForRegisterDto.username.ToLower();
            if (await _repo.UserExists(userForRegisterDto.username))
            {
                return BadRequest("Username already exists");
            }
            var userToCreate = new User
            {
                username = userForRegisterDto.username
            };
            var createdUser = await _repo.Register(userToCreate, userForRegisterDto.password);
            return StatusCode(201);
        }
    }
}