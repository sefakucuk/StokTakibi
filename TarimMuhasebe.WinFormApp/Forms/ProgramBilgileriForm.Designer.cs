
namespace TarimMuhasebe.WinFormApp.Forms
{
    partial class ProgramBilgileriForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProgramBilgileriForm));
            this.txt_Ad = new System.Windows.Forms.TextBox();
            this.txt_VergiNo = new System.Windows.Forms.TextBox();
            this.txt_Adres = new System.Windows.Forms.TextBox();
            this.pic_Logo = new System.Windows.Forms.PictureBox();
            this.txt_Server = new System.Windows.Forms.TextBox();
            this.txt_Kullanici = new System.Windows.Forms.TextBox();
            this.txt_Database = new System.Windows.Forms.TextBox();
            this.btn_Logo = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_Sifre = new System.Windows.Forms.TextBox();
            this.nmbr_Port = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_Kaydet = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            this.txt_YedekYol = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_YedekYol = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Logo)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmbr_Port)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_Ad
            // 
            this.txt_Ad.Location = new System.Drawing.Point(94, 12);
            this.txt_Ad.Name = "txt_Ad";
            this.txt_Ad.Size = new System.Drawing.Size(263, 20);
            this.txt_Ad.TabIndex = 0;
            // 
            // txt_VergiNo
            // 
            this.txt_VergiNo.Location = new System.Drawing.Point(94, 38);
            this.txt_VergiNo.Name = "txt_VergiNo";
            this.txt_VergiNo.Size = new System.Drawing.Size(263, 20);
            this.txt_VergiNo.TabIndex = 1;
            // 
            // txt_Adres
            // 
            this.txt_Adres.Location = new System.Drawing.Point(94, 64);
            this.txt_Adres.Multiline = true;
            this.txt_Adres.Name = "txt_Adres";
            this.txt_Adres.Size = new System.Drawing.Size(263, 55);
            this.txt_Adres.TabIndex = 2;
            // 
            // pic_Logo
            // 
            this.pic_Logo.Location = new System.Drawing.Point(94, 125);
            this.pic_Logo.Name = "pic_Logo";
            this.pic_Logo.Size = new System.Drawing.Size(263, 156);
            this.pic_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_Logo.TabIndex = 3;
            this.pic_Logo.TabStop = false;
            // 
            // txt_Server
            // 
            this.txt_Server.Location = new System.Drawing.Point(92, 15);
            this.txt_Server.Name = "txt_Server";
            this.txt_Server.Size = new System.Drawing.Size(262, 20);
            this.txt_Server.TabIndex = 4;
            // 
            // txt_Kullanici
            // 
            this.txt_Kullanici.Location = new System.Drawing.Point(92, 93);
            this.txt_Kullanici.Name = "txt_Kullanici";
            this.txt_Kullanici.Size = new System.Drawing.Size(262, 20);
            this.txt_Kullanici.TabIndex = 7;
            // 
            // txt_Database
            // 
            this.txt_Database.Location = new System.Drawing.Point(92, 67);
            this.txt_Database.Name = "txt_Database";
            this.txt_Database.Size = new System.Drawing.Size(262, 20);
            this.txt_Database.TabIndex = 6;
            // 
            // btn_Logo
            // 
            this.btn_Logo.Location = new System.Drawing.Point(15, 125);
            this.btn_Logo.Name = "btn_Logo";
            this.btn_Logo.Size = new System.Drawing.Size(72, 156);
            this.btn_Logo.TabIndex = 3;
            this.btn_Logo.Text = "Logo Seç";
            this.btn_Logo.UseVisualStyleBackColor = true;
            this.btn_Logo.Click += new System.EventHandler(this.btn_Logo_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txt_Sifre);
            this.groupBox1.Controls.Add(this.nmbr_Port);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_Server);
            this.groupBox1.Controls.Add(this.txt_Database);
            this.groupBox1.Controls.Add(this.txt_Kullanici);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(-3, 342);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(360, 152);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Database";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 122);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Şifre";
            // 
            // txt_Sifre
            // 
            this.txt_Sifre.Location = new System.Drawing.Point(91, 119);
            this.txt_Sifre.Name = "txt_Sifre";
            this.txt_Sifre.PasswordChar = '*';
            this.txt_Sifre.Size = new System.Drawing.Size(262, 20);
            this.txt_Sifre.TabIndex = 8;
            // 
            // nmbr_Port
            // 
            this.nmbr_Port.Location = new System.Drawing.Point(92, 41);
            this.nmbr_Port.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nmbr_Port.Name = "nmbr_Port";
            this.nmbr_Port.Size = new System.Drawing.Size(262, 20);
            this.nmbr_Port.TabIndex = 5;
            this.nmbr_Port.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nmbr_Port.Value = new decimal(new int[] {
            3306,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 96);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Kullanıcı";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Database";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Port";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Server";
            // 
            // btn_Kaydet
            // 
            this.btn_Kaydet.Location = new System.Drawing.Point(282, 500);
            this.btn_Kaydet.Name = "btn_Kaydet";
            this.btn_Kaydet.Size = new System.Drawing.Size(75, 23);
            this.btn_Kaydet.TabIndex = 9;
            this.btn_Kaydet.Text = "Kaydet";
            this.btn_Kaydet.UseVisualStyleBackColor = true;
            this.btn_Kaydet.Click += new System.EventHandler(this.btn_Kaydet_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Firma Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Vergi No";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Adres";
            // 
            // error
            // 
            this.error.ContainerControl = this;
            // 
            // txt_YedekYol
            // 
            this.txt_YedekYol.Location = new System.Drawing.Point(94, 287);
            this.txt_YedekYol.Name = "txt_YedekYol";
            this.txt_YedekYol.Size = new System.Drawing.Size(263, 20);
            this.txt_YedekYol.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 290);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Yedek  Yolu";
            // 
            // btn_YedekYol
            // 
            this.btn_YedekYol.Location = new System.Drawing.Point(94, 313);
            this.btn_YedekYol.Name = "btn_YedekYol";
            this.btn_YedekYol.Size = new System.Drawing.Size(263, 23);
            this.btn_YedekYol.TabIndex = 17;
            this.btn_YedekYol.Text = "Yol Seç";
            this.btn_YedekYol.UseVisualStyleBackColor = true;
            this.btn_YedekYol.Click += new System.EventHandler(this.btn_YedekYol_Click);
            // 
            // ProgramBilgileriForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 531);
            this.Controls.Add(this.btn_YedekYol);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_YedekYol);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Kaydet);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_Logo);
            this.Controls.Add(this.pic_Logo);
            this.Controls.Add(this.txt_Adres);
            this.Controls.Add(this.txt_VergiNo);
            this.Controls.Add(this.txt_Ad);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(382, 570);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(382, 570);
            this.Name = "ProgramBilgileriForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Program Bilgileri";
            ((System.ComponentModel.ISupportInitialize)(this.pic_Logo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmbr_Port)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Ad;
        private System.Windows.Forms.TextBox txt_VergiNo;
        private System.Windows.Forms.TextBox txt_Adres;
        private System.Windows.Forms.PictureBox pic_Logo;
        private System.Windows.Forms.TextBox txt_Server;
        private System.Windows.Forms.TextBox txt_Kullanici;
        private System.Windows.Forms.TextBox txt_Database;
        private System.Windows.Forms.Button btn_Logo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_Kaydet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nmbr_Port;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_Sifre;
        private System.Windows.Forms.ErrorProvider error;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_YedekYol;
        private System.Windows.Forms.Button btn_YedekYol;
    }
}