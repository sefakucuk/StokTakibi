using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TarimMuhasebe.Core.Helper;
using TarimMuhasebe.DataAccess;
using TarimMuhasebe.WinFormApp.UserControls;

namespace TarimMuhasebe.WinFormApp.Forms
{
    public partial class MainForm : Form
    {
        private int HoverIndex = -1;

        private DatabaseContext db;

        private MainUC mainUc;
        private CariUC cariUC;
        private KasaUC kasaUC;
        private DepoUC depoUC;
        private UrunUC urunUC;
        private StokUC stokUC;
        private KullaniciUC kullaniciUC;

        private UrunSatisUC urunSatisUC;
        private UrunAlisUC urunAlisUC;
        private GiderUC giderUC;
        private GelirUC gelirUC;

        private BirimForm birimForm;
        private OdemeTipForm odemeTipForm;
        private ProgramBilgileriForm programBilgileriForm;
        private SifreGuncellemeForm sifreGuncellemeForm;
        private ProfilForm profilForm;
        private TransferForm transferForm;

        Point _imageLocation = new Point(20, 4);
        Point _imgHitArea = new Point(20, 4);
        Image closeImage;

        public MainForm()
        {
            InitializeComponent();

            db = new DatabaseContext(Program.ConnectionString);
            var data = db.Cariler.ToList();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            closeImage = Properties.Resources.close;
            tab_Pages.Padding = new Point(20, 4);

            mainUc = new MainUC();
            mainUc.Dock = DockStyle.Fill;

            TabPage tp = new TabPage("Anasayfa");
            tp.Tag = "Anasayfa";
            tab_Pages.TabPages.Add(tp);
            tab_Pages.SelectedTab = tp;
            tp.Controls.Add(mainUc);
        }

        private void btn_Anasayfa_Click(object sender, EventArgs e)
        {
            if (mainUc != null)
                return;

            mainUc = new MainUC();
            mainUc.Dock = DockStyle.Fill;

            TabPage tp = new TabPage("Anasayfa");
            tp.Tag = "Anasayfa";
            tab_Pages.TabPages.Add(tp);
            tab_Pages.SelectedTab = tp;
            tp.Controls.Add(mainUc);
        }

        public void btn_Cariler(object sender, EventArgs e)
        {
            if (cariUC != null)
                return;

            cariUC = new CariUC();
            cariUC.Dock = DockStyle.Fill;

            TabPage tp = new TabPage("Cariler");
            tp.Tag = "Cariler";
            tab_Pages.TabPages.Add(tp);
            tab_Pages.SelectedTab = tp;
            tp.Controls.Add(cariUC);
        }

        public void btn_Kasalar(object sender, EventArgs e)
        {
            if (kasaUC != null)
                return;

            kasaUC = new KasaUC();
            kasaUC.Dock = DockStyle.Fill;

            TabPage tp = new TabPage("Kasalar");
            tp.Tag = "Kasalar";
            tab_Pages.TabPages.Add(tp);
            tab_Pages.SelectedTab = tp;
            tp.Controls.Add(kasaUC);
        }

        public void btn_Depolar(object sender, EventArgs e)
        {
            if (depoUC != null)
                return;

            depoUC = new DepoUC();
            depoUC.Dock = DockStyle.Fill;

            TabPage tp = new TabPage("Depolar");
            tp.Tag = "Depolar";
            tab_Pages.TabPages.Add(tp);
            tab_Pages.SelectedTab = tp;
            tp.Controls.Add(depoUC);
        }

        public void btn_Urunler(object sender, EventArgs e)
        {
            if (urunUC != null)
                return;

            urunUC = new UrunUC();
            urunUC.Dock = DockStyle.Fill;

            TabPage tp = new TabPage("Ürünler");
            tp.Tag = "Ürünler";
            tab_Pages.TabPages.Add(tp);
            tab_Pages.SelectedTab = tp;
            tp.Controls.Add(urunUC);
        }

        public void btn_Stoklar(object sender, EventArgs e)
        {
            if (stokUC != null)
                return;

            stokUC = new StokUC();
            stokUC.Dock = DockStyle.Fill;

            TabPage tp = new TabPage("Stoklar");
            tp.Tag = "Stoklar";
            tab_Pages.TabPages.Add(tp);
            tab_Pages.SelectedTab = tp;
            tp.Controls.Add(stokUC);
        }

