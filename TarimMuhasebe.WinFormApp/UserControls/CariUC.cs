using System.Linq;
using System.Windows.Forms;
using TarimMuhasebe.DataAccess;
using TarimMuhasebe.Entities;
using TarimMuhasebe.WinFormApp.Forms;

namespace TarimMuhasebe.WinFormApp.UserControls
{
    public partial class CariUC : UserControl
    {
        private DatabaseContext _db;

        private CariForm cariForm;
        private CariHesapForm cariHesapForm;

        public CariUC()
        {
            InitializeComponent();
            _db = new DatabaseContext(Program.ConnectionString);
            loadData();
        }

        public void loadData()
        {
            dgv_Data.DataSource = null;
            dgv_Data.DataSource = _db.Cariler.ToList();

            this.dgv_Data.ClearSelection();
        }

        private void btn_YeniKayit_Click(object sender, System.EventArgs e)
        {
            cariForm = new CariForm(new Cari());
            cariForm.StartPosition = FormStartPosition.CenterScreen;
            cariForm.FormClosed += CariForm_FormClosed;
            cariForm.ShowDialog();
        }

        private void CariForm_FormClosed(object sender, FormClosedEventArgs e)
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

                    MenuItem accounts = new MenuItem("Hesaplar");
                    MenuItem edit = new MenuItem("Güncelle");
                    MenuItem delete = new MenuItem("Kaldır");

                    accounts.Click += Accounts_Click;
                    edit.Click += Edit_Click;
                    delete.Click += Delete_Click;

                    ContextMenu menu = new ContextMenu();
                    menu.MenuItems.Add(accounts);
                    menu.MenuItems.Add(edit);
                    menu.MenuItems.Add(delete);

                    var mousePosition = dgv_Data.PointToClient(Cursor.Position);

                    menu.Show(dgv_Data, mousePosition);
                }
            }
        }

        private void Accounts_Click(object sender, System.EventArgs e)
        {
            var selectedRow = dgv_Data.SelectedRows[0];
            int Id = (int)selectedRow.Cells["Id"].Value;

            Cari selectCari = _db.Cariler.SingleOrDefault(x => x.Id == Id);

            cariHesapForm = new CariHesapForm(selectCari);
            cariHesapForm.ShowDialog();
        }

        private void Edit_Click(object sender, System.EventArgs e)
        {
            var selectedRow = dgv_Data.SelectedRows[0];
            int Id = (int)selectedRow.Cells["Id"].Value;

            Cari selectCari = _db.Cariler.SingleOrDefault(x => x.Id == Id);

            cariForm = new CariForm(selectCari);
            cariForm.StartPosition = FormStartPosition.CenterScreen;
            cariForm.FormClosed += CariForm_FormClosed;
            cariForm.ShowDialog();
        }

        private void Delete_Click(object sender, System.EventArgs e)
        {
            var selectedRow = dgv_Data.SelectedRows[0];
            string Kod = (string)selectedRow.Cells["Kod"].Value;
            int Id = (int)selectedRow.Cells["Id"].Value;

            if (MessageBox.Show($"{Kod} kodlu cariyi silmek istediğinize eminmisiniz ?", "Uyarı", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var selectedCari = _db.Cariler.SingleOrDefault(x => x.Id == Id);
                _db.Cariler.Remove(selectedCari);
                _db.SaveChanges();

                dgv_Data.DataSource = null;
                dgv_Data.DataSource = _db.Cariler.ToList();
            }
        }
    }
}
