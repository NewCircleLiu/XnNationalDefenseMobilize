using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace XnNationalDefenseMobilize.Models.Media
{
    public class VideoContext : DbContext
    {
        public VideoContext()
            : base("name=Video-Context")
        {
        }

        public DbSet<VideoCategory> videoCategoryLists { get; set; }
        public DbSet<Video> videoLists { get; set; }
    }
}