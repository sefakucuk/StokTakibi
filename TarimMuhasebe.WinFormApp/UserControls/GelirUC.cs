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
    public partial class GelirUC : UserControl
    {
        private DatabaseContext _db;
        private GelirForm gelirForm;

        public GelirUC()
        {
            InitializeComponent();

            _db = new DatabaseContext(Program.ConnectionString);

            loadData();
        }

        public void loadData()
        {
            this.dgv_Data.DataSource = null;

            var data = _db.Gelirler.Include("Cari").Include("OdemeTip").Include("Kasa").Include("Satis").Select(x => new
            {
                Id = x.Id,
                Kod = x.Kod,
                CariId = x.CariId,
                KasaId = x.KasaId,
                OdemeTipId = x.OdemeTipId,
                SatisId = x.SatisId,
                Cari = x.Cari.Unvan,
                Kasa = x.Kasa.Ad,
                OdemeTip = x.OdemeTip.Ad,
                Satis = x.Satis != null ? x.Satis.Kod : "---",
                Tarih = x.Tarih,
                Kullanici = x.Kullanici,
                Tutar = x.Tutar + " ₺",
            }).OrderByDescending(x => x.Tarih).ToList();

            this.dgv_Data.DataSource = data;
            this.dgv_Data.ClearSelection();
        }

        private void btn_YeniKayit_Click(object sender, EventArgs e)
        {
            gelirForm = new GelirForm(new Gelir());
            gelirForm.StartPosition = FormStartPosition.CenterScreen;
            gelirForm.FormClosed += GelirForm_FormClosed;
            gelirForm.ShowDialog();
        }

        private void GelirForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.mainForm.loadData();
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

            Gelir selectGelir = _db.Gelirler.SingleOrDefault(x => x.Id == Id);

            gelirForm = new GelirForm(selectGelir);
            gelirForm.StartPosition = FormStartPosition.CenterScreen;
            gelirForm.FormClosed += GelirForm_FormClosed;
            gelirForm.ShowDialog();
        }

        private void Delete_Click(object sender, System.EventArgs e)
        {
            var selectedRow = dgv_Data.SelectedRows[0];

            int Id = (int)selectedRow.Cells["Id"].Value;

            if (MessageBox.Show($"Seçili işlemi silmek istediğinize eminmisiniz ?", "Uyarı", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Gelir gelir = _db.Gelirler.SingleOrDefault(x => x.Id == Id);

                Kasa kasa = _db.Kasalar.SingleOrDefault(x => x.Id == gelir.KasaId);
                kasa.GuncelTutar -= gelir.Tutar;

                if (gelir.SatisId != null)
                {
                    Satis satis = _db.Satislar.SingleOrDefault(x => x.Id == gelir.SatisId.Value);
                    satis.Tahsilat = false;
                }

                _db.Gelirler.Remove(gelir);
                _db.SaveChanges();
            }
        }
    }
}
