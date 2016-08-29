using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace XnNationalDefenseMobilize.Models.GrassrootWork
{
    public class District
    {
        [Key]
        public int district_id { get; set; }
        public string district_name { get; set; }

        public virtual ICollection<GrassrootNews> news { get; set; }
    }
}