
namespace TarimMuhasebe.WinFormApp.Forms
{
    partial class CariHesapForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CariHesapForm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btn_Raporlama = new System.Windows.Forms.ToolStripButton();
            this.tool_Bottom = new System.Windows.Forms.ToolStrip();
            this.lbl_Toplam = new System.Windows.Forms.ToolStripLabel();
            this.dgv_Data = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tarih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kullanici = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kasa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tutar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            this.tool_Bottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Data)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_Raporlama});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btn_Raporlama
            // 
            this.btn_Raporlama.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btn_Raporlama.Image = ((System.Drawing.Image)(resources.GetObject("btn_Raporlama.Image")));
            this.btn_Raporlama.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Raporlama.Name = "btn_Raporlama";
            this.btn_Raporlama.Size = new System.Drawing.Size(84, 22);
            this.btn_Raporlama.Text = "Raporlama";
            this.btn_Raporlama.Click += new System.EventHandler(this.btn_Raporlama_Click);
            // 
            // tool_Bottom
            // 
            this.tool_Bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tool_Bottom.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbl_Toplam});
            this.tool_Bottom.Location = new System.Drawing.Point(0, 425);
            this.tool_Bottom.Name = "tool_Bottom";
            this.tool_Bottom.Size = new System.Drawing.Size(800, 25);
            this.tool_Bottom.TabIndex = 2;
            this.tool_Bottom.Text = "toolStrip2";
            // 
            // lbl_Toplam
            // 
            this.lbl_Toplam.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.lbl_Toplam.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Toplam.Name = "lbl_Toplam";
            this.lbl_Toplam.Size = new System.Drawing.Size(92, 22);
            this.lbl_Toplam.Text = "toolStripLabel1";
            // 
            // dgv_Data
            // 
            this.dgv_Data.AllowUserToAddRows = false;
            this.dgv_Data.AllowUserToDeleteRows = false;
            this.dgv_Data.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv_Data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Data.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Kod,
            this.Tip,
            this.Tarih,
            this.Kullanici,
            this.Kasa,
            this.Tutar});
            this.dgv_Data.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Data.Location = new System.Drawing.Point(0, 25);
            this.dgv_Data.Name = "dgv_Data";
            this.dgv_Data.ReadOnly = true;
            this.dgv_Data.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Data.Size = new System.Drawing.Size(800, 400);
            this.dgv_Data.TabIndex = 3;
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
            // Kod
            // 
            this.Kod.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Kod.DataPropertyName = "Kod";
            this.Kod.HeaderText = "Kod";
            this.Kod.Name = "Kod";
            this.Kod.ReadOnly = true;
            // 
            // Tip
            // 
            this.Tip.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Tip.DataPropertyName = "Tip";
            this.Tip.HeaderText = "Tip";
            this.Tip.Name = "Tip";
            this.Tip.ReadOnly = true;
            // 
            // Tarih
            // 
            this.Tarih.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Tarih.DataPropertyName = "Tarih";
            this.Tarih.HeaderText = "Tarih";
            this.Tarih.Name = "Tarih";
            this.Tarih.ReadOnly = true;
            // 
            // Kullanici
            // 
            this.Kullanici.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Kullanici.DataPropertyName = "Kullanici";
            this.Kullanici.HeaderText = "Kullanıcı";
            this.Kullanici.Name = "Kullanici";
            this.Kullanici.ReadOnly = true;
            // 
            // Kasa
            // 
            this.Kasa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Kasa.DataPropertyName = "Kasa";
            this.Kasa.HeaderText = "Kasa";
            this.Kasa.Name = "Kasa";
            this.Kasa.ReadOnly = true;
            // 
            // Tutar
            // 
            this.Tutar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Tutar.DataPropertyName = "Tutar";
            this.Tutar.HeaderText = "Tutar";
            this.Tutar.Name = "Tutar";
            this.Tutar.ReadOnly = true;
            // 
            // CariHesapForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgv_Data);
            this.Controls.Add(this.tool_Bottom);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CariHesapForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cari Hesapları";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tool_Bottom.ResumeLayout(false);
            this.tool_Bottom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Data)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStrip tool_Bottom;
        private System.Windows.Forms.DataGridView dgv_Data;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kod;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tip;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tarih;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kullanici;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kasa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tutar;
        private System.Windows.Forms.ToolStripLabel lbl_Toplam;
        private System.Windows.Forms.ToolStripButton btn_Raporlama;
    }
}