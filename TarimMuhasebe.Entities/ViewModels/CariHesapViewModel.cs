using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TarimMuhasebe.Entities.ViewModels
{
    public class CariHesapViewModel
    {
        public int Id { get; set; }
        public string Kod { get; set; }
        public string Kasa { get; set; }
        public DateTime Tarih { get; set; }
        public string Kullanici { get; set; }
        public string Tip { get; set; }
        public decimal Tutar { get; set; }
    }
}
