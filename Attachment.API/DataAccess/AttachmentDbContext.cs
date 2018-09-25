using Microsoft.EntityFrameworkCore;

namespace Attachment.API.DataAccess
{
    public class AttachmentDbContext:DbContext
    {
        public DbSet<Attachment> Attachments { get; set; }
    }
}
