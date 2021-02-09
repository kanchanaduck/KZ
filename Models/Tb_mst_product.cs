using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Http;

namespace PTum.Models
{
    public class Tb_mst_product
    {    
        public int Id { get; set; }
        [Required]
        [Display(Name = "Code")]
        public string prd_code { get; set; }

        [Display(Name = "Name")]
        public string prd_name { get; set; }
        [Display(Name = "Image")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public string prd_img { get; set; }

        [Display(Name = "Category")]
        public string prd_category { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]

        [Display(Name = "Category Image")]      
        public string prd_cate_img { get; set; }
        [Display(Name = "Type")]
        public string prd_type { get; set; }
        [Display(Name = "Model")]
        public string prd_model { get; set; }

        [Display(Name = "CPT Name")]
        public string prd_cpt_name { get; set; }
        [Display(Name = "Fixed Asset No.")]
        public string prd_fixasset_name { get; set; }

        [Display(Name = "Serial No.")]
        public string prd_serial_num { get; set; }

        public DateTime? prd_regis_datetime { get; set; }

        public string prd_regis_name { get; set; }

        public DateTime? prd_last_uptime { get; set; }

        public string prd_last_upname { get; set; }

        public string prd_status { get; set; }

    }
   


}
