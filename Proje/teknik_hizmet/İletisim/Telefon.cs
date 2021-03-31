using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje.teknik_hizmet.İletisim
{
    
    public partial class Telefon : Form
    {
        hastanelerEntities hhh = new hastanelerEntities();
        public Telefon()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
