using System;
using System.Linq;
using System.Windows.Forms;
using TarimMuhasebe.DataAccess;
using TarimMuhasebe.Entities;

namespace TarimMuhasebe.WinFormApp.Forms
{
    public partial class DepoForm : Form
    {
        private DatabaseContext _db;
        private Depo _depo;

        public DepoForm(Depo depo)
        {
            _db = new DatabaseContext(Program.ConnectionString);
            _depo = depo;

            InitializeComponent();
            loadData();
        }

        public void loadData()
        {
            txt_Kod.Text = _depo.Kod;
            txt_Ad.Text = _depo.Ad;
            txt_Aciklama.Text = _depo.Aciklama;

            if (_depo.Id == 0)
            {
                var last = _db.Depolar.OrderByDescending(x => x.Id).FirstOrDefault();
                int number = 1;

                if (last != null)
                    number = last.Id + 1;

                txt_Kod.Text = $"DP-{number.ToString("D10")}";
            }
        }

        private void btn_Kaydet_Click(object sender, EventArgs e)
        {
            bool status = false;

            if (string.IsNullOrEmpty(txt_Kod.Text))
            {
                status = true;
                error.SetError(txt_Kod, "Boş geçilemez !");
            }

            if (string.IsNullOrEmpty(txt_Ad.Text))
            {
                status = true;
                error.SetError(txt_Ad, "Boş geçilemez !");
            }

            if (status)
                return;

            _depo.Kod = txt_Kod.Text;
            _depo.Ad = txt_Ad.Text;
            _depo.Aciklama = txt_Aciklama.Text;

            if (_depo.Id == 0)
                _db.Depolar.Add(_depo);
            else
            {
                var selectDepo = _db.Depolar.SingleOrDefault(x => x.Id == _depo.Id);

                selectDepo.Kod = _depo.Kod;
                selectDepo.Ad = _depo.Ad;
                selectDepo.Aciklama = _depo.Aciklama;
            }

            _db.SaveChanges();

            this.Close();
        }
    }
}
