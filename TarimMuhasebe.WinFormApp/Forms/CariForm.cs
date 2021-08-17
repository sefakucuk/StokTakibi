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
    public partial class CariForm : Form
    {
        private DatabaseContext _db;
        private Cari _cari;

        public CariForm(Cari cari)
        {
            _db = new DatabaseContext(Program.ConnectionString);
            _cari = cari;

            InitializeComponent();

            loadData();
        }

        public void loadData()
        {
            txt_Kod.Text = _cari.Kod;
            txt_Unvan.Text = _cari.Unvan;
            txt_VergiNo.Text = _cari.VergiNo;
            txt_VergiDairesi.Text = _cari.VergiDairesi;
            txt_Yetkili.Text = _cari.Yetkili;
            txt_Il.Text = _cari.Il;
            txt_Ilce.Text = _cari.Ilce;
            txt_Adres.Text = _cari.Adres;
            txt_Tel1.Text = _cari.Tel1;
            txt_Tel2.Text = _cari.Tel2;
            txt_Eposta1.Text = _cari.Eposta1;
            txt_Eposta2.Text = _cari.Eposta2;
            txt_Fax.Text = _cari.Fax;
            chc_Aktif.Checked = _cari.Aktif;

            if (_cari.Id == 0)
            {
                var last = _db.Cariler.OrderByDescending(x=>x.Id).FirstOrDefault();
                int number = 1;

                if (last != null)
                    number = last.Id + 1;

                txt_Kod.Text = $"CR-{number.ToString("D10")}";
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

            if (string.IsNullOrEmpty(txt_Unvan.Text))
            {
                status = true;
                error.SetError(txt_Unvan, "Boş geçilemez !");
            }

            if (string.IsNullOrEmpty(txt_VergiNo.Text))
            {
                status = true;
                error.SetError(txt_VergiNo, "Boş geçilemez !");
            }

            if (status)
                return;

            _cari.Kod = txt_Kod.Text;
            _cari.Unvan = txt_Unvan.Text;
            _cari.VergiNo = txt_VergiNo.Text;
            _cari.VergiDairesi = txt_VergiDairesi.Text;
            _cari.Yetkili = txt_Yetkili.Text;
            _cari.Il = txt_Il.Text;
            _cari.Ilce = txt_Ilce.Text;
            _cari.Adres = txt_Adres.Text;
            _cari.Tel1 = txt_Tel1.Text;
            _cari.Tel2 = txt_Tel2.Text;
            _cari.Eposta1 = txt_Eposta1.Text;
            _cari.Eposta2 = txt_Eposta2.Text;
            _cari.Fax = txt_Fax.Text;
            _cari.Aktif = chc_Aktif.Checked;

            if (_cari.Id == 0)
                _db.Cariler.Add(_cari);
            else
            {
                var selectCari = _db.Cariler.SingleOrDefault(x => x.Id == _cari.Id);

                selectCari.Kod = _cari.Kod;
                selectCari.Unvan = _cari.Unvan;
                selectCari.VergiNo = _cari.VergiNo;
                selectCari.VergiDairesi = _cari.VergiDairesi;
                selectCari.Yetkili = _cari.Yetkili;
                selectCari.Il = _cari.Il;
                selectCari.Ilce = _cari.Ilce;
                selectCari.Adres = _cari.Adres;
                selectCari.Tel1 = _cari.Tel1;
                selectCari.Tel2 = _cari.Tel2;
                selectCari.Eposta1 = _cari.Eposta1;
                selectCari.Eposta2 = _cari.Eposta2;
                selectCari.Fax = _cari.Fax;
                selectCari.Aktif = _cari.Aktif;
            }

            _db.SaveChanges();

            this.Close();
        }
    }
}
