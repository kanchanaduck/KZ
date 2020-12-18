using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PTum.Models
{
    
    public class Balance_V
    {
        [Key]
        public string rownum { get; set; }
        [Display(Name = "Code")]
        public string prd_code { get; set; }

        [Display(Name = "Name")]
        public string prd_name { get; set; }

        [Display(Name = "Image")]
        public string prd_img { get; set; }
        public int total_bl { get; set; }

    }
}