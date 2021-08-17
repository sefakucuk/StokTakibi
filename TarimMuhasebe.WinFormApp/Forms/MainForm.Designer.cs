
namespace TarimMuhasebe.WinFormApp.Forms
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btn_Cikis = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_SifreGuncelle = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_Profil = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_ProgramBilgileri = new System.Windows.Forms.ToolStripButton();
            this.btn_Constants = new System.Windows.Forms.ToolStripDropDownButton();
            this.btn_Birimler = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_OdemeTipleri = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl_Promo = new System.Windows.Forms.Label();
            this.spl_Main = new System.Windows.Forms.SplitContainer();
            this.flw_Menu = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_Anasayfa = new System.Windows.Forms.Button();
            this.bt_Urunler = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.tab_Pages = new System.Windows.Forms.TabControl();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spl_Main)).BeginInit();
            this.spl_Main.Panel1.SuspendLayout();
            this.spl_Main.Panel2.SuspendLayout();
            this.spl_Main.SuspendLayout();
            this.flw_Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_Cikis,
            this.toolStripSeparator3,
            this.btn_SifreGuncelle,
            this.toolStripSeparator4,
            this.btn_Profil,
            this.toolStripSeparator1,
            this.btn_ProgramBilgileri,
            this.btn_Constants});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1142, 38);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btn_Cikis
            // 
            this.btn_Cikis.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btn_Cikis.Image = ((System.Drawing.Image)(resources.GetObject("btn_Cikis.Image")));
            this.btn_Cikis.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Cikis.Name = "btn_Cikis";
            this.btn_Cikis.Size = new System.Drawing.Size(36, 35);
            this.btn_Cikis.Text = "Çıkış";
            this.btn_Cikis.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Cikis.Click += new System.EventHandler(this.btn_Cikis_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 38);
            // 
            // btn_SifreGuncelle
            // 
            this.btn_SifreGuncelle.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btn_SifreGuncelle.Image = ((System.Drawing.Image)(resources.GetObject("btn_SifreGuncelle.Image")));
            this.btn_SifreGuncelle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_SifreGuncelle.Name = "btn_SifreGuncelle";
            this.btn_SifreGuncelle.Size = new System.Drawing.Size(83, 35);
            this.btn_SifreGuncelle.Text = "Şifre Güncelle";
            this.btn_SifreGuncelle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_SifreGuncelle.Click += new System.EventHandler(this.btn_SifreGuncelle_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 38);
            // 
            // btn_Profil
            // 
            this.btn_Profil.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btn_Profil.Image = ((System.Drawing.Image)(resources.GetObject("btn_Profil.Image")));
            this.btn_Profil.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Profil.Name = "btn_Profil";
            this.btn_Profil.Size = new System.Drawing.Size(39, 35);
            this.btn_Profil.Text = "Profil";
            this.btn_Profil.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Profil.Click += new System.EventHandler(this.btn_Profil_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 38);
            // 
            // btn_ProgramBilgileri
            // 
            this.btn_ProgramBilgileri.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btn_ProgramBilgileri.Image = ((System.Drawing.Image)(resources.GetObject("btn_ProgramBilgileri.Image")));
            this.btn_ProgramBilgileri.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_ProgramBilgileri.Name = "btn_ProgramBilgileri";
            this.btn_ProgramBilgileri.Size = new System.Drawing.Size(99, 35);
            this.btn_ProgramBilgileri.Text = "Program Bilgileri";
            this.btn_ProgramBilgileri.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_ProgramBilgileri.Click += new System.EventHandler(this.btn_ProgramBilgileri_Click);
            // 
            // btn_Constants
            // 
            this.btn_Constants.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_Birimler,
            this.btn_OdemeTipleri});
            this.btn_Constants.Image = ((System.Drawing.Image)(resources.GetObject("btn_Constants.Image")));
            this.btn_Constants.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Constants.Name = "btn_Constants";
            this.btn_Constants.Size = new System.Drawing.Size(59, 35);
            this.btn_Constants.Text = "Sabitler";
            this.btn_Constants.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // btn_Birimler
            // 
            this.btn_Birimler.Name = "btn_Birimler";
            this.btn_Birimler.Size = new System.Drawing.Size(148, 22);
            this.btn_Birimler.Text = "Birimler";
            this.btn_Birimler.Click += new System.EventHandler(this.btn_Birimler_Click);
            // 
            // btn_OdemeTipleri
            // 
            this.btn_OdemeTipleri.Name = "btn_OdemeTipleri";
            this.btn_OdemeTipleri.Size = new System.Drawing.Size(148, 22);
            this.btn_OdemeTipleri.Text = "Ödeme Tipleri";
            this.btn_OdemeTipleri.Click += new System.EventHandler(this.btn_OdemeTipleri_Click);
            // 
            // lbl_Promo
            // 
            this.lbl_Promo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbl_Promo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Promo.Location = new System.Drawing.Point(0, 515);
            this.lbl_Promo.Name = "lbl_Promo";
            this.lbl_Promo.Size = new System.Drawing.Size(1142, 13);
            this.lbl_Promo.TabIndex = 2;
            this.lbl_Promo.Text = "Tekno Sivas Ltd. Şti.";
            this.lbl_Promo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // spl_Main
            // 
            this.spl_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spl_Main.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.spl_Main.IsSplitterFixed = true;
            this.spl_Main.Location = new System.Drawing.Point(0, 38);
            this.spl_Main.Name = "spl_Main";
            // 
            // spl_Main.Panel1
            // 
            this.spl_Main.Panel1.Controls.Add(this.flw_Menu);
            // 
            // spl_Main.Panel2
            // 
            this.spl_Main.Panel2.Controls.Add(this.tab_Pages);
            this.spl_Main.Size = new System.Drawing.Size(1142, 477);
            this.spl_Main.SplitterDistance = 249;
            this.spl_Main.TabIndex = 3;
            // 
            // flw_Menu
            // 
            this.flw_Menu.AutoScroll = true;
            this.flw_Menu.Controls.Add(this.btn_Anasayfa);
            this.flw_Menu.Controls.Add(this.bt_Urunler);
            this.flw_Menu.Controls.Add(this.button1);
            this.flw_Menu.Controls.Add(this.button2);
            this.flw_Menu.Controls.Add(this.button3);
            this.flw_Menu.Controls.Add(this.button4);
            this.flw_Menu.Controls.Add(this.button5);
            this.flw_Menu.Controls.Add(this.button6);
            this.flw_Menu.Controls.Add(this.button7);
            this.flw_Menu.Controls.Add(this.button8);
            this.flw_Menu.Controls.Add(this.button9);
            this.flw_Menu.Controls.Add(this.button10);
            this.flw_Menu.Controls.Add(this.button11);
            this.flw_Menu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flw_Menu.Location = new System.Drawing.Point(0, 0);
            this.flw_Menu.Name = "flw_Menu";
            this.flw_Menu.Padding = new System.Windows.Forms.Padding(0, 5, 0, 10);
            this.flw_Menu.Size = new System.Drawing.Size(249, 477);
            this.flw_Menu.TabIndex = 0;
            // 
            // btn_Anasayfa
            // 
            this.btn_Anasayfa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Anasayfa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Anasayfa.Image = ((System.Drawing.Image)(resources.GetObject("btn_Anasayfa.Image")));
            this.btn_Anasayfa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Anasayfa.Location = new System.Drawing.Point(3, 8);
            this.btn_Anasayfa.Name = "btn_Anasayfa";
            this.btn_Anasayfa.Size = new System.Drawing.Size(117, 43);
            this.btn_Anasayfa.TabIndex = 0;
            this.btn_Anasayfa.Text = "Anasayfa";
            this.btn_Anasayfa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Anasayfa.UseVisualStyleBackColor = true;
            this.btn_Anasayfa.Click += new System.EventHandler(this.btn_Anasayfa_Click);
            // 
            // bt_Urunler
            // 
            this.bt_Urunler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Urunler.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bt_Urunler.Image = ((System.Drawing.Image)(resources.GetObject("bt_Urunler.Image")));
            this.bt_Urunler.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_Urunler.Location = new System.Drawing.Point(126, 8);
            this.bt_Urunler.Name = "bt_Urunler";
            this.bt_Urunler.Size = new System.Drawing.Size(117, 43);
            this.bt_Urunler.TabIndex = 1;
            this.bt_Urunler.Text = "Ürünler";
            this.bt_Urunler.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_Urunler.UseVisualStyleBackColor = true;
            this.bt_Urunler.Click += new System.EventHandler(this.btn_Urunler);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(3, 57);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 43);
            this.button1.TabIndex = 1;
            this.button1.Text = "Depolar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btn_Depolar);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(126, 57);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(117, 43);
            this.button2.TabIndex = 2;
            this.button2.Text = "Stoklar";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btn_Stoklar);
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(3, 106);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(117, 43);
            this.button3.TabIndex = 3;
            this.button3.Text = "Kasalar";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btn_Kasalar);
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(126, 106);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(117, 43);
            this.button4.TabIndex = 4;
            this.button4.Text = "Cariler";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.btn_Cariler);
            // 
            // button5
            // 
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(3, 155);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(117, 43);
            this.button5.TabIndex = 5;
            this.button5.Text = "Kullanıcı";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.btn_Kullanicilar);
            // 
            // button6
            // 
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.Location = new System.Drawing.Point(126, 155);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(117, 43);
            this.button6.TabIndex = 6;
            this.button6.Text = "Ürün Satış";
            this.button6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.btn_UrunSatislar);
            // 
            // button7
            // 
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button7.Image = ((System.Drawing.Image)(resources.GetObject("button7.Image")));
            this.button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.Location = new System.Drawing.Point(3, 204);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(117, 43);
            this.button7.TabIndex = 7;
            this.button7.Text = "Ürün Alış";
            this.button7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.btn_UrunAlislar);
            // 
            // button8
            // 
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button8.Image = ((System.Drawing.Image)(resources.GetObject("button8.Image")));
            this.button8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button8.Location = new System.Drawing.Point(126, 204);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(117, 43);
            this.button8.TabIndex = 8;
            this.button8.Text = "Transfer";
            this.button8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.btn_Transfer_Click);
            // 
            // button9
            // 
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button9.Image = ((System.Drawing.Image)(resources.GetObject("button9.Image")));
            this.button9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button9.Location = new System.Drawing.Point(3, 253);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(117, 43);
            this.button9.TabIndex = 9;
            this.button9.Text = "Gelirler";
            this.button9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.btn_Gelirler);
            // 
            // button10
            // 
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button10.Image = ((System.Drawing.Image)(resources.GetObject("button10.Image")));
            this.button10.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button10.Location = new System.Drawing.Point(126, 253);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(117, 43);
            this.button10.TabIndex = 10;
            this.button10.Text = "Giderler";
            this.button10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.btn_Giderler);
            // 
            // button11
            // 
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button11.Image = ((System.Drawing.Image)(resources.GetObject("button11.Image")));
            this.button11.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button11.Location = new System.Drawing.Point(3, 302);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(117, 43);
            this.button11.TabIndex = 11;
            this.button11.Text = "Hesap";
            this.button11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.btn_HesapMakinesi_Click);
            // 
            // tab_Pages
            // 
            this.tab_Pages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tab_Pages.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tab_Pages.Location = new System.Drawing.Point(0, 0);
            this.tab_Pages.Multiline = true;
            this.tab_Pages.Name = "tab_Pages";
            this.tab_Pages.SelectedIndex = 0;
            this.tab_Pages.ShowToolTips = true;
            this.tab_Pages.Size = new System.Drawing.Size(889, 477);
            this.tab_Pages.TabIndex = 0;
            this.tab_Pages.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.tab_Pages_DrawItem);
            this.tab_Pages.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tab_Pages_MouseClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1142, 528);
            this.Controls.Add(this.spl_Main);
            this.Controls.Add(this.lbl_Promo);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tarım Hesabım";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.spl_Main.Panel1.ResumeLayout(false);
            this.spl_Main.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spl_Main)).EndInit();
            this.spl_Main.ResumeLayout(false);
            this.flw_Menu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btn_ProgramBilgileri;
        private System.Windows.Forms.ToolStripDropDownButton btn_Constants;
        private System.Windows.Forms.ToolStripMenuItem btn_OdemeTipleri;
        private System.Windows.Forms.ToolStripButton btn_Cikis;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem btn_Birimler;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btn_Profil;
        private System.Windows.Forms.Label lbl_Promo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton btn_SifreGuncelle;
        private System.Windows.Forms.SplitContainer spl_Main;
        private System.Windows.Forms.FlowLayoutPanel flw_Menu;
        private System.Windows.Forms.Button bt_Urunler;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.TabControl tab_Pages;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button btn_Anasayfa;
    }
}