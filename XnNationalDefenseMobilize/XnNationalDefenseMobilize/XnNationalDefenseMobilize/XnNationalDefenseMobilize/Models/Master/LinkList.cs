using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace XnNationalDefenseMobilize.Models.Master
{
    public class LinkList
    {
        [Key]
        public int link_id { get; set; }
        public string link_name { get; set; }
        public string link_url { get; set; }
    }
}