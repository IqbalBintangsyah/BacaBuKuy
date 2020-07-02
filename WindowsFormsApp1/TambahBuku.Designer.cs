namespace WindowsFormsApp1
{
    partial class TambahBuku
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TambahBuku));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnPower = new System.Windows.Forms.PictureBox();
            this.btnPengembalian = new System.Windows.Forms.Button();
            this.btnPeminjaman = new System.Windows.Forms.Button();
            this.btnHU = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnTambahBuku = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tbISBN = new System.Windows.Forms.TextBox();
            this.tbJudul = new System.Windows.Forms.TextBox();
            this.tbPenulis = new System.Windows.Forms.TextBox();
            this.tbPenerbit = new System.Windows.Forms.TextBox();
            this.tbStock = new System.Windows.Forms.TextBox();
            this.btnTambahBaru = new System.Windows.Forms.Button();
            this.btnDaftarBuku = new System.Windows.Forms.Button();
            this.btnCari = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnPower)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.btnPower);
            this.panel1.Controls.Add(this.btnPengembalian);
            this.panel1.Controls.Add(this.btnPeminjaman);
            this.panel1.Controls.Add(this.btnHU);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.btnTambahBuku);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(189, 469);
            this.panel1.TabIndex = 23;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Maroon;
            this.panel4.Location = new System.Drawing.Point(0, 255);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(13, 46);
            this.panel4.TabIndex = 25;
            // 
            // btnPower
            // 
            this.btnPower.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPower.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnPower.Image = ((System.Drawing.Image)(resources.GetObject("btnPower.Image")));
            this.btnPower.Location = new System.Drawing.Point(69, 406);
            this.btnPower.Margin = new System.Windows.Forms.Padding(4);
            this.btnPower.Name = "btnPower";
            this.btnPower.Size = new System.Drawing.Size(48, 44);
            this.btnPower.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnPower.TabIndex = 3;
            this.btnPower.TabStop = false;
            this.btnPower.Click += new System.EventHandler(this.BtnPower_Click);
            // 
            // btnPengembalian
            // 
            this.btnPengembalian.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnPengembalian.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btnPengembalian.FlatAppearance.BorderSize = 0;
            this.btnPengembalian.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPengembalian.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPengembalian.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnPengembalian.Location = new System.Drawing.Point(-3, 164);
            this.btnPengembalian.Margin = new System.Windows.Forms.Padding(4);
            this.btnPengembalian.Name = "btnPengembalian";
            this.btnPengembalian.Size = new System.Drawing.Size(189, 47);
            this.btnPengembalian.TabIndex = 2;
            this.btnPengembalian.Text = "Pengembalian";
            this.btnPengembalian.UseVisualStyleBackColor = false;
            this.btnPengembalian.Click += new System.EventHandler(this.BtnPengembalian_Click);
            // 
            // btnPeminjaman
            // 
            this.btnPeminjaman.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnPeminjaman.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btnPeminjaman.FlatAppearance.BorderSize = 0;
            this.btnPeminjaman.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPeminjaman.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPeminjaman.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnPeminjaman.Location = new System.Drawing.Point(-3, 122);
            this.btnPeminjaman.Margin = new System.Windows.Forms.Padding(4);
            this.btnPeminjaman.Name = "btnPeminjaman";
            this.btnPeminjaman.Size = new System.Drawing.Size(189, 47);
            this.btnPeminjaman.TabIndex = 1;
            this.btnPeminjaman.Text = "Peminjaman\r";
            this.btnPeminjaman.UseVisualStyleBackColor = false;
            this.btnPeminjaman.Click += new System.EventHandler(this.BtnPeminjaman_Click);
            // 
            // btnHU
            // 
            this.btnHU.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnHU.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btnHU.FlatAppearance.BorderSize = 0;
            this.btnHU.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHU.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHU.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnHU.Location = new System.Drawing.Point(-3, 80);
            this.btnHU.Margin = new System.Windows.Forms.Padding(4);
            this.btnHU.Name = "btnHU";
            this.btnHU.Size = new System.Drawing.Size(189, 47);
            this.btnHU.TabIndex = 0;
            this.btnHU.Text = "Halaman Utama";
            this.btnHU.UseVisualStyleBackColor = false;
            this.btnHU.Click += new System.EventHandler(this.BtnHU_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button5.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(69, 406);
            this.button5.Margin = new System.Windows.Forms.Padding(4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(48, 44);
            this.button5.TabIndex = 24;
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button4.Location = new System.Drawing.Point(-3, 208);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(189, 47);
            this.button4.TabIndex = 5;
            this.button4.Text = "Member Baru";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.BtnTambahMember_Click);
            // 
            // btnTambahBuku
            // 
            this.btnTambahBuku.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnTambahBuku.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btnTambahBuku.FlatAppearance.BorderSize = 0;
            this.btnTambahBuku.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTambahBuku.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTambahBuku.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnTambahBuku.Location = new System.Drawing.Point(-3, 255);
            this.btnTambahBuku.Margin = new System.Windows.Forms.Padding(4);
            this.btnTambahBuku.Name = "btnTambahBuku";
            this.btnTambahBuku.Size = new System.Drawing.Size(189, 47);
            this.btnTambahBuku.TabIndex = 26;
            this.btnTambahBuku.Text = "Tambah Buku";
            this.btnTambahBuku.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Maroon;
            this.panel2.Location = new System.Drawing.Point(189, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(631, 12);
            this.panel2.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(213, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 19);
            this.label1.TabIndex = 25;
            this.label1.Text = "ISBN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(213, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 19);
            this.label2.TabIndex = 26;
            this.label2.Text = "Judul";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(213, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 19);
            this.label3.TabIndex = 27;
            this.label3.Text = "Penulis";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(213, 252);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 19);
            this.label4.TabIndex = 28;
            this.label4.Text = "Penerbit";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(215, 295);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 19);
            this.label5.TabIndex = 29;
            this.label5.Text = "Stock";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(315, 98);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(14, 19);
            this.label8.TabIndex = 30;
            this.label8.Text = ":";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(315, 162);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 19);
            this.label6.TabIndex = 31;
            this.label6.Text = ":";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(315, 207);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(14, 19);
            this.label7.TabIndex = 32;
            this.label7.Text = ":";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(315, 252);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(14, 19);
            this.label9.TabIndex = 33;
            this.label9.Text = ":";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(315, 295);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(14, 19);
            this.label10.TabIndex = 34;
            this.label10.Text = ":";
            // 
            // tbISBN
            // 
            this.tbISBN.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbISBN.Location = new System.Drawing.Point(337, 91);
            this.tbISBN.Margin = new System.Windows.Forms.Padding(4);
            this.tbISBN.Name = "tbISBN";
            this.tbISBN.Size = new System.Drawing.Size(380, 26);
            this.tbISBN.TabIndex = 35;
            this.tbISBN.TextChanged += new System.EventHandler(this.TbISBN_TextChanged);
            // 
            // tbJudul
            // 
            this.tbJudul.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbJudul.Location = new System.Drawing.Point(337, 159);
            this.tbJudul.Margin = new System.Windows.Forms.Padding(4);
            this.tbJudul.Name = "tbJudul";
            this.tbJudul.Size = new System.Drawing.Size(380, 26);
            this.tbJudul.TabIndex = 36;
            // 
            // tbPenulis
            // 
            this.tbPenulis.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPenulis.Location = new System.Drawing.Point(337, 207);
            this.tbPenulis.Margin = new System.Windows.Forms.Padding(4);
            this.tbPenulis.Name = "tbPenulis";
            this.tbPenulis.Size = new System.Drawing.Size(380, 26);
            this.tbPenulis.TabIndex = 37;
            // 
            // tbPenerbit
            // 
            this.tbPenerbit.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPenerbit.Location = new System.Drawing.Point(337, 249);
            this.tbPenerbit.Margin = new System.Windows.Forms.Padding(4);
            this.tbPenerbit.Name = "tbPenerbit";
            this.tbPenerbit.Size = new System.Drawing.Size(380, 26);
            this.tbPenerbit.TabIndex = 38;
            // 
            // tbStock
            // 
            this.tbStock.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbStock.Location = new System.Drawing.Point(337, 292);
            this.tbStock.Margin = new System.Windows.Forms.Padding(4);
            this.tbStock.Name = "tbStock";
            this.tbStock.Size = new System.Drawing.Size(380, 26);
            this.tbStock.TabIndex = 39;
            // 
            // btnTambahBaru
            // 
            this.btnTambahBaru.BackColor = System.Drawing.Color.Maroon;
            this.btnTambahBaru.FlatAppearance.BorderSize = 0;
            this.btnTambahBaru.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTambahBaru.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTambahBaru.ForeColor = System.Drawing.Color.White;
            this.btnTambahBaru.Location = new System.Drawing.Point(337, 366);
            this.btnTambahBaru.Margin = new System.Windows.Forms.Padding(4);
            this.btnTambahBaru.Name = "btnTambahBaru";
            this.btnTambahBaru.Size = new System.Drawing.Size(171, 48);
            this.btnTambahBaru.TabIndex = 47;
            this.btnTambahBaru.Text = "TAMBAH BUKU";
            this.btnTambahBaru.UseVisualStyleBackColor = false;
            this.btnTambahBaru.Click += new System.EventHandler(this.BtnTambahBaru_Click);
            // 
            // btnDaftarBuku
            // 
            this.btnDaftarBuku.BackColor = System.Drawing.Color.Maroon;
            this.btnDaftarBuku.FlatAppearance.BorderSize = 0;
            this.btnDaftarBuku.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDaftarBuku.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDaftarBuku.ForeColor = System.Drawing.Color.White;
            this.btnDaftarBuku.Location = new System.Drawing.Point(548, 366);
            this.btnDaftarBuku.Margin = new System.Windows.Forms.Padding(4);
            this.btnDaftarBuku.Name = "btnDaftarBuku";
            this.btnDaftarBuku.Size = new System.Drawing.Size(171, 48);
            this.btnDaftarBuku.TabIndex = 48;
            this.btnDaftarBuku.Text = "DAFTAR BUKU";
            this.btnDaftarBuku.UseVisualStyleBackColor = false;
            // 
            // btnCari
            // 
            this.btnCari.Location = new System.Drawing.Point(337, 124);
            this.btnCari.Name = "btnCari";
            this.btnCari.Size = new System.Drawing.Size(93, 28);
            this.btnCari.TabIndex = 49;
            this.btnCari.Text = "Cari";
            this.btnCari.UseVisualStyleBackColor = true;
            this.btnCari.Click += new System.EventHandler(this.BtnCari_Click);
            // 
            // TambahBuku
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(820, 466);
            this.Controls.Add(this.btnCari);
            this.Controls.Add(this.btnDaftarBuku);
            this.Controls.Add(this.btnTambahBaru);
            this.Controls.Add(this.tbStock);
            this.Controls.Add(this.tbPenerbit);
            this.Controls.Add(this.tbPenulis);
            this.Controls.Add(this.tbJudul);
            this.Controls.Add(this.tbISBN);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "TambahBuku";
            this.Text = "TambahBuku";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnPower)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox btnPower;
        private System.Windows.Forms.Button btnPengembalian;
        private System.Windows.Forms.Button btnPeminjaman;
        private System.Windows.Forms.Button btnHU;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnTambahBuku;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbISBN;
        private System.Windows.Forms.TextBox tbJudul;
        private System.Windows.Forms.TextBox tbPenulis;
        private System.Windows.Forms.TextBox tbPenerbit;
        private System.Windows.Forms.TextBox tbStock;
        private System.Windows.Forms.Button btnTambahBaru;
        private System.Windows.Forms.Button btnDaftarBuku;
        private System.Windows.Forms.Button btnCari;
    }
}