using System.Linq;
using Demo.Api.Areas.Admin.Controllers.Base;
using Demo.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Demo.Api.Areas.Admin.Controllers
{
    public class UserController : BaseAdminController
    {
        private readonly DemoContext _demoContext;

        public UserController(DemoContext demoContext)
        {
            _demoContext = demoContext;
        }

        /// <summary>
        /// lay thong tin
        /// </summary>
        [HttpGet("get")]
        public IActionResult Get()
        {
            return Ok(_demoContext.Users.ToList());
        }
    }
}
