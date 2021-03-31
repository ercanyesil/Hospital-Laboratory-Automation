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
    public partial class yeni_uye_giris : Form
    {
        hastanelerEntities hhh = new hastanelerEntities();
        public yeni_uye_giris()
        {
            InitializeComponent();
        }

        private void yeni_uye_giris_Load(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
            Hastalar y = new Hastalar();
            y.Hasta_sifre = textBox8.Text;
            y.Hasta_ad = textBox2.Text;
            y.HastaTC = textBox5.Text;
            y.Hasta_soyad = textBox4.Text;
            y.Hasta_cinsiyet = comboBox2.Text;
            y.Hasta_dogum_tarih = dateTimePicker1.Value;
            y.Hasta_mail = textBox6.Text;
            y.Hasta_telefon = textBox7.Text;
            y.Hasta_sifre = textBox8.Text;

            hhh.Hastalar.Add(y);
            hhh.SaveChanges();
            






        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
