
namespace TarimMuhasebe.WinFormApp.UserControls
{
    partial class CariUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CariUC));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btn_YeniKayit = new System.Windows.Forms.ToolStripButton();
            this.cariBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgv_Data = new System.Windows.Forms.DataGridView();
            this.Kod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unvan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VergiNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VergiDairesi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Yetkili = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Il = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ilce = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tel1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tel2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Eposta1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Eposta2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Aktif = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cariBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Data)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_YeniKayit});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1222, 25);
            this.toolStrip1.TabIndex = 0;
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
            // cariBindingSource
            // 
            this.cariBindingSource.DataSource = typeof(TarimMuhasebe.Entities.Cari);
            // 
            // dgv_Data
            // 
            this.dgv_Data.AllowUserToAddRows = false;
            this.dgv_Data.AllowUserToDeleteRows = false;
            this.dgv_Data.AllowUserToOrderColumns = true;
            this.dgv_Data.AutoGenerateColumns = false;
            this.dgv_Data.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv_Data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Data.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Kod,
            this.Unvan,
            this.VergiNo,
            this.VergiDairesi,
            this.Yetkili,
            this.Il,
            this.Ilce,
            this.Adres,
            this.Tel1,
            this.Tel2,
            this.Eposta1,
            this.Eposta2,
            this.Fax,
            this.Aktif,
            this.Id});
            this.dgv_Data.DataSource = this.cariBindingSource;
            this.dgv_Data.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Data.Location = new System.Drawing.Point(0, 25);
            this.dgv_Data.MultiSelect = false;
            this.dgv_Data.Name = "dgv_Data";
            this.dgv_Data.ReadOnly = true;
            this.dgv_Data.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Data.Size = new System.Drawing.Size(1222, 576);
            this.dgv_Data.TabIndex = 1;
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
            // Unvan
            // 
            this.Unvan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Unvan.DataPropertyName = "Unvan";
            this.Unvan.HeaderText = "Unvan";
            this.Unvan.Name = "Unvan";
            this.Unvan.ReadOnly = true;
            // 
            // VergiNo
            // 
            this.VergiNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.VergiNo.DataPropertyName = "VergiNo";
            this.VergiNo.HeaderText = "Vergi No";
            this.VergiNo.Name = "VergiNo";
            this.VergiNo.ReadOnly = true;
            // 
            // VergiDairesi
            // 
            this.VergiDairesi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.VergiDairesi.DataPropertyName = "VergiDairesi";
            this.VergiDairesi.HeaderText = "Vergi Dairesi";
            this.VergiDairesi.Name = "VergiDairesi";
            this.VergiDairesi.ReadOnly = true;
            // 
            // Yetkili
            // 
            this.Yetkili.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Yetkili.DataPropertyName = "Yetkili";
            this.Yetkili.HeaderText = "Yetkili";
            this.Yetkili.Name = "Yetkili";
            this.Yetkili.ReadOnly = true;
            // 
            // Il
            // 
            this.Il.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Il.DataPropertyName = "Il";
            this.Il.HeaderText = "İl";
            this.Il.Name = "Il";
            this.Il.ReadOnly = true;
            // 
            // Ilce
            // 
            this.Ilce.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Ilce.DataPropertyName = "Ilce";
            this.Ilce.HeaderText = "İlçe";
            this.Ilce.Name = "Ilce";
            this.Ilce.ReadOnly = true;
            // 
            // Adres
            // 
            this.Adres.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Adres.DataPropertyName = "Adres";
            this.Adres.HeaderText = "Adres";
            this.Adres.Name = "Adres";
            this.Adres.ReadOnly = true;
            this.Adres.Visible = false;
            // 
            // Tel1
            // 
            this.Tel1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Tel1.DataPropertyName = "Tel1";
            this.Tel1.HeaderText = "Tel-1";
            this.Tel1.Name = "Tel1";
            this.Tel1.ReadOnly = true;
            // 
            // Tel2
            // 
            this.Tel2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Tel2.DataPropertyName = "Tel2";
            this.Tel2.HeaderText = "Tel-2";
            this.Tel2.Name = "Tel2";
            this.Tel2.ReadOnly = true;
            // 
            // Eposta1
            // 
            this.Eposta1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Eposta1.DataPropertyName = "Eposta1";
            this.Eposta1.HeaderText = "Eposta-1";
            this.Eposta1.Name = "Eposta1";
            this.Eposta1.ReadOnly = true;
            // 
            // Eposta2
            // 
            this.Eposta2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Eposta2.DataPropertyName = "Eposta2";
            this.Eposta2.HeaderText = "Eposta-2";
            this.Eposta2.Name = "Eposta2";
            this.Eposta2.ReadOnly = true;
            // 
            // Fax
            // 
            this.Fax.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Fax.DataPropertyName = "Fax";
            this.Fax.HeaderText = "Fax";
            this.Fax.Name = "Fax";
            this.Fax.ReadOnly = true;
            // 
            // Aktif
            // 
            this.Aktif.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Aktif.DataPropertyName = "Aktif";
            this.Aktif.HeaderText = "Aktif";
            this.Aktif.Name = "Aktif";
            this.Aktif.ReadOnly = true;
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
            // CariUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgv_Data);
            this.Controls.Add(this.toolStrip1);
            this.Name = "CariUC";
            this.Size = new System.Drawing.Size(1222, 601);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cariBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Data)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource cariBindingSource;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btn_YeniKayit;
        private System.Windows.Forms.DataGridView dgv_Data;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kod;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unvan;
        private System.Windows.Forms.DataGridViewTextBoxColumn VergiNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn VergiDairesi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Yetkili;
        private System.Windows.Forms.DataGridViewTextBoxColumn Il;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ilce;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adres;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Eposta1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Eposta2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fax;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Aktif;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
    }
}
