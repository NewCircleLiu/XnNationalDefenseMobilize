using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace XnNationalDefenseMobilize.Models.News
{
    public class NewsInfo
    {
        [Key]
        public int news_id { get; set; }
        public string news_title { get; set; }
        public string news_author { get; set; }
        public string news_source { get; set; }
        public string news_abstract { get; set; }
        public string news_content { get; set; }

        public int newsCategory_id { get; set; }

        public virtual NewsCategory newsCategory { get; set; }
    }
}