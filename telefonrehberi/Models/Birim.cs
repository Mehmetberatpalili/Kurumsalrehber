using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace telefonrehberi.Models
{
    public class Birim
    {
        [Key]
        public int BirimID { get; set; }
        public string BirimAdi { get; set; }
        public string  BirimYoneticisi { get; set; }
        public IList<personel> Personel { get; set; }
    }
}
