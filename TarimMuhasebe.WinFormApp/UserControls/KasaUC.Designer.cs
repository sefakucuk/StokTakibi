
namespace TarimMuhasebe.WinFormApp.UserControls
{
    partial class KasaUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KasaUC));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btn_YeniKayit = new System.Windows.Forms.ToolStripButton();
            this.dgv_Data = new System.Windows.Forms.DataGridView();
            this.Kod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Aciklama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AcilisTarihi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AcilisTutar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GuncelTutar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kasaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kasaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_YeniKayit});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(944, 25);
            this.toolStrip1.TabIndex = 1;
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
            this.Aciklama,
            this.AcilisTarihi,
            this.AcilisTutar,
            this.GuncelTutar,
            this.Id});
            this.dgv_Data.DataSource = this.kasaBindingSource;
            this.dgv_Data.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Data.Location = new System.Drawing.Point(0, 25);
            this.dgv_Data.Name = "dgv_Data";
            this.dgv_Data.ReadOnly = true;
            this.dgv_Data.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Data.Size = new System.Drawing.Size(944, 621);
            this.dgv_Data.TabIndex = 2;
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
            // Ad
            // 
            this.Ad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Ad.DataPropertyName = "Ad";
            this.Ad.HeaderText = "Ad";
            this.Ad.Name = "Ad";
            this.Ad.ReadOnly = true;
            // 
            // Aciklama
            // 
            this.Aciklama.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Aciklama.DataPropertyName = "Aciklama";
            this.Aciklama.HeaderText = "Açıklama";
            this.Aciklama.Name = "Aciklama";
            this.Aciklama.ReadOnly = true;
            // 
            // AcilisTarihi
            // 
            this.AcilisTarihi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.AcilisTarihi.DataPropertyName = "AcilisTarihi";
            this.AcilisTarihi.HeaderText = "Açılış Tarihi";
            this.AcilisTarihi.Name = "AcilisTarihi";
            this.AcilisTarihi.ReadOnly = true;
            // 
            // AcilisTutar
            // 
            this.AcilisTutar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.AcilisTutar.DataPropertyName = "AcilisTutar";
            this.AcilisTutar.HeaderText = "Açılış Tutar";
            this.AcilisTutar.Name = "AcilisTutar";
            this.AcilisTutar.ReadOnly = true;
            // 
            // GuncelTutar
            // 
            this.GuncelTutar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.GuncelTutar.DataPropertyName = "GuncelTutar";
            this.GuncelTutar.HeaderText = "Güncel Tutar";
            this.GuncelTutar.Name = "GuncelTutar";
            this.GuncelTutar.ReadOnly = true;
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
            // kasaBindingSource
            // 
            this.kasaBindingSource.DataSource = typeof(TarimMuhasebe.Entities.Kasa);
            // 
            // KasaUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgv_Data);
            this.Controls.Add(this.toolStrip1);
            this.Name = "KasaUC";
            this.Size = new System.Drawing.Size(944, 646);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kasaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btn_YeniKayit;
        private System.Windows.Forms.DataGridView dgv_Data;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kod;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Aciklama;
        private System.Windows.Forms.DataGridViewTextBoxColumn AcilisTarihi;
        private System.Windows.Forms.DataGridViewTextBoxColumn AcilisTutar;
        private System.Windows.Forms.DataGridViewTextBoxColumn GuncelTutar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.BindingSource kasaBindingSource;
    }
}
