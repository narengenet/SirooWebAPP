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
        public IActionResult GetInviter(int id)
        {
            string result = _usersServices.GetInviterUsername(2);
            return Ok(result);
        }
    }
}




//public class DefaultController : Controller
//{
//    private readonly AuthorRepository authorRepository =
//    new AuthorRepository();
//    [HttpGet]
//    [Route("Default/GetAuthor/{authorId:int}")]
//    public IActionResult GetAuthor(int authorId)
//    {
//        var data = authorRepository.GetAuthor(authorId);
//        return Ok(data);
//    }
//    [HttpGet]
//    [Route("Default/GetAuthors/{pageNumber:int}")]
//    public IActionResult GetAuthors([FromQuery
//        (Name = "pageNumber")] int pageNumber = 1)
//    {
//        var data = authorRepository.GetAuthors(pageNumber);
//        return Ok(data);
//    }
//    [HttpGet]
//    [Route("Default/IsCreditCardValid/{creditCardNumber}")]
//    public IActionResult IsCreditCardValid
//    ([FromHeader] string creditCardNumber)
//    {
//        string regexExpression =
//        "^(?:(?<visa>4[0-9]{12}(?:[0-9]{3})?)|" +
//        "(?<mastercard>5[1-5][0-9]{14})|" +
//        "(?<amex>3[47][0-9]{13})|)$";
//        Regex regex = new Regex(regexExpression);
//        var match = regex.Match(creditCardNumber);
//        return Ok(match.Success);
//    }
//    [HttpPost]
//    [Route("Default/Insert")]
//    public IActionResult Insert([FromBody] Author author)
//    {
//        return Ok(authorRepository.Save(author));
//    }
//}