        public void btn_Kullanicilar(object sender, EventArgs e)
        {
            if (kullaniciUC != null)
                return;

            kullaniciUC = new KullaniciUC();
            kullaniciUC.Dock = DockStyle.Fill;

            TabPage tp = new TabPage("Kullanıcılar");
            tp.Tag = "Kullanıcılar";
            tab_Pages.TabPages.Add(tp);
            tab_Pages.SelectedTab = tp;
            tp.Controls.Add(kullaniciUC);
        }

        public void btn_UrunSatislar(object sender, EventArgs e)
        {
            if (urunSatisUC != null)
                return;

            urunSatisUC = new UrunSatisUC();
            urunSatisUC.Dock = DockStyle.Fill;

            TabPage tp = new TabPage("Ürün Satışları");
            tp.Tag = "ÜrünSatışları";
            tab_Pages.TabPages.Add(tp);
            tab_Pages.SelectedTab = tp;
            tp.Controls.Add(urunSatisUC);
        }

        public void btn_UrunAlislar(object sender, EventArgs e)
        {
            if (urunAlisUC != null)
                return;

            urunAlisUC = new UrunAlisUC();
            urunAlisUC.Dock = DockStyle.Fill;

            TabPage tp = new TabPage("Ürün Alışları");
            tp.Tag = "ÜrünAlışları";
            tab_Pages.TabPages.Add(tp);
            tab_Pages.SelectedTab = tp;
            tp.Controls.Add(urunAlisUC);
        }

        public void btn_Giderler(object sender, EventArgs e)
        {
            if (giderUC != null)
                return;

            giderUC = new GiderUC();
            giderUC.Dock = DockStyle.Fill;

            TabPage tp = new TabPage("Giderler");
            tp.Tag = "Giderler";
            tab_Pages.TabPages.Add(tp);
            tab_Pages.SelectedTab = tp;
            tp.Controls.Add(giderUC);
        }

        public void btn_Gelirler(object sender, EventArgs e)
        {
            if (gelirUC != null)
                return;

            gelirUC = new GelirUC();
            gelirUC.Dock = DockStyle.Fill;

            TabPage tp = new TabPage("Gelirler");
            tp.Tag = "Gelirler";
            tab_Pages.TabPages.Add(tp);
            tab_Pages.SelectedTab = tp;
            tp.Controls.Add(gelirUC);
        }

        private void btn_Transfer_Click(object sender, EventArgs e)
        {
            transferForm = new TransferForm();
            transferForm.FormClosed += FormClosed;
            transferForm.ShowDialog();
        }

        private void btn_HesapMakinesi_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process p = System.Diagnostics.Process.Start("calc.exe");
            p.WaitForInputIdle();
        }

        private void btn_Birimler_Click(object sender, EventArgs e)
        {
            birimForm = new BirimForm();
            birimForm.FormClosed += FormClosed;
            birimForm.ShowDialog();
        }

        private void btn_OdemeTipleri_Click(object sender, EventArgs e)
        {
            odemeTipForm = new OdemeTipForm();
            odemeTipForm.FormClosed += FormClosed;
            odemeTipForm.ShowDialog();
        }

        private void FormClosed(object sender, FormClosedEventArgs e)
        {
            loadData();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Yedekleme işlemi yapılsınmı ?", "Bilgilendirme", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                DatabaseProcess.DatabaseBackUp(Program.ConnectionString, Program.firma.YedekAdres);
            }

