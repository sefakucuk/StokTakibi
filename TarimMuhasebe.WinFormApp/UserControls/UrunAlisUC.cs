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
using TarimMuhasebe.WinFormApp.Forms;

namespace TarimMuhasebe.WinFormApp.UserControls
{
    public partial class UrunAlisUC : UserControl
    {
        private DatabaseContext _db;
        private UrunAlisForm urunAlisForm;

        public UrunAlisUC()
        {
            InitializeComponent();

            _db = new DatabaseContext(Program.ConnectionString);

            loadData();
        }

        private void btn_YeniKayit_Click(object sender, EventArgs e)
        {
            urunAlisForm = new UrunAlisForm(new Alis());
            urunAlisForm.StartPosition = FormStartPosition.CenterScreen;
            urunAlisForm.FormClosed += UrunAlisForm_FormClosed;
            urunAlisForm.ShowDialog();
        }

        private void UrunAlisForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.mainForm.loadData();
        }

        public void loadData()
        {
            this.dgv_Data.DataSource = null;

            var data = _db.Alislar.Include("Cari").Include("Urun").Include("Urun.Birim").Include("Depo").Include("Kasa").Select(x => new
            {
                Id = x.Id,
                No = x.Kod,
                CariId = x.CariId,
                KasaId = x.KasaId,
                UrunId = x.UrunId,
                DepoId = x.DepoId,
                Cari = x.Cari.Unvan,
                Urun = x.Urun.Ad,
                Depo = x.Depo.Ad,
                Kasa = x.Kasa.Ad,
                Miktar = x.Miktar + " " + x.Urun.Birim.Gosterim,
                BirimFiyat = x.BirimFiyat + " ₺",
                ToplamFiyat = x.ToplamFiyat + " ₺",
                StopajDahil = x.StopajDahil,
                Tarih = x.Tarih,
                Kullanici = x.Kullanici
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

                    MenuItem show = new MenuItem("İncele");
                    MenuItem delete = new MenuItem("Kaldır");

                    show.Click += Show_Click;
                    delete.Click += Delete_Click;

                    ContextMenu menu = new ContextMenu();
                    menu.MenuItems.Add(show);
                    menu.MenuItems.Add(delete);

                    var mousePosition = dgv_Data.PointToClient(Cursor.Position);

                    menu.Show(dgv_Data, mousePosition);
                }
            }
        }

        private void Show_Click(object sender, System.EventArgs e)
        {
            var selectedRow = dgv_Data.SelectedRows[0];
            int Id = (int)selectedRow.Cells["Id"].Value;

            Alis selectAlis = _db.Alislar.SingleOrDefault(x => x.Id == Id);

            urunAlisForm = new UrunAlisForm(selectAlis);
            urunAlisForm.StartPosition = FormStartPosition.CenterScreen;
            urunAlisForm.FormClosed += UrunAlisForm_FormClosed;
            urunAlisForm.ShowDialog();
        }

        private void Delete_Click(object sender, System.EventArgs e)
        {
            var selectedRow = dgv_Data.SelectedRows[0];

            int Id = (int)selectedRow.Cells["Id"].Value;

            if (MessageBox.Show($"Seçili işlemi silmek istediğinize eminmisiniz ?", "Uyarı", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Alis alis = _db.Alislar.SingleOrDefault(x => x.Id == Id);

                Stok stok = _db.Stoklar.FirstOrDefault(x => x.DepoId == alis.DepoId && x.UrunId == alis.UrunId);
                stok.Miktar -= alis.Miktar;

                Kasa kasa = _db.Kasalar.SingleOrDefault(x => x.Id == alis.KasaId);
                kasa.GuncelTutar += alis.ToplamFiyat;

                _db.Alislar.Remove(alis);
                _db.SaveChanges();
            }
        }
    }
}
