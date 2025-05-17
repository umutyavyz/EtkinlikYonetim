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
    public partial class KatilimciGoruntule : Form
    {
        public KatilimciGoruntule()
        {
            InitializeComponent();
        }

        private void KatilimciGoruntule_Load(object sender, EventArgs e)
        {

            if (cmbEtkinlikSec.Items.Count > 0)
                cmbEtkinlikSec.SelectedIndex = 0; // Bu satır, ilk etkinliği seçip listelemeyi tetikler.


            string query = "SELECT EtkinlikAdi FROM Etkinlikler";
            DataTable dt = DatabaseHelper.ExecuteQuery(query);

            cmbEtkinlikSec.Items.Clear();

            foreach (DataRow row in dt.Rows)
            {
                cmbEtkinlikSec.Items.Add(row["EtkinlikAdi"].ToString());
            }

            if (cmbEtkinlikSec.Items.Count > 0)
                cmbEtkinlikSec.SelectedIndex = 0;
        }

        private void lstKatilimcilar_SelectedIndexChanged(object sender, EventArgs e)
        {

        
        }

        private void cmbEtkinlikSec_SelectedIndexChanged(object sender, EventArgs e)
        {
            string secilenEtkinlik = cmbEtkinlikSec.SelectedItem?.ToString();

            if (string.IsNullOrWhiteSpace(secilenEtkinlik))
                return;

            string query = "SELECT AdSoyad, TcKimlikNo, Email FROM Katilimcilar WHERE EtkinlikAdi = @EtkinlikAdi";

            SqlParameter[] parameters = new SqlParameter[]
            {
        new SqlParameter("@EtkinlikAdi", secilenEtkinlik)
            };

            DataTable dt = DatabaseHelper.ExecuteQuery(query, parameters);

            lstKatilimcilar.Items.Clear();

            foreach (DataRow row in dt.Rows)
            {
                string adSoyad = row["AdSoyad"]?.ToString() ?? "Ad Bilinmiyor";
                string tc = row["TcKimlikNo"]?.ToString() ?? "TC Yok";
                string email = row["Email"]?.ToString() ?? "Email Yok";

                lstKatilimcilar.Items.Add($"{adSoyad} - {tc} - {email}");
            }
        }
    }
}