            Environment.Exit(1);
            Application.Exit();
        }

        private void btn_Cikis_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Çıkış yapmak istediğinize eminmisiniz ?", "Uyarı", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (MessageBox.Show("Yedekleme işlemi yapılsınmı ?", "Bilgilendirme", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    DatabaseProcess.DatabaseBackUp(Program.ConnectionString, Program.firma.YedekAdres);
                }

                Program.mainForm.Dispose();
                Program.girisForm.Visible = true;
            }
        }

        private void btn_ProgramBilgileri_Click(object sender, EventArgs e)
        {
            programBilgileriForm = new ProgramBilgileriForm();
            programBilgileriForm.ShowDialog();
        }

        private void btn_SifreGuncelle_Click(object sender, EventArgs e)
        {
            sifreGuncellemeForm = new SifreGuncellemeForm();
            sifreGuncellemeForm.ShowDialog();
        }

        private void btn_Profil_Click(object sender, EventArgs e)
        {
            profilForm = new ProfilForm();
            profilForm.ShowDialog();
        }

        private void tab_Pages_DrawItem(object sender, DrawItemEventArgs e)
        {
            Image img = new Bitmap(closeImage);
            Rectangle r = e.Bounds;
            r = this.tab_Pages.GetTabRect(e.Index);
            r.Offset(2, 2);
            Brush TitleBrush = new SolidBrush(Color.Black);
            Font f = this.Font;
            string title = this.tab_Pages.TabPages[e.Index].Text;
            e.Graphics.DrawString(title, f, TitleBrush, new PointF(r.X, r.Y));
            e.Graphics.DrawImage(img, new Point(r.X + (this.tab_Pages.GetTabRect(e.Index).Width - _imageLocation.X), _imageLocation.Y));
        }

        private void tab_Pages_MouseClick(object sender, MouseEventArgs e)
        {
            TabControl tabControl = (TabControl)sender;
            Point p = e.Location;
            int _tabWidth = 0;
            _tabWidth = this.tab_Pages.GetTabRect(tabControl.SelectedIndex).Width - (_imgHitArea.X);
            Rectangle r = this.tab_Pages.GetTabRect(tabControl.SelectedIndex);
            r.Offset(_tabWidth, _imgHitArea.Y);
            r.Width = 16;
            r.Height = 16;
            if (tab_Pages.SelectedIndex >= 0)
            {
                if (r.Contains(p))
                {
                    TabPage tabPage = (TabPage)tabControl.TabPages[tabControl.SelectedIndex];

                    switch (tabPage.Tag)
                    {
                        case "Anasayfa":
                            mainUc.Dispose();
                            mainUc = null;
                            break;
                        case "Cariler":
                            cariUC.Dispose();
                            cariUC = null;
                            break;
                        case "Kasalar":
                            kasaUC.Dispose();
                            kasaUC = null;
                            break;
                        case "Depolar":
                            depoUC.Dispose();
                            depoUC = null;
                            break;
                        case "Ürünler":
                            urunUC.Dispose();
                            urunUC = null;
                            break;
                        case "Stoklar":
                            stokUC.Dispose();
                            stokUC = null;
                            break;
                        case "Kullanıcılar":
                            kullaniciUC.Dispose();
                            kullaniciUC = null;
                            break;
                        case "ÜrünSatışları":
                            urunSatisUC.Dispose();
                            urunSatisUC = null;
                            break;
                        case "ÜrünAlışları":
                            urunAlisUC.Dispose();
                            urunAlisUC = null;
                            break;
                        case "Giderler":
                            giderUC.Dispose();
                            giderUC = null;
                            break;
                        case "Gelirler":
                            gelirUC.Dispose();
                            gelirUC = null;
                            break;
                    }

                    tabControl.TabPages.Remove(tabPage);
                }
            }
        }

        public void loadData()
        {
            foreach (TabPage page in tab_Pages.TabPages)
            {
                switch (page.Tag)
                {
                    case "Anasayfa":
                        mainUc.loadData();
                        break;
                    case "Cariler":
                        cariUC.loadData();
                        break;
                    case "Kasalar":
                        kasaUC.loadData();
                        break;
                    case "Depolar":
                        depoUC.loadData();
                        break;
                    case "Ürünler":
                        urunUC.loadData();
                        break;
                    case "Stoklar":
                        stokUC.loadData();
                        break;
                    case "Kullanıcılar":
                        kullaniciUC.loadData();
                        break;
                    case "ÜrünSatışları":
                        urunSatisUC.loadData();
                        break;
                    case "ÜrünAlışları":
                        urunAlisUC.loadData();
                        break;
                    case "Giderler":
                        giderUC.loadData();
                        break;
                    case "Gelirler":
                        gelirUC.loadData();
                        break;
                }
            }
        }
    }
}
