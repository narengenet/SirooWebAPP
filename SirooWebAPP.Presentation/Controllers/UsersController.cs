using Microsoft.AspNetCore.Mvc;
using SirooWebAPP.Application.Interfaces;
using SirooWebAPP.Core.Domain;

namespace SirooWebAPP.Presentation.Controllers
{
    [ApiController]
    [Route(template:"[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly IUserServices _usersServices;

        public UsersController(IUserServices userServices)
        {
          _usersServices = userServices;
        }

        [HttpGet("sina")]
        public IActionResult Get()
        {
            List<String> result = _usersServices.GetUsernames();
            return Ok(result);
        }

        [HttpGet("olay")]
        public IActionResult GetInviter()
        {
            string result = _usersServices.GetInviterUsername(2);
            return Ok(result);
        }
    }
}
