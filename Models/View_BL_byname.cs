using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PTum.Models
{
    
    public class View_BL_byname
    {
        [Key]
        public string prd_name { get; set; }
        public int? bl { get; set; }
        public string prd_img { get; set; }
        public string prd_category { get; set; }

    }
}