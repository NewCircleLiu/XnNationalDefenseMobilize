using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace XnNationalDefenseMobilize.Models.News
{
    public class NewsCategory
    {
        [Key]
        public int newsCategory_id { get; set; }
        public string newsCategory_name { get; set; }
    }
}