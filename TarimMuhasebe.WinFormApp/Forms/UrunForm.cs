using System;
using System.Linq;
using System.Windows.Forms;
using TarimMuhasebe.DataAccess;
using TarimMuhasebe.Entities;

namespace TarimMuhasebe.WinFormApp.Forms
{
    public partial class UrunForm : Form
    {
        private DatabaseContext _db;
        private Urun _urun;

        public UrunForm(Urun urun)
        {
            _db = new DatabaseContext(Program.ConnectionString);
            _urun = urun;

            InitializeComponent();
            loadData();
        }

        public void loadData()
        {
            txt_Kod.Text = _urun.Kod;
            txt_Ad.Text = _urun.Ad;
            nmbr_AlisFiyat.Value = _urun.AlisFiyat;
            nmbr_SatisFiyat.Value = _urun.SatisFiyat;
            nmbr_Stopaj.Value = _urun.Stopaj;
            nmbr_Kdv.Value = _urun.Kdv;

            chc_AnasayfaGosterim.Checked = _urun.AnasayfaGosterim;

            cmb_Birim.DisplayMember = "Ad";
            cmb_Birim.ValueMember = "Id";
            cmb_Birim.DataSource = _db.Birimler.ToList();
            cmb_Birim.SelectedValue = _urun.BirimId;

            if (_urun.Id == 0)
            {
                cmb_Birim.SelectedIndex = 0;

                var last = _db.Urunler.OrderByDescending(x => x.Id).FirstOrDefault();
                int number = 1;

                if (last != null)
                    number = last.Id + 1;

                txt_Kod.Text = $"URN-{number.ToString("D10")}";
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

            if (status)
                return;

            _urun.Kod = txt_Kod.Text;
            _urun.Ad = txt_Ad.Text;
            _urun.AlisFiyat = nmbr_AlisFiyat.Value;
            _urun.SatisFiyat = nmbr_SatisFiyat.Value;
            _urun.Stopaj = nmbr_Stopaj.Value;
            _urun.Kdv = nmbr_Kdv.Value;
            _urun.AnasayfaGosterim = chc_AnasayfaGosterim.Checked;
            _urun.BirimId = (int)cmb_Birim.SelectedValue;

            if (_urun.Id == 0)
            {
                _urun.KayitTarihi = DateTime.Now;
                _urun.SonGuncellenmeTarihi = DateTime.Now;

                _db.Urunler.Add(_urun);
            }
            else
            {
                var selectUrun = _db.Urunler.SingleOrDefault(x => x.Id == _urun.Id);

                selectUrun.Kod = _urun.Kod;
                selectUrun.Ad = _urun.Ad;
                selectUrun.AlisFiyat = _urun.AlisFiyat;
                selectUrun.SatisFiyat = _urun.SatisFiyat;
                selectUrun.Stopaj = _urun.Stopaj;
                selectUrun.Kdv = _urun.Kdv;
                selectUrun.BirimId = _urun.BirimId;
                selectUrun.SonGuncellenmeTarihi = DateTime.Now;
                selectUrun.AnasayfaGosterim = _urun.AnasayfaGosterim;
            }

            _db.SaveChanges();

            this.Close();
        }
    }
}
