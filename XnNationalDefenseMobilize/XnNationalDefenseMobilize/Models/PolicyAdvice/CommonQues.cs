using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace XnNationalDefenseMobilize.Models.PolycyAdvice
{
    public class CommonQues
    {
        [Key]
        public int question_id { get; set; }
        public string question_content { get; set; }
        public string question_answer{ get; set; }
    }
}