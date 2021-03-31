using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje.teknik_hizmet
{
    
    public partial class Sik_sorulanlar : Form
    {
        hastanelerEntities hhh = new hastanelerEntities();
        public Sik_sorulanlar()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
