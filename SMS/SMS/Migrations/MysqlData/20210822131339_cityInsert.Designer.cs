﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApi.Helpers;

namespace SMS.Migrations.MysqlData
{
    [DbContext(typeof(MysqlDataContext))]
    [Migration("20210822131339_cityInsert")]
    partial class cityInsert
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.5");

            modelBuilder.Entity("SMS.Models.Academics.LessonPlan", b =>
                {
                    b.Property<int>("LessonPlanId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("AcademicClassId")
                        .HasColumnType("int");

                    b.Property<int>("AcademicClassSubjectId")
                        .HasColumnType("int");

                    b.Property<string>("LessonPlanCheckDigi")
                        .HasColumnType("text");

                    b.Property<string>("activity")
                        .HasColumnType("text");

                    b.Property<string>("classActivity")
                        .HasColumnType("text");

                    b.Property<string>("classWork")
                        .HasColumnType("text");

                    b.Property<string>("concept")
                        .HasColumnType("text");

                    b.Property<DateTime?>("date")
                        .HasColumnType("datetime");

                    b.Property<string>("extraInfo")
                        .HasColumnType("text");

                    b.Property<string>("games")
                        .HasColumnType("text");

                    b.Property<string>("homeWork")
                        .HasColumnType("text");

                    b.Property<string>("lesson")
                        .HasColumnType("text");

                    b.Property<string>("topic")
                        .HasColumnType("text");

                    b.HasKey("LessonPlanId");

                    b.ToTable("LessonPlans");
                });

            modelBuilder.Entity("SMS.Models.City", b =>
                {
                    b.Property<int>("CityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("cityDescr")
                        .HasColumnType("text");

                    b.HasKey("CityId");

                    b.ToTable("Cities");
                });

            modelBuilder.Entity("SMS.Models.Inventory.Inventory", b =>
                {
                    b.Property<int>("InventoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Brand")
                        .HasColumnType("text");

                    b.Property<int>("InventoryItemTypeId")
                        .HasColumnType("int");

                    b.Property<int>("InventoryItemUsageAreaId")
                        .HasColumnType("int");

                    b.Property<string>("ItemName")
                        .HasColumnType("text");

                    b.Property<int>("ModelNumber")
                        .HasColumnType("int");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<string>("SerialNumber")
                        .HasColumnType("text");

                    b.Property<string>("VendorAddress")
                        .HasColumnType("text");

                    b.Property<string>("VendorName")
                        .HasColumnType("text");

                    b.Property<string>("VendorNumber")
                        .HasColumnType("text");

                    b.Property<bool>("WarrenOrGarantee")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("WarrenOrGarenInfo")
                        .HasColumnType("text");

                    b.HasKey("InventoryId");

                    b.HasIndex("InventoryItemTypeId");

                    b.HasIndex("InventoryItemUsageAreaId");

                    b.ToTable("Inventorys");
                });

            modelBuilder.Entity("SMS.Models.Inventory.InventoryDefect", b =>
                {
                    b.Property<int>("InventoryDefectId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("DefectInfo")
                        .HasColumnType("text");

                    b.Property<int?>("InventoryItemTypeId")
                        .HasColumnType("int");

                    b.Property<int?>("InventoryItemUsageAreaId")
                        .HasColumnType("int");

                    b.HasKey("InventoryDefectId");

                    b.HasIndex("InventoryItemTypeId");

                    b.HasIndex("InventoryItemUsageAreaId");

                    b.ToTable("InventoryDefects");
                });

            modelBuilder.Entity("SMS.Models.Inventory.InventoryItemType", b =>
                {
                    b.Property<int>("InventoryItemTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.HasKey("InventoryItemTypeId");

                    b.ToTable("InventoryItemTypes");
                });

            modelBuilder.Entity("SMS.Models.Inventory.InventoryItemUsageArea", b =>
                {
                    b.Property<int>("InventoryItemUsageAreaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.HasKey("InventoryItemUsageAreaId");

                    b.ToTable("InventoryItemUsageAreas");
                });

            modelBuilder.Entity("SMS.Models.Leave.StaffLeave", b =>
                {
                    b.Property<int>("StaffLeaveId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("LeaveType")
                        .HasColumnType("text");

                    b.Property<string>("Reason")
                        .HasColumnType("text");

                    b.Property<int?>("StaffId")
                        .HasColumnType("int");

                    b.Property<DateTime>("datefrom")
                        .HasColumnType("datetime");

                    b.Property<DateTime>("dateto")
                        .HasColumnType("datetime");

                    b.Property<string>("leavesession")
                        .HasColumnType("text");

                    b.HasKey("StaffLeaveId");

                    b.HasIndex("StaffId");

                    b.ToTable("StaffLeaves");
                });

            modelBuilder.Entity("SMS.Models.Leave.StudentLeave", b =>
                {
                    b.Property<int>("StudentLeaveId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("LeaveType")
                        .HasColumnType("text");

                    b.Property<string>("Reason")
                        .HasColumnType("text");

                    b.Property<int?>("StudentId")
                        .HasColumnType("int");

                    b.Property<DateTime>("datefrom")
                        .HasColumnType("datetime");

                    b.Property<DateTime>("dateto")
                        .HasColumnType("datetime");

                    b.Property<string>("leavesession")
                        .HasColumnType("text");

                    b.HasKey("StudentLeaveId");

                    b.HasIndex("StudentId");

                    b.ToTable("StudentLeaves");
                });

            modelBuilder.Entity("SMS.Models.Nationality", b =>
                {
                    b.Property<int>("NationalityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("NationalityName")
                        .HasColumnType("text");

                    b.HasKey("NationalityId");

                    b.ToTable("Nationalities");
                });

            modelBuilder.Entity("SMS.Models.Religion", b =>
                {
                    b.Property<int>("ReligionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ReligionName")
                        .HasColumnType("text");

                    b.HasKey("ReligionId");

                    b.ToTable("Religions");
                });

            modelBuilder.Entity("SMS.Models.Setup.AcademicClass", b =>
                {
                    b.Property<int>("AcademicClassId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("AcademicClassSubjectId")
                        .HasColumnType("text");

                    b.Property<DateTime>("AcademicYear")
                        .HasColumnType("datetime");

                    b.Property<string>("ClassName")
                        .HasColumnType("text");

                    b.Property<string>("Group")
                        .HasColumnType("text");

                    b.Property<string>("Section")
                        .HasColumnType("text");

                    b.HasKey("AcademicClassId");

                    b.ToTable("AcademicClasses");
                });

            modelBuilder.Entity("SMS.Models.Setup.AcademicClassSubject", b =>
                {
                    b.Property<int>("AcademicClassSubjectId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

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
                        .HasColumnType("int");

                    b.Property<string>("SubjectDescr")
                        .HasColumnType("text");

                    b.HasKey("SubjectID");

                    b.ToTable("Subjects");
                });

            modelBuilder.Entity("SMS.Models.Staff", b =>
                {
                    b.Property<int>("StaffId")
                        .HasColumnType("int");

                    b.Property<string>("AadharNumber")
                        .HasColumnType("text");

                    b.Property<int>("ActiveId")
                        .HasColumnType("int");

                    b.Property<string>("BankAccountNumber")
                        .HasColumnType("text");

                    b.Property<string>("BankBranch")
                        .HasColumnType("text");

                    b.Property<string>("BankIfscCode")
                        .HasColumnType("text");

                    b.Property<string>("BankName")
                        .HasColumnType("text");

                    b.Property<string>("BloodGroup")
                        .HasColumnType("text");

                    b.Property<int>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<int>("DesignationId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Dob")
                        .HasColumnType("datetime");

                    b.Property<int>("EducationId")
                        .HasColumnType("int");

                    b.Property<string>("EmailId")
                        .HasColumnType("text");

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<int>("EmployeementStatusId")
                        .HasColumnType("int");

                    b.Property<string>("Epfnumber")
                        .HasColumnType("text");

                    b.Property<string>("Esinumber")
                        .HasColumnType("text");

                    b.Property<string>("FatherMobileNumber")
                        .HasColumnType("text");

                    b.Property<string>("FatherName")
                        .HasColumnType("text");

                    b.Property<string>("FatherOccupation")
                        .HasColumnType("text");

                    b.Property<string>("FirstName")
                        .HasColumnType("text");

                    b.Property<string>("Gender")
                        .HasColumnType("text");

                    b.Property<DateTime>("JoiningDate")
                        .HasColumnType("datetime");

                    b.Property<int>("LanguagesId")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .HasColumnType("text");

                    b.Property<string>("Marritalsatus")
                        .HasColumnType("text");

                    b.Property<string>("MiddleName")
                        .HasColumnType("text");

                    b.Property<long>("Mobile")
                        .HasColumnType("bigint");

                    b.Property<string>("MotherMobileNumber")
                        .HasColumnType("text");

                    b.Property<string>("MotherName")
                        .HasColumnType("text");

                    b.Property<string>("MotherOccupation")
                        .HasColumnType("text");

                    b.Property<int>("MotherTongue")
                        .HasColumnType("int");

                    b.Property<int>("NationalityId")
                        .HasColumnType("int");

                    b.Property<string>("OfficialEmailId")
                        .HasColumnType("text");

                    b.Property<string>("PanNumber")
                        .HasColumnType("text");

                    b.Property<int>("ReligionId")
                        .HasColumnType("int");

                    b.Property<int>("ReportingTo")
                        .HasColumnType("int");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.Property<string>("SalutationId")
                        .HasColumnType("text");

                    b.Property<string>("SpouseMobileNumber")
                        .HasColumnType("text");

                    b.Property<string>("SpouseName")
                        .HasColumnType("text");

                    b.Property<string>("SpouseOccupation")
                        .HasColumnType("text");

                    b.Property<int>("StaffAddressId")
                        .HasColumnType("int");

                    b.Property<int>("StaffExperienceId")
                        .HasColumnType("int");

                    b.Property<int>("StaffTypeId")
                        .HasColumnType("int");

                    b.Property<string>("TeacherId")
                        .HasColumnType("text");

                    b.Property<string>("Uannumber")
                        .HasColumnType("text");

                    b.Property<DateTime>("WeddingDate")
                        .HasColumnType("datetime");

                    b.HasKey("StaffId");

                    b.ToTable("Staffs");
                });

            modelBuilder.Entity("SMS.Models.StaffAddress", b =>
                {
                    b.Property<int>("StaffAddressId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("City")
                        .HasColumnType("text");

                    b.Property<string>("Country")
                        .HasColumnType("text");

                    b.Property<string>("Line1")
                        .HasColumnType("text");

                    b.Property<string>("Line2")
                        .HasColumnType("text");

                    b.Property<string>("Line3")
                        .HasColumnType("text");

                    b.Property<string>("Pincode")
                        .HasColumnType("text");

                    b.Property<string>("Sate")
                        .HasColumnType("text");

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
                        .HasColumnType("int");

                    b.Property<DateTime?>("From")
                        .HasColumnType("datetime");

                    b.Property<string>("Responsibilty")
                        .HasColumnType("text");

                    b.Property<int>("StaffId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("To")
                        .HasColumnType("datetime");

                    b.HasKey("StaffExperienceId");

                    b.HasIndex("StaffId");

                    b.ToTable("StaffExperience");
                });

            modelBuilder.Entity("SMS.Models.Student", b =>
                {
                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.Property<string>("AadharNumber")
                        .HasColumnType("text");

                    b.Property<int>("AcademicPrecentage")
                        .HasColumnType("int");

                    b.Property<DateTime>("AdmissionDate")
                        .HasColumnType("datetime");

                    b.Property<int>("AdmissionNumber")
                        .HasColumnType("int");

                    b.Property<string>("BloodGroup")
                        .HasColumnType("text");

                    b.Property<string>("Class")
                        .HasColumnType("text");

                    b.Property<string>("CurrentCity")
                        .HasColumnType("text");

                    b.Property<string>("CurrentCountry")
                        .HasColumnType("text");

                    b.Property<string>("CurrentLine1")
                        .HasColumnType("text");

                    b.Property<string>("CurrentLine2")
                        .HasColumnType("text");

                    b.Property<string>("CurrentLine3")
                        .HasColumnType("text");

                    b.Property<string>("CurrentPincode")
                        .HasColumnType("text");

                    b.Property<string>("CurrentSate")
                        .HasColumnType("text");

                    b.Property<DateTime>("Dob")
                        .HasColumnType("datetime");

                    b.Property<string>("EmailId")
                        .HasColumnType("text");

                    b.Property<string>("EmisNumber")
                        .HasColumnType("text");

                    b.Property<string>("FatherAadharNumber")
                        .HasColumnType("text");

                    b.Property<long>("FatherAnnualIncome")
                        .HasColumnType("bigint");

                    b.Property<bool>("FatherBvEmployee")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("FatherCompany")
                        .HasColumnType("text");

                    b.Property<string>("FatherDesignation")
                        .HasColumnType("text");

                    b.Property<string>("FatherEmail")
                        .HasColumnType("text");

                    b.Property<string>("FatherFirstName")
                        .HasColumnType("text");

                    b.Property<string>("FatherLastName")
                        .HasColumnType("text");

                    b.Property<string>("FatherMiddleName")
                        .HasColumnType("text");

                    b.Property<long>("FatherMobileNumber")
                        .HasColumnType("bigint");

                    b.Property<string>("FatherOccupation")
                        .HasColumnType("text");

                    b.Property<string>("FatherSalutationId")
                        .HasColumnType("text");

                    b.Property<string>("FirstLanguage")
                        .HasColumnType("text");

                    b.Property<string>("FirstName")
                        .HasColumnType("text");

                    b.Property<string>("Gender")
                        .HasColumnType("text");

                    b.Property<string>("LastName")
                        .HasColumnType("text");

                    b.Property<string>("LegalAadharNumber")
                        .HasColumnType("text");

                    b.Property<long>("LegalAnnualIncome")
                        .HasColumnType("bigint");

                    b.Property<bool>("LegalBvEmployee")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("LegalCompany")
                        .HasColumnType("text");

                    b.Property<string>("LegalDesignation")
                        .HasColumnType("text");

                    b.Property<string>("LegalEmail")
                        .HasColumnType("text");

                    b.Property<string>("LegalFirstName")
                        .HasColumnType("text");

                    b.Property<string>("LegalLastName")
                        .HasColumnType("text");

                    b.Property<string>("LegalMiddleName")
                        .HasColumnType("text");

                    b.Property<long>("LegalMobileNumber")
                        .HasColumnType("bigint");

                    b.Property<string>("LegalOccupation")
                        .HasColumnType("text");

                    b.Property<string>("LegalSalutationId")
                        .HasColumnType("text");

                    b.Property<string>("LocalGuardianAadharNumber")
                        .HasColumnType("text");

                    b.Property<long>("LocalGuardianAnnualIncome")
                        .HasColumnType("bigint");

                    b.Property<bool>("LocalGuardianBvEmployee")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("LocalGuardianCompany")
                        .HasColumnType("text");

                    b.Property<string>("LocalGuardianDesignation")
                        .HasColumnType("text");

                    b.Property<string>("LocalGuardianEmail")
                        .HasColumnType("text");

                    b.Property<string>("LocalGuardianFirstName")
                        .HasColumnType("text");

                    b.Property<string>("LocalGuardianLastName")
                        .HasColumnType("text");

                    b.Property<string>("LocalGuardianMiddleName")
                        .HasColumnType("text");

                    b.Property<long>("LocalGuardianMobileNumber")
                        .HasColumnType("bigint");

                    b.Property<string>("LocalGuardianOccupation")
                        .HasColumnType("text");

                    b.Property<string>("LocalGuardianSalutationId")
                        .HasColumnType("text");

                    b.Property<string>("MiddleName")
                        .HasColumnType("text");

                    b.Property<long>("Mobile")
                        .HasColumnType("bigint");

                    b.Property<string>("MotherAadharNumber")
                        .HasColumnType("text");

                    b.Property<long>("MotherAnnualIncome")
                        .HasColumnType("bigint");

                    b.Property<bool>("MotherBvEmployee")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("MotherCompany")
                        .HasColumnType("text");

                    b.Property<string>("MotherDesignation")
                        .HasColumnType("text");

                    b.Property<string>("MotherEmail")
                        .HasColumnType("text");

                    b.Property<string>("MotherFirstName")
                        .HasColumnType("text");

                    b.Property<string>("MotherLastName")
                        .HasColumnType("text");

                    b.Property<string>("MotherMiddleName")
                        .HasColumnType("text");

                    b.Property<long>("MotherMobileNumber")
                        .HasColumnType("bigint");

                    b.Property<string>("MotherOccupation")
                        .HasColumnType("text");

                    b.Property<string>("MotherSalutationId")
                        .HasColumnType("text");

                    b.Property<int?>("NationalityId")
                        .HasColumnType("int");

                    b.Property<string>("PermenantCity")
                        .HasColumnType("text");

                    b.Property<string>("PermenantCountry")
                        .HasColumnType("text");

                    b.Property<string>("PermenantLine1")
                        .HasColumnType("text");

                    b.Property<string>("PermenantLine2")
                        .HasColumnType("text");

                    b.Property<string>("PermenantLine3")
                        .HasColumnType("text");

                    b.Property<string>("PermenantPincode")
                        .HasColumnType("text");

                    b.Property<string>("PermenantSate")
                        .HasColumnType("text");

                    b.Property<string>("ReasonForLeaving")
                        .HasColumnType("text");

                    b.Property<int?>("ReligionId")
                        .HasColumnType("int");

                    b.Property<string>("RollNo")
                        .HasColumnType("text");

                    b.Property<string>("Salutation")
                        .HasColumnType("text");

                    b.Property<string>("SecondLanguage")
                        .HasColumnType("text");

                    b.Property<string>("Section")
                        .HasColumnType("text");

                    b.Property<int?>("passingOutSchool")
                        .HasColumnType("int");

                    b.Property<int?>("schoolBrand")
                        .HasColumnType("int");

                    b.Property<string>("schoolName")
                        .HasColumnType("text");

                    b.Property<int?>("yearofattendence")
                        .HasColumnType("int");

                    b.HasKey("StudentId");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("SMS.Models.Transport.BusTrip", b =>
                {
                    b.Property<int>("BusTripid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("BusesAndDriverId")
                        .HasColumnType("int");

                    b.Property<int?>("StudentId")
                        .HasColumnType("int");

                    b.Property<int>("TotalHeadCount")
                        .HasColumnType("int");

                    b.Property<string>("TripAreas")
                        .HasColumnType("text");

                    b.Property<int>("TripNumber")
                        .HasColumnType("int");

                    b.Property<TimeSpan>("TripTimingFrom")
                        .HasColumnType("time");

                    b.Property<TimeSpan>("TripTimingTo")
                        .HasColumnType("time");

                    b.HasKey("BusTripid");

                    b.HasIndex("BusesAndDriverId");

                    b.HasIndex("StudentId");

                    b.ToTable("BusTrips");
                });

            modelBuilder.Entity("SMS.Models.Transport.BusType", b =>
                {
                    b.Property<int>("BusTypeid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("BusTypeDesc")
                        .HasColumnType("text");

                    b.HasKey("BusTypeid");

                    b.ToTable("BusTypes");
                });

            modelBuilder.Entity("SMS.Models.Transport.BusesAndDriver", b =>
                {
                    b.Property<int>("BusesAndDriverId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("BusNumber")
                        .HasColumnType("text");

                    b.Property<int>("BusTypeid")
                        .HasColumnType("int");

                    b.Property<string>("DriverAadhar")
                        .HasColumnType("text");

                    b.Property<string>("DriverName")
                        .HasColumnType("text");

                    b.Property<int>("DriverNumber")
                        .HasColumnType("int");

                    b.Property<DateTime>("InsuranceEndDate")
                        .HasColumnType("datetime");

                    b.Property<string>("InsurancePolicyNum")
                        .HasColumnType("text");

                    b.Property<int>("NotificationSpanId")
                        .HasColumnType("int");

                    b.Property<int>("SeatCount")
                        .HasColumnType("int");

                    b.Property<string>("company")
                        .HasColumnType("text");

                    b.HasKey("BusesAndDriverId");

                    b.HasIndex("BusTypeid");

                    b.HasIndex("NotificationSpanId");

                    b.ToTable("BusesAndDrivers");
                });

            modelBuilder.Entity("SMS.Models.Transport.NotificationSpan", b =>
                {
                    b.Property<int>("NotificationSpanId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("NotificationSpanDesc")
                        .HasColumnType("text");

                    b.HasKey("NotificationSpanId");

                    b.ToTable("NotificationSpans");
                });

            modelBuilder.Entity("WebApi.Entities.Account", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("AcceptTerms")
                        .HasColumnType("int");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime");

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<string>("FirstName")
                        .HasColumnType("text");

                    b.Property<string>("LastName")
                        .HasColumnType("text");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("text");

                    b.Property<DateTime?>("PasswordReset")
                        .HasColumnType("datetime");

                    b.Property<string>("ResetToken")
                        .HasColumnType("text");

                    b.Property<DateTime?>("ResetTokenExpires")
                        .HasColumnType("datetime");

                    b.Property<int>("Role")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("text");

                    b.Property<DateTime?>("Updated")
                        .HasColumnType("datetime");

                    b.Property<string>("VerificationToken")
                        .HasColumnType("text");

                    b.Property<DateTime?>("Verified")
                        .HasColumnType("datetime");

                    b.HasKey("Id");

                    b.ToTable("Accounts");
                });

            modelBuilder.Entity("SMS.Models.Inventory.Inventory", b =>
                {
                    b.HasOne("SMS.Models.Inventory.InventoryItemType", "InventoryItemType")
                        .WithMany()
                        .HasForeignKey("InventoryItemTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SMS.Models.Inventory.InventoryItemUsageArea", "InventoryItemUsageArea")
                        .WithMany()
                        .HasForeignKey("InventoryItemUsageAreaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("InventoryItemType");

                    b.Navigation("InventoryItemUsageArea");
                });

            modelBuilder.Entity("SMS.Models.Inventory.InventoryDefect", b =>
                {
                    b.HasOne("SMS.Models.Inventory.InventoryItemType", "InventoryItemType")
                        .WithMany()
                        .HasForeignKey("InventoryItemTypeId");

                    b.HasOne("SMS.Models.Inventory.InventoryItemUsageArea", "InventoryItemUsageArea")
                        .WithMany()
                        .HasForeignKey("InventoryItemUsageAreaId");

                    b.Navigation("InventoryItemType");

                    b.Navigation("InventoryItemUsageArea");
                });

            modelBuilder.Entity("SMS.Models.Leave.StaffLeave", b =>
                {
                    b.HasOne("SMS.Models.Staff", "Staffs")
                        .WithMany()
                        .HasForeignKey("StaffId");

                    b.Navigation("Staffs");
                });

            modelBuilder.Entity("SMS.Models.Leave.StudentLeave", b =>
                {
                    b.HasOne("SMS.Models.Student", "Students")
                        .WithMany()
                        .HasForeignKey("StudentId");

                    b.Navigation("Students");
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

            modelBuilder.Entity("SMS.Models.Transport.BusTrip", b =>
                {
                    b.HasOne("SMS.Models.Transport.BusesAndDriver", "BusesAndDrivers")
                        .WithMany()
                        .HasForeignKey("BusesAndDriverId");

                    b.HasOne("SMS.Models.Student", "Student")
                        .WithMany()
                        .HasForeignKey("StudentId");

                    b.Navigation("BusesAndDrivers");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("SMS.Models.Transport.BusesAndDriver", b =>
                {
                    b.HasOne("SMS.Models.Transport.BusType", "BusType")
                        .WithMany()
                        .HasForeignKey("BusTypeid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SMS.Models.Transport.NotificationSpan", "NotificationSpan")
                        .WithMany()
                        .HasForeignKey("NotificationSpanId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("BusType");

                    b.Navigation("NotificationSpan");
                });

            modelBuilder.Entity("WebApi.Entities.Account", b =>
                {
                    b.OwnsMany("WebApi.Entities.RefreshToken", "RefreshTokens", b1 =>
                        {
                            b1.Property<int>("Id")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("int");

                            b1.Property<int>("AccountId")
                                .HasColumnType("int");

                            b1.Property<DateTime>("Created")
                                .HasColumnType("datetime");

                            b1.Property<string>("CreatedByIp")
                                .HasColumnType("text");

                            b1.Property<DateTime>("Expires")
                                .HasColumnType("datetime");

                            b1.Property<string>("ReplacedByToken")
                                .HasColumnType("text");

                            b1.Property<DateTime?>("Revoked")
                                .HasColumnType("datetime");

                            b1.Property<string>("RevokedByIp")
                                .HasColumnType("text");

                            b1.Property<string>("Token")
                                .HasColumnType("text");

                            b1.HasKey("Id");

                            b1.HasIndex("AccountId");

                            b1.ToTable("RefreshToken");

                            b1.WithOwner("Account")
                                .HasForeignKey("AccountId");

                            b1.Navigation("Account");
                        });

                    b.Navigation("RefreshTokens");
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
