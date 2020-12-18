using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Http;

namespace PTum.Models
{
    public class Tb_mst_product
    {    
        public int Id { get; set; }

        [Display(Name = "Code")]
        public string prd_code { get; set; }

        [Display(Name = "Name")]
        public string prd_name { get; set; }

        [Display(Name = "Image")]
        public string prd_img { get; set; }

        [Display(Name = "Category")]
        public string prd_category { get; set; }

        [Display(Name = "Category Image")]      
        public string prd_cate_img { get; set; }
        [Display(Name = "Type")]
        public string prd_type { get; set; }
        [Display(Name = "Model")]
        public string prd_model { get; set; }

        public string prd_cpt_name { get; set; }

        public string prd_fixasset_name { get; set; }

        public string prd_serial_num { get; set; }

        public string prd_regis_datetime { get; set; }

        public string prd_regis_name { get; set; }

        public string prd_last_uptime { get; set; }

        public string prd_last_upname { get; set; }

        public string prd_status { get; set; }

    }
}