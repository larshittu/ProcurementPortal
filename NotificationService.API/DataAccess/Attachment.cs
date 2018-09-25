using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NotificationService.API.DataAccess
{
    public class Attachment
    {
        public Guid Id { get; set; }

        public string Path { get; set; }

        public DateTime DateUploaded { get; set; }

    }
}
