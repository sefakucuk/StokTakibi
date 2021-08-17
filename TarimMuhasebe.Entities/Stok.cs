using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TarimMuhasebe.Entities
{
    public class Stok : BaseEntity
    {
        public int UrunId { get; set; }
        public Urun Urun { get; set; }

        public int DepoId { get; set; }
        public Depo Depo { get; set; }

        public decimal Miktar { get; set; }
    }
}
