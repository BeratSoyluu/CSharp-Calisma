using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _022_WindowsForms
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtKullaniciAdi.Text)) // txtKullaniciAdi boşsa
            {
                MessageBox.Show("Kullanıcı Adı boş geçilemez!!","UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (string.IsNullOrWhiteSpace(txtSifre.Text))
            {
                MessageBox.Show("Şifre boş geçilemez!!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (string.IsNullOrWhiteSpace(txtKullaniciKodu.Text))
            {
                MessageBox.Show("Kullanıcı kodu boş geçilemez!!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string veritabanindakiKullaniciAdi = "Admin";
                string veritabanindakiSifre = "123456";
                string veritabanindakiKullaniciKodu = "Axd456n";
                if((txtKullaniciAdi.Text == veritabanindakiKullaniciAdi) && (txtKullaniciKodu.Text==veritabanindakiKullaniciKodu) && (txtSifre.Text == veritabanindakiSifre))
                {
                    MessageBox.Show("Hoşgeldin " + txtKullaniciAdi.Text, "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    groupBox1.Visible = false;
                }
                else
                {
                    MessageBox.Show("Sistemde böyle bir kullanıcı yok!!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
