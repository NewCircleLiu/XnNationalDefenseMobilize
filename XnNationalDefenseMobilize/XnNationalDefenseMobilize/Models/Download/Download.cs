using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace XnNationalDefenseMobilize.Models.Download
{
    public class Download
    {
        [Key]
        public int download_id { get; set; }
        public string download_title { get; set; }
        public string download_source { get; set; }    
        public string download_icon { get; set; }
        public DateTime download_release_time { get; set; }

        public int downloadCategory_id { get; set; }

        public virtual DownloadCategory downloadCategory { get; set; }
    }
}