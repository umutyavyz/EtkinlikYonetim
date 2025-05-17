namespace EtkinlikYonetim
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnEtkinlikEkle = new System.Windows.Forms.Button();
            this.txtEtkinlikAd = new System.Windows.Forms.TextBox();
            this.dtpTarih = new System.Windows.Forms.DateTimePicker();
            this.numKapasite = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.btnKatilimciEkle = new System.Windows.Forms.Button();
            this.btnKayit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnKatilimciGoruntule = new System.Windows.Forms.Button();
            this.btnAsagial = new System.Windows.Forms.Button();
            this.btnkapat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numKapasite)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEtkinlikEkle
            // 
            this.btnEtkinlikEkle.Location = new System.Drawing.Point(61, 143);
            this.btnEtkinlikEkle.Margin = new System.Windows.Forms.Padding(4);
            this.btnEtkinlikEkle.Name = "btnEtkinlikEkle";
            this.btnEtkinlikEkle.Size = new System.Drawing.Size(165, 44);
            this.btnEtkinlikEkle.TabIndex = 0;
            this.btnEtkinlikEkle.Text = "Etkinlik Ekle";
            this.btnEtkinlikEkle.UseVisualStyleBackColor = true;
            this.btnEtkinlikEkle.Click += new System.EventHandler(this.btnEtkinlikEkle_Click);
            // 
            // txtEtkinlikAd
            // 
            this.txtEtkinlikAd.Location = new System.Drawing.Point(144, 89);
            this.txtEtkinlikAd.Margin = new System.Windows.Forms.Padding(4);
            this.txtEtkinlikAd.MaxLength = 80;
            this.txtEtkinlikAd.Name = "txtEtkinlikAd";
            this.txtEtkinlikAd.Size = new System.Drawing.Size(168, 22);
            this.txtEtkinlikAd.TabIndex = 1;
            // 
            // dtpTarih
            // 
            this.dtpTarih.Location = new System.Drawing.Point(61, 57);
            this.dtpTarih.Margin = new System.Windows.Forms.Padding(4);
            this.dtpTarih.Name = "dtpTarih";
            this.dtpTarih.Size = new System.Drawing.Size(251, 22);
            this.dtpTarih.TabIndex = 2;
            // 
            // numKapasite
            // 
            this.numKapasite.Location = new System.Drawing.Point(429, 57);
            this.numKapasite.Margin = new System.Windows.Forms.Padding(4);
            this.numKapasite.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numKapasite.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numKapasite.Name = "numKapasite";
            this.numKapasite.Size = new System.Drawing.Size(65, 22);
            this.numKapasite.TabIndex = 3;
            this.numKapasite.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 92);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Etkinlik Adı";
            // 
            // btnKatilimciEkle
            // 
            this.btnKatilimciEkle.Location = new System.Drawing.Point(277, 143);
            this.btnKatilimciEkle.Margin = new System.Windows.Forms.Padding(4);
            this.btnKatilimciEkle.Name = "btnKatilimciEkle";
            this.btnKatilimciEkle.Size = new System.Drawing.Size(165, 44);
            this.btnKatilimciEkle.TabIndex = 5;
            this.btnKatilimciEkle.Text = "Katılımcı Ekleme";
            this.btnKatilimciEkle.UseVisualStyleBackColor = true;
            this.btnKatilimciEkle.Click += new System.EventHandler(this.btnKatilimciEkle_Click);
            // 
            // btnKayit
            // 
            this.btnKayit.Location = new System.Drawing.Point(487, 143);
            this.btnKayit.Margin = new System.Windows.Forms.Padding(4);
            this.btnKayit.Name = "btnKayit";
            this.btnKayit.Size = new System.Drawing.Size(165, 44);
            this.btnKayit.TabIndex = 6;
            this.btnKayit.Text = "Bilet Oluştur";
            this.btnKayit.UseVisualStyleBackColor = true;
            this.btnKayit.Click += new System.EventHandler(this.btnKayit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(321, 59);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Kişi Kapasitesi";
            // 
            // btnKatilimciGoruntule
            // 
            this.btnKatilimciGoruntule.Location = new System.Drawing.Point(277, 204);
            this.btnKatilimciGoruntule.Margin = new System.Windows.Forms.Padding(4);
            this.btnKatilimciGoruntule.Name = "btnKatilimciGoruntule";
            this.btnKatilimciGoruntule.Size = new System.Drawing.Size(165, 44);
            this.btnKatilimciGoruntule.TabIndex = 9;
            this.btnKatilimciGoruntule.Text = "Katılımcı Görüntüle";
            this.btnKatilimciGoruntule.UseVisualStyleBackColor = true;
            this.btnKatilimciGoruntule.Click += new System.EventHandler(this.btnKatilimciGoruntule_Click);
            // 
            // btnAsagial
            // 
            this.btnAsagial.BackColor = System.Drawing.Color.PaleGreen;
            this.btnAsagial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAsagial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnAsagial.ForeColor = System.Drawing.Color.Black;
            this.btnAsagial.Location = new System.Drawing.Point(500, -1);
            this.btnAsagial.Margin = new System.Windows.Forms.Padding(4);
            this.btnAsagial.Name = "btnAsagial";
            this.btnAsagial.Size = new System.Drawing.Size(96, 33);
            this.btnAsagial.TabIndex = 11;
            this.btnAsagial.Text = "-";
            this.btnAsagial.UseVisualStyleBackColor = false;
            this.btnAsagial.Click += new System.EventHandler(this.btnAsagial_Click);
            // 
            // btnkapat
            // 
            this.btnkapat.BackColor = System.Drawing.Color.PaleGreen;
            this.btnkapat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnkapat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnkapat.ForeColor = System.Drawing.Color.Black;
            this.btnkapat.Location = new System.Drawing.Point(593, -1);
            this.btnkapat.Margin = new System.Windows.Forms.Padding(4);
            this.btnkapat.Name = "btnkapat";
            this.btnkapat.Size = new System.Drawing.Size(96, 33);
            this.btnkapat.TabIndex = 10;
            this.btnkapat.Text = "X";
            this.btnkapat.UseVisualStyleBackColor = false;
            this.btnkapat.Click += new System.EventHandler(this.btnkapat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(688, 263);
            this.Controls.Add(this.btnAsagial);
            this.Controls.Add(this.btnkapat);
            this.Controls.Add(this.btnKatilimciGoruntule);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnKayit);
            this.Controls.Add(this.btnKatilimciEkle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numKapasite);
            this.Controls.Add(this.dtpTarih);
            this.Controls.Add(this.txtEtkinlikAd);
            this.Controls.Add(this.btnEtkinlikEkle);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "BuBilet";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numKapasite)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEtkinlikEkle;
        private System.Windows.Forms.TextBox txtEtkinlikAd;
        private System.Windows.Forms.DateTimePicker dtpTarih;
        private System.Windows.Forms.NumericUpDown numKapasite;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnKatilimciEkle;
        private System.Windows.Forms.Button btnKayit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnKatilimciGoruntule;
        private System.Windows.Forms.Button btnAsagial;
        private System.Windows.Forms.Button btnkapat;
    }
}

