using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TarimMuhasebe.Entities
{
    public class Cari : BaseEntity
    {
        public string Kod { get; set; }
        public string Unvan { get; set; }
        public string VergiNo { get; set; }
        public string VergiDairesi { get; set; }
        public string Yetkili { get; set; }
        public string Il { get; set; }
        public string Ilce { get; set; }
        public string Adres { get; set; }
        public string Tel1 { get; set; }
        public string Tel2 { get; set; }
        public string Eposta1 { get; set; }
        public string Eposta2 { get; set; }
        public string Fax { get; set; }
        public bool Aktif { get; set; }
    }
}
