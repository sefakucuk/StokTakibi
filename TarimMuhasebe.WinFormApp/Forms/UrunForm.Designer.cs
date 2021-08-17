
namespace TarimMuhasebe.WinFormApp.Forms
{
    partial class UrunForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UrunForm));
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Ad = new System.Windows.Forms.TextBox();
            this.btn_Kaydet = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Kod = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nmbr_AlisFiyat = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.nmbr_SatisFiyat = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.nmbr_Stopaj = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.nmbr_Kdv = new System.Windows.Forms.NumericUpDown();
            this.cmb_Birim = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            this.chc_AnasayfaGosterim = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.nmbr_AlisFiyat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmbr_SatisFiyat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmbr_Stopaj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmbr_Kdv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 45;
            this.label2.Text = "Ad";
            // 
            // txt_Ad
            // 
            this.txt_Ad.Location = new System.Drawing.Point(92, 35);
            this.txt_Ad.MaxLength = 150;
            this.txt_Ad.Name = "txt_Ad";
            this.txt_Ad.Size = new System.Drawing.Size(415, 20);
            this.txt_Ad.TabIndex = 44;
            // 
            // btn_Kaydet
            // 
            this.btn_Kaydet.Location = new System.Drawing.Point(432, 192);
            this.btn_Kaydet.Name = "btn_Kaydet";
            this.btn_Kaydet.Size = new System.Drawing.Size(75, 23);
            this.btn_Kaydet.TabIndex = 43;
            this.btn_Kaydet.Text = "Kaydet";
            this.btn_Kaydet.UseVisualStyleBackColor = true;
            this.btn_Kaydet.Click += new System.EventHandler(this.btn_Kaydet_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 42;
            this.label1.Text = "Kod";
            // 
            // txt_Kod
            // 
            this.txt_Kod.Location = new System.Drawing.Point(92, 9);
            this.txt_Kod.MaxLength = 20;
            this.txt_Kod.Name = "txt_Kod";
            this.txt_Kod.Size = new System.Drawing.Size(415, 20);
            this.txt_Kod.TabIndex = 41;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 53;
            this.label3.Text = "Alış Fiyat";
            // 
            // nmbr_AlisFiyat
            // 
            this.nmbr_AlisFiyat.DecimalPlaces = 6;
            this.nmbr_AlisFiyat.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nmbr_AlisFiyat.Location = new System.Drawing.Point(92, 61);
            this.nmbr_AlisFiyat.Maximum = new decimal(new int[] {
            -1486618625,
            232830643,
            0,
            393216});
            this.nmbr_AlisFiyat.Name = "nmbr_AlisFiyat";
            this.nmbr_AlisFiyat.Size = new System.Drawing.Size(415, 20);
            this.nmbr_AlisFiyat.TabIndex = 52;
            this.nmbr_AlisFiyat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 55;
            this.label6.Text = "Satış Fiyat";
            // 
            // nmbr_SatisFiyat
            // 
            this.nmbr_SatisFiyat.DecimalPlaces = 6;
            this.nmbr_SatisFiyat.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nmbr_SatisFiyat.Location = new System.Drawing.Point(92, 87);
            this.nmbr_SatisFiyat.Maximum = new decimal(new int[] {
            -1486618625,
            232830643,
            0,
            393216});
            this.nmbr_SatisFiyat.Name = "nmbr_SatisFiyat";
            this.nmbr_SatisFiyat.Size = new System.Drawing.Size(415, 20);
            this.nmbr_SatisFiyat.TabIndex = 54;
            this.nmbr_SatisFiyat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 115);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 57;
            this.label7.Text = "Stopaj Oranı";
            // 
            // nmbr_Stopaj
            // 
            this.nmbr_Stopaj.DecimalPlaces = 2;
            this.nmbr_Stopaj.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nmbr_Stopaj.Location = new System.Drawing.Point(92, 113);
            this.nmbr_Stopaj.Name = "nmbr_Stopaj";
            this.nmbr_Stopaj.Size = new System.Drawing.Size(415, 20);
            this.nmbr_Stopaj.TabIndex = 56;
            this.nmbr_Stopaj.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 141);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 13);
            this.label8.TabIndex = 59;
            this.label8.Text = "Kdv Oranı";
            // 
            // nmbr_Kdv
            // 
            this.nmbr_Kdv.DecimalPlaces = 2;
            this.nmbr_Kdv.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nmbr_Kdv.Location = new System.Drawing.Point(92, 139);
            this.nmbr_Kdv.Name = "nmbr_Kdv";
            this.nmbr_Kdv.Size = new System.Drawing.Size(415, 20);
            this.nmbr_Kdv.TabIndex = 58;
            this.nmbr_Kdv.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cmb_Birim
            // 
            this.cmb_Birim.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Birim.FormattingEnabled = true;
            this.cmb_Birim.Location = new System.Drawing.Point(92, 165);
            this.cmb_Birim.Name = "cmb_Birim";
            this.cmb_Birim.Size = new System.Drawing.Size(415, 21);
            this.cmb_Birim.TabIndex = 60;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 61;
            this.label4.Text = "Birim";
            // 
            // error
            // 
            this.error.ContainerControl = this;
            // 
            // chc_AnasayfaGosterim
            // 
            this.chc_AnasayfaGosterim.AutoSize = true;
            this.chc_AnasayfaGosterim.Location = new System.Drawing.Point(92, 196);
            this.chc_AnasayfaGosterim.Name = "chc_AnasayfaGosterim";
            this.chc_AnasayfaGosterim.Size = new System.Drawing.Size(116, 17);
            this.chc_AnasayfaGosterim.TabIndex = 62;
            this.chc_AnasayfaGosterim.Text = "Anasayfada Göster";
            this.chc_AnasayfaGosterim.UseVisualStyleBackColor = true;
            // 
            // UrunForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 223);
            this.Controls.Add(this.chc_AnasayfaGosterim);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmb_Birim);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.nmbr_Kdv);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.nmbr_Stopaj);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.nmbr_SatisFiyat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nmbr_AlisFiyat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Ad);
            this.Controls.Add(this.btn_Kaydet);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Kod);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(540, 262);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(540, 262);
            this.Name = "UrunForm";
            this.Text = "Ürün";
            ((System.ComponentModel.ISupportInitialize)(this.nmbr_AlisFiyat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmbr_SatisFiyat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmbr_Stopaj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmbr_Kdv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Ad;
        private System.Windows.Forms.Button btn_Kaydet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Kod;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nmbr_AlisFiyat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nmbr_SatisFiyat;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nmbr_Stopaj;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown nmbr_Kdv;
        private System.Windows.Forms.ComboBox cmb_Birim;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ErrorProvider error;
        private System.Windows.Forms.CheckBox chc_AnasayfaGosterim;
    }
}