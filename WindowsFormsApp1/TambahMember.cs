using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Configuration;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class TambahMember : Form
    {
        private String pathNow = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        //Constructor
        public TambahMember()
        {
            InitializeComponent();
            btnDaftar.Text = "Tambah";
        }
        //Polymorphism Constructor buat pas dipanggil dari Peminjaman Buku biar tbNama langsung keisi
        public TambahMember(string nama)
        {
            InitializeComponent();
            btnDaftar.Text = "Tambah";
            tbNama.Text = nama;
        }
        private void TambahMember_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'memberDataSet.Member' table. You can move, or remove it, as needed.
            this.memberTableAdapter.Fill(this.memberDataSet.Member);
        }
        //Buat ngepass tabel ke form lain --FAIL
        /*public DataGridViewRowCollection GetRow()
        {
            return memberDataGridView.Rows;
        }*/
        public void TambahData()
        {
            String path = Path.Combine(pathNow, @"..\..\");
            string connectionString = string.Format(Properties.Settings.Default.ConnectionString, Path.Combine(path, "Member.accdb"), Environment.CurrentDirectory);

            string Nama = tbNama.Text;
            string Alamat = tbAlamat.Text;
            string No_HP = TbNoHP.Text;
            string Tanggal_Lahir = dtpTanggalLahir.Value.Date.ToString("dd/MM/yyyy");
            string Email = tbEmail.Text;
            string K_Identitas = cbKartuIdentitas.Text;
            string N_Identitas = tbNoKartuIdentitas.Text;

            string insertSQL = string.Format(Properties.Settings.Default.InsertSQL, Nama, Alamat, No_HP, Tanggal_Lahir, Email, K_Identitas, N_Identitas);

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                // The insertSQL string contains an SQL statement that
                // inserts a new row in the source table.
                OleDbCommand command = new OleDbCommand(insertSQL);

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
                    MessageBox.Show("Member anyar sampun ditambahaken.");
                    connection.Close();
                }
            }
            /*{
                using (var db = new DaftarMember())
                {
                    Member newMember = new Member
                    {
                        Nama = tbNama.Text,
                        Alamat = tbAlamat.Text,
                        No_Telp = TbNoHP.Text,
                        Tanggal_Lahir = dtpTanggalLahir.Value.Date,
                        Email = tbEmail.Text,
                        K_Identitas = cbKartuIdentitas.SelectedText,
                        N_Identitas = tbNoKartuIdentitas.Text,
                    };
                    db.Members.Add(newMember);
                    db.SaveChanges();
                    MessageBox.Show("Member baru berhasil ditambahkan!");                    
                }
            }*/
            /*{
                SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = D:\Me!\Program\WindowsFormsApp1\WindowsFormsApp1\Peminjaman.mdf; Integrated Security = True");
                SqlCommand cmd = new SqlCommand("sp_insert", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Nama", tbNama.Text);
                cmd.Parameters.AddWithValue("@Alamat", tbAlamat.Text);
                cmd.Parameters.AddWithValue("@No_Telp", TbNoHP.Text);
                cmd.Parameters.AddWithValue("@Tanggal_Lahir", dtpTanggalLahir.Text);
                cmd.Parameters.AddWithValue("@Email", tbEmail.Text);
                cmd.Parameters.AddWithValue("@K_Identitas", cbKartuIdentitas.Text);
                cmd.Parameters.AddWithValue("@N_Identitas", tbNoKartuIdentitas.Text);
                con.Open();
                int i = cmd.ExecuteNonQuery();

                con.Close();

                if (i != 0)
                {
                    MessageBox.Show(i + "Data Saved");
                }*/

            /*{
                SqlConnection con = new SqlConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Me!\Program\WindowsFormsApp1\WindowsFormsApp1\Member.accdb;Persist Security Info=True");
                SqlCommand cmd = new SqlCommand("INSERT INTO TableMember(Nama, Alamat, No_Telp, Tanggal_Lahir, Email, K_Identitas, N_Identitas) VALUES('{@Nama}', '{@Alamat}', '{@No_Telp}', '{@Tanggal_Lahir}'.'{@Email}'.'{@K_Identitas}', '{@N_Identitas}')")
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("@Nama", tbNama.Text);
                cmd.Parameters.AddWithValue("@Alamat", tbAlamat.Text);
                cmd.Parameters.AddWithValue("@No_Telp", TbNoHP.Text);
                cmd.Parameters.AddWithValue("@Tanggal_Lahir", dtpTanggalLahir.Text);
                cmd.Parameters.AddWithValue("@Email", tbEmail.Text);
                cmd.Parameters.AddWithValue("@K_Identitas", cbKartuIdentitas.Text);
                cmd.Parameters.AddWithValue("@N_Identitas", tbNoKartuIdentitas.Text);
                con.Open();
                int i = cmd.ExecuteNonQuery();
                if (i != 0)
                {
                    MessageBox.Show(i + "Data Saved");
                }
                con.Close();*/



        }        
        private void BtnDaftar_Click(object sender, EventArgs e)
        {
                if (tbNama.Text != "" && tbAlamat.Text != "" && TbNoHP.Text != "" && dtpTanggalLahir.Text != "" &&
        tbEmail.Text != "" && cbKartuIdentitas.Text != "" && tbNoKartuIdentitas.Text != "")
                    TambahData();
                else
                    MessageBox.Show("Seluruh data wajib diisi.");
            memberTableAdapter.Fill(memberDataSet.Member);
        }

        private void MemberBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.memberBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.memberDataSet);

        }
        private void BtnHU_Click(object sender, EventArgs e)
        {
            LogIn logIn = new LogIn();
            logIn.form.Visible = true;
            this.Visible = false;
        }

        private void BtnPeminjaman_Click(object sender, EventArgs e)
        {
            LogIn logIn = new LogIn();
            logIn.pinjam.Visible = true;
            this.Visible = false;
        }

        private void btnPengembalian_Click(object sender, EventArgs e)
        {
            LogIn logIn = new LogIn();
            //logIn.kembali.Visible = true;
            logIn.kembali.Close();
            this.Visible = false;
            Pengembalian pb = new Pengembalian();
            pb.Show();

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
