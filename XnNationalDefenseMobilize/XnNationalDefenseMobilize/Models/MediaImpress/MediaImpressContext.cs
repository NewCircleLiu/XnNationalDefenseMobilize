using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace XnNationalDefenseMobilize.Models.MediaImpress
{
    public class MediaImpressContext : DbContext
    {
        public MediaImpressContext()
            : base("name=MediaImpress-Context")
        {
        }

        public DbSet<MediaImpressCategory> mediaImpressCategoryLists { get; set; }
        public DbSet<MediaImpress> mediaImpressLists { get; set; }
    }
}