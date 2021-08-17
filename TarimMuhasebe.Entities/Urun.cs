using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TarimMuhasebe.Entities
{
    public class Urun : BaseEntity
    {
        public string Kod { get; set; }
        public string Ad { get; set; }
        public decimal AlisFiyat { get; set; }
        public decimal SatisFiyat { get; set; }
        public decimal Stopaj { get; set; }
        public decimal Kdv { get; set; }
        public DateTime SonGuncellenmeTarihi { get; set; }
        public DateTime KayitTarihi { get; set; }
        public bool AnasayfaGosterim { get; set; }
        public int BirimId { get; set; }
        public Birim Birim { get; set; }

        public List<Stok> Stoklar { get; set; }
    }
}
