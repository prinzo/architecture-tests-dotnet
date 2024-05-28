using DataAccess.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace ArchitectureAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserRepository _userRepository;

        public UsersController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var usernames = _userRepository.GetUserNames();
            return this.Ok(usernames);
        }
    }
}
