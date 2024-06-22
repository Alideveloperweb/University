using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace University_EfCore.Migrations
{
    /// <inheritdoc />
    public partial class Create_Table_Person : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Person",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    NationalCode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Mobile = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false),
                    Homephone = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    CountryName = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    CityName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(600)", maxLength: 600, nullable: false),
                    LastEducationalCertificate = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    GPAOfThelastDegree = table.Column<double>(type: "float", maxLength: 20, nullable: false),
                    Gender = table.Column<bool>(type: "bit", nullable: false),
                    MaritalStatus = table.Column<bool>(type: "bit", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", maxLength: 80, nullable: false),
                    EmergencyContactNumber = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false),
                    PostalCode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    SpouseNationalID = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false),
                    BloodType = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    MedicalHistory = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastUpdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsRemove = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Person", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Person");
        }
    }
}
