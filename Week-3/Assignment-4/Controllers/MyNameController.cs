using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MyNameController : ControllerBase
    {
        private const string CookieName = "UserName";

        [HttpGet]
        public IActionResult Get()
        {
            string userName = Request.Cookies[CookieName];

            if (!string.IsNullOrEmpty(userName))
            {
                return Ok($"Welcome back, {userName}!");
            }
            return Redirect("/addmyname.html");
        }

    }
}
