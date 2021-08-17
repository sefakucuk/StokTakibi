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
    public partial class AnasayfaKasaUC : UserControl
    {
        private DatabaseContext _db;
        private Kasa _kasa;

        public AnasayfaKasaUC(int kasaId)
        {
            _db = new DatabaseContext(Program.ConnectionString);

            InitializeComponent();

            _kasa = _db.Kasalar.SingleOrDefault(x => x.Id == kasaId);

            grp_Kasa.Text = _kasa.Ad;
            lbl_AcilisTutar.Text = $"{_kasa.AcilisTutar} ₺";
            lbl_GuncelTutar.Text = $"{_kasa.GuncelTutar} ₺";

            if (_kasa.GuncelTutar < 0)
                lbl_GuncelTutar.BackColor = Color.OrangeRed;
            else
                lbl_GuncelTutar.BackColor = Color.LightGreen;
        }
    }
}
