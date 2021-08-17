using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TarimMuhasebe.Entities
{
    public class Alis : BaseEntity
    {
        public string Kod { get; set; }

        public int CariId { get; set; }
        public Cari Cari { get; set; }

        public int UrunId { get; set; }
        public Urun Urun { get; set; }

        public int DepoId { get; set; }
        public Depo Depo { get; set; }

        public int KasaId { get; set; }
        public Kasa Kasa { get; set; }

        public decimal Miktar { get; set; }
        public decimal BirimFiyat { get; set; }
        public decimal StopajOrani { get; set; }
        public bool StopajDahil { get; set; }
        public decimal StopajTutar { get; set; }
        public decimal ToplamFiyat { get; set; }
        public string Kullanici { get; set; }
        public DateTime Tarih { get; set; }
        public string Aciklama { get; set; }
    }
}
