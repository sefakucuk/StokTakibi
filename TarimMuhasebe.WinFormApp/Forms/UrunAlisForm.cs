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
    public partial class UrunAlisForm : Form
    {
        private Alis _alis;
        private DatabaseContext _db;

        public UrunAlisForm(Alis alis)
        {
            _alis = alis;
            _db = new DatabaseContext(Program.ConnectionString);

            InitializeComponent();
            loadData();
        }

        public void loadData()
        {
            cmb_Cari.DisplayMember = "Unvan";
            cmb_Cari.ValueMember = "Id";
            cmb_Cari.DataSource = _db.Cariler.Where(x => x.Aktif).ToList();

            cmb_Urun.DisplayMember = "Ad";
            cmb_Urun.ValueMember = "Id";
            cmb_Urun.DataSource = _db.Urunler.ToList();

            cmb_Depo.DisplayMember = "Ad";
            cmb_Depo.ValueMember = "Id";
            cmb_Depo.DataSource = _db.Depolar.ToList();

            cmb_Kasa.DisplayMember = "Ad";
            cmb_Kasa.ValueMember = "Id";
            cmb_Kasa.DataSource = _db.Kasalar.ToList();

            if (_alis.Id != 0)
            {
                foreach (Control control in this.Controls)
                {
                    control.Enabled = false;
                }

                txt_No.Text = _alis.Kod;
                lbl_Toplam.Text = _alis.ToplamFiyat.ToString();
                chc_Stopaj.Checked = _alis.StopajDahil;
                nmbr_BirimFiyat.Value = _alis.BirimFiyat;
                nmbr_Miktar.Value = _alis.Miktar;
                nmbr_Stopaj.Value = _alis.StopajOrani;

                cmb_Cari.SelectedValue = _alis.CariId;
                cmb_Urun.SelectedValue = _alis.UrunId;
                cmb_Depo.SelectedValue = _alis.DepoId;
                cmb_Kasa.SelectedValue = _alis.KasaId;
            }
            else
            {
                var last = _db.Alislar.OrderByDescending(x => x.Id).FirstOrDefault();
                int number = 1;

                if (last != null)
                    number = last.Id + 1;

                txt_No.Text = $"ALS-{number.ToString("D10")}";
            }
        }

        private void btn_Kaydet_Click(object sender, EventArgs e)
        {
            error.Clear();

            bool status = false;

            string no = txt_No.Text;
            string aciklama = txt_Aciklama.Text;
            bool stopajDahil = chc_Stopaj.Checked;

            Cari cari = (Cari)cmb_Cari.SelectedItem;
            Urun urun = (Urun)cmb_Urun.SelectedItem;
            Depo depo = (Depo)cmb_Depo.SelectedItem;
            Kasa kasa = (Kasa)cmb_Kasa.SelectedItem;

            decimal stopajOrani = nmbr_Stopaj.Value / 100;
            decimal miktar = nmbr_Miktar.Value;
            decimal birimFiyat = nmbr_BirimFiyat.Value;
            decimal toplam = miktar * birimFiyat;

            decimal stopajTutar = stopajDahil ? toplam * stopajOrani : 0;
            toplam = toplam + stopajTutar;

            if (string.IsNullOrEmpty(no))
            {
                status = true;
                error.SetError(txt_No, "Boş geçilemez !");
            }

            if (cari == null)
            {
                status = true;
                error.SetError(cmb_Cari, "Boş geçilemez !");
            }

            if (urun == null)
            {
                status = true;
                error.SetError(cmb_Urun, "Boş geçilemez !");
            }

            if (depo == null)
            {
                status = true;
                error.SetError(cmb_Depo, "Boş geçilemez !");
            }

            if (kasa == null)
            {
                status = true;
                error.SetError(cmb_Kasa, "Boş geçilemez !");
            }

            if (miktar == 0)
            {
                status = true;
                error.SetError(nmbr_Miktar, "Değer giriniz !");
            }

            if (birimFiyat == 0)
            {
                status = true;
                error.SetError(nmbr_BirimFiyat, "Değer giriniz !");
            }

            if (status)
                return;

            Stok selectStok = _db.Stoklar.FirstOrDefault(x => x.DepoId == depo.Id && x.UrunId == urun.Id);
            Kasa selectKasa = _db.Kasalar.SingleOrDefault(x => x.Id == kasa.Id);

            if (selectKasa.GuncelTutar < toplam)
            {
                if (MessageBox.Show("Kasa miktarı yetersiz devam etmek istiyormusunuz ? (Kasa eksi değere düşürülecek)", "Uyarı", MessageBoxButtons.YesNo) == DialogResult.No)
                    return;
            }

            if (selectStok == null)
            {
                selectStok = new Stok
                {
                    DepoId = depo.Id,
                    UrunId = urun.Id,
                    Miktar = miktar
                };

                _db.Stoklar.Add(selectStok);
            }
            else
            {
                selectStok.Miktar += miktar;
            }

            selectKasa.GuncelTutar -= toplam;

            Alis alis = new Alis
            {
                Kod = no,
                CariId = cari.Id,
                UrunId = urun.Id,
                DepoId = depo.Id,
                KasaId = kasa.Id,
                Miktar = miktar,
                BirimFiyat = birimFiyat,
                StopajOrani = nmbr_Stopaj.Value,
                StopajTutar = stopajTutar,
                StopajDahil = chc_Stopaj.Checked,
                ToplamFiyat = toplam,
                Aciklama = txt_Aciklama.Text,
                Tarih = DateTime.Now,
                Kullanici = Program.kullanici == null ? "Sistem" : $"{Program.kullanici.Ad} {Program.kullanici.Soyad}"
            };

            _db.Alislar.Add(alis);
            _db.SaveChanges();

            if (MessageBox.Show("Alış işlemi başarılı bir şekilde gerçekleştirildi.", "Bilgilendirme", MessageBoxButtons.OK) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void Toplam_ValueChanged(object sender, EventArgs e)
        {
            bool stopajDahil = chc_Stopaj.Checked;

            decimal miktar = nmbr_Miktar.Value;
            decimal birimFiyat = nmbr_BirimFiyat.Value;
            decimal toplam = birimFiyat * miktar;

            decimal stopajOran = nmbr_Stopaj.Value / 100;
            decimal stopajTutar = stopajDahil ? toplam * stopajOran : 0;
            toplam = toplam + stopajTutar;

            lbl_Toplam.Text = $"Toplam : {toplam} ₺";
        }

        private void cmb_Urun_SelectedValueChanged(object sender, EventArgs e)
        {
            Urun urun = (Urun)cmb_Urun.SelectedItem;

            if (urun == null)
                return;

            nmbr_BirimFiyat.Value = urun.AlisFiyat;
            nmbr_Stopaj.Value = urun.Stopaj;
        }
    }
}
