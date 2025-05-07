using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static seyahatplanlamauygulamasi.Program;

namespace seyahatplanlamauygulamasi
{
    public partial class rota : Form
    {
        string ad;
        public rota()
        {
            InitializeComponent();
        }

        private void rota_Load(object sender, EventArgs e)
        {
            // Türkiye'nin en büyük 10 ili
            List<string> iller = new List<string>
            {
                "İstanbul", "Ankara", "İzmir", "Bursa", "Antalya",
                "Adana", "Konya", "Gaziantep", "Şanlıurfa", "Mersin"
            };

            comboBox1.Items.AddRange(iller.ToArray());
            comboBox2.Items.AddRange(iller.ToArray());

            // Kalınacak mekanlar
            comboBox3.Items.AddRange(new string[]
            {
                "Otel", "Pansiyon", "Airbnb", "Misafirhane", "Kamp Alanı"
            });
        }
        private void pnl_geri_Click(object sender, EventArgs e)
        {
            anasayfa anasayfa = new anasayfa(ad);
            anasayfa.Show();
            this.Hide();
        }

        private void pnl_kaydet_Click_1(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1 || comboBox2.SelectedIndex == -1 || comboBox3.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen tüm alanları seçin!");
                return;
            }

            string rotaBaslangic = comboBox1.SelectedItem.ToString();
            string rotaBitis = comboBox2.SelectedItem.ToString();
            string mekan = comboBox3.SelectedItem.ToString();
            string tarih = dateTimePicker1.Value.ToShortDateString();

            string kayit = $"Rota: {rotaBaslangic} -> {rotaBitis}, Mekan: {mekan}, Tarih: {tarih}";

            Veri.kayitliRotalar.Add(kayit); // Kalıcı olarak kaydet
            MessageBox.Show("Rota başarıyla kaydedildi!");
        }
    }
}
