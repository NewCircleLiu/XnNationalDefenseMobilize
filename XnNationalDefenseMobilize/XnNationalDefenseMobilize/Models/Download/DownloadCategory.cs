using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace XnNationalDefenseMobilize.Models.Download
{
    public class DownloadCategory
    {
        [Key]
        public int downloadCategory_id { get; set; }
        public string downloadCategory_name { get; set; }

        public virtual ICollection<Download> downloads { get; set; }
    }
}