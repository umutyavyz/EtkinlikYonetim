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
using ReaLTaiizor;
using ReaLTaiizor.Forms;

namespace EtkinlikYonetim
{
    public partial class GirisYapForm : Form
    {
        Dictionary<string, string> kullaniciVerileri = new Dictionary<string, string>()
    {
        { "admin", "admin" },
        { "kullanici", "sifre" }
    };
        public GirisYapForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = this.Size;
            this.MinimumSize = this.Size;
        }

        private void GirisYapForm_Load(object sender, EventArgs e)
        {
            txtSifre.PasswordChar = '*';
            this.FormBorderStyle = FormBorderStyle.None;

            // Çıkış ve diğer düğmeleri gizle
            this.ControlBox = false;
            this.MaximizeBox = false; // Maksimize butonunu gizle
            this.MinimizeBox = false; // Minimize butonunu gizle

            Color butonRenk = ColorTranslator.FromHtml("#ea2842");
            btnkayitol.ForeColor = butonRenk;
            btnGiris2.PrimaryColor = butonRenk;
            btnGiris2.Font = new Font(btnGiris2.Font.FontFamily, 9, FontStyle.Bold);
            // Butonun kenarlarını kaldır
        }

        private void txtKullaniciAdi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // karakterin TextBox'a yazılmasını engeller
            }
        }

        private void btnkayitol_Click(object sender, EventArgs e)
        {
            KayitOlForm kayitFormu = new KayitOlForm();
            kayitFormu.StartPosition = FormStartPosition.CenterParent;
            kayitFormu.ShowDialog(this);
        }

        private void btnGiris2_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = txtKullaniciAdi.Text.Trim();
            string sifre = txtSifre.Text.Trim();

            if (string.IsNullOrWhiteSpace(kullaniciAdi) || string.IsNullOrWhiteSpace(sifre))
            {
                MessageBox.Show("Lütfen kullanıcı adı ve şifrenizi girin.");
                return;
            }

            string query = "SELECT * FROM Kullanicilar WHERE KullaniciAdi = @KullaniciAdi AND Sifre = @Sifre";

            SqlParameter[] parameters = new SqlParameter[]
            {
    new SqlParameter("@KullaniciAdi", kullaniciAdi),
    new SqlParameter("@Sifre", sifre)
            };

            try
            {
                DataTable result = DatabaseHelper.ExecuteQuery(query, parameters);

                if (result.Rows.Count > 0)
                {
                    // Giriş başarılı
                    string rol = result.Rows[0]["Rol"].ToString();
                    Session.KullaniciAdi = kullaniciAdi;
                    Session.Rol = rol;

                    MessageBox.Show("Giriş başarılı. Hoş geldiniz, " + kullaniciAdi + "!");

                    if (rol.ToLower() == "admin")
                    {
                        // Admin ise ana formu aç
                        Form1 adminForm = new Form1(); // kendi ana formunun adı neyse onu yaz
                        adminForm.Show();
                    }
                    else
                    {
                        // Diğer roller için kayıt ekleme formu aç
                        KatilimciEkleForm katilimciForm = new KatilimciEkleForm();
                        katilimciForm.Show();
                    }

                    this.Hide(); // Giriş formunu gizle (isteğe bağlı)
                }
                else
                {
                    MessageBox.Show("Kullanıcı adı veya şifre hatalı.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
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
    }
}
