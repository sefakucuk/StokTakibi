using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TarimMuhasebe.Core.Helper;
using TarimMuhasebe.DataAccess;
using TarimMuhasebe.Entities;
using TarimMuhasebe.WinFormApp.Forms;

namespace TarimMuhasebe.WinFormApp.UserControls
{
    public partial class UrunSatisUC : UserControl
    {
        private DatabaseContext _db;
        private UrunSatisForm urunSatisForm;

        public UrunSatisUC()
        {
            InitializeComponent();

            _db = new DatabaseContext(Program.ConnectionString);

            loadData();
        }

        private void btn_YeniKayit_Click(object sender, EventArgs e)
        {
            urunSatisForm = new UrunSatisForm(new Satis());
            urunSatisForm.StartPosition = FormStartPosition.CenterScreen;
            urunSatisForm.FormClosed += UrunSatisForm_FormClosed;
            urunSatisForm.ShowDialog();
        }

        private void UrunSatisForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.mainForm.loadData();
        }

        public void loadData()
        {
            this.dgv_Data.DataSource = null;

            var data = _db.Satislar.Include("Cari").Include("Kasa").Select(x => new
            {
                Id = x.Id,
                Kod = x.Kod,
                CariId = x.CariId,
                KasaId = x.KasaId,
                Cari = x.Cari.Unvan,
                Kasa = x.Kasa.Ad,
                ToplamMatrahTutar = x.ToplamMatrahTutar + " ₺",
                ToplamKdvTutar = x.ToplamKdvTutar + " ₺",
                Tarih = x.Tarih,
                Kullanici = x.Kullanici,
                Tahsilat = x.Tahsilat
            }).OrderByDescending(x => x.Tarih).ToList();

            this.dgv_Data.DataSource = data;
            this.dgv_Data.ClearSelection();
        }

        private void dgv_Data_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                int rowSelected = e.RowIndex;

                if (e.RowIndex != -1)
                {
                    this.dgv_Data.ClearSelection();
                    this.dgv_Data.Rows[rowSelected].Selected = true;

                    MenuItem report = new MenuItem("Rapor");
                    MenuItem show = new MenuItem("İncele");
                    MenuItem delete = new MenuItem("Kaldır");

                    report.Click += Report_Click;
                    show.Click += Show_Click;
                    delete.Click += Delete_Click;

                    ContextMenu menu = new ContextMenu();
                    menu.MenuItems.Add(report);
                    menu.MenuItems.Add(show);
                    menu.MenuItems.Add(delete);

                    var mousePosition = dgv_Data.PointToClient(Cursor.Position);

                    menu.Show(dgv_Data, mousePosition);
                }
            }
        }

        private void Report_Click(object sender, EventArgs e)
        {
            var selectedRow = dgv_Data.SelectedRows[0];
            int Id = (int)selectedRow.Cells["Id"].Value;

            Satis selectSatis = _db.Satislar.SingleOrDefault(x => x.Id == Id);

            List<Cari> cariler = _db.Cariler.Where(x => x.Id == selectSatis.CariId).ToList();
            List<Satis> satislar = new List<Satis>();
            List<SatisDetay> detaylar = _db.SatisDetaylari.Where(x => x.SatisId == selectSatis.Id).ToList();
            List<Urun> urunler = new List<Urun>();
            List<Birim> birimler = _db.Birimler.ToList();

            satislar.Add(selectSatis);

            foreach (var detay in detaylar)
            {
                urunler.Add(_db.Urunler.SingleOrDefault(x => x.Id == detay.UrunId));
            }

            ReportDocument rd = new ReportDocument();

            string address = Reporting.GetAddress("SatısRapor.rpt");

            rd.Load(Reporting.GetAddress("SatısRapor.rpt"));

            rd.Database.Tables[0].SetDataSource(cariler);
            rd.Database.Tables[1].SetDataSource(satislar);
            rd.Database.Tables[2].SetDataSource(detaylar);
            rd.Database.Tables[3].SetDataSource(urunler);
            rd.Database.Tables[4].SetDataSource(birimler);

            RaporForm raporForm = new RaporForm(rd);
            raporForm.ShowDialog();

            rd.Close();
            rd.Dispose();
        }

        private void Show_Click(object sender, System.EventArgs e)
        {
            var selectedRow = dgv_Data.SelectedRows[0];
            int Id = (int)selectedRow.Cells["Id"].Value;

            Satis selectSatis = _db.Satislar.SingleOrDefault(x => x.Id == Id);

            urunSatisForm = new UrunSatisForm(selectSatis);
            urunSatisForm.StartPosition = FormStartPosition.CenterScreen;
            urunSatisForm.FormClosed += UrunSatisForm_FormClosed;
            urunSatisForm.ShowDialog();
        }

        private void Delete_Click(object sender, System.EventArgs e)
        {
            var selectedRow = dgv_Data.SelectedRows[0];

            int Id = (int)selectedRow.Cells["Id"].Value;

            if (MessageBox.Show($"Seçili işlemi silmek istediğinize eminmisiniz ?", "Uyarı", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Satis satis = _db.Satislar.SingleOrDefault(x => x.Id == Id);

                Kasa kasa = _db.Kasalar.SingleOrDefault(x => x.Id == satis.KasaId);
                kasa.GuncelTutar += satis.ToplamKdvTutar + satis.ToplamMatrahTutar;

                List<SatisDetay> detaylar = _db.SatisDetaylari.Where(x => x.SatisId == satis.Id).ToList();

                foreach (var detay in detaylar)
                {
                    Stok stok = _db.Stoklar.FirstOrDefault(x => x.DepoId == detay.DepoId && x.UrunId == detay.UrunId);
                    stok.Miktar -= detay.Miktar;
                }

                _db.Satislar.Remove(satis);
                _db.SaveChanges();
            }
        }
    }
}
