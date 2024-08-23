using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace University_EfCore.Migrations
{
    /// <inheritdoc />
    public partial class add_Data : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Certifications",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    LastUpdate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    IsRemove = table.Column<bool>(type: "INTEGER", nullable: false),
                    IsActive = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Certifications", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    LastUpdate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    IsRemove = table.Column<bool>(type: "INTEGER", nullable: false),
                    IsActive = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Job",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(type: "TEXT", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    LastUpdate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    IsRemove = table.Column<bool>(type: "INTEGER", nullable: false),
                    IsActive = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Job", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RecentProjects",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    LastUpdate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    IsRemove = table.Column<bool>(type: "INTEGER", nullable: false),
                    IsActive = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RecentProjects", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Skills",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 30, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    LastUpdate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    IsRemove = table.Column<bool>(type: "INTEGER", nullable: false),
                    IsActive = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Skills", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    EmployeeNumber = table.Column<string>(type: "TEXT", maxLength: 200, nullable: false),
                    HireDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Salary = table.Column<decimal>(type: "TEXT", nullable: false),
                    IsActive = table.Column<bool>(type: "INTEGER", nullable: false),
                    WeeklyWorkingHours = table.Column<int>(type: "INTEGER", nullable: false),
                    RemainingLeaveDays = table.Column<int>(type: "INTEGER", nullable: false),
                    Supervisor = table.Column<string>(type: "TEXT", nullable: false),
                    PerformanceReview = table.Column<string>(type: "TEXT", nullable: false),
                    Password = table.Column<string>(type: "TEXT", nullable: false),
                    JobId = table.Column<int>(type: "INTEGER", nullable: false),
                    DepartmentId = table.Column<int>(type: "INTEGER", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    LastUpdate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    IsRemove = table.Column<bool>(type: "INTEGER", nullable: false),
                    Username = table.Column<string>(type: "TEXT", nullable: false),
                    FirstName = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false),
                    LastName = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    NationalCode = table.Column<string>(type: "TEXT", maxLength: 10, nullable: false),
                    Gender = table.Column<bool>(type: "INTEGER", nullable: false),
                    MaritalStatus = table.Column<bool>(type: "INTEGER", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "TEXT", maxLength: 80, nullable: false),
                    SpouseNationalID = table.Column<string>(type: "TEXT", maxLength: 11, nullable: false),
                    Mobile = table.Column<string>(type: "TEXT", maxLength: 11, nullable: false),
                    Homephone = table.Column<string>(type: "TEXT", maxLength: 11, nullable: false),
                    Email = table.Column<string>(type: "TEXT", maxLength: 300, nullable: false),
                    EmergencyContactNumber = table.Column<string>(type: "TEXT", maxLength: 11, nullable: false),
                    CountryName = table.Column<string>(type: "TEXT", maxLength: 60, nullable: false),
                    CityName = table.Column<string>(type: "TEXT", nullable: false),
                    Address = table.Column<string>(type: "TEXT", maxLength: 600, nullable: false),
                    LastEducationalCertificate = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false),
                    GPAOfThelastDegree = table.Column<double>(type: "REAL", maxLength: 20, nullable: false),
                    BloodType = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false),
                    MedicalHistory = table.Column<string>(type: "TEXT", maxLength: 200, nullable: false),
                    ImageName = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Employee_Departments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Departments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Employee_Job_JobId",
                        column: x => x.JobId,
                        principalTable: "Job",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CertificationsEmployee",
                columns: table => new
                {
                    CertificationsEmployeeId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CertificationsId = table.Column<int>(type: "INTEGER", nullable: false),
                    EmployeeId = table.Column<int>(type: "INTEGER", nullable: false)
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
                    RecentProjectsEmployeeId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    RecentProjectsId = table.Column<int>(type: "INTEGER", nullable: false),
                    EmployeeId = table.Column<int>(type: "INTEGER", nullable: false)
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
                    SkilsEmployeeId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    SkillsId = table.Column<int>(type: "INTEGER", nullable: false),
                    EmployeeId = table.Column<int>(type: "INTEGER", nullable: false)
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
                name: "IX_Employee_DepartmentId",
                table: "Employee",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_JobId",
                table: "Employee",
                column: "JobId");

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
                name: "Employee");

            migrationBuilder.DropTable(
                name: "Skills");

            migrationBuilder.DropTable(
                name: "Departments");

            migrationBuilder.DropTable(
                name: "Job");
        }
    }
}
