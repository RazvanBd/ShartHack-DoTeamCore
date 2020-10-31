﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
{
    public partial class PersoanePolitie
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Nume { get; set; }
        [Required]
        [StringLength(50)]
        public string Prenume { get; set; }
        [Required]
        [StringLength(13)]
        public string Cnp { get; set; }
        public bool Permis { get; set; }
        public bool Cazier { get; set; }
    }
}