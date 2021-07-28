﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApi.Helpers;

namespace SMS.Migrations.Data
{
    [DbContext(typeof(DataContext))]
    [Migration("20210728194815_StudentV6-1_removedFilemanager")]
    partial class StudentV61_removedFilemanager
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.3");

            modelBuilder.Entity("SMS.Models.Student", b =>
                {
                    b.Property<int>("StudentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

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

                    b.Property<bool>("FatherBvEmployee")
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

                    b.Property<bool>("LegalBvEmployee")
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

                    b.Property<bool>("LocalGuardianBvEmployee")
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

                    b.Property<bool>("MotherBvEmployee")
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
                        .UseIdentityColumn();

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

            modelBuilder.Entity("WebApi.Entities.Account", b =>
                {
                    b.OwnsMany("WebApi.Entities.RefreshToken", "RefreshTokens", b1 =>
                        {
                            b1.Property<int>("Id")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("int")
                                .UseIdentityColumn();

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
#pragma warning restore 612, 618
        }
    }
}
