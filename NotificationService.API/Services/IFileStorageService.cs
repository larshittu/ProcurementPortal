using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace NotificationService.API.Services
{
    interface IFileStorageService
    {
        Task<string> Upload(IFormFile file);
    }
}
