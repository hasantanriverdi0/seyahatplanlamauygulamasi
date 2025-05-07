using System;
using System.Windows.Forms;
using static seyahatplanlamauygulamasi.Program;

namespace seyahatplanlamauygulamasi
{
    public partial class kayitlirota : Form
    {
        string ad;
        public kayitlirota()
        {
            InitializeComponent();
        }

        private void kayitlirota_Load(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (string rota in Veri.kayitliRotalar)
            {
                listBox1.Items.Add(rota);
            }
        }

        private void pnl_kaydet_Click(object sender, EventArgs e)
        {

        }

        private void pnl_geri_Click(object sender, EventArgs e)
        {
            anasayfa anasayfa = new anasayfa(ad);
            anasayfa.Show();
            this.Hide();
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen silmek için bir rota seçin!");
                return;
            }

            string secilenRota = listBox1.SelectedItem.ToString();

            // ListBox'tan sil
            listBox1.Items.Remove(secilenRota);

            // Global listeden sil
            Veri.kayitliRotalar.Remove(secilenRota);

            MessageBox.Show("Seçilen rota silindi.");
        }
    }
}