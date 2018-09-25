﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace NotificationService.API.DataAccess
{
    public class AttachmentDbContext:DbContext
    {
        public DbSet<Attachment> Attachments { get; set; }
    }
}
