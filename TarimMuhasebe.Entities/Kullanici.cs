using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TarimMuhasebe.Entities
{
    public class Kullanici : BaseEntity
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Eposta { get; set; }
        public string Telefon { get; set; }
        public string Sifre { get; set; }
        public bool Aktif { get; set; }
        public bool Yonetici { get; set; }
    }
}
