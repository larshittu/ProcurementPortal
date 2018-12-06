using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace Attachment.API.Services
{
    public interface IFileUploader
    {
        Task<IEnumerable<FileUploadResult>> Upload(IFormFileCollection files);
    }
}
