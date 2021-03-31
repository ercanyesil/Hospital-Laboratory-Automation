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
    public partial class Kan_tahlilleri : Form
    {
        hastanelerEntities hhh = new hastanelerEntities();
        public Kan_tahlilleri()
        {
            InitializeComponent();
        }

        private void Kan_tahlilleri_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
