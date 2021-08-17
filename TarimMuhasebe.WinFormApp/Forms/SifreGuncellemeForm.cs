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
    public partial class SifreGuncellemeForm : Form
    {
        private DatabaseContext _db;

        public SifreGuncellemeForm()
        {
            _db = new DatabaseContext(Program.ConnectionString);

            InitializeComponent();
        }

        private void btn_Kaydet_Click(object sender, EventArgs e)
        {
            bool status = false;
            bool status2 = false;

            string mevcutSifre = txt_MevcutSifre.Text;
            string yeniSifre = txt_YeniSifre.Text;
            string yeniSifreTekrar = txt_YeniSifreTekrar.Text;

            if (string.IsNullOrEmpty(mevcutSifre))
            {
                status = true;
                error.SetError(txt_MevcutSifre, "Boş geçilemez !");
            }

            if (string.IsNullOrEmpty(yeniSifre))
            {
                status = true;
                error.SetError(txt_YeniSifre, "Boş geçilemez !");
            }

            if (string.IsNullOrEmpty(yeniSifreTekrar))
            {
                status = true;
                error.SetError(txt_YeniSifreTekrar, "Boş geçilemez !");
            }

            if (status)
                return;

            if (Program.kullanici.Sifre != mevcutSifre)
            {
                status2 = true;
                error.SetError(txt_MevcutSifre, "Mevcut şifre yalnış !");
            }

            if (yeniSifre != yeniSifreTekrar)
            {
                status2 = true;
                error.SetError(txt_YeniSifre, "Şifreler uyuşmuyor !");
                error.SetError(txt_YeniSifreTekrar, "Şifreler uyuşmuyor !");
            }

            if (status2)
                return;

            Kullanici kullanici = _db.Kullanicilar.SingleOrDefault(x => x.Id == Program.kullanici.Id);
            kullanici.Sifre = yeniSifre;
            _db.SaveChanges();

            if (MessageBox.Show("Şifre başarılı bir şekilde güncellendi.","Bilgilendirme",MessageBoxButtons.OK) == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}
