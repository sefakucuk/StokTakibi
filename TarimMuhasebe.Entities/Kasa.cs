using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TarimMuhasebe.Entities
{
    public class Kasa : BaseEntity
    {
        public string Kod { get; set; }
        public string Ad { get; set; }
        public string Aciklama { get; set; }
        public DateTime AcilisTarihi { get; set; }
        public decimal AcilisTutar { get; set; }
        public decimal GuncelTutar { get; set; }
        public bool AnasayfaGosterim { get; set; }
    }
}
