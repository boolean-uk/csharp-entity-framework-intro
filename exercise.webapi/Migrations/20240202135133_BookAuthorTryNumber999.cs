using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace exercise.webapi.Migrations
{
    /// <inheritdoc />
    public partial class BookAuthorTryNumber999 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_books_authors_author_id",
                table: "books");

            migrationBuilder.DropIndex(
                name: "IX_books_author_id",
                table: "books");

            migrationBuilder.DropColumn(
                name: "author_id",
                table: "books");

            migrationBuilder.CreateTable(
                name: "book_authors",
                columns: table => new
                {
                    bookauthor_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    fk_book_id = table.Column<int>(type: "integer", nullable: false),
                    fk_author_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_book_authors", x => x.bookauthor_id);
                    table.ForeignKey(
                        name: "FK_book_authors_authors_fk_author_id",
                        column: x => x.fk_author_id,
                        principalTable: "authors",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_book_authors_books_fk_book_id",
                        column: x => x.fk_book_id,
                        principalTable: "books",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "email", "first_name" },
                values: new object[] { "jimi.winfrey@gov.gr", "Jimi" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.jagger@bbc.co.uk", "Kate", "Jagger" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "charles.hepburn@bbc.co.uk", "Charles", "Hepburn" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.winslet@nasa.org.us", "Kate", "Winslet" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "email", "last_name" },
                values: new object[] { "barack.obama@something.com", "Obama" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "audrey.jagger@bbc.co.uk", "Audrey", "Jagger" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "email", "last_name" },
                values: new object[] { "kate.presley@something.com", "Presley" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "donald.obama@tesla.com", "Donald", "Obama" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.windsor@bbc.co.uk", "Kate", "Windsor" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "charles.jagger@bbc.co.uk", "Charles", "Jagger" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "jimi.winfrey@gov.nl", "Jimi", "Winfrey" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "donald.presley@nasa.org.us", "Donald", "Presley" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "mick.presley@tesla.com", "Mick", "Presley" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "email", "first_name" },
                values: new object[] { "jimi.winfrey@google.com", "Jimi" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "elvis.middleton@google.com", "Elvis", "Middleton" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "audrey.winfrey@gov.nl", "Audrey", "Winfrey" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "audrey.winslet@bbc.co.uk", "Audrey", "Winslet" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "oprah.jagger@gov.ru", "Oprah", "Jagger" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "elvis.hepburn@gov.gr", "Elvis", "Hepburn" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.jagger@gov.ru", "Kate", "Jagger" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.hepburn@tesla.com", "Kate", "Hepburn" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "mick.windsor@gov.gr", "Mick", "Windsor" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.obama@gov.us", "Kate", "Obama" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "charles.presley@gov.us", "Charles", "Presley" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "barack.winslet@theworld.ca", "Barack", "Winslet" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "audrey.windsor@gov.ru", "Audrey", "Windsor" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "mick.obama@theworld.ca", "Mick", "Obama" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "donald.winfrey@gov.us", "Donald", "Winfrey" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "email", "last_name" },
                values: new object[] { "charles.winslet@bbc.co.uk", "Winslet" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "elvis.windsor@nasa.org.us", "Elvis", "Windsor" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "donald.presley@tesla.com", "Donald", "Presley" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "email", "last_name" },
                values: new object[] { "barack.windsor@theworld.ca", "Windsor" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 33,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "charles.middleton@gov.gr", "Charles", "Middleton" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 34,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "barack.winfrey@bbc.co.uk", "Barack", "Winfrey" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 35,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "charles.hepburn@theworld.ca", "Charles", "Hepburn" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 36,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.obama@google.com", "Kate", "Obama" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 37,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "barack.presley@theworld.ca", "Barack", "Presley" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 38,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "oprah.trump@theworld.ca", "Oprah", "Trump" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 39,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "mick.obama@tesla.com", "Mick", "Obama" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 40,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "mick.hendrix@something.com", "Mick", "Hendrix" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 41,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.trump@tesla.com", "Kate", "Trump" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 42,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "donald.middleton@theworld.ca", "Donald", "Middleton" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 43,
                columns: new[] { "email", "last_name" },
                values: new object[] { "jimi.winfrey@something.com", "Winfrey" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 44,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "donald.middleton@gov.gr", "Donald", "Middleton" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 45,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "charles.jagger@gov.ru", "Charles", "Jagger" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 46,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "charles.obama@something.com", "Charles", "Obama" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 47,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "oprah.winfrey@bbc.co.uk", "Oprah", "Winfrey" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 48,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "charles.presley@google.com", "Charles", "Presley" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 49,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "barack.middleton@nasa.org.us", "Barack", "Middleton" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 50,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "barack.hepburn@nasa.org.us", "Barack", "Hepburn" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 51,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "jimi.middleton@gov.ru", "Jimi", "Middleton" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 52,
                columns: new[] { "email", "last_name" },
                values: new object[] { "kate.winslet@bbc.co.uk", "Winslet" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 53,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "oprah.presley@tesla.com", "Oprah", "Presley" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 54,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "charles.jagger@google.com", "Charles", "Jagger" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 55,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.jagger@something.com", "Kate", "Jagger" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 56,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "oprah.winfrey@gov.nl", "Oprah", "Winfrey" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 57,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "elvis.obama@gov.nl", "Elvis", "Obama" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 58,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "donald.windsor@nasa.org.us", "Donald", "Windsor" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 59,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.hendrix@gov.ru", "Kate", "Hendrix" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 60,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "jimi.presley@gov.ru", "Jimi", "Presley" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 61,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "donald.winfrey@gov.gr", "Donald", "Winfrey" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 62,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "oprah.winslet@nasa.org.us", "Oprah", "Winslet" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 63,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.windsor@gov.us", "Kate", "Windsor" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 64,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.winslet@gov.gr", "Kate", "Winslet" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 65,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.middleton@tesla.com", "Kate", "Middleton" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 66,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "donald.hepburn@gov.nl", "Donald", "Hepburn" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 67,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "donald.winslet@theworld.ca", "Donald", "Winslet" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 68,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.hepburn@tesla.com", "Kate", "Hepburn" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 69,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "elvis.middleton@theworld.ca", "Elvis", "Middleton" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 70,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "jimi.obama@gov.ru", "Jimi", "Obama" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 71,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "audrey.winslet@theworld.ca", "Audrey", "Winslet" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 72,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "donald.hepburn@something.com", "Donald", "Hepburn" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 73,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "jimi.presley@gov.gr", "Jimi", "Presley" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 74,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "barack.presley@gov.ru", "Barack", "Presley" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 75,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "mick.trump@something.com", "Mick", "Trump" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 76,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "oprah.trump@tesla.com", "Oprah", "Trump" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 77,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.winslet@gov.gr", "Kate", "Winslet" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 78,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.hepburn@something.com", "Kate", "Hepburn" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 79,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "jimi.hendrix@theworld.ca", "Jimi", "Hendrix" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 80,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.windsor@something.com", "Kate", "Windsor" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 81,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "audrey.hendrix@tesla.com", "Audrey", "Hendrix" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 82,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "donald.winslet@gov.us", "Donald", "Winslet" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 83,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.obama@something.com", "Kate", "Obama" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 84,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "barack.obama@google.com", "Barack", "Obama" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 85,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "elvis.middleton@google.com", "Elvis", "Middleton" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 86,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "oprah.winslet@gov.ru", "Oprah", "Winslet" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 87,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.middleton@gov.gr", "Kate", "Middleton" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 88,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "charles.trump@something.com", "Charles", "Trump" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 89,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "charles.middleton@something.com", "Charles", "Middleton" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 90,
                columns: new[] { "email", "first_name" },
                values: new object[] { "mick.trump@google.com", "Mick" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 91,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "barack.winslet@something.com", "Barack", "Winslet" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 92,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "charles.hepburn@tesla.com", "Charles", "Hepburn" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 93,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "mick.obama@nasa.org.us", "Mick", "Obama" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 94,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "barack.middleton@theworld.ca", "Barack", "Middleton" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 95,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "oprah.winfrey@gov.ru", "Oprah", "Winfrey" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 96,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "jimi.obama@bbc.co.uk", "Jimi", "Obama" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 97,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "barack.obama@google.com", "Barack", "Obama" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 98,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "charles.windsor@gov.us", "Charles", "Windsor" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 99,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "elvis.winfrey@google.com", "Elvis", "Winfrey" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 100,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "mick.winfrey@google.com", "Mick", "Winfrey" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 101,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.hepburn@gov.ru", "Kate", "Hepburn" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 102,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "elvis.presley@nasa.org.us", "Elvis", "Presley" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 103,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "donald.winfrey@nasa.org.us", "Donald", "Winfrey" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 104,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "jimi.middleton@google.com", "Jimi", "Middleton" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 105,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.hendrix@tesla.com", "Kate", "Hendrix" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 106,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "oprah.presley@something.com", "Oprah", "Presley" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 107,
                columns: new[] { "email", "first_name" },
                values: new object[] { "jimi.trump@tesla.com", "Jimi" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 108,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.windsor@something.com", "Kate", "Windsor" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 109,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "mick.winfrey@theworld.ca", "Mick", "Winfrey" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 110,
                columns: new[] { "email", "last_name" },
                values: new object[] { "jimi.hendrix@gov.nl", "Hendrix" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 111,
                columns: new[] { "email", "first_name" },
                values: new object[] { "kate.jagger@theworld.ca", "Kate" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 112,
                columns: new[] { "email", "first_name" },
                values: new object[] { "oprah.windsor@gov.gr", "Oprah" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 113,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "oprah.presley@google.com", "Oprah", "Presley" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 114,
                columns: new[] { "email", "last_name" },
                values: new object[] { "kate.obama@something.com", "Obama" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 115,
                columns: new[] { "email", "last_name" },
                values: new object[] { "donald.winfrey@google.com", "Winfrey" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 116,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "audrey.hendrix@gov.us", "Audrey", "Hendrix" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 117,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "jimi.windsor@bbc.co.uk", "Jimi", "Windsor" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 118,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "donald.middleton@gov.nl", "Donald", "Middleton" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 119,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "jimi.winslet@nasa.org.us", "Jimi", "Winslet" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 120,
                columns: new[] { "email", "first_name" },
                values: new object[] { "oprah.jagger@google.com", "Oprah" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 121,
                columns: new[] { "email", "first_name" },
                values: new object[] { "donald.winfrey@nasa.org.us", "Donald" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 122,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "oprah.hendrix@something.com", "Oprah", "Hendrix" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 123,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "barack.middleton@something.com", "Barack", "Middleton" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 124,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "barack.hendrix@something.com", "Barack", "Hendrix" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 125,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.trump@nasa.org.us", "Kate", "Trump" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 126,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.hendrix@gov.us", "Kate", "Hendrix" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 127,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "donald.winfrey@gov.nl", "Donald", "Winfrey" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 128,
                columns: new[] { "email", "last_name" },
                values: new object[] { "donald.windsor@tesla.com", "Windsor" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 129,
                columns: new[] { "email", "last_name" },
                values: new object[] { "charles.presley@something.com", "Presley" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 130,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.hepburn@gov.nl", "Kate", "Hepburn" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 131,
                columns: new[] { "email", "last_name" },
                values: new object[] { "kate.obama@bbc.co.uk", "Obama" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 132,
                columns: new[] { "email", "last_name" },
                values: new object[] { "jimi.hendrix@something.com", "Hendrix" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 133,
                columns: new[] { "email", "first_name" },
                values: new object[] { "charles.windsor@theworld.ca", "Charles" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 134,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "jimi.hendrix@something.com", "Jimi", "Hendrix" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 135,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "charles.trump@google.com", "Charles", "Trump" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 136,
                columns: new[] { "email", "first_name" },
                values: new object[] { "charles.obama@gov.us", "Charles" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 137,
                columns: new[] { "email", "first_name" },
                values: new object[] { "kate.obama@theworld.ca", "Kate" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 138,
                columns: new[] { "email", "first_name" },
                values: new object[] { "barack.winfrey@theworld.ca", "Barack" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 139,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "charles.winslet@tesla.com", "Charles", "Winslet" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 140,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "jimi.middleton@theworld.ca", "Jimi", "Middleton" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 141,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.trump@something.com", "Kate", "Trump" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 142,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "audrey.trump@gov.us", "Audrey", "Trump" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 143,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "barack.presley@gov.nl", "Barack", "Presley" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 144,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "oprah.hepburn@google.com", "Oprah", "Hepburn" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 145,
                columns: new[] { "email", "first_name" },
                values: new object[] { "audrey.hendrix@gov.nl", "Audrey" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 146,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "audrey.windsor@tesla.com", "Audrey", "Windsor" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 147,
                columns: new[] { "email", "first_name" },
                values: new object[] { "kate.obama@bbc.co.uk", "Kate" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 148,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.trump@gov.ru", "Kate", "Trump" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 149,
                columns: new[] { "email", "first_name" },
                values: new object[] { "charles.jagger@bbc.co.uk", "Charles" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 150,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "barack.hepburn@gov.us", "Barack", "Hepburn" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 151,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "charles.jagger@google.com", "Charles", "Jagger" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 152,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "oprah.winslet@nasa.org.us", "Oprah", "Winslet" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 153,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "barack.winslet@bbc.co.uk", "Barack", "Winslet" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 154,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "audrey.hepburn@gov.ru", "Audrey", "Hepburn" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 155,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "charles.presley@gov.nl", "Charles", "Presley" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 156,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "charles.trump@theworld.ca", "Charles", "Trump" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 157,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "donald.obama@something.com", "Donald", "Obama" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 158,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "charles.winfrey@gov.us", "Charles", "Winfrey" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 159,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "charles.hepburn@bbc.co.uk", "Charles", "Hepburn" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 160,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "barack.trump@nasa.org.us", "Barack", "Trump" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 161,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "barack.windsor@theworld.ca", "Barack", "Windsor" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 162,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.winfrey@tesla.com", "Kate", "Winfrey" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 163,
                columns: new[] { "email", "last_name" },
                values: new object[] { "elvis.jagger@theworld.ca", "Jagger" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 164,
                columns: new[] { "email", "last_name" },
                values: new object[] { "kate.middleton@something.com", "Middleton" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 165,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "barack.trump@tesla.com", "Barack", "Trump" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 166,
                columns: new[] { "email", "last_name" },
                values: new object[] { "barack.hendrix@gov.ru", "Hendrix" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 167,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "mick.jagger@gov.gr", "Mick", "Jagger" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 168,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "mick.winslet@gov.ru", "Mick", "Winslet" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 169,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "donald.winfrey@something.com", "Donald", "Winfrey" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 170,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "elvis.obama@bbc.co.uk", "Elvis", "Obama" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 171,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "charles.hendrix@bbc.co.uk", "Charles", "Hendrix" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 172,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "elvis.jagger@nasa.org.us", "Elvis", "Jagger" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 173,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "mick.presley@something.com", "Mick", "Presley" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 174,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "audrey.obama@gov.us", "Audrey", "Obama" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 175,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "barack.windsor@gov.ru", "Barack", "Windsor" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 176,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "charles.hepburn@tesla.com", "Charles", "Hepburn" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 177,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "barack.winfrey@nasa.org.us", "Barack", "Winfrey" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 178,
                columns: new[] { "email", "last_name" },
                values: new object[] { "kate.winslet@gov.gr", "Winslet" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 179,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "oprah.trump@gov.nl", "Oprah", "Trump" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 180,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "oprah.middleton@tesla.com", "Oprah", "Middleton" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 181,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "donald.winfrey@tesla.com", "Donald", "Winfrey" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 182,
                columns: new[] { "email", "last_name" },
                values: new object[] { "elvis.middleton@something.com", "Middleton" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 183,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "mick.obama@gov.gr", "Mick", "Obama" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 184,
                columns: new[] { "email", "last_name" },
                values: new object[] { "charles.winfrey@theworld.ca", "Winfrey" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 185,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "barack.presley@theworld.ca", "Barack", "Presley" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 186,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "donald.hendrix@google.com", "Donald", "Hendrix" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 187,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "elvis.winslet@tesla.com", "Elvis", "Winslet" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 188,
                columns: new[] { "email", "first_name" },
                values: new object[] { "mick.hendrix@google.com", "Mick" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 189,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "charles.hendrix@google.com", "Charles", "Hendrix" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 190,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "jimi.hepburn@gov.gr", "Jimi", "Hepburn" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 191,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.trump@nasa.org.us", "Kate", "Trump" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 192,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "donald.trump@bbc.co.uk", "Donald", "Trump" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 193,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "mick.obama@gov.us", "Mick", "Obama" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 194,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "audrey.hepburn@gov.ru", "Audrey", "Hepburn" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 195,
                columns: new[] { "email", "last_name" },
                values: new object[] { "mick.windsor@gov.us", "Windsor" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 196,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.middleton@gov.nl", "Kate", "Middleton" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 197,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "mick.winfrey@gov.ru", "Mick", "Winfrey" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 198,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "audrey.windsor@gov.gr", "Audrey", "Windsor" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 199,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.middleton@nasa.org.us", "Kate", "Middleton" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 200,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "donald.trump@gov.us", "Donald", "Trump" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 201,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "audrey.winfrey@gov.nl", "Audrey", "Winfrey" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 202,
                columns: new[] { "email", "last_name" },
                values: new object[] { "kate.jagger@gov.gr", "Jagger" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 203,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "audrey.obama@google.com", "Audrey", "Obama" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 204,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "elvis.trump@gov.gr", "Elvis", "Trump" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 205,
                column: "email",
                value: "kate.windsor@something.com");

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 206,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "oprah.jagger@bbc.co.uk", "Oprah", "Jagger" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 207,
                columns: new[] { "email", "first_name" },
                values: new object[] { "audrey.obama@nasa.org.us", "Audrey" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 208,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "audrey.obama@gov.us", "Audrey", "Obama" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 209,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "jimi.winfrey@gov.nl", "Jimi", "Winfrey" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 210,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.obama@gov.nl", "Kate", "Obama" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 211,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "charles.winslet@something.com", "Charles", "Winslet" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 212,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "barack.middleton@something.com", "Barack", "Middleton" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 213,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "audrey.presley@something.com", "Audrey", "Presley" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 214,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "audrey.hendrix@something.com", "Audrey", "Hendrix" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 215,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.presley@google.com", "Kate", "Presley" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 216,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "donald.winslet@gov.ru", "Donald", "Winslet" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 217,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "audrey.trump@gov.us", "Audrey", "Trump" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 218,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "jimi.winfrey@gov.gr", "Jimi", "Winfrey" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 219,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "audrey.presley@gov.us", "Audrey", "Presley" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 220,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "jimi.hepburn@theworld.ca", "Jimi", "Hepburn" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 221,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "audrey.middleton@gov.ru", "Audrey", "Middleton" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 222,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "elvis.obama@gov.ru", "Elvis", "Obama" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 223,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "audrey.windsor@google.com", "Audrey", "Windsor" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 224,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "jimi.jagger@gov.ru", "Jimi", "Jagger" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 225,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "audrey.obama@gov.ru", "Audrey", "Obama" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 226,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "jimi.winslet@gov.nl", "Jimi", "Winslet" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 227,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "charles.obama@google.com", "Charles", "Obama" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 228,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "elvis.trump@gov.ru", "Elvis", "Trump" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 229,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "jimi.windsor@nasa.org.us", "Jimi", "Windsor" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 230,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.winslet@gov.gr", "Kate", "Winslet" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 231,
                columns: new[] { "email", "last_name" },
                values: new object[] { "donald.presley@google.com", "Presley" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 232,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.winfrey@nasa.org.us", "Kate", "Winfrey" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 233,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "jimi.hepburn@gov.gr", "Jimi", "Hepburn" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 234,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.presley@something.com", "Kate", "Presley" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 235,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "barack.presley@gov.gr", "Barack", "Presley" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 236,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "barack.windsor@gov.gr", "Barack", "Windsor" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 237,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.windsor@bbc.co.uk", "Kate", "Windsor" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 238,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "barack.hepburn@google.com", "Barack", "Hepburn" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 239,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "jimi.hepburn@tesla.com", "Jimi", "Hepburn" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 240,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "donald.trump@gov.ru", "Donald", "Trump" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 241,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "donald.trump@gov.gr", "Donald", "Trump" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 242,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "mick.hepburn@google.com", "Mick", "Hepburn" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 243,
                columns: new[] { "email", "last_name" },
                values: new object[] { "charles.hepburn@bbc.co.uk", "Hepburn" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 244,
                columns: new[] { "email", "first_name" },
                values: new object[] { "jimi.presley@gov.ru", "Jimi" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 245,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "barack.winslet@gov.ru", "Barack", "Winslet" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 246,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "oprah.obama@google.com", "Oprah", "Obama" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 247,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "barack.presley@theworld.ca", "Barack", "Presley" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 248,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "audrey.obama@gov.gr", "Audrey", "Obama" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 249,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.trump@nasa.org.us", "Kate", "Trump" });

            migrationBuilder.InsertData(
                table: "book_authors",
                columns: new[] { "bookauthor_id", "fk_author_id", "fk_book_id" },
                values: new object[,]
                {
                    { 1, 163, 1 },
                    { 2, 157, 2 },
                    { 3, 205, 3 },
                    { 4, 219, 4 },
                    { 5, 232, 5 },
                    { 6, 48, 6 },
                    { 7, 66, 7 },
                    { 8, 218, 8 },
                    { 9, 221, 9 },
                    { 10, 70, 10 },
                    { 11, 168, 11 },
                    { 12, 62, 12 },
                    { 13, 100, 13 },
                    { 14, 110, 14 },
                    { 15, 167, 15 },
                    { 16, 238, 16 },
                    { 17, 68, 17 },
                    { 18, 231, 18 },
                    { 19, 179, 19 },
                    { 20, 115, 20 },
                    { 21, 102, 21 },
                    { 22, 228, 22 },
                    { 23, 90, 23 },
                    { 24, 16, 24 },
                    { 25, 145, 25 },
                    { 26, 121, 26 },
                    { 27, 217, 27 },
                    { 28, 126, 28 },
                    { 29, 32, 29 },
                    { 30, 163, 30 },
                    { 31, 212, 31 },
                    { 32, 134, 32 },
                    { 33, 97, 33 },
                    { 34, 70, 34 },
                    { 35, 113, 35 },
                    { 36, 72, 36 },
                    { 37, 60, 37 },
                    { 38, 199, 38 },
                    { 39, 127, 39 },
                    { 40, 55, 40 },
                    { 41, 138, 41 },
                    { 42, 200, 42 },
                    { 43, 148, 43 },
                    { 44, 22, 44 },
                    { 45, 32, 45 },
                    { 46, 13, 46 },
                    { 47, 168, 47 },
                    { 48, 199, 48 },
                    { 49, 66, 49 },
                    { 50, 45, 50 },
                    { 51, 37, 51 },
                    { 52, 72, 52 },
                    { 53, 244, 53 },
                    { 54, 163, 54 },
                    { 55, 21, 55 },
                    { 56, 11, 56 },
                    { 57, 144, 57 },
                    { 58, 64, 58 },
                    { 59, 179, 59 },
                    { 60, 47, 60 },
                    { 61, 82, 61 },
                    { 62, 64, 62 },
                    { 63, 50, 63 },
                    { 64, 161, 64 },
                    { 65, 199, 65 },
                    { 66, 50, 66 },
                    { 67, 176, 67 },
                    { 68, 231, 68 },
                    { 69, 44, 69 },
                    { 70, 112, 70 },
                    { 71, 72, 71 },
                    { 72, 170, 72 },
                    { 73, 27, 73 },
                    { 74, 157, 74 },
                    { 75, 115, 75 },
                    { 76, 31, 76 },
                    { 77, 103, 77 },
                    { 78, 231, 78 },
                    { 79, 75, 79 },
                    { 80, 134, 80 },
                    { 81, 48, 81 },
                    { 82, 214, 82 },
                    { 83, 36, 83 },
                    { 84, 156, 84 },
                    { 85, 106, 85 },
                    { 86, 152, 86 },
                    { 87, 78, 87 },
                    { 88, 61, 88 },
                    { 89, 173, 89 },
                    { 90, 194, 90 },
                    { 91, 93, 91 },
                    { 92, 146, 92 },
                    { 93, 177, 93 },
                    { 94, 237, 94 },
                    { 95, 119, 95 },
                    { 96, 170, 96 },
                    { 97, 125, 97 },
                    { 98, 158, 98 },
                    { 99, 60, 99 },
                    { 100, 176, 100 },
                    { 101, 99, 101 },
                    { 102, 43, 102 },
                    { 103, 139, 103 },
                    { 104, 82, 104 },
                    { 105, 15, 105 },
                    { 106, 63, 106 },
                    { 107, 164, 107 },
                    { 108, 239, 108 },
                    { 109, 24, 109 },
                    { 110, 115, 110 },
                    { 111, 239, 111 },
                    { 112, 174, 112 },
                    { 113, 146, 113 },
                    { 114, 107, 114 },
                    { 115, 189, 115 },
                    { 116, 29, 116 },
                    { 117, 24, 117 },
                    { 118, 7, 118 },
                    { 119, 177, 119 },
                    { 120, 35, 120 },
                    { 121, 71, 121 },
                    { 122, 233, 122 },
                    { 123, 204, 123 },
                    { 124, 28, 124 },
                    { 125, 65, 125 },
                    { 126, 7, 126 },
                    { 127, 112, 127 },
                    { 128, 212, 128 },
                    { 129, 163, 129 },
                    { 130, 23, 130 },
                    { 131, 160, 131 },
                    { 132, 98, 132 },
                    { 133, 52, 133 },
                    { 134, 247, 134 },
                    { 135, 179, 135 },
                    { 136, 224, 136 },
                    { 137, 135, 137 },
                    { 138, 174, 138 },
                    { 139, 80, 139 },
                    { 140, 196, 140 },
                    { 141, 185, 141 },
                    { 142, 113, 142 },
                    { 143, 247, 143 },
                    { 144, 112, 144 },
                    { 145, 22, 145 },
                    { 146, 59, 146 },
                    { 147, 113, 147 },
                    { 148, 32, 148 },
                    { 149, 244, 149 },
                    { 150, 153, 150 },
                    { 151, 78, 151 },
                    { 152, 117, 152 },
                    { 153, 77, 153 },
                    { 154, 129, 154 },
                    { 155, 181, 155 },
                    { 156, 104, 156 },
                    { 157, 172, 157 },
                    { 158, 98, 158 },
                    { 159, 72, 159 },
                    { 160, 110, 160 },
                    { 161, 196, 161 },
                    { 162, 36, 162 },
                    { 163, 50, 163 },
                    { 164, 39, 164 },
                    { 165, 172, 165 },
                    { 166, 197, 166 },
                    { 167, 80, 167 },
                    { 168, 205, 168 },
                    { 169, 52, 169 },
                    { 170, 242, 170 },
                    { 171, 87, 171 },
                    { 172, 71, 172 },
                    { 173, 35, 173 },
                    { 174, 249, 174 },
                    { 175, 130, 175 },
                    { 176, 54, 176 },
                    { 177, 101, 177 },
                    { 178, 163, 178 },
                    { 179, 205, 179 },
                    { 180, 101, 180 },
                    { 181, 101, 181 },
                    { 182, 180, 182 },
                    { 183, 78, 183 },
                    { 184, 221, 184 },
                    { 185, 144, 185 },
                    { 186, 147, 186 },
                    { 187, 26, 187 },
                    { 188, 50, 188 },
                    { 189, 6, 189 },
                    { 190, 110, 190 },
                    { 191, 247, 191 },
                    { 192, 219, 192 },
                    { 193, 241, 193 },
                    { 194, 225, 194 },
                    { 195, 202, 195 },
                    { 196, 105, 196 },
                    { 197, 24, 197 },
                    { 198, 84, 198 },
                    { 199, 179, 199 },
                    { 200, 212, 200 },
                    { 201, 43, 201 },
                    { 202, 90, 202 },
                    { 203, 17, 203 },
                    { 204, 33, 204 },
                    { 205, 100, 205 },
                    { 206, 153, 206 },
                    { 207, 243, 207 },
                    { 208, 239, 208 },
                    { 209, 238, 209 },
                    { 210, 110, 210 },
                    { 211, 218, 211 },
                    { 212, 99, 212 },
                    { 213, 216, 213 },
                    { 214, 123, 214 },
                    { 215, 179, 215 },
                    { 216, 107, 216 },
                    { 217, 137, 217 },
                    { 218, 77, 218 },
                    { 219, 229, 219 },
                    { 220, 176, 220 },
                    { 221, 63, 221 },
                    { 222, 171, 222 },
                    { 223, 115, 223 },
                    { 224, 54, 224 },
                    { 225, 224, 225 },
                    { 226, 203, 226 },
                    { 227, 128, 227 },
                    { 228, 61, 228 },
                    { 229, 198, 229 },
                    { 230, 181, 230 },
                    { 231, 16, 231 },
                    { 232, 31, 232 },
                    { 233, 231, 233 },
                    { 234, 139, 234 },
                    { 235, 150, 235 },
                    { 236, 59, 236 },
                    { 237, 218, 237 },
                    { 238, 189, 238 },
                    { 239, 125, 239 },
                    { 240, 238, 240 },
                    { 241, 94, 241 },
                    { 242, 34, 242 },
                    { 243, 196, 243 },
                    { 244, 143, 244 },
                    { 245, 107, 245 },
                    { 246, 42, 246 },
                    { 247, 144, 247 },
                    { 248, 34, 248 },
                    { 249, 242, 249 }
                });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "publisher_id", "title" },
                values: new object[] { 2, "A herd of Transparent Houses" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "publisher_id", "title" },
                values: new object[] { 6, "Several Orange Cars" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "publisher_id", "title" },
                values: new object[] { 8, "A herd of Green Buildings" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "publisher_id", "title" },
                values: new object[] { 6, "The Large Planets" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "publisher_id", "title" },
                values: new object[] { 1, "A herd of Green Houses" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "publisher_id", "title" },
                values: new object[] { 7, "Fifteen Green Houses" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "publisher_id", "title" },
                values: new object[] { 3, "Two Orange Houses" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "publisher_id", "title" },
                values: new object[] { 9, "A bunch of Transparent Planets" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "publisher_id", "title" },
                values: new object[] { 9, "A bunch of Rose Smelling Buildings" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "publisher_id", "title" },
                values: new object[] { 9, "A bunch of Large Planets" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "publisher_id", "title" },
                values: new object[] { 6, "A bunch of Orange Buildings" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "publisher_id", "title" },
                values: new object[] { 7, "Fifteen Orange Leopards" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "publisher_id", "title" },
                values: new object[] { 10, "Two Large Buildings" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "publisher_id", "title" },
                values: new object[] { 3, "A bunch of Rose Smelling Houses" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "publisher_id", "title" },
                values: new object[] { 10, "Several Microscopic Flowers" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "publisher_id", "title" },
                values: new object[] { 5, "Two Orange Flowers" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "publisher_id", "title" },
                values: new object[] { 5, "The Rose Smelling Cars" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "publisher_id", "title" },
                values: new object[] { 4, "An army of Microscopic Buildings" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "publisher_id", "title" },
                values: new object[] { 8, "A bunch of Orange Buildings" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "publisher_id", "title" },
                values: new object[] { 8, "Two Orange Cars" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "publisher_id", "title" },
                values: new object[] { 5, "An army of Purple Planets" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "publisher_id", "title" },
                values: new object[] { 10, "An army of Purple Houses" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "publisher_id", "title" },
                values: new object[] { 4, "Fifteen Rose Smelling Planets" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "publisher_id", "title" },
                values: new object[] { 10, "Several Purple Cars" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "publisher_id", "title" },
                values: new object[] { 7, "Several Green Buildings" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "publisher_id", "title" },
                values: new object[] { 7, "Two Orange Cars" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "publisher_id", "title" },
                values: new object[] { 1, "A bunch of Rose Smelling Buildings" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "publisher_id", "title" },
                values: new object[] { 8, "Two Orange Flowers" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "publisher_id", "title" },
                values: new object[] { 10, "Several Transparent Flowers" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "publisher_id", "title" },
                values: new object[] { 8, "A bunch of Rose Smelling Leopards" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "publisher_id", "title" },
                values: new object[] { 3, "Fifteen Rose Smelling Houses" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "publisher_id", "title" },
                values: new object[] { 5, "Two Purple Cars" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 33,
                columns: new[] { "publisher_id", "title" },
                values: new object[] { 3, "The Orange Buildings" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 34,
                columns: new[] { "publisher_id", "title" },
                values: new object[] { 2, "A bunch of Bitter Buildings" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 35,
                columns: new[] { "publisher_id", "title" },
                values: new object[] { 5, "The Bitter Houses" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 36,
                columns: new[] { "publisher_id", "title" },
                values: new object[] { 3, "Two Orange Buildings" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 37,
                column: "title",
                value: "A herd of Microscopic Flowers");

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 38,
                columns: new[] { "publisher_id", "title" },
                values: new object[] { 1, "Several Purple Flowers" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 39,
                columns: new[] { "publisher_id", "title" },
                values: new object[] { 2, "The Large Buildings" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 40,
                columns: new[] { "publisher_id", "title" },
                values: new object[] { 4, "Two Green Houses" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 41,
                columns: new[] { "publisher_id", "title" },
                values: new object[] { 2, "Two Large Leopards" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 42,
                columns: new[] { "publisher_id", "title" },
                values: new object[] { 2, "A herd of Rose Smelling Cars" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 43,
                columns: new[] { "publisher_id", "title" },
                values: new object[] { 9, "Fifteen Bitter Houses" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 44,
                columns: new[] { "publisher_id", "title" },
                values: new object[] { 10, "An army of Bitter Planets" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 45,
                columns: new[] { "publisher_id", "title" },
                values: new object[] { 9, "The Large Houses" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 46,
                columns: new[] { "publisher_id", "title" },
                values: new object[] { 8, "A bunch of Green Leopards" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 47,
                columns: new[] { "publisher_id", "title" },
                values: new object[] { 3, "The Bitter Buildings" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 48,
                columns: new[] { "publisher_id", "title" },
                values: new object[] { 9, "The Transparent Leopards" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 49,
                columns: new[] { "publisher_id", "title" },
                values: new object[] { 8, "A bunch of Orange Houses" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 50,
                columns: new[] { "publisher_id", "title" },
                values: new object[] { 1, "Several Bitter Leopards" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 51,
                columns: new[] { "publisher_id", "title" },
                values: new object[] { 4, "An army of Microscopic Planets" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 52,
                column: "title",
                value: "A bunch of Orange Buildings");

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 53,
                columns: new[] { "publisher_id", "title" },
                values: new object[] { 1, "Fifteen Microscopic Leopards" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 54,
                columns: new[] { "publisher_id", "title" },
                values: new object[] { 3, "A bunch of Green Leopards" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 55,
                columns: new[] { "publisher_id", "title" },
                values: new object[] { 6, "A herd of Transparent Houses" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 56,
                columns: new[] { "publisher_id", "title" },
                values: new object[] { 3, "An army of Large Buildings" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 57,
                columns: new[] { "publisher_id", "title" },
                values: new object[] { 2, "Fifteen Purple Houses" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 58,
                column: "title",
                value: "Two Orange Buildings");

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 59,
                columns: new[] { "publisher_id", "title" },
                values: new object[] { 2, "A bunch of Microscopic Leopards" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 60,
                columns: new[] { "publisher_id", "title" },
                values: new object[] { 7, "Fifteen Orange Leopards" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 61,
                columns: new[] { "publisher_id", "title" },
                values: new object[] { 4, "Two Green Leopards" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 62,
                columns: new[] { "publisher_id", "title" },
                values: new object[] { 6, "A herd of Large Cars" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 63,
                columns: new[] { "publisher_id", "title" },
                values: new object[] { 3, "Two Bitter Planets" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 64,
                columns: new[] { "publisher_id", "title" },
                values: new object[] { 3, "Fifteen Large Cars" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 65,
                columns: new[] { "publisher_id", "title" },
                values: new object[] { 7, "A herd of Microscopic Houses" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 66,
                columns: new[] { "publisher_id", "title" },
                values: new object[] { 6, "An army of Orange Cars" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 67,
                columns: new[] { "publisher_id", "title" },
                values: new object[] { 2, "Two Bitter Planets" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 68,
                column: "publisher_id",
                value: 2);

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 69,
                columns: new[] { "publisher_id", "title" },
                values: new object[] { 5, "The Orange Leopards" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 70,
                columns: new[] { "publisher_id", "title" },
                values: new object[] { 8, "Fifteen Transparent Flowers" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 71,
                columns: new[] { "publisher_id", "title" },
                values: new object[] { 2, "A bunch of Bitter Leopards" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 72,
                columns: new[] { "publisher_id", "title" },
                values: new object[] { 7, "A bunch of Large Buildings" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 73,
                column: "title",
                value: "The Green Houses");

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 74,
                columns: new[] { "publisher_id", "title" },
                values: new object[] { 8, "Several Orange Planets" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 75,
                columns: new[] { "publisher_id", "title" },
                values: new object[] { 7, "Fifteen Purple Houses" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 76,
                columns: new[] { "publisher_id", "title" },
                values: new object[] { 8, "Two Purple Buildings" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 77,
                column: "title",
                value: "A herd of Orange Leopards");

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 78,
                columns: new[] { "publisher_id", "title" },
                values: new object[] { 10, "Fifteen Transparent Buildings" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 79,
                column: "title",
                value: "A herd of Purple Houses");

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 80,
                columns: new[] { "publisher_id", "title" },
                values: new object[] { 9, "A herd of Bitter Cars" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 81,
                columns: new[] { "publisher_id", "title" },
                values: new object[] { 7, "Several Large Planets" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 82,
                columns: new[] { "publisher_id", "title" },
                values: new object[] { 1, "A herd of Rose Smelling Planets" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 83,
                columns: new[] { "publisher_id", "title" },
                values: new object[] { 6, "The Bitter Leopards" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 84,
                column: "title",
                value: "Fifteen Large Houses");

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 85,
                columns: new[] { "publisher_id", "title" },
                values: new object[] { 9, "Two Microscopic Buildings" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 86,
                columns: new[] { "publisher_id", "title" },
                values: new object[] { 10, "Several Microscopic Flowers" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 87,
                columns: new[] { "publisher_id", "title" },
                values: new object[] { 10, "A herd of Rose Smelling Buildings" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 88,
                columns: new[] { "publisher_id", "title" },
                values: new object[] { 3, "Several Rose Smelling Planets" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 89,
                column: "title",
                value: "An army of Bitter Planets");

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 90,
                columns: new[] { "publisher_id", "title" },
                values: new object[] { 4, "Several Microscopic Houses" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 91,
                columns: new[] { "publisher_id", "title" },
                values: new object[] { 6, "The Microscopic Houses" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 92,
                columns: new[] { "publisher_id", "title" },
                values: new object[] { 9, "A herd of Green Flowers" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 93,
                columns: new[] { "publisher_id", "title" },
                values: new object[] { 7, "An army of Transparent Cars" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 94,
                columns: new[] { "publisher_id", "title" },
                values: new object[] { 4, "Fifteen Rose Smelling Buildings" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 95,
                columns: new[] { "publisher_id", "title" },
                values: new object[] { 8, "The Green Leopards" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 96,
                columns: new[] { "publisher_id", "title" },
                values: new object[] { 5, "An army of Large Planets" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 97,
                columns: new[] { "publisher_id", "title" },
                values: new object[] { 3, "A herd of Rose Smelling Cars" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 98,
                columns: new[] { "publisher_id", "title" },
                values: new object[] { 3, "The Bitter Cars" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 99,
                columns: new[] { "publisher_id", "title" },
                values: new object[] { 3, "Two Transparent Leopards" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 100,
                columns: new[] { "publisher_id", "title" },
                values: new object[] { 9, "The Bitter Leopards" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 101,
                columns: new[] { "publisher_id", "title" },
                values: new object[] { 5, "A bunch of Orange Leopards" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 102,
                columns: new[] { "publisher_id", "title" },
                values: new object[] { 4, "A bunch of Rose Smelling Buildings" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 103,
                columns: new[] { "publisher_id", "title" },
                values: new object[] { 5, "Fifteen Bitter Buildings" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 104,
                columns: new[] { "publisher_id", "title" },
                values: new object[] { 3, "A herd of Green Cars" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 105,
                columns: new[] { "publisher_id", "title" },
                values: new object[] { 1, "Several Microscopic Cars" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 106,
                columns: new[] { "publisher_id", "title" },
                values: new object[] { 5, "An army of Bitter Flowers" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 107,
                column: "title",
                value: "Two Large Flowers");

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 108,
                columns: new[] { "publisher_id", "title" },
                values: new object[] { 3, "Several Orange Houses" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 109,
                columns: new[] { "publisher_id", "title" },
                values: new object[] { 10, "The Large Flowers" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 110,
                columns: new[] { "publisher_id", "title" },
                values: new object[] { 4, "Two Large Leopards" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 111,
                columns: new[] { "publisher_id", "title" },
                values: new object[] { 9, "Several Green Flowers" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 112,
                columns: new[] { "publisher_id", "title" },
                values: new object[] { 6, "A herd of Microscopic Buildings" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 113,
                columns: new[] { "publisher_id", "title" },
                values: new object[] { 7, "A bunch of Orange Houses" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 114,
                columns: new[] { "publisher_id", "title" },
                values: new object[] { 1, "A herd of Orange Cars" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 115,
                columns: new[] { "publisher_id", "title" },
                values: new object[] { 2, "The Purple Buildings" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 116,
                columns: new[] { "publisher_id", "title" },
                values: new object[] { 4, "The Bitter Planets" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 117,
                columns: new[] { "publisher_id", "title" },
                values: new object[] { 10, "An army of Microscopic Houses" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 118,
                columns: new[] { "publisher_id", "title" },
                values: new object[] { 7, "The Large Houses" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 119,
                columns: new[] { "publisher_id", "title" },
                values: new object[] { 5, "An army of Large Leopards" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 120,
                column: "title",
                value: "The Green Leopards");

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 121,
                columns: new[] { "publisher_id", "title" },
                values: new object[] { 5, "Several Orange Flowers" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 122,
                columns: new[] { "publisher_id", "title" },
                values: new object[] { 8, "Two Transparent Planets" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 123,
                columns: new[] { "publisher_id", "title" },
                values: new object[] { 2, "A herd of Microscopic Planets" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 124,
                columns: new[] { "publisher_id", "title" },
                values: new object[] { 2, "The Purple Leopards" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 125,
                columns: new[] { "publisher_id", "title" },
                values: new object[] { 1, "A herd of Green Buildings" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 126,
                columns: new[] { "publisher_id", "title" },
                values: new object[] { 6, "The Purple Cars" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 127,
                columns: new[] { "publisher_id", "title" },
                values: new object[] { 3, "Several Large Houses" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 128,
                column: "title",
                value: "A herd of Rose Smelling Leopards");

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 130,
                columns: new[] { "publisher_id", "title" },
                values: new object[] { 9, "Fifteen Transparent Planets" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 131,
                column: "title",
                value: "Fifteen Rose Smelling Leopards");

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 132,
                column: "title",
                value: "Two Orange Planets");

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 133,
                columns: new[] { "publisher_id", "title" },
                values: new object[] { 6, "Fifteen Bitter Houses" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 134,
                columns: new[] { "publisher_id", "title" },
                values: new object[] { 1, "An army of Purple Planets" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 135,
                columns: new[] { "publisher_id", "title" },
                values: new object[] { 3, "An army of Bitter Buildings" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 136,
                columns: new[] { "publisher_id", "title" },
                values: new object[] { 5, "A herd of Large Flowers" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 137,
                column: "publisher_id",
                value: 5);

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 138,
                columns: new[] { "publisher_id", "title" },
                values: new object[] { 4, "A bunch of Green Buildings" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 139,
                columns: new[] { "publisher_id", "title" },
                values: new object[] { 10, "Two Large Cars" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 140,
                columns: new[] { "publisher_id", "title" },
                values: new object[] { 8, "A bunch of Bitter Flowers" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 141,
                columns: new[] { "publisher_id", "title" },
                values: new object[] { 3, "Two Rose Smelling Cars" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 142,
                columns: new[] { "publisher_id", "title" },
                values: new object[] { 3, "The Purple Cars" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 143,
                columns: new[] { "publisher_id", "title" },
                values: new object[] { 10, "The Transparent Cars" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 144,
                columns: new[] { "publisher_id", "title" },
                values: new object[] { 7, "A herd of Purple Planets" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 145,
                columns: new[] { "publisher_id", "title" },
                values: new object[] { 6, "A bunch of Rose Smelling Buildings" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 146,
                columns: new[] { "publisher_id", "title" },
                values: new object[] { 4, "Two Purple Flowers" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 147,
                columns: new[] { "publisher_id", "title" },
                values: new object[] { 10, "The Orange Planets" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 148,
                columns: new[] { "publisher_id", "title" },
                values: new object[] { 1, "An army of Microscopic Leopards" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 149,
                columns: new[] { "publisher_id", "title" },
                values: new object[] { 2, "Several Green Cars" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 150,
                columns: new[] { "publisher_id", "title" },
                values: new object[] { 3, "A bunch of Microscopic Flowers" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 151,
                columns: new[] { "publisher_id", "title" },
                values: new object[] { 6, "Two Microscopic Houses" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 152,
                columns: new[] { "publisher_id", "title" },
                values: new object[] { 3, "The Green Houses" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 153,
                columns: new[] { "publisher_id", "title" },
                values: new object[] { 4, "An army of Transparent Planets" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 154,
                columns: new[] { "publisher_id", "title" },
                values: new object[] { 4, "A bunch of Bitter Leopards" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 155,
                columns: new[] { "publisher_id", "title" },
                values: new object[] { 9, "Several Large Houses" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 156,
                columns: new[] { "publisher_id", "title" },
                values: new object[] { 3, "The Green Cars" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 157,
                columns: new[] { "publisher_id", "title" },
                values: new object[] { 10, "The Bitter Leopards" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 158,
                columns: new[] { "publisher_id", "title" },
                values: new object[] { 10, "A herd of Bitter Flowers" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 159,
                columns: new[] { "publisher_id", "title" },
                values: new object[] { 4, "A herd of Microscopic Planets" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 160,
                columns: new[] { "publisher_id", "title" },
                values: new object[] { 5, "An army of Orange Houses" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 161,
                columns: new[] { "publisher_id", "title" },
                values: new object[] { 6, "The Rose Smelling Planets" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 162,
                columns: new[] { "publisher_id", "title" },
                values: new object[] { 8, "Two Transparent Cars" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 163,
                columns: new[] { "publisher_id", "title" },
                values: new object[] { 6, "Several Green Flowers" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 164,
                column: "title",
                value: "The Purple Houses");

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 165,
                columns: new[] { "publisher_id", "title" },
                values: new object[] { 8, "A herd of Transparent Planets" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 166,
                columns: new[] { "publisher_id", "title" },
                values: new object[] { 4, "Fifteen Rose Smelling Cars" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 167,
                columns: new[] { "publisher_id", "title" },
                values: new object[] { 3, "An army of Bitter Flowers" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 168,
                columns: new[] { "publisher_id", "title" },
                values: new object[] { 8, "Fifteen Transparent Buildings" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 169,
                columns: new[] { "publisher_id", "title" },
                values: new object[] { 4, "A bunch of Purple Cars" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 170,
                columns: new[] { "publisher_id", "title" },
                values: new object[] { 4, "Two Microscopic Houses" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 171,
                columns: new[] { "publisher_id", "title" },
                values: new object[] { 8, "Fifteen Rose Smelling Flowers" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 172,
                columns: new[] { "publisher_id", "title" },
                values: new object[] { 9, "The Orange Planets" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 173,
                columns: new[] { "publisher_id", "title" },
                values: new object[] { 8, "Two Transparent Cars" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 174,
                columns: new[] { "publisher_id", "title" },
                values: new object[] { 9, "The Rose Smelling Buildings" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 175,
                columns: new[] { "publisher_id", "title" },
                values: new object[] { 7, "A herd of Purple Flowers" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 176,
                columns: new[] { "publisher_id", "title" },
                values: new object[] { 4, "Several Rose Smelling Cars" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 177,
                columns: new[] { "publisher_id", "title" },
                values: new object[] { 4, "An army of Bitter Houses" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 178,
                columns: new[] { "publisher_id", "title" },
                values: new object[] { 1, "Several Bitter Planets" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 179,
                columns: new[] { "publisher_id", "title" },
                values: new object[] { 4, "Two Purple Flowers" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 180,
                columns: new[] { "publisher_id", "title" },
                values: new object[] { 3, "An army of Green Leopards" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 181,
                columns: new[] { "publisher_id", "title" },
                values: new object[] { 3, "A herd of Green Buildings" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 182,
                columns: new[] { "publisher_id", "title" },
                values: new object[] { 7, "A herd of Orange Flowers" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 183,
                columns: new[] { "publisher_id", "title" },
                values: new object[] { 8, "Fifteen Transparent Planets" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 184,
                columns: new[] { "publisher_id", "title" },
                values: new object[] { 10, "A herd of Purple Buildings" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 185,
                columns: new[] { "publisher_id", "title" },
                values: new object[] { 10, "A herd of Rose Smelling Leopards" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 186,
                columns: new[] { "publisher_id", "title" },
                values: new object[] { 4, "Several Microscopic Flowers" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 187,
                columns: new[] { "publisher_id", "title" },
                values: new object[] { 10, "Several Bitter Planets" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 188,
                columns: new[] { "publisher_id", "title" },
                values: new object[] { 3, "Two Microscopic Buildings" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 189,
                column: "title",
                value: "Several Microscopic Cars");

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 190,
                columns: new[] { "publisher_id", "title" },
                values: new object[] { 6, "A herd of Rose Smelling Houses" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 191,
                columns: new[] { "publisher_id", "title" },
                values: new object[] { 1, "The Bitter Leopards" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 192,
                column: "title",
                value: "An army of Bitter Buildings");

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 193,
                columns: new[] { "publisher_id", "title" },
                values: new object[] { 10, "A bunch of Transparent Cars" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 194,
                columns: new[] { "publisher_id", "title" },
                values: new object[] { 2, "A bunch of Green Cars" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 195,
                columns: new[] { "publisher_id", "title" },
                values: new object[] { 10, "Two Rose Smelling Planets" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 196,
                columns: new[] { "publisher_id", "title" },
                values: new object[] { 4, "A bunch of Green Leopards" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 197,
                columns: new[] { "publisher_id", "title" },
                values: new object[] { 9, "The Purple Houses" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 198,
                columns: new[] { "publisher_id", "title" },
                values: new object[] { 3, "A bunch of Bitter Planets" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 199,
                columns: new[] { "publisher_id", "title" },
                values: new object[] { 6, "Two Green Planets" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 200,
                columns: new[] { "publisher_id", "title" },
                values: new object[] { 7, "A bunch of Orange Leopards" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 201,
                columns: new[] { "publisher_id", "title" },
                values: new object[] { 5, "A bunch of Transparent Houses" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 202,
                columns: new[] { "publisher_id", "title" },
                values: new object[] { 3, "Two Microscopic Flowers" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 203,
                columns: new[] { "publisher_id", "title" },
                values: new object[] { 3, "Two Purple Leopards" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 204,
                columns: new[] { "publisher_id", "title" },
                values: new object[] { 1, "A bunch of Orange Leopards" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 205,
                columns: new[] { "publisher_id", "title" },
                values: new object[] { 8, "An army of Purple Flowers" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 206,
                columns: new[] { "publisher_id", "title" },
                values: new object[] { 1, "A herd of Large Planets" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 207,
                columns: new[] { "publisher_id", "title" },
                values: new object[] { 3, "An army of Rose Smelling Flowers" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 208,
                columns: new[] { "publisher_id", "title" },
                values: new object[] { 6, "Fifteen Purple Planets" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 209,
                column: "title",
                value: "An army of Green Flowers");

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 210,
                columns: new[] { "publisher_id", "title" },
                values: new object[] { 4, "An army of Orange Leopards" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 211,
                columns: new[] { "publisher_id", "title" },
                values: new object[] { 5, "Two Purple Buildings" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 212,
                columns: new[] { "publisher_id", "title" },
                values: new object[] { 4, "The Transparent Flowers" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 213,
                columns: new[] { "publisher_id", "title" },
                values: new object[] { 10, "Several Orange Houses" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 214,
                columns: new[] { "publisher_id", "title" },
                values: new object[] { 3, "Fifteen Bitter Leopards" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 215,
                column: "title",
                value: "An army of Purple Buildings");

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 216,
                columns: new[] { "publisher_id", "title" },
                values: new object[] { 9, "A bunch of Bitter Buildings" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 217,
                columns: new[] { "publisher_id", "title" },
                values: new object[] { 5, "Several Bitter Planets" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 218,
                columns: new[] { "publisher_id", "title" },
                values: new object[] { 6, "An army of Microscopic Cars" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 219,
                columns: new[] { "publisher_id", "title" },
                values: new object[] { 7, "An army of Bitter Planets" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 220,
                columns: new[] { "publisher_id", "title" },
                values: new object[] { 6, "Fifteen Transparent Flowers" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 221,
                columns: new[] { "publisher_id", "title" },
                values: new object[] { 4, "The Rose Smelling Planets" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 222,
                columns: new[] { "publisher_id", "title" },
                values: new object[] { 5, "A bunch of Green Planets" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 223,
                columns: new[] { "publisher_id", "title" },
                values: new object[] { 7, "An army of Orange Buildings" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 224,
                columns: new[] { "publisher_id", "title" },
                values: new object[] { 6, "A bunch of Purple Leopards" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 225,
                columns: new[] { "publisher_id", "title" },
                values: new object[] { 4, "Several Microscopic Cars" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 226,
                columns: new[] { "publisher_id", "title" },
                values: new object[] { 6, "A herd of Transparent Leopards" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 227,
                columns: new[] { "publisher_id", "title" },
                values: new object[] { 7, "An army of Microscopic Buildings" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 228,
                columns: new[] { "publisher_id", "title" },
                values: new object[] { 4, "Two Large Buildings" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 229,
                columns: new[] { "publisher_id", "title" },
                values: new object[] { 8, "A bunch of Microscopic Planets" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 230,
                columns: new[] { "publisher_id", "title" },
                values: new object[] { 1, "A bunch of Orange Houses" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 231,
                columns: new[] { "publisher_id", "title" },
                values: new object[] { 3, "Several Green Planets" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 232,
                columns: new[] { "publisher_id", "title" },
                values: new object[] { 8, "Several Orange Houses" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 233,
                columns: new[] { "publisher_id", "title" },
                values: new object[] { 9, "The Large Leopards" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 234,
                columns: new[] { "publisher_id", "title" },
                values: new object[] { 3, "Fifteen Large Planets" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 235,
                columns: new[] { "publisher_id", "title" },
                values: new object[] { 5, "Fifteen Microscopic Leopards" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 236,
                columns: new[] { "publisher_id", "title" },
                values: new object[] { 4, "The Orange Buildings" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 237,
                column: "title",
                value: "Several Green Planets");

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 238,
                columns: new[] { "publisher_id", "title" },
                values: new object[] { 4, "Several Rose Smelling Cars" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 239,
                column: "title",
                value: "The Transparent Buildings");

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 240,
                columns: new[] { "publisher_id", "title" },
                values: new object[] { 7, "Several Purple Buildings" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 241,
                columns: new[] { "publisher_id", "title" },
                values: new object[] { 5, "An army of Transparent Houses" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 242,
                columns: new[] { "publisher_id", "title" },
                values: new object[] { 1, "Fifteen Rose Smelling Leopards" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 243,
                columns: new[] { "publisher_id", "title" },
                values: new object[] { 6, "Two Orange Buildings" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 244,
                columns: new[] { "publisher_id", "title" },
                values: new object[] { 6, "Fifteen Rose Smelling Flowers" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 245,
                columns: new[] { "publisher_id", "title" },
                values: new object[] { 10, "Fifteen Large Leopards" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 246,
                columns: new[] { "publisher_id", "title" },
                values: new object[] { 3, "An army of Bitter Flowers" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 247,
                columns: new[] { "publisher_id", "title" },
                values: new object[] { 3, "The Bitter Leopards" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 248,
                columns: new[] { "publisher_id", "title" },
                values: new object[] { 3, "A herd of Green Flowers" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 249,
                columns: new[] { "publisher_id", "title" },
                values: new object[] { 3, "A herd of Microscopic Flowers" });

            migrationBuilder.CreateIndex(
                name: "IX_book_authors_fk_author_id",
                table: "book_authors",
                column: "fk_author_id");

            migrationBuilder.CreateIndex(
                name: "IX_book_authors_fk_book_id",
                table: "book_authors",
                column: "fk_book_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "book_authors");

            migrationBuilder.AddColumn<int>(
                name: "author_id",
                table: "books",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "email", "first_name" },
                values: new object[] { "audrey.winfrey@gov.gr", "Audrey" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "audrey.trump@gov.us", "Audrey", "Trump" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "mick.jagger@gov.ru", "Mick", "Jagger" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "jimi.hepburn@gov.gr", "Jimi", "Hepburn" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "email", "last_name" },
                values: new object[] { "barack.presley@gov.gr", "Presley" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "oprah.hepburn@gov.gr", "Oprah", "Hepburn" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "email", "last_name" },
                values: new object[] { "kate.hendrix@theworld.ca", "Hendrix" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "charles.middleton@gov.us", "Charles", "Middleton" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "audrey.presley@theworld.ca", "Audrey", "Presley" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.winslet@something.com", "Kate", "Winslet" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.obama@gov.gr", "Kate", "Obama" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "barack.trump@gov.ru", "Barack", "Trump" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "elvis.hepburn@gov.ru", "Elvis", "Hepburn" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "email", "first_name" },
                values: new object[] { "donald.winfrey@gov.gr", "Donald" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "charles.winslet@bbc.co.uk", "Charles", "Winslet" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "mick.jagger@gov.nl", "Mick", "Jagger" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "mick.winfrey@gov.ru", "Mick", "Winfrey" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "elvis.middleton@google.com", "Elvis", "Middleton" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "mick.obama@gov.us", "Mick", "Obama" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "oprah.hepburn@gov.nl", "Oprah", "Hepburn" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "oprah.hendrix@gov.nl", "Oprah", "Hendrix" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "audrey.trump@tesla.com", "Audrey", "Trump" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "donald.windsor@gov.gr", "Donald", "Windsor" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.trump@google.com", "Kate", "Trump" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "oprah.hepburn@gov.ru", "Oprah", "Hepburn" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "charles.hendrix@gov.ru", "Charles", "Hendrix" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "elvis.winslet@gov.nl", "Elvis", "Winslet" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "jimi.hendrix@bbc.co.uk", "Jimi", "Hendrix" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "email", "last_name" },
                values: new object[] { "charles.winfrey@tesla.com", "Winfrey" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "donald.winfrey@gov.gr", "Donald", "Winfrey" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "mick.obama@theworld.ca", "Mick", "Obama" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "email", "last_name" },
                values: new object[] { "barack.trump@gov.us", "Trump" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 33,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "jimi.presley@gov.ru", "Jimi", "Presley" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 34,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.winslet@gov.gr", "Kate", "Winslet" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 35,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "barack.obama@tesla.com", "Barack", "Obama" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 36,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "oprah.winslet@tesla.com", "Oprah", "Winslet" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 37,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.obama@google.com", "Kate", "Obama" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 38,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "jimi.hepburn@gov.ru", "Jimi", "Hepburn" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 39,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "oprah.jagger@gov.gr", "Oprah", "Jagger" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 40,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "elvis.obama@bbc.co.uk", "Elvis", "Obama" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 41,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "jimi.windsor@something.com", "Jimi", "Windsor" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 42,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.hepburn@gov.nl", "Kate", "Hepburn" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 43,
                columns: new[] { "email", "last_name" },
                values: new object[] { "jimi.hepburn@gov.gr", "Hepburn" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 44,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "mick.winfrey@nasa.org.us", "Mick", "Winfrey" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 45,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "oprah.winfrey@gov.us", "Oprah", "Winfrey" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 46,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.trump@google.com", "Kate", "Trump" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 47,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "jimi.trump@theworld.ca", "Jimi", "Trump" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 48,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "oprah.obama@nasa.org.us", "Oprah", "Obama" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 49,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.winslet@gov.ru", "Kate", "Winslet" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 50,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "elvis.presley@gov.ru", "Elvis", "Presley" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 51,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "donald.trump@gov.gr", "Donald", "Trump" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 52,
                columns: new[] { "email", "last_name" },
                values: new object[] { "kate.presley@gov.us", "Presley" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 53,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "jimi.winfrey@something.com", "Jimi", "Winfrey" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 54,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.winfrey@bbc.co.uk", "Kate", "Winfrey" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 55,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "audrey.trump@gov.ru", "Audrey", "Trump" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 56,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "jimi.trump@gov.us", "Jimi", "Trump" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 57,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.presley@theworld.ca", "Kate", "Presley" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 58,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.trump@gov.nl", "Kate", "Trump" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 59,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "donald.windsor@google.com", "Donald", "Windsor" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 60,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "oprah.hendrix@gov.us", "Oprah", "Hendrix" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 61,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "elvis.windsor@gov.us", "Elvis", "Windsor" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 62,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.winfrey@something.com", "Kate", "Winfrey" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 63,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "mick.obama@something.com", "Mick", "Obama" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 64,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "charles.trump@gov.gr", "Charles", "Trump" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 65,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "oprah.hendrix@gov.gr", "Oprah", "Hendrix" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 66,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.winslet@gov.nl", "Kate", "Winslet" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 67,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "mick.presley@gov.us", "Mick", "Presley" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 68,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "oprah.winslet@gov.gr", "Oprah", "Winslet" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 69,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.hepburn@theworld.ca", "Kate", "Hepburn" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 70,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "donald.presley@gov.us", "Donald", "Presley" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 71,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.presley@gov.nl", "Kate", "Presley" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 72,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "audrey.presley@bbc.co.uk", "Audrey", "Presley" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 73,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "barack.trump@google.com", "Barack", "Trump" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 74,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "jimi.jagger@something.com", "Jimi", "Jagger" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 75,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "charles.hepburn@bbc.co.uk", "Charles", "Hepburn" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 76,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "elvis.jagger@gov.gr", "Elvis", "Jagger" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 77,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "charles.obama@bbc.co.uk", "Charles", "Obama" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 78,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "oprah.trump@nasa.org.us", "Oprah", "Trump" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 79,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "donald.presley@tesla.com", "Donald", "Presley" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 80,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "jimi.middleton@google.com", "Jimi", "Middleton" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 81,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "charles.presley@gov.us", "Charles", "Presley" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 82,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "charles.obama@nasa.org.us", "Charles", "Obama" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 83,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "donald.winfrey@gov.gr", "Donald", "Winfrey" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 84,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.trump@nasa.org.us", "Kate", "Trump" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 85,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "mick.obama@tesla.com", "Mick", "Obama" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 86,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "donald.presley@tesla.com", "Donald", "Presley" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 87,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "charles.winfrey@theworld.ca", "Charles", "Winfrey" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 88,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "oprah.jagger@tesla.com", "Oprah", "Jagger" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 89,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "mick.windsor@gov.ru", "Mick", "Windsor" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 90,
                columns: new[] { "email", "first_name" },
                values: new object[] { "audrey.trump@google.com", "Audrey" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 91,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "elvis.presley@bbc.co.uk", "Elvis", "Presley" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 92,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.winslet@bbc.co.uk", "Kate", "Winslet" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 93,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "oprah.winfrey@theworld.ca", "Oprah", "Winfrey" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 94,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "audrey.obama@bbc.co.uk", "Audrey", "Obama" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 95,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "mick.jagger@google.com", "Mick", "Jagger" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 96,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "charles.presley@gov.ru", "Charles", "Presley" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 97,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "oprah.middleton@gov.ru", "Oprah", "Middleton" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 98,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.obama@gov.ru", "Kate", "Obama" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 99,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "barack.obama@gov.us", "Barack", "Obama" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 100,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "oprah.obama@gov.nl", "Oprah", "Obama" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 101,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "donald.hendrix@nasa.org.us", "Donald", "Hendrix" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 102,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "audrey.windsor@tesla.com", "Audrey", "Windsor" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 103,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "mick.obama@google.com", "Mick", "Obama" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 104,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.jagger@theworld.ca", "Kate", "Jagger" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 105,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "charles.hepburn@google.com", "Charles", "Hepburn" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 106,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "barack.hepburn@something.com", "Barack", "Hepburn" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 107,
                columns: new[] { "email", "first_name" },
                values: new object[] { "mick.trump@gov.nl", "Mick" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 108,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "elvis.winslet@gov.nl", "Elvis", "Winslet" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 109,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "oprah.middleton@gov.nl", "Oprah", "Middleton" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 110,
                columns: new[] { "email", "last_name" },
                values: new object[] { "jimi.middleton@gov.gr", "Middleton" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 111,
                columns: new[] { "email", "first_name" },
                values: new object[] { "audrey.jagger@google.com", "Audrey" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 112,
                columns: new[] { "email", "first_name" },
                values: new object[] { "kate.windsor@gov.gr", "Kate" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 113,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "elvis.hepburn@theworld.ca", "Elvis", "Hepburn" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 114,
                columns: new[] { "email", "last_name" },
                values: new object[] { "kate.winfrey@gov.gr", "Winfrey" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 115,
                columns: new[] { "email", "last_name" },
                values: new object[] { "donald.middleton@tesla.com", "Middleton" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 116,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "jimi.obama@nasa.org.us", "Jimi", "Obama" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 117,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "donald.middleton@tesla.com", "Donald", "Middleton" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 118,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.trump@tesla.com", "Kate", "Trump" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 119,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.presley@gov.nl", "Kate", "Presley" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 120,
                columns: new[] { "email", "first_name" },
                values: new object[] { "charles.jagger@theworld.ca", "Charles" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 121,
                columns: new[] { "email", "first_name" },
                values: new object[] { "kate.winfrey@gov.ru", "Kate" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 122,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "barack.jagger@nasa.org.us", "Barack", "Jagger" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 123,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "mick.presley@theworld.ca", "Mick", "Presley" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 124,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "jimi.winslet@gov.gr", "Jimi", "Winslet" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 125,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "barack.winslet@tesla.com", "Barack", "Winslet" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 126,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "jimi.jagger@gov.ru", "Jimi", "Jagger" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 127,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "jimi.windsor@gov.nl", "Jimi", "Windsor" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 128,
                columns: new[] { "email", "last_name" },
                values: new object[] { "donald.jagger@something.com", "Jagger" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 129,
                columns: new[] { "email", "last_name" },
                values: new object[] { "charles.windsor@theworld.ca", "Windsor" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 130,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "charles.windsor@bbc.co.uk", "Charles", "Windsor" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 131,
                columns: new[] { "email", "last_name" },
                values: new object[] { "kate.hendrix@bbc.co.uk", "Hendrix" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 132,
                columns: new[] { "email", "last_name" },
                values: new object[] { "jimi.middleton@tesla.com", "Middleton" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 133,
                columns: new[] { "email", "first_name" },
                values: new object[] { "kate.windsor@gov.nl", "Kate" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 134,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "mick.obama@something.com", "Mick", "Obama" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 135,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "mick.winslet@gov.us", "Mick", "Winslet" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 136,
                columns: new[] { "email", "first_name" },
                values: new object[] { "jimi.obama@gov.nl", "Jimi" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 137,
                columns: new[] { "email", "first_name" },
                values: new object[] { "mick.obama@theworld.ca", "Mick" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 138,
                columns: new[] { "email", "first_name" },
                values: new object[] { "kate.winfrey@gov.us", "Kate" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 139,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "elvis.trump@gov.nl", "Elvis", "Trump" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 140,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.windsor@gov.gr", "Kate", "Windsor" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 141,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "charles.hepburn@something.com", "Charles", "Hepburn" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 142,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.obama@gov.us", "Kate", "Obama" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 143,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "elvis.jagger@nasa.org.us", "Elvis", "Jagger" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 144,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "donald.presley@gov.gr", "Donald", "Presley" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 145,
                columns: new[] { "email", "first_name" },
                values: new object[] { "jimi.hendrix@gov.nl", "Jimi" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 146,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "charles.jagger@nasa.org.us", "Charles", "Jagger" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 147,
                columns: new[] { "email", "first_name" },
                values: new object[] { "donald.obama@bbc.co.uk", "Donald" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 148,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "mick.winfrey@nasa.org.us", "Mick", "Winfrey" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 149,
                columns: new[] { "email", "first_name" },
                values: new object[] { "jimi.jagger@gov.us", "Jimi" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 150,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.presley@nasa.org.us", "Kate", "Presley" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 151,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "elvis.hepburn@something.com", "Elvis", "Hepburn" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 152,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.windsor@gov.us", "Kate", "Windsor" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 153,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "oprah.trump@nasa.org.us", "Oprah", "Trump" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 154,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "donald.obama@tesla.com", "Donald", "Obama" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 155,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.middleton@theworld.ca", "Kate", "Middleton" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 156,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "elvis.hepburn@gov.gr", "Elvis", "Hepburn" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 157,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "mick.trump@gov.ru", "Mick", "Trump" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 158,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "oprah.middleton@bbc.co.uk", "Oprah", "Middleton" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 159,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "donald.presley@something.com", "Donald", "Presley" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 160,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "charles.hepburn@gov.nl", "Charles", "Hepburn" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 161,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "audrey.middleton@theworld.ca", "Audrey", "Middleton" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 162,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "donald.presley@theworld.ca", "Donald", "Presley" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 163,
                columns: new[] { "email", "last_name" },
                values: new object[] { "elvis.winfrey@gov.nl", "Winfrey" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 164,
                columns: new[] { "email", "last_name" },
                values: new object[] { "kate.jagger@bbc.co.uk", "Jagger" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 165,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "oprah.windsor@google.com", "Oprah", "Windsor" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 166,
                columns: new[] { "email", "last_name" },
                values: new object[] { "barack.trump@tesla.com", "Trump" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 167,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "charles.trump@gov.nl", "Charles", "Trump" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 168,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "donald.hendrix@gov.gr", "Donald", "Hendrix" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 169,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "mick.presley@something.com", "Mick", "Presley" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 170,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "barack.hendrix@nasa.org.us", "Barack", "Hendrix" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 171,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "jimi.presley@gov.gr", "Jimi", "Presley" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 172,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "jimi.middleton@nasa.org.us", "Jimi", "Middleton" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 173,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "jimi.trump@gov.us", "Jimi", "Trump" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 174,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "mick.windsor@nasa.org.us", "Mick", "Windsor" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 175,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "mick.middleton@gov.ru", "Mick", "Middleton" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 176,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.obama@google.com", "Kate", "Obama" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 177,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.middleton@tesla.com", "Kate", "Middleton" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 178,
                columns: new[] { "email", "last_name" },
                values: new object[] { "kate.jagger@gov.us", "Jagger" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 179,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "audrey.jagger@bbc.co.uk", "Audrey", "Jagger" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 180,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.presley@bbc.co.uk", "Kate", "Presley" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 181,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.winslet@gov.nl", "Kate", "Winslet" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 182,
                columns: new[] { "email", "last_name" },
                values: new object[] { "elvis.winfrey@something.com", "Winfrey" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 183,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.trump@bbc.co.uk", "Kate", "Trump" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 184,
                columns: new[] { "email", "last_name" },
                values: new object[] { "charles.presley@gov.nl", "Presley" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 185,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "donald.middleton@google.com", "Donald", "Middleton" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 186,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "mick.middleton@gov.us", "Mick", "Middleton" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 187,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "oprah.trump@nasa.org.us", "Oprah", "Trump" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 188,
                columns: new[] { "email", "first_name" },
                values: new object[] { "donald.hendrix@bbc.co.uk", "Donald" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 189,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "elvis.obama@gov.gr", "Elvis", "Obama" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 190,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "charles.middleton@tesla.com", "Charles", "Middleton" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 191,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "barack.presley@bbc.co.uk", "Barack", "Presley" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 192,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "charles.presley@tesla.com", "Charles", "Presley" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 193,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.hepburn@something.com", "Kate", "Hepburn" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 194,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "donald.middleton@gov.gr", "Donald", "Middleton" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 195,
                columns: new[] { "email", "last_name" },
                values: new object[] { "mick.hepburn@gov.gr", "Hepburn" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 196,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "barack.obama@something.com", "Barack", "Obama" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 197,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.trump@gov.us", "Kate", "Trump" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 198,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "elvis.hepburn@theworld.ca", "Elvis", "Hepburn" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 199,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "jimi.hepburn@tesla.com", "Jimi", "Hepburn" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 200,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "mick.middleton@nasa.org.us", "Mick", "Middleton" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 201,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "oprah.middleton@gov.us", "Oprah", "Middleton" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 202,
                columns: new[] { "email", "last_name" },
                values: new object[] { "kate.middleton@gov.us", "Middleton" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 203,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "donald.hendrix@gov.ru", "Donald", "Hendrix" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 204,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "jimi.hendrix@bbc.co.uk", "Jimi", "Hendrix" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 205,
                column: "email",
                value: "kate.windsor@theworld.ca");

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 206,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.hendrix@gov.ru", "Kate", "Hendrix" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 207,
                columns: new[] { "email", "first_name" },
                values: new object[] { "barack.obama@gov.gr", "Barack" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 208,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "donald.winfrey@theworld.ca", "Donald", "Winfrey" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 209,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "donald.middleton@google.com", "Donald", "Middleton" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 210,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "audrey.presley@gov.gr", "Audrey", "Presley" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 211,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "oprah.presley@gov.ru", "Oprah", "Presley" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 212,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "audrey.winslet@gov.us", "Audrey", "Winslet" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 213,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.winslet@tesla.com", "Kate", "Winslet" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 214,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "barack.presley@google.com", "Barack", "Presley" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 215,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "donald.winfrey@gov.nl", "Donald", "Winfrey" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 216,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "barack.hepburn@theworld.ca", "Barack", "Hepburn" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 217,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "charles.obama@gov.gr", "Charles", "Obama" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 218,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "audrey.jagger@gov.gr", "Audrey", "Jagger" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 219,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "oprah.hendrix@theworld.ca", "Oprah", "Hendrix" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 220,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "audrey.windsor@gov.gr", "Audrey", "Windsor" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 221,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "charles.trump@google.com", "Charles", "Trump" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 222,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "charles.hendrix@gov.nl", "Charles", "Hendrix" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 223,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.winfrey@gov.gr", "Kate", "Winfrey" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 224,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "mick.hendrix@gov.us", "Mick", "Hendrix" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 225,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "barack.winfrey@something.com", "Barack", "Winfrey" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 226,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "donald.hendrix@tesla.com", "Donald", "Hendrix" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 227,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "audrey.presley@something.com", "Audrey", "Presley" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 228,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "charles.winslet@gov.nl", "Charles", "Winslet" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 229,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "mick.obama@theworld.ca", "Mick", "Obama" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 230,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "audrey.hepburn@gov.us", "Audrey", "Hepburn" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 231,
                columns: new[] { "email", "last_name" },
                values: new object[] { "donald.hendrix@gov.ru", "Hendrix" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 232,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "donald.jagger@theworld.ca", "Donald", "Jagger" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 233,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.windsor@theworld.ca", "Kate", "Windsor" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 234,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "oprah.winfrey@bbc.co.uk", "Oprah", "Winfrey" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 235,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "elvis.middleton@theworld.ca", "Elvis", "Middleton" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 236,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "audrey.hepburn@something.com", "Audrey", "Hepburn" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 237,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "charles.middleton@something.com", "Charles", "Middleton" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 238,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "audrey.obama@theworld.ca", "Audrey", "Obama" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 239,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "donald.presley@tesla.com", "Donald", "Presley" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 240,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "oprah.hepburn@nasa.org.us", "Oprah", "Hepburn" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 241,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "jimi.winslet@gov.nl", "Jimi", "Winslet" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 242,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "charles.winslet@gov.ru", "Charles", "Winslet" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 243,
                columns: new[] { "email", "last_name" },
                values: new object[] { "charles.trump@gov.us", "Trump" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 244,
                columns: new[] { "email", "first_name" },
                values: new object[] { "oprah.presley@theworld.ca", "Oprah" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 245,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.hepburn@gov.ru", "Kate", "Hepburn" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 246,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "barack.winslet@gov.nl", "Barack", "Winslet" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 247,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "elvis.winfrey@nasa.org.us", "Elvis", "Winfrey" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 248,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "jimi.hendrix@tesla.com", "Jimi", "Hendrix" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 249,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "jimi.presley@something.com", "Jimi", "Presley" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 147, 9, "An army of Orange Flowers" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 179, 10, "The Bitter Planets" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 21, 3, "Several Transparent Buildings" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 159, 2, "A bunch of Transparent Flowers" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 100, 5, "Several Microscopic Planets" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 229, 1, "Two Transparent Leopards" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 63, 9, "The Transparent Flowers" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 68, 8, "The Large Cars" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 217, 10, "A herd of Green Planets" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 113, 10, "Two Green Buildings" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 32, 5, "Several Microscopic Buildings" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 235, 5, "Two Microscopic Leopards" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 94, 1, "The Bitter Buildings" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 163, 7, "The Green Planets" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 18, 3, "An army of Microscopic Cars" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 102, 7, "A herd of Purple Buildings" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 137, 8, "Two Purple Planets" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 168, 10, "The Bitter Houses" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 4, 5, "The Microscopic Cars" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 6, 1, "The Orange Cars" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 109, 3, "Two Orange Leopards" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 198, 1, "Several Purple Planets" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 179, 2, "The Orange Houses" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 98, 8, "Fifteen Orange Buildings" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 15, 4, "Fifteen Purple Cars" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 179, 5, "The Microscopic Planets" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 208, 2, "The Transparent Houses" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 150, 5, "The Purple Planets" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 224, 9, "Several Transparent Leopards" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 219, 2, "Two Orange Buildings" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 150, 9, "A herd of Bitter Houses" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 177, 10, "A bunch of Purple Houses" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 33,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 175, 10, "A bunch of Purple Planets" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 34,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 26, 5, "Fifteen Purple Planets" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 35,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 125, 8, "The Transparent Cars" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 36,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 134, 8, "An army of Orange Houses" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 37,
                columns: new[] { "author_id", "title" },
                values: new object[] { 50, "Several Green Cars" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 38,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 32, 5, "Two Microscopic Planets" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 39,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 240, 10, "Two Microscopic Leopards" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 40,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 86, 6, "An army of Bitter Flowers" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 41,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 33, 5, "A bunch of Orange Planets" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 42,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 53, 1, "Fifteen Transparent Flowers" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 43,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 147, 10, "Two Bitter Houses" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 44,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 210, 3, "A bunch of Large Houses" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 45,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 11, 3, "The Orange Buildings" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 46,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 89, 10, "The Orange Houses" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 47,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 186, 8, "Several Green Cars" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 48,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 140, 3, "A herd of Large Flowers" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 49,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 19, 5, "Several Large Houses" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 50,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 133, 2, "A herd of Purple Houses" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 51,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 95, 7, "Fifteen Orange Cars" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 52,
                columns: new[] { "author_id", "title" },
                values: new object[] { 8, "Two Large Planets" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 53,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 17, 4, "Fifteen Transparent Leopards" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 54,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 180, 9, "Two Purple Cars" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 55,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 249, 5, "Fifteen Purple Buildings" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 56,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 189, 1, "A bunch of Microscopic Buildings" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 57,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 70, 9, "The Large Houses" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 58,
                columns: new[] { "author_id", "title" },
                values: new object[] { 173, "A bunch of Large Leopards" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 59,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 225, 1, "An army of Purple Cars" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 60,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 144, 4, "Several Green Leopards" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 61,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 71, 6, "An army of Rose Smelling Flowers" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 62,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 147, 10, "The Purple Houses" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 63,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 123, 4, "A herd of Purple Cars" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 64,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 51, 2, "Fifteen Large Flowers" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 65,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 150, 6, "An army of Microscopic Leopards" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 66,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 204, 1, "A bunch of Orange Houses" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 67,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 210, 3, "Fifteen Transparent Planets" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 68,
                columns: new[] { "author_id", "publisher_id" },
                values: new object[] { 148, 5 });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 69,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 91, 6, "Several Microscopic Buildings" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 70,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 173, 9, "Two Transparent Leopards" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 71,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 204, 8, "A bunch of Microscopic Planets" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 72,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 57, 4, "The Orange Buildings" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 73,
                columns: new[] { "author_id", "title" },
                values: new object[] { 210, "The Bitter Leopards" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 74,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 65, 1, "Two Rose Smelling Houses" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 75,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 236, 1, "Two Large Cars" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 76,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 224, 6, "A herd of Bitter Leopards" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 77,
                columns: new[] { "author_id", "title" },
                values: new object[] { 100, "The Orange Houses" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 78,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 189, 7, "An army of Microscopic Planets" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 79,
                columns: new[] { "author_id", "title" },
                values: new object[] { 105, "Fifteen Microscopic Planets" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 80,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 25, 6, "The Large Buildings" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 81,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 37, 4, "A bunch of Microscopic Leopards" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 82,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 26, 5, "An army of Orange Planets" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 83,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 151, 4, "An army of Orange Planets" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 84,
                columns: new[] { "author_id", "title" },
                values: new object[] { 218, "Several Microscopic Cars" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 85,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 211, 2, "An army of Large Planets" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 86,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 147, 7, "Fifteen Rose Smelling Cars" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 87,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 229, 2, "The Transparent Buildings" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 88,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 39, 9, "A bunch of Microscopic Flowers" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 89,
                columns: new[] { "author_id", "title" },
                values: new object[] { 72, "A herd of Green Planets" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 90,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 126, 7, "An army of Green Cars" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 91,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 168, 9, "Fifteen Bitter Flowers" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 92,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 92, 3, "Fifteen Microscopic Buildings" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 93,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 193, 5, "Fifteen Transparent Cars" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 94,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 226, 10, "Fifteen Rose Smelling Cars" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 95,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 15, 7, "Fifteen Large Leopards" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 96,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 44, 7, "Fifteen Rose Smelling Houses" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 97,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 114, 9, "The Rose Smelling Buildings" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 98,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 71, 6, "Two Orange Buildings" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 99,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 143, 9, "A bunch of Microscopic Planets" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 100,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 187, 3, "Two Bitter Cars" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 101,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 167, 1, "The Bitter Buildings" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 102,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 171, 8, "Two Green Leopards" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 103,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 225, 10, "The Rose Smelling Buildings" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 104,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 92, 5, "A herd of Orange Planets" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 105,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 46, 3, "Fifteen Bitter Flowers" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 106,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 58, 9, "A herd of Purple Flowers" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 107,
                columns: new[] { "author_id", "title" },
                values: new object[] { 15, "The Orange Flowers" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 108,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 211, 4, "Several Rose Smelling Buildings" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 109,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 211, 2, "The Large Cars" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 110,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 143, 5, "Two Orange Houses" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 111,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 190, 7, "A bunch of Purple Flowers" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 112,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 137, 8, "An army of Orange Houses" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 113,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 118, 6, "A bunch of Orange Buildings" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 114,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 185, 7, "Several Bitter Leopards" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 115,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 101, 7, "Two Microscopic Cars" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 116,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 219, 1, "A herd of Microscopic Buildings" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 117,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 29, 8, "Two Purple Planets" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 118,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 144, 1, "Several Bitter Leopards" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 119,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 43, 8, "Several Purple Flowers" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 120,
                columns: new[] { "author_id", "title" },
                values: new object[] { 116, "A herd of Large Leopards" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 121,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 113, 3, "The Large Buildings" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 122,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 218, 3, "Two Transparent Houses" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 123,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 110, 9, "Fifteen Orange Buildings" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 124,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 191, 7, "Several Microscopic Houses" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 125,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 132, 3, "Several Green Cars" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 126,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 120, 7, "Two Rose Smelling Flowers" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 127,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 155, 2, "Fifteen Orange Planets" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 128,
                columns: new[] { "author_id", "title" },
                values: new object[] { 194, "An army of Purple Houses" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 129,
                column: "author_id",
                value: 23);

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 130,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 204, 1, "An army of Large Houses" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 131,
                columns: new[] { "author_id", "title" },
                values: new object[] { 102, "Fifteen Orange Cars" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 132,
                columns: new[] { "author_id", "title" },
                values: new object[] { 79, "A herd of Large Leopards" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 133,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 53, 9, "A bunch of Rose Smelling Planets" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 134,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 10, 7, "Several Microscopic Buildings" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 135,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 30, 7, "A bunch of Bitter Buildings" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 136,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 36, 9, "Two Purple Leopards" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 137,
                columns: new[] { "author_id", "publisher_id" },
                values: new object[] { 104, 3 });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 138,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 247, 7, "Two Microscopic Planets" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 139,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 188, 2, "A bunch of Purple Buildings" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 140,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 82, 6, "Fifteen Purple Buildings" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 141,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 152, 4, "Several Rose Smelling Planets" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 142,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 165, 4, "An army of Large Cars" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 143,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 160, 3, "Two Bitter Cars" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 144,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 143, 5, "An army of Orange Cars" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 145,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 202, 2, "Two Bitter Cars" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 146,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 106, 6, "The Transparent Planets" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 147,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 232, 2, "Two Transparent Cars" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 148,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 210, 2, "A herd of Large Leopards" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 149,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 209, 8, "A herd of Microscopic Cars" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 150,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 42, 10, "The Large Leopards" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 151,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 144, 3, "The Rose Smelling Planets" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 152,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 88, 5, "Fifteen Orange Cars" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 153,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 228, 6, "The Orange Houses" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 154,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 16, 1, "Several Bitter Leopards" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 155,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 69, 4, "A bunch of Bitter Houses" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 156,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 179, 7, "Several Green Houses" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 157,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 75, 6, "An army of Microscopic Planets" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 158,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 80, 7, "Several Rose Smelling Flowers" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 159,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 208, 7, "Fifteen Orange Flowers" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 160,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 100, 2, "An army of Large Cars" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 161,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 13, 5, "Two Purple Flowers" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 162,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 161, 2, "A bunch of Microscopic Leopards" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 163,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 106, 7, "An army of Purple Planets" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 164,
                columns: new[] { "author_id", "title" },
                values: new object[] { 174, "A herd of Orange Planets" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 165,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 167, 10, "An army of Orange Flowers" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 166,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 242, 9, "A bunch of Transparent Buildings" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 167,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 162, 8, "An army of Purple Buildings" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 168,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 187, 2, "Two Transparent Cars" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 169,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 218, 5, "The Bitter Leopards" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 170,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 30, 8, "A bunch of Bitter Houses" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 171,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 14, 6, "Two Rose Smelling Cars" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 172,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 226, 7, "The Rose Smelling Flowers" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 173,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 221, 9, "An army of Bitter Leopards" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 174,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 211, 10, "A bunch of Green Planets" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 175,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 33, 2, "Two Large Leopards" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 176,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 57, 10, "A herd of Green Houses" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 177,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 95, 5, "An army of Large Cars" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 178,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 142, 5, "A bunch of Large Houses" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 179,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 152, 10, "A herd of Orange Flowers" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 180,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 48, 4, "The Large Buildings" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 181,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 167, 8, "Fifteen Rose Smelling Leopards" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 182,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 189, 5, "A herd of Large Leopards" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 183,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 88, 7, "The Purple Houses" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 184,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 238, 4, "A herd of Rose Smelling Planets" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 185,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 41, 3, "A bunch of Purple Buildings" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 186,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 200, 3, "Several Orange Planets" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 187,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 239, 1, "The Large Houses" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 188,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 166, 8, "Fifteen Orange Buildings" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 189,
                columns: new[] { "author_id", "title" },
                values: new object[] { 26, "Several Orange Flowers" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 190,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 231, 3, "Several Transparent Planets" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 191,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 66, 5, "A bunch of Orange Flowers" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 192,
                columns: new[] { "author_id", "title" },
                values: new object[] { 202, "The Rose Smelling Leopards" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 193,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 114, 9, "A herd of Green Cars" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 194,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 234, 6, "A herd of Microscopic Planets" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 195,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 176, 6, "A herd of Purple Leopards" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 196,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 166, 8, "The Orange Buildings" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 197,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 172, 5, "A bunch of Transparent Planets" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 198,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 145, 6, "Fifteen Bitter Planets" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 199,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 26, 10, "The Rose Smelling Flowers" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 200,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 2, 4, "Fifteen Orange Flowers" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 201,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 115, 4, "Fifteen Green Flowers" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 202,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 216, 9, "The Microscopic Flowers" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 203,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 40, 5, "An army of Orange Flowers" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 204,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 163, 5, "The Bitter Leopards" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 205,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 247, 4, "An army of Microscopic Buildings" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 206,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 235, 10, "An army of Orange Houses" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 207,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 167, 4, "Two Transparent Flowers" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 208,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 219, 1, "The Large Houses" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 209,
                columns: new[] { "author_id", "title" },
                values: new object[] { 102, "A herd of Orange Flowers" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 210,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 105, 6, "A herd of Rose Smelling Buildings" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 211,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 205, 8, "Two Large Cars" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 212,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 226, 9, "Fifteen Purple Leopards" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 213,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 15, 8, "Two Purple Flowers" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 214,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 24, 7, "Two Transparent Houses" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 215,
                columns: new[] { "author_id", "title" },
                values: new object[] { 62, "A herd of Bitter Planets" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 216,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 63, 3, "Several Rose Smelling Houses" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 217,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 16, 4, "Several Microscopic Buildings" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 218,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 155, 9, "Two Bitter Cars" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 219,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 159, 4, "An army of Purple Cars" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 220,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 213, 3, "The Bitter Flowers" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 221,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 163, 7, "A herd of Large Planets" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 222,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 74, 6, "The Bitter Flowers" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 223,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 208, 3, "A bunch of Purple Houses" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 224,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 50, 3, "Several Orange Cars" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 225,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 229, 2, "An army of Microscopic Cars" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 226,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 105, 2, "Several Transparent Cars" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 227,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 22, 4, "A bunch of Bitter Flowers" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 228,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 227, 2, "Several Green Flowers" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 229,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 65, 4, "An army of Large Leopards" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 230,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 245, 9, "Two Bitter Houses" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 231,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 33, 7, "A bunch of Microscopic Houses" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 232,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 131, 3, "A herd of Microscopic Buildings" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 233,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 209, 5, "Fifteen Transparent Planets" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 234,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 233, 2, "A bunch of Transparent Buildings" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 235,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 227, 2, "Fifteen Microscopic Cars" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 236,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 164, 10, "A herd of Microscopic Planets" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 237,
                columns: new[] { "author_id", "title" },
                values: new object[] { 132, "An army of Purple Houses" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 238,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 192, 7, "A herd of Green Leopards" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 239,
                columns: new[] { "author_id", "title" },
                values: new object[] { 241, "The Microscopic Flowers" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 240,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 36, 3, "Fifteen Transparent Buildings" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 241,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 242, 1, "Fifteen Orange Cars" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 242,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 202, 4, "The Purple Flowers" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 243,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 165, 7, "Fifteen Large Buildings" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 244,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 128, 4, "The Green Cars" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 245,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 165, 5, "Fifteen Rose Smelling Buildings" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 246,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 246, 1, "Several Bitter Flowers" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 247,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 142, 1, "An army of Large Cars" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 248,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 12, 5, "A herd of Microscopic Planets" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 249,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 101, 7, "The Transparent Houses" });

            migrationBuilder.CreateIndex(
                name: "IX_books_author_id",
                table: "books",
                column: "author_id");

            migrationBuilder.AddForeignKey(
                name: "FK_books_authors_author_id",
                table: "books",
                column: "author_id",
                principalTable: "authors",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
