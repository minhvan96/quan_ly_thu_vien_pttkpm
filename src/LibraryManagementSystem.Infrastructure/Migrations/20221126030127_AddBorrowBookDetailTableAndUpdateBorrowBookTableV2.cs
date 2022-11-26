using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LibraryManagementSystem.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddBorrowBookDetailTableAndUpdateBorrowBookTableV2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "BorrowBookId",
                table: "BorrowBookDetails",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_BorrowBookDetails_BorrowBookId",
                table: "BorrowBookDetails",
                column: "BorrowBookId");

            migrationBuilder.AddForeignKey(
                name: "FK_BorrowBookDetails_BorrowBooks_BorrowBookId",
                table: "BorrowBookDetails",
                column: "BorrowBookId",
                principalTable: "BorrowBooks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BorrowBookDetails_BorrowBooks_BorrowBookId",
                table: "BorrowBookDetails");

            migrationBuilder.DropIndex(
                name: "IX_BorrowBookDetails_BorrowBookId",
                table: "BorrowBookDetails");

            migrationBuilder.DropColumn(
                name: "BorrowBookId",
                table: "BorrowBookDetails");
        }
    }
}
