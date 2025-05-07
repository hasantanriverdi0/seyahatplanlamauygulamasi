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
    public partial class anasayfa : Form
    {
        public anasayfa(string ad)
        {
            InitializeComponent();
            label1.Text = "Hoş Geldin " + ad;
        }

        private void anasayfa_Load(object sender, EventArgs e)
        {

        }

        private void pnl_rota_Click_1(object sender, EventArgs e)
        {
            rota frmRota = new rota();
            frmRota.Show();
            this.Hide();
        }

        private void pnl_kayitlirota_Click_1(object sender, EventArgs e)
        {
            kayitlirota frmKayitli = new kayitlirota();
            frmKayitli.Show();
            this.Hide();
        }

        private void pnl_cikis_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
