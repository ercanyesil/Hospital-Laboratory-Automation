using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje.tahlil_islemleri.Radyolojik_tahliller
{
    public partial class Usg : Form
    {
        hastanelerEntities hhh = new hastanelerEntities();
        public Usg()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
