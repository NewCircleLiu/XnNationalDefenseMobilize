using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace XnNationalDefenseMobilize.Models.Slogan
{
    public class Slogan
    {
        [Key]
        public int slogan_id { get; set; }
        public string slogan_location { get; set; }
        public string slogan__content { get; set; }
    }
}