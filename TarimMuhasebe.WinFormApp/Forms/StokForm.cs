using System;
using System.Linq;
using System.Windows.Forms;
using TarimMuhasebe.DataAccess;
using TarimMuhasebe.Entities;

namespace TarimMuhasebe.WinFormApp.Forms
{
    public partial class StokForm : Form
    {
        private DatabaseContext _db;
        private Stok _stok;

        public StokForm(Stok stok)
        {
            _db = new DatabaseContext(Program.ConnectionString);
            _stok = stok;

            InitializeComponent();
            loadData();
        }

        public void loadData()
        {
            nmbr_Miktar.Value = _stok.Miktar;

            cmb_Urun.DisplayMember = "Ad";
            cmb_Urun.ValueMember = "Id";
            cmb_Urun.DataSource = _db.Urunler.ToList();
            cmb_Urun.SelectedValue = _stok.UrunId;

            cmb_Depo.DisplayMember = "Ad";
            cmb_Depo.ValueMember = "Id";
            cmb_Depo.DataSource = _db.Depolar.ToList();
            cmb_Depo.SelectedValue = _stok.DepoId;

            if (_stok.Id == 0)
            {
                cmb_Urun.SelectedIndex = 0;
                cmb_Depo.SelectedIndex = 0;
            }
        }

        private void btn_Kaydet_Click(object sender, EventArgs e)
        {
            _stok.Miktar = nmbr_Miktar.Value;
            _stok.UrunId = (int)cmb_Urun.SelectedValue;
            _stok.DepoId = (int)cmb_Depo.SelectedValue;


            if (_stok.Id == 0)
            {
                var stok = _db.Stoklar.FirstOrDefault(x => x.UrunId == _stok.UrunId && x.DepoId == _stok.DepoId);

                if (stok != null)
                {
                    MessageBox.Show("Kayıt etmek istediğiniz ürün zaten seçili depoda mevcut !", "Uyarı", MessageBoxButtons.OK);
                    return;
                }

                _db.Stoklar.Add(_stok);
            }
            else
            {
                var selectStok = _db.Stoklar.SingleOrDefault(x => x.Id == _stok.Id);

                selectStok.Miktar = _stok.Miktar;
                selectStok.UrunId = _stok.UrunId;
                selectStok.DepoId = _stok.DepoId;
            }

            _db.SaveChanges();

            this.Close();
        }
    }
}
