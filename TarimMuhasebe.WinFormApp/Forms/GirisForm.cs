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

namespace TarimMuhasebe.WinFormApp.Forms
{
    public partial class GirisForm : Form
    {
        private ProgramBilgileriForm programBilgileriForm;
        private DatabaseContext _db;

        public GirisForm()
        {
            _db = new DatabaseContext(Program.ConnectionString);

            InitializeComponent();
        }

        private void btn_Giris_Click(object sender, EventArgs e)
        {
            if (DateTime.Now.Year == 2022)
            {
                MessageBox.Show("Yazılımcı ile iletişime geçin !!!", "HATA", MessageBoxButtons.OK);
                Application.Exit();
                return;
            }

            error.Clear();

            bool status = false;

            if (string.IsNullOrEmpty(txt_EpostaTelefon.Text))
            {
                status = true;
                error.SetError(txt_EpostaTelefon, "Boş geçilemez !");
            }

            if (string.IsNullOrEmpty(txt_Sifre.Text))
            {
                status = true;
                error.SetError(txt_Sifre, "Boş geçilemez !");
            }

            if (status)
                return;

            string epostaTel = txt_EpostaTelefon.Text;
            string sifre = txt_Sifre.Text;

            var kullanici = _db.Kullanicilar.SingleOrDefault(x => (x.Eposta == epostaTel || x.Telefon == epostaTel) && x.Sifre == sifre);

            if (kullanici == null)
            {
                error.SetError(btn_Giris, "Kullanıcı bulunamadı !");
                return;
            }

            txt_EpostaTelefon.Text = string.Empty;
            txt_Sifre.Text = string.Empty;

            this.Visible = false;
            Program.kullanici = kullanici;

            Program.mainForm = new MainForm();
            Program.mainForm.Visible = true;
        }

        private void btn_ProgramBilgileri_Click(object sender, EventArgs e)
        {
            programBilgileriForm = new ProgramBilgileriForm();
            programBilgileriForm.ShowDialog();
        }
    }
}
