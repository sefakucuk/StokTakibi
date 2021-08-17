using System;
using System.Linq;
using System.Windows.Forms;
using TarimMuhasebe.DataAccess;
using TarimMuhasebe.Entities;

namespace TarimMuhasebe.WinFormApp.Forms
{
    public partial class KasaForm : Form
    {
        private DatabaseContext _db;
        private Kasa _kasa;

        public KasaForm(Kasa kasa)
        {
            _db = new DatabaseContext(Program.ConnectionString);
            _kasa = kasa;

            InitializeComponent();
            loadData();
        }

        public void loadData()
        {
            txt_Kod.Text = _kasa.Kod;
            txt_Ad.Text = _kasa.Ad;
            txt_Aciklama.Text = _kasa.Aciklama;
            nmbr_AcilisTutar.Value = _kasa.AcilisTutar;
            nmbr_GuncelTutar.Value = _kasa.GuncelTutar;
            chc_AnasayfaGosterim.Checked = _kasa.AnasayfaGosterim;

            if (_kasa.Id != 0)
            {
                date_AcilisTarihi.Value = _kasa.AcilisTarihi;

                date_AcilisTarihi.Enabled = false;
                nmbr_AcilisTutar.Enabled = false;
            }
            else
            {
                date_AcilisTarihi.Value = DateTime.Now;

                var last = _db.Kasalar.OrderByDescending(x => x.Id).FirstOrDefault();
                int number = 1;

                if (last != null)
                    number = last.Id + 1;

                txt_Kod.Text = $"KS-{number.ToString("D10")}";
            }
        }

        private void btn_Kaydet_Click(object sender, EventArgs e)
        {
            bool status = false;

            if (string.IsNullOrEmpty(txt_Kod.Text))
            {
                status = true;
                error.SetError(txt_Kod, "Boş geçilemez !");
            }

            if (string.IsNullOrEmpty(txt_Ad.Text))
            {
                status = true;
                error.SetError(txt_Ad, "Boş geçilemez !");
            }

            if (date_AcilisTarihi.Value == null)
            {
                status = true;
                error.SetError(date_AcilisTarihi, "Boş geçilemez !");
            }

            if (status)
                return;

            _kasa.Kod = txt_Kod.Text;
            _kasa.Ad = txt_Ad.Text;
            _kasa.Aciklama = txt_Aciklama.Text;
            _kasa.AcilisTarihi = date_AcilisTarihi.Value;
            _kasa.AcilisTutar = nmbr_AcilisTutar.Value;
            _kasa.AnasayfaGosterim = chc_AnasayfaGosterim.Checked;

            if (_kasa.Id == 0)
            {
                _kasa.GuncelTutar = _kasa.AcilisTutar;

                _db.Kasalar.Add(_kasa);
            }
            else
            {
                var selectKasa = _db.Kasalar.SingleOrDefault(x => x.Id == _kasa.Id);

                selectKasa.Kod = _kasa.Kod;
                selectKasa.Ad = _kasa.Ad;
                selectKasa.Aciklama = _kasa.Aciklama;
                selectKasa.AnasayfaGosterim = _kasa.AnasayfaGosterim;
            }

            _db.SaveChanges();

            this.Close();
        }
    }
}
