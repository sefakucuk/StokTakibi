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
    public partial class KullaniciUC : UserControl
    {
        private DatabaseContext _db;
        private KullaniciForm kullaniciForm;

        public KullaniciUC()
        {
            InitializeComponent();

            _db = new DatabaseContext(Program.ConnectionString);
            loadData();
        }

        public void loadData()
        {
            dgv_Data.DataSource = null;
            dgv_Data.DataSource = _db.Kullanicilar.ToList();
            this.dgv_Data.ClearSelection();
        }

        private void btn_YeniKayit_Click(object sender, EventArgs e)
        {
            kullaniciForm = new KullaniciForm(new Kullanici());
            kullaniciForm.StartPosition = FormStartPosition.CenterScreen;
            kullaniciForm.FormClosed += KullaniciForm_FormClosed;
            kullaniciForm.ShowDialog();
        }

        private void KullaniciForm_FormClosed(object sender, FormClosedEventArgs e)
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

            Kullanici selectkullanici = _db.Kullanicilar.SingleOrDefault(x => x.Id == Id);

            kullaniciForm = new KullaniciForm(selectkullanici);
            kullaniciForm.StartPosition = FormStartPosition.CenterScreen;
            kullaniciForm.FormClosed += KullaniciForm_FormClosed;
            kullaniciForm.ShowDialog();
        }

        private void Delete_Click(object sender, System.EventArgs e)
        {
            var selectedRow = dgv_Data.SelectedRows[0];
            string AdSoyad = $"{(string)selectedRow.Cells["Ad"].Value} {(string)selectedRow.Cells["Soyad"].Value}";
            int Id = (int)selectedRow.Cells["Id"].Value;

            if (MessageBox.Show($"{AdSoyad} isimli kullanıcıyı silmek istediğinize eminmisiniz ?", "Uyarı", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var selectKullanici = _db.Kullanicilar.SingleOrDefault(x => x.Id == Id);
                _db.Kullanicilar.Remove(selectKullanici);
                _db.SaveChanges();

                dgv_Data.DataSource = null;
                dgv_Data.DataSource = _db.Kullanicilar.ToList();
            }
        }
    }
}
