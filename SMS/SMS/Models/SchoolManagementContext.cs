using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace SMS.Models
{
    public partial class SchoolManagementContext : DbContext
    {
        public SchoolManagementContext()
        {
        }

        public SchoolManagementContext(DbContextOptions<SchoolManagementContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Designation> Designations { get; set; }
        public virtual DbSet<Function> Functions { get; set; }
        public virtual DbSet<Nationality> Nationalities { get; set; }
        public virtual DbSet<Person> Persons { get; set; }
        public virtual DbSet<Religion> Religions { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<RoleFunction> RoleFunctions { get; set; }
        public virtual DbSet<Staff> Staffs { get; set; }
        public virtual DbSet<Student> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=.;Database=SchoolManagement;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Person>(entity =>
            {
                entity.HasIndex(e => e.NationalityId, "IX_Persons_NationalityId");

                entity.HasIndex(e => e.ReligionId, "IX_Persons_ReligionId");

                //entity.HasIndex(e => e.PersonId, "IX_Persons_ReligionId");

                entity.HasOne(d => d.Nationality)
                    .WithMany(p => p.People)
                    .HasForeignKey(d => d.NationalityId);

                entity.HasOne(d => d.Religion)
                    .WithMany(p => p.People)
                    .HasForeignKey(d => d.ReligionId);
            });

            modelBuilder.Entity<RoleFunction>(entity =>
            {
                entity.HasIndex(e => e.FunctionId, "IX_RoleFunctions_FunctionId");

                entity.HasIndex(e => e.RoleId, "IX_RoleFunctions_RoleId");

                entity.HasOne(d => d.Function)
                    .WithMany(p => p.RoleFunctions)
                    .HasForeignKey(d => d.FunctionId);

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.RoleFunctions)
                    .HasForeignKey(d => d.RoleId);
            });

            modelBuilder.Entity<Staff>(entity =>
            {
                entity.HasIndex(e => e.DepartmentId, "IX_Staffs_DepartmentId");

                entity.HasIndex(e => e.DesignationId, "IX_Staffs_DesignationId");

                entity.HasIndex(e => e.PersonId, "IX_Staffs_PersonId");

                entity.Property(e => e.Epfnumber).HasColumnName("EPFNumber");

                entity.Property(e => e.Esinumber).HasColumnName("ESINumber");

                entity.Property(e => e.Uannumber).HasColumnName("UANNumber");

                entity.HasOne(d => d.Department)
                    .WithMany(p => p.staff)
                    .HasForeignKey(d => d.DepartmentId);

                entity.HasOne(d => d.Designation)
                    .WithMany(p => p.staff)
                    .HasForeignKey(d => d.DesignationId);

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.staff)
                    .HasForeignKey(d => d.PersonId);
            });

            modelBuilder.Entity<Student>(entity =>
            {
                entity.HasIndex(e => e.PersonId, "IX_Students_PersonId");

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.Students)
                    .HasForeignKey(d => d.PersonId);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
