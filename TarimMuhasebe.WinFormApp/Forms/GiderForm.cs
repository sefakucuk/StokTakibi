using System;
using System.Linq;
using System.Windows.Forms;
using TarimMuhasebe.DataAccess;
using TarimMuhasebe.Entities;

namespace TarimMuhasebe.WinFormApp.Forms
{
    public partial class GiderForm : Form
    {
        private Gider _gider;
        private DatabaseContext _db;

        public GiderForm(Gider gider)
        {
            _gider = gider;
            _db = new DatabaseContext(Program.ConnectionString);

            InitializeComponent();
            loadData();
        }

        public void loadData()
        {
            cmb_Cari.DisplayMember = "Unvan";
            cmb_Cari.ValueMember = "Id";
            cmb_Cari.DataSource = _db.Cariler.Where(x => x.Aktif).ToList();

            cmb_OdemeTip.DisplayMember = "Ad";
            cmb_OdemeTip.ValueMember = "Id";
            cmb_OdemeTip.DataSource = _db.OdemeTipleri.ToList();

            cmb_Kasa.DisplayMember = "Ad";
            cmb_Kasa.ValueMember = "Id";
            cmb_Kasa.DataSource = _db.Kasalar.ToList();

            if (_gider.Id != 0)
            {
                foreach (Control control in this.Controls)
                {
                    control.Enabled = false;
                }

                txt_Kod.Text = _gider.Kod;
                nmbr_Tutar.Value = _gider.Tutar;

                cmb_Cari.SelectedValue = _gider.CariId;
                cmb_Kasa.SelectedValue = _gider.KasaId;
                cmb_OdemeTip.SelectedValue = _gider.OdemeTipId;
            }
            else
            {
                var last = _db.Giderler.OrderByDescending(x => x.Id).FirstOrDefault();
                int number = 1;

                if (last != null)
                    number = last.Id + 1;

                txt_Kod.Text = $"GDR-{number.ToString("D10")}";
            }
        }

        private void btn_Kaydet_Click(object sender, EventArgs e)
        {
            error.Clear();

            bool status = false;

            string kod = txt_Kod.Text;
            string aciklama = txt_Aciklama.Text;

            Cari cari = (Cari)cmb_Cari.SelectedItem;
            Kasa kasa = (Kasa)cmb_Kasa.SelectedItem;
            OdemeTip odemeTip = (OdemeTip)cmb_OdemeTip.SelectedItem;

            decimal tutar = nmbr_Tutar.Value;

            if (string.IsNullOrEmpty(kod))
            {
                status = true;
                error.SetError(txt_Kod, "Boş geçilemez !");
            }

            if (cari == null)
            {
                status = true;
                error.SetError(cmb_Cari, "Boş geçilemez !");
            }

            if (odemeTip == null)
            {
                status = true;
                error.SetError(cmb_OdemeTip, "Boş geçilemez !");
            }

            if (kasa == null)
            {
                status = true;
                error.SetError(cmb_Kasa, "Boş geçilemez !");
            }

            if (tutar == 0)
            {
                status = true;
                error.SetError(nmbr_Tutar, "Değer giriniz !");
            }

            if (status)
                return;

            Kasa selectKasa = _db.Kasalar.SingleOrDefault(x => x.Id == kasa.Id);

            if (selectKasa.GuncelTutar < tutar)
            {
                if (MessageBox.Show("Kasa miktarı yetersiz devam etmek istiyormusunuz ? (Kasa eksi değere düşürülecek)", "Uyarı", MessageBoxButtons.YesNo) == DialogResult.No)
                    return;
            }

            selectKasa.GuncelTutar -= tutar;

            Gider gider = new Gider
            {
                Kod = kod,
                CariId = cari.Id,
                KasaId = kasa.Id,
                OdemeTipId = odemeTip.Id,
                Tutar = tutar,
                Aciklama = txt_Aciklama.Text,
                Tarih = DateTime.Now,
                Kullanici = Program.kullanici == null ? "Sistem" : $"{Program.kullanici.Ad} {Program.kullanici.Soyad}"
            };

            _db.Giderler.Add(gider);
            _db.SaveChanges();

            if (MessageBox.Show("Gider işlemi başarılı bir şekilde gerçekleştirildi.", "Bilgilendirme", MessageBoxButtons.OK) == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}
