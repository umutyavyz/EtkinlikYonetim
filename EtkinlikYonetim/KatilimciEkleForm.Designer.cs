namespace EtkinlikYonetim
{
    partial class KatilimciEkleForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KatilimciEkleForm));
            this.txtTC = new System.Windows.Forms.TextBox();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnKatilimciEkle = new System.Windows.Forms.Button();
            this.lblUyari = new System.Windows.Forms.Label();
            this.btnEtkinlikSecim = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtTC
            // 
            this.txtTC.Location = new System.Drawing.Point(176, 47);
            this.txtTC.Margin = new System.Windows.Forms.Padding(4);
            this.txtTC.MaxLength = 11;
            this.txtTC.Name = "txtTC";
            this.txtTC.Size = new System.Drawing.Size(221, 22);
            this.txtTC.TabIndex = 0;
            this.txtTC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTC_KeyPress);
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Location = new System.Drawing.Point(176, 79);
            this.txtAdSoyad.Margin = new System.Windows.Forms.Padding(4);
            this.txtAdSoyad.MaxLength = 64;
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(221, 22);
            this.txtAdSoyad.TabIndex = 1;
            this.txtAdSoyad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAdSoyad_KeyPress);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(176, 111);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.MaxLength = 100;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(221, 22);
            this.txtEmail.TabIndex = 2;
            this.txtEmail.Leave += new System.EventHandler(this.txtEmail_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 47);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "TC Kimlik No";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 79);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ad Soyad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 111);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "E-posta";
            // 
            // btnKatilimciEkle
            // 
            this.btnKatilimciEkle.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnKatilimciEkle.Location = new System.Drawing.Point(176, 144);
            this.btnKatilimciEkle.Margin = new System.Windows.Forms.Padding(4);
            this.btnKatilimciEkle.Name = "btnKatilimciEkle";
            this.btnKatilimciEkle.Size = new System.Drawing.Size(223, 44);
            this.btnKatilimciEkle.TabIndex = 6;
            this.btnKatilimciEkle.Text = "Katilimci Ekle";
            this.btnKatilimciEkle.UseVisualStyleBackColor = true;
            this.btnKatilimciEkle.Click += new System.EventHandler(this.btnKatilimciEkle_Click);
            // 
            // lblUyari
            // 
            this.lblUyari.AutoSize = true;
            this.lblUyari.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUyari.Location = new System.Drawing.Point(13, 213);
            this.lblUyari.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUyari.Name = "lblUyari";
            this.lblUyari.Size = new System.Drawing.Size(67, 24);
            this.lblUyari.TabIndex = 7;
            this.lblUyari.Text = "Durum";
            // 
            // btnEtkinlikSecim
            // 
            this.btnEtkinlikSecim.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnEtkinlikSecim.Location = new System.Drawing.Point(323, 199);
            this.btnEtkinlikSecim.Margin = new System.Windows.Forms.Padding(4);
            this.btnEtkinlikSecim.Name = "btnEtkinlikSecim";
            this.btnEtkinlikSecim.Size = new System.Drawing.Size(184, 41);
            this.btnEtkinlikSecim.TabIndex = 8;
            this.btnEtkinlikSecim.Text = "Etkinlik Seçimi";
            this.btnEtkinlikSecim.UseVisualStyleBackColor = true;
            this.btnEtkinlikSecim.Click += new System.EventHandler(this.button1_Click);
            // 
            // KatilimciEkleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(521, 251);
            this.Controls.Add(this.btnEtkinlikSecim);
            this.Controls.Add(this.lblUyari);
            this.Controls.Add(this.btnKatilimciEkle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtAdSoyad);
            this.Controls.Add(this.txtTC);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "KatilimciEkleForm";
            this.Text = "BuBilet | Katilimci Ekle";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.KatilimciEkleForm_FormClosing);
            this.Load += new System.EventHandler(this.KatilimciEkleForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTC;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnKatilimciEkle;
        private System.Windows.Forms.Label lblUyari;
        private System.Windows.Forms.Button btnEtkinlikSecim;
    }
}