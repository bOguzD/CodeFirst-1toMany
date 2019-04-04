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
    public partial class FormSinif : Form
    {
        OgrenciSinifContext ctx = new OgrenciSinifContext();
        public FormSinif()
        {
            InitializeComponent();
        }

        private void FormSinif_Load(object sender, EventArgs e)
        {
            Doldur();
        }
        private void Doldur()
        {
            dataGridView1.DataSource = ctx.Siniflar.Select(x => new
            {
                x.SinifID,
                x.Aciklama
            }).ToList();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Sinif s = new Sinif();
            s.Aciklama = txtAciklama.Text;
            ctx.Siniflar.Add(s);
            ctx.SaveChanges();
            Doldur();
        }
    }
}
