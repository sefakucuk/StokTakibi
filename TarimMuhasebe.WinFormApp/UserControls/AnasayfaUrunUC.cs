using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TarimMuhasebe.DataAccess;
using TarimMuhasebe.Entities;

namespace TarimMuhasebe.WinFormApp.UserControls
{
    public partial class AnasayfaUrunUC : UserControl
    {
        private DatabaseContext _db;
        private Urun _urun;

        public AnasayfaUrunUC(int urunId)
        {
            _db = new DatabaseContext(Program.ConnectionString);

            InitializeComponent();

            _urun = _db.Urunler.Include("Birim").SingleOrDefault(x => x.Id == urunId);

            decimal toplamStok = _db.Stoklar.Where(x => x.UrunId == urunId).ToList().Sum(x => x.Miktar);

            grp_Urun.Text = _urun.Ad;
            lbl_AlisFiyat.Text = $"{_urun.AlisFiyat} ₺";
            lbl_SatisFiyat.Text = $"{_urun.SatisFiyat} ₺";
            lbl_Stok.Text = $"{toplamStok.ToString("F2")} {_urun.Birim.Gosterim}";
        }
    }
}
