
namespace TarimMuhasebe.WinFormApp.Forms
{
    partial class GelirForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GelirForm));
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_OdemeTip = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_Kod = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Kaydet = new System.Windows.Forms.Button();
            this.txt_Aciklama = new System.Windows.Forms.TextBox();
            this.nmbr_Tutar = new System.Windows.Forms.NumericUpDown();
            this.cmb_Kasa = new System.Windows.Forms.ComboBox();
            this.cmb_Cari = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_Satis = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmbr_Tutar)).BeginInit();
            this.SuspendLayout();
            // 
            // error
            // 
            this.error.ContainerControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 87;
            this.label1.Text = "Ödeme Tipi";
            // 
            // cmb_OdemeTip
            // 
            this.cmb_OdemeTip.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_OdemeTip.FormattingEnabled = true;
            this.cmb_OdemeTip.Location = new System.Drawing.Point(83, 115);
            this.cmb_OdemeTip.Name = "cmb_OdemeTip";
            this.cmb_OdemeTip.Size = new System.Drawing.Size(425, 21);
            this.cmb_OdemeTip.TabIndex = 86;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 11);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 13);
            this.label9.TabIndex = 85;
            this.label9.Text = "İşlem Kodu";
            // 
            // txt_Kod
            // 
            this.txt_Kod.Location = new System.Drawing.Point(83, 8);
            this.txt_Kod.MaxLength = 20;
            this.txt_Kod.Name = "txt_Kod";
            this.txt_Kod.Size = new System.Drawing.Size(425, 20);
            this.txt_Kod.TabIndex = 84;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 171);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 13);
            this.label8.TabIndex = 83;
            this.label8.Text = "Açıklama";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 144);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 82;
            this.label7.Text = "Tutar";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 81;
            this.label5.Text = "Kasa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 80;
            this.label2.Text = "Cari";
            // 
            // btn_Kaydet
            // 
            this.btn_Kaydet.Location = new System.Drawing.Point(433, 232);
            this.btn_Kaydet.Name = "btn_Kaydet";
            this.btn_Kaydet.Size = new System.Drawing.Size(75, 23);
            this.btn_Kaydet.TabIndex = 79;
            this.btn_Kaydet.Text = "Kaydet";
            this.btn_Kaydet.UseVisualStyleBackColor = true;
            this.btn_Kaydet.Click += new System.EventHandler(this.btn_Kaydet_Click);
            // 
            // txt_Aciklama
            // 
            this.txt_Aciklama.Location = new System.Drawing.Point(83, 168);
            this.txt_Aciklama.MaxLength = 500;
            this.txt_Aciklama.Multiline = true;
            this.txt_Aciklama.Name = "txt_Aciklama";
            this.txt_Aciklama.Size = new System.Drawing.Size(425, 58);
            this.txt_Aciklama.TabIndex = 78;
            // 
            // nmbr_Tutar
            // 
            this.nmbr_Tutar.DecimalPlaces = 6;
            this.nmbr_Tutar.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nmbr_Tutar.Location = new System.Drawing.Point(83, 142);
            this.nmbr_Tutar.Maximum = new decimal(new int[] {
            -1486618625,
            232830643,
            0,
            393216});
            this.nmbr_Tutar.Name = "nmbr_Tutar";
            this.nmbr_Tutar.Size = new System.Drawing.Size(425, 20);
            this.nmbr_Tutar.TabIndex = 77;
            this.nmbr_Tutar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cmb_Kasa
            // 
            this.cmb_Kasa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Kasa.FormattingEnabled = true;
            this.cmb_Kasa.Location = new System.Drawing.Point(83, 61);
            this.cmb_Kasa.Name = "cmb_Kasa";
            this.cmb_Kasa.Size = new System.Drawing.Size(425, 21);
            this.cmb_Kasa.TabIndex = 76;
            // 
            // cmb_Cari
            // 
            this.cmb_Cari.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Cari.FormattingEnabled = true;
            this.cmb_Cari.Location = new System.Drawing.Point(83, 34);
            this.cmb_Cari.Name = "cmb_Cari";
            this.cmb_Cari.Size = new System.Drawing.Size(425, 21);
            this.cmb_Cari.TabIndex = 75;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 89;
            this.label3.Text = "Satış";
            // 
            // cmb_Satis
            // 
            this.cmb_Satis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Satis.FormattingEnabled = true;
            this.cmb_Satis.Location = new System.Drawing.Point(83, 88);
            this.cmb_Satis.Name = "cmb_Satis";
            this.cmb_Satis.Size = new System.Drawing.Size(425, 21);
            this.cmb_Satis.TabIndex = 88;
            // 
            // GelirForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 266);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmb_Satis);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_OdemeTip);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_Kod);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Kaydet);
            this.Controls.Add(this.txt_Aciklama);
            this.Controls.Add(this.nmbr_Tutar);
            this.Controls.Add(this.cmb_Kasa);
            this.Controls.Add(this.cmb_Cari);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(540, 305);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(540, 305);
            this.Name = "GelirForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gelir";
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmbr_Tutar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ErrorProvider error;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmb_Satis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_OdemeTip;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_Kod;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Kaydet;
        private System.Windows.Forms.TextBox txt_Aciklama;
        private System.Windows.Forms.NumericUpDown nmbr_Tutar;
        private System.Windows.Forms.ComboBox cmb_Kasa;
        private System.Windows.Forms.ComboBox cmb_Cari;
    }
}