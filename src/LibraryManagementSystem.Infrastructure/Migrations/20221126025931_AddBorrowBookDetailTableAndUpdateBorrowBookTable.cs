using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LibraryManagementSystem.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddBorrowBookDetailTableAndUpdateBorrowBookTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BorrowBooks_Books_BookId",
                table: "BorrowBooks");

            migrationBuilder.DropIndex(
                name: "IX_BorrowBooks_BookId",
                table: "BorrowBooks");

            migrationBuilder.DropColumn(
                name: "BookId",
                table: "BorrowBooks");

            migrationBuilder.DropColumn(
                name: "IsReturnBook",
                table: "BorrowBooks");

            migrationBuilder.CreateTable(
                name: "BorrowBookDetails",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BookId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsReturnBook = table.Column<bool>(type: "bit", nullable: false),
                    ReturnDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    CreatedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    UpdatedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BorrowBookDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BorrowBookDetails_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BorrowBookDetails_BookId",
                table: "BorrowBookDetails",
                column: "BookId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BorrowBookDetails");

            migrationBuilder.AddColumn<Guid>(
                name: "BookId",
                table: "BorrowBooks",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<bool>(
                name: "IsReturnBook",
                table: "BorrowBooks",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateIndex(
                name: "IX_BorrowBooks_BookId",
                table: "BorrowBooks",
                column: "BookId");

            migrationBuilder.AddForeignKey(
                name: "FK_BorrowBookDetails_Books_BookId",
                table: "BorrowBooks",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
