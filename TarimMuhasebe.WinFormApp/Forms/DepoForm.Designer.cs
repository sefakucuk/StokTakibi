
namespace TarimMuhasebe.WinFormApp.Forms
{
    partial class DepoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DepoForm));
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Aciklama = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Ad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Kod = new System.Windows.Forms.TextBox();
            this.btn_Kaydet = new System.Windows.Forms.Button();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 40;
            this.label3.Text = "Açıklama";
            // 
            // txt_Aciklama
            // 
            this.txt_Aciklama.Location = new System.Drawing.Point(86, 58);
            this.txt_Aciklama.MaxLength = 500;
            this.txt_Aciklama.Multiline = true;
            this.txt_Aciklama.Name = "txt_Aciklama";
            this.txt_Aciklama.Size = new System.Drawing.Size(415, 49);
            this.txt_Aciklama.TabIndex = 39;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 38;
            this.label2.Text = "Ad";
            // 
            // txt_Ad
            // 
            this.txt_Ad.Location = new System.Drawing.Point(86, 32);
            this.txt_Ad.MaxLength = 150;
            this.txt_Ad.Name = "txt_Ad";
            this.txt_Ad.Size = new System.Drawing.Size(415, 20);
            this.txt_Ad.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 36;
            this.label1.Text = "Kod";
            // 
            // txt_Kod
            // 
            this.txt_Kod.Location = new System.Drawing.Point(86, 6);
            this.txt_Kod.MaxLength = 20;
            this.txt_Kod.Name = "txt_Kod";
            this.txt_Kod.Size = new System.Drawing.Size(415, 20);
            this.txt_Kod.TabIndex = 35;
            // 
            // btn_Kaydet
            // 
            this.btn_Kaydet.Location = new System.Drawing.Point(426, 113);
            this.btn_Kaydet.Name = "btn_Kaydet";
            this.btn_Kaydet.Size = new System.Drawing.Size(75, 23);
            this.btn_Kaydet.TabIndex = 41;
            this.btn_Kaydet.Text = "Kaydet";
            this.btn_Kaydet.UseVisualStyleBackColor = true;
            this.btn_Kaydet.Click += new System.EventHandler(this.btn_Kaydet_Click);
            // 
            // error
            // 
            this.error.ContainerControl = this;
            // 
            // DepoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 143);
            this.Controls.Add(this.btn_Kaydet);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_Aciklama);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Ad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Kod);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(540, 182);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(540, 182);
            this.Name = "DepoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Depo";
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Aciklama;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Ad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Kod;
        private System.Windows.Forms.Button btn_Kaydet;
        private System.Windows.Forms.ErrorProvider error;
    }
}