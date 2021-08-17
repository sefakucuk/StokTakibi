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

namespace TarimMuhasebe.WinFormApp.Forms
{
    public partial class KullaniciForm : Form
    {
        private DatabaseContext _db;
        private Kullanici _kullanici;


        public KullaniciForm(Kullanici kullanici)
        {
            _db = new DatabaseContext(Program.ConnectionString);
            _kullanici = kullanici;

            InitializeComponent();

            loadData();
        }

        public void loadData()
        {
            txt_Ad.Text = _kullanici.Ad;
            txt_Soyad.Text = _kullanici.Soyad;
            txt_Eposta.Text = _kullanici.Eposta;
            txt_Telefon.Text = _kullanici.Telefon;

            chc_Admin.Checked = _kullanici.Yonetici;
            chc_Aktif.Checked = _kullanici.Aktif;
        }

        private void btn_Kaydet_Click(object sender, EventArgs e)
        {
            bool status = false;

            if (string.IsNullOrEmpty(txt_Ad.Text))
            {
                status = true;
                error.SetError(txt_Ad, "Boş geçilemez !");
            }

            if (string.IsNullOrEmpty(txt_Soyad.Text))
            {
                status = true;
                error.SetError(txt_Soyad, "Boş geçilemez !");
            }

            if (string.IsNullOrEmpty(txt_Eposta.Text))
            {
                status = true;
                error.SetError(txt_Eposta, "Boş geçilemez !");
            }

            if (string.IsNullOrEmpty(txt_Sifre.Text) && _kullanici.Id == 0)
            {
                status = true;
                error.SetError(txt_Sifre, "Boş geçilemez !");
            }

            if (status)
                return;

            _kullanici.Ad = txt_Ad.Text;
            _kullanici.Soyad = txt_Soyad.Text;
            _kullanici.Eposta = txt_Eposta.Text;
            _kullanici.Telefon = txt_Telefon.Text;
            _kullanici.Sifre = txt_Sifre.Text;
            _kullanici.Yonetici = chc_Admin.Checked;
            _kullanici.Aktif = chc_Aktif.Checked;
            
            if (_kullanici.Id == 0)
                _db.Kullanicilar.Add(_kullanici);
            else
            {
                var selectKullanici = _db.Kullanicilar.SingleOrDefault(x => x.Id == _kullanici.Id);

                selectKullanici.Ad = _kullanici.Ad;
                selectKullanici.Soyad = _kullanici.Soyad;
                selectKullanici.Eposta = _kullanici.Eposta;
                selectKullanici.Telefon = _kullanici.Telefon;
                selectKullanici.Yonetici = _kullanici.Yonetici;
                selectKullanici.Aktif = _kullanici.Aktif;
            }

            _db.SaveChanges();

            this.Close();
        }
    }
}
