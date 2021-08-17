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
    public partial class TransferForm : Form
    {
        private DatabaseContext _db;

        public TransferForm()
        {
            _db = new DatabaseContext(Program.ConnectionString);

            InitializeComponent();
            loadData();
        }

        private void loadData()
        {
            cmb_CikisDepo.DisplayMember = "Ad";
            cmb_CikisDepo.ValueMember = "Id";
            cmb_CikisDepo.DataSource = _db.Depolar.ToList();

            cmb_GirisDepo.DisplayMember = "Ad";
            cmb_GirisDepo.ValueMember = "Id";
            cmb_GirisDepo.DataSource = _db.Depolar.ToList();

            cmb_Urun.DisplayMember = "Ad";
            cmb_Urun.ValueMember = "Id";
            cmb_Urun.DataSource = _db.Urunler.ToList();
        }

        private void btn_Kaydet_Click(object sender, EventArgs e)
        {
            error.Clear();

            bool status = false;
            bool status2 = false;

            Depo cikisDepo = (Depo)cmb_CikisDepo.SelectedItem;
            Depo girisDepo = (Depo)cmb_GirisDepo.SelectedItem;
            Urun selectUrun = (Urun)cmb_Urun.SelectedItem;
            decimal miktar = nmbr_Miktar.Value;

            if (cikisDepo == null)
            {
                status = true;
                error.SetError(cmb_CikisDepo, "Boş geçilemez !");
            }

            if (girisDepo == null)
            {
                status = true;
                error.SetError(cmb_GirisDepo, "Boş geçilemez !");
            }

            if (selectUrun == null)
            {
                status = true;
                error.SetError(cmb_Urun, "Boş geçilemez !");
            }

            if (miktar == 0)
            {
                status = true;
                error.SetError(nmbr_Miktar, "Değer giriniz !");
            }

            if (status)
                return;

            if (cikisDepo.Id == girisDepo.Id)
            {
                status2 = true;
                error.SetError(cmb_CikisDepo, "Aynı depolar arası transfer yapılamaz !");
                error.SetError(cmb_GirisDepo, "Aynı depolar arası transfer yapılamaz !");
            }

            var cikisStok = _db.Stoklar.FirstOrDefault(x => x.DepoId == cikisDepo.Id && x.UrunId == selectUrun.Id);

            if (cikisStok == null)
            {
                status2 = true;
                error.SetError(cmb_Urun, "Çıkış deposunda seçili ürün mevcut değil !");
            }

            if (cikisStok != null && cikisStok.Miktar < miktar)
            {
                status2 = true;
                error.SetError(nmbr_Miktar, "Çıkış deposunda seçili üründen yeterli miktarda mevcut değil !");
            }

            if (status2)
                return;

            var girisStok = _db.Stoklar.FirstOrDefault(x => x.DepoId == girisDepo.Id && x.UrunId == selectUrun.Id);

            cikisStok.Miktar -= miktar;

            if (girisStok == null)
            {
                girisStok = new Stok
                {
                    DepoId = girisDepo.Id,
                    UrunId = selectUrun.Id,
                    Miktar = miktar
                };

                _db.Stoklar.Add(girisStok);
            }
            else
            {
                girisStok.Miktar += miktar;
            }

            _db.SaveChanges();

            if (MessageBox.Show("Transfer işlemi başarılı bir şekilde gerçekleştirildi.", "Bilgilendirme", MessageBoxButtons.OK) == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}
