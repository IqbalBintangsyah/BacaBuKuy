namespace WindowsFormsApp1
{
    partial class HalamanUtama
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HalamanUtama));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnTambahBuku = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btPengembalian = new System.Windows.Forms.Button();
            this.btPeminjaman = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.btMemberBaru = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.btnTambahBuku);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btPengembalian);
            this.panel1.Controls.Add(this.btPeminjaman);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.btMemberBaru);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(142, 381);
            this.panel1.TabIndex = 23;
            // 
            // btnTambahBuku
            // 
            this.btnTambahBuku.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnTambahBuku.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btnTambahBuku.FlatAppearance.BorderSize = 0;
            this.btnTambahBuku.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTambahBuku.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTambahBuku.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnTambahBuku.Location = new System.Drawing.Point(-2, 206);
            this.btnTambahBuku.Name = "btnTambahBuku";
            this.btnTambahBuku.Size = new System.Drawing.Size(142, 38);
            this.btnTambahBuku.TabIndex = 27;
            this.btnTambahBuku.Text = "Tambah Buku";
            this.btnTambahBuku.UseVisualStyleBackColor = false;
            this.btnTambahBuku.Click += new System.EventHandler(this.BtnTambahBuku_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Maroon;
            this.panel4.Location = new System.Drawing.Point(0, 65);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 34);
            this.panel4.TabIndex = 6;
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
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // btPengembalian
            // 
            this.btPengembalian.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btPengembalian.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btPengembalian.FlatAppearance.BorderSize = 0;
            this.btPengembalian.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btPengembalian.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPengembalian.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btPengembalian.Location = new System.Drawing.Point(-2, 133);
            this.btPengembalian.Name = "btPengembalian";
            this.btPengembalian.Size = new System.Drawing.Size(142, 38);
            this.btPengembalian.TabIndex = 2;
            this.btPengembalian.Text = "Pengembalian";
            this.btPengembalian.UseVisualStyleBackColor = false;
            this.btPengembalian.Click += new System.EventHandler(this.btPengembalian_Click);
            // 
            // btPeminjaman
            // 
            this.btPeminjaman.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btPeminjaman.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btPeminjaman.FlatAppearance.BorderSize = 0;
            this.btPeminjaman.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btPeminjaman.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPeminjaman.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btPeminjaman.Location = new System.Drawing.Point(-2, 99);
            this.btPeminjaman.Name = "btPeminjaman";
            this.btPeminjaman.Size = new System.Drawing.Size(142, 38);
            this.btPeminjaman.TabIndex = 1;
            this.btPeminjaman.Text = "Peminjaman\r";
            this.btPeminjaman.UseVisualStyleBackColor = false;
            this.btPeminjaman.Click += new System.EventHandler(this.btPeminjaman_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button1.Location = new System.Drawing.Point(-2, 65);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 38);
            this.button1.TabIndex = 0;
            this.button1.Text = "Halaman Utama";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button5.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(52, 330);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(36, 36);
            this.button5.TabIndex = 24;
            this.button5.UseVisualStyleBackColor = false;
            // 
            // btMemberBaru
            // 
            this.btMemberBaru.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btMemberBaru.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btMemberBaru.FlatAppearance.BorderSize = 0;
            this.btMemberBaru.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btMemberBaru.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMemberBaru.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btMemberBaru.Location = new System.Drawing.Point(-2, 169);
            this.btMemberBaru.Name = "btMemberBaru";
            this.btMemberBaru.Size = new System.Drawing.Size(142, 38);
            this.btMemberBaru.TabIndex = 5;
            this.btMemberBaru.Text = "Member Baru";
            this.btMemberBaru.UseVisualStyleBackColor = false;
            this.btMemberBaru.Click += new System.EventHandler(this.btMemberBaru_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Maroon;
            this.panel2.Location = new System.Drawing.Point(142, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(473, 10);
            this.panel2.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(248, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 62);
            this.label1.TabIndex = 25;
            this.label1.Text = "Selamat Datang!,\r\nSelamat Berkarya!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(159, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(408, 64);
            this.label2.TabIndex = 26;
            this.label2.Text = "“In the case of good books, the point is not to see how many of them \r\nyou can ge" +
    "t through, but rather how many can get through to you.”\r\n – Mortimer J. Adler\r\n\r" +
    "\n";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // HalamanUtama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(613, 380);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HalamanUtama";
            this.Text = "\\";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btPengembalian;
        private System.Windows.Forms.Button btPeminjaman;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btMemberBaru;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTambahBuku;
    }
}