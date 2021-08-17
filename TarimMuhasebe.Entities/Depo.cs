using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TarimMuhasebe.Entities
{
    public class Depo : BaseEntity
    {
        public string Kod { get; set; }
        public string Ad { get; set; }
        public string Aciklama { get; set; }

        public List<Stok> Stoklar { get; set; }

        public Depo()
        {
            Stoklar = new List<Stok>();
        }
    }
}
