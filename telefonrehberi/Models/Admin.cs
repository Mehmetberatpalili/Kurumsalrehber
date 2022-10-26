using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace telefonrehberi.Models
{
    public class Admin
    {
        [Key]
        public int AdminId { get; set; }
        public string Kullanici { get; set; }
        public string Sifre { get; set; }
    }
}
