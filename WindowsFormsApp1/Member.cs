namespace WindowsFormsApp1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Member")]
    public partial class Member
        //kelas tidak digunakan
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Nama { get; set; }

        [Required]
        [StringLength(50)]
        public string Alamat { get; set; }

        [Required]
        [StringLength(12)]
        public string No_Telp { get; set; }

        public DateTime Tanggal_Lahir { get; set; }

        [Required]
        [StringLength(50)]
        public string Email { get; set; }

        [Required]
        [StringLength(3)]
        public string K_Identitas { get; set; }

        [Required]
        [StringLength(12)]
        public string N_Identitas { get; set; }
    }
}
