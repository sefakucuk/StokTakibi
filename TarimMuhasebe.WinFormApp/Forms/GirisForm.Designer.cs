
namespace TarimMuhasebe.WinFormApp.Forms
{
    partial class GirisForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GirisForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Giris = new System.Windows.Forms.Button();
            this.txt_Sifre = new System.Windows.Forms.TextBox();
            this.txt_EpostaTelefon = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            this.btn_ProgramBilgileri = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(366, 96);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(3, 277);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(363, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "2021 - TeknoSivas";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_Giris
            // 
            this.btn_Giris.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Giris.Image = ((System.Drawing.Image)(resources.GetObject("btn_Giris.Image")));
            this.btn_Giris.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Giris.Location = new System.Drawing.Point(186, 200);
            this.btn_Giris.Name = "btn_Giris";
            this.btn_Giris.Size = new System.Drawing.Size(162, 74);
            this.btn_Giris.TabIndex = 9;
            this.btn_Giris.Text = "Sisteme Giriş";
            this.btn_Giris.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Giris.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Giris.UseVisualStyleBackColor = true;
            this.btn_Giris.Click += new System.EventHandler(this.btn_Giris_Click);
            // 
            // txt_Sifre
            // 
            this.txt_Sifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_Sifre.Location = new System.Drawing.Point(7, 170);
            this.txt_Sifre.MaxLength = 500;
            this.txt_Sifre.Name = "txt_Sifre";
            this.txt_Sifre.PasswordChar = '*';
            this.txt_Sifre.Size = new System.Drawing.Size(342, 24);
            this.txt_Sifre.TabIndex = 8;
            // 
            // txt_EpostaTelefon
            // 
            this.txt_EpostaTelefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_EpostaTelefon.Location = new System.Drawing.Point(6, 122);
            this.txt_EpostaTelefon.MaxLength = 150;
            this.txt_EpostaTelefon.Name = "txt_EpostaTelefon";
            this.txt_EpostaTelefon.Size = new System.Drawing.Size(342, 24);
            this.txt_EpostaTelefon.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(3, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Şifre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(4, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "E-Posta veya Telefon";
            // 
            // error
            // 
            this.error.ContainerControl = this;
            // 
            // btn_ProgramBilgileri
            // 
            this.btn_ProgramBilgileri.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_ProgramBilgileri.Image = ((System.Drawing.Image)(resources.GetObject("btn_ProgramBilgileri.Image")));
            this.btn_ProgramBilgileri.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ProgramBilgileri.Location = new System.Drawing.Point(7, 200);
            this.btn_ProgramBilgileri.Name = "btn_ProgramBilgileri";
            this.btn_ProgramBilgileri.Size = new System.Drawing.Size(162, 74);
            this.btn_ProgramBilgileri.TabIndex = 10;
            this.btn_ProgramBilgileri.Text = "Program Bilgileri";
            this.btn_ProgramBilgileri.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_ProgramBilgileri.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_ProgramBilgileri.UseVisualStyleBackColor = true;
            this.btn_ProgramBilgileri.Click += new System.EventHandler(this.btn_ProgramBilgileri_Click);
            // 
            // GirisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 301);
            this.Controls.Add(this.btn_ProgramBilgileri);
            this.Controls.Add(this.btn_Giris);
            this.Controls.Add(this.txt_Sifre);
            this.Controls.Add(this.txt_EpostaTelefon);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(382, 340);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(382, 340);
            this.Name = "GirisForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giriş";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Giris;
        private System.Windows.Forms.TextBox txt_Sifre;
        private System.Windows.Forms.TextBox txt_EpostaTelefon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider error;
        private System.Windows.Forms.Button btn_ProgramBilgileri;
    }
}