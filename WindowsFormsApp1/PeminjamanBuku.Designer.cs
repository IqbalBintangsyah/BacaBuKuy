namespace WindowsFormsApp1
{
    partial class PeminjamanBuku
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PeminjamanBuku));
            this.lblQuote = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbID = new System.Windows.Forms.TextBox();
            this.tbNamaPeminjam = new System.Windows.Forms.TextBox();
            this.tbNamaBuku = new System.Windows.Forms.TextBox();
            this.tbKodeBuku = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnTambahBuku = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button6 = new System.Windows.Forms.Button();
            this.btnMB = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnPengembalian = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnHU = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tbPenulisBuku = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnPinjam = new System.Windows.Forms.Button();
            this.dtpSampai = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpDari = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.pinjamanDataSet = new WindowsFormsApp1.PinjamanDataSet();
            this.pinjamanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pinjamanTableAdapter = new WindowsFormsApp1.PinjamanDataSetTableAdapters.PinjamanTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp1.PinjamanDataSetTableAdapters.TableAdapterManager();
            this.bukuPinjamanDataSet = new WindowsFormsApp1.BukuPinjamanDataSet();
            this.bukuPinjamanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bukuPinjamanTableAdapter = new WindowsFormsApp1.BukuPinjamanDataSetTableAdapters.BukuPinjamanTableAdapter();
            this.tableAdapterManager1 = new WindowsFormsApp1.BukuPinjamanDataSetTableAdapters.TableAdapterManager();
            this.label16 = new System.Windows.Forms.Label();
            this.tbPinjam = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.tbStok = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pinjamanDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pinjamanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bukuPinjamanDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bukuPinjamanBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblQuote
            // 
            this.lblQuote.AutoSize = true;
            this.lblQuote.BackColor = System.Drawing.Color.White;
            this.lblQuote.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuote.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblQuote.Location = new System.Drawing.Point(167, 296);
            this.lblQuote.Name = "lblQuote";
            this.lblQuote.Size = new System.Drawing.Size(256, 31);
            this.lblQuote.TabIndex = 0;
            this.lblQuote.Text = "Buku Jendela Dunia";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(160, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Judul Buku";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(160, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nama Peminjam";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(160, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "ID Peminjam";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(160, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Kode Buku";
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(273, 43);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(258, 22);
            this.tbID.TabIndex = 10;
            this.tbID.TextChanged += new System.EventHandler(this.TbID_TextChanged);
            // 
            // tbNamaPeminjam
            // 
            this.tbNamaPeminjam.Location = new System.Drawing.Point(273, 73);
            this.tbNamaPeminjam.Name = "tbNamaPeminjam";
            this.tbNamaPeminjam.Size = new System.Drawing.Size(258, 22);
            this.tbNamaPeminjam.TabIndex = 11;
            // 
            // tbNamaBuku
            // 
            this.tbNamaBuku.Location = new System.Drawing.Point(273, 165);
            this.tbNamaBuku.Name = "tbNamaBuku";
            this.tbNamaBuku.Size = new System.Drawing.Size(258, 22);
            this.tbNamaBuku.TabIndex = 12;
            // 
            // tbKodeBuku
            // 
            this.tbKodeBuku.Location = new System.Drawing.Point(273, 104);
            this.tbKodeBuku.Name = "tbKodeBuku";
            this.tbKodeBuku.Size = new System.Drawing.Size(258, 22);
            this.tbKodeBuku.TabIndex = 13;
            this.tbKodeBuku.TextChanged += new System.EventHandler(this.TbKodeBuku_TextChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Maroon;
            this.panel2.Location = new System.Drawing.Point(142, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(473, 10);
            this.panel2.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(258, 46);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(12, 16);
            this.label8.TabIndex = 19;
            this.label8.Text = ":";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label9.Location = new System.Drawing.Point(258, 76);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(12, 16);
            this.label9.TabIndex = 20;
            this.label9.Text = ":";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label10.Location = new System.Drawing.Point(258, 107);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(12, 16);
            this.label10.TabIndex = 21;
            this.label10.Text = ":";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label11.Location = new System.Drawing.Point(258, 168);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(12, 16);
            this.label11.TabIndex = 22;
            this.label11.Text = ":";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.btnTambahBuku);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.btnMB);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.btnPengembalian);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.btnHU);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(142, 381);
            this.panel1.TabIndex = 24;
            // 
            // btnTambahBuku
            // 
            this.btnTambahBuku.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnTambahBuku.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btnTambahBuku.FlatAppearance.BorderSize = 0;
            this.btnTambahBuku.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTambahBuku.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTambahBuku.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnTambahBuku.Location = new System.Drawing.Point(-2, 204);
            this.btnTambahBuku.Margin = new System.Windows.Forms.Padding(4);
            this.btnTambahBuku.Name = "btnTambahBuku";
            this.btnTambahBuku.Size = new System.Drawing.Size(144, 47);
            this.btnTambahBuku.TabIndex = 40;
            this.btnTambahBuku.Text = "Tambah Buku";
            this.btnTambahBuku.UseVisualStyleBackColor = false;
            this.btnTambahBuku.Click += new System.EventHandler(this.BtnTambahBuku_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(52, 330);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 36);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button6.Location = new System.Drawing.Point(52, 330);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(36, 36);
            this.button6.TabIndex = 26;
            this.button6.UseVisualStyleBackColor = false;
            // 
            // btnMB
            // 
            this.btnMB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnMB.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btnMB.FlatAppearance.BorderSize = 0;
            this.btnMB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMB.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMB.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnMB.Location = new System.Drawing.Point(-2, 169);
            this.btnMB.Name = "btnMB";
            this.btnMB.Size = new System.Drawing.Size(142, 38);
            this.btnMB.TabIndex = 5;
            this.btnMB.Text = "Member Baru";
            this.btnMB.UseVisualStyleBackColor = false;
            this.btnMB.Click += new System.EventHandler(this.btnMB_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Maroon;
            this.panel3.Location = new System.Drawing.Point(0, 169);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(8, 38);
            this.panel3.TabIndex = 4;
            // 
            // btnPengembalian
            // 
            this.btnPengembalian.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnPengembalian.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btnPengembalian.FlatAppearance.BorderSize = 0;
            this.btnPengembalian.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPengembalian.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPengembalian.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnPengembalian.Location = new System.Drawing.Point(-2, 133);
            this.btnPengembalian.Name = "btnPengembalian";
            this.btnPengembalian.Size = new System.Drawing.Size(142, 38);
            this.btnPengembalian.TabIndex = 2;
            this.btnPengembalian.Text = "Pengembalian";
            this.btnPengembalian.UseVisualStyleBackColor = false;
            this.btnPengembalian.Click += new System.EventHandler(this.btnPengembalian_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button2.Location = new System.Drawing.Point(-2, 99);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(142, 36);
            this.button2.TabIndex = 1;
            this.button2.Text = "Peminjaman\r";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // btnHU
            // 
            this.btnHU.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnHU.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btnHU.FlatAppearance.BorderSize = 0;
            this.btnHU.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHU.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHU.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnHU.Location = new System.Drawing.Point(-2, 65);
            this.btnHU.Name = "btnHU";
            this.btnHU.Size = new System.Drawing.Size(142, 38);
            this.btnHU.TabIndex = 0;
            this.btnHU.Text = "Halaman Utama";
            this.btnHU.UseVisualStyleBackColor = false;
            this.btnHU.Click += new System.EventHandler(this.btnHU_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Maroon;
            this.panel4.Location = new System.Drawing.Point(0, 98);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 34);
            this.panel4.TabIndex = 25;
            // 
            // tbPenulisBuku
            // 
            this.tbPenulisBuku.Location = new System.Drawing.Point(273, 196);
            this.tbPenulisBuku.Name = "tbPenulisBuku";
            this.tbPenulisBuku.Size = new System.Drawing.Size(258, 22);
            this.tbPenulisBuku.TabIndex = 39;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label14.Location = new System.Drawing.Point(258, 199);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(12, 16);
            this.label14.TabIndex = 38;
            this.label14.Text = ":";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.White;
            this.label13.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label13.Location = new System.Drawing.Point(160, 199);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(85, 16);
            this.label13.TabIndex = 37;
            this.label13.Text = "Penulis Buku";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label12.Location = new System.Drawing.Point(258, 230);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(12, 16);
            this.label12.TabIndex = 36;
            this.label12.Text = ":";
            // 
            // btnPinjam
            // 
            this.btnPinjam.BackColor = System.Drawing.Color.Maroon;
            this.btnPinjam.FlatAppearance.BorderSize = 0;
            this.btnPinjam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPinjam.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPinjam.ForeColor = System.Drawing.Color.White;
            this.btnPinjam.Location = new System.Drawing.Point(429, 292);
            this.btnPinjam.Name = "btnPinjam";
            this.btnPinjam.Size = new System.Drawing.Size(102, 39);
            this.btnPinjam.TabIndex = 35;
            this.btnPinjam.Text = "Pinjam";
            this.btnPinjam.UseVisualStyleBackColor = false;
            this.btnPinjam.Click += new System.EventHandler(this.btnPinjam_Click);
            // 
            // dtpSampai
            // 
            this.dtpSampai.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpSampai.Location = new System.Drawing.Point(396, 251);
            this.dtpSampai.Name = "dtpSampai";
            this.dtpSampai.Size = new System.Drawing.Size(135, 22);
            this.dtpSampai.TabIndex = 34;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(338, 254);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 16);
            this.label7.TabIndex = 32;
            this.label7.Text = "Sampai";
            // 
            // dtpDari
            // 
            this.dtpDari.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDari.Location = new System.Drawing.Point(197, 251);
            this.dtpDari.Name = "dtpDari";
            this.dtpDari.Size = new System.Drawing.Size(135, 22);
            this.dtpDari.TabIndex = 33;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(160, 254);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 16);
            this.label6.TabIndex = 31;
            this.label6.Text = "Dari";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(160, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 16);
            this.label5.TabIndex = 30;
            this.label5.Text = "Tanggal Pinjam";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.White;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label15.Location = new System.Drawing.Point(167, 296);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(256, 31);
            this.label15.TabIndex = 29;
            this.label15.Text = "Buku Jendela Dunia";
            // 
            // pinjamanDataSet
            // 
            this.pinjamanDataSet.DataSetName = "PinjamanDataSet";
            this.pinjamanDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pinjamanBindingSource
            // 
            this.pinjamanBindingSource.DataMember = "Pinjaman";
            this.pinjamanBindingSource.DataSource = this.pinjamanDataSet;
            // 
            // pinjamanTableAdapter
            // 
            this.pinjamanTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.PinjamanTableAdapter = this.pinjamanTableAdapter;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp1.PinjamanDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // bukuPinjamanDataSet
            // 
            this.bukuPinjamanDataSet.DataSetName = "BukuPinjamanDataSet";
            this.bukuPinjamanDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bukuPinjamanBindingSource
            // 
            this.bukuPinjamanBindingSource.DataMember = "BukuPinjaman";
            this.bukuPinjamanBindingSource.DataSource = this.bukuPinjamanDataSet;
            // 
            // bukuPinjamanTableAdapter
            // 
            this.bukuPinjamanTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.BukuPinjamanTableAdapter = this.bukuPinjamanTableAdapter;
            this.tableAdapterManager1.UpdateOrder = WindowsFormsApp1.BukuPinjamanDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.White;
            this.label16.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label16.Location = new System.Drawing.Point(383, 136);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(48, 16);
            this.label16.TabIndex = 40;
            this.label16.Text = "Pinjam";
            // 
            // tbPinjam
            // 
            this.tbPinjam.Location = new System.Drawing.Point(455, 133);
            this.tbPinjam.Name = "tbPinjam";
            this.tbPinjam.Size = new System.Drawing.Size(76, 22);
            this.tbPinjam.TabIndex = 41;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label17.Location = new System.Drawing.Point(437, 136);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(12, 16);
            this.label17.TabIndex = 42;
            this.label17.Text = ":";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label18.Location = new System.Drawing.Point(258, 137);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(12, 16);
            this.label18.TabIndex = 45;
            this.label18.Text = ":";
            // 
            // tbStok
            // 
            this.tbStok.Location = new System.Drawing.Point(273, 135);
            this.tbStok.Name = "tbStok";
            this.tbStok.Size = new System.Drawing.Size(104, 22);
            this.tbStok.TabIndex = 44;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.White;
            this.label19.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label19.Location = new System.Drawing.Point(160, 138);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(35, 16);
            this.label19.TabIndex = 43;
            this.label19.Text = "Stok";
            // 
            // PeminjamanBuku
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(616, 379);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.tbStok);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.tbPinjam);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.tbPenulisBuku);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnPinjam);
            this.Controls.Add(this.dtpSampai);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtpDari);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblQuote);
            this.Controls.Add(this.tbKodeBuku);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbNamaBuku);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbNamaPeminjam);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.label2);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "PeminjamanBuku";
            this.Text = "Peminjaman Buku";
            this.Load += new System.EventHandler(this.Pinjaman_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pinjamanDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pinjamanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bukuPinjamanDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bukuPinjamanBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQuote;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.TextBox tbNamaPeminjam;
        private System.Windows.Forms.TextBox tbNamaBuku;
        private System.Windows.Forms.TextBox tbKodeBuku;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnMB;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnPengembalian;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnHU;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox tbPenulisBuku;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnPinjam;
        private System.Windows.Forms.DateTimePicker dtpSampai;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpDari;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label15;
        private PinjamanDataSet pinjamanDataSet;
        private System.Windows.Forms.BindingSource pinjamanBindingSource;
        private PinjamanDataSetTableAdapters.PinjamanTableAdapter pinjamanTableAdapter;
        private PinjamanDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private BukuPinjamanDataSet bukuPinjamanDataSet;
        private System.Windows.Forms.BindingSource bukuPinjamanBindingSource;
        private BukuPinjamanDataSetTableAdapters.BukuPinjamanTableAdapter bukuPinjamanTableAdapter;
        private BukuPinjamanDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.Button btnTambahBuku;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox tbPinjam;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox tbStok;
        private System.Windows.Forms.Label label19;
    }
}