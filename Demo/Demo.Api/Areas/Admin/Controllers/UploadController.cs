using System.Collections.Generic;
using Demo.Api.Areas.Admin.Controllers.Base;
using Demo.Api.Utils;
using Demo.Core.Exceptions;
using Demo.Models.Common;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Demo.Api.Areas.Admin.Controllers
{
    [Route("admin/api/upload")]
    public class UploadController : BaseAdminController
    {
        private readonly IHostingEnvironment _hostingEnvironment;

        public UploadController(IHostingEnvironment hostingEnvironment)
        {
            _hostingEnvironment = hostingEnvironment;
        }

        [HttpPost("file")]
        public IActionResult UploadFile(List<IFormFile> files)
        {
            if (files.Count == 0)
                throw new DemoException("No file selected");

            var imageUtils = UploadUtils.Instance(_hostingEnvironment);

            var relativePaths = imageUtils.Save(files);

            return Ok(new
            {
                relativePaths
            });
        }

        [HttpPost("base64")]
        public IActionResult UploadBase64([FromBody]UploadBase64Model model)
        {
            var imageUtils = UploadUtils.Instance(_hostingEnvironment);

            var relativePath = imageUtils.Save(model.Value);

            return Ok(new
            {
                relativePath
            });
        }
    }
}
