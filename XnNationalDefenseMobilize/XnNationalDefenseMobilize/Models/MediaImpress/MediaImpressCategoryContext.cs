using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace XnNationalDefenseMobilize.Models.MediaImpress
{
    public class MediaImpressCategoryContext : DbContext
    {
        public MediaImpressCategoryContext()
            : base("name=MediaImpressCategory-Context")
        {
        }
        public DbSet<MediaImpress> mediaImpressLists { get; set; }
    }
}