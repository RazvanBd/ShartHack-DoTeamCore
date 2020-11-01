using System;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace WebApplication1.Models
{
    public partial class GhiseuDigitalContext : IdentityDbContext
    {
        
        public GhiseuDigitalContext()
        {
        }

        public GhiseuDigitalContext(DbContextOptions<GhiseuDigitalContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Persoane> Persoane { get; set; }
        public virtual DbSet<PersoaneMedic> PersoaneMedic { get; set; }
        public virtual DbSet<PersoanePolitie> PersoanePolitie { get; set; }
        public virtual DbSet<StudentiUniversitate> StudentiUniversitate { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-KNJ41GG;Database=GhiseuDigital;Trusted_Connection=True;MultipleActiveResultSets=true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
