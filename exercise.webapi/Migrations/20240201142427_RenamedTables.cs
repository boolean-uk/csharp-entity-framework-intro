using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace exercise.webapi.Migrations
{
    /// <inheritdoc />
    public partial class RenamedTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_Authors_author_id",
                table: "Books");

            migrationBuilder.DropForeignKey(
                name: "FK_Books_Publishers_publisher_id",
                table: "Books");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Publishers",
                table: "Publishers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Books",
                table: "Books");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Authors",
                table: "Authors");

            migrationBuilder.RenameTable(
                name: "Publishers",
                newName: "publishers");

            migrationBuilder.RenameTable(
                name: "Books",
                newName: "books");

            migrationBuilder.RenameTable(
                name: "Authors",
                newName: "authors");

            migrationBuilder.RenameIndex(
                name: "IX_Books_publisher_id",
                table: "books",
                newName: "IX_books_publisher_id");

            migrationBuilder.RenameIndex(
                name: "IX_Books_author_id",
                table: "books",
                newName: "IX_books_author_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_publishers",
                table: "publishers",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_books",
                table: "books",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_authors",
                table: "authors",
                column: "id");

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "barack.presley@google.com", "Barack", "Presley" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.winfrey@something.com", "Kate", "Winfrey" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "barack.hendrix@gov.nl", "Barack", "Hendrix" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "jimi.obama@gov.ru", "Jimi", "Obama" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "elvis.hendrix@something.com", "Elvis", "Hendrix" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "charles.hendrix@gov.nl", "Charles", "Hendrix" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "charles.presley@gov.us", "Charles", "Presley" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "oprah.hendrix@gov.us", "Oprah", "Hendrix" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "email", "last_name" },
                values: new object[] { "barack.obama@something.com", "Obama" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "audrey.hepburn@gov.us", "Audrey", "Hepburn" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "barack.middleton@gov.us", "Barack", "Middleton" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "jimi.jagger@gov.ru", "Jimi", "Jagger" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "email", "last_name" },
                values: new object[] { "kate.presley@google.com", "Presley" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "barack.middleton@bbc.co.uk", "Barack", "Middleton" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.middleton@nasa.org.us", "Kate", "Middleton" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "oprah.jagger@gov.gr", "Oprah", "Jagger" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "barack.hepburn@gov.us", "Barack", "Hepburn" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.winslet@something.com", "Kate", "Winslet" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "email", "first_name" },
                values: new object[] { "jimi.hendrix@theworld.ca", "Jimi" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "jimi.winslet@something.com", "Jimi", "Winslet" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "audrey.middleton@google.com", "Audrey", "Middleton" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "email", "first_name" },
                values: new object[] { "charles.winslet@bbc.co.uk", "Charles" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "donald.windsor@tesla.com", "Donald", "Windsor" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "elvis.jagger@nasa.org.us", "Elvis", "Jagger" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "audrey.hendrix@gov.gr", "Audrey", "Hendrix" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "email", "last_name" },
                values: new object[] { "mick.obama@bbc.co.uk", "Obama" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "barack.winslet@gov.gr", "Barack", "Winslet" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "email", "last_name" },
                values: new object[] { "kate.presley@gov.ru", "Presley" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "barack.presley@tesla.com", "Barack", "Presley" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "charles.windsor@gov.ru", "Charles", "Windsor" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "elvis.hepburn@tesla.com", "Elvis", "Hepburn" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "mick.winfrey@gov.gr", "Mick", "Winfrey" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 33,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "jimi.presley@something.com", "Jimi", "Presley" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 34,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "mick.trump@gov.nl", "Mick", "Trump" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 35,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "oprah.winslet@bbc.co.uk", "Oprah", "Winslet" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 36,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.windsor@gov.ru", "Kate", "Windsor" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 37,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "oprah.jagger@gov.nl", "Oprah", "Jagger" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 38,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "charles.winslet@theworld.ca", "Charles", "Winslet" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 39,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "donald.obama@gov.gr", "Donald", "Obama" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 40,
                columns: new[] { "email", "last_name" },
                values: new object[] { "elvis.hepburn@theworld.ca", "Hepburn" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 41,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "barack.windsor@gov.nl", "Barack", "Windsor" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 42,
                columns: new[] { "email", "first_name" },
                values: new object[] { "jimi.winslet@bbc.co.uk", "Jimi" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 43,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.hendrix@gov.nl", "Kate", "Hendrix" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 44,
                columns: new[] { "email", "last_name" },
                values: new object[] { "barack.presley@bbc.co.uk", "Presley" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 45,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "charles.presley@gov.ru", "Charles", "Presley" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 46,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "jimi.winfrey@google.com", "Jimi", "Winfrey" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 47,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "donald.obama@google.com", "Donald", "Obama" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 48,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "audrey.trump@gov.gr", "Audrey", "Trump" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 49,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "audrey.middleton@gov.gr", "Audrey", "Middleton" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 50,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "mick.obama@bbc.co.uk", "Mick", "Obama" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 51,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "audrey.hendrix@google.com", "Audrey", "Hendrix" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 52,
                columns: new[] { "email", "first_name" },
                values: new object[] { "audrey.trump@gov.nl", "Audrey" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 53,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "donald.jagger@gov.us", "Donald", "Jagger" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 54,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "barack.middleton@nasa.org.us", "Barack", "Middleton" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 55,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "oprah.jagger@gov.ru", "Oprah", "Jagger" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 56,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "audrey.winslet@gov.ru", "Audrey", "Winslet" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 57,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "elvis.winfrey@bbc.co.uk", "Elvis", "Winfrey" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 58,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "mick.middleton@google.com", "Mick", "Middleton" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 59,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "oprah.trump@nasa.org.us", "Oprah", "Trump" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 60,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "audrey.middleton@gov.us", "Audrey", "Middleton" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 61,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "jimi.windsor@tesla.com", "Jimi", "Windsor" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 62,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "elvis.windsor@gov.gr", "Elvis", "Windsor" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 63,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "jimi.jagger@bbc.co.uk", "Jimi", "Jagger" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 64,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.presley@bbc.co.uk", "Kate", "Presley" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 65,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.winfrey@gov.ru", "Kate", "Winfrey" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 66,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.presley@gov.us", "Kate", "Presley" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 67,
                columns: new[] { "email", "first_name" },
                values: new object[] { "elvis.presley@gov.ru", "Elvis" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 68,
                columns: new[] { "email", "first_name" },
                values: new object[] { "oprah.obama@gov.us", "Oprah" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 69,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "barack.winfrey@gov.gr", "Barack", "Winfrey" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 70,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "charles.winfrey@gov.gr", "Charles", "Winfrey" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 71,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "audrey.middleton@theworld.ca", "Audrey", "Middleton" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 72,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "audrey.hendrix@something.com", "Audrey", "Hendrix" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 73,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "mick.winslet@bbc.co.uk", "Mick", "Winslet" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 74,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "jimi.trump@bbc.co.uk", "Jimi", "Trump" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 75,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "elvis.obama@nasa.org.us", "Elvis", "Obama" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 76,
                columns: new[] { "email", "last_name" },
                values: new object[] { "charles.winfrey@gov.nl", "Winfrey" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 77,
                columns: new[] { "email", "last_name" },
                values: new object[] { "jimi.winfrey@bbc.co.uk", "Winfrey" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 78,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "barack.trump@something.com", "Barack", "Trump" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 79,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "jimi.winslet@google.com", "Jimi", "Winslet" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 80,
                columns: new[] { "email", "first_name" },
                values: new object[] { "barack.windsor@gov.ru", "Barack" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 81,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.hepburn@gov.nl", "Kate", "Hepburn" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 82,
                columns: new[] { "email", "first_name" },
                values: new object[] { "elvis.presley@theworld.ca", "Elvis" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 83,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "elvis.winslet@gov.us", "Elvis", "Winslet" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 84,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "jimi.winslet@gov.gr", "Jimi", "Winslet" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 85,
                columns: new[] { "email", "last_name" },
                values: new object[] { "kate.presley@something.com", "Presley" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 86,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.middleton@gov.ru", "Kate", "Middleton" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 87,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "oprah.trump@google.com", "Oprah", "Trump" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 88,
                columns: new[] { "email", "last_name" },
                values: new object[] { "kate.windsor@gov.gr", "Windsor" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 89,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "oprah.jagger@gov.gr", "Oprah", "Jagger" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 90,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "donald.presley@gov.ru", "Donald", "Presley" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 91,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "jimi.windsor@gov.us", "Jimi", "Windsor" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 92,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.presley@gov.nl", "Kate", "Presley" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 93,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "jimi.obama@google.com", "Jimi", "Obama" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 94,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "elvis.winfrey@gov.gr", "Elvis", "Winfrey" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 95,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "mick.presley@gov.nl", "Mick", "Presley" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 96,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "barack.winslet@bbc.co.uk", "Barack", "Winslet" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 97,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.middleton@gov.us", "Kate", "Middleton" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 98,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "elvis.jagger@bbc.co.uk", "Elvis", "Jagger" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 99,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "donald.winfrey@gov.gr", "Donald", "Winfrey" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 100,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.winslet@something.com", "Kate", "Winslet" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 101,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "elvis.hendrix@google.com", "Elvis", "Hendrix" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 102,
                column: "email",
                value: "mick.trump@gov.ru");

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 103,
                columns: new[] { "email", "first_name" },
                values: new object[] { "kate.winslet@something.com", "Kate" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 104,
                columns: new[] { "email", "first_name" },
                values: new object[] { "barack.jagger@something.com", "Barack" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 105,
                columns: new[] { "email", "last_name" },
                values: new object[] { "elvis.winfrey@bbc.co.uk", "Winfrey" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 106,
                columns: new[] { "email", "last_name" },
                values: new object[] { "barack.obama@google.com", "Obama" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 107,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "donald.hendrix@gov.us", "Donald", "Hendrix" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 108,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "barack.trump@gov.nl", "Barack", "Trump" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 109,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "mick.middleton@something.com", "Mick", "Middleton" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 110,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "barack.obama@theworld.ca", "Barack", "Obama" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 111,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.winfrey@gov.nl", "Kate", "Winfrey" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 112,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "donald.winfrey@gov.ru", "Donald", "Winfrey" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 113,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.winfrey@gov.nl", "Kate", "Winfrey" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 114,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "charles.obama@gov.nl", "Charles", "Obama" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 115,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "audrey.jagger@tesla.com", "Audrey", "Jagger" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 116,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "audrey.jagger@google.com", "Audrey", "Jagger" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 117,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "barack.winfrey@theworld.ca", "Barack", "Winfrey" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 118,
                columns: new[] { "email", "first_name" },
                values: new object[] { "audrey.obama@nasa.org.us", "Audrey" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 119,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "jimi.jagger@tesla.com", "Jimi", "Jagger" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 120,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "donald.hepburn@gov.nl", "Donald", "Hepburn" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 121,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "mick.winfrey@gov.nl", "Mick", "Winfrey" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 122,
                columns: new[] { "email", "first_name" },
                values: new object[] { "oprah.hendrix@tesla.com", "Oprah" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 123,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.jagger@nasa.org.us", "Kate", "Jagger" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 124,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.hepburn@nasa.org.us", "Kate", "Hepburn" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 125,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "barack.middleton@nasa.org.us", "Barack", "Middleton" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 126,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "mick.winfrey@google.com", "Mick", "Winfrey" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 127,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "oprah.presley@something.com", "Oprah", "Presley" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 128,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "elvis.hepburn@gov.ru", "Elvis", "Hepburn" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 129,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.presley@google.com", "Kate", "Presley" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 130,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "elvis.windsor@tesla.com", "Elvis", "Windsor" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 131,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "elvis.windsor@bbc.co.uk", "Elvis", "Windsor" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 132,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.hendrix@gov.ru", "Kate", "Hendrix" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 133,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "donald.jagger@gov.gr", "Donald", "Jagger" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 134,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.windsor@bbc.co.uk", "Kate", "Windsor" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 135,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "oprah.jagger@something.com", "Oprah", "Jagger" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 136,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.trump@gov.us", "Kate", "Trump" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 137,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "jimi.windsor@google.com", "Jimi", "Windsor" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 138,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "elvis.winslet@google.com", "Elvis", "Winslet" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 139,
                columns: new[] { "email", "last_name" },
                values: new object[] { "charles.hendrix@gov.ru", "Hendrix" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 140,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.winfrey@gov.gr", "Kate", "Winfrey" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 141,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "charles.middleton@nasa.org.us", "Charles", "Middleton" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 142,
                columns: new[] { "email", "last_name" },
                values: new object[] { "mick.hendrix@nasa.org.us", "Hendrix" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 143,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "oprah.jagger@gov.ru", "Oprah", "Jagger" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 144,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "mick.obama@theworld.ca", "Mick", "Obama" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 145,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "barack.hendrix@gov.gr", "Barack", "Hendrix" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 146,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "jimi.hendrix@theworld.ca", "Jimi", "Hendrix" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 147,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "jimi.winslet@tesla.com", "Jimi", "Winslet" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 148,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "oprah.obama@gov.ru", "Oprah", "Obama" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 149,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "barack.windsor@something.com", "Barack", "Windsor" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 150,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "donald.winfrey@nasa.org.us", "Donald", "Winfrey" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 151,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "charles.winslet@google.com", "Charles", "Winslet" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 152,
                columns: new[] { "email", "last_name" },
                values: new object[] { "mick.trump@gov.gr", "Trump" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 153,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "charles.hepburn@gov.ru", "Charles", "Hepburn" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 154,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "oprah.middleton@google.com", "Oprah", "Middleton" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 155,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "barack.presley@gov.nl", "Barack", "Presley" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 156,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "donald.jagger@gov.ru", "Donald", "Jagger" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 157,
                columns: new[] { "email", "last_name" },
                values: new object[] { "donald.trump@gov.gr", "Trump" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 158,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "jimi.windsor@theworld.ca", "Jimi", "Windsor" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 159,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "donald.presley@google.com", "Donald", "Presley" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 160,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "mick.windsor@gov.us", "Mick", "Windsor" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 161,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "charles.windsor@google.com", "Charles", "Windsor" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 162,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "jimi.jagger@gov.us", "Jimi", "Jagger" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 163,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "donald.middleton@tesla.com", "Donald", "Middleton" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 164,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "jimi.windsor@theworld.ca", "Jimi", "Windsor" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 165,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "elvis.obama@bbc.co.uk", "Elvis", "Obama" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 166,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "oprah.presley@bbc.co.uk", "Oprah", "Presley" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 167,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "oprah.winslet@nasa.org.us", "Oprah", "Winslet" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 168,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "oprah.middleton@gov.ru", "Oprah", "Middleton" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 169,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "mick.windsor@bbc.co.uk", "Mick", "Windsor" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 170,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "oprah.obama@bbc.co.uk", "Oprah", "Obama" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 171,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "donald.middleton@tesla.com", "Donald", "Middleton" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 172,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.middleton@gov.gr", "Kate", "Middleton" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 173,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "elvis.hendrix@gov.gr", "Elvis", "Hendrix" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 174,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "donald.hendrix@gov.nl", "Donald", "Hendrix" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 175,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "charles.hendrix@nasa.org.us", "Charles", "Hendrix" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 176,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.hendrix@gov.us", "Kate", "Hendrix" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 177,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.hepburn@gov.nl", "Kate", "Hepburn" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 178,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.obama@bbc.co.uk", "Kate", "Obama" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 179,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "charles.winslet@theworld.ca", "Charles", "Winslet" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 180,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "charles.windsor@something.com", "Charles", "Windsor" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 181,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.presley@gov.gr", "Kate", "Presley" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 182,
                columns: new[] { "email", "last_name" },
                values: new object[] { "audrey.presley@gov.ru", "Presley" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 183,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "mick.presley@nasa.org.us", "Mick", "Presley" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 184,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "oprah.winslet@nasa.org.us", "Oprah", "Winslet" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 185,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "barack.obama@gov.gr", "Barack", "Obama" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 186,
                columns: new[] { "email", "last_name" },
                values: new object[] { "oprah.windsor@gov.gr", "Windsor" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 187,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "audrey.obama@gov.ru", "Audrey", "Obama" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 188,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "donald.windsor@gov.ru", "Donald", "Windsor" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 189,
                columns: new[] { "email", "last_name" },
                values: new object[] { "oprah.hepburn@gov.gr", "Hepburn" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 190,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "mick.winfrey@gov.gr", "Mick", "Winfrey" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 191,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "donald.hendrix@google.com", "Donald", "Hendrix" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 192,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.hendrix@gov.ru", "Kate", "Hendrix" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 193,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.jagger@gov.us", "Kate", "Jagger" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 194,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.obama@bbc.co.uk", "Kate", "Obama" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 195,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "barack.windsor@tesla.com", "Barack", "Windsor" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 196,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "elvis.winslet@tesla.com", "Elvis", "Winslet" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 197,
                columns: new[] { "email", "last_name" },
                values: new object[] { "oprah.winfrey@nasa.org.us", "Winfrey" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 198,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "jimi.obama@google.com", "Jimi", "Obama" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 199,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "mick.presley@nasa.org.us", "Mick", "Presley" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 200,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "audrey.middleton@bbc.co.uk", "Audrey", "Middleton" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 201,
                columns: new[] { "email", "last_name" },
                values: new object[] { "audrey.trump@gov.ru", "Trump" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 202,
                columns: new[] { "email", "last_name" },
                values: new object[] { "kate.winfrey@tesla.com", "Winfrey" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 203,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.winslet@gov.us", "Kate", "Winslet" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 204,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "donald.hepburn@gov.gr", "Donald", "Hepburn" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 205,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "charles.presley@theworld.ca", "Charles", "Presley" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 206,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "audrey.obama@something.com", "Audrey", "Obama" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 207,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "charles.hendrix@gov.ru", "Charles", "Hendrix" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 208,
                columns: new[] { "email", "first_name" },
                values: new object[] { "oprah.obama@theworld.ca", "Oprah" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 209,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "barack.hepburn@gov.nl", "Barack", "Hepburn" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 210,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.presley@gov.nl", "Kate", "Presley" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 211,
                columns: new[] { "email", "last_name" },
                values: new object[] { "charles.winfrey@gov.us", "Winfrey" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 212,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.trump@gov.ru", "Kate", "Trump" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 213,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "charles.windsor@gov.nl", "Charles", "Windsor" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 214,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.jagger@gov.ru", "Kate", "Jagger" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 215,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "elvis.middleton@gov.nl", "Elvis", "Middleton" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 216,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "barack.winslet@theworld.ca", "Barack", "Winslet" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 217,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "oprah.windsor@tesla.com", "Oprah", "Windsor" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 218,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "barack.presley@something.com", "Barack", "Presley" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 219,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "audrey.jagger@gov.gr", "Audrey", "Jagger" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 220,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.obama@bbc.co.uk", "Kate", "Obama" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 221,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.middleton@gov.gr", "Kate", "Middleton" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 222,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.winslet@nasa.org.us", "Kate", "Winslet" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 223,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "audrey.windsor@gov.gr", "Audrey", "Windsor" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 224,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "donald.jagger@gov.nl", "Donald", "Jagger" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 225,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "barack.winslet@gov.us", "Barack", "Winslet" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 226,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "jimi.trump@tesla.com", "Jimi", "Trump" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 227,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "mick.winslet@google.com", "Mick", "Winslet" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 228,
                columns: new[] { "email", "last_name" },
                values: new object[] { "barack.hepburn@google.com", "Hepburn" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 229,
                columns: new[] { "email", "last_name" },
                values: new object[] { "mick.windsor@bbc.co.uk", "Windsor" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 230,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "donald.winslet@gov.nl", "Donald", "Winslet" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 231,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "elvis.jagger@google.com", "Elvis", "Jagger" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 232,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "charles.middleton@nasa.org.us", "Charles", "Middleton" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 233,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "donald.windsor@something.com", "Donald", "Windsor" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 234,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "barack.hendrix@nasa.org.us", "Barack", "Hendrix" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 235,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "barack.trump@gov.us", "Barack", "Trump" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 236,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "jimi.trump@bbc.co.uk", "Jimi", "Trump" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 237,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.winfrey@bbc.co.uk", "Kate", "Winfrey" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 238,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "audrey.presley@google.com", "Audrey", "Presley" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 239,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "elvis.middleton@gov.gr", "Elvis", "Middleton" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 240,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "mick.jagger@bbc.co.uk", "Mick", "Jagger" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 241,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.obama@google.com", "Kate", "Obama" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 242,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.winfrey@gov.ru", "Kate", "Winfrey" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 243,
                columns: new[] { "email", "first_name" },
                values: new object[] { "donald.winslet@something.com", "Donald" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 244,
                columns: new[] { "email", "last_name" },
                values: new object[] { "elvis.windsor@nasa.org.us", "Windsor" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 245,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "jimi.obama@gov.gr", "Jimi", "Obama" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 246,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "donald.winfrey@google.com", "Donald", "Winfrey" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 247,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "elvis.windsor@bbc.co.uk", "Elvis", "Windsor" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 248,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "audrey.hendrix@bbc.co.uk", "Audrey", "Hendrix" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 249,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "barack.winslet@tesla.com", "Barack", "Winslet" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 71, 2, "An army of Rose Smelling Buildings" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "author_id", "title" },
                values: new object[] { 64, "Several Purple Leopards" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 204, 9, "Two Rose Smelling Houses" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 156, 6, "A bunch of Rose Smelling Flowers" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 170, 4, "The Purple Cars" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 135, 1, "A bunch of Large Flowers" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 47, 10, "A herd of Large Planets" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 239, 7, "A herd of Purple Houses" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 15, 6, "A herd of Transparent Planets" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 146, 6, "An army of Green Leopards" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 203, 5, "A herd of Green Cars" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "author_id", "title" },
                values: new object[] { 226, "An army of Rose Smelling Leopards" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 140, 6, "The Green Buildings" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 66, 9, "A bunch of Green Leopards" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 48, 10, "A herd of Orange Flowers" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "author_id", "title" },
                values: new object[] { 58, "Fifteen Orange Leopards" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 61, 6, "Several Rose Smelling Cars" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 239, 10, "An army of Purple Houses" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 72, 9, "A bunch of Bitter Flowers" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 177, 1, "A bunch of Bitter Planets" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 195, 6, "An army of Large Buildings" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 169, 1, "An army of Transparent Houses" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 124, 1, "Several Bitter Leopards" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 124, 5, "Several Microscopic Leopards" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 20, 5, "The Rose Smelling Flowers" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 159, 4, "Two Transparent Leopards" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 187, 4, "Several Large Houses" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 188, 8, "A bunch of Green Cars" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 48, 1, "An army of Large Planets" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 101, 5, "Two Large Planets" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 144, 10, "A herd of Green Cars" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 55, 1, "A herd of Purple Buildings" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 33,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 78, 10, "The Large Leopards" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 34,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 188, 8, "Two Orange Flowers" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 35,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 178, 6, "The Microscopic Leopards" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 36,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 109, 3, "Two Rose Smelling Planets" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 37,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 158, 9, "Two Purple Houses" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 38,
                columns: new[] { "author_id", "title" },
                values: new object[] { 100, "An army of Bitter Flowers" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 39,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 140, 6, "Several Green Houses" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 40,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 196, 7, "Several Green Leopards" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 41,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 242, 7, "An army of Large Cars" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 42,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 190, 7, "A herd of Large Leopards" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 43,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 134, 7, "A herd of Orange Houses" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 44,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 100, 5, "An army of Purple Leopards" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 45,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 132, 7, "A bunch of Purple Planets" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 46,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 90, 8, "A bunch of Rose Smelling Houses" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 47,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 125, 9, "A bunch of Purple Planets" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 48,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 80, 4, "Several Large Planets" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 49,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 79, 1, "The Bitter Buildings" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 50,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 173, 8, "Fifteen Large Planets" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 51,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 244, 3, "Fifteen Green Cars" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 52,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 184, 2, "A herd of Purple Flowers" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 53,
                columns: new[] { "author_id", "title" },
                values: new object[] { 107, "Several Orange Houses" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 54,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 64, 5, "A bunch of Bitter Planets" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 55,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 107, 6, "Two Rose Smelling Cars" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 56,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 169, 4, "A herd of Transparent Flowers" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 57,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 226, 3, "An army of Rose Smelling Leopards" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 58,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 225, 1, "The Rose Smelling Leopards" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 59,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 187, 1, "Two Bitter Leopards" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 60,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 98, 10, "A herd of Bitter Leopards" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 61,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 88, 10, "The Bitter Leopards" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 62,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 197, 10, "The Microscopic Houses" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 63,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 20, 2, "A herd of Transparent Leopards" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 64,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 8, 10, "Two Orange Planets" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 65,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 94, 10, "Fifteen Rose Smelling Cars" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 66,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 157, 4, "Fifteen Microscopic Cars" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 67,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 31, 4, "An army of Rose Smelling Flowers" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 68,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 228, 6, "A herd of Rose Smelling Houses" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 69,
                columns: new[] { "author_id", "title" },
                values: new object[] { 128, "Fifteen Transparent Cars" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 70,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 39, 1, "A bunch of Microscopic Leopards" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 71,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 31, 8, "A bunch of Microscopic Cars" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 72,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 65, 8, "The Orange Flowers" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 73,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 57, 7, "Fifteen Rose Smelling Cars" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 74,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 210, 9, "A bunch of Transparent Leopards" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 75,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 136, 9, "A herd of Green Houses" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 76,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 245, 8, "The Orange Planets" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 77,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 69, 6, "An army of Green Flowers" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 78,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 77, 9, "An army of Large Cars" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 79,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 71, 3, "A bunch of Orange Leopards" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 80,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 141, 5, "Several Rose Smelling Houses" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 81,
                columns: new[] { "author_id", "title" },
                values: new object[] { 37, "The Large Flowers" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 82,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 209, 2, "Fifteen Green Leopards" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 83,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 198, 8, "Fifteen Rose Smelling Planets" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 84,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 145, 2, "Fifteen Rose Smelling Flowers" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 85,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 171, 5, "A bunch of Orange Buildings" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 86,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 102, 6, "The Large Flowers" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 87,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 59, 2, "Fifteen Transparent Planets" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 88,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 89, 3, "The Microscopic Buildings" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 89,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 81, 5, "Fifteen Rose Smelling Flowers" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 90,
                columns: new[] { "author_id", "title" },
                values: new object[] { 78, "A bunch of Bitter Leopards" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 91,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 65, 7, "Fifteen Transparent Leopards" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 92,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 87, 1, "Two Green Houses" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 93,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 28, 9, "An army of Orange Flowers" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 94,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 52, 7, "A bunch of Transparent Leopards" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 95,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 85, 5, "Several Orange Buildings" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 96,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 15, 6, "Several Microscopic Houses" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 97,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 228, 4, "A herd of Orange Buildings" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 98,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 133, 9, "Two Bitter Houses" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 99,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 79, 8, "Fifteen Purple Planets" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 100,
                columns: new[] { "author_id", "title" },
                values: new object[] { 54, "Fifteen Microscopic Cars" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 101,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 85, 5, "Two Green Flowers" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 102,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 215, 10, "A bunch of Large Planets" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 103,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 194, 8, "Fifteen Large Buildings" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 104,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 158, 3, "Fifteen Transparent Cars" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 105,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 166, 8, "Two Bitter Planets" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 106,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 184, 10, "An army of Microscopic Leopards" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 107,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 247, 9, "A bunch of Transparent Planets" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 108,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 93, 10, "A herd of Green Planets" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 109,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 58, 7, "A herd of Bitter Buildings" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 110,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 243, 4, "Fifteen Transparent Planets" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 111,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 209, 3, "Fifteen Microscopic Flowers" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 112,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 21, 3, "Two Bitter Cars" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 113,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 88, 4, "The Rose Smelling Houses" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 114,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 56, 1, "A herd of Green Planets" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 115,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 148, 5, "An army of Orange Planets" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 116,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 158, 5, "A bunch of Green Planets" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 117,
                columns: new[] { "author_id", "title" },
                values: new object[] { 175, "Fifteen Orange Leopards" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 118,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 211, 6, "Two Bitter Flowers" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 119,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 149, 8, "Several Green Planets" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 120,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 45, 10, "An army of Large Cars" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 121,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 201, 10, "An army of Purple Cars" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 122,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 145, 9, "The Bitter Houses" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 123,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 86, 10, "The Microscopic Planets" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 124,
                columns: new[] { "author_id", "title" },
                values: new object[] { 182, "Two Bitter Leopards" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 125,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 204, 4, "Two Rose Smelling Flowers" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 126,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 176, 8, "An army of Purple Cars" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 127,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 73, 10, "Fifteen Rose Smelling Cars" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 128,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 161, 6, "A bunch of Green Leopards" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 129,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 159, 6, "A bunch of Microscopic Flowers" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 130,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 30, 3, "The Transparent Cars" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 131,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 150, 8, "A herd of Purple Leopards" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 132,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 21, 4, "The Orange Cars" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 133,
                columns: new[] { "author_id", "title" },
                values: new object[] { 242, "An army of Orange Cars" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 134,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 119, 8, "Fifteen Bitter Planets" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 135,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 22, 8, "Two Rose Smelling Flowers" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 136,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 79, 5, "A herd of Purple Leopards" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 137,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 83, 5, "Two Rose Smelling Houses" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 138,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 96, 8, "A herd of Microscopic Leopards" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 139,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 149, 8, "Two Green Buildings" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 140,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 180, 9, "A herd of Orange Cars" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 141,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 207, 6, "Fifteen Microscopic Leopards" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 142,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 28, 8, "Fifteen Bitter Planets" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 143,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 81, 8, "A bunch of Bitter Buildings" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 144,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 92, 2, "An army of Orange Houses" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 145,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 247, 10, "Fifteen Large Flowers" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 146,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 26, 3, "Several Transparent Flowers" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 147,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 114, 3, "A herd of Bitter Buildings" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 148,
                columns: new[] { "author_id", "title" },
                values: new object[] { 69, "A herd of Rose Smelling Planets" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 149,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 4, 10, "Several Green Flowers" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 150,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 174, 2, "The Green Flowers" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 151,
                columns: new[] { "author_id", "title" },
                values: new object[] { 174, "The Bitter Flowers" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 152,
                columns: new[] { "author_id", "title" },
                values: new object[] { 227, "Several Large Leopards" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 153,
                columns: new[] { "author_id", "title" },
                values: new object[] { 120, "Several Orange Planets" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 154,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 221, 3, "An army of Bitter Planets" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 155,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 243, 7, "A herd of Large Buildings" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 156,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 190, 4, "The Microscopic Houses" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 157,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 184, 4, "Two Bitter Houses" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 158,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 69, 5, "A herd of Purple Buildings" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 159,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 101, 8, "A bunch of Microscopic Houses" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 160,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 32, 4, "Several Microscopic Flowers" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 161,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 18, 3, "A herd of Purple Leopards" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 162,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 120, 8, "The Orange Houses" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 163,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 68, 8, "The Transparent Flowers" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 164,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 184, 7, "A bunch of Green Planets" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 165,
                columns: new[] { "author_id", "title" },
                values: new object[] { 130, "Two Green Cars" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 166,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 201, 4, "Several Bitter Planets" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 167,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 137, 6, "A bunch of Large Cars" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 168,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 18, 3, "The Transparent Houses" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 169,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 39, 7, "Several Green Planets" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 170,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 26, 3, "An army of Bitter Leopards" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 171,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 77, 10, "Several Transparent Planets" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 172,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 67, 3, "An army of Purple Buildings" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 173,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 25, 9, "An army of Green Houses" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 174,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 112, 9, "A bunch of Purple Flowers" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 175,
                columns: new[] { "author_id", "title" },
                values: new object[] { 107, "Several Transparent Planets" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 176,
                columns: new[] { "author_id", "title" },
                values: new object[] { 134, "An army of Orange Buildings" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 177,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 73, 3, "The Rose Smelling Planets" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 178,
                columns: new[] { "author_id", "title" },
                values: new object[] { 88, "Fifteen Microscopic Buildings" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 179,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 177, 1, "Several Microscopic Buildings" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 180,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 100, 4, "Two Orange Houses" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 181,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 152, 8, "The Bitter Buildings" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 182,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 199, 1, "A bunch of Bitter Houses" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 183,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 192, 10, "Several Large Planets" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 184,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 117, 4, "Fifteen Microscopic Planets" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 185,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 50, 2, "A herd of Rose Smelling Cars" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 186,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 247, 4, "Two Orange Flowers" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 187,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 131, 9, "Two Microscopic Leopards" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 188,
                columns: new[] { "author_id", "title" },
                values: new object[] { 249, "The Microscopic Planets" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 189,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 6, 2, "A bunch of Rose Smelling Cars" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 190,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 169, 4, "Two Microscopic Houses" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 191,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 72, 4, "A bunch of Bitter Planets" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 192,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 90, 3, "The Green Planets" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 193,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 229, 10, "Fifteen Large Leopards" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 194,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 168, 9, "Several Orange Planets" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 195,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 5, 8, "A herd of Microscopic Houses" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 196,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 124, 1, "A bunch of Microscopic Leopards" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 197,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 19, 4, "An army of Microscopic Buildings" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 198,
                columns: new[] { "author_id", "title" },
                values: new object[] { 143, "The Transparent Cars" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 199,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 91, 4, "Two Rose Smelling Cars" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 200,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 28, 5, "A bunch of Large Buildings" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 201,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 190, 7, "An army of Transparent Flowers" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 202,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 115, 10, "The Rose Smelling Flowers" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 203,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 110, 10, "An army of Green Leopards" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 204,
                columns: new[] { "author_id", "title" },
                values: new object[] { 100, "A bunch of Orange Buildings" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 205,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 174, 4, "Two Green Cars" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 206,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 153, 10, "Two Purple Buildings" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 207,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 65, 5, "A bunch of Transparent Leopards" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 208,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 98, 2, "Several Rose Smelling Flowers" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 209,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 244, 2, "An army of Transparent Houses" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 210,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 183, 1, "Fifteen Orange Cars" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 211,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 110, 5, "Several Rose Smelling Planets" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 212,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 32, 5, "A herd of Bitter Flowers" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 213,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 245, 4, "The Purple Flowers" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 214,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 65, 3, "An army of Microscopic Houses" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 215,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 28, 8, "A bunch of Green Leopards" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 216,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 101, 9, "Two Microscopic Leopards" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 217,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 26, 9, "A bunch of Rose Smelling Houses" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 218,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 163, 1, "Several Green Leopards" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 219,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 103, 7, "Two Purple Planets" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 220,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 116, 7, "A herd of Orange Houses" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 221,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 83, 5, "Fifteen Bitter Cars" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 222,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 228, 7, "The Bitter Flowers" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 223,
                columns: new[] { "author_id", "title" },
                values: new object[] { 57, "An army of Transparent Planets" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 224,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 74, 2, "A herd of Bitter Cars" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 225,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 33, 3, "The Bitter Flowers" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 226,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 54, 6, "The Rose Smelling Flowers" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 227,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 142, 7, "Several Bitter Leopards" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 228,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 234, 9, "Several Bitter Flowers" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 229,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 105, 2, "An army of Orange Planets" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 230,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 210, 9, "Several Microscopic Houses" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 231,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 86, 10, "The Rose Smelling Leopards" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 232,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 66, 8, "Fifteen Green Flowers" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 233,
                columns: new[] { "author_id", "title" },
                values: new object[] { 192, "An army of Purple Leopards" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 234,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 246, 10, "An army of Purple Buildings" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 235,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 66, 8, "Two Purple Leopards" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 236,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 165, 4, "The Transparent Houses" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 237,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 10, 6, "The Orange Leopards" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 238,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 154, 5, "Several Microscopic Cars" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 239,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 116, 1, "Fifteen Transparent Houses" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 240,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 6, 3, "Fifteen Large Planets" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 241,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 183, 3, "An army of Purple Houses" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 242,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 248, 7, "Several Orange Leopards" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 243,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 154, 4, "A bunch of Bitter Buildings" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 244,
                columns: new[] { "author_id", "title" },
                values: new object[] { 27, "Fifteen Rose Smelling Flowers" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 245,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 39, 1, "The Green Leopards" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 246,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 115, 1, "Two Bitter Flowers" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 247,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 5, 6, "The Purple Houses" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 248,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 133, 4, "A herd of Purple Flowers" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 249,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 98, 1, "Fifteen Bitter Cars" });

            migrationBuilder.AddForeignKey(
                name: "FK_books_authors_author_id",
                table: "books",
                column: "author_id",
                principalTable: "authors",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_books_publishers_publisher_id",
                table: "books",
                column: "publisher_id",
                principalTable: "publishers",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_books_authors_author_id",
                table: "books");

            migrationBuilder.DropForeignKey(
                name: "FK_books_publishers_publisher_id",
                table: "books");

            migrationBuilder.DropPrimaryKey(
                name: "PK_publishers",
                table: "publishers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_books",
                table: "books");

            migrationBuilder.DropPrimaryKey(
                name: "PK_authors",
                table: "authors");

            migrationBuilder.RenameTable(
                name: "publishers",
                newName: "Publishers");

            migrationBuilder.RenameTable(
                name: "books",
                newName: "Books");

            migrationBuilder.RenameTable(
                name: "authors",
                newName: "Authors");

            migrationBuilder.RenameIndex(
                name: "IX_books_publisher_id",
                table: "Books",
                newName: "IX_Books_publisher_id");

            migrationBuilder.RenameIndex(
                name: "IX_books_author_id",
                table: "Books",
                newName: "IX_Books_author_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Publishers",
                table: "Publishers",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Books",
                table: "Books",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Authors",
                table: "Authors",
                column: "id");

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.jagger@tesla.com", "Kate", "Jagger" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "audrey.winslet@theworld.ca", "Audrey", "Winslet" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "jimi.winslet@gov.ru", "Jimi", "Winslet" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.windsor@bbc.co.uk", "Kate", "Windsor" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.trump@gov.nl", "Kate", "Trump" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "jimi.winslet@gov.ru", "Jimi", "Winslet" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "jimi.hendrix@gov.us", "Jimi", "Hendrix" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "elvis.trump@bbc.co.uk", "Elvis", "Trump" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "email", "last_name" },
                values: new object[] { "barack.presley@bbc.co.uk", "Presley" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.winfrey@gov.us", "Kate", "Winfrey" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "mick.winfrey@tesla.com", "Mick", "Winfrey" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.winslet@bbc.co.uk", "Kate", "Winslet" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "email", "last_name" },
                values: new object[] { "kate.hepburn@something.com", "Hepburn" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "charles.hepburn@gov.nl", "Charles", "Hepburn" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "elvis.hendrix@gov.us", "Elvis", "Hendrix" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "audrey.middleton@tesla.com", "Audrey", "Middleton" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "elvis.presley@theworld.ca", "Elvis", "Presley" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "jimi.jagger@nasa.org.us", "Jimi", "Jagger" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "email", "first_name" },
                values: new object[] { "kate.hendrix@theworld.ca", "Kate" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "donald.winfrey@theworld.ca", "Donald", "Winfrey" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "oprah.presley@gov.us", "Oprah", "Presley" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "email", "first_name" },
                values: new object[] { "donald.winslet@theworld.ca", "Donald" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "audrey.trump@something.com", "Audrey", "Trump" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "donald.presley@bbc.co.uk", "Donald", "Presley" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.middleton@theworld.ca", "Kate", "Middleton" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "email", "last_name" },
                values: new object[] { "mick.middleton@nasa.org.us", "Middleton" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.jagger@tesla.com", "Kate", "Jagger" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "email", "last_name" },
                values: new object[] { "kate.trump@gov.us", "Trump" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "elvis.middleton@gov.gr", "Elvis", "Middleton" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "mick.middleton@gov.gr", "Mick", "Middleton" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "audrey.jagger@nasa.org.us", "Audrey", "Jagger" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "donald.windsor@tesla.com", "Donald", "Windsor" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 33,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.winfrey@something.com", "Kate", "Winfrey" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 34,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "oprah.hepburn@theworld.ca", "Oprah", "Hepburn" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 35,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "audrey.hepburn@gov.gr", "Audrey", "Hepburn" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 36,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "oprah.winslet@something.com", "Oprah", "Winslet" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 37,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.obama@something.com", "Kate", "Obama" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 38,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.jagger@google.com", "Kate", "Jagger" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 39,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "barack.jagger@gov.ru", "Barack", "Jagger" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 40,
                columns: new[] { "email", "last_name" },
                values: new object[] { "elvis.presley@gov.us", "Presley" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 41,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.presley@gov.us", "Kate", "Presley" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 42,
                columns: new[] { "email", "first_name" },
                values: new object[] { "elvis.winslet@tesla.com", "Elvis" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 43,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "mick.middleton@nasa.org.us", "Mick", "Middleton" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 44,
                columns: new[] { "email", "last_name" },
                values: new object[] { "barack.hepburn@tesla.com", "Hepburn" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 45,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "audrey.middleton@tesla.com", "Audrey", "Middleton" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 46,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "mick.hepburn@theworld.ca", "Mick", "Hepburn" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 47,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "charles.winfrey@nasa.org.us", "Charles", "Winfrey" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 48,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "barack.obama@theworld.ca", "Barack", "Obama" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 49,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "jimi.winfrey@bbc.co.uk", "Jimi", "Winfrey" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 50,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "donald.hepburn@gov.nl", "Donald", "Hepburn" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 51,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "barack.obama@tesla.com", "Barack", "Obama" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 52,
                columns: new[] { "email", "first_name" },
                values: new object[] { "barack.trump@bbc.co.uk", "Barack" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 53,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "audrey.hepburn@gov.us", "Audrey", "Hepburn" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 54,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.presley@gov.gr", "Kate", "Presley" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 55,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.winfrey@bbc.co.uk", "Kate", "Winfrey" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 56,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "oprah.hendrix@bbc.co.uk", "Oprah", "Hendrix" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 57,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.winslet@gov.us", "Kate", "Winslet" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 58,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "oprah.trump@theworld.ca", "Oprah", "Trump" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 59,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.jagger@gov.us", "Kate", "Jagger" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 60,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.hendrix@bbc.co.uk", "Kate", "Hendrix" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 61,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "barack.presley@tesla.com", "Barack", "Presley" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 62,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "donald.obama@gov.gr", "Donald", "Obama" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 63,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "charles.winfrey@gov.gr", "Charles", "Winfrey" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 64,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "mick.hendrix@gov.nl", "Mick", "Hendrix" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 65,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "barack.obama@gov.ru", "Barack", "Obama" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 66,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "charles.winfrey@nasa.org.us", "Charles", "Winfrey" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 67,
                columns: new[] { "email", "first_name" },
                values: new object[] { "kate.presley@gov.nl", "Kate" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 68,
                columns: new[] { "email", "first_name" },
                values: new object[] { "audrey.obama@something.com", "Audrey" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 69,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "oprah.obama@something.com", "Oprah", "Obama" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 70,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "barack.obama@tesla.com", "Barack", "Obama" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 71,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "elvis.windsor@gov.us", "Elvis", "Windsor" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 72,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "donald.hepburn@something.com", "Donald", "Hepburn" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 73,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.winfrey@theworld.ca", "Kate", "Winfrey" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 74,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "mick.winfrey@bbc.co.uk", "Mick", "Winfrey" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 75,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "audrey.trump@google.com", "Audrey", "Trump" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 76,
                columns: new[] { "email", "last_name" },
                values: new object[] { "charles.hepburn@theworld.ca", "Hepburn" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 77,
                columns: new[] { "email", "last_name" },
                values: new object[] { "jimi.winslet@gov.us", "Winslet" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 78,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "elvis.hendrix@something.com", "Elvis", "Hendrix" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 79,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "mick.presley@gov.nl", "Mick", "Presley" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 80,
                columns: new[] { "email", "first_name" },
                values: new object[] { "kate.windsor@gov.nl", "Kate" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 81,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "donald.winfrey@gov.gr", "Donald", "Winfrey" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 82,
                columns: new[] { "email", "first_name" },
                values: new object[] { "jimi.presley@nasa.org.us", "Jimi" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 83,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "audrey.middleton@nasa.org.us", "Audrey", "Middleton" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 84,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "elvis.middleton@gov.gr", "Elvis", "Middleton" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 85,
                columns: new[] { "email", "last_name" },
                values: new object[] { "kate.obama@nasa.org.us", "Obama" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 86,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "jimi.jagger@nasa.org.us", "Jimi", "Jagger" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 87,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "elvis.middleton@gov.us", "Elvis", "Middleton" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 88,
                columns: new[] { "email", "last_name" },
                values: new object[] { "kate.middleton@bbc.co.uk", "Middleton" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 89,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "audrey.windsor@gov.us", "Audrey", "Windsor" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 90,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "jimi.winfrey@theworld.ca", "Jimi", "Winfrey" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 91,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "elvis.trump@google.com", "Elvis", "Trump" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 92,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "donald.hepburn@gov.ru", "Donald", "Hepburn" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 93,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "charles.jagger@google.com", "Charles", "Jagger" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 94,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "barack.trump@something.com", "Barack", "Trump" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 95,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "barack.hendrix@google.com", "Barack", "Hendrix" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 96,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.trump@something.com", "Kate", "Trump" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 97,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "jimi.hendrix@gov.us", "Jimi", "Hendrix" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 98,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.obama@something.com", "Kate", "Obama" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 99,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.presley@gov.gr", "Kate", "Presley" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 100,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "donald.obama@gov.nl", "Donald", "Obama" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 101,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "charles.middleton@google.com", "Charles", "Middleton" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 102,
                column: "email",
                value: "mick.trump@something.com");

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 103,
                columns: new[] { "email", "first_name" },
                values: new object[] { "oprah.winslet@google.com", "Oprah" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 104,
                columns: new[] { "email", "first_name" },
                values: new object[] { "mick.jagger@google.com", "Mick" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 105,
                columns: new[] { "email", "last_name" },
                values: new object[] { "elvis.hendrix@tesla.com", "Hendrix" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 106,
                columns: new[] { "email", "last_name" },
                values: new object[] { "barack.presley@gov.gr", "Presley" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 107,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "barack.obama@something.com", "Barack", "Obama" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 108,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "oprah.hendrix@google.com", "Oprah", "Hendrix" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 109,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "donald.winslet@gov.ru", "Donald", "Winslet" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 110,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "charles.windsor@gov.gr", "Charles", "Windsor" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 111,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "barack.trump@nasa.org.us", "Barack", "Trump" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 112,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "mick.middleton@bbc.co.uk", "Mick", "Middleton" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 113,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "oprah.winslet@gov.gr", "Oprah", "Winslet" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 114,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "jimi.windsor@gov.ru", "Jimi", "Windsor" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 115,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "jimi.hepburn@gov.gr", "Jimi", "Hepburn" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 116,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "mick.winslet@gov.ru", "Mick", "Winslet" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 117,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "elvis.jagger@gov.gr", "Elvis", "Jagger" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 118,
                columns: new[] { "email", "first_name" },
                values: new object[] { "elvis.obama@nasa.org.us", "Elvis" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 119,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "barack.hepburn@gov.ru", "Barack", "Hepburn" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 120,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "audrey.middleton@gov.gr", "Audrey", "Middleton" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 121,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "oprah.windsor@bbc.co.uk", "Oprah", "Windsor" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 122,
                columns: new[] { "email", "first_name" },
                values: new object[] { "kate.hendrix@gov.nl", "Kate" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 123,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "charles.obama@nasa.org.us", "Charles", "Obama" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 124,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "charles.jagger@google.com", "Charles", "Jagger" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 125,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.winslet@something.com", "Kate", "Winslet" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 126,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.middleton@bbc.co.uk", "Kate", "Middleton" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 127,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "charles.middleton@gov.ru", "Charles", "Middleton" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 128,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "charles.winslet@gov.gr", "Charles", "Winslet" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 129,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "jimi.middleton@bbc.co.uk", "Jimi", "Middleton" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 130,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "mick.middleton@nasa.org.us", "Mick", "Middleton" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 131,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "donald.presley@google.com", "Donald", "Presley" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 132,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "donald.windsor@bbc.co.uk", "Donald", "Windsor" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 133,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "audrey.obama@tesla.com", "Audrey", "Obama" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 134,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "audrey.presley@theworld.ca", "Audrey", "Presley" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 135,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "elvis.hepburn@theworld.ca", "Elvis", "Hepburn" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 136,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "charles.winfrey@gov.nl", "Charles", "Winfrey" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 137,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "barack.jagger@gov.nl", "Barack", "Jagger" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 138,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "charles.windsor@bbc.co.uk", "Charles", "Windsor" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 139,
                columns: new[] { "email", "last_name" },
                values: new object[] { "charles.windsor@tesla.com", "Windsor" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 140,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "charles.presley@gov.us", "Charles", "Presley" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 141,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "audrey.hepburn@nasa.org.us", "Audrey", "Hepburn" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 142,
                columns: new[] { "email", "last_name" },
                values: new object[] { "mick.hepburn@something.com", "Hepburn" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 143,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "mick.winfrey@gov.us", "Mick", "Winfrey" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 144,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "audrey.hepburn@theworld.ca", "Audrey", "Hepburn" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 145,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.trump@gov.ru", "Kate", "Trump" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 146,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "donald.hepburn@gov.gr", "Donald", "Hepburn" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 147,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "donald.hepburn@theworld.ca", "Donald", "Hepburn" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 148,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "elvis.jagger@gov.gr", "Elvis", "Jagger" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 149,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "jimi.hendrix@gov.gr", "Jimi", "Hendrix" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 150,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "charles.presley@gov.gr", "Charles", "Presley" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 151,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "elvis.winfrey@gov.us", "Elvis", "Winfrey" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 152,
                columns: new[] { "email", "last_name" },
                values: new object[] { "mick.winfrey@gov.nl", "Winfrey" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 153,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.obama@google.com", "Kate", "Obama" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 154,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "mick.hendrix@something.com", "Mick", "Hendrix" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 155,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.middleton@theworld.ca", "Kate", "Middleton" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 156,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.hendrix@gov.gr", "Kate", "Hendrix" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 157,
                columns: new[] { "email", "last_name" },
                values: new object[] { "donald.windsor@google.com", "Windsor" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 158,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.obama@nasa.org.us", "Kate", "Obama" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 159,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "audrey.obama@nasa.org.us", "Audrey", "Obama" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 160,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "charles.winslet@nasa.org.us", "Charles", "Winslet" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 161,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "donald.hendrix@gov.gr", "Donald", "Hendrix" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 162,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.hendrix@gov.us", "Kate", "Hendrix" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 163,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "mick.obama@bbc.co.uk", "Mick", "Obama" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 164,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "elvis.jagger@google.com", "Elvis", "Jagger" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 165,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "mick.presley@something.com", "Mick", "Presley" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 166,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "charles.winslet@gov.nl", "Charles", "Winslet" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 167,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "elvis.trump@gov.nl", "Elvis", "Trump" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 168,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "charles.winfrey@gov.gr", "Charles", "Winfrey" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 169,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "charles.winfrey@google.com", "Charles", "Winfrey" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 170,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "mick.trump@gov.us", "Mick", "Trump" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 171,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "jimi.winfrey@gov.nl", "Jimi", "Winfrey" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 172,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "barack.obama@gov.nl", "Barack", "Obama" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 173,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "jimi.presley@google.com", "Jimi", "Presley" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 174,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "mick.winfrey@nasa.org.us", "Mick", "Winfrey" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 175,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "oprah.obama@theworld.ca", "Oprah", "Obama" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 176,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "charles.obama@tesla.com", "Charles", "Obama" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 177,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "jimi.presley@bbc.co.uk", "Jimi", "Presley" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 178,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "oprah.jagger@nasa.org.us", "Oprah", "Jagger" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 179,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "jimi.windsor@nasa.org.us", "Jimi", "Windsor" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 180,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "jimi.presley@gov.ru", "Jimi", "Presley" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 181,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "mick.jagger@gov.us", "Mick", "Jagger" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 182,
                columns: new[] { "email", "last_name" },
                values: new object[] { "audrey.winslet@gov.gr", "Winslet" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 183,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "elvis.windsor@something.com", "Elvis", "Windsor" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 184,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "audrey.obama@bbc.co.uk", "Audrey", "Obama" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 185,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "oprah.presley@gov.gr", "Oprah", "Presley" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 186,
                columns: new[] { "email", "last_name" },
                values: new object[] { "oprah.hepburn@tesla.com", "Hepburn" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 187,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "donald.presley@gov.gr", "Donald", "Presley" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 188,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "barack.obama@bbc.co.uk", "Barack", "Obama" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 189,
                columns: new[] { "email", "last_name" },
                values: new object[] { "oprah.obama@gov.ru", "Obama" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 190,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "elvis.jagger@google.com", "Elvis", "Jagger" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 191,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.jagger@gov.ru", "Kate", "Jagger" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 192,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "oprah.hepburn@something.com", "Oprah", "Hepburn" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 193,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "mick.middleton@theworld.ca", "Mick", "Middleton" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 194,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "barack.presley@nasa.org.us", "Barack", "Presley" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 195,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "charles.middleton@gov.nl", "Charles", "Middleton" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 196,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "jimi.hepburn@something.com", "Jimi", "Hepburn" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 197,
                columns: new[] { "email", "last_name" },
                values: new object[] { "oprah.trump@gov.us", "Trump" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 198,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "elvis.middleton@gov.nl", "Elvis", "Middleton" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 199,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.winslet@bbc.co.uk", "Kate", "Winslet" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 200,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.winfrey@nasa.org.us", "Kate", "Winfrey" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 201,
                columns: new[] { "email", "last_name" },
                values: new object[] { "audrey.winfrey@bbc.co.uk", "Winfrey" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 202,
                columns: new[] { "email", "last_name" },
                values: new object[] { "kate.winslet@gov.nl", "Winslet" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 203,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "charles.trump@gov.gr", "Charles", "Trump" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 204,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.jagger@something.com", "Kate", "Jagger" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 205,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "barack.windsor@something.com", "Barack", "Windsor" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 206,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "barack.winfrey@gov.us", "Barack", "Winfrey" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 207,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "audrey.winfrey@bbc.co.uk", "Audrey", "Winfrey" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 208,
                columns: new[] { "email", "first_name" },
                values: new object[] { "kate.obama@something.com", "Kate" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 209,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "mick.obama@something.com", "Mick", "Obama" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 210,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "audrey.winslet@gov.gr", "Audrey", "Winslet" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 211,
                columns: new[] { "email", "last_name" },
                values: new object[] { "charles.hepburn@gov.gr", "Hepburn" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 212,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "audrey.winslet@gov.us", "Audrey", "Winslet" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 213,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "oprah.presley@gov.us", "Oprah", "Presley" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 214,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "jimi.winfrey@google.com", "Jimi", "Winfrey" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 215,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "charles.obama@gov.nl", "Charles", "Obama" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 216,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.hepburn@tesla.com", "Kate", "Hepburn" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 217,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.obama@gov.ru", "Kate", "Obama" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 218,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "audrey.windsor@theworld.ca", "Audrey", "Windsor" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 219,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "charles.windsor@theworld.ca", "Charles", "Windsor" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 220,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "mick.middleton@gov.us", "Mick", "Middleton" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 221,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "audrey.obama@bbc.co.uk", "Audrey", "Obama" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 222,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "oprah.trump@gov.gr", "Oprah", "Trump" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 223,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "oprah.presley@something.com", "Oprah", "Presley" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 224,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "audrey.winslet@gov.us", "Audrey", "Winslet" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 225,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.hepburn@gov.us", "Kate", "Hepburn" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 226,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "charles.winfrey@gov.nl", "Charles", "Winfrey" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 227,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "barack.obama@tesla.com", "Barack", "Obama" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 228,
                columns: new[] { "email", "last_name" },
                values: new object[] { "barack.hendrix@bbc.co.uk", "Hendrix" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 229,
                columns: new[] { "email", "last_name" },
                values: new object[] { "mick.winslet@gov.us", "Winslet" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 230,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "charles.hendrix@tesla.com", "Charles", "Hendrix" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 231,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "mick.winfrey@gov.gr", "Mick", "Winfrey" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 232,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.hepburn@gov.us", "Kate", "Hepburn" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 233,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "audrey.trump@nasa.org.us", "Audrey", "Trump" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 234,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "mick.winslet@gov.gr", "Mick", "Winslet" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 235,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "jimi.winslet@nasa.org.us", "Jimi", "Winslet" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 236,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "audrey.winfrey@gov.us", "Audrey", "Winfrey" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 237,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "audrey.hendrix@bbc.co.uk", "Audrey", "Hendrix" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 238,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "elvis.winfrey@gov.gr", "Elvis", "Winfrey" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 239,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "mick.hendrix@something.com", "Mick", "Hendrix" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 240,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.trump@tesla.com", "Kate", "Trump" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 241,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "barack.windsor@gov.gr", "Barack", "Windsor" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 242,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "mick.obama@theworld.ca", "Mick", "Obama" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 243,
                columns: new[] { "email", "first_name" },
                values: new object[] { "jimi.winslet@gov.gr", "Jimi" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 244,
                columns: new[] { "email", "last_name" },
                values: new object[] { "elvis.trump@something.com", "Trump" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 245,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "barack.windsor@gov.us", "Barack", "Windsor" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 246,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.presley@gov.nl", "Kate", "Presley" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 247,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "oprah.presley@gov.ru", "Oprah", "Presley" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 248,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "barack.trump@gov.gr", "Barack", "Trump" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 249,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "oprah.trump@bbc.co.uk", "Oprah", "Trump" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 125, 3, "An army of Microscopic Houses" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "author_id", "title" },
                values: new object[] { 6, "A herd of Microscopic Leopards" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 245, 7, "Several Purple Houses" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 221, 1, "Two Orange Leopards" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 49, 8, "A bunch of Bitter Houses" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 196, 7, "Fifteen Transparent Flowers" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 109, 2, "A herd of Rose Smelling Flowers" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 100, 2, "Fifteen Green Planets" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 105, 4, "A herd of Green Flowers" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 132, 5, "Fifteen Rose Smelling Cars" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 225, 9, "A herd of Purple Flowers" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "author_id", "title" },
                values: new object[] { 144, "A bunch of Large Flowers" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 50, 8, "A herd of Bitter Buildings" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 31, 6, "A bunch of Transparent Buildings" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 201, 2, "Two Bitter Leopards" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "author_id", "title" },
                values: new object[] { 248, "A herd of Bitter Leopards" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 164, 1, "Several Large Planets" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 213, 3, "The Large Cars" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 144, 8, "The Orange Flowers" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 183, 2, "The Purple Buildings" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 142, 3, "An army of Bitter Flowers" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 132, 4, "Two Large Planets" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 167, 4, "Two Purple Flowers" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 200, 2, "The Rose Smelling Cars" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 7, 3, "A herd of Large Buildings" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 163, 8, "Fifteen Microscopic Planets" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 127, 10, "Two Green Planets" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 32, 5, "An army of Bitter Planets" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 239, 7, "A herd of Rose Smelling Houses" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 4, 2, "Two Rose Smelling Buildings" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 110, 3, "The Large Cars" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 145, 8, "The Microscopic Leopards" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 33,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 21, 4, "An army of Bitter Cars" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 34,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 10, 7, "Fifteen Rose Smelling Planets" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 35,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 189, 7, "A bunch of Rose Smelling Buildings" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 36,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 72, 5, "An army of Transparent Flowers" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 37,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 11, 1, "The Transparent Flowers" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 38,
                columns: new[] { "author_id", "title" },
                values: new object[] { 78, "An army of Green Flowers" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 39,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 243, 8, "The Microscopic Planets" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 40,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 24, 9, "Fifteen Bitter Buildings" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 41,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 82, 4, "Several Bitter Houses" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 42,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 54, 4, "Fifteen Large Planets" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 43,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 57, 2, "Fifteen Large Planets" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 44,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 188, 3, "Fifteen Large Cars" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 45,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 213, 1, "A herd of Microscopic Planets" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 46,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 5, 5, "Fifteen Microscopic Planets" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 47,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 54, 1, "Fifteen Orange Buildings" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 48,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 100, 6, "Two Rose Smelling Houses" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 49,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 51, 8, "A herd of Orange Leopards" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 50,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 137, 9, "A bunch of Transparent Flowers" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 51,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 77, 10, "A bunch of Rose Smelling Flowers" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 52,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 68, 10, "The Transparent Buildings" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 53,
                columns: new[] { "author_id", "title" },
                values: new object[] { 88, "A herd of Microscopic Cars" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 54,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 162, 3, "Fifteen Purple Cars" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 55,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 134, 10, "An army of Orange Planets" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 56,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 195, 8, "The Microscopic Buildings" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 57,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 45, 4, "An army of Green Flowers" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 58,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 112, 4, "A herd of Purple Leopards" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 59,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 149, 10, "Two Bitter Buildings" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 60,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 206, 8, "The Transparent Leopards" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 61,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 249, 5, "The Green Flowers" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 62,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 178, 4, "Two Transparent Planets" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 63,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 48, 9, "Several Rose Smelling Cars" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 64,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 168, 7, "A bunch of Green Planets" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 65,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 2, 1, "A bunch of Large Cars" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 66,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 127, 1, "An army of Orange Cars" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 67,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 59, 8, "Two Purple Leopards" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 68,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 74, 4, "An army of Bitter Cars" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 69,
                columns: new[] { "author_id", "title" },
                values: new object[] { 117, "Fifteen Green Cars" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 70,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 15, 9, "An army of Green Leopards" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 71,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 53, 2, "Fifteen Rose Smelling Flowers" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 72,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 166, 2, "Two Large Flowers" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 73,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 223, 4, "The Rose Smelling Buildings" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 74,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 12, 1, "An army of Rose Smelling Leopards" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 75,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 154, 5, "A bunch of Transparent Buildings" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 76,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 138, 1, "An army of Large Flowers" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 77,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 154, 8, "An army of Microscopic Flowers" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 78,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 237, 2, "Fifteen Transparent Houses" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 79,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 70, 6, "Fifteen Microscopic Planets" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 80,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 97, 2, "A bunch of Transparent Planets" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 81,
                columns: new[] { "author_id", "title" },
                values: new object[] { 47, "Two Green Planets" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 82,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 19, 10, "Fifteen Purple Buildings" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 83,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 23, 1, "Fifteen Purple Buildings" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 84,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 41, 4, "Several Rose Smelling Buildings" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 85,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 243, 2, "Fifteen Transparent Flowers" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 86,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 28, 3, "Fifteen Green Leopards" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 87,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 164, 1, "Several Green Buildings" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 88,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 108, 8, "An army of Large Planets" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 89,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 116, 6, "The Green Cars" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 90,
                columns: new[] { "author_id", "title" },
                values: new object[] { 35, "Fifteen Rose Smelling Planets" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 91,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 107, 4, "Several Transparent Planets" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 92,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 17, 8, "An army of Purple Houses" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 93,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 125, 6, "Two Green Planets" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 94,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 84, 5, "Two Purple Cars" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 95,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 199, 1, "An army of Microscopic Buildings" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 96,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 196, 10, "Several Green Houses" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 97,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 221, 8, "A bunch of Transparent Leopards" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 98,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 98, 4, "Fifteen Bitter Houses" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 99,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 54, 4, "An army of Rose Smelling Flowers" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 100,
                columns: new[] { "author_id", "title" },
                values: new object[] { 118, "An army of Large Cars" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 101,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 56, 2, "A bunch of Rose Smelling Cars" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 102,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 231, 5, "Two Orange Planets" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 103,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 107, 7, "The Rose Smelling Cars" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 104,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 217, 2, "Two Bitter Buildings" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 105,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 229, 10, "The Green Buildings" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 106,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 83, 4, "Fifteen Transparent Leopards" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 107,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 184, 4, "A bunch of Green Leopards" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 108,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 31, 7, "The Green Buildings" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 109,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 120, 6, "Two Orange Leopards" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 110,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 28, 6, "A herd of Rose Smelling Flowers" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 111,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 13, 9, "Several Rose Smelling Flowers" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 112,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 43, 7, "An army of Bitter Cars" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 113,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 23, 9, "A bunch of Green Flowers" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 114,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 132, 5, "Several Large Flowers" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 115,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 28, 7, "A bunch of Large Houses" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 116,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 25, 10, "A bunch of Bitter Buildings" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 117,
                columns: new[] { "author_id", "title" },
                values: new object[] { 17, "The Purple Houses" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 118,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 208, 9, "Several Bitter Leopards" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 119,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 44, 3, "An army of Rose Smelling Cars" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 120,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 89, 9, "Fifteen Bitter Buildings" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 121,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 224, 2, "The Green Leopards" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 122,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 209, 1, "The Transparent Houses" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 123,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 94, 1, "Several Transparent Flowers" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 124,
                columns: new[] { "author_id", "title" },
                values: new object[] { 62, "The Orange Houses" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 125,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 20, 10, "Fifteen Purple Cars" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 126,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 179, 4, "A bunch of Rose Smelling Houses" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 127,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 120, 8, "Two Bitter Cars" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 128,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 181, 4, "Fifteen Microscopic Planets" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 129,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 131, 1, "A herd of Purple Flowers" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 130,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 168, 5, "Several Purple Leopards" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 131,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 98, 5, "Two Purple Houses" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 132,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 129, 10, "A herd of Transparent Planets" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 133,
                columns: new[] { "author_id", "title" },
                values: new object[] { 176, "Several Orange Planets" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 134,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 79, 1, "Several Transparent Leopards" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 135,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 103, 9, "A bunch of Rose Smelling Flowers" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 136,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 41, 4, "An army of Green Flowers" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 137,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 194, 3, "A herd of Green Planets" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 138,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 188, 7, "The Large Flowers" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 139,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 17, 5, "A bunch of Microscopic Flowers" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 140,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 232, 10, "The Bitter Flowers" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 141,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 118, 3, "Two Purple Buildings" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 142,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 156, 2, "The Bitter Flowers" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 143,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 154, 5, "An army of Transparent Houses" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 144,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 127, 9, "An army of Orange Leopards" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 145,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 81, 2, "An army of Green Planets" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 146,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 19, 4, "Two Rose Smelling Planets" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 147,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 136, 10, "A bunch of Orange Buildings" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 148,
                columns: new[] { "author_id", "title" },
                values: new object[] { 103, "Two Purple Planets" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 149,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 157, 5, "Two Transparent Leopards" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 150,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 62, 10, "A herd of Transparent Cars" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 151,
                columns: new[] { "author_id", "title" },
                values: new object[] { 120, "Two Green Planets" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 152,
                columns: new[] { "author_id", "title" },
                values: new object[] { 203, "A herd of Green Houses" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 153,
                columns: new[] { "author_id", "title" },
                values: new object[] { 157, "The Transparent Planets" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 154,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 150, 1, "A bunch of Bitter Houses" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 155,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 219, 2, "A bunch of Rose Smelling Cars" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 156,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 95, 6, "An army of Green Planets" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 157,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 15, 9, "An army of Bitter Buildings" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 158,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 244, 3, "An army of Transparent Buildings" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 159,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 135, 7, "Two Bitter Flowers" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 160,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 102, 6, "An army of Transparent Leopards" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 161,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 2, 5, "The Microscopic Buildings" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 162,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 237, 7, "An army of Microscopic Cars" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 163,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 76, 2, "A bunch of Green Flowers" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 164,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 160, 2, "Fifteen Bitter Planets" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 165,
                columns: new[] { "author_id", "title" },
                values: new object[] { 239, "An army of Purple Houses" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 166,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 232, 10, "Several Transparent Planets" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 167,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 66, 2, "Several Bitter Leopards" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 168,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 96, 5, "A herd of Large Flowers" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 169,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 166, 8, "A bunch of Large Leopards" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 170,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 167, 9, "Two Purple Cars" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 171,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 186, 5, "An army of Microscopic Planets" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 172,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 202, 6, "A bunch of Microscopic Leopards" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 173,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 193, 7, "A bunch of Rose Smelling Houses" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 174,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 110, 8, "Several Purple Leopards" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 175,
                columns: new[] { "author_id", "title" },
                values: new object[] { 116, "A herd of Purple Leopards" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 176,
                columns: new[] { "author_id", "title" },
                values: new object[] { 3, "The Microscopic Cars" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 177,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 84, 6, "A bunch of Orange Flowers" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 178,
                columns: new[] { "author_id", "title" },
                values: new object[] { 134, "Fifteen Rose Smelling Planets" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 179,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 30, 4, "The Green Planets" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 180,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 210, 7, "Two Transparent Planets" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 181,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 41, 5, "Fifteen Large Buildings" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 182,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 223, 3, "Fifteen Green Leopards" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 183,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 211, 8, "A bunch of Orange Houses" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 184,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 94, 8, "The Bitter Planets" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 185,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 100, 8, "An army of Transparent Cars" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 186,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 248, 8, "A herd of Transparent Flowers" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 187,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 139, 6, "Several Large Buildings" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 188,
                columns: new[] { "author_id", "title" },
                values: new object[] { 243, "A bunch of Orange Houses" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 189,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 247, 6, "Several Green Planets" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 190,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 209, 2, "An army of Green Planets" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 191,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 183, 3, "An army of Large Buildings" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 192,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 41, 5, "Several Green Houses" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 193,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 136, 3, "The Rose Smelling Leopards" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 194,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 46, 5, "Fifteen Rose Smelling Planets" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 195,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 168, 2, "Several Purple Leopards" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 196,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 144, 2, "A herd of Transparent Flowers" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 197,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 202, 8, "A herd of Green Buildings" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 198,
                columns: new[] { "author_id", "title" },
                values: new object[] { 61, "A bunch of Large Cars" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 199,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 179, 6, "A bunch of Microscopic Houses" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 200,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 71, 6, "Fifteen Purple Houses" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 201,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 13, 1, "A bunch of Purple Houses" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 202,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 61, 8, "Fifteen Microscopic Flowers" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 203,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 229, 2, "Several Rose Smelling Flowers" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 204,
                columns: new[] { "author_id", "title" },
                values: new object[] { 61, "The Microscopic Leopards" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 205,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 105, 2, "The Green Planets" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 206,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 156, 6, "A bunch of Transparent Cars" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 207,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 97, 3, "An army of Rose Smelling Flowers" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 208,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 84, 10, "The Green Cars" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 209,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 16, 6, "The Rose Smelling Planets" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 210,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 179, 7, "A herd of Rose Smelling Buildings" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 211,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 214, 10, "A herd of Bitter Flowers" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 212,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 220, 9, "Several Rose Smelling Leopards" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 213,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 200, 6, "Two Purple Houses" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 214,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 138, 1, "A bunch of Purple Cars" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 215,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 209, 6, "The Purple Buildings" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 216,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 31, 5, "A bunch of Purple Cars" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 217,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 227, 5, "Several Microscopic Buildings" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 218,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 7, 7, "Several Transparent Leopards" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 219,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 9, 9, "A bunch of Purple Planets" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 220,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 198, 4, "The Microscopic Houses" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 221,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 24, 7, "Several Bitter Leopards" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 222,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 206, 6, "A bunch of Large Leopards" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 223,
                columns: new[] { "author_id", "title" },
                values: new object[] { 17, "An army of Orange Buildings" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 224,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 112, 4, "Fifteen Microscopic Cars" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 225,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 37, 10, "Two Transparent Cars" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 226,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 80, 8, "A bunch of Orange Leopards" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 227,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 136, 2, "A bunch of Microscopic Planets" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 228,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 207, 3, "Two Orange Leopards" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 229,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 21, 1, "A herd of Microscopic Flowers" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 230,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 109, 3, "Two Green Houses" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 231,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 87, 6, "Two Rose Smelling Planets" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 232,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 77, 9, "Several Bitter Buildings" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 233,
                columns: new[] { "author_id", "title" },
                values: new object[] { 80, "A bunch of Green Cars" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 234,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 198, 9, "Two Purple Flowers" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 235,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 24, 7, "Fifteen Transparent Planets" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 236,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 98, 3, "Fifteen Green Houses" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 237,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 26, 4, "Several Large Flowers" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 238,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 47, 7, "Several Orange Buildings" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 239,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 133, 5, "An army of Bitter Flowers" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 240,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 190, 7, "A herd of Purple Houses" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 241,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 9, 4, "An army of Bitter Buildings" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 242,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 62, 4, "A herd of Purple Houses" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 243,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 176, 2, "A herd of Green Planets" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 244,
                columns: new[] { "author_id", "title" },
                values: new object[] { 61, "Two Bitter Houses" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 245,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 10, 4, "An army of Orange Cars" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 246,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 139, 6, "Several Bitter Planets" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 247,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 22, 8, "The Rose Smelling Leopards" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 248,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 187, 6, "A bunch of Purple Houses" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 249,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 109, 10, "An army of Rose Smelling Buildings" });

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Authors_author_id",
                table: "Books",
                column: "author_id",
                principalTable: "Authors",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Publishers_publisher_id",
                table: "Books",
                column: "publisher_id",
                principalTable: "Publishers",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
