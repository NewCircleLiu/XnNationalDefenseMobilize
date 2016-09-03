using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace XnNationalDefenseMobilize.Models.Media
{
    public class VideoCategoryContext : DbContext
    {
        public VideoCategoryContext()
            : base("name=VideoCategory-Context")
        {
        }

        public DbSet<VideoCategory> videoCategoryLists { get; set; }
    }
}