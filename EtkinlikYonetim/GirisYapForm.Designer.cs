namespace EtkinlikYonetim
{
    partial class GirisYapForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GirisYapForm));
            this.txtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnkapat = new System.Windows.Forms.Button();
            this.btnAsagial = new System.Windows.Forms.Button();
            this.btnkayitol = new System.Windows.Forms.Button();
            this.btnGiris2 = new ReaLTaiizor.Controls.HopeButton();
            this.SuspendLayout();
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.BackColor = System.Drawing.Color.White;
            this.txtKullaniciAdi.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtKullaniciAdi.Location = new System.Drawing.Point(222, 64);
            this.txtKullaniciAdi.MaxLength = 32;
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(148, 29);
            this.txtKullaniciAdi.TabIndex = 0;
            this.txtKullaniciAdi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKullaniciAdi_KeyPress);
            // 
            // txtSifre
            // 
            this.txtSifre.BackColor = System.Drawing.Color.White;
            this.txtSifre.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtSifre.Location = new System.Drawing.Point(222, 116);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(148, 29);
            this.txtSifre.TabIndex = 1;
            this.txtSifre.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(143, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Kullanıcı Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(178, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Şifre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(267, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "YA DA";
            // 
            // btnkapat
            // 
            this.btnkapat.BackColor = System.Drawing.Color.PaleGreen;
            this.btnkapat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnkapat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnkapat.ForeColor = System.Drawing.Color.Black;
            this.btnkapat.Location = new System.Drawing.Point(448, -1);
            this.btnkapat.Name = "btnkapat";
            this.btnkapat.Size = new System.Drawing.Size(72, 27);
            this.btnkapat.TabIndex = 7;
            this.btnkapat.Text = "X";
            this.btnkapat.UseVisualStyleBackColor = false;
            this.btnkapat.Click += new System.EventHandler(this.btnkapat_Click);
            // 
            // btnAsagial
            // 
            this.btnAsagial.BackColor = System.Drawing.Color.PaleGreen;
            this.btnAsagial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAsagial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnAsagial.ForeColor = System.Drawing.Color.Black;
            this.btnAsagial.Location = new System.Drawing.Point(378, -1);
            this.btnAsagial.Name = "btnAsagial";
            this.btnAsagial.Size = new System.Drawing.Size(72, 27);
            this.btnAsagial.TabIndex = 8;
            this.btnAsagial.Text = "-";
            this.btnAsagial.UseVisualStyleBackColor = false;
            this.btnAsagial.Click += new System.EventHandler(this.btnAsagial_Click);
            // 
            // btnkayitol
            // 
            this.btnkayitol.BackColor = System.Drawing.Color.Transparent;
            this.btnkayitol.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnkayitol.FlatAppearance.BorderSize = 0;
            this.btnkayitol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnkayitol.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnkayitol.Location = new System.Drawing.Point(226, 243);
            this.btnkayitol.Name = "btnkayitol";
            this.btnkayitol.Size = new System.Drawing.Size(130, 25);
            this.btnkayitol.TabIndex = 9;
            this.btnkayitol.Text = "Kayıt Ol";
            this.btnkayitol.UseVisualStyleBackColor = false;
            this.btnkayitol.Click += new System.EventHandler(this.btnkayitol_Click);
            // 
            // btnGiris2
            // 
            this.btnGiris2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.btnGiris2.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            this.btnGiris2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGiris2.DangerColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.btnGiris2.DefaultColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnGiris2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnGiris2.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.btnGiris2.InfoColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(147)))), ((int)(((byte)(153)))));
            this.btnGiris2.Location = new System.Drawing.Point(242, 168);
            this.btnGiris2.Name = "btnGiris2";
            this.btnGiris2.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(194)))), ((int)(((byte)(58)))));
            this.btnGiris2.Size = new System.Drawing.Size(100, 33);
            this.btnGiris2.SuccessColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.btnGiris2.TabIndex = 10;
            this.btnGiris2.Text = "Giriş";
            this.btnGiris2.TextColor = System.Drawing.Color.White;
            this.btnGiris2.WarningColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(162)))), ((int)(((byte)(60)))));
            this.btnGiris2.Click += new System.EventHandler(this.btnGiris2_Click);
            // 
            // GirisYapForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(519, 304);
            this.Controls.Add(this.btnGiris2);
            this.Controls.Add(this.btnkayitol);
            this.Controls.Add(this.btnAsagial);
            this.Controls.Add(this.btnkapat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.txtKullaniciAdi);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GirisYapForm";
            this.Text = "BuBilet | Giriş Yap";
            this.Load += new System.EventHandler(this.GirisYapForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtKullaniciAdi;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnkapat;
        private System.Windows.Forms.Button btnAsagial;
        private System.Windows.Forms.Button btnkayitol;
        private ReaLTaiizor.Controls.HopeButton btnGiris2;
    }
}