using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Daftar_Pinjaman : Form
    {
        public Daftar_Pinjaman()
        {
            InitializeComponent();
        }

        private void btnHU_Click(object sender, EventArgs e)
        {
            HalamanUtama form = new HalamanUtama();
            form.Show();
        }

        private void btnPengembalian_Click(object sender, EventArgs e)
        {
            Pengembalian form = new Pengembalian();
            form.Show();
        }

        private void btnMB_Click(object sender, EventArgs e)
        {
            TambahMember form = new TambahMember();
            form.Show();
        }

        private void BtnTambahBuku_Click(object sender, EventArgs e)
        {
            TambahBuku form = new TambahBuku();
            form.Show();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
