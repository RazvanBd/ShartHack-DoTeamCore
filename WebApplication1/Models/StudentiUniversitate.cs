using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
{
    public partial class StudentiUniversitate
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [StringLength(50)]
        public string Nume { get; set; }
        [StringLength(50)]
        public string Prenume { get; set; }
        [Required]
        [Column("CNP")]
        [StringLength(50)]
        public string Cnp { get; set; }
        [Required]
        [StringLength(50)]
        public string Facultate { get; set; }
        [Required]
        [StringLength(50)]
        public string Specializare { get; set; }
        [Required]
        [StringLength(50)]
        public string Stadiu { get; set; }
        [Required]
        [StringLength(50)]
        public string An { get; set; }
    }
}
