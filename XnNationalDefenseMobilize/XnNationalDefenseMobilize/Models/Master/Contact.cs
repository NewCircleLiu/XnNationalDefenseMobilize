using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace XnNationalDefenseMobilize.Models.Master
{
    public class Contact
    {
        [Key]
        public int contact_id { get; set; }
        public string contact_addr { get; set; }
        public string contact_phone { get; set; }
        public string contact_fax { get; set; }
        public string contact_email { get; set; }
        public string contact_website { get; set; }
        public string contact_wx_bincode { get; set; }
        public string contact_web_bincode { get; set; }
    }
}