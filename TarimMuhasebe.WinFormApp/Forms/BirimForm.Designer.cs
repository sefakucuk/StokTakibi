
namespace TarimMuhasebe.WinFormApp.Forms
{
    partial class BirimForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BirimForm));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lst_Data = new System.Windows.Forms.ListBox();
            this.btn_Kaldir = new System.Windows.Forms.Button();
            this.btn_Temizle = new System.Windows.Forms.Button();
            this.btn_Kaydet = new System.Windows.Forms.Button();
            this.txt_Gosterim = new System.Windows.Forms.TextBox();
            this.txt_Ad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lst_Data);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.btn_Kaldir);
            this.splitContainer1.Panel2.Controls.Add(this.btn_Temizle);
            this.splitContainer1.Panel2.Controls.Add(this.btn_Kaydet);
            this.splitContainer1.Panel2.Controls.Add(this.txt_Gosterim);
            this.splitContainer1.Panel2.Controls.Add(this.txt_Ad);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Size = new System.Drawing.Size(623, 450);
            this.splitContainer1.SplitterDistance = 245;
            this.splitContainer1.TabIndex = 0;
            // 
            // lst_Data
            // 
            this.lst_Data.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lst_Data.FormattingEnabled = true;
            this.lst_Data.Location = new System.Drawing.Point(0, 0);
            this.lst_Data.Name = "lst_Data";
            this.lst_Data.Size = new System.Drawing.Size(245, 450);
            this.lst_Data.TabIndex = 0;
            this.lst_Data.SelectedValueChanged += new System.EventHandler(this.lst_Data_SelectedValueChanged);
            // 
            // btn_Kaldir
            // 
            this.btn_Kaldir.Location = new System.Drawing.Point(125, 64);
            this.btn_Kaldir.Name = "btn_Kaldir";
            this.btn_Kaldir.Size = new System.Drawing.Size(75, 23);
            this.btn_Kaldir.TabIndex = 6;
            this.btn_Kaldir.Text = "Kaldır";
            this.btn_Kaldir.UseVisualStyleBackColor = true;
            this.btn_Kaldir.Click += new System.EventHandler(this.btn_Kaldir_Click);
            // 
            // btn_Temizle
            // 
            this.btn_Temizle.Location = new System.Drawing.Point(206, 64);
            this.btn_Temizle.Name = "btn_Temizle";
            this.btn_Temizle.Size = new System.Drawing.Size(75, 23);
            this.btn_Temizle.TabIndex = 5;
            this.btn_Temizle.Text = "Temizle";
            this.btn_Temizle.UseVisualStyleBackColor = true;
            this.btn_Temizle.Click += new System.EventHandler(this.btn_Temizle_Click);
            // 
            // btn_Kaydet
            // 
            this.btn_Kaydet.Location = new System.Drawing.Point(287, 64);
            this.btn_Kaydet.Name = "btn_Kaydet";
            this.btn_Kaydet.Size = new System.Drawing.Size(75, 23);
            this.btn_Kaydet.TabIndex = 4;
            this.btn_Kaydet.Text = "Kaydet";
            this.btn_Kaydet.UseVisualStyleBackColor = true;
            this.btn_Kaydet.Click += new System.EventHandler(this.btn_Kaydet_Click);
            // 
            // txt_Gosterim
            // 
            this.txt_Gosterim.Location = new System.Drawing.Point(63, 38);
            this.txt_Gosterim.MaxLength = 20;
            this.txt_Gosterim.Name = "txt_Gosterim";
            this.txt_Gosterim.Size = new System.Drawing.Size(299, 20);
            this.txt_Gosterim.TabIndex = 3;
            // 
            // txt_Ad
            // 
            this.txt_Ad.Location = new System.Drawing.Point(63, 12);
            this.txt_Ad.MaxLength = 150;
            this.txt_Ad.Name = "txt_Ad";
            this.txt_Ad.Size = new System.Drawing.Size(299, 20);
            this.txt_Ad.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Gösterim";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad";
            // 
            // error
            // 
            this.error.ContainerControl = this;
            // 
            // BirimForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 450);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(639, 489);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(639, 489);
            this.Name = "BirimForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Birimler";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListBox lst_Data;
        private System.Windows.Forms.TextBox txt_Gosterim;
        private System.Windows.Forms.TextBox txt_Ad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Kaydet;
        private System.Windows.Forms.Button btn_Temizle;
        private System.Windows.Forms.ErrorProvider error;
        private System.Windows.Forms.Button btn_Kaldir;
    }
}