
namespace TarimMuhasebe.WinFormApp.Forms
{
    partial class UrunSatisForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UrunSatisForm));
            this.spl_Main = new System.Windows.Forms.SplitContainer();
            this.btn_Kaydet = new System.Windows.Forms.Button();
            this.lbl_ToplamTutar = new System.Windows.Forms.Label();
            this.lbl_ToplamKdv = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_ToplamMatrah = new System.Windows.Forms.Label();
            this.chc_Tahsilat = new System.Windows.Forms.CheckBox();
            this.txt_Aciklama = new System.Windows.Forms.TextBox();
            this.cmb_Kasa = new System.Windows.Forms.ComboBox();
            this.cmb_Cari = new System.Windows.Forms.ComboBox();
            this.txt_No = new System.Windows.Forms.TextBox();
            this.flw_Urunler = new System.Windows.Forms.FlowLayoutPanel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btn_YeniUrun = new System.Windows.Forms.ToolStripButton();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.spl_Main)).BeginInit();
            this.spl_Main.Panel1.SuspendLayout();
            this.spl_Main.Panel2.SuspendLayout();
            this.spl_Main.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            this.SuspendLayout();
            // 
            // spl_Main
            // 
            this.spl_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spl_Main.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.spl_Main.IsSplitterFixed = true;
            this.spl_Main.Location = new System.Drawing.Point(0, 0);
            this.spl_Main.Name = "spl_Main";
            // 
            // spl_Main.Panel1
            // 
            this.spl_Main.Panel1.Controls.Add(this.btn_Kaydet);
            this.spl_Main.Panel1.Controls.Add(this.lbl_ToplamTutar);
            this.spl_Main.Panel1.Controls.Add(this.lbl_ToplamKdv);
            this.spl_Main.Panel1.Controls.Add(this.label6);
            this.spl_Main.Panel1.Controls.Add(this.label5);
            this.spl_Main.Panel1.Controls.Add(this.label4);
            this.spl_Main.Panel1.Controls.Add(this.label3);
            this.spl_Main.Panel1.Controls.Add(this.lbl_ToplamMatrah);
            this.spl_Main.Panel1.Controls.Add(this.chc_Tahsilat);
            this.spl_Main.Panel1.Controls.Add(this.txt_Aciklama);
            this.spl_Main.Panel1.Controls.Add(this.cmb_Kasa);
            this.spl_Main.Panel1.Controls.Add(this.cmb_Cari);
            this.spl_Main.Panel1.Controls.Add(this.txt_No);
            // 
            // spl_Main.Panel2
            // 
            this.spl_Main.Panel2.Controls.Add(this.flw_Urunler);
            this.spl_Main.Panel2.Controls.Add(this.toolStrip1);
            this.spl_Main.Size = new System.Drawing.Size(784, 461);
            this.spl_Main.SplitterDistance = 392;
            this.spl_Main.TabIndex = 0;
            // 
            // btn_Kaydet
            // 
            this.btn_Kaydet.Location = new System.Drawing.Point(293, 231);
            this.btn_Kaydet.Name = "btn_Kaydet";
            this.btn_Kaydet.Size = new System.Drawing.Size(75, 23);
            this.btn_Kaydet.TabIndex = 13;
            this.btn_Kaydet.Text = "Kaydet";
            this.btn_Kaydet.UseVisualStyleBackColor = true;
            this.btn_Kaydet.Click += new System.EventHandler(this.btn_Kaydet_Click);
            // 
            // lbl_ToplamTutar
            // 
            this.lbl_ToplamTutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_ToplamTutar.Location = new System.Drawing.Point(167, 205);
            this.lbl_ToplamTutar.Name = "lbl_ToplamTutar";
            this.lbl_ToplamTutar.Size = new System.Drawing.Size(201, 23);
            this.lbl_ToplamTutar.TabIndex = 12;
            this.lbl_ToplamTutar.Text = "Toplam Tutar : 0.00 ₺";
            this.lbl_ToplamTutar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_ToplamKdv
            // 
            this.lbl_ToplamKdv.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_ToplamKdv.Location = new System.Drawing.Point(167, 182);
            this.lbl_ToplamKdv.Name = "lbl_ToplamKdv";
            this.lbl_ToplamKdv.Size = new System.Drawing.Size(201, 23);
            this.lbl_ToplamKdv.TabIndex = 11;
            this.lbl_ToplamKdv.Text = "Toplam Kdv : 0.00 ₺";
            this.lbl_ToplamKdv.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Açıklama";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Kasa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Cari";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "İşlem No";
            // 
            // lbl_ToplamMatrah
            // 
            this.lbl_ToplamMatrah.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_ToplamMatrah.Location = new System.Drawing.Point(167, 159);
            this.lbl_ToplamMatrah.Name = "lbl_ToplamMatrah";
            this.lbl_ToplamMatrah.Size = new System.Drawing.Size(201, 23);
            this.lbl_ToplamMatrah.TabIndex = 5;
            this.lbl_ToplamMatrah.Text = "Toplam Matrah : 0.00 ₺";
            this.lbl_ToplamMatrah.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // chc_Tahsilat
            // 
            this.chc_Tahsilat.AutoSize = true;
            this.chc_Tahsilat.Location = new System.Drawing.Point(79, 163);
            this.chc_Tahsilat.Name = "chc_Tahsilat";
            this.chc_Tahsilat.Size = new System.Drawing.Size(82, 17);
            this.chc_Tahsilat.TabIndex = 4;
            this.chc_Tahsilat.Text = "Tahsil Edildi";
            this.chc_Tahsilat.UseVisualStyleBackColor = true;
            // 
            // txt_Aciklama
            // 
            this.txt_Aciklama.Location = new System.Drawing.Point(79, 92);
            this.txt_Aciklama.MaxLength = 500;
            this.txt_Aciklama.Multiline = true;
            this.txt_Aciklama.Name = "txt_Aciklama";
            this.txt_Aciklama.Size = new System.Drawing.Size(289, 60);
            this.txt_Aciklama.TabIndex = 3;
            // 
            // cmb_Kasa
            // 
            this.cmb_Kasa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Kasa.FormattingEnabled = true;
            this.cmb_Kasa.Location = new System.Drawing.Point(79, 65);
            this.cmb_Kasa.Name = "cmb_Kasa";
            this.cmb_Kasa.Size = new System.Drawing.Size(289, 21);
            this.cmb_Kasa.TabIndex = 2;
            // 
            // cmb_Cari
            // 
            this.cmb_Cari.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Cari.FormattingEnabled = true;
            this.cmb_Cari.Location = new System.Drawing.Point(79, 38);
            this.cmb_Cari.Name = "cmb_Cari";
            this.cmb_Cari.Size = new System.Drawing.Size(289, 21);
            this.cmb_Cari.TabIndex = 1;
            // 
            // txt_No
            // 
            this.txt_No.Location = new System.Drawing.Point(79, 12);
            this.txt_No.MaxLength = 150;
            this.txt_No.Name = "txt_No";
            this.txt_No.Size = new System.Drawing.Size(289, 20);
            this.txt_No.TabIndex = 0;
            // 
            // flw_Urunler
            // 
            this.flw_Urunler.AutoScroll = true;
            this.flw_Urunler.AutoSize = true;
            this.flw_Urunler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flw_Urunler.Location = new System.Drawing.Point(0, 25);
            this.flw_Urunler.Name = "flw_Urunler";
            this.flw_Urunler.Padding = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.flw_Urunler.Size = new System.Drawing.Size(388, 436);
            this.flw_Urunler.TabIndex = 1;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_YeniUrun});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(388, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btn_YeniUrun
            // 
            this.btn_YeniUrun.Image = ((System.Drawing.Image)(resources.GetObject("btn_YeniUrun.Image")));
            this.btn_YeniUrun.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_YeniUrun.Name = "btn_YeniUrun";
            this.btn_YeniUrun.Size = new System.Drawing.Size(78, 22);
            this.btn_YeniUrun.Text = "Yeni Ürün";
            this.btn_YeniUrun.Click += new System.EventHandler(this.btn_YeniUrun_Click);
            // 
            // error
            // 
            this.error.ContainerControl = this;
            // 
            // UrunSatisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.spl_Main);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UrunSatisForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Satış";
            this.spl_Main.Panel1.ResumeLayout(false);
            this.spl_Main.Panel1.PerformLayout();
            this.spl_Main.Panel2.ResumeLayout(false);
            this.spl_Main.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spl_Main)).EndInit();
            this.spl_Main.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer spl_Main;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_ToplamMatrah;
        private System.Windows.Forms.CheckBox chc_Tahsilat;
        private System.Windows.Forms.TextBox txt_Aciklama;
        private System.Windows.Forms.ComboBox cmb_Kasa;
        private System.Windows.Forms.ComboBox cmb_Cari;
        private System.Windows.Forms.TextBox txt_No;
        private System.Windows.Forms.Label lbl_ToplamKdv;
        private System.Windows.Forms.Label lbl_ToplamTutar;
        private System.Windows.Forms.Button btn_Kaydet;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btn_YeniUrun;
        private System.Windows.Forms.FlowLayoutPanel flw_Urunler;
        private System.Windows.Forms.ErrorProvider error;
    }
}