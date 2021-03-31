using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje
{
    public partial class Main : Form
    {
        hastanelerEntities hhh = new hastanelerEntities();
        public Main()
        {
            InitializeComponent();
        }

        private void mikroskoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void randevuİptalToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void raporToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void genetikTahlilleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var tgen = new tahlil_islemleri.Genetik_tahliller();
            tgen.MdiParent = this;
            tgen.Show();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            Doktorlar f = new Doktorlar();
            f.Doktorlar1 = "gggg";
            hhh.Doktorlar.Add(f);
            hhh.SaveChanges();
            
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var ral = new randevu.Randevu_al();
            ral.MdiParent = this;
            ral.Show();
        }

        private void randevuİptalEtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var rip = new randevu.Randevu_iptal_et();
            rip.MdiParent = this;
            rip.Show();
        }

        private void rAndevuListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var rlist = new randevu.Randevu_listesi();
            rlist.MdiParent = this;
            rlist.Show();
        }

        private void kanTahlilleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var tkan = new tahlil_islemleri.Kan_tahlilleri();
            tkan.MdiParent = this;
            tkan.Show();
            
        }

        private void patalojiTahlilleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var tpat = new tahlil_islemleri.Patoloji_tahlilleri();
            tpat.MdiParent = this;
            tpat.Show();
        }

        private void idrarTahlilleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var tidr = new tahlil_islemleri.İdrar_tahlilleri();
            tidr.MdiParent = this;
            tidr.Show();
        }

        private void mrToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var tmr = new tahlil_islemleri.Radyolojik_tahliller.Mr();
            tmr.MdiParent = this;
            tmr.Show();
        
        }

        private void bTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var tbt = new tahlil_islemleri.Radyolojik_tahliller.Bt();
            tbt.MdiParent = this;
            tbt.Show();
        }

        private void röntgenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var tront = new tahlil_islemleri.Radyolojik_tahliller.Röntgen();
            tront.MdiParent = this;
            tront.Show();
        }

        private void uSGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var tusg = new tahlil_islemleri.Radyolojik_tahliller.Usg();
            tusg.MdiParent = this;
            tusg.Show();
        }

        private void günlükRaporToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var reimz = new rapor.e_imza();
            reimz.MdiParent = this;
            reimz.Show();
        }

        private void aylıkRaporToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var rmus = new rapor.musteri_erisimli();
            rmus.MdiParent = this;
            rmus.Show();
        }

        private void yıllıkRaporToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var ryon = new rapor.yonetim_erisimli();
            ryon.MdiParent = this;
            ryon.Show();
        }

        private void nakitÖdemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var onak = new odeme.Nakit();
            onak.MdiParent = this;
            onak.Show();
        }

        private void krediKartıİleÖdemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var okre = new odeme.Kredi();
            okre.MdiParent = this;
            okre.Show();
        }

        private void sıkSorulanlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var tsık = new teknik_hizmet.Sik_sorulanlar();
            tsık.MdiParent = this;
            tsık.Show();
        }

        private void telefonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var ttel = new teknik_hizmet.İletisim.Telefon();
            ttel.MdiParent = this;
            ttel.Show();
        }

        private void eMailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var tema = new teknik_hizmet.İletisim.E_mail();
            tema.MdiParent = this;
            tema.Show();
        }

        private void asiditeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var tph = new tahlil_islemleri.Mikroskopik_tahliller.Aside_ph();
            tph.MdiParent = this;
            tph.Show();
        }

        private void proteinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var tpro = new tahlil_islemleri.Mikroskopik_tahliller.Protein();
            tpro.MdiParent = this;
            tpro.Show();
        }

        private void şekerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var tse = new tahlil_islemleri.Mikroskopik_tahliller.Seker();
            tse.MdiParent = this;
            tse.Show();
            
           
        }

        private void ketonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var tket = new tahlil_islemleri.Mikroskopik_tahliller.Keton();
            tket.MdiParent = this;
            tket.Show();
        }

        private void enfeksiyonGöstergeleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var tenf = new tahlil_islemleri.Mikroskopik_tahliller.Enfeksiyon();
            tenf.MdiParent = this;
            tenf.Show();
        }
    }
}
