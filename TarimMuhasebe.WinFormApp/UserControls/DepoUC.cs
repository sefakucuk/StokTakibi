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
    public partial class DepoUC : UserControl
    {
        private DatabaseContext _db;
        private DepoForm depoForm;

        public DepoUC()
        {
            InitializeComponent();

            _db = new DatabaseContext(Program.ConnectionString);

            loadData();
        }

        public void loadData()
        {
            dgv_Data.DataSource = null;
            dgv_Data.DataSource = _db.Depolar.ToList();

            this.dgv_Data.ClearSelection();
        }

        private void btn_YeniKayit_Click(object sender, EventArgs e)
        {
            depoForm = new DepoForm(new Depo());
            depoForm.StartPosition = FormStartPosition.CenterScreen;
            depoForm.FormClosed += DepoForm_FormClosed;
            depoForm.ShowDialog();
        }

        private void DepoForm_FormClosed(object sender, FormClosedEventArgs e)
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

            Depo selectDepo = _db.Depolar.SingleOrDefault(x => x.Id == Id);

            depoForm = new DepoForm(selectDepo);
            depoForm.StartPosition = FormStartPosition.CenterScreen;
            depoForm.FormClosed += DepoForm_FormClosed;
            depoForm.ShowDialog();

        }

        private void Delete_Click(object sender, System.EventArgs e)
        {
            var selectedRow = dgv_Data.SelectedRows[0];
            string Kod = (string)selectedRow.Cells["Kod"].Value;
            int Id = (int)selectedRow.Cells["Id"].Value;

            if (MessageBox.Show($"{Kod} kodlu depoyu silmek istediğinize eminmisiniz ?", "Uyarı", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var selectDepo = _db.Depolar.SingleOrDefault(x => x.Id == Id);
                _db.Depolar.Remove(selectDepo);
                _db.SaveChanges();

                dgv_Data.DataSource = null;
                dgv_Data.DataSource = _db.Depolar.ToList();
            }
        }
    }
}
