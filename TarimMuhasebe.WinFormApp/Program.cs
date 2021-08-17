using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using TarimMuhasebe.Core.Helper;
using TarimMuhasebe.Entities;
using TarimMuhasebe.WinFormApp.Forms;

namespace TarimMuhasebe.WinFormApp
{
    static class Program
    {
        public static string ConnectionString;
        public static FirmaBilgileri firma;
        public static Kullanici kullanici;

        public static MainForm mainForm;
        public static GirisForm girisForm;

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            

            if (File.Exists(Setting.GetAddress("Ayar.json")))
                firma = JsonConvert.DeserializeObject<FirmaBilgileri>(File.ReadAllText(Setting.GetAddress("Ayar.json")));
            else
                firma = new FirmaBilgileri();

            ConnectionString = $"server={firma.Server};port={firma.Port};user={firma.Kullanici};password={firma.Sifre};database={firma.Database}";

            if (string.IsNullOrEmpty(firma.Server) || string.IsNullOrEmpty(firma.Port.ToString()) ||
                string.IsNullOrEmpty(firma.Kullanici) || string.IsNullOrEmpty(firma.Sifre) ||
                string.IsNullOrEmpty(firma.Database))
                Application.Run(new ProgramBilgileriForm());
            else
            {
                //mainForm = new MainForm();
                girisForm = new GirisForm();
                Application.Run(girisForm);
            }
        }
    }
}
