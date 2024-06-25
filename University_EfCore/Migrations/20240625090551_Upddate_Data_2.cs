using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace University_EfCore.Migrations
{
    /// <inheritdoc />
    public partial class Upddate_Data_2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageName",
                table: "Employee",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageName",
                table: "Employee");
        }
    }
}
