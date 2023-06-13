using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DataController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get(string? number)
        {
            if (number == null)
            {
                return BadRequest("Lack of Parameter");
            }

            if (!int.TryParse(number.ToString(), out int parsedNumber))
            {
                return BadRequest("Wrong Parameter");
            }

            int sum = 0;
            for (int i = 1; i <= parsedNumber; i++)
            {
                sum += i;
            }

            return Ok($"Sum: {sum}");
        }
    }
}
