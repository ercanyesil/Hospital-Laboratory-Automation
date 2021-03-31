using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje.randevu
{
    public partial class Randevu_al : Form
    {
        hastanelerEntities hhh = new hastanelerEntities();
        public Randevu_al()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "İstanbul")
            {
                comboBox2.Items.Add("Haseki");
                comboBox2.Items.Add("Medipol");
                comboBox2.Items.Add("Çapa");
                comboBox2.Items.Add("Cerrahpaşa");

                comboBox3.Items.Add("Dr.Ahmet");
                comboBox3.Items.Add("Dr.Mehmet");
                comboBox3.Items.Add("Dr.Ali");

                comboBox4.Items.Add("9.00");
                comboBox4.Items.Add("10.00");
                comboBox4.Items.Add("11.00");
                comboBox4.Items.Add("12.00");
            }
            else if (comboBox1.Text == "Ankara")
            {
                comboBox2.Items.Add("Ulus ");
                comboBox2.Items.Add("gazi mustafa kemal");
                comboBox2.Items.Add("29 mayıs ");
                comboBox2.Items.Add("keçiören");
            }
            else
            {
                comboBox2.Items.Clear();
                comboBox3.Items.Clear();
                comboBox4.Items.Clear();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Randevu_al_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("İstanbul");
            comboBox1.Items.Add("Ankara");

            

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label20.Text = comboBox1.Text + comboBox2.Text + comboBox3.Text + comboBox4.Text;
            Random sayi = new Random();
            label20.Text = sayi.Next(9999999).ToString();
        }
    }
}
