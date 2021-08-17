
namespace TarimMuhasebe.WinFormApp.UserControls
{
    partial class SatisDetayUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SatisDetayUC));
            this.pnl_Main = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.nmr_KdvOrani = new System.Windows.Forms.NumericUpDown();
            this.lbl_Toplam = new System.Windows.Forms.Label();
            this.pic_Kaldir = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_Kdv = new System.Windows.Forms.Label();
            this.lbl_Matrah = new System.Windows.Forms.Label();
            this.txt_Aciklama = new System.Windows.Forms.TextBox();
            this.nmbr_BirimFiyat = new System.Windows.Forms.NumericUpDown();
            this.nmbr_Miktar = new System.Windows.Forms.NumericUpDown();
            this.cmb_Depo = new System.Windows.Forms.ComboBox();
            this.cmb_Urun = new System.Windows.Forms.ComboBox();
            this.pnl_Main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmr_KdvOrani)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Kaldir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmbr_BirimFiyat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmbr_Miktar)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_Main
            // 
            this.pnl_Main.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_Main.Controls.Add(this.label1);
            this.pnl_Main.Controls.Add(this.nmr_KdvOrani);
            this.pnl_Main.Controls.Add(this.lbl_Toplam);
            this.pnl_Main.Controls.Add(this.pic_Kaldir);
            this.pnl_Main.Controls.Add(this.label7);
            this.pnl_Main.Controls.Add(this.label6);
            this.pnl_Main.Controls.Add(this.label5);
            this.pnl_Main.Controls.Add(this.label4);
            this.pnl_Main.Controls.Add(this.label3);
            this.pnl_Main.Controls.Add(this.lbl_Kdv);
            this.pnl_Main.Controls.Add(this.lbl_Matrah);
            this.pnl_Main.Controls.Add(this.txt_Aciklama);
            this.pnl_Main.Controls.Add(this.nmbr_BirimFiyat);
            this.pnl_Main.Controls.Add(this.nmbr_Miktar);
            this.pnl_Main.Controls.Add(this.cmb_Depo);
            this.pnl_Main.Controls.Add(this.cmb_Urun);
            this.pnl_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Main.Location = new System.Drawing.Point(0, 0);
            this.pnl_Main.Name = "pnl_Main";
            this.pnl_Main.Size = new System.Drawing.Size(359, 289);
            this.pnl_Main.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Kdv Oranı";
            // 
            // nmr_KdvOrani
            // 
            this.nmr_KdvOrani.DecimalPlaces = 2;
            this.nmr_KdvOrani.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nmr_KdvOrani.Location = new System.Drawing.Point(66, 92);
            this.nmr_KdvOrani.Name = "nmr_KdvOrani";
            this.nmr_KdvOrani.Size = new System.Drawing.Size(273, 20);
            this.nmr_KdvOrani.TabIndex = 14;
            this.nmr_KdvOrani.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nmr_KdvOrani.ValueChanged += new System.EventHandler(this.Hesap_ValueChanged);
            // 
            // lbl_Toplam
            // 
            this.lbl_Toplam.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Toplam.Location = new System.Drawing.Point(21, 262);
            this.lbl_Toplam.Name = "lbl_Toplam";
            this.lbl_Toplam.Size = new System.Drawing.Size(316, 23);
            this.lbl_Toplam.TabIndex = 13;
            this.lbl_Toplam.Text = "Toplam : 0.00 ₺";
            this.lbl_Toplam.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pic_Kaldir
            // 
            this.pic_Kaldir.Image = ((System.Drawing.Image)(resources.GetObject("pic_Kaldir.Image")));
            this.pic_Kaldir.Location = new System.Drawing.Point(306, 3);
            this.pic_Kaldir.Name = "pic_Kaldir";
            this.pic_Kaldir.Size = new System.Drawing.Size(33, 29);
            this.pic_Kaldir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_Kaldir.TabIndex = 12;
            this.pic_Kaldir.TabStop = false;
            this.pic_Kaldir.Click += new System.EventHandler(this.pic_Kaldir_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 173);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Açıklama";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Miktar";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Birim Fiyat";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Depo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Ürün";
            // 
            // lbl_Kdv
            // 
            this.lbl_Kdv.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Kdv.Location = new System.Drawing.Point(21, 239);
            this.lbl_Kdv.Name = "lbl_Kdv";
            this.lbl_Kdv.Size = new System.Drawing.Size(316, 23);
            this.lbl_Kdv.TabIndex = 6;
            this.lbl_Kdv.Text = "Kdv : 0.00 ₺";
            this.lbl_Kdv.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_Matrah
            // 
            this.lbl_Matrah.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Matrah.Location = new System.Drawing.Point(21, 216);
            this.lbl_Matrah.Name = "lbl_Matrah";
            this.lbl_Matrah.Size = new System.Drawing.Size(316, 23);
            this.lbl_Matrah.TabIndex = 5;
            this.lbl_Matrah.Text = "Matrah : 0.00 ₺";
            this.lbl_Matrah.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_Aciklama
            // 
            this.txt_Aciklama.Location = new System.Drawing.Point(64, 170);
            this.txt_Aciklama.MaxLength = 500;
            this.txt_Aciklama.Multiline = true;
            this.txt_Aciklama.Name = "txt_Aciklama";
            this.txt_Aciklama.Size = new System.Drawing.Size(273, 42);
            this.txt_Aciklama.TabIndex = 4;
            // 
            // nmbr_BirimFiyat
            // 
            this.nmbr_BirimFiyat.DecimalPlaces = 6;
            this.nmbr_BirimFiyat.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nmbr_BirimFiyat.Location = new System.Drawing.Point(64, 144);
            this.nmbr_BirimFiyat.Maximum = new decimal(new int[] {
            -1486618625,
            232830643,
            0,
            393216});
            this.nmbr_BirimFiyat.Name = "nmbr_BirimFiyat";
            this.nmbr_BirimFiyat.Size = new System.Drawing.Size(273, 20);
            this.nmbr_BirimFiyat.TabIndex = 3;
            this.nmbr_BirimFiyat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nmbr_BirimFiyat.ValueChanged += new System.EventHandler(this.Hesap_ValueChanged);
            // 
            // nmbr_Miktar
            // 
            this.nmbr_Miktar.DecimalPlaces = 6;
            this.nmbr_Miktar.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nmbr_Miktar.Location = new System.Drawing.Point(65, 118);
            this.nmbr_Miktar.Maximum = new decimal(new int[] {
            -1486618625,
            232830643,
            0,
            393216});
            this.nmbr_Miktar.Name = "nmbr_Miktar";
            this.nmbr_Miktar.Size = new System.Drawing.Size(273, 20);
            this.nmbr_Miktar.TabIndex = 2;
            this.nmbr_Miktar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nmbr_Miktar.ValueChanged += new System.EventHandler(this.Hesap_ValueChanged);
            // 
            // cmb_Depo
            // 
            this.cmb_Depo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Depo.FormattingEnabled = true;
            this.cmb_Depo.Location = new System.Drawing.Point(66, 65);
            this.cmb_Depo.Name = "cmb_Depo";
            this.cmb_Depo.Size = new System.Drawing.Size(272, 21);
            this.cmb_Depo.TabIndex = 1;
            this.cmb_Depo.SelectedValueChanged += new System.EventHandler(this.cmb_Depo_SelectedValueChanged);
            // 
            // cmb_Urun
            // 
            this.cmb_Urun.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Urun.FormattingEnabled = true;
            this.cmb_Urun.Location = new System.Drawing.Point(66, 38);
            this.cmb_Urun.Name = "cmb_Urun";
            this.cmb_Urun.Size = new System.Drawing.Size(272, 21);
            this.cmb_Urun.TabIndex = 0;
            this.cmb_Urun.SelectedValueChanged += new System.EventHandler(this.cmb_Urun_SelectedValueChanged);
            // 
            // SatisDetayUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnl_Main);
            this.Name = "SatisDetayUC";
            this.Size = new System.Drawing.Size(359, 289);
            this.pnl_Main.ResumeLayout(false);
            this.pnl_Main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmr_KdvOrani)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Kaldir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmbr_BirimFiyat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmbr_Miktar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Main;
        private System.Windows.Forms.Label lbl_Kdv;
        private System.Windows.Forms.Label lbl_Matrah;
        private System.Windows.Forms.TextBox txt_Aciklama;
        private System.Windows.Forms.NumericUpDown nmbr_BirimFiyat;
        private System.Windows.Forms.NumericUpDown nmbr_Miktar;
        private System.Windows.Forms.ComboBox cmb_Depo;
        private System.Windows.Forms.ComboBox cmb_Urun;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pic_Kaldir;
        private System.Windows.Forms.Label lbl_Toplam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nmr_KdvOrani;
    }
}
