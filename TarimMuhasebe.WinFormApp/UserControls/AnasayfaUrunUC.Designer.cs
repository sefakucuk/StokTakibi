
namespace TarimMuhasebe.WinFormApp.UserControls
{
    partial class AnasayfaUrunUC
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
            this.grp_Urun = new System.Windows.Forms.GroupBox();
            this.lbl_Stok = new System.Windows.Forms.Label();
            this.lbl_SatisFiyat = new System.Windows.Forms.Label();
            this.lbl_AlisFiyat = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grp_Urun.SuspendLayout();
            this.SuspendLayout();
            // 
            // grp_Urun
            // 
            this.grp_Urun.BackColor = System.Drawing.Color.Transparent;
            this.grp_Urun.Controls.Add(this.lbl_Stok);
            this.grp_Urun.Controls.Add(this.lbl_SatisFiyat);
            this.grp_Urun.Controls.Add(this.lbl_AlisFiyat);
            this.grp_Urun.Controls.Add(this.label3);
            this.grp_Urun.Controls.Add(this.label2);
            this.grp_Urun.Controls.Add(this.label1);
            this.grp_Urun.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grp_Urun.Location = new System.Drawing.Point(3, 3);
            this.grp_Urun.Name = "grp_Urun";
            this.grp_Urun.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.grp_Urun.Size = new System.Drawing.Size(200, 100);
            this.grp_Urun.TabIndex = 1;
            this.grp_Urun.TabStop = false;
            this.grp_Urun.Text = "Ürün Adı";
            // 
            // lbl_Stok
            // 
            this.lbl_Stok.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Stok.Location = new System.Drawing.Point(74, 79);
            this.lbl_Stok.Name = "lbl_Stok";
            this.lbl_Stok.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_Stok.Size = new System.Drawing.Size(120, 13);
            this.lbl_Stok.TabIndex = 5;
            this.lbl_Stok.Text = "0 KG";
            this.lbl_Stok.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_SatisFiyat
            // 
            this.lbl_SatisFiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_SatisFiyat.Location = new System.Drawing.Point(74, 54);
            this.lbl_SatisFiyat.Name = "lbl_SatisFiyat";
            this.lbl_SatisFiyat.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_SatisFiyat.Size = new System.Drawing.Size(120, 13);
            this.lbl_SatisFiyat.TabIndex = 4;
            this.lbl_SatisFiyat.Text = "0.00 ₺";
            this.lbl_SatisFiyat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_AlisFiyat
            // 
            this.lbl_AlisFiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_AlisFiyat.Location = new System.Drawing.Point(74, 26);
            this.lbl_AlisFiyat.Name = "lbl_AlisFiyat";
            this.lbl_AlisFiyat.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_AlisFiyat.Size = new System.Drawing.Size(120, 13);
            this.lbl_AlisFiyat.TabIndex = 3;
            this.lbl_AlisFiyat.Text = "0.00 ₺";
            this.lbl_AlisFiyat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(6, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Stok";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(6, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Satış Fiyat";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Alış Fiyat";
            // 
            // AnasayfaUrunUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.grp_Urun);
            this.Name = "AnasayfaUrunUC";
            this.Size = new System.Drawing.Size(205, 107);
            this.grp_Urun.ResumeLayout(false);
            this.grp_Urun.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grp_Urun;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_Stok;
        private System.Windows.Forms.Label lbl_SatisFiyat;
        private System.Windows.Forms.Label lbl_AlisFiyat;
    }
}
