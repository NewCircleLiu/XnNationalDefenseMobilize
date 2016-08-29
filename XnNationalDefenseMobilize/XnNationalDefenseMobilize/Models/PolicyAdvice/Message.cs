using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace XnNationalDefenseMobilize.Models.PolycyAdvice
{
    public class Message
    {
        [Key]
        public int message_id { get; set; }
        public string message_username { get; set; }
        public string message_email { get; set; }
        public string message_title { get; set; }
        public string message_content { get; set; }
        public string message_reply_content { get; set; }
    }
}