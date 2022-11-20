using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LibraryManagementSystem.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class UpdateLibraryConfiguration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "LibraryConfigurations",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "LibraryConfigurations",
                type: "nvarchar(254)",
                maxLength: 254,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Value",
                table: "LibraryConfigurations",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Code",
                table: "LibraryConfigurations");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "LibraryConfigurations");

            migrationBuilder.DropColumn(
                name: "Value",
                table: "LibraryConfigurations");
        }
    }
}
