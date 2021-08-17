
namespace TarimMuhasebe.WinFormApp.Forms
{
    partial class SifreGuncellemeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SifreGuncellemeForm));
            this.txt_MevcutSifre = new System.Windows.Forms.TextBox();
            this.txt_YeniSifre = new System.Windows.Forms.TextBox();
            this.txt_YeniSifreTekrar = new System.Windows.Forms.TextBox();
            this.btn_Kaydet = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_MevcutSifre
            // 
            this.txt_MevcutSifre.Location = new System.Drawing.Point(110, 12);
            this.txt_MevcutSifre.Name = "txt_MevcutSifre";
            this.txt_MevcutSifre.PasswordChar = '*';
            this.txt_MevcutSifre.Size = new System.Drawing.Size(233, 20);
            this.txt_MevcutSifre.TabIndex = 0;
            // 
            // txt_YeniSifre
            // 
            this.txt_YeniSifre.Location = new System.Drawing.Point(110, 38);
            this.txt_YeniSifre.Name = "txt_YeniSifre";
            this.txt_YeniSifre.PasswordChar = '*';
            this.txt_YeniSifre.Size = new System.Drawing.Size(233, 20);
            this.txt_YeniSifre.TabIndex = 1;
            // 
            // txt_YeniSifreTekrar
            // 
            this.txt_YeniSifreTekrar.Location = new System.Drawing.Point(110, 64);
            this.txt_YeniSifreTekrar.Name = "txt_YeniSifreTekrar";
            this.txt_YeniSifreTekrar.PasswordChar = '*';
            this.txt_YeniSifreTekrar.Size = new System.Drawing.Size(233, 20);
            this.txt_YeniSifreTekrar.TabIndex = 2;
            // 
            // btn_Kaydet
            // 
            this.btn_Kaydet.Location = new System.Drawing.Point(268, 90);
            this.btn_Kaydet.Name = "btn_Kaydet";
            this.btn_Kaydet.Size = new System.Drawing.Size(75, 23);
            this.btn_Kaydet.TabIndex = 3;
            this.btn_Kaydet.Text = "Kaydet";
            this.btn_Kaydet.UseVisualStyleBackColor = true;
            this.btn_Kaydet.Click += new System.EventHandler(this.btn_Kaydet_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Mevcut Şifre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Yeni Şifre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Yeni Şifre (Tekrar)";
            // 
            // error
            // 
            this.error.ContainerControl = this;
            // 
            // SifreGuncellemeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 122);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Kaydet);
            this.Controls.Add(this.txt_YeniSifreTekrar);
            this.Controls.Add(this.txt_YeniSifre);
            this.Controls.Add(this.txt_MevcutSifre);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(382, 161);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(382, 161);
            this.Name = "SifreGuncellemeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Şifre Güncelle";
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_MevcutSifre;
        private System.Windows.Forms.TextBox txt_YeniSifre;
        private System.Windows.Forms.TextBox txt_YeniSifreTekrar;
        private System.Windows.Forms.Button btn_Kaydet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ErrorProvider error;
    }
}