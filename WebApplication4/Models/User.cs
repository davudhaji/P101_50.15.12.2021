using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication4.Models
{
    public class User
    {
        [Key]
        public int id { get; set; }
        [MaxLength(20)]
        public string name { get; set; }
        [MaxLength(20)]
        public string surname { get; set; }
        [MaxLength(50)]
        public string email { set; get; }
        [MaxLength(15)]
        public string phone { get; set; }
        [MaxLength(30)]
        public string username { get; set; }
        [MaxLength(250)]
        public string password { get; set; }

        public string publicDate { get; set; }

    }
}
