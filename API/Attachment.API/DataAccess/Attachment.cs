using System;

namespace Attachment.API.DataAccess
{
    public class Attachment
    {
        public Guid Id { get; set; }

        public string Path { get; set; }

        public DateTime DateUploaded { get; set; }

    }
}
