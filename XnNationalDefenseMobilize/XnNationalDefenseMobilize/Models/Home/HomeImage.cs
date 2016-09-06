using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace XnNationalDefenseMobilize.Models.Home
{
    public class HomeImage
    {
        [Key]
        public int image_id { get; set; }
        public string image_path { get; set; }
        public string image_location { get; set; }
    }
}