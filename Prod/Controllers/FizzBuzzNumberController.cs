using Microsoft.AspNetCore.Mvc;

namespace FizzBuzz.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class FizzBuzzNumberController : ControllerBase
    {
        [HttpGet("{number}")]
        public ActionResult Get(short number) 
        {
            return Ok();
        }
    }
}
