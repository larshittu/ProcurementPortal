using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using NotificationService.API.Services;

namespace Attachment.API.Core
{
    public class AzureBlobStorageService : IFileStorageService
    {
        public Task<string> Upload(IFormFile file)
        {
            throw new System.NotImplementedException();

        }
    }
}