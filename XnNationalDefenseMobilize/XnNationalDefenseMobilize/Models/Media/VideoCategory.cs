using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace XnNationalDefenseMobilize.Models.Media
{
    public class VideoCategory
    {
        [Key]
        public int videoCategory_id { get; set; }
        public string videoCategory_name { get; set; }

        public virtual ICollection<Video> videos { get; set; }
    }
}