using Demo.Api.Controllers.Base;
using Microsoft.AspNetCore.Mvc;

namespace Demo.Api.Controllers
{
    [Route("api")]
    public class MainController : BaseController
    {
        public MainController()
        {
        }

        [HttpGet("test")]
        public IActionResult Test() => Ok();
    }
}
