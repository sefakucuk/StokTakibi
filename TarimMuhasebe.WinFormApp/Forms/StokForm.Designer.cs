
namespace TarimMuhasebe.WinFormApp.Forms
{
    partial class StokForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StokForm));
            this.label4 = new System.Windows.Forms.Label();
            this.cmb_Depo = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.nmbr_Miktar = new System.Windows.Forms.NumericUpDown();
            this.btn_Kaydet = new System.Windows.Forms.Button();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_Urun = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.nmbr_Miktar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 76;
            this.label4.Text = "Depo";
            // 
            // cmb_Depo
            // 
            this.cmb_Depo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Depo.FormattingEnabled = true;
            this.cmb_Depo.Location = new System.Drawing.Point(92, 39);
            this.cmb_Depo.Name = "cmb_Depo";
            this.cmb_Depo.Size = new System.Drawing.Size(415, 21);
            this.cmb_Depo.TabIndex = 75;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 70;
            this.label6.Text = "Miktar";
            // 
            // nmbr_Miktar
            // 
            this.nmbr_Miktar.DecimalPlaces = 6;
            this.nmbr_Miktar.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nmbr_Miktar.Location = new System.Drawing.Point(92, 66);
            this.nmbr_Miktar.Maximum = new decimal(new int[] {
            268435456,
            1042612833,
            542101086,
            131072});
            this.nmbr_Miktar.Name = "nmbr_Miktar";
            this.nmbr_Miktar.Size = new System.Drawing.Size(415, 20);
            this.nmbr_Miktar.TabIndex = 69;
            this.nmbr_Miktar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btn_Kaydet
            // 
            this.btn_Kaydet.Location = new System.Drawing.Point(432, 92);
            this.btn_Kaydet.Name = "btn_Kaydet";
            this.btn_Kaydet.Size = new System.Drawing.Size(75, 23);
            this.btn_Kaydet.TabIndex = 64;
            this.btn_Kaydet.Text = "Kaydet";
            this.btn_Kaydet.UseVisualStyleBackColor = true;
            this.btn_Kaydet.Click += new System.EventHandler(this.btn_Kaydet_Click);
            // 
            // error
            // 
            this.error.ContainerControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 78;
            this.label1.Text = "Ürün";
            // 
            // cmb_Urun
            // 
            this.cmb_Urun.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Urun.FormattingEnabled = true;
            this.cmb_Urun.Location = new System.Drawing.Point(92, 12);
            this.cmb_Urun.Name = "cmb_Urun";
            this.cmb_Urun.Size = new System.Drawing.Size(415, 21);
            this.cmb_Urun.TabIndex = 77;
            // 
            // StokForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 127);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_Urun);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmb_Depo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.nmbr_Miktar);
            this.Controls.Add(this.btn_Kaydet);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(540, 166);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(540, 166);
            this.Name = "StokForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stok";
            ((System.ComponentModel.ISupportInitialize)(this.nmbr_Miktar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmb_Depo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nmbr_Miktar;
        private System.Windows.Forms.Button btn_Kaydet;
        private System.Windows.Forms.ErrorProvider error;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_Urun;
    }
}