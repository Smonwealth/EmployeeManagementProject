using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace EmployeeManagementProject.Models
{
    public partial class SchoolManagementDbContext : DbContext
    {
        public SchoolManagementDbContext()
        {
        }

        public SchoolManagementDbContext(DbContextOptions<SchoolManagementDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<BioData> BioData { get; set; }
        public virtual DbSet<Department> Department { get; set; }
        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<Leave> Leave { get; set; }
        public virtual DbSet<Login> Login { get; set; }
        public virtual DbSet<Registration> Registration { get; set; }
        public virtual DbSet<Role> Role { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=DESKTOP-R7JS9OQ;Database=SchoolManagementDb;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BioData>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Address).IsRequired();

                entity.Property(e => e.BloodGroup)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Dob)
                    .HasColumnName("DOB")
                    .HasColumnType("date");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Genotype)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.LocalGovtOfOrigin)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Nationality)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.OtherName).HasMaxLength(50);

                entity.Property(e => e.Passport)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.PhoneNumber)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.RegistrationStatus)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Sex)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.StateOfOrigin)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Department>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Acronym)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.DepartmentName).IsRequired();
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.Property(e => e.EmployeeId).ValueGeneratedNever();
            });

            modelBuilder.Entity<Leave>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.ApprovedBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.EndDate).HasColumnType("date");

                entity.Property(e => e.Name).IsRequired();

                entity.Property(e => e.StartDate).HasColumnType("date");

                entity.Property(e => e.TypeOfLeave)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Login>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Registration>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Address).IsRequired();

                entity.Property(e => e.AreaOfSpecialization).IsRequired();

                entity.Property(e => e.Dob)
                    .HasColumnName("DOB")
                    .HasColumnType("date");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.LocalGovtOfOrigin)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Nationality)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.OtherName).HasMaxLength(50);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.PhoneNumber)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Qualification)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.StateOfOrigin)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.StateOfResidence)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Rank)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.RoleName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
