
namespace TarimMuhasebe.WinFormApp.UserControls
{
    partial class StokUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StokUC));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btn_YeniKayit = new System.Windows.Forms.ToolStripButton();
            this.dgv_Data = new System.Windows.Forms.DataGridView();
            this.stokBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmb_Depo = new System.Windows.Forms.ToolStripComboBox();
            this.cmb_Urun = new System.Windows.Forms.ToolStripComboBox();
            this.btn_Raporla = new System.Windows.Forms.ToolStripButton();
            this.btn_Filtrele = new System.Windows.Forms.ToolStripButton();
            this.UrunId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Urun = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DepoId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Depo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Miktar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Birim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stokBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_YeniKayit,
            this.btn_Raporla,
            this.btn_Filtrele,
            this.cmb_Depo,
            this.cmb_Urun});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(965, 25);
            this.toolStrip1.TabIndex = 3;
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
            this.UrunId,
            this.Urun,
            this.DepoId,
            this.Depo,
            this.Miktar,
            this.Id,
            this.Birim});
            this.dgv_Data.DataSource = this.stokBindingSource;
            this.dgv_Data.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Data.Location = new System.Drawing.Point(0, 25);
            this.dgv_Data.Name = "dgv_Data";
            this.dgv_Data.ReadOnly = true;
            this.dgv_Data.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Data.Size = new System.Drawing.Size(965, 583);
            this.dgv_Data.TabIndex = 4;
            this.dgv_Data.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_Data_CellMouseDown);
            // 
            // stokBindingSource
            // 
            this.stokBindingSource.DataSource = typeof(TarimMuhasebe.Entities.Stok);
            // 
            // cmb_Depo
            // 
            this.cmb_Depo.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.cmb_Depo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Depo.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.cmb_Depo.Name = "cmb_Depo";
            this.cmb_Depo.Size = new System.Drawing.Size(121, 25);
            // 
            // cmb_Urun
            // 
            this.cmb_Urun.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.cmb_Urun.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Urun.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.cmb_Urun.Name = "cmb_Urun";
            this.cmb_Urun.Size = new System.Drawing.Size(121, 25);
            // 
            // btn_Raporla
            // 
            this.btn_Raporla.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btn_Raporla.Image = ((System.Drawing.Image)(resources.GetObject("btn_Raporla.Image")));
            this.btn_Raporla.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Raporla.Name = "btn_Raporla";
            this.btn_Raporla.Size = new System.Drawing.Size(67, 22);
            this.btn_Raporla.Text = "Raporla";
            this.btn_Raporla.Click += new System.EventHandler(this.btn_Raporla_Click);
            // 
            // btn_Filtrele
            // 
            this.btn_Filtrele.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btn_Filtrele.Image = ((System.Drawing.Image)(resources.GetObject("btn_Filtrele.Image")));
            this.btn_Filtrele.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Filtrele.Name = "btn_Filtrele";
            this.btn_Filtrele.Size = new System.Drawing.Size(62, 22);
            this.btn_Filtrele.Text = "Filtrele";
            this.btn_Filtrele.Click += new System.EventHandler(this.btn_Filtrele_Click);
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
            // Miktar
            // 
            this.Miktar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Miktar.DataPropertyName = "Miktar";
            this.Miktar.HeaderText = "Miktar";
            this.Miktar.Name = "Miktar";
            this.Miktar.ReadOnly = true;
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
            // Birim
            // 
            this.Birim.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Birim.DataPropertyName = "Birim";
            this.Birim.HeaderText = "Birim";
            this.Birim.Name = "Birim";
            this.Birim.ReadOnly = true;
            // 
            // StokUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgv_Data);
            this.Controls.Add(this.toolStrip1);
            this.Name = "StokUC";
            this.Size = new System.Drawing.Size(965, 608);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stokBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btn_YeniKayit;
        private System.Windows.Forms.DataGridView dgv_Data;
        private System.Windows.Forms.BindingSource stokBindingSource;
        private System.Windows.Forms.ToolStripButton btn_Raporla;
        private System.Windows.Forms.ToolStripButton btn_Filtrele;
        private System.Windows.Forms.ToolStripComboBox cmb_Depo;
        private System.Windows.Forms.ToolStripComboBox cmb_Urun;
        private System.Windows.Forms.DataGridViewTextBoxColumn UrunId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Urun;
        private System.Windows.Forms.DataGridViewTextBoxColumn DepoId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Depo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Miktar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Birim;
    }
}
