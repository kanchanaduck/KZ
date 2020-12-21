using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PTum.Models
{
    
    public class Menu
    {
        public string menu { get; set; }
        public string text { get; set; }
        public string type { get; set; }

    }
}