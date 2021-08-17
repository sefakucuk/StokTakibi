
namespace TarimMuhasebe.WinFormApp.Forms
{
    partial class KullaniciForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KullaniciForm));
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Kaydet = new System.Windows.Forms.Button();
            this.chc_Aktif = new System.Windows.Forms.CheckBox();
            this.txt_Sifre = new System.Windows.Forms.TextBox();
            this.txt_Telefon = new System.Windows.Forms.TextBox();
            this.txt_Eposta = new System.Windows.Forms.TextBox();
            this.txt_Soyad = new System.Windows.Forms.TextBox();
            this.txt_Ad = new System.Windows.Forms.TextBox();
            this.chc_Admin = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            this.SuspendLayout();
            // 
            // error
            // 
            this.error.ContainerControl = this;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 47;
            this.label5.Text = "Şifre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 46;
            this.label4.Text = "Telefon";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 45;
            this.label3.Text = "E-Posta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 44;
            this.label2.Text = "Soyad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 43;
            this.label1.Text = "Ad";
            // 
            // btn_Kaydet
            // 
            this.btn_Kaydet.Location = new System.Drawing.Point(433, 139);
            this.btn_Kaydet.Name = "btn_Kaydet";
            this.btn_Kaydet.Size = new System.Drawing.Size(75, 23);
            this.btn_Kaydet.TabIndex = 42;
            this.btn_Kaydet.Text = "Kaydet";
            this.btn_Kaydet.UseVisualStyleBackColor = true;
            this.btn_Kaydet.Click += new System.EventHandler(this.btn_Kaydet_Click);
            // 
            // chc_Aktif
            // 
            this.chc_Aktif.AutoSize = true;
            this.chc_Aktif.Location = new System.Drawing.Point(93, 143);
            this.chc_Aktif.Name = "chc_Aktif";
            this.chc_Aktif.Size = new System.Drawing.Size(47, 17);
            this.chc_Aktif.TabIndex = 41;
            this.chc_Aktif.Text = "Aktif";
            this.chc_Aktif.UseVisualStyleBackColor = true;
            // 
            // txt_Sifre
            // 
            this.txt_Sifre.Location = new System.Drawing.Point(93, 113);
            this.txt_Sifre.MaxLength = 500;
            this.txt_Sifre.Name = "txt_Sifre";
            this.txt_Sifre.PasswordChar = '*';
            this.txt_Sifre.Size = new System.Drawing.Size(415, 20);
            this.txt_Sifre.TabIndex = 32;
            // 
            // txt_Telefon
            // 
            this.txt_Telefon.Location = new System.Drawing.Point(93, 87);
            this.txt_Telefon.MaxLength = 20;
            this.txt_Telefon.Name = "txt_Telefon";
            this.txt_Telefon.Size = new System.Drawing.Size(415, 20);
            this.txt_Telefon.TabIndex = 31;
            // 
            // txt_Eposta
            // 
            this.txt_Eposta.Location = new System.Drawing.Point(93, 61);
            this.txt_Eposta.MaxLength = 150;
            this.txt_Eposta.Name = "txt_Eposta";
            this.txt_Eposta.Size = new System.Drawing.Size(415, 20);
            this.txt_Eposta.TabIndex = 30;
            // 
            // txt_Soyad
            // 
            this.txt_Soyad.Location = new System.Drawing.Point(93, 35);
            this.txt_Soyad.MaxLength = 50;
            this.txt_Soyad.Name = "txt_Soyad";
            this.txt_Soyad.Size = new System.Drawing.Size(415, 20);
            this.txt_Soyad.TabIndex = 29;
            // 
            // txt_Ad
            // 
            this.txt_Ad.Location = new System.Drawing.Point(93, 9);
            this.txt_Ad.MaxLength = 50;
            this.txt_Ad.Name = "txt_Ad";
            this.txt_Ad.Size = new System.Drawing.Size(415, 20);
            this.txt_Ad.TabIndex = 28;
            // 
            // chc_Admin
            // 
            this.chc_Admin.AutoSize = true;
            this.chc_Admin.Location = new System.Drawing.Point(146, 143);
            this.chc_Admin.Name = "chc_Admin";
            this.chc_Admin.Size = new System.Drawing.Size(64, 17);
            this.chc_Admin.TabIndex = 48;
            this.chc_Admin.Text = "Yönetici";
            this.chc_Admin.UseVisualStyleBackColor = true;
            // 
            // KullaniciForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 169);
            this.Controls.Add(this.chc_Admin);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Kaydet);
            this.Controls.Add(this.chc_Aktif);
            this.Controls.Add(this.txt_Sifre);
            this.Controls.Add(this.txt_Telefon);
            this.Controls.Add(this.txt_Eposta);
            this.Controls.Add(this.txt_Soyad);
            this.Controls.Add(this.txt_Ad);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(540, 208);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(540, 208);
            this.Name = "KullaniciForm";
            this.Text = "Kullanici";
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ErrorProvider error;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Kaydet;
        private System.Windows.Forms.CheckBox chc_Aktif;
        private System.Windows.Forms.TextBox txt_Sifre;
        private System.Windows.Forms.TextBox txt_Telefon;
        private System.Windows.Forms.TextBox txt_Eposta;
        private System.Windows.Forms.TextBox txt_Soyad;
        private System.Windows.Forms.TextBox txt_Ad;
        private System.Windows.Forms.CheckBox chc_Admin;
    }
}