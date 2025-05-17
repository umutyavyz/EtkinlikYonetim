namespace EtkinlikYonetim
{
    partial class KayitEkleForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KayitEkleForm));
            this.cmbEtkinlikler = new System.Windows.Forms.ComboBox();
            this.txtKatilimciTC = new System.Windows.Forms.TextBox();
            this.btnKayit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAsagial = new System.Windows.Forms.Button();
            this.btnkapat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbEtkinlikler
            // 
            this.cmbEtkinlikler.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEtkinlikler.FormattingEnabled = true;
            this.cmbEtkinlikler.Location = new System.Drawing.Point(261, 66);
            this.cmbEtkinlikler.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbEtkinlikler.Name = "cmbEtkinlikler";
            this.cmbEtkinlikler.Size = new System.Drawing.Size(261, 24);
            this.cmbEtkinlikler.TabIndex = 0;
            // 
            // txtKatilimciTC
            // 
            this.txtKatilimciTC.Location = new System.Drawing.Point(261, 101);
            this.txtKatilimciTC.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtKatilimciTC.MaxLength = 11;
            this.txtKatilimciTC.Name = "txtKatilimciTC";
            this.txtKatilimciTC.Size = new System.Drawing.Size(261, 22);
            this.txtKatilimciTC.TabIndex = 1;
            this.txtKatilimciTC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKatilimciTC_KeyPress);
            // 
            // btnKayit
            // 
            this.btnKayit.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnKayit.Location = new System.Drawing.Point(310, 142);
            this.btnKayit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnKayit.Name = "btnKayit";
            this.btnKayit.Size = new System.Drawing.Size(161, 41);
            this.btnKayit.TabIndex = 2;
            this.btnKayit.Text = "Kayıt";
            this.btnKayit.UseVisualStyleBackColor = true;
            this.btnKayit.Click += new System.EventHandler(this.btnKayit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 105);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Katılımcı TC Kimlik Numarası";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(153, 70);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Etkinlik Seçimi";
            // 
            // btnAsagial
            // 
            this.btnAsagial.BackColor = System.Drawing.Color.White;
            this.btnAsagial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAsagial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnAsagial.ForeColor = System.Drawing.Color.Black;
            this.btnAsagial.Location = new System.Drawing.Point(489, -1);
            this.btnAsagial.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAsagial.Name = "btnAsagial";
            this.btnAsagial.Size = new System.Drawing.Size(96, 33);
            this.btnAsagial.TabIndex = 13;
            this.btnAsagial.Text = "-";
            this.btnAsagial.UseVisualStyleBackColor = false;
            this.btnAsagial.Click += new System.EventHandler(this.btnAsagial_Click);
            // 
            // btnkapat
            // 
            this.btnkapat.BackColor = System.Drawing.Color.White;
            this.btnkapat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnkapat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnkapat.ForeColor = System.Drawing.Color.Black;
            this.btnkapat.Location = new System.Drawing.Point(583, -1);
            this.btnkapat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnkapat.Name = "btnkapat";
            this.btnkapat.Size = new System.Drawing.Size(96, 33);
            this.btnkapat.TabIndex = 12;
            this.btnkapat.Text = "X";
            this.btnkapat.UseVisualStyleBackColor = false;
            this.btnkapat.Click += new System.EventHandler(this.btnkapat_Click);
            // 
            // KayitEkleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(676, 270);
            this.Controls.Add(this.btnAsagial);
            this.Controls.Add(this.btnkapat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnKayit);
            this.Controls.Add(this.txtKatilimciTC);
            this.Controls.Add(this.cmbEtkinlikler);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "KayitEkleForm";
            this.Text = "BuBilet | Kayıt Ekle";
            this.Load += new System.EventHandler(this.KayitEkleForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbEtkinlikler;
        private System.Windows.Forms.TextBox txtKatilimciTC;
        private System.Windows.Forms.Button btnKayit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAsagial;
        private System.Windows.Forms.Button btnkapat;
    }
}