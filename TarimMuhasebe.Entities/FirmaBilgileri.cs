using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TarimMuhasebe.Entities
{
    public class FirmaBilgileri
    {
        public string Server { get; set; }
        public int Port { get; set; }
        public string Database { get; set; }
        public string Kullanici { get; set; }
        public string Sifre { get; set; }

        public string YedekAdres { get; set; }

        public string Ad { get; set; }
        public string VergiNo { get; set; }
        public string Adres { get; set; }
        public string Logo { get; set; }
    }
}
