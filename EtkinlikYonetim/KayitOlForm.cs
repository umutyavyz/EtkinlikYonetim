using Microsoft.Data.Sqlite;
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
    public partial class KayitOlForm : Form
    {
        public static Dictionary<string, string> kullaniciVerileri = new Dictionary<string, string>();
        public KayitOlForm()
        {
            InitializeComponent();
        }

        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = txtKullaniciAdi.Text.Trim();
            string sifre = txtSifre.Text.Trim();
            string sifreTekrar = txtSifreTekrar.Text.Trim();

            if (string.IsNullOrWhiteSpace(kullaniciAdi) || string.IsNullOrWhiteSpace(sifre))
            {
                MessageBox.Show("Kullanıcı adı ve şifre boş olamaz.");
                return;
            }

            if (sifre != sifreTekrar)
            {
                MessageBox.Show("Şifreler uyuşmuyor.");
                return;
            }

            string rol = "Kullanici"; // varsayılan rol

            string query = "INSERT INTO Kullanicilar (KullaniciAdi, Sifre, Rol) VALUES (@KullaniciAdi, @Sifre, @Rol)";

            SqlParameter[] parameters = new SqlParameter[]
            {
        new SqlParameter("@KullaniciAdi", kullaniciAdi),
        new SqlParameter("@Sifre", sifre),
        new SqlParameter("@Rol", rol)
            };

            try
            {
                DatabaseHelper.ExecuteNonQuery(query, parameters);
                MessageBox.Show("Kullanıcı başarıyla eklendi.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }
        }

        private void txtKullaniciAdi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // karakterin TextBox'a yazılmasını engeller
            }
        }

        private void btnkapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAsagial_Click(object sender, EventArgs e)
        {
            this.MinimizeBox = true; // Formu küçült
        }
    }
}
