using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PTum.Models
{
    // [Keyless]
    public class Tb_stock_in
    {
        [Key]        
        public int id_in { get; set; }
        [Required]
        [Display(Name = "Code")]
        [StringLength(12)]
        public string prd_code { get; set; }
        [Required]
        [Display(Name = "Qty")]
        public int? prd_inqty { get; set; }
        public string in_status { get; set; }

        [Display(Name = "Date in")]
        public DateTime? in_datetime { get; set; }
        [Display(Name = "Operator")]
        public string in_name { get; set; }
        public string in_last_uptime { get; set; }
        public string in_last_upname { get; set; }
    }
}