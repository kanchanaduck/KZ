using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PTum.Models
{
    // [Keyless]
    public class Model
    {
        [Key]        
        public int id { get; set; }
        public string name { get; set; }
        public int id_type { get; set; }

        [ForeignKey("id_type")]
        public Prod_type Prod_type { get; set; }
        public ICollection<Tb_mst_product> products { get; set; }
    }
}