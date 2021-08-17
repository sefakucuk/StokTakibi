
namespace TarimMuhasebe.WinFormApp.UserControls
{
    partial class AnasayfaKasaUC
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
            this.grp_Kasa = new System.Windows.Forms.GroupBox();
            this.lbl_GuncelTutar = new System.Windows.Forms.Label();
            this.lbl_AcilisTutar = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grp_Kasa.SuspendLayout();
            this.SuspendLayout();
            // 
            // grp_Kasa
            // 
            this.grp_Kasa.BackColor = System.Drawing.Color.Transparent;
            this.grp_Kasa.Controls.Add(this.lbl_GuncelTutar);
            this.grp_Kasa.Controls.Add(this.lbl_AcilisTutar);
            this.grp_Kasa.Controls.Add(this.label2);
            this.grp_Kasa.Controls.Add(this.label1);
            this.grp_Kasa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grp_Kasa.Location = new System.Drawing.Point(3, 3);
            this.grp_Kasa.Name = "grp_Kasa";
            this.grp_Kasa.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.grp_Kasa.Size = new System.Drawing.Size(200, 100);
            this.grp_Kasa.TabIndex = 2;
            this.grp_Kasa.TabStop = false;
            this.grp_Kasa.Text = "Kasa Adı";
            // 
            // lbl_GuncelTutar
            // 
            this.lbl_GuncelTutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_GuncelTutar.Location = new System.Drawing.Point(49, 62);
            this.lbl_GuncelTutar.Name = "lbl_GuncelTutar";
            this.lbl_GuncelTutar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_GuncelTutar.Size = new System.Drawing.Size(145, 13);
            this.lbl_GuncelTutar.TabIndex = 4;
            this.lbl_GuncelTutar.Text = "0.00 ₺";
            this.lbl_GuncelTutar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_AcilisTutar
            // 
            this.lbl_AcilisTutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_AcilisTutar.Location = new System.Drawing.Point(49, 34);
            this.lbl_AcilisTutar.Name = "lbl_AcilisTutar";
            this.lbl_AcilisTutar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_AcilisTutar.Size = new System.Drawing.Size(145, 13);
            this.lbl_AcilisTutar.TabIndex = 3;
            this.lbl_AcilisTutar.Text = "0.00 ₺";
            this.lbl_AcilisTutar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(6, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Güncel";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(6, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Açılış";
            // 
            // AnasayfaKasaUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.grp_Kasa);
            this.Name = "AnasayfaKasaUC";
            this.Size = new System.Drawing.Size(205, 107);
            this.grp_Kasa.ResumeLayout(false);
            this.grp_Kasa.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grp_Kasa;
        private System.Windows.Forms.Label lbl_AcilisTutar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_GuncelTutar;
        private System.Windows.Forms.Label label2;
    }
}
