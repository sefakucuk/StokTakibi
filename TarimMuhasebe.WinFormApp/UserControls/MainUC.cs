using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using TarimMuhasebe.DataAccess;
using TarimMuhasebe.WinFormApp.Forms;

namespace TarimMuhasebe.WinFormApp.UserControls
{
    public partial class MainUC : UserControl
    {
        private DatabaseContext _db;

        public MainUC()
        {
            _db = new DatabaseContext(Program.ConnectionString);

            InitializeComponent();
            loadData();
        }

        public void loadData()
        {
            loadAnasayfaUrunler();
            loadAnasayfaKasalar();
        }

        private void loadAnasayfaUrunler()
        {
            pnl_Urunler.Controls.Clear();

            var urunler = _db.Urunler.Where(x => x.AnasayfaGosterim).ToList();

            foreach (var urun in urunler)
            {
                AnasayfaUrunUC urunUC = new AnasayfaUrunUC(urun.Id);
                pnl_Urunler.Controls.Add(urunUC);
            }
        }

        private void loadAnasayfaKasalar()
        {
            pnl_Kasalar.Controls.Clear();

            var kasalar = _db.Kasalar.Where(x => x.AnasayfaGosterim).ToList();

            foreach (var kasa in kasalar)
            {
                AnasayfaKasaUC kasaUC = new AnasayfaKasaUC(kasa.Id);
                pnl_Kasalar.Controls.Add(kasaUC);
            }
        }

        private void DialogForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            loadAnasayfaUrunler();
            loadAnasayfaKasalar();
        }
    }
}
