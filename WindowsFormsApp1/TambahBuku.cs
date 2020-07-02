using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class TambahBuku : Form
    {
        private String pathNow = Environment.CurrentDirectory;
        
        public TambahBuku()
        {
            InitializeComponent();
        }
        public void TambahData()
        {
            String path = Path.Combine(pathNow, @"..\..\");
            string connectionString3 = string.Format(Properties.Settings.Default.ConnectionString3, Path.Combine(path, "TambahBuku.accdb"), Environment.CurrentDirectory);
            OleDbConnection conn = new OleDbConnection(connectionString3);

            string ISBN = tbISBN.Text;
            string Judul = tbJudul.Text;
            string Penerbit = tbPenerbit.Text;
            string Penulis = tbPenulis.Text;
            int Stock = Convert.ToInt32(tbStock.Text);

            OleDbCommand check_User_Name = new OleDbCommand("SELECT COUNT(*) FROM TambahBuku WHERE ISBN='"+tbISBN.Text+"'", conn);
            check_User_Name.Parameters.AddWithValue("@ISBN", tbISBN.Text);
            conn.Open();
            int UserExist = (int)check_User_Name.ExecuteScalar();

            if (UserExist > 0)
            {
                string updateSql = "UPDATE TambahBuku SET Stock = Stock +" + Stock + " WHERE ISBN = '" + ISBN + "'";
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
                MessageBox.Show("Updated bosq");
            }
            else
            {
                string insertSQL = string.Format(Properties.Settings.Default.InsertSQL3, ISBN, Judul, Penulis, Penerbit, Stock);

                using (OleDbConnection connection = new OleDbConnection(connectionString3))
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
                        MessageBox.Show("Buku anyar sampun ditambahaken.");
                        connection.Close();
                    }
                }
            }           
        }
        private void BtnHU_Click(object sender, EventArgs e)
        {
            HalamanUtama form = new HalamanUtama();
            form.Visible = true;
            this.Visible = false;
        }

        private void BtnPeminjaman_Click(object sender, EventArgs e)
        {
            PeminjamanBuku pinjam = new PeminjamanBuku();
            pinjam.Visible = true;
            this.Visible = false;
        }

        private void BtnPengembalian_Click(object sender, EventArgs e)
        {
            Pengembalian kembali = new Pengembalian();
            kembali.Visible = true;
            this.Visible = false;
        }

        private void BtnTambahMember_Click(object sender, EventArgs e)
        {
            TambahMember tm = new TambahMember();
            tm.Visible = true;
            this.Visible = false;
        }

        private void BtnPower_Click(object sender, EventArgs e)
        {
            LogIn logIn = new LogIn();
            logIn.Visible = true;
            this.Visible = false;
        }

        private void BtnCari_Click(object sender, EventArgs e)
        {
            string isbn = tbISBN.Text;
            var output = BookSearch.SearchISBN(isbn);
            MessageBox.Show(isbn);
            try
            {
                Assert.AreEqual(output.Result != null, true);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            var result = output.Result;
            try
            {
                tbJudul.Text = result.VolumeInfo.Title;
            }
            catch
            {
                MessageBox.Show("Tidak ada buku yang ditemukan.");
                tbJudul.Text = "";
            }
            try
            {
                tbPenulis.Text = string.Join(", ", result.VolumeInfo.Authors.ToArray());
            }
            catch
            {
                tbPenulis.Text = "-";
            }
            try
            {
                tbPenerbit.Text = string.Join(", ", result.VolumeInfo.Publisher.ToArray());
            }
            catch
            {
                tbPenerbit.Text= "-";
            }
        }

        private void BtnTambahBaru_Click(object sender, EventArgs e)
        {
            if (tbISBN.Text != "" && tbJudul.Text != "" && tbPenulis.Text != "" && tbPenerbit.Text != "" && tbStock.Text != "")
                TambahData();
            else
                MessageBox.Show("Semua data harus diisi!");
        }

        private void TbISBN_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
