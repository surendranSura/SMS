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

        public virtual DbSet<Function> Functions { get; set; }
        public virtual DbSet<Person> People { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<RoleFunction> RoleFunctions { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<staff> staff { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=.;Database=SchoolManagement;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Function>(entity =>
            {
                entity.HasKey(e => e.FuncId);

                entity.ToTable("Function");

                entity.Property(e => e.FuncId).ValueGeneratedNever();

                entity.Property(e => e.Descr)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Person>(entity =>
            {
                entity.ToTable("Person");

                entity.Property(e => e.Id)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.AadharNumber).HasColumnName("Aadhar Number");

                entity.Property(e => e.BloodGroup)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("Blood Group")
                    .IsFixedLength(true);

                entity.Property(e => e.CurrentAddress).HasColumnName("Current Address");

                entity.Property(e => e.DOB)
                    .HasColumnType("datetime")
                    .HasColumnName("D.O.B");

                entity.Property(e => e.EmailId).HasColumnName("email id");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("First Name");

                entity.Property(e => e.Gender)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.LastName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Last Name");

                entity.Property(e => e.MiddleName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Middle Name");

                entity.Property(e => e.Password).IsUnicode(false);

                entity.Property(e => e.PermanentAddress).HasColumnName("Permanent address");

                entity.Property(e => e.RoleId)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.Salt).IsUnicode(false);
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.ToTable("Role");

                entity.HasComment("User Roles !!");

                entity.Property(e => e.Descr)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<RoleFunction>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("RoleFunction");
            });

            modelBuilder.Entity<Student>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Student");

                entity.Property(e => e.AdmissionDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Admission Date");

                entity.Property(e => e.Class)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.EmisNumber)
                    .HasMaxLength(50)
                    .HasColumnName("EMIS Number");

                entity.Property(e => e.FathersAadharNumber)
                    .HasMaxLength(50)
                    .HasColumnName("Fathers Aadhar Number");

                entity.Property(e => e.FathersAnnualIncome)
                    .HasColumnType("money")
                    .HasColumnName("Fathers Annual Income");

                entity.Property(e => e.FathersDesignation).HasColumnName("Fathers Designation");

                entity.Property(e => e.FathersFirstName)
                    .HasMaxLength(50)
                    .HasColumnName("Fathers First Name");

                entity.Property(e => e.FathersLastName)
                    .HasMaxLength(50)
                    .HasColumnName("Fathers Last Name");

                entity.Property(e => e.FathersMiddleName)
                    .HasMaxLength(50)
                    .HasColumnName("Fathers Middle Name");

                entity.Property(e => e.FathersMobileNumber)
                    .HasMaxLength(10)
                    .HasColumnName("Fathers Mobile Number")
                    .IsFixedLength(true);

                entity.Property(e => e.FathersOccupation)
                    .HasMaxLength(50)
                    .HasColumnName("Fathers Occupation");

                entity.Property(e => e.FathersOrganization).HasColumnName("Fathers Organization");

                entity.Property(e => e.FathersSalutation)
                    .HasMaxLength(3)
                    .HasColumnName("Fathers Salutation");

                entity.Property(e => e.FirstLanguage)
                    .HasMaxLength(10)
                    .HasColumnName("First Language")
                    .IsFixedLength(true);

                entity.Property(e => e.LegalGaurdianAadharNumber)
                    .HasMaxLength(50)
                    .HasColumnName("LegalGaurdian Aadhar Number");

                entity.Property(e => e.LegalGaurdianAnnualIncome)
                    .HasColumnType("money")
                    .HasColumnName("LegalGaurdian Annual Income");

                entity.Property(e => e.LegalGaurdianDesignation).HasColumnName("LegalGaurdian Designation");

                entity.Property(e => e.LegalGaurdianFirstName)
                    .HasMaxLength(50)
                    .HasColumnName("LegalGaurdian First Name");

                entity.Property(e => e.LegalGaurdianLastName)
                    .HasMaxLength(50)
                    .HasColumnName("LegalGaurdian Last Name");

                entity.Property(e => e.LegalGaurdianMiddleName)
                    .HasMaxLength(50)
                    .HasColumnName("LegalGaurdian Middle Name");

                entity.Property(e => e.LegalGaurdianMobileNumber)
                    .HasMaxLength(10)
                    .HasColumnName("LegalGaurdian Mobile Number")
                    .IsFixedLength(true);

                entity.Property(e => e.LegalGaurdianOccupation)
                    .HasMaxLength(50)
                    .HasColumnName("LegalGaurdian Occupation");

                entity.Property(e => e.LegalGaurdianOrganization).HasColumnName("LegalGaurdian Organization");

                entity.Property(e => e.LegalGaurdianSalutation)
                    .HasMaxLength(3)
                    .HasColumnName("LegalGaurdian Salutation");

                entity.Property(e => e.LgaurdianAadharNumber)
                    .HasMaxLength(50)
                    .HasColumnName("LGaurdian Aadhar Number");

                entity.Property(e => e.LgaurdianAnnualIncome)
                    .HasColumnType("money")
                    .HasColumnName("LGaurdian Annual Income");

                entity.Property(e => e.LgaurdianDesignation).HasColumnName("LGaurdian Designation");

                entity.Property(e => e.LgaurdianFirstName)
                    .HasMaxLength(50)
                    .HasColumnName("LGaurdian First Name");

                entity.Property(e => e.LgaurdianLastName)
                    .HasMaxLength(50)
                    .HasColumnName("LGaurdian Last Name");

                entity.Property(e => e.LgaurdianMiddleName)
                    .HasMaxLength(50)
                    .HasColumnName("LGaurdian Middle Name");

                entity.Property(e => e.LgaurdianMobileNumber)
                    .HasMaxLength(10)
                    .HasColumnName("LGaurdian Mobile Number")
                    .IsFixedLength(true);

                entity.Property(e => e.LgaurdianOccupation)
                    .HasMaxLength(50)
                    .HasColumnName("LGaurdian Occupation");

                entity.Property(e => e.LgaurdianOrganization).HasColumnName("LGaurdian Organization");

                entity.Property(e => e.LgaurdianSalutation)
                    .HasMaxLength(3)
                    .HasColumnName("LGaurdian Salutation");

                entity.Property(e => e.MothersAadharNumber)
                    .HasMaxLength(50)
                    .HasColumnName("Mothers Aadhar Number");

                entity.Property(e => e.MothersAnnualIncome)
                    .HasColumnType("money")
                    .HasColumnName("Mothers Annual Income");

                entity.Property(e => e.MothersDesignation).HasColumnName("Mothers Designation");

                entity.Property(e => e.MothersFirstName)
                    .HasMaxLength(50)
                    .HasColumnName("Mothers First Name");

                entity.Property(e => e.MothersLastName)
                    .HasMaxLength(50)
                    .HasColumnName("Mothers Last Name");

                entity.Property(e => e.MothersMiddleName)
                    .HasMaxLength(50)
                    .HasColumnName("Mothers Middle Name");

                entity.Property(e => e.MothersMobileNumber)
                    .HasMaxLength(10)
                    .HasColumnName("Mothers Mobile Number")
                    .IsFixedLength(true);

                entity.Property(e => e.MothersOccupation)
                    .HasMaxLength(50)
                    .HasColumnName("Mothers Occupation");

                entity.Property(e => e.MothersOrganization).HasColumnName("Mothers Organization");

                entity.Property(e => e.MothersSalutation)
                    .HasMaxLength(3)
                    .HasColumnName("Mothers Salutation");

                entity.Property(e => e.RollNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Roll No");

                entity.Property(e => e.SecondLanguage)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("Second Language")
                    .IsFixedLength(true);

                entity.Property(e => e.Section)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<staff>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Staff");

                entity.Property(e => e.BankAcNumber)
                    .IsRequired()
                    .HasColumnName("Bank AC Number");

                entity.Property(e => e.BankBranch)
                    .IsRequired()
                    .HasColumnName("Bank Branch");

                entity.Property(e => e.BankIfscCode)
                    .IsRequired()
                    .HasColumnName("Bank IFSC Code");

                entity.Property(e => e.BankName)
                    .IsRequired()
                    .HasColumnName("Bank Name");

                entity.Property(e => e.Department)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.Designation)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.EmployeeId).HasColumnName("Employee ID");

                entity.Property(e => e.EpfNumber).HasColumnName("EPF Number");

                entity.Property(e => e.EsiNumber).HasColumnName("ESI Number");

                entity.Property(e => e.FaterOccupation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Fater Occupation");

                entity.Property(e => e.FatherMobileNumber)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("Father Mobile Number")
                    .IsFixedLength(true);

                entity.Property(e => e.FatherName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Father Name");

                entity.Property(e => e.JoiningDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Joining Date");

                entity.Property(e => e.MotherMobileNumber)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("Mother Mobile Number")
                    .IsFixedLength(true);

                entity.Property(e => e.MotherName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Mother Name");

                entity.Property(e => e.MotherOccupation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Mother Occupation");

                entity.Property(e => e.OfficialEMailId)
                    .IsRequired()
                    .HasColumnName("Official e-mail ID");

                entity.Property(e => e.PanNumber)
                    .HasMaxLength(50)
                    .HasColumnName("PAN Number");

                entity.Property(e => e.ReportingTo).HasColumnName("Reporting To");

                entity.Property(e => e.SpouceOccupation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Spouce Occupation");

                entity.Property(e => e.SpoucseMobileNumber)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("Spoucse Mobile Number")
                    .IsFixedLength(true);

                entity.Property(e => e.SpouseName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Spouse Name");

                entity.Property(e => e.StaffType)
                    .HasMaxLength(10)
                    .HasColumnName("Staff Type")
                    .IsFixedLength(true);

                entity.Property(e => e.TeacherId)
                    .HasMaxLength(50)
                    .HasColumnName("Teacher ID");

                entity.Property(e => e.UanNumber).HasColumnName("UAN Number");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
