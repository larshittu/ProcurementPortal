using System;
using System.Threading.Tasks;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Blob;

namespace Attachment.API.FileStorage
{
    class CloudBlockBlobFactory : ICloudBlockBlobFactory
    {
        public async Task<CloudBlockBlob> GetAttachmentBlockAsync(string fileName)
        {
            var storageConnectionString = Environment.GetEnvironmentVariable("storageconnectionstring");

            var storageAccount = CloudStorageAccount.Parse(storageConnectionString);

            var blobClient = storageAccount.CreateCloudBlobClient();

            var blobContainer = blobClient.GetContainerReference("attachments");

            await blobContainer.CreateIfNotExistsAsync();

            BlobContainerPermissions permissions = new BlobContainerPermissions
            {
                PublicAccess = BlobContainerPublicAccessType.Blob
            };

            await blobContainer.SetPermissionsAsync(permissions);

            return blobContainer.GetBlockBlobReference(fileName);
        }
    }
}