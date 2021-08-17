
namespace TarimMuhasebe.WinFormApp.UserControls
{
    partial class UrunUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UrunUC));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btn_YeniKayit = new System.Windows.Forms.ToolStripButton();
            this.dgv_Data = new System.Windows.Forms.DataGridView();
            this.urunBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Kod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AlisFiyat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SatisFiyat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stopaj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kdv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SonGuncellenmeTarihi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KayitTarihi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BirimId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Birim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.urunBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_YeniKayit});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1011, 25);
            this.toolStrip1.TabIndex = 2;
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
            this.Ad,
            this.AlisFiyat,
            this.SatisFiyat,
            this.Stopaj,
            this.Kdv,
            this.SonGuncellenmeTarihi,
            this.KayitTarihi,
            this.BirimId,
            this.Birim,
            this.Id});
            this.dgv_Data.DataSource = this.urunBindingSource;
            this.dgv_Data.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Data.Location = new System.Drawing.Point(0, 25);
            this.dgv_Data.Name = "dgv_Data";
            this.dgv_Data.ReadOnly = true;
            this.dgv_Data.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Data.Size = new System.Drawing.Size(1011, 614);
            this.dgv_Data.TabIndex = 3;
            this.dgv_Data.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_Data_CellMouseDown);
            // 
            // urunBindingSource
            // 
            this.urunBindingSource.DataSource = typeof(TarimMuhasebe.Entities.Urun);
            // 
            // Kod
            // 
            this.Kod.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Kod.DataPropertyName = "Kod";
            this.Kod.HeaderText = "Kod";
            this.Kod.Name = "Kod";
            this.Kod.ReadOnly = true;
            // 
            // Ad
            // 
            this.Ad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Ad.DataPropertyName = "Ad";
            this.Ad.HeaderText = "Ad";
            this.Ad.Name = "Ad";
            this.Ad.ReadOnly = true;
            // 
            // AlisFiyat
            // 
            this.AlisFiyat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.AlisFiyat.DataPropertyName = "AlisFiyat";
            this.AlisFiyat.HeaderText = "Alış Fiyat";
            this.AlisFiyat.Name = "AlisFiyat";
            this.AlisFiyat.ReadOnly = true;
            // 
            // SatisFiyat
            // 
            this.SatisFiyat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SatisFiyat.DataPropertyName = "SatisFiyat";
            this.SatisFiyat.HeaderText = "Satış Fiyat";
            this.SatisFiyat.Name = "SatisFiyat";
            this.SatisFiyat.ReadOnly = true;
            // 
            // Stopaj
            // 
            this.Stopaj.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Stopaj.DataPropertyName = "Stopaj";
            this.Stopaj.HeaderText = "Stopaj Oranı";
            this.Stopaj.Name = "Stopaj";
            this.Stopaj.ReadOnly = true;
            // 
            // Kdv
            // 
            this.Kdv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Kdv.DataPropertyName = "Kdv";
            this.Kdv.HeaderText = "Kdv Oranı";
            this.Kdv.Name = "Kdv";
            this.Kdv.ReadOnly = true;
            // 
            // SonGuncellenmeTarihi
            // 
            this.SonGuncellenmeTarihi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SonGuncellenmeTarihi.DataPropertyName = "SonGuncellenmeTarihi";
            this.SonGuncellenmeTarihi.HeaderText = "Güncellenme Tarihi";
            this.SonGuncellenmeTarihi.Name = "SonGuncellenmeTarihi";
            this.SonGuncellenmeTarihi.ReadOnly = true;
            // 
            // KayitTarihi
            // 
            this.KayitTarihi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.KayitTarihi.DataPropertyName = "KayitTarihi";
            this.KayitTarihi.HeaderText = "KayitTarihi";
            this.KayitTarihi.Name = "KayitTarihi";
            this.KayitTarihi.ReadOnly = true;
            // 
            // BirimId
            // 
            this.BirimId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BirimId.DataPropertyName = "BirimId";
            this.BirimId.HeaderText = "BirimId";
            this.BirimId.Name = "BirimId";
            this.BirimId.ReadOnly = true;
            this.BirimId.Visible = false;
            // 
            // Birim
            // 
            this.Birim.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Birim.DataPropertyName = "Birim";
            this.Birim.HeaderText = "Birim";
            this.Birim.Name = "Birim";
            this.Birim.ReadOnly = true;
            this.Birim.Visible = false;
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
            // UrunUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgv_Data);
            this.Controls.Add(this.toolStrip1);
            this.Name = "UrunUC";
            this.Size = new System.Drawing.Size(1011, 639);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.urunBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btn_YeniKayit;
        private System.Windows.Forms.DataGridView dgv_Data;
        private System.Windows.Forms.BindingSource urunBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kod;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ad;
        private System.Windows.Forms.DataGridViewTextBoxColumn AlisFiyat;
        private System.Windows.Forms.DataGridViewTextBoxColumn SatisFiyat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stopaj;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kdv;
        private System.Windows.Forms.DataGridViewTextBoxColumn SonGuncellenmeTarihi;
        private System.Windows.Forms.DataGridViewTextBoxColumn KayitTarihi;
        private System.Windows.Forms.DataGridViewTextBoxColumn BirimId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Birim;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
    }
}
