using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace telefonrehberi.Models
{
    public class personel
    {
       [Key]
        public int perid { get; set; }
        public int Tc { get; set; }
        public string ad { get; set; }
        public string soyad { get; set; }
        public int  telefon{ get; set; }
        public string Adres { get; set; }
        public string CalistigiBirim { get; set; }
        public string  Gorev { get; set; }

        public int BirimID { get; set; }
        public Birim Birim { get; set; }

    }
}
