using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace EmployeeWebApp.Models
{
    public partial class officeContext : DbContext
    {
        public officeContext()
        {
        }

        public officeContext(DbContextOptions<officeContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Employee> Employee { get; set; }

        // Unable to generate entity type for table 'dbo.Table_1'. Please see the warning messages.

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Database=office;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>(entity =>
            {
                entity.ToTable("employee");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.EmployeeAge).HasColumnName("employee_age");

                entity.Property(e => e.EmployeeGender)
                    .HasColumnName("employee_gender")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeName)
                    .HasColumnName("employee_name")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeePhonenumber)
                    .HasColumnName("employee_phonenumber")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });
        }
    }
}
