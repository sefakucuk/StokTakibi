using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TarimMuhasebe.Entities
{
    public class Gider : BaseEntity
    {
        public string Kod { get; set; }
        public int KasaId { get; set; }
        public Kasa Kasa { get; set; }
        public int CariId { get; set; }
        public Cari Cari { get; set; }
        public decimal Tutar { get; set; }
        public DateTime Tarih { get; set; }
        public string Kullanici { get; set; }
        public string Aciklama { get; set; }
        public int OdemeTipId { get; set; }
        public OdemeTip OdemeTip { get; set; }
    }
}
