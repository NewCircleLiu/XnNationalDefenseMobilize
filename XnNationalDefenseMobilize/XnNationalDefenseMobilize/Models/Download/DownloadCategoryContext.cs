using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace XnNationalDefenseMobilize.Models.Download
{
    public class DownloadCategoryContext : DbContext
    {
        public DownloadCategoryContext()
            : base("name=DownloadCategory-Context")
        {
        }

        public DbSet<DownloadCategory> downloadCategoryLists { get; set; }
    }
}