using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Pengembalian : Form
    {
        //TambahMember tm = new TambahMember();

        //DataGridViewRowCollection data = tm.GetRow;
        // ATRIBUT
        //DataGridViewRowCollection rows;
        private String pathNow = Environment.CurrentDirectory;
        // KONSTRUKTOR
        public Pengembalian()
        {
            InitializeComponent();
            //var data = tm.TambahData();

            //rows = GetRow();
        }
        /*public Pengembalian(DataGridViewRowCollection rows)
        {
            InitializeComponent();
            this.rows = rows;
        }*/
        /*public DataGridViewRowCollection GetRow()
        {
            TambahMember tm = new TambahMember();
            return tm.GetRow();
        }*/

        // EVENTS
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            LogIn logIn = new LogIn();
            logIn.Visible = true;
            this.Visible = false;
        }
        private void btnHU_Click(object sender, EventArgs e)
        {
            LogIn logIn = new LogIn();
            logIn.form.Visible = true;
            this.Visible = false;
        }
        private void btnPeminjaman_Click(object sender, EventArgs e)
        {
            LogIn logIn = new LogIn();
            logIn.pinjam.Visible = true;
            this.Visible = false;
        }
        private void BtnMB_Click(object sender, EventArgs e)
        {
            LogIn logIn = new LogIn();
            logIn.tm.Visible = true;
            this.Visible = false;
        }
        //Buat ngambil data berdasarkan nomor peminjaman (yang paling atas sendiri), tapi karena tipedatanya autonumber ini belum work
        private void GetData(int no)
        {
            String path = Path.Combine(pathNow, @"..\..\");
            string connectionString2 = string.Format(Properties.Settings.Default.ConnectionString2
                , Path.Combine(path, "BukuPinjaman.accdb"), Environment.CurrentDirectory);
            string strSql = "SELECT * FROM BukuPinjaman WHERE No = '"+no+"'";
            using (OleDbConnection connection = new OleDbConnection(connectionString2))
            using (OleDbCommand cmd = connection.CreateCommand())
            {               
                cmd.CommandText = strSql;
                cmd.Parameters.Add("@No", OleDbType.Integer).Value = no;
                connection.Open();
                {
                    try
                    {
                        OleDbDataReader read = cmd.ExecuteReader();
                        while (read.Read())
                        {
                            MessageBox.Show("Henlo");
                            tbId.Text = read["ID"].ToString();
                            tbNama.Text = read["Nama"].ToString();
                            tbIsbn.Text = read["ISBN"].ToString();
                            tbJudul.Text = read["Judul"].ToString();
                            tbPenulis.Text = read["Penulis"].ToString();
                            tbJumlahPinjam.Text = read["JumlahPinjam"].ToString();
                            dtpDari.Value = Convert.ToDateTime(read["TanggalDari"].ToString());
                            dtpSampai.Value = Convert.ToDateTime(read["TanggalSampai"].ToString());
                            DateTime now = DateTime.Today;
                            if (DateTime.Compare(now, dtpSampai.Value) > 0)
                            {
                                TimeSpan telat = now - dtpSampai.Value;
                                int telatt = Convert.ToInt32(telat.TotalDays);
                                tbKeterlambatan.Text = Convert.ToString(telatt);
                                tbDenda.Text = Convert.ToString(telatt * 500);
                            }
                            else
                            {
                                tbKeterlambatan.Text = "-";
                                tbDenda.Text = "-";
                            }
                        }

                    }
                    catch { }
                }
            }
        }
        //Polymorphism
        //Ngambil data berdasarkan id member sama isbn buku
        private void GetData()
        {
            String path = Path.Combine(pathNow, @"..\..\");
            string connectionString2 = string.Format(Properties.Settings.Default.ConnectionString2
                , Path.Combine(path, "BukuPinjaman.accdb"),Environment.CurrentDirectory);
            string ID = tbId.Text;
            string ISBN = tbIsbn.Text;
            //String No = tbNomor.Text;
            string strSql = "SELECT * FROM BukuPinjaman WHERE ID='" + ID +"' AND ISBN='"+ISBN+"' AND Kembali IS NULL";
            using (OleDbConnection connection = new OleDbConnection(connectionString2))
            using (OleDbCommand cmd = connection.CreateCommand())
            {
                cmd.CommandText = strSql;
                cmd.Parameters.AddWithValue("ID", ID);
                cmd.Parameters.AddWithValue("ISBN", ISBN);
                connection.Open();
                {
                    try
                    {
                        OleDbDataReader read = cmd.ExecuteReader();
                        while (read.Read())
                        {
                            tbNomor.Text = read["No"].ToString();
                            tbId.Text = read["ID"].ToString();
                            tbNama.Text = read["Nama"].ToString();
                            tbIsbn.Text = read["ISBN"].ToString();
                            tbJudul.Text = read["Judul"].ToString();
                            tbPenulis.Text = read["Penulis"].ToString();
                            tbJumlahPinjam.Text = read["JumlahPinjam"].ToString();
                            dtpDari.Value = Convert.ToDateTime(read["TanggalDari"].ToString());
                            dtpSampai.Value = Convert.ToDateTime(read["TanggalSampai"].ToString());
                            DateTime now = DateTime.Today;
                            if (DateTime.Compare(now, dtpSampai.Value) > 0)
                            {
                                TimeSpan telat = now - dtpSampai.Value;
                                int telatt = Convert.ToInt32(telat.TotalDays);
                                int jumlah = Convert.ToInt32(tbJumlahPinjam.Text);
                                tbKeterlambatan.Text = Convert.ToString(telatt);
                                tbDenda.Text = Convert.ToString(telatt * 500 * jumlah);
                            }
                            else
                            {
                                tbKeterlambatan.Text = "-";
                                tbDenda.Text = "-";
                            }
                        }                        
                    }
                    catch { }
                }
            }
        }
        //buat buka database accessnya pas button Daftar diklik
            private void btnDaftar_Click(object sender, EventArgs e)
            {
                string loc = @"D:\Me!\Program\WindowsFormsApp1\WindowsFormsApp1\BukuPinjaman.accdb";
                Process.Start(loc);
            }

            private void BtnKembalikan_Click(object sender, EventArgs e)
            {
            String path = Path.Combine(pathNow, @"..\..\");
            string ID = tbId.Text;
                string ISBN = tbIsbn.Text;
            DateTime now = DateTime.Today;
            TimeSpan telat = now - dtpSampai.Value;
            int telatt = Convert.ToInt32(telat.TotalDays);
            int jumlah = Convert.ToInt32(tbJumlahPinjam.Text);
            string denda = Convert.ToString(telatt * 500 * jumlah);            
            if (Convert.ToInt32(denda) < 0)
                denda = "0";
            string connectionString2 = string.Format(Properties.Settings.Default.ConnectionString2, Path.Combine(path, "BukuPinjaman.accdb"), Environment.CurrentDirectory);
            string connectionString3 = string.Format(Properties.Settings.Default.ConnectionString3, Path.Combine(path, "TambahBuku.accdb"), Environment.CurrentDirectory);
            string strSql = "UPDATE BukuPinjaman SET Kembali='" + Convert.ToString(now) + "', Denda='"+denda+"' WHERE ID='" + ID + "' AND ISBN='" + ISBN + "'";
            string updateSql = "UPDATE TambahBuku SET Stock = Stock +" + jumlah + " WHERE ISBN = '" + ISBN + "'";
            using (OleDbConnection connection = new OleDbConnection(connectionString2))
            using (OleDbCommand cmd = connection.CreateCommand())
            {
                cmd.CommandText = strSql;
                cmd.Parameters.AddWithValue("ID", ID);
                cmd.Parameters.AddWithValue("ISBN", ISBN);
                cmd.Connection = connection;
                connection.Open();
                {
                    OleDbDataReader read = cmd.ExecuteReader();
                    MessageBox.Show("Terima kasih telah meminjam buku! Silakan pinjam kembali");
                    if (Convert.ToInt32(denda) > 0)
                        MessageBox.Show("Terima kasih juga telah menambah penghasilan kami!", "Telat teroooos");
                    /*if(read.HasRows)
                    {
                        //cmd.ExecuteNonQuery();
                    }
                    else
                    {
                        MessageBox.Show("Tidak ada data tersebut.");
                    }*/
                }
            }
            using (OleDbConnection connection = new OleDbConnection(connectionString3))
            using (OleDbCommand cmd = connection.CreateCommand())
            {
                cmd.CommandText = updateSql;
                cmd.Connection = connection;
                connection.Open();
                {
                    OleDbDataReader read = cmd.ExecuteReader();
                }
            }
        }

            private void TbNomor_TextChanged(object sender, EventArgs e)
            {
            try
            {
                GetData(Convert.ToInt32(tbNomor.Text));
            }
            catch { }
            }

        private void Button1_Click(object sender, EventArgs e)
        {
            GetData(Convert.ToInt32(tbNomor.Text));
            MessageBox.Show("Maaf fitur ini belum disempurnakan");
        }

        private void TbId_TextChanged(object sender, EventArgs e)
        {
            string connectionString = string.Format(Properties.Settings.Default.ConnectionString
                , Environment.CurrentDirectory);
            string ID = tbId.Text;
            string strSql = "SELECT Nama FROM Member WHERE ID=" + ID;
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            using (OleDbCommand cmd = connection.CreateCommand())
            {
                cmd.CommandText = strSql;
                try
                {
                    cmd.Parameters.AddWithValue("ID", Convert.ToInt32(ID));
                }
                catch { }
                connection.Open();
                {
                    OleDbDataReader read;
                    try
                    {
                        read = cmd.ExecuteReader();
                        while (read.Read())
                        {
                            tbNama.Text = read["Nama"].ToString();
                        }
                    }
                    catch
                    {

                    }
                }
            }
        }

        private void TbIsbn_TextChanged(object sender, EventArgs e)
        {
            GetData();
        }

        private void BtnTambahBuku_Click(object sender, EventArgs e)
        {
            TambahBuku tb = new TambahBuku();
            tb.Visible = true;
            this.Visible = false;
        }
    }
}
