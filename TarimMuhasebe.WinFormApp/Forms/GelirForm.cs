﻿using System;
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
    public partial class GelirForm : Form
    {
        private Gelir _gelir;
        private DatabaseContext _db;

        public GelirForm(Gelir gelir)
        {
            _gelir = gelir;
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

            cmb_Satis.DisplayMember = "Kod";
            cmb_Satis.ValueMember = "Id";

            List<Satis> satislar = new List<Satis>();
            satislar.Add(new Satis
            {
                Id = 0,
                Kod = "Yok"
            });

            satislar.AddRange(_db.Satislar.Where(x => !x.Tahsilat).ToList());
            cmb_Satis.DataSource = satislar;

            if (_gelir.Id != 0)
            {
                foreach (Control control in this.Controls)
                {
                    control.Enabled = false;
                }

                txt_Kod.Text = _gelir.Kod;
                nmbr_Tutar.Value = _gelir.Tutar;

                cmb_Cari.SelectedValue = _gelir.CariId;
                cmb_Kasa.SelectedValue = _gelir.KasaId;
                cmb_OdemeTip.SelectedValue = _gelir.OdemeTipId;

                if (_gelir.SatisId != null)
                    cmb_Satis.SelectedValue = _gelir.SatisId;
            }
            else
            {
                var last = _db.Gelirler.OrderByDescending(x => x.Id).FirstOrDefault();
                int number = 1;

                if (last != null)
                    number = last.Id + 1;

                txt_Kod.Text = $"GLR-{number.ToString("D10")}";
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
            Satis satis = (Satis)cmb_Satis.SelectedItem;

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

            selectKasa.GuncelTutar += tutar;

            Gelir gelir = new Gelir
            {
                Kod = kod,
                CariId = cari.Id,
                KasaId = kasa.Id,
                SatisId = satis.Id == 0 ? (int?)null : satis.Id,
                OdemeTipId = odemeTip.Id,
                Tutar = tutar,
                Aciklama = txt_Aciklama.Text,
                Tarih = DateTime.Now,
                Kullanici = Program.kullanici == null ? "Sistem" : $"{Program.kullanici.Ad} {Program.kullanici.Soyad}"
            };

            _db.Gelirler.Add(gelir);

            if (satis.Id != 0)
            {
                var selectSatis = _db.Satislar.SingleOrDefault(x => x.Id == satis.Id);
                selectSatis.Tahsilat = true;
            }

            _db.SaveChanges();

            if (MessageBox.Show("Gelir işlemi başarılı bir şekilde gerçekleştirildi.", "Bilgilendirme", MessageBoxButtons.OK) == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}
