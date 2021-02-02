using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SMS.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    DepartmentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepartmentName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.DepartmentId);
                });

            migrationBuilder.CreateTable(
                name: "Designations",
                columns: table => new
                {
                    DesignationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DesignationName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Designations", x => x.DesignationId);
                });

            migrationBuilder.CreateTable(
                name: "Functions",
                columns: table => new
                {
                    FunctionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Decription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DisplayValue = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DisplayOrder = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ParentFunctionId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Functions", x => x.FunctionId);
                });

            migrationBuilder.CreateTable(
                name: "Nationalities",
                columns: table => new
                {
                    NationalityId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NationalityName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nationalities", x => x.NationalityId);
                });

            migrationBuilder.CreateTable(
                name: "Religions",
                columns: table => new
                {
                    ReligionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReligionName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Religions", x => x.ReligionId);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    RoleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.RoleId);
                });

            migrationBuilder.CreateTable(
                name: "Persons",
                columns: table => new
                {
                    PersonId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmailId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mobile = table.Column<long>(type: "bigint", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Salt = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AuthToken = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RoleId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MiddleName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Dob = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CurrentAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PermanentAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AadharNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BloodGroup = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NationalityId = table.Column<int>(type: "int", nullable: true),
                    ReligionId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Persons", x => x.PersonId);
                    table.ForeignKey(
                        name: "FK_Persons_Nationalities_NationalityId",
                        column: x => x.NationalityId,
                        principalTable: "Nationalities",
                        principalColumn: "NationalityId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Persons_Religions_ReligionId",
                        column: x => x.ReligionId,
                        principalTable: "Religions",
                        principalColumn: "ReligionId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RoleFunctions",
                columns: table => new
                {
                    RoleFunctionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    FunctionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleFunctions", x => x.RoleFunctionId);
                    table.ForeignKey(
                        name: "FK_RoleFunctions_Functions_FunctionId",
                        column: x => x.FunctionId,
                        principalTable: "Functions",
                        principalColumn: "FunctionId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RoleFunctions_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "RoleId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Staffs",
                columns: table => new
                {
                    StaffId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PersonId = table.Column<int>(type: "int", nullable: false),
                    StaffType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ESINumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EPFNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UANNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReportingTo = table.Column<int>(type: "int", nullable: false),
                    JoiningDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    OfficialEmailId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TeacherId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BankName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BankBranch = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BankAccountNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BankIfscCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PanNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FatherName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MotherName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SpouseName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FatherOccupation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MotherOccupation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SpouseOccupation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FatherMobileNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MotherMobileNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SpouseMobileNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DepartmentId = table.Column<int>(type: "int", nullable: true),
                    DesignationId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Staffs", x => x.StaffId);
                    table.ForeignKey(
                        name: "FK_Staffs_Departments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Departments",
                        principalColumn: "DepartmentId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Staffs_Designations_DesignationId",
                        column: x => x.DesignationId,
                        principalTable: "Designations",
                        principalColumn: "DesignationId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Staffs_Persons_PersonId",
                        column: x => x.PersonId,
                        principalTable: "Persons",
                        principalColumn: "PersonId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    StudentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PersonId = table.Column<int>(type: "int", nullable: false),
                    EmisNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RollNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirstLanguage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecondLanguage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdmissionDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Class = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Section = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FathersSalutation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FathersFirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FathersMiddleName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FathersLastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FathersMobileNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FathersOccupation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FathersOrganization = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FathersDesignation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FathersAnnualIncome = table.Column<long>(type: "bigint", nullable: false),
                    FathersAadharNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MothersSalutation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MothersFirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MothersMiddleName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MothersLastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MothersMobileNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MothersOccupation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MothersOrganization = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MothersDesignation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MothersAnnualIncome = table.Column<long>(type: "bigint", nullable: false),
                    MothersAadharNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LocalGaurdianSalutation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LocalGaurdianFirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LocalGaurdianMiddleName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LocalGaurdianLastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LocalGaurdianMobileNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LocalGaurdianOccupation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LocalGaurdianOrganization = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LocalGaurdianDesignation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LocalGaurdianAnnualIncome = table.Column<long>(type: "bigint", nullable: false),
                    LocalGaurdianAadharNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LegalGaurdianSalutation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LegalGaurdianFirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LegalGaurdianMiddleName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LegalGaurdianLastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LegalGaurdianMobileNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LegalGaurdianOccupation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LegalGaurdianOrganization = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LegalGaurdianDesignation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LegalGaurdianAnnualIncome = table.Column<long>(type: "bigint", nullable: false),
                    LegalGaurdianAadharNumber = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.StudentId);
                    table.ForeignKey(
                        name: "FK_Students_Persons_PersonId",
                        column: x => x.PersonId,
                        principalTable: "Persons",
                        principalColumn: "PersonId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Persons_NationalityId",
                table: "Persons",
                column: "NationalityId");

            migrationBuilder.CreateIndex(
                name: "IX_Persons_ReligionId",
                table: "Persons",
                column: "ReligionId");

            migrationBuilder.CreateIndex(
                name: "IX_RoleFunctions_FunctionId",
                table: "RoleFunctions",
                column: "FunctionId");

            migrationBuilder.CreateIndex(
                name: "IX_RoleFunctions_RoleId",
                table: "RoleFunctions",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_Staffs_DepartmentId",
                table: "Staffs",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Staffs_DesignationId",
                table: "Staffs",
                column: "DesignationId");

            migrationBuilder.CreateIndex(
                name: "IX_Staffs_PersonId",
                table: "Staffs",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_PersonId",
                table: "Students",
                column: "PersonId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RoleFunctions");

            migrationBuilder.DropTable(
                name: "Staffs");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "Functions");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Departments");

            migrationBuilder.DropTable(
                name: "Designations");

            migrationBuilder.DropTable(
                name: "Persons");

            migrationBuilder.DropTable(
                name: "Nationalities");

            migrationBuilder.DropTable(
                name: "Religions");
        }
    }
}
