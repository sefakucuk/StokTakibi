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
    public partial class OdemeTipForm : Form
    {
        private OdemeTip _selectOdemeTip;
        private DatabaseContext _db;

        public OdemeTipForm()
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
            lst_Data.DataSource = _db.OdemeTipleri.ToList();

            lst_Data.ClearSelected();
        }

        private void lst_Data_SelectedValueChanged(object sender, EventArgs e)
        {
            OdemeTip odemeTip = (OdemeTip)lst_Data.SelectedItem;

            if (odemeTip != null)
            {
                _selectOdemeTip = odemeTip;

                txt_Ad.Text = odemeTip.Ad;
            }
            else
            {
                _selectOdemeTip = null;

                txt_Ad.Text = string.Empty;
            }
        }

        private void btn_Temizle_Click(object sender, EventArgs e)
        {
            _selectOdemeTip = null;

            txt_Ad.Text = string.Empty;
        }

        private void btn_Kaydet_Click(object sender, EventArgs e)
        {
            bool status = false;

            string ad = txt_Ad.Text;

            if (string.IsNullOrEmpty(ad))
            {
                status = true;
                error.SetError(txt_Ad, "Boş geçilemez !");
            }

            if (status)
                return;

            if (_selectOdemeTip == null)
            {
                _selectOdemeTip = new OdemeTip
                {
                    Ad = ad
                };

                _db.OdemeTipleri.Add(_selectOdemeTip);
            }
            else
            {
                _selectOdemeTip.Ad = ad;
            }

            _db.SaveChanges();
            loadData();
        }

        private void btn_Kaldir_Click(object sender, EventArgs e)
        {
            if (_selectOdemeTip == null)
            {
                MessageBox.Show("Seçim yapınız", "Uyarı", MessageBoxButtons.OK);
                return;
            }

            if (MessageBox.Show("Seçili öğeyi silmek istediğinize eminmisiniz ?","Uyarı",MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                _db.OdemeTipleri.Remove(_selectOdemeTip);
                _db.SaveChanges();

                loadData();
            }
        }
    }
}
