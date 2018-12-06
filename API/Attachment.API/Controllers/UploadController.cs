using System.Collections.Generic;
using System.Threading.Tasks;
using Attachment.API.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Attachment.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UploadController : ControllerBase
    {
        private readonly IFileUploader _fileUploader;

        public UploadController(IFileUploader fileUploader)
        {
            _fileUploader = fileUploader;
        }

        [HttpPost]
        public async Task<ActionResult<IEnumerable<string>>> Index([FromBody]IFormFileCollection files)
        {
            var result = await _fileUploader.Upload(files);
            return Ok(result);
        }
    }
}