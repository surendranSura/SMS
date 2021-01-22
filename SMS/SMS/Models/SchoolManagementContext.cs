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
                entity.ToTable("Function");

                entity.Property(e => e.FunctionId)
                    .ValueGeneratedNever()
                    .HasColumnName("Function_Id");

                entity.Property(e => e.Decription)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DisplayOrder)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Display_Order");

                entity.Property(e => e.DisplayValue)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Display_Value");

                entity.Property(e => e.ParentFunctionId).HasColumnName("Parent_Function_Id");
            });

            modelBuilder.Entity<Person>(entity =>
            {
                entity.ToTable("Person");

                entity.Property(e => e.PersonId)
                    .ValueGeneratedNever()
                    .HasColumnName("Person_Id");

                entity.Property(e => e.AadharNumber)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Aadhar_Number");

                entity.Property(e => e.BloodGroup)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("Blood_Group")
                    .IsFixedLength(true);

                entity.Property(e => e.CurrentAddress)
                    .IsRequired()
                    .HasColumnName("Current_Address");

                entity.Property(e => e.Dob).HasColumnType("date");

                entity.Property(e => e.EmailId)
                    .IsRequired()
                    .HasColumnName("Email_Id");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("First_Name");

                entity.Property(e => e.Gender)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Last_Name");

                entity.Property(e => e.MiddleName)
                    .HasMaxLength(50)
                    .HasColumnName("Middle_Name");

                entity.Property(e => e.Nationality)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.PermanentAddress)
                    .IsRequired()
                    .HasColumnName("Permanent_Address");

                entity.Property(e => e.Religion)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.RoleId)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.Salt)
                    .IsRequired()
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.Property(e => e.RoleId)
                    .ValueGeneratedNever()
                    .HasColumnName("Role_Id");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<RoleFunction>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("RoleFunction");

                entity.Property(e => e.FunctionId).HasColumnName("Function_Id");

                entity.Property(e => e.RoleId).HasColumnName("Role_Id");

                entity.HasOne(d => d.Function)
                    .WithMany()
                    .HasForeignKey(d => d.FunctionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RoleFunction_Function");

                entity.HasOne(d => d.Role)
                    .WithMany()
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RoleFunction_Roles");
            });

            modelBuilder.Entity<Student>(entity =>
            {
                entity.ToTable("Student");

                entity.Property(e => e.StudentId)
                    .ValueGeneratedNever()
                    .HasColumnName("Student_Id");

                entity.Property(e => e.AdmissionDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Admission_Date");

                entity.Property(e => e.Class)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.EmisNumber)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("EMIS_Number");

                entity.Property(e => e.FathersAadharNumber)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Fathers_Aadhar_Number");

                entity.Property(e => e.FathersAnnualIncome)
                    .HasColumnType("money")
                    .HasColumnName("Fathers_Annual_Income");

                entity.Property(e => e.FathersDesignation)
                    .IsRequired()
                    .HasColumnName("Fathers_Designation");

                entity.Property(e => e.FathersFirstName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Fathers_First_Name");

                entity.Property(e => e.FathersLastName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Fathers_Last_Name");

                entity.Property(e => e.FathersMiddleName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Fathers_Middle_Name");

                entity.Property(e => e.FathersMobileNumber)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("Fathers_Mobile_Number")
                    .IsFixedLength(true);

                entity.Property(e => e.FathersOccupation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Fathers_Occupation");

                entity.Property(e => e.FathersOrganization)
                    .IsRequired()
                    .HasColumnName("Fathers_Organization");

                entity.Property(e => e.FathersSalutation)
                    .IsRequired()
                    .HasMaxLength(3)
                    .HasColumnName("Fathers_Salutation");

                entity.Property(e => e.FirstLanguage)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("First_Language")
                    .IsFixedLength(true);

                entity.Property(e => e.LegalGaurdianAadharNumber)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Legal_Gaurdian_Aadhar_Number");

                entity.Property(e => e.LegalGaurdianAnnualIncome)
                    .HasColumnType("money")
                    .HasColumnName("Legal_Gaurdian_Annual_Income");

                entity.Property(e => e.LegalGaurdianDesignation)
                    .IsRequired()
                    .HasColumnName("Legal_Gaurdian_Designation");

                entity.Property(e => e.LegalGaurdianFirstName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Legal_Gaurdian_First_Name");

                entity.Property(e => e.LegalGaurdianLastName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Legal_Gaurdian_Last_Name");

                entity.Property(e => e.LegalGaurdianMiddleName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Legal_Gaurdian_Middle_Name");

                entity.Property(e => e.LegalGaurdianMobileNumber)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("Legal_Gaurdian_Mobile_Number")
                    .IsFixedLength(true);

                entity.Property(e => e.LegalGaurdianOccupation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Legal_Gaurdian_Occupation");

                entity.Property(e => e.LegalGaurdianOrganization)
                    .IsRequired()
                    .HasColumnName("Legal_Gaurdian_Organization");

                entity.Property(e => e.LegalGaurdianSalutation)
                    .IsRequired()
                    .HasMaxLength(3)
                    .HasColumnName("Legal_Gaurdian_Salutation");

                entity.Property(e => e.LocalGaurdianAadharNumber)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Local_Gaurdian_Aadhar_Number");

                entity.Property(e => e.LocalGaurdianAnnualIncome)
                    .HasColumnType("money")
                    .HasColumnName("Local_Gaurdian_Annual_Income");

                entity.Property(e => e.LocalGaurdianDesignation)
                    .IsRequired()
                    .HasColumnName("Local_Gaurdian_Designation");

                entity.Property(e => e.LocalGaurdianFirstName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Local_Gaurdian_First_Name");

                entity.Property(e => e.LocalGaurdianLastName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Local_Gaurdian_Last_Name");

                entity.Property(e => e.LocalGaurdianMiddleName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Local_Gaurdian_Middle_Name");

                entity.Property(e => e.LocalGaurdianMobileNumber)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("Local_Gaurdian_Mobile_Number")
                    .IsFixedLength(true);

                entity.Property(e => e.LocalGaurdianOccupation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Local_Gaurdian_Occupation");

                entity.Property(e => e.LocalGaurdianOrganization).HasColumnName("Local_Gaurdian_Organization");

                entity.Property(e => e.LocalGaurdianSalutation)
                    .IsRequired()
                    .HasMaxLength(3)
                    .HasColumnName("Local_Gaurdian_Salutation");

                entity.Property(e => e.MothersAadharNumber)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Mothers_Aadhar_Number");

                entity.Property(e => e.MothersAnnualIncome)
                    .HasColumnType("money")
                    .HasColumnName("Mothers_Annual_Income");

                entity.Property(e => e.MothersDesignation)
                    .IsRequired()
                    .HasColumnName("Mothers_Designation");

                entity.Property(e => e.MothersFirstName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Mothers_First_Name");

                entity.Property(e => e.MothersLastName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Mothers_Last_Name");

                entity.Property(e => e.MothersMiddleName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Mothers_Middle_Name");

                entity.Property(e => e.MothersMobileNumber)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("Mothers_Mobile_Number")
                    .IsFixedLength(true);

                entity.Property(e => e.MothersOccupation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Mothers_Occupation");

                entity.Property(e => e.MothersOrganization)
                    .IsRequired()
                    .HasColumnName("Mothers_Organization");

                entity.Property(e => e.MothersSalutation)
                    .IsRequired()
                    .HasMaxLength(3)
                    .HasColumnName("Mothers_Salutation");

                entity.Property(e => e.PersonId).HasColumnName("Person_Id");

                entity.Property(e => e.RollNo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Roll_No");

                entity.Property(e => e.SecondLanguage)
                    .HasMaxLength(10)
                    .HasColumnName("Second_Language")
                    .IsFixedLength(true);

                entity.Property(e => e.Section)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.Students)
                    .HasForeignKey(d => d.PersonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Student_Person");
            });

            modelBuilder.Entity<staff>(entity =>
            {
                entity.HasKey(e => e.EmployeeId);

                entity.ToTable("Staff");

                entity.Property(e => e.EmployeeId)
                    .ValueGeneratedNever()
                    .HasColumnName("Employee_Id");

                entity.Property(e => e.BankAccountNumber)
                    .IsRequired()
                    .HasColumnName("Bank_Account_Number");

                entity.Property(e => e.BankBranch)
                    .IsRequired()
                    .HasColumnName("Bank_Branch");

                entity.Property(e => e.BankIfscCode)
                    .IsRequired()
                    .HasColumnName("Bank_IFSC_Code");

                entity.Property(e => e.BankName)
                    .IsRequired()
                    .HasColumnName("Bank_Name");

                entity.Property(e => e.Department)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.Designation)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.EpfNumber)
                    .IsRequired()
                    .HasColumnName("EPF_Number");

                entity.Property(e => e.EsiNumber)
                    .IsRequired()
                    .HasColumnName("ESI_Number");

                entity.Property(e => e.FatherMobileNumber)
                    .HasMaxLength(10)
                    .HasColumnName("Father_Mobile_Number")
                    .IsFixedLength(true);

                entity.Property(e => e.FatherName)
                    .HasMaxLength(50)
                    .HasColumnName("Father_Name");

                entity.Property(e => e.FatherOccupation)
                    .HasMaxLength(50)
                    .HasColumnName("Father_Occupation");

                entity.Property(e => e.JoiningDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Joining_Date");

                entity.Property(e => e.MotherMobileNumber)
                    .HasMaxLength(10)
                    .HasColumnName("Mother_Mobile_Number")
                    .IsFixedLength(true);

                entity.Property(e => e.MotherName)
                    .HasMaxLength(50)
                    .HasColumnName("Mother_Name");

                entity.Property(e => e.MotherOccupation)
                    .HasMaxLength(50)
                    .HasColumnName("Mother_Occupation");

                entity.Property(e => e.OfficialEmailId)
                    .IsRequired()
                    .HasColumnName("Official_Email_Id");

                entity.Property(e => e.PanNumber)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("PAN_Number");

                entity.Property(e => e.PersonId).HasColumnName("Person_Id");

                entity.Property(e => e.ReportingTo).HasColumnName("Reporting_To");

                entity.Property(e => e.SpouseMobileNumber)
                    .HasMaxLength(10)
                    .HasColumnName("Spouse_Mobile_Number")
                    .IsFixedLength(true);

                entity.Property(e => e.SpouseName)
                    .HasMaxLength(50)
                    .HasColumnName("Spouse_Name");

                entity.Property(e => e.SpouseOccupation)
                    .HasMaxLength(50)
                    .HasColumnName("Spouse_Occupation");

                entity.Property(e => e.StaffType)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("Staff_Type")
                    .IsFixedLength(true);

                entity.Property(e => e.TeacherId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Teacher_Id");

                entity.Property(e => e.UanNumber)
                    .IsRequired()
                    .HasColumnName("UAN_Number");

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.staff)
                    .HasForeignKey(d => d.PersonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Staff_Person");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
