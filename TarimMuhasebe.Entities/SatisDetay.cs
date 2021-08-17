using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TarimMuhasebe.Entities
{
    public class SatisDetay : BaseEntity
    {
        public int SatisId { get; set; }
        public Satis Satis { get; set; }

        public int UrunId { get; set; }
        public Urun Urun { get; set; }

        public int DepoId { get; set; }
        public Depo Depo { get; set; }

        public decimal Miktar { get; set; }
        public decimal BirimFiyat { get; set; }
        public decimal Matrah { get; set; }
        public decimal KdvOrani { get; set; }
        public decimal Kdv { get; set; }
        public string Aciklama { get; set; }
    }
}
