using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace NotificationService.API.Services
{
    public class AzureBlobStorageService : IFileStorageService
    {

        public Task<string> Upload(IFormFile file)
        {
            throw new System.NotImplementedException();
        }
    }
}