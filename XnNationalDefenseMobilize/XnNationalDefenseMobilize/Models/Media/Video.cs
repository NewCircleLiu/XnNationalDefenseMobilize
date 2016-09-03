using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace XnNationalDefenseMobilize.Models.Media
{
    public class Video
    {
        [Key]
        public int video_id { get; set; }
        public string video_title { get; set; }
        public string video_source { get; set; }
        public DateTime video_release_time { get; set; }
        public string video_covers { get; set; }

        public int videoCategory_id { get; set; }

        public virtual VideoCategory videoCategory { get; set; }
    }
}