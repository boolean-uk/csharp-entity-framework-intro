using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace exercise.webapi.Migrations
{
    /// <inheritdoc />
    public partial class SecondMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_Authors_AuthorId",
                table: "Books");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Books",
                table: "Books");

            migrationBuilder.RenameTable(
                name: "Books",
                newName: "books");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "books",
                newName: "title");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "books",
                newName: "id");

            migrationBuilder.RenameIndex(
                name: "IX_Books_AuthorId",
                table: "books",
                newName: "IX_books_AuthorId");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "Authors",
                newName: "email");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Authors",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "Authors",
                newName: "last_name");

            migrationBuilder.RenameColumn(
                name: "FirstName",
                table: "Authors",
                newName: "first_name");

            migrationBuilder.AddPrimaryKey(
                name: "PK_books",
                table: "books",
                column: "id");

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "oprah.jagger@gov.nl", "Oprah", "Jagger" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "email", "last_name" },
                values: new object[] { "kate.winfrey@gov.gr", "Winfrey" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.obama@something.com", "Kate", "Obama" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "mick.middleton@gov.us", "Mick", "Middleton" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "jimi.winfrey@gov.nl", "Jimi", "Winfrey" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "email", "first_name" },
                values: new object[] { "oprah.windsor@tesla.com", "Oprah" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "elvis.presley@gov.gr", "Elvis", "Presley" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "charles.presley@theworld.ca", "Charles", "Presley" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "oprah.hendrix@theworld.ca", "Oprah", "Hendrix" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "oprah.winfrey@gov.ru", "Oprah", "Winfrey" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.hepburn@something.com", "Kate", "Hepburn" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "oprah.hendrix@gov.nl", "Oprah", "Hendrix" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "donald.hepburn@tesla.com", "Donald", "Hepburn" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "donald.presley@nasa.org.us", "Donald", "Presley" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "email", "last_name" },
                values: new object[] { "barack.hepburn@nasa.org.us", "Hepburn" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "charles.winslet@gov.nl", "Charles", "Winslet" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "barack.jagger@nasa.org.us", "Barack", "Jagger" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.presley@gov.nl", "Kate", "Presley" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "oprah.middleton@nasa.org.us", "Oprah", "Middleton" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "elvis.obama@gov.nl", "Elvis", "Obama" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "oprah.windsor@google.com", "Oprah", "Windsor" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "email", "last_name" },
                values: new object[] { "kate.presley@theworld.ca", "Presley" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "donald.hendrix@gov.nl", "Donald", "Hendrix" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.hendrix@gov.ru", "Kate", "Hendrix" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "mick.middleton@theworld.ca", "Mick", "Middleton" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "audrey.obama@gov.ru", "Audrey", "Obama" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "charles.middleton@gov.ru", "Charles", "Middleton" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "charles.hendrix@gov.gr", "Charles", "Hendrix" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "email", "first_name" },
                values: new object[] { "jimi.windsor@nasa.org.us", "Jimi" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "audrey.winfrey@gov.nl", "Audrey", "Winfrey" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "barack.windsor@gov.gr", "Barack", "Windsor" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "audrey.winfrey@tesla.com", "Audrey", "Winfrey" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 33,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "audrey.middleton@nasa.org.us", "Audrey", "Middleton" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 34,
                columns: new[] { "email", "last_name" },
                values: new object[] { "mick.hendrix@theworld.ca", "Hendrix" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 35,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "mick.winfrey@something.com", "Mick", "Winfrey" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 36,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "oprah.trump@theworld.ca", "Oprah", "Trump" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 37,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.hepburn@gov.gr", "Kate", "Hepburn" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 38,
                column: "email",
                value: "audrey.winfrey@bbc.co.uk");

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 39,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "mick.trump@google.com", "Mick", "Trump" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 40,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "mick.presley@tesla.com", "Mick", "Presley" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 41,
                columns: new[] { "email", "first_name" },
                values: new object[] { "oprah.jagger@nasa.org.us", "Oprah" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 42,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.hepburn@something.com", "Kate", "Hepburn" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 43,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.presley@nasa.org.us", "Kate", "Presley" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 44,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "mick.trump@nasa.org.us", "Mick", "Trump" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 45,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.obama@gov.ru", "Kate", "Obama" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 46,
                columns: new[] { "email", "first_name" },
                values: new object[] { "mick.jagger@gov.us", "Mick" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 47,
                columns: new[] { "email", "last_name" },
                values: new object[] { "donald.winslet@tesla.com", "Winslet" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 48,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "audrey.obama@something.com", "Audrey", "Obama" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 49,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "elvis.middleton@something.com", "Elvis", "Middleton" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 50,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "jimi.obama@nasa.org.us", "Jimi", "Obama" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 51,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "jimi.jagger@tesla.com", "Jimi", "Jagger" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 52,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.presley@gov.us", "Kate", "Presley" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 53,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "elvis.windsor@gov.gr", "Elvis", "Windsor" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 54,
                columns: new[] { "email", "last_name" },
                values: new object[] { "jimi.middleton@nasa.org.us", "Middleton" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 55,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "jimi.winslet@something.com", "Jimi", "Winslet" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 56,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "jimi.middleton@gov.us", "Jimi", "Middleton" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 57,
                columns: new[] { "email", "last_name" },
                values: new object[] { "kate.windsor@something.com", "Windsor" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 58,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.winfrey@gov.gr", "Kate", "Winfrey" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 59,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.hepburn@gov.gr", "Kate", "Hepburn" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 60,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.windsor@theworld.ca", "Kate", "Windsor" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 61,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "mick.obama@tesla.com", "Mick", "Obama" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 62,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.obama@gov.ru", "Kate", "Obama" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 63,
                columns: new[] { "email", "last_name" },
                values: new object[] { "kate.winslet@theworld.ca", "Winslet" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 64,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "audrey.hepburn@gov.us", "Audrey", "Hepburn" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 65,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.hendrix@something.com", "Kate", "Hendrix" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 66,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "oprah.jagger@tesla.com", "Oprah", "Jagger" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 67,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "mick.winfrey@nasa.org.us", "Mick", "Winfrey" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 68,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.hendrix@bbc.co.uk", "Kate", "Hendrix" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 69,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "donald.trump@gov.gr", "Donald", "Trump" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 70,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "barack.winslet@gov.gr", "Barack", "Winslet" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 71,
                columns: new[] { "email", "last_name" },
                values: new object[] { "kate.hendrix@gov.nl", "Hendrix" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 72,
                columns: new[] { "email", "first_name" },
                values: new object[] { "audrey.hepburn@gov.nl", "Audrey" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 73,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.hendrix@something.com", "Kate", "Hendrix" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 74,
                columns: new[] { "email", "last_name" },
                values: new object[] { "elvis.winslet@google.com", "Winslet" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 75,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "jimi.obama@nasa.org.us", "Jimi", "Obama" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 76,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "oprah.trump@tesla.com", "Oprah", "Trump" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 77,
                column: "email",
                value: "charles.windsor@gov.ru");

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 78,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.middleton@bbc.co.uk", "Kate", "Middleton" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 79,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "audrey.hepburn@gov.ru", "Audrey", "Hepburn" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 80,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "elvis.winslet@theworld.ca", "Elvis", "Winslet" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 81,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "oprah.winslet@tesla.com", "Oprah", "Winslet" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 82,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "barack.windsor@gov.nl", "Barack", "Windsor" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 83,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "audrey.winfrey@gov.ru", "Audrey", "Winfrey" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 84,
                columns: new[] { "email", "last_name" },
                values: new object[] { "barack.middleton@tesla.com", "Middleton" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 85,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "audrey.hepburn@gov.nl", "Audrey", "Hepburn" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 86,
                columns: new[] { "email", "first_name" },
                values: new object[] { "charles.winfrey@nasa.org.us", "Charles" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 87,
                columns: new[] { "email", "first_name" },
                values: new object[] { "oprah.winfrey@bbc.co.uk", "Oprah" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 88,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "barack.trump@nasa.org.us", "Barack", "Trump" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 89,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.winslet@bbc.co.uk", "Kate", "Winslet" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 90,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.winslet@gov.gr", "Kate", "Winslet" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 91,
                columns: new[] { "email", "last_name" },
                values: new object[] { "barack.winslet@gov.us", "Winslet" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 92,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "mick.windsor@nasa.org.us", "Mick", "Windsor" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 93,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.windsor@gov.nl", "Kate", "Windsor" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 94,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "donald.windsor@nasa.org.us", "Donald", "Windsor" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 95,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.windsor@bbc.co.uk", "Kate", "Windsor" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 96,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "donald.presley@theworld.ca", "Donald", "Presley" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 97,
                columns: new[] { "email", "last_name" },
                values: new object[] { "kate.middleton@bbc.co.uk", "Middleton" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 98,
                columns: new[] { "email", "last_name" },
                values: new object[] { "jimi.trump@bbc.co.uk", "Trump" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 99,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "elvis.obama@gov.ru", "Elvis", "Obama" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 100,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.jagger@google.com", "Kate", "Jagger" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 101,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.winslet@gov.gr", "Kate", "Winslet" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 102,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "charles.middleton@gov.us", "Charles", "Middleton" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 103,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "charles.winfrey@gov.nl", "Charles", "Winfrey" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 104,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "mick.winslet@gov.us", "Mick", "Winslet" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 105,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "audrey.presley@bbc.co.uk", "Audrey", "Presley" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 106,
                columns: new[] { "email", "last_name" },
                values: new object[] { "kate.hendrix@google.com", "Hendrix" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 107,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "donald.jagger@gov.nl", "Donald", "Jagger" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 108,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "mick.windsor@bbc.co.uk", "Mick", "Windsor" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 109,
                column: "email",
                value: "donald.middleton@nasa.org.us");

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 110,
                columns: new[] { "email", "last_name" },
                values: new object[] { "kate.winfrey@bbc.co.uk", "Winfrey" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 111,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "barack.hendrix@nasa.org.us", "Barack", "Hendrix" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 112,
                columns: new[] { "email", "last_name" },
                values: new object[] { "mick.presley@gov.gr", "Presley" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 113,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "donald.middleton@tesla.com", "Donald", "Middleton" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 114,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "elvis.winfrey@theworld.ca", "Elvis", "Winfrey" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 115,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "jimi.hepburn@gov.nl", "Jimi", "Hepburn" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 116,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "barack.middleton@bbc.co.uk", "Barack", "Middleton" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 117,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "jimi.windsor@something.com", "Jimi", "Windsor" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 118,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "audrey.trump@gov.us", "Audrey", "Trump" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 119,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "mick.winslet@gov.nl", "Mick", "Winslet" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 120,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.obama@gov.ru", "Kate", "Obama" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 121,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "audrey.winslet@gov.nl", "Audrey", "Winslet" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 122,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "donald.winfrey@theworld.ca", "Donald", "Winfrey" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 123,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "charles.hendrix@tesla.com", "Charles", "Hendrix" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 124,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "audrey.winslet@gov.us", "Audrey", "Winslet" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 125,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "barack.obama@gov.ru", "Barack", "Obama" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 126,
                columns: new[] { "email", "last_name" },
                values: new object[] { "kate.presley@gov.gr", "Presley" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 127,
                columns: new[] { "email", "first_name" },
                values: new object[] { "barack.windsor@bbc.co.uk", "Barack" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 128,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.presley@something.com", "Kate", "Presley" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 129,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "mick.jagger@theworld.ca", "Mick", "Jagger" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 130,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "audrey.windsor@something.com", "Audrey", "Windsor" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 131,
                columns: new[] { "email", "last_name" },
                values: new object[] { "audrey.windsor@bbc.co.uk", "Windsor" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 132,
                columns: new[] { "email", "last_name" },
                values: new object[] { "elvis.trump@theworld.ca", "Trump" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 133,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "donald.hendrix@gov.gr", "Donald", "Hendrix" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 134,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "jimi.hendrix@gov.nl", "Jimi", "Hendrix" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 135,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.hepburn@bbc.co.uk", "Kate", "Hepburn" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 136,
                columns: new[] { "email", "first_name" },
                values: new object[] { "elvis.winfrey@nasa.org.us", "Elvis" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 137,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "donald.trump@gov.ru", "Donald", "Trump" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 138,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "donald.windsor@gov.gr", "Donald", "Windsor" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 139,
                columns: new[] { "email", "first_name" },
                values: new object[] { "audrey.presley@something.com", "Audrey" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 140,
                column: "email",
                value: "audrey.hendrix@gov.us");

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 141,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "mick.jagger@gov.us", "Mick", "Jagger" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 142,
                columns: new[] { "email", "first_name" },
                values: new object[] { "jimi.trump@gov.gr", "Jimi" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 143,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.middleton@bbc.co.uk", "Kate", "Middleton" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 144,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.winfrey@something.com", "Kate", "Winfrey" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 145,
                columns: new[] { "email", "last_name" },
                values: new object[] { "kate.middleton@google.com", "Middleton" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 146,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "audrey.winfrey@gov.ru", "Audrey", "Winfrey" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 147,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "barack.obama@gov.nl", "Barack", "Obama" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 148,
                columns: new[] { "email", "first_name" },
                values: new object[] { "elvis.winfrey@tesla.com", "Elvis" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 149,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "audrey.winslet@gov.gr", "Audrey", "Winslet" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 150,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "oprah.presley@tesla.com", "Oprah", "Presley" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 151,
                columns: new[] { "email", "last_name" },
                values: new object[] { "mick.trump@theworld.ca", "Trump" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 152,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "mick.obama@gov.gr", "Mick", "Obama" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 153,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "charles.middleton@nasa.org.us", "Charles", "Middleton" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 154,
                columns: new[] { "email", "first_name" },
                values: new object[] { "mick.hepburn@bbc.co.uk", "Mick" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 155,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "mick.presley@gov.ru", "Mick", "Presley" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 156,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "audrey.windsor@bbc.co.uk", "Audrey", "Windsor" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 157,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "elvis.middleton@gov.us", "Elvis", "Middleton" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 158,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "mick.jagger@theworld.ca", "Mick", "Jagger" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 159,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "donald.jagger@gov.nl", "Donald", "Jagger" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 160,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "oprah.trump@theworld.ca", "Oprah", "Trump" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 161,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "audrey.winfrey@something.com", "Audrey", "Winfrey" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 162,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.jagger@gov.ru", "Kate", "Jagger" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 163,
                columns: new[] { "email", "first_name" },
                values: new object[] { "mick.middleton@tesla.com", "Mick" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 164,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "mick.hendrix@gov.nl", "Mick", "Hendrix" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 165,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "barack.windsor@bbc.co.uk", "Barack", "Windsor" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 166,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "oprah.trump@google.com", "Oprah", "Trump" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 167,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "elvis.winslet@bbc.co.uk", "Elvis", "Winslet" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 168,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "charles.hendrix@nasa.org.us", "Charles", "Hendrix" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 169,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "charles.hepburn@gov.gr", "Charles", "Hepburn" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 170,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "jimi.jagger@nasa.org.us", "Jimi", "Jagger" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 171,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "jimi.presley@tesla.com", "Jimi", "Presley" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 172,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "donald.winfrey@gov.gr", "Donald", "Winfrey" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 173,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "barack.middleton@theworld.ca", "Barack", "Middleton" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 175,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "elvis.winfrey@tesla.com", "Elvis", "Winfrey" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 176,
                columns: new[] { "email", "last_name" },
                values: new object[] { "kate.hendrix@tesla.com", "Hendrix" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 177,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "oprah.winfrey@tesla.com", "Oprah", "Winfrey" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 178,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "donald.jagger@gov.us", "Donald", "Jagger" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 179,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "jimi.trump@nasa.org.us", "Jimi", "Trump" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 180,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "mick.obama@tesla.com", "Mick", "Obama" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 181,
                columns: new[] { "email", "last_name" },
                values: new object[] { "oprah.winslet@bbc.co.uk", "Winslet" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 182,
                columns: new[] { "email", "first_name" },
                values: new object[] { "mick.presley@gov.nl", "Mick" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 183,
                columns: new[] { "email", "first_name" },
                values: new object[] { "charles.winslet@google.com", "Charles" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 184,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "jimi.middleton@gov.gr", "Jimi", "Middleton" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 185,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.middleton@google.com", "Kate", "Middleton" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 186,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "elvis.jagger@tesla.com", "Elvis", "Jagger" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 187,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.middleton@something.com", "Kate", "Middleton" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 188,
                columns: new[] { "email", "first_name" },
                values: new object[] { "oprah.jagger@nasa.org.us", "Oprah" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 189,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "oprah.middleton@something.com", "Oprah", "Middleton" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 190,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "elvis.obama@gov.us", "Elvis", "Obama" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 191,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "audrey.obama@tesla.com", "Audrey", "Obama" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 192,
                columns: new[] { "email", "first_name" },
                values: new object[] { "oprah.hendrix@tesla.com", "Oprah" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 193,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "oprah.trump@google.com", "Oprah", "Trump" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 194,
                columns: new[] { "email", "first_name" },
                values: new object[] { "audrey.middleton@google.com", "Audrey" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 195,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "donald.winslet@gov.nl", "Donald", "Winslet" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 196,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "barack.obama@something.com", "Barack", "Obama" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 197,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "elvis.windsor@gov.us", "Elvis", "Windsor" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 198,
                columns: new[] { "email", "first_name" },
                values: new object[] { "charles.presley@google.com", "Charles" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 199,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.winfrey@google.com", "Kate", "Winfrey" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 200,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "oprah.windsor@gov.nl", "Oprah", "Windsor" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 201,
                columns: new[] { "email", "last_name" },
                values: new object[] { "barack.hendrix@gov.gr", "Hendrix" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 202,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.hendrix@gov.us", "Kate", "Hendrix" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 203,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.hepburn@gov.ru", "Kate", "Hepburn" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 204,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "oprah.hendrix@gov.gr", "Oprah", "Hendrix" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 205,
                columns: new[] { "email", "first_name" },
                values: new object[] { "barack.middleton@nasa.org.us", "Barack" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 206,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "mick.trump@gov.us", "Mick", "Trump" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 207,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "charles.jagger@gov.us", "Charles", "Jagger" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 208,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "oprah.middleton@bbc.co.uk", "Oprah", "Middleton" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 209,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "oprah.hepburn@gov.gr", "Oprah", "Hepburn" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 210,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "jimi.winslet@tesla.com", "Jimi", "Winslet" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 211,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "jimi.middleton@gov.us", "Jimi", "Middleton" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 212,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "charles.windsor@gov.us", "Charles", "Windsor" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 213,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.windsor@gov.ru", "Kate", "Windsor" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 214,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "charles.middleton@bbc.co.uk", "Charles", "Middleton" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 215,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "barack.middleton@gov.gr", "Barack", "Middleton" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 216,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "elvis.presley@gov.nl", "Elvis", "Presley" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 217,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "charles.jagger@gov.ru", "Charles", "Jagger" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 218,
                columns: new[] { "email", "last_name" },
                values: new object[] { "charles.presley@gov.gr", "Presley" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 219,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "mick.hendrix@gov.gr", "Mick", "Hendrix" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 220,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "audrey.hepburn@gov.us", "Audrey", "Hepburn" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 221,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.middleton@gov.us", "Kate", "Middleton" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 222,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "charles.trump@gov.ru", "Charles", "Trump" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 223,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.obama@nasa.org.us", "Kate", "Obama" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 224,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "mick.hendrix@gov.nl", "Mick", "Hendrix" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 225,
                columns: new[] { "email", "last_name" },
                values: new object[] { "elvis.middleton@gov.us", "Middleton" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 226,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "audrey.jagger@tesla.com", "Audrey", "Jagger" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 227,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "mick.windsor@gov.us", "Mick", "Windsor" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 228,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "charles.windsor@gov.us", "Charles", "Windsor" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 229,
                columns: new[] { "email", "last_name" },
                values: new object[] { "jimi.winslet@gov.ru", "Winslet" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 230,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "barack.presley@bbc.co.uk", "Barack", "Presley" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 231,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "audrey.jagger@nasa.org.us", "Audrey", "Jagger" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 232,
                columns: new[] { "email", "last_name" },
                values: new object[] { "kate.obama@gov.ru", "Obama" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 233,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "elvis.hepburn@something.com", "Elvis", "Hepburn" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 234,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "mick.jagger@gov.ru", "Mick", "Jagger" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 235,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "jimi.hepburn@nasa.org.us", "Jimi", "Hepburn" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 236,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "oprah.hepburn@google.com", "Oprah", "Hepburn" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 237,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.trump@gov.ru", "Kate", "Trump" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 238,
                columns: new[] { "email", "last_name" },
                values: new object[] { "mick.middleton@bbc.co.uk", "Middleton" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 239,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "oprah.trump@something.com", "Oprah", "Trump" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 240,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "donald.trump@tesla.com", "Donald", "Trump" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 241,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.winslet@tesla.com", "Kate", "Winslet" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 242,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "jimi.jagger@gov.ru", "Jimi", "Jagger" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 243,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "donald.winslet@gov.ru", "Donald", "Winslet" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 244,
                columns: new[] { "email", "last_name" },
                values: new object[] { "kate.hendrix@bbc.co.uk", "Hendrix" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 245,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "audrey.middleton@theworld.ca", "Audrey", "Middleton" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 246,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "elvis.middleton@google.com", "Elvis", "Middleton" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 247,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "oprah.middleton@gov.gr", "Oprah", "Middleton" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 248,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "charles.windsor@google.com", "Charles", "Windsor" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 249,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "elvis.winfrey@bbc.co.uk", "Elvis", "Winfrey" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "AuthorId", "title" },
                values: new object[] { 51, "An army of Orange Flowers" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "AuthorId", "title" },
                values: new object[] { 100, "Fifteen Purple Planets" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "AuthorId", "title" },
                values: new object[] { 170, "Fifteen Microscopic Flowers" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "AuthorId", "title" },
                values: new object[] { 231, "Several Orange Flowers" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "AuthorId", "title" },
                values: new object[] { 247, "Two Large Cars" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "AuthorId", "title" },
                values: new object[] { 153, "Several Green Houses" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "AuthorId", "title" },
                values: new object[] { 238, "Two Orange Flowers" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "AuthorId", "title" },
                values: new object[] { 233, "Two Orange Buildings" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "AuthorId", "title" },
                values: new object[] { 119, "An army of Rose Smelling Leopards" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "AuthorId", "title" },
                values: new object[] { 125, "An army of Green Buildings" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "AuthorId", "title" },
                values: new object[] { 5, "The Transparent Planets" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "AuthorId", "title" },
                values: new object[] { 202, "An army of Microscopic Cars" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "AuthorId", "title" },
                values: new object[] { 244, "Two Rose Smelling Leopards" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "AuthorId", "title" },
                values: new object[] { 84, "The Purple Planets" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "AuthorId", "title" },
                values: new object[] { 214, "An army of Purple Cars" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "AuthorId", "title" },
                values: new object[] { 74, "The Green Leopards" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "AuthorId", "title" },
                values: new object[] { 101, "A bunch of Green Cars" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "AuthorId", "title" },
                values: new object[] { 62, "An army of Green Houses" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "AuthorId", "title" },
                values: new object[] { 39, "A herd of Rose Smelling Leopards" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "AuthorId", "title" },
                values: new object[] { 6, "A herd of Microscopic Houses" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "AuthorId", "title" },
                values: new object[] { 130, "The Microscopic Cars" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "AuthorId", "title" },
                values: new object[] { 208, "Fifteen Bitter Flowers" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "AuthorId", "title" },
                values: new object[] { 186, "An army of Large Cars" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "AuthorId", "title" },
                values: new object[] { 210, "An army of Rose Smelling Buildings" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "AuthorId", "title" },
                values: new object[] { 206, "Several Orange Buildings" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "AuthorId", "title" },
                values: new object[] { 190, "An army of Transparent Cars" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "AuthorId", "title" },
                values: new object[] { 98, "The Purple Cars" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "AuthorId", "title" },
                values: new object[] { 77, "A herd of Transparent Houses" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "AuthorId", "title" },
                values: new object[] { 215, "Two Rose Smelling Flowers" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "AuthorId", "title" },
                values: new object[] { 247, "The Rose Smelling Flowers" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "AuthorId", "title" },
                values: new object[] { 187, "Several Microscopic Houses" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "AuthorId", "title" },
                values: new object[] { 160, "Several Rose Smelling Leopards" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 33,
                columns: new[] { "AuthorId", "title" },
                values: new object[] { 135, "A herd of Bitter Planets" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 34,
                columns: new[] { "AuthorId", "title" },
                values: new object[] { 190, "Two Large Planets" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 35,
                columns: new[] { "AuthorId", "title" },
                values: new object[] { 177, "An army of Transparent Planets" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 36,
                columns: new[] { "AuthorId", "title" },
                values: new object[] { 126, "Two Purple Cars" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 37,
                columns: new[] { "AuthorId", "title" },
                values: new object[] { 135, "An army of Purple Buildings" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 38,
                columns: new[] { "AuthorId", "title" },
                values: new object[] { 11, "Several Transparent Planets" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 39,
                columns: new[] { "AuthorId", "title" },
                values: new object[] { 155, "Two Microscopic Flowers" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 40,
                columns: new[] { "AuthorId", "title" },
                values: new object[] { 231, "The Transparent Houses" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 41,
                columns: new[] { "AuthorId", "title" },
                values: new object[] { 33, "Several Large Planets" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 42,
                columns: new[] { "AuthorId", "title" },
                values: new object[] { 116, "An army of Microscopic Houses" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 43,
                columns: new[] { "AuthorId", "title" },
                values: new object[] { 234, "Two Microscopic Planets" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 44,
                columns: new[] { "AuthorId", "title" },
                values: new object[] { 218, "The Green Buildings" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 45,
                columns: new[] { "AuthorId", "title" },
                values: new object[] { 186, "A herd of Bitter Flowers" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 46,
                columns: new[] { "AuthorId", "title" },
                values: new object[] { 115, "An army of Microscopic Planets" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 47,
                columns: new[] { "AuthorId", "title" },
                values: new object[] { 92, "Two Transparent Cars" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 48,
                columns: new[] { "AuthorId", "title" },
                values: new object[] { 60, "Two Orange Houses" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 49,
                columns: new[] { "AuthorId", "title" },
                values: new object[] { 144, "Two Rose Smelling Planets" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 50,
                columns: new[] { "AuthorId", "title" },
                values: new object[] { 56, "A herd of Purple Planets" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 51,
                columns: new[] { "AuthorId", "title" },
                values: new object[] { 202, "Fifteen Bitter Flowers" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 52,
                column: "title",
                value: "An army of Green Planets");

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 53,
                columns: new[] { "AuthorId", "title" },
                values: new object[] { 87, "An army of Rose Smelling Cars" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 54,
                columns: new[] { "AuthorId", "title" },
                values: new object[] { 113, "Several Large Cars" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 55,
                columns: new[] { "AuthorId", "title" },
                values: new object[] { 6, "Several Large Flowers" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 56,
                columns: new[] { "AuthorId", "title" },
                values: new object[] { 224, "Two Microscopic Leopards" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 57,
                columns: new[] { "AuthorId", "title" },
                values: new object[] { 29, "An army of Rose Smelling Cars" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 58,
                columns: new[] { "AuthorId", "title" },
                values: new object[] { 32, "A herd of Purple Leopards" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 59,
                columns: new[] { "AuthorId", "title" },
                values: new object[] { 189, "The Large Planets" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 60,
                columns: new[] { "AuthorId", "title" },
                values: new object[] { 181, "Two Bitter Leopards" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 61,
                columns: new[] { "AuthorId", "title" },
                values: new object[] { 13, "A bunch of Rose Smelling Planets" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 62,
                columns: new[] { "AuthorId", "title" },
                values: new object[] { 220, "An army of Transparent Buildings" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 63,
                columns: new[] { "AuthorId", "title" },
                values: new object[] { 137, "The Transparent Cars" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 64,
                columns: new[] { "AuthorId", "title" },
                values: new object[] { 162, "An army of Green Leopards" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 65,
                columns: new[] { "AuthorId", "title" },
                values: new object[] { 167, "Fifteen Large Planets" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 66,
                columns: new[] { "AuthorId", "title" },
                values: new object[] { 221, "Two Rose Smelling Flowers" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 67,
                columns: new[] { "AuthorId", "title" },
                values: new object[] { 68, "A herd of Bitter Cars" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 68,
                columns: new[] { "AuthorId", "title" },
                values: new object[] { 212, "The Purple Buildings" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 69,
                columns: new[] { "AuthorId", "title" },
                values: new object[] { 30, "The Large Houses" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 70,
                columns: new[] { "AuthorId", "title" },
                values: new object[] { 233, "An army of Orange Planets" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 71,
                columns: new[] { "AuthorId", "title" },
                values: new object[] { 159, "Fifteen Large Planets" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 72,
                columns: new[] { "AuthorId", "title" },
                values: new object[] { 74, "Several Microscopic Planets" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 73,
                columns: new[] { "AuthorId", "title" },
                values: new object[] { 166, "Several Rose Smelling Buildings" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 74,
                columns: new[] { "AuthorId", "title" },
                values: new object[] { 177, "A bunch of Purple Buildings" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 75,
                columns: new[] { "AuthorId", "title" },
                values: new object[] { 170, "Two Large Flowers" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 76,
                columns: new[] { "AuthorId", "title" },
                values: new object[] { 86, "A bunch of Rose Smelling Planets" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 77,
                columns: new[] { "AuthorId", "title" },
                values: new object[] { 188, "Fifteen Green Leopards" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 78,
                columns: new[] { "AuthorId", "title" },
                values: new object[] { 131, "Fifteen Green Flowers" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 79,
                columns: new[] { "AuthorId", "title" },
                values: new object[] { 233, "Two Large Buildings" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 80,
                columns: new[] { "AuthorId", "title" },
                values: new object[] { 93, "A bunch of Microscopic Planets" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 81,
                columns: new[] { "AuthorId", "title" },
                values: new object[] { 212, "Fifteen Rose Smelling Leopards" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 82,
                columns: new[] { "AuthorId", "title" },
                values: new object[] { 136, "An army of Large Planets" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 83,
                columns: new[] { "AuthorId", "title" },
                values: new object[] { 79, "A bunch of Purple Cars" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 84,
                columns: new[] { "AuthorId", "title" },
                values: new object[] { 156, "An army of Green Leopards" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 85,
                columns: new[] { "AuthorId", "title" },
                values: new object[] { 78, "An army of Transparent Cars" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 86,
                columns: new[] { "AuthorId", "title" },
                values: new object[] { 40, "A bunch of Rose Smelling Leopards" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 87,
                columns: new[] { "AuthorId", "title" },
                values: new object[] { 154, "A herd of Green Planets" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 88,
                columns: new[] { "AuthorId", "title" },
                values: new object[] { 156, "A herd of Transparent Buildings" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 89,
                columns: new[] { "AuthorId", "title" },
                values: new object[] { 155, "The Bitter Buildings" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 90,
                columns: new[] { "AuthorId", "title" },
                values: new object[] { 149, "A bunch of Microscopic Cars" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 91,
                columns: new[] { "AuthorId", "title" },
                values: new object[] { 209, "Two Orange Planets" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 92,
                columns: new[] { "AuthorId", "title" },
                values: new object[] { 214, "Fifteen Orange Houses" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 93,
                columns: new[] { "AuthorId", "title" },
                values: new object[] { 214, "A bunch of Large Leopards" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 94,
                columns: new[] { "AuthorId", "title" },
                values: new object[] { 169, "A bunch of Microscopic Buildings" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 95,
                columns: new[] { "AuthorId", "title" },
                values: new object[] { 207, "Fifteen Bitter Buildings" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 96,
                columns: new[] { "AuthorId", "title" },
                values: new object[] { 211, "Several Purple Leopards" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 97,
                columns: new[] { "AuthorId", "title" },
                values: new object[] { 58, "Fifteen Orange Flowers" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 98,
                columns: new[] { "AuthorId", "title" },
                values: new object[] { 9, "Two Bitter Cars" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 99,
                columns: new[] { "AuthorId", "title" },
                values: new object[] { 1, "A herd of Purple Houses" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 100,
                columns: new[] { "AuthorId", "title" },
                values: new object[] { 84, "Two Green Houses" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 101,
                columns: new[] { "AuthorId", "title" },
                values: new object[] { 245, "A herd of Transparent Buildings" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 102,
                columns: new[] { "AuthorId", "title" },
                values: new object[] { 55, "Fifteen Orange Cars" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 103,
                columns: new[] { "AuthorId", "title" },
                values: new object[] { 159, "The Bitter Planets" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 104,
                columns: new[] { "AuthorId", "title" },
                values: new object[] { 125, "Two Purple Buildings" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 105,
                columns: new[] { "AuthorId", "title" },
                values: new object[] { 148, "Several Transparent Buildings" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 106,
                columns: new[] { "AuthorId", "title" },
                values: new object[] { 67, "Fifteen Microscopic Planets" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 107,
                columns: new[] { "AuthorId", "title" },
                values: new object[] { 183, "A bunch of Bitter Houses" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 108,
                columns: new[] { "AuthorId", "title" },
                values: new object[] { 200, "The Rose Smelling Planets" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 109,
                columns: new[] { "AuthorId", "title" },
                values: new object[] { 74, "The Large Cars" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 110,
                columns: new[] { "AuthorId", "title" },
                values: new object[] { 3, "Fifteen Rose Smelling Houses" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 111,
                columns: new[] { "AuthorId", "title" },
                values: new object[] { 30, "Several Green Planets" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 112,
                columns: new[] { "AuthorId", "title" },
                values: new object[] { 69, "An army of Green Flowers" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 113,
                columns: new[] { "AuthorId", "title" },
                values: new object[] { 232, "A bunch of Transparent Cars" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 114,
                columns: new[] { "AuthorId", "title" },
                values: new object[] { 217, "An army of Purple Planets" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 115,
                columns: new[] { "AuthorId", "title" },
                values: new object[] { 79, "Fifteen Purple Planets" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 116,
                columns: new[] { "AuthorId", "title" },
                values: new object[] { 105, "A herd of Rose Smelling Flowers" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 117,
                columns: new[] { "AuthorId", "title" },
                values: new object[] { 10, "Two Microscopic Buildings" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 118,
                columns: new[] { "AuthorId", "title" },
                values: new object[] { 128, "Several Large Houses" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 119,
                columns: new[] { "AuthorId", "title" },
                values: new object[] { 201, "Fifteen Rose Smelling Planets" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 120,
                columns: new[] { "AuthorId", "title" },
                values: new object[] { 58, "An army of Microscopic Planets" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 121,
                columns: new[] { "AuthorId", "title" },
                values: new object[] { 102, "An army of Green Planets" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 122,
                columns: new[] { "AuthorId", "title" },
                values: new object[] { 36, "Fifteen Microscopic Buildings" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 123,
                columns: new[] { "AuthorId", "title" },
                values: new object[] { 89, "Fifteen Bitter Planets" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 124,
                columns: new[] { "AuthorId", "title" },
                values: new object[] { 240, "Several Microscopic Buildings" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 125,
                columns: new[] { "AuthorId", "title" },
                values: new object[] { 180, "Fifteen Transparent Leopards" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 126,
                columns: new[] { "AuthorId", "title" },
                values: new object[] { 83, "The Bitter Houses" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 127,
                columns: new[] { "AuthorId", "title" },
                values: new object[] { 173, "Two Transparent Flowers" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 128,
                columns: new[] { "AuthorId", "title" },
                values: new object[] { 46, "A bunch of Rose Smelling Planets" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 129,
                columns: new[] { "AuthorId", "title" },
                values: new object[] { 57, "A herd of Transparent Flowers" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 130,
                columns: new[] { "AuthorId", "title" },
                values: new object[] { 197, "The Purple Leopards" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 131,
                columns: new[] { "AuthorId", "title" },
                values: new object[] { 79, "An army of Large Buildings" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 132,
                columns: new[] { "AuthorId", "title" },
                values: new object[] { 236, "An army of Rose Smelling Houses" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 133,
                columns: new[] { "AuthorId", "title" },
                values: new object[] { 48, "Fifteen Green Planets" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 134,
                columns: new[] { "AuthorId", "title" },
                values: new object[] { 176, "A bunch of Bitter Leopards" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 135,
                columns: new[] { "AuthorId", "title" },
                values: new object[] { 2, "A herd of Large Planets" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 136,
                columns: new[] { "AuthorId", "title" },
                values: new object[] { 184, "The Green Cars" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 137,
                columns: new[] { "AuthorId", "title" },
                values: new object[] { 170, "A bunch of Microscopic Leopards" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 138,
                columns: new[] { "AuthorId", "title" },
                values: new object[] { 141, "A bunch of Large Flowers" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 139,
                columns: new[] { "AuthorId", "title" },
                values: new object[] { 69, "Several Transparent Houses" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 140,
                columns: new[] { "AuthorId", "title" },
                values: new object[] { 152, "The Transparent Buildings" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 141,
                columns: new[] { "AuthorId", "title" },
                values: new object[] { 69, "An army of Bitter Buildings" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 142,
                columns: new[] { "AuthorId", "title" },
                values: new object[] { 37, "A bunch of Green Planets" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 143,
                columns: new[] { "AuthorId", "title" },
                values: new object[] { 234, "The Bitter Leopards" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 144,
                columns: new[] { "AuthorId", "title" },
                values: new object[] { 31, "A herd of Green Leopards" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 145,
                columns: new[] { "AuthorId", "title" },
                values: new object[] { 127, "The Rose Smelling Planets" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 146,
                columns: new[] { "AuthorId", "title" },
                values: new object[] { 54, "Fifteen Orange Leopards" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 147,
                columns: new[] { "AuthorId", "title" },
                values: new object[] { 157, "Two Large Cars" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 148,
                columns: new[] { "AuthorId", "title" },
                values: new object[] { 178, "Fifteen Rose Smelling Planets" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 149,
                columns: new[] { "AuthorId", "title" },
                values: new object[] { 219, "Fifteen Green Leopards" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 150,
                columns: new[] { "AuthorId", "title" },
                values: new object[] { 60, "A herd of Transparent Flowers" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 151,
                columns: new[] { "AuthorId", "title" },
                values: new object[] { 93, "An army of Orange Buildings" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 152,
                columns: new[] { "AuthorId", "title" },
                values: new object[] { 95, "Fifteen Transparent Cars" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 153,
                columns: new[] { "AuthorId", "title" },
                values: new object[] { 195, "Several Microscopic Leopards" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 154,
                columns: new[] { "AuthorId", "title" },
                values: new object[] { 125, "An army of Purple Buildings" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 155,
                columns: new[] { "AuthorId", "title" },
                values: new object[] { 114, "Several Transparent Houses" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 156,
                columns: new[] { "AuthorId", "title" },
                values: new object[] { 53, "An army of Purple Buildings" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 157,
                columns: new[] { "AuthorId", "title" },
                values: new object[] { 119, "The Purple Buildings" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 158,
                columns: new[] { "AuthorId", "title" },
                values: new object[] { 211, "Two Green Cars" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 159,
                columns: new[] { "AuthorId", "title" },
                values: new object[] { 99, "An army of Large Planets" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 160,
                columns: new[] { "AuthorId", "title" },
                values: new object[] { 66, "A herd of Transparent Houses" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 161,
                columns: new[] { "AuthorId", "title" },
                values: new object[] { 151, "The Rose Smelling Planets" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 162,
                columns: new[] { "AuthorId", "title" },
                values: new object[] { 53, "Several Orange Flowers" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 163,
                columns: new[] { "AuthorId", "title" },
                values: new object[] { 71, "An army of Bitter Buildings" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 164,
                columns: new[] { "AuthorId", "title" },
                values: new object[] { 211, "A bunch of Large Buildings" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 165,
                columns: new[] { "AuthorId", "title" },
                values: new object[] { 53, "A bunch of Rose Smelling Buildings" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 166,
                columns: new[] { "AuthorId", "title" },
                values: new object[] { 207, "Fifteen Purple Cars" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 167,
                columns: new[] { "AuthorId", "title" },
                values: new object[] { 24, "A bunch of Orange Planets" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 168,
                columns: new[] { "AuthorId", "title" },
                values: new object[] { 142, "Fifteen Orange Flowers" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 169,
                columns: new[] { "AuthorId", "title" },
                values: new object[] { 157, "A herd of Transparent Flowers" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 170,
                columns: new[] { "AuthorId", "title" },
                values: new object[] { 17, "An army of Green Planets" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 171,
                columns: new[] { "AuthorId", "title" },
                values: new object[] { 113, "A bunch of Large Cars" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 172,
                columns: new[] { "AuthorId", "title" },
                values: new object[] { 172, "Several Transparent Leopards" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 173,
                columns: new[] { "AuthorId", "title" },
                values: new object[] { 90, "The Rose Smelling Planets" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 174,
                columns: new[] { "AuthorId", "title" },
                values: new object[] { 2, "Fifteen Purple Planets" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 175,
                columns: new[] { "AuthorId", "title" },
                values: new object[] { 168, "An army of Large Buildings" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 176,
                columns: new[] { "AuthorId", "title" },
                values: new object[] { 40, "A bunch of Large Leopards" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 177,
                columns: new[] { "AuthorId", "title" },
                values: new object[] { 28, "Several Microscopic Cars" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 178,
                columns: new[] { "AuthorId", "title" },
                values: new object[] { 74, "A bunch of Rose Smelling Flowers" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 179,
                columns: new[] { "AuthorId", "title" },
                values: new object[] { 102, "A bunch of Purple Houses" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 180,
                columns: new[] { "AuthorId", "title" },
                values: new object[] { 98, "Several Transparent Cars" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 181,
                columns: new[] { "AuthorId", "title" },
                values: new object[] { 181, "Two Rose Smelling Buildings" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 182,
                columns: new[] { "AuthorId", "title" },
                values: new object[] { 68, "Two Purple Planets" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 183,
                columns: new[] { "AuthorId", "title" },
                values: new object[] { 229, "An army of Green Cars" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 184,
                columns: new[] { "AuthorId", "title" },
                values: new object[] { 221, "The Orange Cars" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 185,
                columns: new[] { "AuthorId", "title" },
                values: new object[] { 173, "The Microscopic Buildings" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 186,
                columns: new[] { "AuthorId", "title" },
                values: new object[] { 27, "A bunch of Green Houses" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 187,
                columns: new[] { "AuthorId", "title" },
                values: new object[] { 72, "An army of Purple Leopards" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 188,
                columns: new[] { "AuthorId", "title" },
                values: new object[] { 75, "An army of Green Planets" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 189,
                columns: new[] { "AuthorId", "title" },
                values: new object[] { 194, "Two Bitter Leopards" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 190,
                columns: new[] { "AuthorId", "title" },
                values: new object[] { 137, "Several Green Buildings" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 191,
                columns: new[] { "AuthorId", "title" },
                values: new object[] { 206, "Fifteen Rose Smelling Buildings" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 192,
                columns: new[] { "AuthorId", "title" },
                values: new object[] { 21, "A bunch of Green Leopards" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 193,
                columns: new[] { "AuthorId", "title" },
                values: new object[] { 3, "Fifteen Orange Leopards" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 194,
                columns: new[] { "AuthorId", "title" },
                values: new object[] { 47, "Fifteen Large Flowers" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 195,
                columns: new[] { "AuthorId", "title" },
                values: new object[] { 91, "Fifteen Large Buildings" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 196,
                columns: new[] { "AuthorId", "title" },
                values: new object[] { 132, "Two Microscopic Houses" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 197,
                columns: new[] { "AuthorId", "title" },
                values: new object[] { 113, "An army of Rose Smelling Planets" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 198,
                columns: new[] { "AuthorId", "title" },
                values: new object[] { 237, "Fifteen Rose Smelling Buildings" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 199,
                columns: new[] { "AuthorId", "title" },
                values: new object[] { 223, "A bunch of Purple Planets" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 200,
                columns: new[] { "AuthorId", "title" },
                values: new object[] { 55, "Fifteen Microscopic Leopards" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 201,
                columns: new[] { "AuthorId", "title" },
                values: new object[] { 79, "Several Green Houses" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 202,
                columns: new[] { "AuthorId", "title" },
                values: new object[] { 243, "Two Rose Smelling Buildings" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 203,
                columns: new[] { "AuthorId", "title" },
                values: new object[] { 27, "The Transparent Flowers" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 204,
                columns: new[] { "AuthorId", "title" },
                values: new object[] { 209, "The Orange Planets" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 205,
                columns: new[] { "AuthorId", "title" },
                values: new object[] { 177, "Fifteen Green Planets" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 206,
                columns: new[] { "AuthorId", "title" },
                values: new object[] { 244, "An army of Microscopic Houses" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 207,
                columns: new[] { "AuthorId", "title" },
                values: new object[] { 154, "Fifteen Large Cars" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 208,
                columns: new[] { "AuthorId", "title" },
                values: new object[] { 68, "Fifteen Orange Planets" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 209,
                columns: new[] { "AuthorId", "title" },
                values: new object[] { 48, "The Green Houses" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 210,
                columns: new[] { "AuthorId", "title" },
                values: new object[] { 167, "A herd of Purple Planets" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 211,
                columns: new[] { "AuthorId", "title" },
                values: new object[] { 227, "Two Bitter Leopards" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 212,
                columns: new[] { "AuthorId", "title" },
                values: new object[] { 184, "A bunch of Orange Buildings" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 213,
                columns: new[] { "AuthorId", "title" },
                values: new object[] { 176, "A bunch of Green Buildings" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 214,
                columns: new[] { "AuthorId", "title" },
                values: new object[] { 100, "An army of Bitter Buildings" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 215,
                columns: new[] { "AuthorId", "title" },
                values: new object[] { 215, "Fifteen Purple Houses" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 216,
                columns: new[] { "AuthorId", "title" },
                values: new object[] { 26, "A bunch of Transparent Planets" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 217,
                columns: new[] { "AuthorId", "title" },
                values: new object[] { 7, "A bunch of Green Houses" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 218,
                columns: new[] { "AuthorId", "title" },
                values: new object[] { 79, "A bunch of Purple Leopards" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 219,
                columns: new[] { "AuthorId", "title" },
                values: new object[] { 60, "Fifteen Transparent Buildings" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 220,
                columns: new[] { "AuthorId", "title" },
                values: new object[] { 44, "A bunch of Large Buildings" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 221,
                columns: new[] { "AuthorId", "title" },
                values: new object[] { 218, "The Purple Planets" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 222,
                columns: new[] { "AuthorId", "title" },
                values: new object[] { 174, "Two Rose Smelling Buildings" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 223,
                columns: new[] { "AuthorId", "title" },
                values: new object[] { 209, "Fifteen Orange Houses" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 224,
                columns: new[] { "AuthorId", "title" },
                values: new object[] { 15, "Fifteen Rose Smelling Planets" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 225,
                columns: new[] { "AuthorId", "title" },
                values: new object[] { 155, "The Transparent Buildings" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 226,
                columns: new[] { "AuthorId", "title" },
                values: new object[] { 75, "A bunch of Purple Houses" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 227,
                columns: new[] { "AuthorId", "title" },
                values: new object[] { 88, "Several Microscopic Planets" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 228,
                columns: new[] { "AuthorId", "title" },
                values: new object[] { 12, "An army of Orange Flowers" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 229,
                columns: new[] { "AuthorId", "title" },
                values: new object[] { 67, "The Purple Buildings" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 230,
                columns: new[] { "AuthorId", "title" },
                values: new object[] { 50, "The Green Planets" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 231,
                columns: new[] { "AuthorId", "title" },
                values: new object[] { 119, "Several Transparent Cars" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 232,
                columns: new[] { "AuthorId", "title" },
                values: new object[] { 76, "Two Orange Buildings" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 233,
                columns: new[] { "AuthorId", "title" },
                values: new object[] { 8, "Two Green Planets" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 234,
                columns: new[] { "AuthorId", "title" },
                values: new object[] { 217, "A bunch of Orange Cars" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 235,
                columns: new[] { "AuthorId", "title" },
                values: new object[] { 6, "A herd of Microscopic Leopards" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 236,
                columns: new[] { "AuthorId", "title" },
                values: new object[] { 53, "Fifteen Large Planets" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 237,
                columns: new[] { "AuthorId", "title" },
                values: new object[] { 246, "The Microscopic Buildings" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 238,
                columns: new[] { "AuthorId", "title" },
                values: new object[] { 31, "Two Bitter Leopards" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 239,
                columns: new[] { "AuthorId", "title" },
                values: new object[] { 89, "An army of Bitter Planets" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 240,
                columns: new[] { "AuthorId", "title" },
                values: new object[] { 68, "An army of Rose Smelling Flowers" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 241,
                columns: new[] { "AuthorId", "title" },
                values: new object[] { 131, "Several Large Flowers" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 242,
                columns: new[] { "AuthorId", "title" },
                values: new object[] { 140, "A herd of Microscopic Flowers" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 243,
                columns: new[] { "AuthorId", "title" },
                values: new object[] { 60, "A herd of Orange Cars" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 244,
                columns: new[] { "AuthorId", "title" },
                values: new object[] { 22, "The Green Leopards" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 245,
                columns: new[] { "AuthorId", "title" },
                values: new object[] { 133, "Several Bitter Flowers" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 246,
                columns: new[] { "AuthorId", "title" },
                values: new object[] { 43, "An army of Orange Buildings" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 247,
                columns: new[] { "AuthorId", "title" },
                values: new object[] { 134, "An army of Orange Cars" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 248,
                columns: new[] { "AuthorId", "title" },
                values: new object[] { 144, "The Microscopic Flowers" });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 249,
                columns: new[] { "AuthorId", "title" },
                values: new object[] { 47, "The Large Flowers" });

            migrationBuilder.AddForeignKey(
                name: "FK_books_Authors_AuthorId",
                table: "books",
                column: "AuthorId",
                principalTable: "Authors",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_books_Authors_AuthorId",
                table: "books");

            migrationBuilder.DropPrimaryKey(
                name: "PK_books",
                table: "books");

            migrationBuilder.RenameTable(
                name: "books",
                newName: "Books");

            migrationBuilder.RenameColumn(
                name: "title",
                table: "Books",
                newName: "Title");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Books",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_books_AuthorId",
                table: "Books",
                newName: "IX_Books_AuthorId");

            migrationBuilder.RenameColumn(
                name: "email",
                table: "Authors",
                newName: "Email");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Authors",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "last_name",
                table: "Authors",
                newName: "LastName");

            migrationBuilder.RenameColumn(
                name: "first_name",
                table: "Authors",
                newName: "FirstName");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Books",
                table: "Books",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "elvis.winslet@nasa.org.us", "Elvis", "Winslet" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Email", "LastName" },
                values: new object[] { "kate.hepburn@gov.us", "Hepburn" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "charles.hepburn@google.com", "Charles", "Hepburn" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "barack.trump@gov.ru", "Barack", "Trump" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "mick.obama@google.com", "Mick", "Obama" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Email", "FirstName" },
                values: new object[] { "charles.windsor@nasa.org.us", "Charles" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "jimi.hendrix@bbc.co.uk", "Jimi", "Hendrix" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "barack.jagger@google.com", "Barack", "Jagger" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "mick.hepburn@nasa.org.us", "Mick", "Hepburn" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "kate.winslet@bbc.co.uk", "Kate", "Winslet" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "elvis.hendrix@something.com", "Elvis", "Hendrix" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "elvis.windsor@something.com", "Elvis", "Windsor" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "kate.trump@tesla.com", "Kate", "Trump" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "kate.hepburn@tesla.com", "Kate", "Hepburn" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Email", "LastName" },
                values: new object[] { "barack.hendrix@gov.ru", "Hendrix" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "mick.hendrix@gov.nl", "Mick", "Hendrix" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "kate.winfrey@gov.nl", "Kate", "Winfrey" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "audrey.hendrix@google.com", "Audrey", "Hendrix" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "elvis.jagger@gov.ru", "Elvis", "Jagger" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "charles.presley@something.com", "Charles", "Presley" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "jimi.hepburn@gov.gr", "Jimi", "Hepburn" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Email", "LastName" },
                values: new object[] { "kate.middleton@gov.nl", "Middleton" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "jimi.winfrey@theworld.ca", "Jimi", "Winfrey" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "mick.presley@bbc.co.uk", "Mick", "Presley" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "donald.presley@something.com", "Donald", "Presley" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "donald.winslet@nasa.org.us", "Donald", "Winslet" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "oprah.hepburn@bbc.co.uk", "Oprah", "Hepburn" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "kate.middleton@gov.gr", "Kate", "Middleton" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Email", "FirstName" },
                values: new object[] { "charles.windsor@gov.ru", "Charles" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "kate.winslet@gov.gr", "Kate", "Winslet" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "kate.obama@gov.us", "Kate", "Obama" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "oprah.presley@bbc.co.uk", "Oprah", "Presley" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "kate.jagger@bbc.co.uk", "Kate", "Jagger" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Email", "LastName" },
                values: new object[] { "mick.trump@google.com", "Trump" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "kate.middleton@theworld.ca", "Kate", "Middleton" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "elvis.obama@google.com", "Elvis", "Obama" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "mick.winslet@theworld.ca", "Mick", "Winslet" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 38,
                column: "Email",
                value: "audrey.winfrey@gov.us");

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "jimi.winslet@gov.nl", "Jimi", "Winslet" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "jimi.jagger@bbc.co.uk", "Jimi", "Jagger" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Email", "FirstName" },
                values: new object[] { "kate.jagger@theworld.ca", "Kate" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "charles.jagger@gov.ru", "Charles", "Jagger" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "charles.hepburn@gov.ru", "Charles", "Hepburn" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "kate.winslet@gov.nl", "Kate", "Winslet" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "barack.presley@gov.us", "Barack", "Presley" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Email", "FirstName" },
                values: new object[] { "kate.jagger@gov.nl", "Kate" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Email", "LastName" },
                values: new object[] { "donald.hendrix@something.com", "Hendrix" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "kate.jagger@gov.ru", "Kate", "Jagger" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "donald.obama@gov.nl", "Donald", "Obama" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "kate.jagger@tesla.com", "Kate", "Jagger" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "kate.obama@google.com", "Kate", "Obama" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "oprah.winslet@gov.ru", "Oprah", "Winslet" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "donald.obama@nasa.org.us", "Donald", "Obama" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "Email", "LastName" },
                values: new object[] { "jimi.winfrey@theworld.ca", "Winfrey" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "barack.presley@something.com", "Barack", "Presley" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "elvis.hepburn@something.com", "Elvis", "Hepburn" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "Email", "LastName" },
                values: new object[] { "kate.trump@gov.gr", "Trump" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "audrey.hendrix@gov.us", "Audrey", "Hendrix" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "mick.winfrey@google.com", "Mick", "Winfrey" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "charles.presley@nasa.org.us", "Charles", "Presley" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "kate.winfrey@tesla.com", "Kate", "Winfrey" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "audrey.hepburn@gov.us", "Audrey", "Hepburn" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "Email", "LastName" },
                values: new object[] { "kate.obama@google.com", "Obama" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "oprah.hendrix@gov.us", "Oprah", "Hendrix" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "charles.windsor@theworld.ca", "Charles", "Windsor" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "jimi.trump@bbc.co.uk", "Jimi", "Trump" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "kate.trump@theworld.ca", "Kate", "Trump" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "barack.middleton@theworld.ca", "Barack", "Middleton" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "mick.windsor@gov.gr", "Mick", "Windsor" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "kate.windsor@gov.gr", "Kate", "Windsor" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "Email", "LastName" },
                values: new object[] { "kate.jagger@gov.ru", "Jagger" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "Email", "FirstName" },
                values: new object[] { "barack.hepburn@gov.nl", "Barack" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "barack.jagger@theworld.ca", "Barack", "Jagger" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "Email", "LastName" },
                values: new object[] { "elvis.obama@gov.ru", "Obama" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "barack.windsor@bbc.co.uk", "Barack", "Windsor" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "charles.jagger@google.com", "Charles", "Jagger" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 77,
                column: "Email",
                value: "charles.windsor@nasa.org.us");

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "donald.winfrey@gov.us", "Donald", "Winfrey" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "kate.obama@google.com", "Kate", "Obama" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "jimi.hepburn@theworld.ca", "Jimi", "Hepburn" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "audrey.obama@tesla.com", "Audrey", "Obama" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "charles.hepburn@tesla.com", "Charles", "Hepburn" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "elvis.jagger@gov.us", "Elvis", "Jagger" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "Email", "LastName" },
                values: new object[] { "barack.winfrey@something.com", "Winfrey" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "mick.middleton@gov.nl", "Mick", "Middleton" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "Email", "FirstName" },
                values: new object[] { "kate.winfrey@gov.ru", "Kate" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "Email", "FirstName" },
                values: new object[] { "kate.winfrey@gov.ru", "Kate" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "donald.hendrix@something.com", "Donald", "Hendrix" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "mick.hendrix@nasa.org.us", "Mick", "Hendrix" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "audrey.trump@gov.nl", "Audrey", "Trump" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "Email", "LastName" },
                values: new object[] { "barack.winfrey@theworld.ca", "Winfrey" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "kate.hepburn@nasa.org.us", "Kate", "Hepburn" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "barack.hepburn@gov.us", "Barack", "Hepburn" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "mick.obama@gov.gr", "Mick", "Obama" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "charles.winslet@gov.nl", "Charles", "Winslet" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "charles.obama@bbc.co.uk", "Charles", "Obama" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "Email", "LastName" },
                values: new object[] { "kate.hepburn@google.com", "Hepburn" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "Email", "LastName" },
                values: new object[] { "jimi.hepburn@google.com", "Hepburn" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "jimi.winslet@nasa.org.us", "Jimi", "Winslet" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "jimi.obama@gov.us", "Jimi", "Obama" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "charles.winfrey@google.com", "Charles", "Winfrey" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "mick.obama@nasa.org.us", "Mick", "Obama" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "kate.windsor@google.com", "Kate", "Windsor" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "kate.hendrix@nasa.org.us", "Kate", "Hendrix" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "charles.jagger@gov.gr", "Charles", "Jagger" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "Email", "LastName" },
                values: new object[] { "kate.windsor@gov.ru", "Windsor" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "kate.hendrix@google.com", "Kate", "Hendrix" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "jimi.obama@gov.ru", "Jimi", "Obama" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 109,
                column: "Email",
                value: "donald.middleton@gov.nl");

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "Email", "LastName" },
                values: new object[] { "kate.winslet@nasa.org.us", "Winslet" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "oprah.middleton@something.com", "Oprah", "Middleton" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "Email", "LastName" },
                values: new object[] { "mick.jagger@nasa.org.us", "Jagger" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "mick.presley@something.com", "Mick", "Presley" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "barack.winslet@gov.us", "Barack", "Winslet" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "donald.middleton@tesla.com", "Donald", "Middleton" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "donald.trump@gov.nl", "Donald", "Trump" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "elvis.middleton@theworld.ca", "Elvis", "Middleton" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "charles.jagger@google.com", "Charles", "Jagger" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "donald.windsor@gov.ru", "Donald", "Windsor" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "jimi.winfrey@gov.gr", "Jimi", "Winfrey" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "barack.obama@gov.us", "Barack", "Obama" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "audrey.hepburn@tesla.com", "Audrey", "Hepburn" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "kate.trump@something.com", "Kate", "Trump" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "kate.jagger@something.com", "Kate", "Jagger" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "elvis.hepburn@tesla.com", "Elvis", "Hepburn" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "Email", "LastName" },
                values: new object[] { "kate.hendrix@something.com", "Hendrix" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "Email", "FirstName" },
                values: new object[] { "charles.windsor@theworld.ca", "Charles" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "barack.hendrix@something.com", "Barack", "Hendrix" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "elvis.presley@google.com", "Elvis", "Presley" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "charles.hepburn@gov.gr", "Charles", "Hepburn" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "Email", "LastName" },
                values: new object[] { "audrey.obama@tesla.com", "Obama" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "Email", "LastName" },
                values: new object[] { "elvis.middleton@gov.gr", "Middleton" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "jimi.middleton@gov.us", "Jimi", "Middleton" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "kate.trump@google.com", "Kate", "Trump" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "barack.windsor@gov.ru", "Barack", "Windsor" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "Email", "FirstName" },
                values: new object[] { "charles.winfrey@something.com", "Charles" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "kate.middleton@something.com", "Kate", "Middleton" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "kate.presley@gov.us", "Kate", "Presley" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "Email", "FirstName" },
                values: new object[] { "kate.presley@nasa.org.us", "Kate" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 140,
                column: "Email",
                value: "audrey.hendrix@gov.gr");

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "audrey.middleton@gov.ru", "Audrey", "Middleton" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "Email", "FirstName" },
                values: new object[] { "elvis.trump@gov.gr", "Elvis" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "mick.obama@nasa.org.us", "Mick", "Obama" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "charles.windsor@gov.us", "Charles", "Windsor" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "Email", "LastName" },
                values: new object[] { "kate.hepburn@google.com", "Hepburn" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "kate.presley@gov.us", "Kate", "Presley" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "mick.middleton@gov.gr", "Mick", "Middleton" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "Email", "FirstName" },
                values: new object[] { "charles.winfrey@gov.gr", "Charles" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "jimi.trump@theworld.ca", "Jimi", "Trump" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "jimi.winfrey@something.com", "Jimi", "Winfrey" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "Email", "LastName" },
                values: new object[] { "mick.obama@gov.gr", "Obama" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "oprah.winfrey@theworld.ca", "Oprah", "Winfrey" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "elvis.windsor@gov.ru", "Elvis", "Windsor" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "Email", "FirstName" },
                values: new object[] { "donald.hepburn@bbc.co.uk", "Donald" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "kate.winfrey@something.com", "Kate", "Winfrey" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "charles.obama@gov.gr", "Charles", "Obama" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "mick.windsor@gov.gr", "Mick", "Windsor" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "kate.hendrix@gov.gr", "Kate", "Hendrix" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "kate.middleton@gov.ru", "Kate", "Middleton" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "kate.middleton@gov.us", "Kate", "Middleton" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "barack.jagger@gov.ru", "Barack", "Jagger" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "charles.winslet@gov.us", "Charles", "Winslet" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "Email", "FirstName" },
                values: new object[] { "oprah.middleton@gov.nl", "Oprah" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "charles.windsor@gov.ru", "Charles", "Windsor" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "donald.winslet@tesla.com", "Donald", "Winslet" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "kate.obama@google.com", "Kate", "Obama" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "mick.hendrix@gov.gr", "Mick", "Hendrix" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "kate.presley@nasa.org.us", "Kate", "Presley" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "kate.middleton@gov.ru", "Kate", "Middleton" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "kate.winfrey@gov.us", "Kate", "Winfrey" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "elvis.winslet@gov.ru", "Elvis", "Winslet" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "barack.hendrix@nasa.org.us", "Barack", "Hendrix" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "charles.hepburn@something.com", "Charles", "Hepburn" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "kate.hepburn@bbc.co.uk", "Kate", "Hepburn" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "Email", "LastName" },
                values: new object[] { "kate.obama@bbc.co.uk", "Obama" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "barack.hepburn@theworld.ca", "Barack", "Hepburn" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "oprah.obama@gov.ru", "Oprah", "Obama" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "kate.hendrix@gov.nl", "Kate", "Hendrix" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "kate.windsor@gov.nl", "Kate", "Windsor" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "Email", "LastName" },
                values: new object[] { "oprah.winfrey@theworld.ca", "Winfrey" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "Email", "FirstName" },
                values: new object[] { "jimi.presley@gov.gr", "Jimi" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "Email", "FirstName" },
                values: new object[] { "elvis.winslet@gov.nl", "Elvis" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "barack.presley@gov.ru", "Barack", "Presley" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "charles.obama@gov.gr", "Charles", "Obama" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "charles.middleton@bbc.co.uk", "Charles", "Middleton" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "elvis.hepburn@something.com", "Elvis", "Hepburn" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "Email", "FirstName" },
                values: new object[] { "jimi.jagger@nasa.org.us", "Jimi" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "donald.trump@gov.ru", "Donald", "Trump" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "mick.hendrix@something.com", "Mick", "Hendrix" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "mick.windsor@gov.ru", "Mick", "Windsor" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "Email", "FirstName" },
                values: new object[] { "audrey.hendrix@nasa.org.us", "Audrey" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "charles.hendrix@gov.ru", "Charles", "Hendrix" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "Email", "FirstName" },
                values: new object[] { "jimi.middleton@nasa.org.us", "Jimi" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "mick.middleton@tesla.com", "Mick", "Middleton" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "audrey.winslet@nasa.org.us", "Audrey", "Winslet" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "barack.winslet@theworld.ca", "Barack", "Winslet" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "Email", "FirstName" },
                values: new object[] { "donald.presley@theworld.ca", "Donald" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "audrey.winslet@google.com", "Audrey", "Winslet" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "barack.middleton@tesla.com", "Barack", "Middleton" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "Email", "LastName" },
                values: new object[] { "barack.trump@something.com", "Trump" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "barack.obama@theworld.ca", "Barack", "Obama" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 203,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "barack.hendrix@gov.nl", "Barack", "Hendrix" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 204,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "kate.winfrey@gov.us", "Kate", "Winfrey" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 205,
                columns: new[] { "Email", "FirstName" },
                values: new object[] { "donald.middleton@google.com", "Donald" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 206,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "audrey.presley@theworld.ca", "Audrey", "Presley" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 207,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "audrey.winslet@something.com", "Audrey", "Winslet" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 208,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "jimi.hepburn@google.com", "Jimi", "Hepburn" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 209,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "mick.middleton@gov.us", "Mick", "Middleton" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 210,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "audrey.middleton@gov.ru", "Audrey", "Middleton" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 211,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "barack.winslet@gov.nl", "Barack", "Winslet" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 212,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "kate.jagger@gov.gr", "Kate", "Jagger" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 213,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "charles.jagger@tesla.com", "Charles", "Jagger" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 214,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "oprah.jagger@gov.us", "Oprah", "Jagger" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 215,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "audrey.presley@gov.ru", "Audrey", "Presley" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 216,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "kate.obama@theworld.ca", "Kate", "Obama" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 217,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "kate.hepburn@gov.gr", "Kate", "Hepburn" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 218,
                columns: new[] { "Email", "LastName" },
                values: new object[] { "charles.winslet@something.com", "Winslet" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 219,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "donald.trump@nasa.org.us", "Donald", "Trump" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 220,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "elvis.presley@theworld.ca", "Elvis", "Presley" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 221,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "barack.presley@gov.gr", "Barack", "Presley" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 222,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "audrey.winfrey@theworld.ca", "Audrey", "Winfrey" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 223,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "elvis.windsor@something.com", "Elvis", "Windsor" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 224,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "barack.windsor@gov.nl", "Barack", "Windsor" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 225,
                columns: new[] { "Email", "LastName" },
                values: new object[] { "elvis.hepburn@google.com", "Hepburn" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 226,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "elvis.presley@nasa.org.us", "Elvis", "Presley" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 227,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "charles.winslet@bbc.co.uk", "Charles", "Winslet" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 228,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "oprah.winfrey@theworld.ca", "Oprah", "Winfrey" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 229,
                columns: new[] { "Email", "LastName" },
                values: new object[] { "jimi.winfrey@bbc.co.uk", "Winfrey" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 230,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "kate.winslet@bbc.co.uk", "Kate", "Winslet" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 231,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "barack.windsor@gov.us", "Barack", "Windsor" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 232,
                columns: new[] { "Email", "LastName" },
                values: new object[] { "kate.hendrix@gov.us", "Hendrix" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 233,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "donald.hendrix@bbc.co.uk", "Donald", "Hendrix" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 234,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "kate.hendrix@theworld.ca", "Kate", "Hendrix" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 235,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "audrey.hendrix@gov.nl", "Audrey", "Hendrix" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 236,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "mick.winslet@bbc.co.uk", "Mick", "Winslet" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 237,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "audrey.hepburn@google.com", "Audrey", "Hepburn" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 238,
                columns: new[] { "Email", "LastName" },
                values: new object[] { "mick.trump@nasa.org.us", "Trump" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 239,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "audrey.middleton@gov.us", "Audrey", "Middleton" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 240,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "barack.winfrey@bbc.co.uk", "Barack", "Winfrey" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 241,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "donald.middleton@gov.ru", "Donald", "Middleton" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 242,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "charles.trump@nasa.org.us", "Charles", "Trump" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 243,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "audrey.trump@gov.ru", "Audrey", "Trump" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 244,
                columns: new[] { "Email", "LastName" },
                values: new object[] { "kate.hepburn@gov.ru", "Hepburn" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 245,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "oprah.hendrix@google.com", "Oprah", "Hendrix" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 246,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "charles.winslet@nasa.org.us", "Charles", "Winslet" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 247,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "mick.windsor@gov.gr", "Mick", "Windsor" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 248,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "kate.winslet@google.com", "Kate", "Winslet" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 249,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "charles.presley@nasa.org.us", "Charles", "Presley" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 203, "Several Orange Buildings" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 67, "A herd of Purple Flowers" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 167, "Fifteen Purple Flowers" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 183, "An army of Orange Buildings" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 63, "Two Green Flowers" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 71, "Several Large Leopards" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 167, "Two Bitter Buildings" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 137, "An army of Microscopic Buildings" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 202, "An army of Transparent Planets" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 79, "An army of Large Flowers" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 153, "Two Transparent Buildings" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 44, "Fifteen Bitter Houses" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 140, "Two Rose Smelling Cars" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 202, "Several Rose Smelling Planets" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 188, "Fifteen Bitter Cars" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 167, "An army of Microscopic Flowers" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 129, "The Large Flowers" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 191, "An army of Green Leopards" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 240, "Several Purple Leopards" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 130, "Fifteen Transparent Flowers" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 93, "Several Bitter Flowers" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 34, "A herd of Bitter Buildings" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 142, "Two Orange Buildings" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 195, "A bunch of Large Buildings" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 39, "Several Purple Leopards" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 114, "A bunch of Large Cars" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 54, "Several Purple Leopards" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 71, "An army of Orange Cars" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 233, "Several Orange Houses" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 42, "Fifteen Bitter Houses" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 61, "A bunch of Large Buildings" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 240, "The Orange Houses" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 138, "Fifteen Transparent Planets" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 149, "An army of Large Flowers" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 193, "Several Green Houses" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 235, "A herd of Rose Smelling Buildings" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 216, "A bunch of Microscopic Cars" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 125, "The Transparent Flowers" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 184, "A herd of Bitter Planets" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 26, "A herd of Purple Leopards" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 22, "An army of Rose Smelling Cars" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 165, "A herd of Green Houses" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 204, "A herd of Bitter Leopards" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 95, "Two Purple Flowers" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 14, "Several Bitter Houses" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 130, "Several Transparent Cars" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 106, "An army of Transparent Planets" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 52, "Fifteen Green Cars" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 21, "A bunch of Purple Buildings" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 14, "A herd of Orange Leopards" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 159, "Two Bitter Leopards" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 52,
                column: "Title",
                value: "Fifteen Purple Leopards");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 15, "An army of Orange Houses" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 14, "The Bitter Houses" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 177, "The Purple Planets" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 158, "Several Orange Houses" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 89, "A bunch of Green Leopards" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 141, "A bunch of Transparent Houses" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 67, "Fifteen Transparent Leopards" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 35, "A bunch of Transparent Planets" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 223, "Several Rose Smelling Cars" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 93, "An army of Orange Planets" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 102, "Two Microscopic Cars" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 128, "Two Transparent Leopards" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 4, "A herd of Orange Buildings" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 196, "A herd of Rose Smelling Leopards" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 85, "A bunch of Large Buildings" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 103, "Several Bitter Planets" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 98, "A bunch of Green Leopards" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 167, "An army of Purple Buildings" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 102, "The Green Buildings" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 92, "A bunch of Purple Buildings" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 27, "An army of Microscopic Flowers" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 1, "Several Transparent Planets" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 32, "The Green Planets" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 28, "An army of Transparent Flowers" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 176, "Fifteen Large Flowers" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 245, "Several Large Leopards" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 1, "An army of Microscopic Cars" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 45, "Several Bitter Flowers" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 189, "An army of Orange Buildings" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 178, "The Orange Houses" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 135, "The Transparent Cars" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 4, "Several Purple Cars" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 155, "Fifteen Purple Cars" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 24, "A bunch of Large Leopards" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 183, "The Transparent Leopards" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 114, "A herd of Large Cars" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 169, "An army of Transparent Cars" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 37, "Fifteen Bitter Flowers" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 41, "A herd of Large Buildings" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 62, "A herd of Purple Flowers" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 113, "Two Orange Leopards" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 52, "A bunch of Orange Houses" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 175, "Several Purple Buildings" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 63, "Two Transparent Flowers" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 147, "The Large Cars" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 193, "An army of Microscopic Leopards" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 246, "Two Purple Planets" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 127, "A bunch of Orange Cars" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 222, "A bunch of Rose Smelling Buildings" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 78, "Several Green Planets" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 23, "Fifteen Orange Buildings" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 66, "An army of Transparent Leopards" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 104, "A herd of Transparent Flowers" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 141, "A herd of Microscopic Leopards" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 141, "The Orange Planets" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 16, "An army of Bitter Houses" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 59, "A bunch of Large Houses" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 137, "Two Bitter Houses" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 97, "Two Transparent Cars" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 247, "The Bitter Cars" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 201, "The Rose Smelling Planets" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 194, "An army of Bitter Houses" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 127, "Two Large Houses" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 30, "Several Orange Buildings" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 19, "The Transparent Planets" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 33, "The Transparent Planets" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 129, "A bunch of Bitter Flowers" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 154, "A herd of Bitter Cars" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 6, "Several Bitter Planets" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 50, "A herd of Orange Cars" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 211, "Fifteen Microscopic Houses" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 88, "A herd of Transparent Cars" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 134, "An army of Transparent Planets" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 248, "A herd of Microscopic Planets" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 195, "Two Purple Buildings" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 54, "Two Orange Buildings" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 10, "Two Green Buildings" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 35, "Several Purple Leopards" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 244, "An army of Purple Planets" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 166, "A bunch of Transparent Leopards" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 119, "A herd of Rose Smelling Houses" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 202, "The Large Flowers" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 148, "A herd of Large Leopards" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 193, "A herd of Bitter Leopards" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 118, "The Bitter Houses" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 18, "An army of Microscopic Houses" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 28, "The Transparent Planets" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 14, "A bunch of Microscopic Flowers" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 198, "Fifteen Large Buildings" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 179, "A bunch of Orange Leopards" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 48, "Two Purple Houses" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 111, "The Orange Leopards" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 247, "A herd of Microscopic Buildings" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 88, "Two Green Planets" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 206, "Fifteen Green Leopards" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 169, "A bunch of Green Cars" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 71, "An army of Rose Smelling Buildings" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 104, "A herd of Microscopic Buildings" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 156, "A bunch of Rose Smelling Buildings" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 103, "The Transparent Cars" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 214, "Fifteen Bitter Flowers" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 105, "The Orange Planets" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 85, "The Rose Smelling Planets" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 174, "The Rose Smelling Leopards" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 88, "Fifteen Large Cars" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 112, "A herd of Green Flowers" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 130, "Two Orange Leopards" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 134, "Fifteen Purple Buildings" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 209, "The Microscopic Cars" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 244, "A herd of Purple Flowers" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 162, "Several Transparent Buildings" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 18, "A bunch of Microscopic Buildings" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 154, "Two Bitter Buildings" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 245, "Fifteen Bitter Houses" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 217, "Fifteen Orange Planets" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 3, "Fifteen Transparent Planets" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 36, "A bunch of Microscopic Houses" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 238, "A bunch of Rose Smelling Houses" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 242, "The Purple Buildings" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 9, "A bunch of Bitter Cars" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 46, "A herd of Purple Planets" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 186, "Fifteen Orange Buildings" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 72, "An army of Purple Houses" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 243, "A herd of Green Planets" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 185, "An army of Orange Houses" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 191, "Fifteen Purple Flowers" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 34, "An army of Microscopic Houses" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 232, "A bunch of Microscopic Houses" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 36, "A herd of Orange Planets" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 84, "Fifteen Green Buildings" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 128, "Fifteen Purple Houses" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 197, "Two Purple Planets" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 128, "An army of Green Leopards" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 118, "Fifteen Large Flowers" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 54, "A bunch of Rose Smelling Cars" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 4, "Two Large Flowers" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 220, "The Bitter Flowers" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 245, "Two Green Leopards" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 221, "An army of Microscopic Cars" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 12, "An army of Green Buildings" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 4, "Fifteen Microscopic Buildings" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 25, "Two Green Buildings" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 50, "The Purple Leopards" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 206, "Fifteen Rose Smelling Houses" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 11, "An army of Green Houses" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 200, "A bunch of Green Buildings" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 218, "A bunch of Rose Smelling Flowers" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 195, "A bunch of Bitter Buildings" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 61, "The Rose Smelling Buildings" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 101, "Fifteen Microscopic Planets" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 203,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 218, "A herd of Purple Leopards" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 204,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 64, "Several Orange Planets" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 205,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 9, "Fifteen Bitter Leopards" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 206,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 144, "An army of Green Cars" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 207,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 81, "The Bitter Leopards" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 208,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 80, "Several Transparent Cars" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 209,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 152, "Two Purple Leopards" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 210,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 158, "The Purple Flowers" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 211,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 226, "A bunch of Green Leopards" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 212,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 15, "A herd of Purple Cars" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 213,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 242, "An army of Large Houses" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 214,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 180, "An army of Purple Flowers" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 215,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 42, "A bunch of Purple Planets" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 216,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 229, "An army of Bitter Houses" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 217,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 241, "The Rose Smelling Houses" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 218,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 226, "Fifteen Microscopic Planets" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 219,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 104, "The Green Planets" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 220,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 79, "A bunch of Orange Leopards" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 221,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 174, "Fifteen Transparent Buildings" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 222,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 122, "The Green Buildings" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 223,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 117, "Several Purple Planets" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 224,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 51, "Several Orange Leopards" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 225,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 247, "Fifteen Large Cars" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 226,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 172, "A herd of Green Flowers" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 227,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 186, "A herd of Large Planets" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 228,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 62, "Fifteen Purple Buildings" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 229,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 117, "A herd of Large Leopards" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 230,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 83, "Two Transparent Cars" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 231,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 172, "Fifteen Bitter Houses" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 232,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 98, "A bunch of Green Buildings" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 233,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 166, "A bunch of Purple Buildings" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 234,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 89, "Several Transparent Houses" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 235,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 108, "A bunch of Rose Smelling Cars" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 236,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 152, "A herd of Microscopic Cars" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 237,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 171, "Two Bitter Leopards" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 238,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 232, "Several Rose Smelling Houses" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 239,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 222, "Two Orange Houses" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 240,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 75, "The Orange Flowers" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 241,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 86, "A bunch of Rose Smelling Flowers" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 242,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 145, "An army of Bitter Planets" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 243,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 38, "Two Orange Leopards" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 244,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 164, "Two Transparent Buildings" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 245,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 99, "Fifteen Purple Flowers" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 246,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 176, "Fifteen Purple Cars" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 247,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 76, "Several Rose Smelling Houses" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 248,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 46, "The Orange Planets" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 249,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 178, "A herd of Large Houses" });

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Authors_AuthorId",
                table: "Books",
                column: "AuthorId",
                principalTable: "Authors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
