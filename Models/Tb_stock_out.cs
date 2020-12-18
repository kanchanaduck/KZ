using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PTum.Models
{
    public class Tb_stock_out
    {
        [Key]        
        public int id_out { get; set; }
        [Display(Name = "Product Code")]
        public string prd_code { get; set; }
        [Display(Name = "Qty")]
        public int? prd_outqty { get; set; }
        [Display(Name = "Remark")]
        public string prd_outremark { get; set; }

        [Display(Name = "Garoon No.")]
        public string prd_garron_no { get; set; }
        [Display(Name = "Borrow")]
        public Boolean prd_borrow_status { get; set; }

        [Display(Name = "Date")]
        public DateTime? out_datetime { get; set; }

        [Display(Name = "Operator")]
        public string out_name { get; set; }
        public DateTime? out_last_uptime { get; set; }
        public string out_last_upname { get; set; }
        public DateTime? borrow_datetime { get; set; }
        public string borrow_name { get; set; }
        public string return_name { get; set; }
        public DateTime? return_datetime { get; set; }
        public string return_status { get; set; }
        public DateTime? send_datetime { get; set; }
        public string send_name { get; set; }
        public string out_status { get; set; }
        [Display(Name = "Request No.")]
        public string pay_no { get; set; }
        public int pay_run { get; set; }
    }
}