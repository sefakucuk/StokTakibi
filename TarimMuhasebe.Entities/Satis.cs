using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TarimMuhasebe.Entities
{
    public class Satis : BaseEntity
    {
        public string Kod { get; set; }

        public int CariId { get; set; }
        public Cari Cari { get; set; }

        public int KasaId { get; set; }
        public Kasa Kasa { get; set; }

        public string Kullanici { get; set; }
        public DateTime Tarih { get; set; }
        public string Aciklama { get; set; }
        public decimal ToplamMatrahTutar { get; set; }
        public decimal ToplamKdvTutar { get; set; }
        public bool Tahsilat { get; set; }

        public List<SatisDetay> SatisDetaylari { get; set; }
    }
}
