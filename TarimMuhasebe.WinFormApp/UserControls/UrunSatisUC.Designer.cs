
namespace TarimMuhasebe.WinFormApp.UserControls
{
    partial class UrunSatisUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UrunSatisUC));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btn_YeniKayit = new System.Windows.Forms.ToolStripButton();
            this.dgv_Data = new System.Windows.Forms.DataGridView();
            this.Kod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CariId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cari = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KasaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kasa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kullanici = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tarih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Aciklama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ToplamMatrahTutar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ToplamKdvTutar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tahsilat = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.satisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.satisBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_YeniKayit});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1049, 25);
            this.toolStrip1.TabIndex = 5;
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
            this.Kod,
            this.CariId,
            this.Cari,
            this.KasaId,
            this.Kasa,
            this.Kullanici,
            this.Tarih,
            this.Aciklama,
            this.ToplamMatrahTutar,
            this.ToplamKdvTutar,
            this.Tahsilat,
            this.Id});
            this.dgv_Data.DataSource = this.satisBindingSource;
            this.dgv_Data.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Data.Location = new System.Drawing.Point(0, 25);
            this.dgv_Data.Name = "dgv_Data";
            this.dgv_Data.ReadOnly = true;
            this.dgv_Data.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Data.Size = new System.Drawing.Size(1049, 579);
            this.dgv_Data.TabIndex = 6;
            this.dgv_Data.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_Data_CellMouseDown);
            // 
            // Kod
            // 
            this.Kod.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Kod.DataPropertyName = "Kod";
            this.Kod.HeaderText = "Kod";
            this.Kod.Name = "Kod";
            this.Kod.ReadOnly = true;
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
            this.Aciklama.HeaderText = "Açıklama";
            this.Aciklama.Name = "Aciklama";
            this.Aciklama.ReadOnly = true;
            this.Aciklama.Visible = false;
            // 
            // ToplamMatrahTutar
            // 
            this.ToplamMatrahTutar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ToplamMatrahTutar.DataPropertyName = "ToplamMatrahTutar";
            this.ToplamMatrahTutar.HeaderText = "Toplam Matrah";
            this.ToplamMatrahTutar.Name = "ToplamMatrahTutar";
            this.ToplamMatrahTutar.ReadOnly = true;
            // 
            // ToplamKdvTutar
            // 
            this.ToplamKdvTutar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ToplamKdvTutar.DataPropertyName = "ToplamKdvTutar";
            this.ToplamKdvTutar.HeaderText = "Toplam Kdv";
            this.ToplamKdvTutar.Name = "ToplamKdvTutar";
            this.ToplamKdvTutar.ReadOnly = true;
            // 
            // Tahsilat
            // 
            this.Tahsilat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Tahsilat.DataPropertyName = "Tahsilat";
            this.Tahsilat.HeaderText = "Tahsilat";
            this.Tahsilat.Name = "Tahsilat";
            this.Tahsilat.ReadOnly = true;
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
            // satisBindingSource
            // 
            this.satisBindingSource.DataSource = typeof(TarimMuhasebe.Entities.Satis);
            // 
            // UrunSatisUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgv_Data);
            this.Controls.Add(this.toolStrip1);
            this.Name = "UrunSatisUC";
            this.Size = new System.Drawing.Size(1049, 604);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.satisBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btn_YeniKayit;
        private System.Windows.Forms.DataGridView dgv_Data;
        private System.Windows.Forms.BindingSource satisBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kod;
        private System.Windows.Forms.DataGridViewTextBoxColumn CariId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cari;
        private System.Windows.Forms.DataGridViewTextBoxColumn KasaId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kasa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kullanici;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tarih;
        private System.Windows.Forms.DataGridViewTextBoxColumn Aciklama;
        private System.Windows.Forms.DataGridViewTextBoxColumn ToplamMatrahTutar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ToplamKdvTutar;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Tahsilat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
    }
}
