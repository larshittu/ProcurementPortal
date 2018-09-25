using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace Attachment.API.FileStorage
{
    interface IFileStorageService
    {
        Task<string> UploadAsync(IFormFile file);
    }
}
