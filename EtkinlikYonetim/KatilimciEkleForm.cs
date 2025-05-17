using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EtkinlikYonetim
{
    public partial class KatilimciEkleForm : Form
    {
        List<Katilim> katilimciListesi = new List<Katilim>();
        public KatilimciEkleForm()
        {
            InitializeComponent();
        }

        private void btnKatilimciEkle_Click(object sender, EventArgs e)
        {
            string tc = txtTC.Text.Trim();
            string adSoyad = txtAdSoyad.Text.Trim();
            string email = txtEmail.Text.Trim();

            if (string.IsNullOrWhiteSpace(tc) || string.IsNullOrWhiteSpace(adSoyad) || string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.");
                return;
            }

            string query = "INSERT INTO Katilimcilar (TcKimlikNo, AdSoyad, Email) " +
                           "VALUES (@TcKimlikNo, @AdSoyad, @Email)";

            SqlParameter[] parameters = new SqlParameter[]
            {
        new SqlParameter("@TcKimlikNo", tc),
        new SqlParameter("@AdSoyad", adSoyad),
        new SqlParameter("@Email", email)
            };

            try
            {
                DatabaseHelper.ExecuteNonQuery(query, parameters);
                MessageBox.Show("Katılımcı başarıyla eklendi.");
                txtAdSoyad.Text = "";
                txtTC.Text = "";
                txtEmail.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }
        }

        private void txtTC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // karakterin yazılmasını engeller
            }
        }

        private void txtAdSoyad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // karakterin TextBox'a yazılmasını engeller
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";

            if (!Regex.IsMatch(email, pattern))
            {
                lblUyari.Text = "Geçersiz e-posta adresi!";
                lblUyari.ForeColor = Color.Red;
            }
            else
            {
                lblUyari.Text = "Geçerli E-posta Adresi!";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new KayitEkleForm().ShowDialog();
        }

        private void KatilimciEkleForm_Load(object sender, EventArgs e)
        {

        }

        private void KatilimciEkleForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Session.Rol == "admin")
            {
                // Sadece bu formu kapat
                this.Hide(); // veya e.Cancel = true;
            }
            else
            {
                // Kullanıcı ise uygulamayı tamamen kapat
                Application.Exit();
            }
        }
    }
}
