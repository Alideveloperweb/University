using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace University_EfCore.Migrations
{
    /// <inheritdoc />
    public partial class Add_Table : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EmploymentStatus",
                table: "Employee");

            migrationBuilder.AddColumn<string>(
                name: "Username",
                table: "Employee",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "Certifications",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastUpdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsRemove = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Certifications", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RecentProjects",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastUpdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsRemove = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RecentProjects", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Skills",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastUpdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsRemove = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Skills", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CertificationsEmployee",
                columns: table => new
                {
                    CertificationsEmployeeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CertificationsId = table.Column<int>(type: "int", nullable: false),
                    EmployeeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CertificationsEmployee", x => x.CertificationsEmployeeId);
                    table.ForeignKey(
                        name: "FK_CertificationsEmployee_Certifications_CertificationsId",
                        column: x => x.CertificationsId,
                        principalTable: "Certifications",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CertificationsEmployee_Employee_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employee",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RecentProjectsEmployee",
                columns: table => new
                {
                    RecentProjectsEmployeeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RecentProjectsId = table.Column<int>(type: "int", nullable: false),
                    EmployeeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RecentProjectsEmployee", x => x.RecentProjectsEmployeeId);
                    table.ForeignKey(
                        name: "FK_RecentProjectsEmployee_Employee_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employee",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RecentProjectsEmployee_RecentProjects_RecentProjectsId",
                        column: x => x.RecentProjectsId,
                        principalTable: "RecentProjects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SkilsEmployee",
                columns: table => new
                {
                    SkilsEmployeeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SkillsId = table.Column<int>(type: "int", nullable: false),
                    EmployeeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SkilsEmployee", x => x.SkilsEmployeeId);
                    table.ForeignKey(
                        name: "FK_SkilsEmployee_Employee_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employee",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SkilsEmployee_Skills_SkillsId",
                        column: x => x.SkillsId,
                        principalTable: "Skills",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CertificationsEmployee_CertificationsId",
                table: "CertificationsEmployee",
                column: "CertificationsId");

            migrationBuilder.CreateIndex(
                name: "IX_CertificationsEmployee_EmployeeId",
                table: "CertificationsEmployee",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_RecentProjectsEmployee_EmployeeId",
                table: "RecentProjectsEmployee",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_RecentProjectsEmployee_RecentProjectsId",
                table: "RecentProjectsEmployee",
                column: "RecentProjectsId");

            migrationBuilder.CreateIndex(
                name: "IX_SkilsEmployee_EmployeeId",
                table: "SkilsEmployee",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_SkilsEmployee_SkillsId",
                table: "SkilsEmployee",
                column: "SkillsId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CertificationsEmployee");

            migrationBuilder.DropTable(
                name: "RecentProjectsEmployee");

            migrationBuilder.DropTable(
                name: "SkilsEmployee");

            migrationBuilder.DropTable(
                name: "Certifications");

            migrationBuilder.DropTable(
                name: "RecentProjects");

            migrationBuilder.DropTable(
                name: "Skills");

            migrationBuilder.DropColumn(
                name: "Username",
                table: "Employee");

            migrationBuilder.AddColumn<bool>(
                name: "EmploymentStatus",
                table: "Employee",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
