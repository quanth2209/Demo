using Demo.Api.Areas.User.Base;
using Microsoft.AspNetCore.Mvc;

namespace Demo.Api.Areas.User
{
    [Route("user/api")]
    public class MainController : BaseUserController
    {
        public MainController()
        {
        }

        [HttpGet("test")]
        public IActionResult Test() => Ok();
    }
}
