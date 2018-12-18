using Demo.Api.Areas.Admin.Controllers.Base;
using Microsoft.AspNetCore.Mvc;

namespace Demo.Api.Areas.Admin.Controllers
{
    [Route("admin/api")]
    public class MainController : BaseAdminController
    {
        public MainController()
        {
        }

        [HttpGet("test")]
        public IActionResult Test() => Ok();
    }
}
