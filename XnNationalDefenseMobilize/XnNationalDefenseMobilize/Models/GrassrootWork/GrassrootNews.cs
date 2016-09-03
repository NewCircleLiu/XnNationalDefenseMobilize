using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace XnNationalDefenseMobilize.Models.GrassrootWork
{
    public class GrassrootNews
    {
        [Key]
        public int grassrootNews_id { get; set; }
        public string grassrootNews_title { get; set; }
        public string grassrootNews_author { get; set; }
        public string grassrootNews_source { get; set; }
        public string grassrootNews_abstract { get; set; }
        public string grassrootNews_content { get; set; }
        public DateTime grassrootNews_release_time { get; set; }

        public int district_id { get; set; }

        public virtual District disTrict { get; set; }
    }
}