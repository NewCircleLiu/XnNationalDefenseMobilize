using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace XnNationalDefenseMobilize.Models.MediaImpress
{
    public class MediaImpress
    {
        [Key]
        public int mediaImpress_id { get; set; }
        public string mediaImpress_title { get; set; }
        public string mediaImpress_cover { get; set; }
        public string mediaImpress_source { get; set; }
        public string mediaImpress_abstract { get; set; }
        public string mediaImpress_content { get; set; }
        public DateTime mediaImpress_release_time { get; set; }

        public int mediaImpressCategory_id { get; set; }

        public virtual MediaImpressCategory mediaImpressCategory { get; set; }
    }
}