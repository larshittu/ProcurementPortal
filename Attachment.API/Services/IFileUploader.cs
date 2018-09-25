using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace Attachment.API.Services
{
    interface IFileUploader
    {
        Task Upload(IFormFileCollection files);
    }

}
