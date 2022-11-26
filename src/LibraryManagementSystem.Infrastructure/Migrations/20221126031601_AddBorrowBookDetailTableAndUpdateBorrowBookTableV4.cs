using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LibraryManagementSystem.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddBorrowBookDetailTableAndUpdateBorrowBookTableV4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
