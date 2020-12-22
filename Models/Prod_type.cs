using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PTum.Models
{
    public class Prod_type
    {
        [Key]        
        public int id { get; set; }
        public string name { get; set; }

        public int id_category { get; set; }
        [ForeignKey("id_category")]
        public Category Category { get; set; }
        public ICollection<Model> Model { get; set; }
    }
}