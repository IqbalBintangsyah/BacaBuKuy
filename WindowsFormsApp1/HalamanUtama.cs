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
    public partial class HalamanUtama : Form
    {
        public HalamanUtama()
        {
            InitializeComponent();
        }

        private void btPeminjaman_Click(object sender, EventArgs e)
        {
            LogIn logIn = new LogIn();
            logIn.pinjam.Visible = true;
            this.Visible = false;
        }

        private void btPengembalian_Click(object sender, EventArgs e)
        {
            LogIn logIn = new LogIn();
            logIn.kembali.Visible = true;
            this.Visible = false;
        }

        private void btMemberBaru_Click(object sender, EventArgs e)
        {
            LogIn logIn = new LogIn();
            logIn.tm.Visible = true;
            this.Visible = false;
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            LogIn logIn = new LogIn();
            logIn.Visible = true;
            this.Visible = false;
        }

        private void BtnTambahBuku_Click(object sender, EventArgs e)
        {
            TambahBuku tb = new TambahBuku();
            tb.Visible = true;
            this.Visible = false;
        }
    }
}
