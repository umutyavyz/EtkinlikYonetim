namespace EtkinlikYonetim
{
    partial class KatilimciGoruntule
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KatilimciGoruntule));
            this.cmbEtkinlikSec = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lstKatilimcilar = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // cmbEtkinlikSec
            // 
            this.cmbEtkinlikSec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEtkinlikSec.FormattingEnabled = true;
            this.cmbEtkinlikSec.Location = new System.Drawing.Point(104, 25);
            this.cmbEtkinlikSec.Name = "cmbEtkinlikSec";
            this.cmbEtkinlikSec.Size = new System.Drawing.Size(255, 24);
            this.cmbEtkinlikSec.TabIndex = 0;
            this.cmbEtkinlikSec.SelectedIndexChanged += new System.EventHandler(this.cmbEtkinlikSec_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Etkinlik Seçin";
            // 
            // lstKatilimcilar
            // 
            this.lstKatilimcilar.FormattingEnabled = true;
            this.lstKatilimcilar.ItemHeight = 16;
            this.lstKatilimcilar.Location = new System.Drawing.Point(15, 68);
            this.lstKatilimcilar.Name = "lstKatilimcilar";
            this.lstKatilimcilar.Size = new System.Drawing.Size(344, 260);
            this.lstKatilimcilar.TabIndex = 2;
            this.lstKatilimcilar.SelectedIndexChanged += new System.EventHandler(this.lstKatilimcilar_SelectedIndexChanged);
            // 
            // KatilimciGoruntule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 345);
            this.Controls.Add(this.lstKatilimcilar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbEtkinlikSec);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "KatilimciGoruntule";
            this.Text = "BuBilet | Katılımcı Görüntüle";
            this.Load += new System.EventHandler(this.KatilimciGoruntule_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbEtkinlikSec;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstKatilimcilar;
    }
}