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

namespace TarimMuhasebe.WinFormApp.Forms
{
    public partial class ProfilForm : Form
    {
        private DatabaseContext _db;

        public ProfilForm()
        {
            _db = new DatabaseContext(Program.ConnectionString);

            InitializeComponent();
            loadData();
        }

        private void loadData()
        {
            txt_Ad.Text = Program.kullanici.Ad;
            txt_Soyad.Text = Program.kullanici.Soyad;
            txt_Eposta.Text = Program.kullanici.Eposta;
            txt_Telefon.Text = Program.kullanici.Telefon;
        }

        private void btn_Kaydet_Click(object sender, EventArgs e)
        {
            bool status = false;

            string ad = txt_Ad.Text;
            string soyad = txt_Soyad.Text;
            string eposta = txt_Eposta.Text;
            string telefon = txt_Telefon.Text;

            if (string.IsNullOrEmpty(ad))
            {
                status = true;
                error.SetError(txt_Ad, "Boş geçilemez !");
            }

            if (string.IsNullOrEmpty(soyad))
            {
                status = true;
                error.SetError(txt_Soyad, "Boş geçilemez !");
            }

            if (string.IsNullOrEmpty(eposta))
            {
                status = true;
                error.SetError(txt_Eposta, "Boş geçilemez !");
            }

            if (status)
                return;

            var kullanici = _db.Kullanicilar.SingleOrDefault(x => x.Id == Program.kullanici.Id);

            kullanici.Ad = ad;
            kullanici.Soyad = soyad;
            kullanici.Eposta = eposta;
            kullanici.Telefon = telefon;

            _db.SaveChanges();

            Program.kullanici = kullanici;

            if (MessageBox.Show("Profil başarılı bir şekilde güncellendi.","Bilgilendirme",MessageBoxButtons.OK) == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}
