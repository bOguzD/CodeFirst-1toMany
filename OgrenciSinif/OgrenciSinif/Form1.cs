using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OgrenciSinif
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void sınıflarınTanımlanmasıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSinif frm = new FormSinif();
            frm.Show();
        }

        private void öğrencilerinSınıflandırılmasıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormOgrenci frm = new FormOgrenci();
            frm.Show();
        }
    }
}
