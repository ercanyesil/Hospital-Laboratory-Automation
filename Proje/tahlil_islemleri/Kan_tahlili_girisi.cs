using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje.tahlil_islemleri
{
    public partial class Kan_tahlili_girisi : Form
    {
        hastanelerEntities hhh = new hastanelerEntities();
        public Kan_tahlili_girisi()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
