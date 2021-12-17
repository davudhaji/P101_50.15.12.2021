using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication4.Models
{
    public class Social
    {
        [Key]
        public int id { get; set; }
        [MaxLength(30)]
        public string name { get; set; }
        [MaxLength(50)]
        public string icon { get; set; }
        [MaxLength(250)]
        public string link { get; set; }
    }
}
