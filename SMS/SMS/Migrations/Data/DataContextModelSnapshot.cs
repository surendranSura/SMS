﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApi.Helpers;

namespace SMS.Migrations.Data
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:IdentityIncrement", 1)
                .HasAnnotation("SqlServer:IdentitySeed", 1)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn)
                .HasAnnotation("ProductVersion", "5.0.3");

            modelBuilder.Entity("SMS.Models.Academics.LessonPlan", b =>
                {
                    b.Property<int>("LessonPlanId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AcademicClassId")
                        .HasColumnType("int");

                    b.Property<int>("AcademicClassSubjectId")
                        .HasColumnType("int");

                    b.Property<string>("LessonPlanCheckDigi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("activity")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("classActivity")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("classWork")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("concept")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("date")
                        .HasColumnType("datetime2");

                    b.Property<string>("extraInfo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("games")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("homeWork")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("lesson")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("topic")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("LessonPlanId");

                    b.ToTable("LessonPlans");
                });

            modelBuilder.Entity("SMS.Models.Setup.AcademicClass", b =>
                {
                    b.Property<int>("AcademicClassId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AcademicClassSubjectId")
                        .HasColumnType("int");

                    b.Property<DateTime>("AcademicYear")
                        .HasColumnType("datetime2");

                    b.Property<string>("ClassName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Group")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Section")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AcademicClassId");

                    b.HasIndex("AcademicClassSubjectId");

                    b.ToTable("AcademicClasses");
                });

            modelBuilder.Entity("SMS.Models.Setup.AcademicClassSubject", b =>
                {
                    b.Property<int>("AcademicClassSubjectId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AcademicClassId")
                        .HasColumnType("int");

                    b.Property<int>("SubjectID")
                        .HasColumnType("int");

                    b.HasKey("AcademicClassSubjectId");

                    b.ToTable("AcademicClassSubjects");
                });

            modelBuilder.Entity("SMS.Models.Setup.Subject", b =>
                {
                    b.Property<int>("SubjectID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AcademicClassSubjectId")
                        .HasColumnType("int");

                    b.Property<string>("SubjectDescr")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SubjectID");

                    b.HasIndex("AcademicClassSubjectId");

                    b.ToTable("Subjects");
                });

            modelBuilder.Entity("SMS.Models.Staff", b =>
                {
                    b.Property<int>("StaffId")
                        .HasColumnType("int");

                    b.Property<string>("AadharNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ActiveId")
                        .HasColumnType("int");

                    b.Property<string>("BankAccountNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BankBranch")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BankIfscCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BankName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BloodGroup")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<int>("DesignationId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Dob")
                        .HasColumnType("datetime2");

                    b.Property<int>("EducationId")
                        .HasColumnType("int");

                    b.Property<string>("EmailId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<int>("EmployeementStatusId")
                        .HasColumnType("int");

                    b.Property<string>("Epfnumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Esinumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FatherMobileNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FatherName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FatherOccupation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("JoiningDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("LanguagesId")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Marritalsatus")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MiddleName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("Mobile")
                        .HasColumnType("bigint");

                    b.Property<string>("MotherMobileNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MotherName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MotherOccupation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MotherTongue")
                        .HasColumnType("int");

                    b.Property<int>("NationalityId")
                        .HasColumnType("int");

                    b.Property<string>("OfficialEmailId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PanNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ReligionId")
                        .HasColumnType("int");

                    b.Property<int>("ReportingTo")
                        .HasColumnType("int");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.Property<string>("SalutationId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SpouseMobileNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SpouseName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SpouseOccupation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StaffAddressId")
                        .HasColumnType("int");

                    b.Property<int>("StaffExperienceId")
                        .HasColumnType("int");

                    b.Property<int>("StaffTypeId")
                        .HasColumnType("int");

                    b.Property<string>("TeacherId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Uannumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("WeddingDate")
                        .HasColumnType("datetime2");

                    b.HasKey("StaffId");

                    b.ToTable("Staffs");
                });

            modelBuilder.Entity("SMS.Models.StaffAddress", b =>
                {
                    b.Property<int>("StaffAddressId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Line1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Line2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Line3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pincode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StaffId")
                        .HasColumnType("int");

                    b.HasKey("StaffAddressId");

                    b.HasIndex("StaffId");

                    b.ToTable("StaffAddress");
                });

            modelBuilder.Entity("SMS.Models.StaffExperience", b =>
                {
                    b.Property<int>("StaffExperienceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("From")
                        .HasColumnType("datetime2");

                    b.Property<string>("Responsibilty")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StaffId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("To")
                        .HasColumnType("datetime2");

                    b.HasKey("StaffExperienceId");

                    b.HasIndex("StaffId");

                    b.ToTable("StaffExperience");
                });

            modelBuilder.Entity("SMS.Models.Student", b =>
                {
                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.Property<string>("AadharNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("AcademicPrecentage")
                        .HasColumnType("int");

                    b.Property<DateTime>("AdmissionDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("AdmissionNumber")
                        .HasColumnType("int");

                    b.Property<string>("BloodGroup")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Class")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CurrentCity")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CurrentCountry")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CurrentLine1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CurrentLine2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CurrentLine3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CurrentPincode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CurrentSate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Dob")
                        .HasColumnType("datetime2");

                    b.Property<string>("EmailId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmisNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FatherAadharNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("FatherAnnualIncome")
                        .HasColumnType("bigint");

                    b.Property<ulong>("FatherBvEmployee")
                        .HasColumnType("bit");

                    b.Property<string>("FatherCompany")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FatherDesignation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FatherEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FatherFirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FatherLastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FatherMiddleName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("FatherMobileNumber")
                        .HasColumnType("bigint");

                    b.Property<string>("FatherOccupation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FatherSalutationId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstLanguage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LegalAadharNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("LegalAnnualIncome")
                        .HasColumnType("bigint");

                    b.Property<ulong>("LegalBvEmployee")
                        .HasColumnType("bit");

                    b.Property<string>("LegalCompany")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LegalDesignation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LegalEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LegalFirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LegalLastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LegalMiddleName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("LegalMobileNumber")
                        .HasColumnType("bigint");

                    b.Property<string>("LegalOccupation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LegalSalutationId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LocalGuardianAadharNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("LocalGuardianAnnualIncome")
                        .HasColumnType("bigint");

                    b.Property<ulong>("LocalGuardianBvEmployee")
                        .HasColumnType("bit");

                    b.Property<string>("LocalGuardianCompany")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LocalGuardianDesignation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LocalGuardianEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LocalGuardianFirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LocalGuardianLastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LocalGuardianMiddleName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("LocalGuardianMobileNumber")
                        .HasColumnType("bigint");

                    b.Property<string>("LocalGuardianOccupation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LocalGuardianSalutationId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MiddleName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("Mobile")
                        .HasColumnType("bigint");

                    b.Property<string>("MotherAadharNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("MotherAnnualIncome")
                        .HasColumnType("bigint");

                    b.Property<ulong>("MotherBvEmployee")
                        .HasColumnType("bit");

                    b.Property<string>("MotherCompany")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MotherDesignation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MotherEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MotherFirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MotherLastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MotherMiddleName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("MotherMobileNumber")
                        .HasColumnType("bigint");

                    b.Property<string>("MotherOccupation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MotherSalutationId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("NationalityId")
                        .HasColumnType("int");

                    b.Property<string>("PermenantCity")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PermenantCountry")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PermenantLine1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PermenantLine2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PermenantLine3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PermenantPincode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PermenantSate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ReasonForLeaving")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ReligionId")
                        .HasColumnType("int");

                    b.Property<string>("RollNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Salutation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SecondLanguage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Section")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("passingOutSchool")
                        .HasColumnType("int");

                    b.Property<int?>("schoolBrand")
                        .HasColumnType("int");

                    b.Property<string>("schoolName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("yearofattendence")
                        .HasColumnType("int");

                    b.HasKey("StudentId");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("WebApi.Entities.Account", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AcceptTerms")
                        .HasColumnType("int");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("PasswordReset")
                        .HasColumnType("datetime2");

                    b.Property<string>("ResetToken")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ResetTokenExpires")
                        .HasColumnType("datetime2");

                    b.Property<int>("Role")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Updated")
                        .HasColumnType("datetime2");

                    b.Property<string>("VerificationToken")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Verified")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Accounts");
                });

            modelBuilder.Entity("SMS.Models.Setup.AcademicClass", b =>
                {
                    b.HasOne("SMS.Models.Setup.AcademicClassSubject", "AcademicClassSubject")
                        .WithMany("AcademicClasses")
                        .HasForeignKey("AcademicClassSubjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AcademicClassSubject");
                });

            modelBuilder.Entity("SMS.Models.Setup.Subject", b =>
                {
                    b.HasOne("SMS.Models.Setup.AcademicClassSubject", "AcademicClassSubject")
                        .WithMany("Subjects")
                        .HasForeignKey("AcademicClassSubjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AcademicClassSubject");
                });

            modelBuilder.Entity("SMS.Models.StaffAddress", b =>
                {
                    b.HasOne("SMS.Models.Staff", null)
                        .WithMany("Addresses")
                        .HasForeignKey("StaffId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SMS.Models.StaffExperience", b =>
                {
                    b.HasOne("SMS.Models.Staff", null)
                        .WithMany("experiences")
                        .HasForeignKey("StaffId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WebApi.Entities.Account", b =>
                {
                    b.OwnsMany("WebApi.Entities.RefreshToken", "RefreshTokens", b1 =>
                        {
                            b1.Property<int>("Id")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("int")
                                .HasAnnotation("SqlServer:IdentityIncrement", 1)
                                .HasAnnotation("SqlServer:IdentitySeed", 1)
                                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                            b1.Property<int>("AccountId")
                                .HasColumnType("int");

                            b1.Property<DateTime>("Created")
                                .HasColumnType("datetime2");

                            b1.Property<string>("CreatedByIp")
                                .HasColumnType("nvarchar(max)");

                            b1.Property<DateTime>("Expires")
                                .HasColumnType("datetime2");

                            b1.Property<string>("ReplacedByToken")
                                .HasColumnType("nvarchar(max)");

                            b1.Property<DateTime?>("Revoked")
                                .HasColumnType("datetime2");

                            b1.Property<string>("RevokedByIp")
                                .HasColumnType("nvarchar(max)");

                            b1.Property<string>("Token")
                                .HasColumnType("nvarchar(max)");

                            b1.HasKey("Id");

                            b1.HasIndex("AccountId");

                            b1.ToTable("RefreshToken");

                            b1.WithOwner("Account")
                                .HasForeignKey("AccountId");

                            b1.Navigation("Account");
                        });

                    b.Navigation("RefreshTokens");
                });

            modelBuilder.Entity("SMS.Models.Setup.AcademicClassSubject", b =>
                {
                    b.Navigation("AcademicClasses");

                    b.Navigation("Subjects");
                });

            modelBuilder.Entity("SMS.Models.Staff", b =>
                {
                    b.Navigation("Addresses");

                    b.Navigation("experiences");
                });
#pragma warning restore 612, 618
        }
    }
}
