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
    public partial class FormOgrenci : Form
    {
        public FormOgrenci()
        {
            InitializeComponent();
        }
        OgrenciSinifContext ctx = new OgrenciSinifContext();

        private void FormOgrenci_Load(object sender, EventArgs e)
        {
            cmbDoldur();
            Doldur();
        }
        private void cmbDoldur()
        {
            var query=ctx.Siniflar.Select(x => new
            {
                x.SinifID,
                x.Aciklama
            }).ToList();
            comboBox1.DisplayMember = "Aciklama";
            comboBox1.ValueMember = "SinifID";
            comboBox1.DataSource = query;
        }
        private void Doldur()
        {
            dataGridView1.DataSource = ctx.Ogrenciler.Select(x => new
            {
                x.TcKimlikID,
                x.AdSoyad,
                x.sinif.Aciklama
            }).ToList();

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Ogrenci o = new Ogrenci();
            o.AdSoyad = txtAdSoyad.Text;
            o.SinifID = (int)comboBox1.SelectedValue;
            ctx.Ogrenciler.Add(o);
            ctx.SaveChanges();
            Doldur();
        }
    }
}
