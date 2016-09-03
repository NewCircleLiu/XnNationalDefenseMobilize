using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace XnNationalDefenseMobilize.Models.MediaImpress
{
    public class MediaImpressCategory
    {
        [Key]
        public int mediaImpressCategory_id { get; set; }
        public string mediaImpressCategory_name { get; set; }

        public virtual ICollection<MediaImpress> mediaImpress { get; set; }
    }
}