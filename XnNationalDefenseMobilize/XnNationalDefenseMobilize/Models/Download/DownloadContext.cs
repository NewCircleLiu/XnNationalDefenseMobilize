using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace XnNationalDefenseMobilize.Models.Download
{
    public class DownloadContext : DbContext
    {
        public DownloadContext()
            : base("name=Download-Context")
        {
        }

        public DbSet<DownloadCategory> downloadCategoryLists { get; set; }
        public DbSet<Download> downloadLists { get; set; }
    }
}