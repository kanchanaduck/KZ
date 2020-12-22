using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PTum.Models
{
    // [Keyless]
    public class Category
    {
        [Key]        
        public int id { get; set; }
        public string name { get; set; }
        public ICollection<Prod_type> Type { get; set; }
    }
}