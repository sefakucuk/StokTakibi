using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TarimMuhasebe.Core.Helper;

namespace TarimMuhasebe.WinFormApp.Forms
{
    public partial class ProgramBilgileriForm : Form
    {
        public ProgramBilgileriForm()
        {
            InitializeComponent();
            loadData();
        }

        private void loadData()
        {
            txt_Ad.Text = Program.firma.Ad;
            txt_VergiNo.Text = Program.firma.VergiNo;
            txt_Adres.Text = Program.firma.Adres;

            txt_YedekYol.Text = Program.firma.YedekAdres;

            txt_Server.Text = Program.firma.Server;
            nmbr_Port.Value = Program.firma.Port;
            txt_Database.Text = Program.firma.Database;
            txt_Kullanici.Text = Program.firma.Kullanici;
            txt_Sifre.Text = Program.firma.Sifre;

            if (Program.firma.Logo != null)
            {
                byte[] imageBytes = Convert.FromBase64String(Program.firma.Logo);

                using (var ms = new MemoryStream(imageBytes, 0, imageBytes.Length))
                {
                    pic_Logo.Image = Image.FromStream(ms, true);
                }
            }
        }

        private void btn_Logo_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Title = "Logo Seçimi";
                dlg.Filter = "png dosyası (*.png)|*.png";

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    pic_Logo.Image = new Bitmap(dlg.FileName);
                }
            }
        }

        private void btn_YedekYol_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    txt_YedekYol.Text = fbd.SelectedPath;
                }
            }
        }

        private void btn_Kaydet_Click(object sender, EventArgs e)
        {
            bool status = false;

            string ad = txt_Ad.Text;
            string vergiNo = txt_VergiNo.Text;
            string adres = txt_Adres.Text;
            string yedekYol = txt_YedekYol.Text;

            string server = txt_Server.Text;
            int port = Convert.ToInt32(nmbr_Port.Value);
            string database = txt_Database.Text;
            string kullanici = txt_Kullanici.Text;
            string sifre = txt_Sifre.Text;

            if (string.IsNullOrEmpty(ad))
            {
                status = true;
                error.SetError(txt_Ad, "Boş geçilemez !");
            }

            if (string.IsNullOrEmpty(vergiNo))
            {
                status = true;
                error.SetError(txt_VergiNo, "Boş geçilemez !");
            }

            if (string.IsNullOrEmpty(adres))
            {
                status = true;
                error.SetError(txt_Adres, "Boş geçilemez !");
            }

            if (string.IsNullOrEmpty(yedekYol))
            {
                status = true;
                error.SetError(txt_YedekYol, "Boş geçilemez !");
            }

            if (string.IsNullOrEmpty(server))
            {
                status = true;
                error.SetError(txt_Server, "Boş geçilemez !");
            }

            if (port == 0)
            {
                status = true;
                error.SetError(nmbr_Port, "Geçerli bir değer giriniz !");
            }

            if (string.IsNullOrEmpty(database))
            {
                status = true;
                error.SetError(txt_Database, "Boş geçilemez !");
            }

            if (string.IsNullOrEmpty(kullanici))
            {
                status = true;
                error.SetError(txt_Kullanici, "Boş geçilemez !");
            }

            if (string.IsNullOrEmpty(sifre))
            {
                status = true;
                error.SetError(txt_Sifre, "Boş geçilemez !");
            }

            if (status)
                return;

            Program.firma.Ad = ad;
            Program.firma.VergiNo = vergiNo;
            Program.firma.Adres = adres;

            Program.firma.YedekAdres = yedekYol;

            if (pic_Logo.Image != null)
                Program.firma.Logo = ConvertImageToBase64(pic_Logo.Image);

            Program.firma.Server = server;
            Program.firma.Port = port;
            Program.firma.Database = database;
            Program.firma.Kullanici = kullanici;
            Program.firma.Sifre = sifre;

            string filePath = Setting.GetAddress("Ayar.json");

            if (!Directory.Exists(Setting.FolderPath))
                Directory.CreateDirectory(Setting.FolderPath);

            if (!File.Exists(filePath))
                File.Create(filePath).Close();

            File.WriteAllText(filePath, JsonConvert.SerializeObject(Program.firma));

            if (MessageBox.Show("Kayıt işlemi başarılı bir şekilde gerçekleştirildi.Programın yeniden başlatılması gerekli yeniden başlatılsın mı ?", "Bilgilendirme", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Restart();
            }
        }

        public string ConvertImageToBase64(Image file)
        {
            using (MemoryStream memoryStream = new MemoryStream())
            {
                file.Save(memoryStream, file.RawFormat);
                byte[] imageBytes = memoryStream.ToArray();
                return Convert.ToBase64String(imageBytes);
            }
        }
    }
}
