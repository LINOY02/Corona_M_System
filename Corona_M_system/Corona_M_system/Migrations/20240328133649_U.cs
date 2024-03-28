using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Corona_M_system.Migrations
{
    public partial class U : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserInfoId",
                table: "Vaccination",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "UserInfo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Street = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StreetNum = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CellPhone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RecoveryDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PositiveResult = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserInfo", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Vaccination_UserInfoId",
                table: "Vaccination",
                column: "UserInfoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Vaccination_UserInfo_UserInfoId",
                table: "Vaccination",
                column: "UserInfoId",
                principalTable: "UserInfo",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vaccination_UserInfo_UserInfoId",
                table: "Vaccination");

            migrationBuilder.DropTable(
                name: "UserInfo");

            migrationBuilder.DropIndex(
                name: "IX_Vaccination_UserInfoId",
                table: "Vaccination");

            migrationBuilder.DropColumn(
                name: "UserInfoId",
                table: "Vaccination");
        }
    }
}
