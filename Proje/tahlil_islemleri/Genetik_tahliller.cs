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
    public partial class Genetik_tahliller : Form
    {
        hastanelerEntities hhh = new hastanelerEntities();
        public Genetik_tahliller()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
