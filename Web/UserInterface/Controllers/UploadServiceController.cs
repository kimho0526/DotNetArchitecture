using System.Collections.Generic;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Solution.CrossCutting.AspNetCore.Attributes;
using Solution.CrossCutting.AspNetCore.Extensions;
using Solution.Model.Models;

namespace Solution.Web.UserInterface.Controllers
{
    [ApiController]
    [RouteController]
    public class UploadServiceController : ControllerBase
    {
        public UploadServiceController(IHostingEnvironment environment)
        {
            Environment = environment;
        }

        private IHostingEnvironment Environment { get; }

        [DisableRequestSizeLimit]
        [HttpPost]
        public IEnumerable<FileModel> Upload()
        {
            return Request.Upload(Path.Combine(Environment.ContentRootPath, nameof(Upload)));
        }
    }
}
