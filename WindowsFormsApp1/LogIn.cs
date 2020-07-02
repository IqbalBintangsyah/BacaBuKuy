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
    public partial class LogIn : Form
    {
        public HalamanUtama form = new HalamanUtama();
        public PeminjamanBuku pinjam = new PeminjamanBuku();
        public Pengembalian kembali = new Pengembalian();
        public TambahMember tm = new TambahMember();
        public TambahBuku tb = new TambahBuku();
        public LogIn()
        {
            InitializeComponent();
        }
        private void btnPeminjaman_Click(object sender, EventArgs e)
        {
            if (tbNama.Text == "a" && tbID.Text == "a")
            {
                form.Show();
                pinjam.Show();
                pinjam.Visible = false;
                kembali.Show();
                kembali.Visible = false;
                tm.Show();
                tm.Visible = false;
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("Kok salah? Bukan pegawai yaaa..??\nHayo mau ngapain?");
            }
        }

    }
}
