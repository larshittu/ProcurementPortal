using System.Threading.Tasks;
using Microsoft.WindowsAzure.Storage.Blob;

namespace Attachment.API.FileStorage
{
    public interface ICloudBlockBlobFactory
    {
        Task<CloudBlockBlob> GetAttachmentBlockAsync(string fileName);
    }
}
