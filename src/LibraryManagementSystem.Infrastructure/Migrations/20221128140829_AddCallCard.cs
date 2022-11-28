using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LibraryManagementSystem.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddCallCard : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CallCards_LibraryCards_LibraryCardId1",
                table: "CallCards");

            migrationBuilder.DropIndex(
                name: "IX_CallCards_LibraryCardId1",
                table: "CallCards");

            migrationBuilder.DropColumn(
                name: "LibraryCardId1",
                table: "CallCards");

            migrationBuilder.AddColumn<Guid>(
                name: "LibraryCardId",
                table: "CallCards",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateTable(
                name: "CallCardDetails",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CalLCardId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BookId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    UpdatedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CallCardDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CallCardDetails_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CallCardDetails_CallCards_CalLCardId",
                        column: x => x.CalLCardId,
                        principalTable: "CallCards",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CallCards_LibraryCardId",
                table: "CallCards",
                column: "LibraryCardId");

            migrationBuilder.CreateIndex(
                name: "IX_CallCardDetails_BookId",
                table: "CallCardDetails",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_CallCardDetails_CalLCardId",
                table: "CallCardDetails",
                column: "CalLCardId");

            migrationBuilder.AddForeignKey(
                name: "FK_CallCards_LibraryCards_LibraryCardId",
                table: "CallCards",
                column: "LibraryCardId",
                principalTable: "LibraryCards",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CallCards_LibraryCards_LibraryCardId",
                table: "CallCards");

            migrationBuilder.DropTable(
                name: "CallCardDetails");

            migrationBuilder.DropIndex(
                name: "IX_CallCards_LibraryCardId",
                table: "CallCards");

            migrationBuilder.DropColumn(
                name: "BorrowDate",
                table: "CallCards");

            migrationBuilder.DropColumn(
                name: "LibraryCardId",
                table: "CallCards");

            migrationBuilder.CreateTable(
                name: "BorrowBooks",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ReaderId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BorrowDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    CreatedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    UpdatedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BorrowBooks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BorrowBooks_Readers_ReaderId",
                        column: x => x.ReaderId,
                        principalTable: "Readers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BorrowBookDetails",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BookId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BorrowBookId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    IsReturnBook = table.Column<bool>(type: "bit", nullable: false),
                    ReturnDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
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
                    table.ForeignKey(
                        name: "FK_BorrowBookDetails_BorrowBooks_BorrowBookId",
                        column: x => x.BorrowBookId,
                        principalTable: "BorrowBooks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BorrowBookDetails_BookId",
                table: "BorrowBookDetails",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_BorrowBookDetails_BorrowBookId",
                table: "BorrowBookDetails",
                column: "BorrowBookId");

            migrationBuilder.CreateIndex(
                name: "IX_BorrowBooks_ReaderId",
                table: "BorrowBooks",
                column: "ReaderId");
        }
    }
}
