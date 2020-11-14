using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ResumeAngularNet.Models
{
    public partial class ResumeAngularDBContext : DbContext
    {
        public ResumeAngularDBContext()
        {
        }

        public ResumeAngularDBContext(DbContextOptions<ResumeAngularDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Certification> Certification { get; set; }
        public virtual DbSet<Contact> Contact { get; set; }
        public virtual DbSet<Education> Education { get; set; }
        public virtual DbSet<Experience> Experience { get; set; }
        public virtual DbSet<ExperienceItem> ExperienceItem { get; set; }

//        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//        {
//            if (!optionsBuilder.IsConfigured)
//            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
//                //optionsBuilder.UseSqlServer("Server=(localdb)\\ProjectsV13;Database=ResumeAngularDB;Trusted_Connection=True;");
//            }
//        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Certification>(entity =>
            {
                entity.Property(e => e.Contact).HasColumnName("contact");

                entity.Property(e => e.DateIni)
                    .HasColumnName("dateIni")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Institution)
                    .HasColumnName("institution")
                    .HasMaxLength(50);

                entity.Property(e => e.Title)
                    .HasColumnName("title")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Contact>(entity =>
            {
                entity.Property(e => e.City)
                    .HasColumnName("city")
                    .HasMaxLength(50);

                entity.Property(e => e.Country)
                    .HasColumnName("country")
                    .HasMaxLength(50);

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(50);

                entity.Property(e => e.FirstName)
                    .HasColumnName("firstName")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.LastName)
                    .HasColumnName("lastName")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Phone)
                    .HasColumnName("phone")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.State)
                    .HasColumnName("state")
                    .HasMaxLength(50);

                entity.Property(e => e.Street)
                    .HasColumnName("street")
                    .HasMaxLength(50);

                entity.Property(e => e.Zip)
                    .HasColumnName("zip")
                    .HasMaxLength(10)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Education>(entity =>
            {
                entity.Property(e => e.City)
                    .HasColumnName("city")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Contact).HasColumnName("contact");

                entity.Property(e => e.Country)
                    .HasColumnName("country")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.DateFin)
                    .HasColumnName("dateFin")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.DateIni)
                    .HasColumnName("dateIni")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Institution)
                    .HasColumnName("institution")
                    .HasMaxLength(50);

                entity.Property(e => e.Title)
                    .HasColumnName("title")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Experience>(entity =>
            {
                entity.Property(e => e.City)
                    .HasColumnName("city")
                    .HasMaxLength(50);

                entity.Property(e => e.Company)
                    .HasColumnName("company")
                    .HasMaxLength(50);

                entity.Property(e => e.Contact).HasColumnName("contact");

                entity.Property(e => e.Country)
                    .HasColumnName("country")
                    .HasMaxLength(50);

                entity.HasOne(d => d.ContactNavigation)
                    .WithMany(p => p.Experience)
                    .HasForeignKey(d => d.Contact)
                    .HasConstraintName("FK_Experience_ToContact");
            });

            modelBuilder.Entity<ExperienceItem>(entity =>
            {
                entity.Property(e => e.CompanyId).HasColumnName("companyId");

                entity.Property(e => e.DateFin)
                    .HasColumnName("dateFin")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.DateIni)
                    .HasColumnName("dateIni")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.Title)
                    .HasColumnName("title")
                    .HasMaxLength(50);

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.ExperienceItem)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ExperienceItem_ToExperience");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
