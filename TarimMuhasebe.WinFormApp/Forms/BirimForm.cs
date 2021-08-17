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

namespace TarimMuhasebe.WinFormApp.Forms
{
    public partial class BirimForm : Form
    {
        private Birim _selectBirim;
        private DatabaseContext _db;

        public BirimForm()
        {
            _db = new DatabaseContext(Program.ConnectionString);

            InitializeComponent();
            loadData();
        }

        private void loadData()
        {
            lst_Data.DataSource = null;

            lst_Data.ValueMember = "Id";
            lst_Data.DisplayMember = "Ad";
            lst_Data.DataSource = _db.Birimler.ToList();

            lst_Data.ClearSelected();
        }

        private void lst_Data_SelectedValueChanged(object sender, EventArgs e)
        {
            Birim birim = (Birim)lst_Data.SelectedItem;

            if (birim != null)
            {
                _selectBirim = birim;

                txt_Ad.Text = birim.Ad;
                txt_Gosterim.Text = birim.Gosterim;
            }
            else
            {
                _selectBirim = null;

                txt_Ad.Text = string.Empty;
                txt_Gosterim.Text = string.Empty;
            }
        }

        private void btn_Temizle_Click(object sender, EventArgs e)
        {
            _selectBirim = null;

            txt_Ad.Text = string.Empty;
            txt_Gosterim.Text = string.Empty;
        }

        private void btn_Kaydet_Click(object sender, EventArgs e)
        {
            bool status = false;

            string ad = txt_Ad.Text;
            string gosterim = txt_Gosterim.Text;

            if (string.IsNullOrEmpty(ad))
            {
                status = true;
                error.SetError(txt_Ad, "Boş geçilemez !");
            }

            if (string.IsNullOrEmpty(gosterim))
            {
                status = true;
                error.SetError(txt_Gosterim, "Boş geçilemez !");
            }

            if (status)
                return;

            if (_selectBirim == null)
            {
                _selectBirim = new Birim
                {
                    Ad = ad,
                    Gosterim = gosterim
                };

                _db.Birimler.Add(_selectBirim);
            }
            else
            {
                _selectBirim.Ad = ad;
                _selectBirim.Gosterim = gosterim;
            }

            _db.SaveChanges();
            loadData();
        }

        private void btn_Kaldir_Click(object sender, EventArgs e)
        {
            if (_selectBirim == null)
            {
                MessageBox.Show("Seçim yapınız", "Uyarı", MessageBoxButtons.OK);
                return;
            }

            if (MessageBox.Show("Seçili öğeyi silmek istediğinize eminmisiniz ?", "Uyarı", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                _db.Birimler.Remove(_selectBirim);
                _db.SaveChanges();

                loadData();
            }
        }
    }
}
