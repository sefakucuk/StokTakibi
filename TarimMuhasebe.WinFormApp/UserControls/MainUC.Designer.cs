
namespace TarimMuhasebe.WinFormApp.UserControls
{
    partial class MainUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainUC));
            this.pnl_Main = new System.Windows.Forms.Panel();
            this.pnl_Urunler = new System.Windows.Forms.FlowLayoutPanel();
            this.pnl_Kasalar = new System.Windows.Forms.FlowLayoutPanel();
            this.pnl_Main.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Main
            // 
            this.pnl_Main.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnl_Main.BackgroundImage")));
            this.pnl_Main.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pnl_Main.Controls.Add(this.pnl_Urunler);
            this.pnl_Main.Controls.Add(this.pnl_Kasalar);
            this.pnl_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Main.Location = new System.Drawing.Point(0, 0);
            this.pnl_Main.Name = "pnl_Main";
            this.pnl_Main.Size = new System.Drawing.Size(1277, 632);
            this.pnl_Main.TabIndex = 0;
            // 
            // pnl_Urunler
            // 
            this.pnl_Urunler.AutoScroll = true;
            this.pnl_Urunler.AutoSize = true;
            this.pnl_Urunler.BackColor = System.Drawing.Color.Transparent;
            this.pnl_Urunler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Urunler.Location = new System.Drawing.Point(0, 0);
            this.pnl_Urunler.Name = "pnl_Urunler";
            this.pnl_Urunler.Padding = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.pnl_Urunler.Size = new System.Drawing.Size(1277, 612);
            this.pnl_Urunler.TabIndex = 8;
            // 
            // pnl_Kasalar
            // 
            this.pnl_Kasalar.AutoScroll = true;
            this.pnl_Kasalar.AutoSize = true;
            this.pnl_Kasalar.BackColor = System.Drawing.Color.Transparent;
            this.pnl_Kasalar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_Kasalar.Location = new System.Drawing.Point(0, 612);
            this.pnl_Kasalar.Name = "pnl_Kasalar";
            this.pnl_Kasalar.Padding = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.pnl_Kasalar.Size = new System.Drawing.Size(1277, 20);
            this.pnl_Kasalar.TabIndex = 6;
            // 
            // MainUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnl_Main);
            this.Name = "MainUC";
            this.Size = new System.Drawing.Size(1277, 632);
            this.pnl_Main.ResumeLayout(false);
            this.pnl_Main.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Main;
        private System.Windows.Forms.FlowLayoutPanel pnl_Kasalar;
        private System.Windows.Forms.FlowLayoutPanel pnl_Urunler;
    }
}
