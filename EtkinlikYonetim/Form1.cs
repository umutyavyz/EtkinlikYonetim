using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EtkinlikYonetim
{
    public partial class Form1 : Form
    {
        List<Etkinlik> etkinlikListesi = new List<Etkinlik>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEtkinlikEkle_Click(object sender, EventArgs e)
        {
            string etkinlikAdi = txtEtkinlikAd.Text.Trim();
            DateTime tarih = dtpTarih.Value.Date;
            int kapasite = (int)numKapasite.Value;

            if (string.IsNullOrWhiteSpace(etkinlikAdi))
            {
                MessageBox.Show("Etkinlik adı boş bırakılamaz.");
                return;
            }

            if (tarih < DateTime.Today)
            {
                MessageBox.Show("Geçmiş tarihli etkinlik eklenemez.");
                return;
            }

            string query = "INSERT INTO Etkinlikler (EtkinlikAdi, Tarih, Kapasite) VALUES (@EtkinlikAdi, @Tarih, @Kapasite)";

            SqlParameter[] parameters = new SqlParameter[]
            {
        new SqlParameter("@EtkinlikAdi", etkinlikAdi),
        new SqlParameter("@Tarih", tarih),
        new SqlParameter("@Kapasite", kapasite)
            };

            try
            {
                DatabaseHelper.ExecuteNonQuery(query, parameters);
                MessageBox.Show("Etkinlik başarıyla eklendi.");

                // Alanları temizle (isteğe bağlı)
                txtEtkinlikAd.Text = "";
                numKapasite.Value = 1;
                dtpTarih.Value = DateTime.Today;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }
        }

        private void btnKatilimciEkle_Click(object sender, EventArgs e)
        {
            KatilimciEkleForm katilimciEkleForm = new KatilimciEkleForm();
            katilimciEkleForm.ShowDialog();

        }

        private void btnKayit_Click(object sender, EventArgs e)
        {
            new KayitEkleForm().ShowDialog();
        }

        private void btnAsagial_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnkapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dtpTarih.MinDate = DateTime.Today;
        }

        private void btnKatilimciGoruntule_Click(object sender, EventArgs e)
        {
            KatilimciGoruntule katilimciGoruntule = new KatilimciGoruntule();
            katilimciGoruntule.ShowDialog();
        }
    }
}
