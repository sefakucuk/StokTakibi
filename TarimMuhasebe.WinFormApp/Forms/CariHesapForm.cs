using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TarimMuhasebe.Core.Helper;
using TarimMuhasebe.DataAccess;
using TarimMuhasebe.Entities;
using TarimMuhasebe.Entities.ViewModels;

namespace TarimMuhasebe.WinFormApp.Forms
{
    public partial class CariHesapForm : Form
    {
        private DatabaseContext _db;
        private Cari _cari;

        public CariHesapForm(Cari cari)
        {
            _cari = cari;
            _db = new DatabaseContext(Program.ConnectionString);

            InitializeComponent();

            this.Text = $"{ cari.Unvan} Cari Hesapları";

            loadData();
        }

        private void loadData()
        {
            var listAlis = _db.Alislar.Include("Kasa").Where(x => x.CariId == _cari.Id).ToList();
            var listSatis = _db.Satislar.Include("Kasa").Where(x => x.CariId == _cari.Id && x.Tahsilat).ToList();
            var listGelir = _db.Gelirler.Include("Kasa").Where(x => x.CariId == _cari.Id).ToList();
            var listGider = _db.Giderler.Include("Kasa").Where(x => x.CariId == _cari.Id).ToList();

            List<CariHesapViewModel> viewModels = new List<CariHesapViewModel>();

            listAlis.ForEach(x =>
            {
                viewModels.Add(new CariHesapViewModel
                {
                    Id = x.Id,
                    Kod = x.Kod,
                    Kasa = x.Kasa.Ad,
                    Tarih = x.Tarih,
                    Kullanici = x.Kullanici,
                    Tip = "ÜRÜN ALIŞ",
                    Tutar = x.ToplamFiyat * -1
                });
            });

            listSatis.ForEach(x =>
            {
                viewModels.Add(new CariHesapViewModel
                {
                    Id = x.Id,
                    Kod = x.Kod,
                    Kasa = x.Kasa.Ad,
                    Tarih = x.Tarih,
                    Kullanici = x.Kullanici,
                    Tip = "ÜRÜN SATIŞ",
                    Tutar = x.ToplamKdvTutar + x.ToplamMatrahTutar
                });
            });

            listGelir.ForEach(x =>
            {
                viewModels.Add(new CariHesapViewModel
                {
                    Id = x.Id,
                    Kod = x.Kod,
                    Kasa = x.Kasa.Ad,
                    Tarih = x.Tarih,
                    Kullanici = x.Kullanici,
                    Tip = "GELİR",
                    Tutar = x.Tutar
                });
            });

            listGider.ForEach(x =>
            {
                viewModels.Add(new CariHesapViewModel
                {
                    Id = x.Id,
                    Kod = x.Kod,
                    Kasa = x.Kasa.Ad,
                    Tarih = x.Tarih,
                    Kullanici = x.Kullanici,
                    Tip = "GİDER",
                    Tutar = x.Tutar * -1
                });
            });

            dgv_Data.DataSource = null;
            dgv_Data.DataSource = viewModels.OrderByDescending(x => x.Tarih).ToList();

            decimal toplam = viewModels.Sum(x => x.Tutar);

            lbl_Toplam.Text = $"Toplam Tutar : {toplam} TL";

            if (toplam >= 0)
                tool_Bottom.BackColor = Color.LightGreen;
            else
                tool_Bottom.BackColor = Color.OrangeRed;
        }

        private void btn_Raporlama_Click(object sender, EventArgs e)
        {
            List<Cari> cariler = new List<Cari>();
            List<CariHesapViewModel> hesaplar = new List<CariHesapViewModel>();

            var listAlis = _db.Alislar.Include("Kasa").Where(x => x.CariId == _cari.Id).ToList();
            var listSatis = _db.Satislar.Include("Kasa").Where(x => x.CariId == _cari.Id && x.Tahsilat).ToList();
            var listGelir = _db.Gelirler.Include("Kasa").Where(x => x.CariId == _cari.Id).ToList();
            var listGider = _db.Giderler.Include("Kasa").Where(x => x.CariId == _cari.Id).ToList();

            listAlis.ForEach(x =>
            {
                hesaplar.Add(new CariHesapViewModel
                {
                    Id = x.Id,
                    Kod = x.Kod,
                    Kasa = x.Kasa.Ad,
                    Tarih = x.Tarih,
                    Kullanici = x.Kullanici,
                    Tip = "ÜRÜN ALIŞ",
                    Tutar = x.ToplamFiyat * -1
                });
            });

            listSatis.ForEach(x =>
            {
                hesaplar.Add(new CariHesapViewModel
                {
                    Id = x.Id,
                    Kod = x.Kod,
                    Kasa = x.Kasa.Ad,
                    Tarih = x.Tarih,
                    Kullanici = x.Kullanici,
                    Tip = "ÜRÜN SATIŞ",
                    Tutar = x.ToplamKdvTutar + x.ToplamMatrahTutar
                });
            });

            listGelir.ForEach(x =>
            {
                hesaplar.Add(new CariHesapViewModel
                {
                    Id = x.Id,
                    Kod = x.Kod,
                    Kasa = x.Kasa.Ad,
                    Tarih = x.Tarih,
                    Kullanici = x.Kullanici,
                    Tip = "GELİR",
                    Tutar = x.Tutar
                });
            });

            listGider.ForEach(x =>
            {
                hesaplar.Add(new CariHesapViewModel
                {
                    Id = x.Id,
                    Kod = x.Kod,
                    Kasa = x.Kasa.Ad,
                    Tarih = x.Tarih,
                    Kullanici = x.Kullanici,
                    Tip = "GİDER",
                    Tutar = x.Tutar * -1
                });
            });

            cariler.Add(_cari);

            ReportDocument rd = new ReportDocument();

            string address = Reporting.GetAddress("CariHesap.rpt");

            rd.Load(Reporting.GetAddress("CariHesap.rpt"));

            rd.Database.Tables[0].SetDataSource(cariler);
            rd.Database.Tables[1].SetDataSource(hesaplar.OrderByDescending(x=>x.Tarih));

            RaporForm raporForm = new RaporForm(rd);
            raporForm.ShowDialog();

            rd.Close();
            rd.Dispose();
        }
    }
}
