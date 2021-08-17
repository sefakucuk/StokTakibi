using System;
using System.Linq;
using System.Windows.Forms;
using TarimMuhasebe.DataAccess;
using TarimMuhasebe.Entities;
using TarimMuhasebe.WinFormApp.Forms;

namespace TarimMuhasebe.WinFormApp.UserControls
{
    public partial class KasaUC : UserControl
    {
        private DatabaseContext _db;
        private KasaForm kasaForm;

        public KasaUC()
        {
            InitializeComponent();

            _db = new DatabaseContext(Program.ConnectionString);
            loadData();
        }

        public void loadData()
        {
            dgv_Data.DataSource = null;
            dgv_Data.DataSource = _db.Kasalar.ToList();
            this.dgv_Data.ClearSelection();
        }

        private void btn_YeniKayit_Click(object sender, EventArgs e)
        {
            kasaForm = new KasaForm(new Kasa());
            kasaForm.StartPosition = FormStartPosition.CenterScreen;
            kasaForm.FormClosed += KasaForm_FormClosed;
            kasaForm.ShowDialog();
        }

        private void KasaForm_FormClosed(object sender, FormClosedEventArgs e)
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

            Kasa selectKasa = _db.Kasalar.SingleOrDefault(x => x.Id == Id);

            kasaForm = new KasaForm(selectKasa);
            kasaForm.StartPosition = FormStartPosition.CenterScreen;
            kasaForm.FormClosed += KasaForm_FormClosed;
            kasaForm.ShowDialog();
        }

        private void Delete_Click(object sender, System.EventArgs e)
        {
            var selectedRow = dgv_Data.SelectedRows[0];
            string Kod = (string)selectedRow.Cells["Kod"].Value;
            int Id = (int)selectedRow.Cells["Id"].Value;

            if (MessageBox.Show($"{Kod} kodlu kasayı silmek istediğinize eminmisiniz ?", "Uyarı", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var selectKasa = _db.Kasalar.SingleOrDefault(x => x.Id == Id);
                _db.Kasalar.Remove(selectKasa);
                _db.SaveChanges();

                dgv_Data.DataSource = null;
                dgv_Data.DataSource = _db.Kasalar.ToList();
            }
        }
    }
}
