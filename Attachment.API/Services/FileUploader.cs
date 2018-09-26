using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Attachment.API.DataAccess;
using Attachment.API.FileStorage;
using Microsoft.AspNetCore.Http;

namespace Attachment.API.Services
{
    public class FileUploader : IFileUploader
    {
        private readonly IFileStorageService _fileStorageService;
        private readonly AttachmentDbContext _attachmentDbContext;

        public FileUploader(IFileStorageService fileStorageService, AttachmentDbContext attachmentDbContext)
        {
            _fileStorageService = fileStorageService;
            _attachmentDbContext = attachmentDbContext;
        }

        public async Task<IEnumerable<FileUploadResult>> Upload(IFormFileCollection files)
        {
            var results = new List<FileUploadResult>();

            foreach (var file in files)
            {
                var result = await Save(file);
                results.Add(result);
            }

            await SaveAttachments(results);

            return results;
        }

        private async Task SaveAttachments(IEnumerable<FileUploadResult> results)
        {
            var attachments = results.Select(r => new DataAccess.Attachment { Path = r.NewName });

            _attachmentDbContext.Attachments.AddRange(attachments);

            await _attachmentDbContext.SaveChangesAsync();
        }

        private async Task<FileUploadResult> Save(IFormFile file)
        {
            var fileName = await _fileStorageService.UploadAsync(file);

            return new FileUploadResult { NewName = fileName, OriginalName = file.Name };
        }
    }
}