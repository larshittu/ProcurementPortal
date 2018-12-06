using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace Attachment.API.FileStorage
{
    public class AzureBlobStorageService : IFileStorageService
    {
        private readonly ICloudBlockBlobFactory _cloudBlockBlobFactory;

        public AzureBlobStorageService(ICloudBlockBlobFactory cloudBlockBlobFactory)
        {
            _cloudBlockBlobFactory = cloudBlockBlobFactory;
        }

        public async Task<string> UploadAsync(IFormFile file)
        {
            var fileName = Guid.NewGuid().ToString("N") + file.FileName;

            var blockBlob = await _cloudBlockBlobFactory.GetAttachmentBlockAsync(fileName);

            await blockBlob.UploadFromStreamAsync(file.OpenReadStream());

            return fileName;
        }
    }
}