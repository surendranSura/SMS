using Microsoft.EntityFrameworkCore.Migrations;

namespace SMS.Migrations
{
    public partial class updstaffandaddressarray : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Persons_Address_AddressId",
                table: "Persons");

            migrationBuilder.DropIndex(
                name: "IX_StaffExperience_StaffId",
                table: "StaffExperience");

            migrationBuilder.DropIndex(
                name: "IX_Persons_AddressId",
                table: "Persons");

            migrationBuilder.CreateTable(
                name: "AddressPerson",
                columns: table => new
                {
                    CurrentAddressAddressId = table.Column<int>(type: "int", nullable: false),
                    PeoplePersonId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AddressPerson", x => new { x.CurrentAddressAddressId, x.PeoplePersonId });
                    table.ForeignKey(
                        name: "FK_AddressPerson_Address_CurrentAddressAddressId",
                        column: x => x.CurrentAddressAddressId,
                        principalTable: "Address",
                        principalColumn: "AddressId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AddressPerson_Persons_PeoplePersonId",
                        column: x => x.PeoplePersonId,
                        principalTable: "Persons",
                        principalColumn: "PersonId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_StaffExperience_StaffId",
                table: "StaffExperience",
                column: "StaffId");

            migrationBuilder.CreateIndex(
                name: "IX_AddressPerson_PeoplePersonId",
                table: "AddressPerson",
                column: "PeoplePersonId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AddressPerson");

            migrationBuilder.DropIndex(
                name: "IX_StaffExperience_StaffId",
                table: "StaffExperience");

            migrationBuilder.CreateIndex(
                name: "IX_StaffExperience_StaffId",
                table: "StaffExperience",
                column: "StaffId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Persons_AddressId",
                table: "Persons",
                column: "AddressId");

            migrationBuilder.AddForeignKey(
                name: "FK_Persons_Address_AddressId",
                table: "Persons",
                column: "AddressId",
                principalTable: "Address",
                principalColumn: "AddressId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
