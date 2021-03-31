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
    
    public partial class E_mail : Form
    {
        hastanelerEntities hhh = new hastanelerEntities();
        public E_mail()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
