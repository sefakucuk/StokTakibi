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

namespace TarimMuhasebe.WinFormApp.UserControls
{
    public partial class SatisDetayUC : UserControl
    {
        public event EventHandler IslemEvent;

        private DatabaseContext _db;
        public SatisDetay _satisDetay;

        public SatisDetayUC(SatisDetay satisDetay)
        {
            _db = new DatabaseContext(Program.ConnectionString);
            _satisDetay = satisDetay;

            InitializeComponent();

            loadData();
        }

        private void loadData()
        {
            cmb_Urun.ValueMember = "Id";
            cmb_Urun.DisplayMember = "Ad";
            cmb_Urun.DataSource = _db.Urunler.ToList();

            if (_satisDetay.Id != 0)
            {
                foreach (Control control in this.Controls)
                {
                    control.Enabled = false;
                }

                cmb_Urun.SelectedValue = _satisDetay.UrunId;
                cmb_Depo.SelectedValue = _satisDetay.DepoId;
                nmr_KdvOrani.Value = _satisDetay.KdvOrani;
                nmbr_Miktar.Value = _satisDetay.Miktar;
                nmbr_BirimFiyat.Value = _satisDetay.BirimFiyat;
                lbl_Matrah.Text = $"Matrah : {_satisDetay.Matrah} ₺";
                lbl_Kdv.Text = $"Kdv : {_satisDetay.Kdv} ₺";
                lbl_Toplam.Text = $"Toplam : {_satisDetay.Matrah + _satisDetay.Kdv} ₺";
            }
        }

        private void pic_Kaldir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void cmb_Urun_SelectedValueChanged(object sender, EventArgs e)
        {
            if (_satisDetay.Id != 0)
                return;

            Urun urun = (Urun)cmb_Urun.SelectedItem;

            if (urun == null)
                return;

            nmbr_BirimFiyat.Value = urun.SatisFiyat;
            nmr_KdvOrani.Value = urun.Kdv;

            var depoList = _db.Stoklar.Where(x => x.UrunId == urun.Id).Select(x => x.DepoId).ToList();

            cmb_Depo.ValueMember = "Id";
            cmb_Depo.DisplayMember = "Ad";
            cmb_Depo.DataSource = _db.Depolar.Where(x => depoList.Contains(x.Id)).ToList();

            Esitleme();
        }

        private void cmb_Depo_SelectedValueChanged(object sender, EventArgs e)
        {
            if (_satisDetay.Id != 0)
                return;

            Urun urun = (Urun)cmb_Urun.SelectedItem;
            Depo depo = (Depo)cmb_Depo.SelectedItem;

            if (depo == null)
                return;

            var stok = _db.Stoklar.FirstOrDefault(x => x.UrunId == urun.Id && x.DepoId == depo.Id);

            if (stok == null)
                nmbr_Miktar.Maximum = 0;
            else
                nmbr_Miktar.Maximum = stok.Miktar;

            Esitleme();
        }

        private void Hesap_ValueChanged(object sender, EventArgs e)
        {
            if (_satisDetay.Id != 0)
                return;

            Esitleme();

            lbl_Matrah.Text = $"Matrah : {_satisDetay.Matrah} ₺";
            lbl_Kdv.Text = $"Kdv : {_satisDetay.Kdv} ₺";
            lbl_Toplam.Text = $"Toplam : {_satisDetay.Matrah + _satisDetay.Kdv} ₺";
        }

        private void Esitleme()
        {
            if (_satisDetay.Id != 0)
                return;

            Urun urun = (Urun)cmb_Urun.SelectedItem;
            Depo depo = (Depo)cmb_Depo.SelectedItem;

            if (urun == null || depo == null)
                return;

            decimal kdvOrani = nmr_KdvOrani.Value;
            decimal miktar = nmbr_Miktar.Value;
            decimal birimFiyat = nmbr_BirimFiyat.Value;
            decimal matrah = miktar * birimFiyat;
            decimal kdvTutar = ((miktar * birimFiyat) * kdvOrani) / 100; ;

            _satisDetay.UrunId = urun.Id;
            _satisDetay.DepoId = depo.Id;
            _satisDetay.Miktar = nmbr_Miktar.Value;
            _satisDetay.BirimFiyat = nmbr_BirimFiyat.Value;
            _satisDetay.Aciklama = txt_Aciklama.Text;
            _satisDetay.Matrah = matrah;
            _satisDetay.KdvOrani = nmr_KdvOrani.Value;
            _satisDetay.Kdv = kdvTutar;

            IslemEvent?.Invoke(_satisDetay, null);
        }
    }
}
