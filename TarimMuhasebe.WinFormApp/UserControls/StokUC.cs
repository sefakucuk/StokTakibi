using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using TarimMuhasebe.Core.Helper;
using TarimMuhasebe.DataAccess;
using TarimMuhasebe.Entities;
using TarimMuhasebe.Entities.Reports;
using TarimMuhasebe.WinFormApp.Forms;

namespace TarimMuhasebe.WinFormApp.UserControls
{
    public partial class StokUC : UserControl
    {
        private DatabaseContext _db;
        private StokForm stokForm;

        public StokUC()
        {
            InitializeComponent();

            _db = new DatabaseContext(Program.ConnectionString);
            loadData();
        }

        public void loadData()
        {
            loadGrid();
            loadCombobox();
        }

        private void btn_YeniKayit_Click(object sender, EventArgs e)
        {
            stokForm = new StokForm(new Stok());
            stokForm.StartPosition = FormStartPosition.CenterScreen;
            stokForm.FormClosed += StokForm_FormClosed;
            stokForm.ShowDialog();
        }

        private void StokForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.mainForm.loadData();
        }

        private void loadCombobox()
        {
            cmb_Urun.ComboBox.DisplayMember = "Ad";
            cmb_Urun.ComboBox.ValueMember = "Id";

            List<Urun> urunler = new List<Urun>();
            urunler.Add(new Urun
            {
                Id = 0,
                Ad = "Hepsi"
            });
            urunler.AddRange(_db.Urunler.ToList());
            cmb_Urun.ComboBox.DataSource = urunler;

            cmb_Depo.ComboBox.DisplayMember = "Ad";
            cmb_Depo.ComboBox.ValueMember = "Id";

            List<Depo> depolar = new List<Depo>();
            depolar.Add(new Depo
            {
                Id = 0,
                Ad = "Hepsi"
            });
            depolar.AddRange(_db.Depolar.ToList());
            cmb_Depo.ComboBox.DataSource = depolar;
        }

        private void btn_Filtrele_Click(object sender, EventArgs e)
        {
            Urun urun = (Urun)cmb_Urun.ComboBox.SelectedItem;
            Depo depo = (Depo)cmb_Depo.ComboBox.SelectedItem;

            int? urunId = urun.Id == 0 ? (int?)null : urun.Id;
            int? depoId = depo.Id == 0 ? (int?)null : depo.Id;

            this.dgv_Data.DataSource = null;

            var data = _db.Stoklar.Include("Urun").Include("Urun.Birim").Include("Depo")
                .Where(x => 
                (urunId == null ? true : x.UrunId == urunId.Value) && 
                (depoId == null ? true : x.DepoId == depoId.Value))
                .Select(x => new
                {
                    Id = x.Id,
                    Miktar = x.Miktar,
                    UrunId = x.UrunId,
                    DepoId = x.DepoId,
                    Urun = x.Urun.Ad,
                    Depo = x.Depo.Ad,
                    Birim = x.Urun.Birim.Gosterim
                }).ToList();

            this.dgv_Data.DataSource = data;
            this.dgv_Data.ClearSelection();
        }

        private void loadGrid()
        {
            this.dgv_Data.DataSource = null;
            var data = _db.Stoklar.Include("Urun").Include("Urun.Birim").Include("Depo").Select(x => new
            {
                Id = x.Id,
                Miktar = x.Miktar,
                UrunId = x.UrunId,
                DepoId = x.DepoId,
                Urun = x.Urun.Ad,
                Depo = x.Depo.Ad,
                Birim = x.Urun.Birim.Gosterim
            }).ToList();

            this.dgv_Data.DataSource = data;
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

                    MenuItem edit = new MenuItem("Güncelle");
                    MenuItem delete = new MenuItem("Kaldır");

                    edit.Click += Edit_Click;
                    delete.Click += Delete_Click;

                    ContextMenu menu = new ContextMenu();
                    menu.MenuItems.Add(edit);
                    menu.MenuItems.Add(delete);

                    var mousePosition = dgv_Data.PointToClient(Cursor.Position);

                    menu.Show(dgv_Data, mousePosition);
                }
            }
        }

        private void Edit_Click(object sender, System.EventArgs e)
        {
            var selectedRow = dgv_Data.SelectedRows[0];
            int Id = (int)selectedRow.Cells["Id"].Value;

            Stok selectStok = _db.Stoklar.SingleOrDefault(x => x.Id == Id);

            stokForm = new StokForm(selectStok);
            stokForm.StartPosition = FormStartPosition.CenterScreen;
            stokForm.FormClosed += StokForm_FormClosed;
            stokForm.ShowDialog();
        }

        private void Delete_Click(object sender, System.EventArgs e)
        {
            var selectedRow = dgv_Data.SelectedRows[0];

            int Id = (int)selectedRow.Cells["Id"].Value;

            if (MessageBox.Show($"Seçili stoğu silmek istediğinize eminmisiniz ?", "Uyarı", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var selectStok = _db.Stoklar.SingleOrDefault(x => x.Id == Id);
                _db.Stoklar.Remove(selectStok);
                _db.SaveChanges();

                dgv_Data.DataSource = null;
                loadGrid();
            }
        }

        private void btn_Raporla_Click(object sender, EventArgs e)
        {
            Urun selectUrun = (Urun)cmb_Urun.ComboBox.SelectedItem;
            Depo selectDepo = (Depo)cmb_Depo.ComboBox.SelectedItem;

            List<Urun> urunler = _db.Urunler.Where(x => selectUrun.Id == 0 ? true : x.Id == selectUrun.Id).ToList();
            List<Depo> depolar = _db.Depolar.Where(x => selectDepo.Id == 0 ? true : x.Id == selectDepo.Id).ToList();

            List<Stok> stoklar = _db.Stoklar.Include("Urun").Include("Urun.Birim").Include("Depo")
                .Where(x =>
                (selectUrun.Id == 0 ? true : x.UrunId == selectUrun.Id) &&
                (selectDepo.Id == 0 ? true : x.DepoId == selectDepo.Id)).ToList();

            List<Birim> birimler = _db.Birimler.ToList();
            List<FirmaBilgileri> firma = new List<FirmaBilgileri>();
            firma.Add(Program.firma);

            ReportDocument rd = new ReportDocument();

            string address = Reporting.GetAddress("StokRapor.rpt");

            rd.Load(Reporting.GetAddress("StokRapor.rpt"));

            rd.Database.Tables[0].SetDataSource(urunler);
            rd.Database.Tables[1].SetDataSource(depolar);
            rd.Database.Tables[2].SetDataSource(stoklar);
            rd.Database.Tables[3].SetDataSource(birimler);
            rd.Database.Tables[4].SetDataSource(firma);

            RaporForm raporForm = new RaporForm(rd);
            raporForm.ShowDialog();

            rd.Close();
            rd.Dispose();
        }
    }
}
