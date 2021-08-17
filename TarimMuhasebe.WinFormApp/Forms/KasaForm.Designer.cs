
namespace TarimMuhasebe.WinFormApp.Forms
{
    partial class KasaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KasaForm));
            this.txt_Kod = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            this.btn_Kaydet = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Ad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Aciklama = new System.Windows.Forms.TextBox();
            this.nmbr_AcilisTutar = new System.Windows.Forms.NumericUpDown();
            this.nmbr_GuncelTutar = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.date_AcilisTarihi = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.chc_AnasayfaGosterim = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmbr_AcilisTutar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmbr_GuncelTutar)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_Kod
            // 
            this.txt_Kod.Location = new System.Drawing.Point(86, 10);
            this.txt_Kod.MaxLength = 20;
            this.txt_Kod.Name = "txt_Kod";
            this.txt_Kod.Size = new System.Drawing.Size(415, 20);
            this.txt_Kod.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "Kod";
            // 
            // error
            // 
            this.error.ContainerControl = this;
            // 
            // btn_Kaydet
            // 
            this.btn_Kaydet.Location = new System.Drawing.Point(426, 196);
            this.btn_Kaydet.Name = "btn_Kaydet";
            this.btn_Kaydet.Size = new System.Drawing.Size(75, 23);
            this.btn_Kaydet.TabIndex = 30;
            this.btn_Kaydet.Text = "Kaydet";
            this.btn_Kaydet.UseVisualStyleBackColor = true;
            this.btn_Kaydet.Click += new System.EventHandler(this.btn_Kaydet_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "Ad";
            // 
            // txt_Ad
            // 
            this.txt_Ad.Location = new System.Drawing.Point(86, 36);
            this.txt_Ad.MaxLength = 150;
            this.txt_Ad.Name = "txt_Ad";
            this.txt_Ad.Size = new System.Drawing.Size(415, 20);
            this.txt_Ad.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "Açıklama";
            // 
            // txt_Aciklama
            // 
            this.txt_Aciklama.Location = new System.Drawing.Point(86, 62);
            this.txt_Aciklama.MaxLength = 500;
            this.txt_Aciklama.Multiline = true;
            this.txt_Aciklama.Name = "txt_Aciklama";
            this.txt_Aciklama.Size = new System.Drawing.Size(415, 49);
            this.txt_Aciklama.TabIndex = 33;
            // 
            // nmbr_AcilisTutar
            // 
            this.nmbr_AcilisTutar.DecimalPlaces = 6;
            this.nmbr_AcilisTutar.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nmbr_AcilisTutar.Location = new System.Drawing.Point(86, 144);
            this.nmbr_AcilisTutar.Maximum = new decimal(new int[] {
            -1486618625,
            232830643,
            0,
            393216});
            this.nmbr_AcilisTutar.Name = "nmbr_AcilisTutar";
            this.nmbr_AcilisTutar.Size = new System.Drawing.Size(415, 20);
            this.nmbr_AcilisTutar.TabIndex = 35;
            this.nmbr_AcilisTutar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // nmbr_GuncelTutar
            // 
            this.nmbr_GuncelTutar.DecimalPlaces = 6;
            this.nmbr_GuncelTutar.Enabled = false;
            this.nmbr_GuncelTutar.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nmbr_GuncelTutar.Location = new System.Drawing.Point(86, 170);
            this.nmbr_GuncelTutar.Maximum = new decimal(new int[] {
            -1486618625,
            232830643,
            0,
            393216});
            this.nmbr_GuncelTutar.Name = "nmbr_GuncelTutar";
            this.nmbr_GuncelTutar.Size = new System.Drawing.Size(415, 20);
            this.nmbr_GuncelTutar.TabIndex = 36;
            this.nmbr_GuncelTutar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 37;
            this.label4.Text = "Açılış Tutar";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 38;
            this.label5.Text = "Güncel Tutar";
            // 
            // date_AcilisTarihi
            // 
            this.date_AcilisTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_AcilisTarihi.Location = new System.Drawing.Point(86, 118);
            this.date_AcilisTarihi.Name = "date_AcilisTarihi";
            this.date_AcilisTarihi.Size = new System.Drawing.Size(415, 20);
            this.date_AcilisTarihi.TabIndex = 39;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 40;
            this.label6.Text = "Açılış Tarihi";
            // 
            // chc_AnasayfaGosterim
            // 
            this.chc_AnasayfaGosterim.AutoSize = true;
            this.chc_AnasayfaGosterim.Location = new System.Drawing.Point(86, 200);
            this.chc_AnasayfaGosterim.Name = "chc_AnasayfaGosterim";
            this.chc_AnasayfaGosterim.Size = new System.Drawing.Size(116, 17);
            this.chc_AnasayfaGosterim.TabIndex = 63;
            this.chc_AnasayfaGosterim.Text = "Anasayfada Göster";
            this.chc_AnasayfaGosterim.UseVisualStyleBackColor = true;
            // 
            // KasaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 227);
            this.Controls.Add(this.chc_AnasayfaGosterim);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.date_AcilisTarihi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nmbr_GuncelTutar);
            this.Controls.Add(this.nmbr_AcilisTutar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_Aciklama);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Ad);
            this.Controls.Add(this.btn_Kaydet);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Kod);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(540, 266);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(540, 266);
            this.Name = "KasaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kasa";
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmbr_AcilisTutar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmbr_GuncelTutar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Kod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider error;
        private System.Windows.Forms.Button btn_Kaydet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Aciklama;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Ad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nmbr_GuncelTutar;
        private System.Windows.Forms.NumericUpDown nmbr_AcilisTutar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker date_AcilisTarihi;
        private System.Windows.Forms.CheckBox chc_AnasayfaGosterim;
    }
}