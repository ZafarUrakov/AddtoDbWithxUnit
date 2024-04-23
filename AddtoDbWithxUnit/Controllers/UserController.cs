using AddtoDbWithxUnit.Models;
using AddtoDbWithxUnit.UserService;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace AddtoDbWithxUnit.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : Controller
    {
        private readonly IUserService userService;

        public UserController(IUserService userService) =>
            this.userService = userService;

        [HttpPost]
        public async ValueTask<ActionResult<User>> PostUserAsync(User user)
        {
            var storedUser = await this.userService.AddUserAsync(user);
            return Ok(storedUser);
        }
    }
}
