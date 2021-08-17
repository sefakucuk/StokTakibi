
namespace TarimMuhasebe.WinFormApp.UserControls
{
    partial class UrunAlisUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UrunAlisUC));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btn_YeniKayit = new System.Windows.Forms.ToolStripButton();
            this.dgv_Data = new System.Windows.Forms.DataGridView();
            this.No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CariId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cari = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UrunId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Urun = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DepoId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Depo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KasaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kasa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Miktar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BirimFiyat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StopajDahil = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ToplamFiyat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kullanici = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tarih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Aciklama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alisBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_YeniKayit});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1059, 25);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btn_YeniKayit
            // 
            this.btn_YeniKayit.Image = ((System.Drawing.Image)(resources.GetObject("btn_YeniKayit.Image")));
            this.btn_YeniKayit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_YeniKayit.Name = "btn_YeniKayit";
            this.btn_YeniKayit.Size = new System.Drawing.Size(78, 22);
            this.btn_YeniKayit.Text = "Yeni Kayıt";
            this.btn_YeniKayit.Click += new System.EventHandler(this.btn_YeniKayit_Click);
            // 
            // dgv_Data
            // 
            this.dgv_Data.AllowUserToAddRows = false;
            this.dgv_Data.AllowUserToDeleteRows = false;
            this.dgv_Data.AutoGenerateColumns = false;
            this.dgv_Data.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv_Data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Data.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.No,
            this.CariId,
            this.Cari,
            this.UrunId,
            this.Urun,
            this.DepoId,
            this.Depo,
            this.KasaId,
            this.Kasa,
            this.Miktar,
            this.BirimFiyat,
            this.StopajDahil,
            this.ToplamFiyat,
            this.Kullanici,
            this.Tarih,
            this.Aciklama,
            this.Id});
            this.dgv_Data.DataSource = this.alisBindingSource;
            this.dgv_Data.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Data.Location = new System.Drawing.Point(0, 25);
            this.dgv_Data.Name = "dgv_Data";
            this.dgv_Data.ReadOnly = true;
            this.dgv_Data.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Data.Size = new System.Drawing.Size(1059, 594);
            this.dgv_Data.TabIndex = 5;
            this.dgv_Data.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_Data_CellMouseDown);
            // 
            // No
            // 
            this.No.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.No.DataPropertyName = "No";
            this.No.HeaderText = "İşlem No";
            this.No.Name = "No";
            this.No.ReadOnly = true;
            // 
            // CariId
            // 
            this.CariId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CariId.DataPropertyName = "CariId";
            this.CariId.HeaderText = "CariId";
            this.CariId.Name = "CariId";
            this.CariId.ReadOnly = true;
            this.CariId.Visible = false;
            // 
            // Cari
            // 
            this.Cari.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Cari.DataPropertyName = "Cari";
            this.Cari.HeaderText = "Cari";
            this.Cari.Name = "Cari";
            this.Cari.ReadOnly = true;
            // 
            // UrunId
            // 
            this.UrunId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.UrunId.DataPropertyName = "UrunId";
            this.UrunId.HeaderText = "UrunId";
            this.UrunId.Name = "UrunId";
            this.UrunId.ReadOnly = true;
            this.UrunId.Visible = false;
            // 
            // Urun
            // 
            this.Urun.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Urun.DataPropertyName = "Urun";
            this.Urun.HeaderText = "Ürün";
            this.Urun.Name = "Urun";
            this.Urun.ReadOnly = true;
            // 
            // DepoId
            // 
            this.DepoId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DepoId.DataPropertyName = "DepoId";
            this.DepoId.HeaderText = "DepoId";
            this.DepoId.Name = "DepoId";
            this.DepoId.ReadOnly = true;
            this.DepoId.Visible = false;
            // 
            // Depo
            // 
            this.Depo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Depo.DataPropertyName = "Depo";
            this.Depo.HeaderText = "Depo";
            this.Depo.Name = "Depo";
            this.Depo.ReadOnly = true;
            // 
            // KasaId
            // 
            this.KasaId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.KasaId.DataPropertyName = "KasaId";
            this.KasaId.HeaderText = "KasaId";
            this.KasaId.Name = "KasaId";
            this.KasaId.ReadOnly = true;
            this.KasaId.Visible = false;
            // 
            // Kasa
            // 
            this.Kasa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Kasa.DataPropertyName = "Kasa";
            this.Kasa.HeaderText = "Kasa";
            this.Kasa.Name = "Kasa";
            this.Kasa.ReadOnly = true;
            // 
            // Miktar
            // 
            this.Miktar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Miktar.DataPropertyName = "Miktar";
            this.Miktar.HeaderText = "Miktar";
            this.Miktar.Name = "Miktar";
            this.Miktar.ReadOnly = true;
            // 
            // BirimFiyat
            // 
            this.BirimFiyat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BirimFiyat.DataPropertyName = "BirimFiyat";
            this.BirimFiyat.HeaderText = "Birim Fiyat";
            this.BirimFiyat.Name = "BirimFiyat";
            this.BirimFiyat.ReadOnly = true;
            // 
            // StopajDahil
            // 
            this.StopajDahil.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.StopajDahil.DataPropertyName = "StopajDahil";
            this.StopajDahil.HeaderText = "Stopaj Dahil";
            this.StopajDahil.Name = "StopajDahil";
            this.StopajDahil.ReadOnly = true;
            // 
            // ToplamFiyat
            // 
            this.ToplamFiyat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ToplamFiyat.DataPropertyName = "ToplamFiyat";
            this.ToplamFiyat.HeaderText = "Toplam Fiyat";
            this.ToplamFiyat.Name = "ToplamFiyat";
            this.ToplamFiyat.ReadOnly = true;
            // 
            // Kullanici
            // 
            this.Kullanici.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Kullanici.DataPropertyName = "Kullanici";
            this.Kullanici.HeaderText = "Kullanıcı";
            this.Kullanici.Name = "Kullanici";
            this.Kullanici.ReadOnly = true;
            // 
            // Tarih
            // 
            this.Tarih.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Tarih.DataPropertyName = "Tarih";
            this.Tarih.HeaderText = "Tarih";
            this.Tarih.Name = "Tarih";
            this.Tarih.ReadOnly = true;
            // 
            // Aciklama
            // 
            this.Aciklama.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Aciklama.DataPropertyName = "Aciklama";
            this.Aciklama.HeaderText = "Aciklama";
            this.Aciklama.Name = "Aciklama";
            this.Aciklama.ReadOnly = true;
            this.Aciklama.Visible = false;
            // 
            // Id
            // 
            this.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // alisBindingSource
            // 
            this.alisBindingSource.DataSource = typeof(TarimMuhasebe.Entities.Alis);
            // 
            // UrunAlisUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgv_Data);
            this.Controls.Add(this.toolStrip1);
            this.Name = "UrunAlisUC";
            this.Size = new System.Drawing.Size(1059, 619);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alisBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btn_YeniKayit;
        private System.Windows.Forms.DataGridView dgv_Data;
        private System.Windows.Forms.DataGridViewTextBoxColumn No;
        private System.Windows.Forms.DataGridViewTextBoxColumn CariId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cari;
        private System.Windows.Forms.DataGridViewTextBoxColumn UrunId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Urun;
        private System.Windows.Forms.DataGridViewTextBoxColumn DepoId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Depo;
        private System.Windows.Forms.DataGridViewTextBoxColumn KasaId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kasa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Miktar;
        private System.Windows.Forms.DataGridViewTextBoxColumn BirimFiyat;
        private System.Windows.Forms.DataGridViewCheckBoxColumn StopajDahil;
        private System.Windows.Forms.DataGridViewTextBoxColumn ToplamFiyat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kullanici;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tarih;
        private System.Windows.Forms.DataGridViewTextBoxColumn Aciklama;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.BindingSource alisBindingSource;
    }
}
