
namespace TarimMuhasebe.WinFormApp.Forms
{
    partial class TransferForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TransferForm));
            this.cmb_CikisDepo = new System.Windows.Forms.ComboBox();
            this.cmb_Urun = new System.Windows.Forms.ComboBox();
            this.nmbr_Miktar = new System.Windows.Forms.NumericUpDown();
            this.cmb_GirisDepo = new System.Windows.Forms.ComboBox();
            this.btn_Kaydet = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nmbr_Miktar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            this.SuspendLayout();
            // 
            // cmb_CikisDepo
            // 
            this.cmb_CikisDepo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_CikisDepo.FormattingEnabled = true;
            this.cmb_CikisDepo.Location = new System.Drawing.Point(87, 6);
            this.cmb_CikisDepo.Name = "cmb_CikisDepo";
            this.cmb_CikisDepo.Size = new System.Drawing.Size(415, 21);
            this.cmb_CikisDepo.TabIndex = 78;
            // 
            // cmb_Urun
            // 
            this.cmb_Urun.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Urun.FormattingEnabled = true;
            this.cmb_Urun.Location = new System.Drawing.Point(87, 33);
            this.cmb_Urun.Name = "cmb_Urun";
            this.cmb_Urun.Size = new System.Drawing.Size(415, 21);
            this.cmb_Urun.TabIndex = 79;
            // 
            // nmbr_Miktar
            // 
            this.nmbr_Miktar.DecimalPlaces = 6;
            this.nmbr_Miktar.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nmbr_Miktar.Location = new System.Drawing.Point(87, 60);
            this.nmbr_Miktar.Maximum = new decimal(new int[] {
            268435456,
            1042612833,
            542101086,
            131072});
            this.nmbr_Miktar.Name = "nmbr_Miktar";
            this.nmbr_Miktar.Size = new System.Drawing.Size(415, 20);
            this.nmbr_Miktar.TabIndex = 80;
            this.nmbr_Miktar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cmb_GirisDepo
            // 
            this.cmb_GirisDepo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_GirisDepo.FormattingEnabled = true;
            this.cmb_GirisDepo.Location = new System.Drawing.Point(87, 86);
            this.cmb_GirisDepo.Name = "cmb_GirisDepo";
            this.cmb_GirisDepo.Size = new System.Drawing.Size(415, 21);
            this.cmb_GirisDepo.TabIndex = 81;
            // 
            // btn_Kaydet
            // 
            this.btn_Kaydet.Location = new System.Drawing.Point(427, 119);
            this.btn_Kaydet.Name = "btn_Kaydet";
            this.btn_Kaydet.Size = new System.Drawing.Size(75, 23);
            this.btn_Kaydet.TabIndex = 82;
            this.btn_Kaydet.Text = "Kaydet";
            this.btn_Kaydet.UseVisualStyleBackColor = true;
            this.btn_Kaydet.Click += new System.EventHandler(this.btn_Kaydet_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 83;
            this.label1.Text = "Çıkış Depo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 84;
            this.label2.Text = "Ürün";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 85;
            this.label3.Text = "Miktar";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 86;
            this.label4.Text = "Giriş Depo";
            // 
            // error
            // 
            this.error.ContainerControl = this;
            // 
            // TransferForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 154);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Kaydet);
            this.Controls.Add(this.cmb_GirisDepo);
            this.Controls.Add(this.nmbr_Miktar);
            this.Controls.Add(this.cmb_Urun);
            this.Controls.Add(this.cmb_CikisDepo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TransferForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stok Transfer";
            ((System.ComponentModel.ISupportInitialize)(this.nmbr_Miktar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_CikisDepo;
        private System.Windows.Forms.ComboBox cmb_Urun;
        private System.Windows.Forms.NumericUpDown nmbr_Miktar;
        private System.Windows.Forms.ComboBox cmb_GirisDepo;
        private System.Windows.Forms.Button btn_Kaydet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ErrorProvider error;
    }
}