using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace seyahatplanlamauygulamasi
{
    public partial class giris : Form
    {

        public giris()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pnl_giris_Click(object sender, EventArgs e)
        {
            string adSoyad = txt_adsoyad.Text.Trim();
            string telefon = txt_no.Text.Trim();

            // Kontroller
            if (string.IsNullOrWhiteSpace(adSoyad))
            {
                MessageBox.Show("Ad Soyad boş olamaz!");
                return;
            }

            if (telefon.Length != 10 || !telefon.All(char.IsDigit))
            {
                MessageBox.Show("Telefon numarası 10 haneli ve sadece rakamlardan oluşmalıdır!");
                return;
            }

            // Geçerli ise anasayfaya geçiş
            anasayfa frm = new anasayfa(adSoyad);
            frm.Show();
            this.Hide();
        }
    }
}
