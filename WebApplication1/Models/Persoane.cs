using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
{
    public partial class Persoane
    {
        [Key]
        [Column("CNP")]
        [StringLength(13)]
        public string Cnp { get; set; }
        [Required]
        [StringLength(50)]
        public string Nume { get; set; }
        [Required]
        [StringLength(50)]
        public string Prenume { get; set; }
        [Required]
        [StringLength(2)]
        public string Serie { get; set; }
        [Required]
        [StringLength(6)]
        public string Numar { get; set; }
        [Required]
        [StringLength(100)]
        public string Adresa { get; set; }
        [Column(TypeName = "date")]
        public DateTime DataNasterii { get; set; }
        [StringLength(50)]
        public string StatusPolitie { get; set; }
        [StringLength(50)]
        public string StatusMedic { get; set; }
        public bool? StatusUniversitate { get; set; }
    }
}
