using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje.Login
{
    public partial class uye_giris : Form
    {
        hastanelerEntities hhh = new hastanelerEntities();
        public uye_giris()
        {
            InitializeComponent();
        }

        private void uye_giris_Load(object sender, EventArgs e)
        {
            //Hastalar u = new Hastalar();
            //u.Hasta_ad =
            
            //hhh.Doktorlar.Add(f);
            //hhh.SaveChanges();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var hg = hhh.Hastalar.Any(n => n.HastaTC == textBox1.Text && n.Hasta_sifre == textBox3.Text);
            if (hg)
            {
                var main = new Main();
                main.Show();
                this.Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            yeni_uye_giris ee = new yeni_uye_giris();
            ee.ShowDialog();

        }
    }
}
