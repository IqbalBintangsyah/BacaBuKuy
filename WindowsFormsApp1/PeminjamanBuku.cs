using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class PeminjamanBuku : Form
    {
        private string id;
        public string Id
        {
            get
            {
                return id;
            }
            set
            {
                id = tbID.Text;
            }
        }
        //BookResult listBuku;
        TambahMember tm = new TambahMember();
        //DataGridViewRowCollection rows = MemberDataSet.member;
        private String pathNow = Environment.CurrentDirectory;
        //Constructor
        public PeminjamanBuku()
        {
            InitializeComponent();
            dtpSampai.Value = dtpSampai.Value.AddDays(3);   //Batas peminjaman umumnya 3 hari
            /*listBuku = BookRest.GetBukuList(tbNamaBuku.Text);
            foreach (string buku in listBuku)
            {
                tbNamaBuku.AutoCompleteCustomSource.Add(buku);
            }*/
        }

        /*private void TbId_TextChanged(object sender, EventArgs e)
        {
            string nama = "";
            try
            {
                if (GetNama(Convert.ToInt32(tbID.Text), ref nama))
                    tbNamaPeminjam.Text = nama;
                //else
                //    tbNama.Text = "";
            }
            catch { }
        }*/

        // METHODS
        /*private bool GetNama(int id, ref string nama)
        {
            if (rows == null)
                return false;
            for (int i = 0; i < rows.Count; i++)
            {
                if (id == (int)rows[i].Cells[0].Value)
                {
                    nama = rows[i].Cells[1].Value as string;
                    break;
                }
            }
            if (nama != "")
                return true;
            else
                return false;
        }*/

        /*private void tbNamaBuku_TextChanged(object sender, EventArgs e)
        {
            //BookRest bookRest = new BookRest();
            //string id = bookRest.ObtainResult(tbNamaBuku.Text).Identifier;
            //tbKodeBuku.Text = id;
        }*/
        //Buat nyari dan menampilkan nama peminjam pas id dimasukkan
        private void TbID_TextChanged(object sender, EventArgs e)
        {
            String path = Path.Combine(pathNow, @"..\..\");
            string connectionString = string.Format(Properties.Settings.Default.ConnectionString, Path.Combine(path, "Member.accdb")
                , Environment.CurrentDirectory);
            string ID = tbID.Text;
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
                            tbNamaPeminjam.Text = read["Nama"].ToString();
                        }
                    }
                    catch
                    {
                        tbNamaPeminjam.Text = "";
                    }
                }
            }
        }
        //Ini method pas kolom kode buku diisi
        private void TbKodeBuku_TextChanged(object sender, EventArgs e)
        {
            string isbn = tbKodeBuku.Text;
            CekBuku(isbn);
        }
        //ini buat ngecek buku yang dipinjem ada apa ngga, kalo ada data2 bukunya ditampilkan ke layar
        private void CekBuku(string isbn)
        {
            String path = Path.Combine(pathNow, @"..\..\");
            string connectionString3 = string.Format(Properties.Settings.Default.ConnectionString3
                , Path.Combine(path, "TambahBuku.accdb"), Environment.CurrentDirectory);
            string strSql = "SELECT * FROM TambahBuku Member WHERE ISBN='" + isbn + "'";
            using (OleDbConnection connection = new OleDbConnection(connectionString3))
            using (OleDbCommand cmd = connection.CreateCommand())
            {
                cmd.CommandText = strSql;
                try
                {
                    cmd.Parameters.AddWithValue("isbn", isbn);
                }
                catch { }
                connection.Open();
                {
                    OleDbDataReader read;
                    try
                    {
                        read = cmd.ExecuteReader();
                        if (read.Read())
                        {
                            tbStok.Text = read["Stock"].ToString();
                            tbNamaBuku.Text = read["Judul"].ToString();
                            tbPenulisBuku.Text = read["Penulis"].ToString();
                        }
                        else
                        {
                            tbStok.Text = "";
                            tbNamaBuku.Text = "";
                            tbPenulisBuku.Text = "";                       }
                    }
                    catch
                    {
                        tbStok.Text = "";
                        tbNamaBuku.Text = "";
                        tbPenulisBuku.Text = "";
                    }
                }
            }
        }
        //Ini buat nambah data ke database
        private void MinjemBos()
        {
            String path = Path.Combine(pathNow, @"..\..\");
            string connectionString2 = string.Format(Properties.Settings.Default.ConnectionString2, Path.Combine(path, "BukuPinjaman.accdb")
                , Environment.CurrentDirectory);
            string connectionString3 = string.Format(Properties.Settings.Default.ConnectionString3, Path.Combine(path, "TambahBuku.accdb")
                , Environment.CurrentDirectory);

            string ID = tbID.Text;
            string Nama_Peminjam = tbNamaPeminjam.Text;
            string ISBN = tbKodeBuku.Text;
            string Judul = tbNamaBuku.Text;
            string Penulis = tbPenulisBuku.Text;
            string jumlahPinjam = tbPinjam.Text;
            int stok = Convert.ToInt32(tbStok.Text);
            DateTime tanggalDari = dtpDari.Value;
            DateTime tanggalSampai = dtpSampai.Value;
            int sisa = stok - Convert.ToInt32(jumlahPinjam);
            if (CekAdaApaNgga(ID) && CekAdaApaNgga(sisa))
            {
                string insertSQL2 = string.Format(Properties.Settings.Default.InsertSQL2, ID, Nama_Peminjam, ISBN, Judul, Penulis, tanggalDari, tanggalSampai, jumlahPinjam);
                using (OleDbConnection connection = new OleDbConnection(connectionString2))
                {
                    // The insertSQL string contains a SQL statement that
                    // inserts a new row in the source table.
                    OleDbCommand command = new OleDbCommand(insertSQL2);

                    // Set the Connection to the new OleDbConnection.
                    command.Connection = connection;

                    // Open the connection and execute the insert command.
                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        MessageBox.Show("Kelar bosq");
                        connection.Close();
                    }
                    /*SqlConnection con = new SqlConnection();
                    SqlCommand cmd = new SqlCommand("sp_insert", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Id", tbID.Text);
                    cmd.Parameters.AddWithValue("@Nama", tbNamaPeminjam.Text);
                    cmd.Parameters.AddWithValue("@Kode_Buku", tbKodeBuku.Text);
                    cmd.Parameters.AddWithValue("@Nama_Buku", tbNamaBuku.Text);
                    cmd.Parameters.AddWithValue("@Batas_Peminjaman", dtpSampai.Text);
                    con.Open();
                    int i = cmd.ExecuteNonQuery();

                    con.Close();

                    if (i != 0)
                    {
                        MessageBox.Show(i + "Data Saved");
                    }*/
                }
                string updateSql = "UPDATE TambahBuku SET Stock =" + sisa + " WHERE ISBN = '" + ISBN + "'";
                using (OleDbConnection connection = new OleDbConnection(connectionString3))
                using (OleDbCommand cmd = connection.CreateCommand())
                {
                    cmd.CommandText = updateSql;
                    cmd.Parameters.AddWithValue("Stock", sisa);
                    cmd.Connection = connection;
                    connection.Open();
                    {
                        OleDbDataReader read = cmd.ExecuteReader();
                    }
                }
            }
            else if (!CekAdaApaNgga(ID))
            {
                MessageBox.Show("Member dengan ID tersebut sepertinya tidak ada..");
                DialogResult dialogResult = MessageBox.Show("Mau daftar menjadi member?", "Tambah member?", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    LogIn logIn = new LogIn();
                    logIn.tm.Close();
                    TambahMember tm = new TambahMember(Nama_Peminjam);
                    tm.Show();
                    this.Visible = false;
                }
                if (dialogResult == DialogResult.No)
                {
                    MessageBox.Show("Semua memang butuh waktu.");
                }
            }
            else if (!CekAdaApaNgga(sisa))
            {
                MessageBox.Show("Bukunya kurang bos, itu yang diserahkan buku siapa tu?");
            }
        }
        //ngecek ada nggak sih member dengan id yang dituliskan
        private bool CekAdaApaNgga(string ID)
        {
            String path = Path.Combine(pathNow, @"..\..\");
            string strSql = "SELECT count(*) FROM Member WHERE ID = " + ID;
            string connectionString = string.Format(Properties.Settings.Default.ConnectionString, Path.Combine(path, "Member.accdb")
                , Environment.CurrentDirectory);
            OleDbConnection conn = new OleDbConnection(connectionString);
            OleDbCommand cmd = new OleDbCommand(strSql, conn);
            conn.Open();
            int count = (int)cmd.ExecuteScalar();
            if (count > 0)
                return true;
            else
                return false;
        }
        //kalo ini ngecek bukunya ada stok apa ngga
        //ini polymorphism
        private bool CekAdaApaNgga(int stock)
        {
            if (stock >= 0)
                return true;
            else
                return false;
        }
        //Ini yang terjadi pas button pinjam diklik, dia bakal manggil method "MinjemBos()"
        private void btnPinjam_Click(object sender, EventArgs e)
        {
            if (tbID.Text != "" && tbNamaPeminjam.Text != "" && tbKodeBuku.Text != "" && tbNamaBuku.Text != "" && tbPenulisBuku.Text != "")
            {
                MinjemBos();
            }
            else
                MessageBox.Show("Isi semua dulu lahh!! vocvocvocvocvoc");
            bukuPinjamanTableAdapter.Fill(bukuPinjamanDataSet.BukuPinjaman);
        }
        private void Pinjaman_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bukuPinjamanDataSet.BukuPinjaman' table. You can move, or remove it, as needed.
            this.bukuPinjamanTableAdapter.Fill(this.bukuPinjamanDataSet.BukuPinjaman);
        }
        private void btnHU_Click(object sender, EventArgs e)
        {
            LogIn logIn = new LogIn();
            logIn.form.Visible = true;
            this.Visible = false;
        }

        private void btnPengembalian_Click(object sender, EventArgs e)
        {
            LogIn logIn = new LogIn();
            logIn.kembali.Visible = true;
            this.Visible = false;
        }

        private void btnMB_Click(object sender, EventArgs e)
        {
            LogIn logIn = new LogIn();
            logIn.tm.Visible = true;
            this.Visible = false;
        }

        private void BtnTambahBuku_Click(object sender, EventArgs e)
        {
            TambahBuku tb = new TambahBuku();
            tb.Visible = true;
            this.Visible = false;
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            LogIn logIn = new LogIn();
            logIn.Visible = true;
            this.Visible = false;
        }      
    }
}
