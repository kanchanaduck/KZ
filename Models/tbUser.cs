using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PTum.Models
{
    public class tbUser
    {
        [Key]        
        public int id { get; set; }
        [Required]
        [StringLength(6, MinimumLength = 6)]
        [Display(Name = "Username")]
        public string username { get; set; }
        [Required]
        [Display(Name = "Password")]
        public string password { get; set; }
        public string email { get; set; }
        public string tell { get; set; }
        [Display(Name = "Dept")]
        public string det { get; set; }
        public string div { get; set; }
        [Display(Name = "Dept Code")]
        public string det_code { get; set; }
        public string div_code { get; set; }
        [Display(Name = "Firstname")]
        public string name { get; set; }

        [Display(Name = "Lastname")]
        public string last_name { get; set; }
        public string full_name { get; set; }
        [Display(Name = "Emp ID")]
        public string emp_code { get; set; }
        [Required]
        [Display(Name = "Position")]
        public string position { get; set; }
        public int? project_id { get; set; }
        public Boolean? status { get; set; }
    }
}