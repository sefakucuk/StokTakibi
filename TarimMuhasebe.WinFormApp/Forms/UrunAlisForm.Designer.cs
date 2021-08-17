
namespace TarimMuhasebe.WinFormApp.Forms
{
    partial class UrunAlisForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UrunAlisForm));
            this.cmb_Cari = new System.Windows.Forms.ComboBox();
            this.cmb_Urun = new System.Windows.Forms.ComboBox();
            this.cmb_Depo = new System.Windows.Forms.ComboBox();
            this.cmb_Kasa = new System.Windows.Forms.ComboBox();
            this.nmbr_Miktar = new System.Windows.Forms.NumericUpDown();
            this.nmbr_BirimFiyat = new System.Windows.Forms.NumericUpDown();
            this.chc_Stopaj = new System.Windows.Forms.CheckBox();
            this.lbl_Toplam = new System.Windows.Forms.Label();
            this.txt_Aciklama = new System.Windows.Forms.TextBox();
            this.btn_Kaydet = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_No = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            this.nmbr_Stopaj = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nmbr_Miktar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmbr_BirimFiyat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmbr_Stopaj)).BeginInit();
            this.SuspendLayout();
            // 
            // cmb_Cari
            // 
            this.cmb_Cari.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Cari.FormattingEnabled = true;
            this.cmb_Cari.Location = new System.Drawing.Point(78, 38);
            this.cmb_Cari.Name = "cmb_Cari";
            this.cmb_Cari.Size = new System.Drawing.Size(425, 21);
            this.cmb_Cari.TabIndex = 0;
            // 
            // cmb_Urun
            // 
            this.cmb_Urun.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Urun.FormattingEnabled = true;
            this.cmb_Urun.Location = new System.Drawing.Point(78, 65);
            this.cmb_Urun.Name = "cmb_Urun";
            this.cmb_Urun.Size = new System.Drawing.Size(425, 21);
            this.cmb_Urun.TabIndex = 1;
            this.cmb_Urun.SelectedValueChanged += new System.EventHandler(this.cmb_Urun_SelectedValueChanged);
            // 
            // cmb_Depo
            // 
            this.cmb_Depo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Depo.FormattingEnabled = true;
            this.cmb_Depo.Location = new System.Drawing.Point(78, 92);
            this.cmb_Depo.Name = "cmb_Depo";
            this.cmb_Depo.Size = new System.Drawing.Size(425, 21);
            this.cmb_Depo.TabIndex = 2;
            // 
            // cmb_Kasa
            // 
            this.cmb_Kasa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Kasa.FormattingEnabled = true;
            this.cmb_Kasa.Location = new System.Drawing.Point(78, 119);
            this.cmb_Kasa.Name = "cmb_Kasa";
            this.cmb_Kasa.Size = new System.Drawing.Size(425, 21);
            this.cmb_Kasa.TabIndex = 3;
            // 
            // nmbr_Miktar
            // 
            this.nmbr_Miktar.DecimalPlaces = 6;
            this.nmbr_Miktar.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nmbr_Miktar.Location = new System.Drawing.Point(78, 146);
            this.nmbr_Miktar.Maximum = new decimal(new int[] {
            -1486618625,
            232830643,
            0,
            393216});
            this.nmbr_Miktar.Name = "nmbr_Miktar";
            this.nmbr_Miktar.Size = new System.Drawing.Size(425, 20);
            this.nmbr_Miktar.TabIndex = 4;
            this.nmbr_Miktar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nmbr_Miktar.ValueChanged += new System.EventHandler(this.Toplam_ValueChanged);
            // 
            // nmbr_BirimFiyat
            // 
            this.nmbr_BirimFiyat.DecimalPlaces = 6;
            this.nmbr_BirimFiyat.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nmbr_BirimFiyat.Location = new System.Drawing.Point(78, 172);
            this.nmbr_BirimFiyat.Maximum = new decimal(new int[] {
            -1486618625,
            232830643,
            0,
            393216});
            this.nmbr_BirimFiyat.Name = "nmbr_BirimFiyat";
            this.nmbr_BirimFiyat.Size = new System.Drawing.Size(425, 20);
            this.nmbr_BirimFiyat.TabIndex = 5;
            this.nmbr_BirimFiyat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nmbr_BirimFiyat.ValueChanged += new System.EventHandler(this.Toplam_ValueChanged);
            // 
            // chc_Stopaj
            // 
            this.chc_Stopaj.AutoSize = true;
            this.chc_Stopaj.Location = new System.Drawing.Point(78, 288);
            this.chc_Stopaj.Name = "chc_Stopaj";
            this.chc_Stopaj.Size = new System.Drawing.Size(83, 17);
            this.chc_Stopaj.TabIndex = 6;
            this.chc_Stopaj.Text = "Stopaj Dahil";
            this.chc_Stopaj.UseVisualStyleBackColor = true;
            this.chc_Stopaj.CheckedChanged += new System.EventHandler(this.Toplam_ValueChanged);
            // 
            // lbl_Toplam
            // 
            this.lbl_Toplam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Toplam.Location = new System.Drawing.Point(167, 289);
            this.lbl_Toplam.Name = "lbl_Toplam";
            this.lbl_Toplam.Size = new System.Drawing.Size(336, 16);
            this.lbl_Toplam.TabIndex = 7;
            this.lbl_Toplam.Text = "Toplam : 0.00 ₺";
            this.lbl_Toplam.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_Aciklama
            // 
            this.txt_Aciklama.Location = new System.Drawing.Point(78, 224);
            this.txt_Aciklama.MaxLength = 500;
            this.txt_Aciklama.Multiline = true;
            this.txt_Aciklama.Name = "txt_Aciklama";
            this.txt_Aciklama.Size = new System.Drawing.Size(425, 58);
            this.txt_Aciklama.TabIndex = 8;
            // 
            // btn_Kaydet
            // 
            this.btn_Kaydet.Location = new System.Drawing.Point(428, 308);
            this.btn_Kaydet.Name = "btn_Kaydet";
            this.btn_Kaydet.Size = new System.Drawing.Size(75, 23);
            this.btn_Kaydet.TabIndex = 44;
            this.btn_Kaydet.Text = "Kaydet";
            this.btn_Kaydet.UseVisualStyleBackColor = true;
            this.btn_Kaydet.Click += new System.EventHandler(this.btn_Kaydet_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 45;
            this.label2.Text = "Cari";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 46;
            this.label3.Text = "Ürün";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 47;
            this.label4.Text = "Depo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 48;
            this.label5.Text = "Kasa";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 49;
            this.label6.Text = "Miktar";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 174);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 50;
            this.label7.Text = "Fiyat";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 227);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 13);
            this.label8.TabIndex = 51;
            this.label8.Text = "Açıklama";
            // 
            // txt_No
            // 
            this.txt_No.Location = new System.Drawing.Point(78, 12);
            this.txt_No.MaxLength = 150;
            this.txt_No.Name = "txt_No";
            this.txt_No.Size = new System.Drawing.Size(425, 20);
            this.txt_No.TabIndex = 52;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 13);
            this.label9.TabIndex = 53;
            this.label9.Text = "İşlem No";
            // 
            // error
            // 
            this.error.ContainerControl = this;
            // 
            // nmbr_Stopaj
            // 
            this.nmbr_Stopaj.DecimalPlaces = 2;
            this.nmbr_Stopaj.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nmbr_Stopaj.Location = new System.Drawing.Point(78, 198);
            this.nmbr_Stopaj.Maximum = new decimal(new int[] {
            -1486618625,
            232830643,
            0,
            393216});
            this.nmbr_Stopaj.Name = "nmbr_Stopaj";
            this.nmbr_Stopaj.Size = new System.Drawing.Size(425, 20);
            this.nmbr_Stopaj.TabIndex = 54;
            this.nmbr_Stopaj.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nmbr_Stopaj.ValueChanged += new System.EventHandler(this.Toplam_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 55;
            this.label1.Text = "Stopaj Oran";
            // 
            // UrunAlisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 339);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nmbr_Stopaj);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_No);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Kaydet);
            this.Controls.Add(this.txt_Aciklama);
            this.Controls.Add(this.lbl_Toplam);
            this.Controls.Add(this.chc_Stopaj);
            this.Controls.Add(this.nmbr_BirimFiyat);
            this.Controls.Add(this.nmbr_Miktar);
            this.Controls.Add(this.cmb_Kasa);
            this.Controls.Add(this.cmb_Depo);
            this.Controls.Add(this.cmb_Urun);
            this.Controls.Add(this.cmb_Cari);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(540, 378);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(540, 378);
            this.Name = "UrunAlisForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ürün Alış";
            ((System.ComponentModel.ISupportInitialize)(this.nmbr_Miktar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmbr_BirimFiyat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmbr_Stopaj)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_Cari;
        private System.Windows.Forms.ComboBox cmb_Urun;
        private System.Windows.Forms.ComboBox cmb_Depo;
        private System.Windows.Forms.ComboBox cmb_Kasa;
        private System.Windows.Forms.NumericUpDown nmbr_Miktar;
        private System.Windows.Forms.NumericUpDown nmbr_BirimFiyat;
        private System.Windows.Forms.CheckBox chc_Stopaj;
        private System.Windows.Forms.Label lbl_Toplam;
        private System.Windows.Forms.TextBox txt_Aciklama;
        private System.Windows.Forms.Button btn_Kaydet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_No;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ErrorProvider error;
        private System.Windows.Forms.NumericUpDown nmbr_Stopaj;
        private System.Windows.Forms.Label label1;
    }
}