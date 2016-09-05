using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace XnNationalDefenseMobilize.Models.Master
{
    public class Suggest
    {
        [Key]
        public int suggest_id { get; set; }
        public string user_name { get; set; }
        public string suggest_email { get; set; }
        public string suggest_phone { get; set; }
        public string suggest_content { get; set; }
        public DateTime suggest_time { get; set; }
    }
}