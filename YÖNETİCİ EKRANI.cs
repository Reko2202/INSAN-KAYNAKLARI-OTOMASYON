using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yapısal_Projeyi
{
    public partial class YÖNETİCİEKRANI : Form
    {
        public YÖNETİCİEKRANI()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            YÖNETİCİEKLEMEFORMU frm = new YÖNETİCİEKLEMEFORMU();
            frm.MdiParent = this;
            frm.Dock = DockStyle.Fill;
            frm.Show();

        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            BAŞVURULAR frm = new BAŞVURULAR();
            frm.MdiParent = this;
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void btnişçiler_Click(object sender, EventArgs e)
        {
            İŞÇİLER frm = new İŞÇİLER();
            frm.MdiParent = this;
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void btnçıkış_Click(object sender, EventArgs e)
        {
            GİRİŞFORMU frm = new GİRİŞFORMU();
            this.Close();
            frm.Show();
        }

        private void YÖNETİCİEKRANI_Load(object sender, EventArgs e)
        {
            HOŞGELDİNİZ frm = new HOŞGELDİNİZ();
            frm.MdiParent = this;
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }
    }
}
