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
    public partial class KayitEkleForm : Form
    {
        
        public KayitEkleForm()
        {
            InitializeComponent();
        }

        private void btnKayit_Click(object sender, EventArgs e)
        {
            string secilenEtkinlik = cmbEtkinlikler.SelectedItem?.ToString();
            string tcKimlik = txtKatilimciTC.Text.Trim();

            if (string.IsNullOrWhiteSpace(secilenEtkinlik) || string.IsNullOrWhiteSpace(tcKimlik))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.");
                return;
            }

            if (tcKimlik.Length != 11 || !tcKimlik.All(char.IsDigit))
            {
                MessageBox.Show("Geçerli bir 11 haneli TC Kimlik No girin.");
                return;
            }

            // 1. Katılımcı sistemde var mı kontrolü
            string kontrolQuery = "SELECT COUNT(*) FROM Katilimcilar WHERE TcKimlikNo = @TcKimlikNo";
            SqlParameter kontrolParam = new SqlParameter("@TcKimlikNo", tcKimlik);

            try
            {
                DataTable result = DatabaseHelper.ExecuteQuery(kontrolQuery, kontrolParam);
                int kayitSayisi = Convert.ToInt32(result.Rows[0][0]);

                if (kayitSayisi > 0)
                {
                    // 2. Güncelleme sorgusu
                    string updateQuery = "UPDATE Katilimcilar SET EtkinlikAdi = @EtkinlikAdi WHERE TcKimlikNo = @TcKimlikNo";
                    SqlParameter[] updateParams = new SqlParameter[]
                    {
            new SqlParameter("@EtkinlikAdi", secilenEtkinlik),
            new SqlParameter("@TcKimlikNo", tcKimlik)
                    };

                    DatabaseHelper.ExecuteNonQuery(updateQuery, updateParams);
                    MessageBox.Show("Etkinlik başarıyla güncellendi.");

                    // Temizle
                    txtKatilimciTC.Text = "";
                    cmbEtkinlikler.SelectedIndex = 0;
                }
                else
                {
                    MessageBox.Show("Bu TC Kimlik numarasıyla sistemde kayıtlı bir katılımcı bulunamadı.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }
        }

        private void txtKatilimciTC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnkapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAsagial_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void KayitEkleForm_Load(object sender, EventArgs e)
        {
            this.Load += new System.EventHandler(this.KayitEkleForm_Load);

            string query = "SELECT EtkinlikAdi FROM Etkinlikler";

            try
            {
                DataTable dt = DatabaseHelper.ExecuteQuery(query);

                cmbEtkinlikler.Items.Clear();
                foreach (DataRow row in dt.Rows)
                {
                    cmbEtkinlikler.Items.Add(row["EtkinlikAdi"].ToString());
                }

                if (cmbEtkinlikler.Items.Count > 0)
                    cmbEtkinlikler.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Etkinlikler yüklenirken hata oluştu: " + ex.Message);
            }
        }
    }
}
