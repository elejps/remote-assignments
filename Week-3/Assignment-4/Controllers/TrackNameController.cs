using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TrackNameController : ControllerBase
    {
        private const string CookieName = "UserName";

        [HttpPost]
        public IActionResult Post([FromForm] string name)
        {
            if (!string.IsNullOrEmpty(name))
            {
                Response.Cookies.Append(CookieName, name);
            }

            return Redirect("/myName");
        }
    }
}
