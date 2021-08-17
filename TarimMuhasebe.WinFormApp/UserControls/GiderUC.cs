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
    public partial class GiderUC : UserControl
    {
        private DatabaseContext _db;
        private GiderForm giderForm;

        public GiderUC()
        {
            InitializeComponent();

            _db = new DatabaseContext(Program.ConnectionString);

            loadData();

        }

        public void loadData()
        {
            this.dgv_Data.DataSource = null;

            var data = _db.Giderler.Include("Cari").Include("OdemeTip").Include("Kasa").Select(x => new
            {
                Id = x.Id,
                Kod = x.Kod,
                CariId = x.CariId,
                KasaId = x.KasaId,
                OdemeTipId = x.OdemeTipId,
                Cari = x.Cari.Unvan,
                Kasa = x.Kasa.Ad,
                OdemeTip = x.OdemeTip.Ad,
                Tarih = x.Tarih,
                Kullanici = x.Kullanici,
                Tutar = x.Tutar + " ₺",
            }).OrderByDescending(x => x.Tarih).ToList();

            this.dgv_Data.DataSource = data;
            this.dgv_Data.ClearSelection();
        }

        private void btn_YeniKayit_Click(object sender, EventArgs e)
        {
            giderForm = new GiderForm(new Gider());
            giderForm.StartPosition = FormStartPosition.CenterScreen;
            giderForm.FormClosed += GiderForm_FormClosed;
            giderForm.ShowDialog();
        }

        private void GiderForm_FormClosed(object sender, FormClosedEventArgs e)
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

            Gider selectGider = _db.Giderler.SingleOrDefault(x => x.Id == Id);
           
            giderForm = new GiderForm(selectGider);
            giderForm.StartPosition = FormStartPosition.CenterScreen;
            giderForm.FormClosed += GiderForm_FormClosed;
            giderForm.ShowDialog();
        }

        private void Delete_Click(object sender, System.EventArgs e)
        {
            var selectedRow = dgv_Data.SelectedRows[0];

            int Id = (int)selectedRow.Cells["Id"].Value;

            if (MessageBox.Show($"Seçili işlemi silmek istediğinize eminmisiniz ?", "Uyarı", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Gider gider = _db.Giderler.SingleOrDefault(x => x.Id == Id);

                Kasa kasa = _db.Kasalar.SingleOrDefault(x => x.Id == gider.KasaId);
                kasa.GuncelTutar += gider.Tutar;

                _db.Giderler.Remove(gider);
                _db.SaveChanges();
            }
        }
    }
}
