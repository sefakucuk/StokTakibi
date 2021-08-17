using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using TarimMuhasebe.DataAccess;
using TarimMuhasebe.Entities;
using TarimMuhasebe.WinFormApp.UserControls;

namespace TarimMuhasebe.WinFormApp.Forms
{
    public partial class UrunSatisForm : Form
    {
        private Satis _satis;
        private DatabaseContext _db;

        public UrunSatisForm(Satis satis)
        {
            _satis = satis;
            _db = new DatabaseContext(Program.ConnectionString);

            InitializeComponent();
            loadData();
        }

        private void loadData()
        {
            cmb_Cari.ValueMember = "Id";
            cmb_Cari.DisplayMember = "Unvan";
            cmb_Cari.DataSource = _db.Cariler.Where(x=>x.Aktif).ToList();

            cmb_Kasa.ValueMember = "Id";
            cmb_Kasa.DisplayMember = "Ad";
            cmb_Kasa.DataSource = _db.Kasalar.ToList();

            if (_satis.Id != 0)
            {
                foreach (Control control in this.Controls)
                {
                    control.Enabled = false;
                }

                txt_No.Text = _satis.Kod;
                txt_Aciklama.Text = _satis.Aciklama;

                cmb_Cari.SelectedValue = _satis.CariId;
                cmb_Kasa.SelectedValue = _satis.KasaId;

                chc_Tahsilat.Checked = _satis.Tahsilat;

                lbl_ToplamMatrah.Text = $"Toplam Matrah : {_satis.ToplamMatrahTutar} ₺";
                lbl_ToplamKdv.Text = $"Toplam Kdv : {_satis.ToplamKdvTutar} ₺";
                lbl_ToplamTutar.Text = $"Toplam Tutar : {_satis.ToplamMatrahTutar + _satis.ToplamKdvTutar} ₺";

                var satisDetaylar = _db.SatisDetaylari.Where(x => x.SatisId == _satis.Id).ToList();

                foreach (var detay in satisDetaylar)
                {
                    SatisDetayUC satisDetayUc = new SatisDetayUC(detay);
                    flw_Urunler.Controls.Add(satisDetayUc);
                }
            }
            else
            {
                var last = _db.Satislar.OrderByDescending(x => x.Id).FirstOrDefault();
                int number = 1;

                if (last != null)
                    number = last.Id + 1;

                txt_No.Text = $"STS-{number.ToString("D10")}";
            }
        }

        private void btn_YeniUrun_Click(object sender, EventArgs e)
        {
            SatisDetayUC satisDetayUc = new SatisDetayUC(new SatisDetay());
            satisDetayUc.IslemEvent += DetayUc_IslemEvent;
            flw_Urunler.Controls.Add(satisDetayUc);
        }

        private void DetayUc_IslemEvent(object sender, EventArgs e)
        {
            decimal toplamMatrah = 0;
            decimal toplamKdv = 0;

            foreach (Control control in flw_Urunler.Controls)
            {
                if (control is SatisDetayUC)
                {
                    SatisDetay satisDetay = ((SatisDetayUC)control)._satisDetay;
                    toplamMatrah += satisDetay.Matrah;
                    toplamKdv += satisDetay.Kdv;
                }
            }

            decimal toplamTutar = toplamMatrah + toplamKdv;

            lbl_ToplamMatrah.Text = $"Toplam Matrah : {toplamMatrah} ₺";
            lbl_ToplamKdv.Text = $"Toplam Kdv : {toplamKdv} ₺";
            lbl_ToplamTutar.Text = $"Toplam Tutar : {toplamTutar} ₺";
        }

        private void btn_Kaydet_Click(object sender, EventArgs e)
        {
            bool status = false;

            string kod = txt_No.Text;
            Cari cari = (Cari)cmb_Cari.SelectedItem;
            Kasa kasa = (Kasa)cmb_Kasa.SelectedItem;

            if (string.IsNullOrEmpty(kod))
            {
                status = true;
                error.SetError(txt_No, "Boş geçilemez !");
            }

            if (cari == null)
            {
                status = true;
                error.SetError(cmb_Cari, "Seçim yapınız !");
            }

            if (kasa == null)
            {
                status = true;
                error.SetError(cmb_Kasa, "Seçim yapınız !");
            }

            if (status)
                return;

            decimal toplamMatrah = 0;
            decimal toplamKdv = 0;

            foreach (Control control in flw_Urunler.Controls)
            {
                if (control is SatisDetayUC)
                {
                    SatisDetay satisDetay = ((SatisDetayUC)control)._satisDetay;
                    toplamMatrah += satisDetay.Matrah;
                    toplamKdv += satisDetay.Kdv;
                }
            }

            _satis.CariId = cari.Id;
            _satis.KasaId = kasa.Id;
            _satis.Kod = txt_No.Text;
            _satis.ToplamMatrahTutar = toplamMatrah;
            _satis.ToplamKdvTutar = toplamKdv;
            _satis.Tarih = DateTime.Now;
            _satis.Kullanici = Program.kullanici == null ? "Sistem" : $"{Program.kullanici.Ad} {Program.kullanici.Soyad}";
            _satis.Aciklama = txt_Aciklama.Text;
            _satis.Tahsilat = chc_Tahsilat.Checked;

            _db.Satislar.Add(_satis);

            if (_satis.Tahsilat)
            {
                Kasa selectKasa = _db.Kasalar.SingleOrDefault(x => x.Id == kasa.Id);
                selectKasa.GuncelTutar += _satis.ToplamMatrahTutar + _satis.ToplamKdvTutar;
            }

            _db.SaveChanges();

            foreach (Control control in flw_Urunler.Controls)
            {
                if (control is SatisDetayUC)
                {
                    SatisDetay satisDetay = ((SatisDetayUC)control)._satisDetay;
                    satisDetay.SatisId = _satis.Id;

                    _db.SatisDetaylari.Add(satisDetay);
                }
            }

            _db.SaveChanges();

            if (MessageBox.Show("Satış işlemi başarılı bir şekilde gerçekleştirildi.","Bilgilendirme",MessageBoxButtons.OK) == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}
