using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace exercise.webapi.Migrations
{
    /// <inheritdoc />
    public partial class constraintForeignKey : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "elvis.winfrey@nasa.org.us", "Elvis", "Winfrey" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.trump@gov.ru", "Kate", "Trump" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "oprah.winfrey@gov.ru", "Oprah", "Winfrey" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "oprah.jagger@tesla.com", "Oprah", "Jagger" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "jimi.jagger@gov.nl", "Jimi", "Jagger" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "donald.jagger@bbc.co.uk", "Donald", "Jagger" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "barack.obama@theworld.ca", "Barack", "Obama" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "charles.middleton@something.com", "Charles", "Middleton" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "charles.hendrix@nasa.org.us", "Charles", "Hendrix" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "oprah.hendrix@tesla.com", "Oprah", "Hendrix" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "oprah.presley@tesla.com", "Oprah", "Presley" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.hendrix@theworld.ca", "Kate", "Hendrix" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "mick.trump@gov.us", "Mick", "Trump" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "email", "first_name" },
                values: new object[] { "barack.obama@google.com", "Barack" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "charles.jagger@gov.us", "Charles", "Jagger" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "email", "last_name" },
                values: new object[] { "jimi.hepburn@nasa.org.us", "Hepburn" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "jimi.trump@google.com", "Jimi", "Trump" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "email", "first_name" },
                values: new object[] { "charles.obama@gov.gr", "Charles" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "donald.trump@gov.us", "Donald", "Trump" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "charles.obama@tesla.com", "Charles", "Obama" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "mick.middleton@google.com", "Mick", "Middleton" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "email", "first_name" },
                values: new object[] { "elvis.trump@theworld.ca", "Elvis" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "elvis.hendrix@gov.ru", "Elvis", "Hendrix" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "email", "first_name" },
                values: new object[] { "kate.windsor@gov.ru", "Kate" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "email", "last_name" },
                values: new object[] { "jimi.presley@bbc.co.uk", "Presley" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.winfrey@gov.ru", "Kate", "Winfrey" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "jimi.jagger@something.com", "Jimi", "Jagger" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "email", "last_name" },
                values: new object[] { "donald.obama@nasa.org.us", "Obama" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "audrey.middleton@nasa.org.us", "Audrey", "Middleton" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "audrey.jagger@tesla.com", "Audrey", "Jagger" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.hendrix@tesla.com", "Kate", "Hendrix" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.hendrix@gov.us", "Kate", "Hendrix" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 33,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "barack.winslet@theworld.ca", "Barack", "Winslet" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 34,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "donald.winslet@theworld.ca", "Donald", "Winslet" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 35,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "jimi.winfrey@gov.us", "Jimi", "Winfrey" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 36,
                columns: new[] { "email", "last_name" },
                values: new object[] { "oprah.middleton@nasa.org.us", "Middleton" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 37,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.presley@gov.us", "Kate", "Presley" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 38,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "oprah.hepburn@gov.gr", "Oprah", "Hepburn" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 39,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "mick.presley@gov.ru", "Mick", "Presley" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 40,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.winfrey@nasa.org.us", "Kate", "Winfrey" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 41,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "oprah.trump@google.com", "Oprah", "Trump" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 42,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "mick.obama@gov.ru", "Mick", "Obama" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 43,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "elvis.hepburn@nasa.org.us", "Elvis", "Hepburn" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 44,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "jimi.middleton@gov.ru", "Jimi", "Middleton" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 45,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "barack.presley@tesla.com", "Barack", "Presley" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 46,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "elvis.trump@gov.ru", "Elvis", "Trump" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 47,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "charles.winfrey@tesla.com", "Charles", "Winfrey" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 48,
                columns: new[] { "email", "first_name" },
                values: new object[] { "barack.jagger@google.com", "Barack" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 49,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "mick.hepburn@gov.gr", "Mick", "Hepburn" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 50,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.presley@theworld.ca", "Kate", "Presley" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 51,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "donald.middleton@gov.us", "Donald", "Middleton" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 52,
                columns: new[] { "email", "last_name" },
                values: new object[] { "donald.winslet@tesla.com", "Winslet" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 53,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "mick.middleton@gov.us", "Mick", "Middleton" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 54,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "elvis.windsor@theworld.ca", "Elvis", "Windsor" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 55,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "charles.trump@gov.us", "Charles", "Trump" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 56,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "jimi.winslet@bbc.co.uk", "Jimi", "Winslet" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 57,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "jimi.middleton@something.com", "Jimi", "Middleton" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 58,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "donald.windsor@tesla.com", "Donald", "Windsor" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 59,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.trump@bbc.co.uk", "Kate", "Trump" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 60,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "oprah.trump@gov.ru", "Oprah", "Trump" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 61,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "jimi.winslet@nasa.org.us", "Jimi", "Winslet" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 62,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "jimi.windsor@theworld.ca", "Jimi", "Windsor" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 63,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "charles.middleton@bbc.co.uk", "Charles", "Middleton" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 64,
                columns: new[] { "email", "last_name" },
                values: new object[] { "audrey.winfrey@gov.gr", "Winfrey" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 65,
                columns: new[] { "email", "first_name" },
                values: new object[] { "audrey.hendrix@google.com", "Audrey" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 66,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "audrey.trump@tesla.com", "Audrey", "Trump" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 67,
                columns: new[] { "email", "last_name" },
                values: new object[] { "audrey.windsor@gov.gr", "Windsor" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 68,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "oprah.hepburn@nasa.org.us", "Oprah", "Hepburn" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 69,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "oprah.hepburn@gov.nl", "Oprah", "Hepburn" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 70,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "jimi.jagger@tesla.com", "Jimi", "Jagger" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 71,
                columns: new[] { "email", "last_name" },
                values: new object[] { "kate.obama@gov.us", "Obama" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 72,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "barack.winslet@google.com", "Barack", "Winslet" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 73,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.presley@gov.gr", "Kate", "Presley" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 74,
                columns: new[] { "email", "first_name" },
                values: new object[] { "barack.hendrix@gov.ru", "Barack" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 75,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "jimi.hepburn@bbc.co.uk", "Jimi", "Hepburn" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 76,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "oprah.middleton@bbc.co.uk", "Oprah", "Middleton" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 77,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "jimi.hepburn@nasa.org.us", "Jimi", "Hepburn" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 78,
                columns: new[] { "email", "last_name" },
                values: new object[] { "kate.windsor@something.com", "Windsor" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 79,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "charles.hepburn@something.com", "Charles", "Hepburn" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 80,
                columns: new[] { "email", "last_name" },
                values: new object[] { "barack.winslet@google.com", "Winslet" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 81,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "jimi.trump@something.com", "Jimi", "Trump" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 82,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "mick.presley@gov.gr", "Mick", "Presley" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 83,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "mick.middleton@google.com", "Mick", "Middleton" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 84,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "charles.trump@gov.gr", "Charles", "Trump" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 85,
                column: "email",
                value: "kate.winfrey@something.com");

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 86,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "elvis.hendrix@gov.gr", "Elvis", "Hendrix" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 87,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "audrey.hendrix@theworld.ca", "Audrey", "Hendrix" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 88,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.windsor@gov.ru", "Kate", "Windsor" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 89,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "elvis.winfrey@theworld.ca", "Elvis", "Winfrey" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 90,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "barack.jagger@bbc.co.uk", "Barack", "Jagger" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 91,
                columns: new[] { "email", "last_name" },
                values: new object[] { "elvis.hepburn@gov.ru", "Hepburn" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 92,
                columns: new[] { "email", "first_name" },
                values: new object[] { "charles.middleton@gov.gr", "Charles" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 93,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "barack.winfrey@gov.ru", "Barack", "Winfrey" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 94,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "audrey.jagger@gov.us", "Audrey", "Jagger" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 95,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "barack.winslet@theworld.ca", "Barack", "Winslet" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 96,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "audrey.obama@gov.nl", "Audrey", "Obama" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 97,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "elvis.hepburn@gov.gr", "Elvis", "Hepburn" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 98,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "elvis.windsor@something.com", "Elvis", "Windsor" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 99,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.trump@theworld.ca", "Kate", "Trump" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 100,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "barack.trump@nasa.org.us", "Barack", "Trump" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 101,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.hepburn@gov.nl", "Kate", "Hepburn" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 102,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.presley@something.com", "Kate", "Presley" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 103,
                columns: new[] { "email", "last_name" },
                values: new object[] { "charles.windsor@gov.nl", "Windsor" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 104,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "mick.presley@gov.nl", "Mick", "Presley" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 105,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "jimi.winslet@google.com", "Jimi", "Winslet" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 106,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "jimi.winslet@bbc.co.uk", "Jimi", "Winslet" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 107,
                columns: new[] { "email", "first_name" },
                values: new object[] { "kate.presley@google.com", "Kate" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 108,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "barack.trump@gov.nl", "Barack", "Trump" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 109,
                columns: new[] { "email", "last_name" },
                values: new object[] { "mick.winslet@tesla.com", "Winslet" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 110,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.jagger@something.com", "Kate", "Jagger" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 111,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "charles.hendrix@something.com", "Charles", "Hendrix" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 112,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.trump@tesla.com", "Kate", "Trump" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 113,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "charles.jagger@something.com", "Charles", "Jagger" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 114,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "jimi.trump@nasa.org.us", "Jimi", "Trump" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 115,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "barack.obama@something.com", "Barack", "Obama" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 116,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "audrey.winfrey@something.com", "Audrey", "Winfrey" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 117,
                columns: new[] { "email", "last_name" },
                values: new object[] { "mick.trump@nasa.org.us", "Trump" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 118,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "oprah.middleton@gov.nl", "Oprah", "Middleton" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 119,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "oprah.trump@gov.ru", "Oprah", "Trump" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 120,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "elvis.hendrix@gov.us", "Elvis", "Hendrix" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 121,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "mick.jagger@gov.ru", "Mick", "Jagger" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 122,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "donald.windsor@theworld.ca", "Donald", "Windsor" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 123,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "audrey.windsor@google.com", "Audrey", "Windsor" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 124,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "elvis.winslet@gov.us", "Elvis", "Winslet" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 125,
                columns: new[] { "email", "first_name" },
                values: new object[] { "charles.winslet@gov.gr", "Charles" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 126,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.middleton@gov.us", "Kate", "Middleton" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 127,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "audrey.winfrey@theworld.ca", "Audrey", "Winfrey" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 128,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "elvis.jagger@tesla.com", "Elvis", "Jagger" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 129,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "mick.hepburn@something.com", "Mick", "Hepburn" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 130,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "charles.winfrey@gov.gr", "Charles", "Winfrey" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 131,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "audrey.winfrey@something.com", "Audrey", "Winfrey" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 132,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "barack.presley@bbc.co.uk", "Barack", "Presley" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 133,
                columns: new[] { "email", "first_name" },
                values: new object[] { "oprah.hepburn@nasa.org.us", "Oprah" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 134,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "jimi.hendrix@gov.nl", "Jimi", "Hendrix" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 135,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "oprah.trump@bbc.co.uk", "Oprah", "Trump" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 136,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "donald.middleton@something.com", "Donald", "Middleton" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 137,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "oprah.winfrey@tesla.com", "Oprah", "Winfrey" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 138,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "audrey.obama@nasa.org.us", "Audrey", "Obama" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 139,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "charles.presley@gov.nl", "Charles", "Presley" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 140,
                columns: new[] { "email", "last_name" },
                values: new object[] { "kate.winslet@theworld.ca", "Winslet" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 141,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "oprah.hendrix@gov.us", "Oprah", "Hendrix" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 142,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "oprah.presley@theworld.ca", "Oprah", "Presley" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 143,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "elvis.windsor@gov.us", "Elvis", "Windsor" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 144,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "elvis.windsor@nasa.org.us", "Elvis", "Windsor" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 145,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.middleton@gov.gr", "Kate", "Middleton" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 146,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "barack.obama@nasa.org.us", "Barack", "Obama" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 147,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "oprah.middleton@tesla.com", "Oprah", "Middleton" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 148,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "audrey.windsor@tesla.com", "Audrey", "Windsor" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 149,
                columns: new[] { "email", "last_name" },
                values: new object[] { "elvis.winslet@gov.gr", "Winslet" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 150,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.jagger@bbc.co.uk", "Kate", "Jagger" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 151,
                columns: new[] { "email", "first_name" },
                values: new object[] { "mick.middleton@something.com", "Mick" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 152,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "barack.winfrey@tesla.com", "Barack", "Winfrey" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 153,
                columns: new[] { "email", "last_name" },
                values: new object[] { "charles.hepburn@gov.nl", "Hepburn" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 154,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "jimi.hendrix@tesla.com", "Jimi", "Hendrix" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 155,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "mick.trump@google.com", "Mick", "Trump" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 156,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "audrey.hepburn@gov.ru", "Audrey", "Hepburn" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 157,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "jimi.hepburn@gov.gr", "Jimi", "Hepburn" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 158,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "jimi.hendrix@tesla.com", "Jimi", "Hendrix" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 159,
                columns: new[] { "email", "first_name" },
                values: new object[] { "kate.winslet@something.com", "Kate" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 160,
                columns: new[] { "email", "first_name" },
                values: new object[] { "audrey.obama@gov.us", "Audrey" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 161,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "oprah.trump@gov.ru", "Oprah", "Trump" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 162,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "mick.middleton@something.com", "Mick", "Middleton" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 163,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "donald.trump@gov.gr", "Donald", "Trump" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 164,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.obama@tesla.com", "Kate", "Obama" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 165,
                columns: new[] { "email", "last_name" },
                values: new object[] { "charles.hendrix@bbc.co.uk", "Hendrix" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 166,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "donald.jagger@gov.us", "Donald", "Jagger" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 167,
                columns: new[] { "email", "last_name" },
                values: new object[] { "kate.presley@gov.us", "Presley" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 168,
                columns: new[] { "email", "last_name" },
                values: new object[] { "kate.middleton@gov.nl", "Middleton" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 169,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.trump@tesla.com", "Kate", "Trump" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 170,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "charles.trump@tesla.com", "Charles", "Trump" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 171,
                columns: new[] { "email", "last_name" },
                values: new object[] { "kate.jagger@tesla.com", "Jagger" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 172,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "donald.winfrey@tesla.com", "Donald", "Winfrey" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 173,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "audrey.trump@bbc.co.uk", "Audrey", "Trump" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 174,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "donald.obama@google.com", "Donald", "Obama" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 175,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.obama@gov.nl", "Kate", "Obama" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 176,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "donald.hendrix@google.com", "Donald", "Hendrix" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 177,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "jimi.jagger@tesla.com", "Jimi", "Jagger" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 178,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "charles.winslet@nasa.org.us", "Charles", "Winslet" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 179,
                columns: new[] { "email", "last_name" },
                values: new object[] { "kate.presley@nasa.org.us", "Presley" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 180,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.middleton@bbc.co.uk", "Kate", "Middleton" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 181,
                column: "email",
                value: "elvis.windsor@gov.ru");

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 182,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "donald.winslet@gov.gr", "Donald", "Winslet" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 183,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "jimi.trump@nasa.org.us", "Jimi", "Trump" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 184,
                columns: new[] { "email", "last_name" },
                values: new object[] { "jimi.middleton@google.com", "Middleton" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 185,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.jagger@theworld.ca", "Kate", "Jagger" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 186,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "barack.presley@gov.gr", "Barack", "Presley" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 187,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "oprah.windsor@tesla.com", "Oprah", "Windsor" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 188,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "barack.jagger@bbc.co.uk", "Barack", "Jagger" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 189,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "elvis.obama@gov.gr", "Elvis", "Obama" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 190,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.hepburn@nasa.org.us", "Kate", "Hepburn" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 191,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "mick.jagger@tesla.com", "Mick", "Jagger" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 192,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.hendrix@gov.us", "Kate", "Hendrix" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 193,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "charles.windsor@something.com", "Charles", "Windsor" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 194,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "audrey.jagger@gov.nl", "Audrey", "Jagger" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 195,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "donald.hepburn@gov.nl", "Donald", "Hepburn" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 196,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "mick.obama@gov.ru", "Mick", "Obama" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 197,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "elvis.hendrix@gov.ru", "Elvis", "Hendrix" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 198,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.presley@google.com", "Kate", "Presley" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 199,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "audrey.hepburn@gov.us", "Audrey", "Hepburn" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 200,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "audrey.middleton@gov.nl", "Audrey", "Middleton" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 201,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "mick.presley@theworld.ca", "Mick", "Presley" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 202,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.windsor@google.com", "Kate", "Windsor" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 203,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.presley@gov.ru", "Kate", "Presley" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 204,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "oprah.hendrix@theworld.ca", "Oprah", "Hendrix" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 205,
                column: "email",
                value: "kate.obama@bbc.co.uk");

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 206,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "charles.jagger@google.com", "Charles", "Jagger" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 207,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "charles.middleton@gov.nl", "Charles", "Middleton" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 208,
                columns: new[] { "email", "first_name" },
                values: new object[] { "oprah.obama@tesla.com", "Oprah" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 209,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "charles.hendrix@google.com", "Charles", "Hendrix" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 210,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "oprah.winslet@theworld.ca", "Oprah", "Winslet" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 211,
                columns: new[] { "email", "first_name" },
                values: new object[] { "audrey.hepburn@bbc.co.uk", "Audrey" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 212,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.hendrix@google.com", "Kate", "Hendrix" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 213,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "donald.presley@gov.us", "Donald", "Presley" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 214,
                columns: new[] { "email", "first_name" },
                values: new object[] { "kate.windsor@gov.us", "Kate" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 215,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.obama@gov.gr", "Kate", "Obama" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 216,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "elvis.winfrey@gov.us", "Elvis", "Winfrey" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 217,
                columns: new[] { "email", "first_name" },
                values: new object[] { "kate.jagger@gov.gr", "Kate" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 218,
                columns: new[] { "email", "first_name" },
                values: new object[] { "kate.middleton@gov.us", "Kate" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 219,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "oprah.presley@gov.ru", "Oprah", "Presley" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 220,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "barack.hepburn@gov.gr", "Barack", "Hepburn" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 221,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "barack.middleton@bbc.co.uk", "Barack", "Middleton" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 222,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.presley@nasa.org.us", "Kate", "Presley" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 223,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.winslet@gov.nl", "Kate", "Winslet" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 224,
                columns: new[] { "email", "first_name" },
                values: new object[] { "charles.hendrix@gov.gr", "Charles" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 225,
                column: "email",
                value: "kate.hendrix@gov.gr");

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 226,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "mick.hendrix@gov.nl", "Mick", "Hendrix" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 227,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "charles.presley@nasa.org.us", "Charles", "Presley" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 228,
                columns: new[] { "email", "last_name" },
                values: new object[] { "mick.winfrey@gov.us", "Winfrey" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 229,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.hepburn@bbc.co.uk", "Kate", "Hepburn" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 230,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "oprah.hendrix@something.com", "Oprah", "Hendrix" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 231,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "donald.presley@nasa.org.us", "Donald", "Presley" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 232,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "mick.middleton@tesla.com", "Mick", "Middleton" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 233,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "barack.winslet@something.com", "Barack", "Winslet" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 234,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "donald.winslet@something.com", "Donald", "Winslet" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 235,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "elvis.middleton@gov.ru", "Elvis", "Middleton" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 236,
                column: "email",
                value: "donald.windsor@gov.nl");

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 237,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "jimi.hepburn@gov.gr", "Jimi", "Hepburn" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 238,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "oprah.obama@theworld.ca", "Oprah", "Obama" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 239,
                columns: new[] { "email", "last_name" },
                values: new object[] { "donald.winfrey@nasa.org.us", "Winfrey" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 240,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "mick.middleton@theworld.ca", "Mick", "Middleton" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 241,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "oprah.jagger@theworld.ca", "Oprah", "Jagger" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 242,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "oprah.winslet@tesla.com", "Oprah", "Winslet" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 243,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "mick.hepburn@tesla.com", "Mick", "Hepburn" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 244,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "barack.jagger@nasa.org.us", "Barack", "Jagger" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 245,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "audrey.winslet@something.com", "Audrey", "Winslet" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 246,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "jimi.hendrix@theworld.ca", "Jimi", "Hendrix" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 247,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "oprah.hendrix@google.com", "Oprah", "Hendrix" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 248,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.winslet@google.com", "Kate", "Winslet" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 249,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "audrey.obama@something.com", "Audrey", "Obama" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 187, 163, "An army of Orange Leopards" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 201, 233, "The Rose Smelling Leopards" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 195, 159, "The Microscopic Flowers" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 48, 90, "Fifteen Bitter Flowers" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 119, 186, "Fifteen Purple Flowers" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 14, 61, "A bunch of Green Cars" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 216, 81, "An army of Transparent Flowers" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 183, 112, "Fifteen Orange Flowers" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 129, 134, "Several Orange Flowers" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 140, 110, "Fifteen Rose Smelling Houses" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 180, 240, "Two Microscopic Planets" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 121, 87, "The Purple Planets" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 6, 6, "Fifteen Purple Flowers" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 201, 158, "A bunch of Bitter Houses" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 12, 111, "An army of Purple Planets" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 137, 26, "Several Purple Cars" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 41, 99, "A bunch of Rose Smelling Leopards" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 166, 129, "Several Purple Flowers" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 61, 154, "Fifteen Purple Planets" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 175, 80, "An army of Purple Planets" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 161, 7, "The Orange Flowers" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 71, 20, "A herd of Purple Houses" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 127, 119, "Fifteen Green Buildings" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 76, 184, "Several Microscopic Leopards" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 197, 107, "The Large Cars" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 113, 191, "Several Orange Houses" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 135, 55, "A herd of Rose Smelling Houses" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 89, 97, "An army of Large Houses" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 27, 170, "An army of Large Leopards" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 11, 45, "The Purple Buildings" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 29, 129, "A bunch of Large Flowers" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 216, 21, "The Rose Smelling Buildings" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 33,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 132, 94, "Fifteen Purple Buildings" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 34,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 4, 199, "A herd of Orange Houses" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 35,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 92, 13, "An army of Green Planets" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 36,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 27, 136, "A herd of Green Cars" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 37,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 245, 25, "Fifteen Bitter Cars" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 38,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 10, 31, "A bunch of Bitter Flowers" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 39,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 180, 209, "A herd of Transparent Leopards" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 40,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 164, 201, "The Large Leopards" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 41,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 149, 182, "Two Bitter Planets" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 42,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 82, 6, "An army of Transparent Flowers" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 43,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 145, 89, "Fifteen Green Planets" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 44,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 5, 135, "A bunch of Orange Houses" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 45,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 118, 248, "An army of Transparent Leopards" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 46,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 61, 79, "Fifteen Green Planets" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 47,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 161, 57, "Fifteen Microscopic Buildings" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 48,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 59, 1, "Two Bitter Planets" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 49,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 80, 185, "Several Transparent Buildings" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 50,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 1, 167, "The Large Flowers" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 51,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 124, 97, "Fifteen Rose Smelling Flowers" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 52,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 18, 99, "The Transparent Planets" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 53,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 96, 248, "A bunch of Purple Buildings" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 54,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 158, 145, "A herd of Bitter Houses" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 55,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 53, 83, "Two Orange Flowers" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 56,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 222, 91, "Fifteen Large Houses" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 57,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 61, 96, "A herd of Large Flowers" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 58,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 54, 225, "Several Purple Houses" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 59,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 12, 224, "Fifteen Microscopic Buildings" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 60,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 39, 145, "A bunch of Microscopic Cars" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 61,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 2, 129, "Two Microscopic Houses" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 62,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 83, 167, "An army of Bitter Planets" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 63,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 122, 238, "Fifteen Bitter Cars" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 64,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 227, 56, "The Microscopic Planets" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 65,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 171, 96, "Several Bitter Buildings" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 66,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 80, 223, "An army of Transparent Houses" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 67,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 212, 27, "A herd of Large Leopards" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 68,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 89, 76, "Several Green Flowers" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 69,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 123, 134, "Several Orange Buildings" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 70,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 69, 14, "Several Transparent Leopards" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 71,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 50, 217, "Several Transparent Houses" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 72,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 111, 160, "An army of Transparent Cars" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 73,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 230, 189, "An army of Orange Planets" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 74,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 165, 6, "Two Purple Houses" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 75,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 171, 29, "Two Bitter Flowers" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 76,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 80, 172, "Two Large Flowers" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 77,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 92, 87, "A herd of Microscopic Leopards" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 78,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 138, 142, "A bunch of Microscopic Planets" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 79,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 6, 58, "An army of Orange Flowers" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 80,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 137, 21, "The Purple Leopards" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 81,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 154, 95, "An army of Green Buildings" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 82,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 227, 141, "A herd of Green Flowers" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 83,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 129, 159, "A herd of Large Flowers" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 84,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 133, 3, "An army of Microscopic Flowers" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 85,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 2, 203, "Several Purple Leopards" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 86,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 194, 55, "A bunch of Microscopic Cars" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 87,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 15, 215, "An army of Orange Leopards" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 88,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 84, 248, "A herd of Large Flowers" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 89,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 128, 29, "A bunch of Large Houses" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 90,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 23, 39, "Fifteen Rose Smelling Houses" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 91,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 48, 63, "The Orange Cars" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 92,
                columns: new[] { "publisher_id", "title" },
                values: new object[] { 172, "Several Orange Cars" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 93,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 129, 164, "A bunch of Microscopic Flowers" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 94,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 47, 94, "A bunch of Orange Buildings" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 95,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 104, 115, "Two Transparent Buildings" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 96,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 83, 96, "Fifteen Bitter Houses" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 97,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 140, 209, "Fifteen Purple Houses" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 98,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 237, 128, "A herd of Purple Houses" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 99,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 17, 122, "Two Green Leopards" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 100,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 79, 219, "An army of Green Cars" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 101,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 120, 6, "A bunch of Bitter Leopards" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 102,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 30, 80, "A herd of Rose Smelling Leopards" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 103,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 148, 91, "Fifteen Microscopic Houses" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 104,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 195, 10, "Two Bitter Houses" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 105,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 147, 118, "An army of Purple Flowers" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 106,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 125, 151, "Two Rose Smelling Cars" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 107,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 181, 247, "An army of Orange Leopards" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 108,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 60, 236, "Two Orange Planets" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 109,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 127, 179, "Several Large Planets" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 110,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 181, 106, "An army of Green Houses" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 111,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 189, 39, "Several Microscopic Flowers" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 112,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 82, 103, "Two Green Leopards" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 113,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 144, 67, "The Microscopic Planets" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 114,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 126, 94, "Several Green Cars" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 115,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 142, 97, "A bunch of Green Flowers" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 116,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 131, 29, "An army of Microscopic Planets" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 117,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 97, 181, "An army of Purple Leopards" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 118,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 27, 213, "The Green Buildings" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 119,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 218, 211, "The Rose Smelling Planets" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 120,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 126, 58, "The Rose Smelling Leopards" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 121,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 53, 145, "An army of Purple Planets" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 122,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 206, 50, "A herd of Rose Smelling Planets" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 123,
                columns: new[] { "author_id", "publisher_id" },
                values: new object[] { 21, 199 });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 124,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 94, 82, "Two Rose Smelling Cars" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 125,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 35, 95, "Two Green Houses" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 126,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 11, 89, "A herd of Bitter Flowers" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 127,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 193, 134, "A herd of Large Houses" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 128,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 213, 191, "A bunch of Large Cars" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 129,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 180, 216, "A bunch of Bitter Leopards" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 130,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 96, 40, "A herd of Large Buildings" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 131,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 206, 147, "Two Rose Smelling Cars" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 132,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 55, 32, "A bunch of Bitter Flowers" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 133,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 18, 217, "Two Purple Cars" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 134,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 170, 94, "Several Large Leopards" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 135,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 102, 79, "Two Large Flowers" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 136,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 181, 62, "Fifteen Purple Houses" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 137,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 175, 99, "The Purple Cars" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 138,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 235, 29, "A bunch of Green Houses" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 139,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 153, 45, "Two Purple Leopards" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 140,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 237, 22, "An army of Rose Smelling Buildings" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 141,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 71, 100, "Several Bitter Houses" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 142,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 131, 121, "A herd of Transparent Flowers" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 143,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 117, 171, "An army of Green Buildings" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 144,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 236, 83, "A bunch of Rose Smelling Flowers" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 145,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 237, 220, "Several Green Leopards" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 146,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 159, 26, "A herd of Bitter Cars" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 147,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 127, 228, "A herd of Bitter Houses" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 148,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 243, 27, "The Orange Flowers" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 149,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 49, 215, "An army of Rose Smelling Cars" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 150,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 21, 99, "An army of Large Leopards" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 151,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 182, 28, "A herd of Bitter Planets" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 152,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 107, 182, "A herd of Purple Flowers" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 153,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 245, 220, "Two Orange Leopards" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 154,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 82, 62, "A herd of Microscopic Leopards" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 155,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 87, 83, "The Purple Planets" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 156,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 83, 207, "The Bitter Planets" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 157,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 164, 96, "Fifteen Bitter Leopards" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 158,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 178, 156, "Several Green Houses" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 159,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 238, 186, "A bunch of Transparent Planets" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 160,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 55, 59, "A herd of Microscopic Flowers" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 161,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 11, 42, "The Rose Smelling Flowers" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 162,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 246, 92, "An army of Transparent Leopards" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 163,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 87, 106, "An army of Bitter Flowers" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 164,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 116, 146, "The Purple Houses" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 165,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 246, 61, "Two Transparent Leopards" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 166,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 82, 220, "The Purple Leopards" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 167,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 138, 117, "A herd of Orange Leopards" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 168,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 15, 157, "A herd of Green Cars" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 169,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 75, 124, "Fifteen Microscopic Houses" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 170,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 81, 157, "Two Bitter Buildings" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 171,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 44, 207, "Two Bitter Buildings" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 172,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 120, 34, "Fifteen Green Leopards" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 173,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 9, 76, "A herd of Bitter Flowers" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 174,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 23, 65, "A herd of Microscopic Leopards" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 175,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 105, 65, "A herd of Microscopic Planets" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 176,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 119, 124, "A bunch of Orange Flowers" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 177,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 29, 198, "Fifteen Orange Leopards" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 178,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 120, 212, "Two Microscopic Buildings" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 179,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 80, 152, "Two Rose Smelling Leopards" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 180,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 30, 182, "An army of Green Leopards" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 181,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 63, 151, "A bunch of Orange Houses" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 182,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 221, 69, "The Orange Flowers" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 183,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 86, 241, "A bunch of Microscopic Buildings" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 184,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 104, 68, "The Orange Flowers" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 185,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 166, 96, "Several Green Leopards" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 186,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 55, 249, "An army of Rose Smelling Planets" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 187,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 138, 207, "Several Microscopic Planets" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 188,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 151, 191, "Several Rose Smelling Planets" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 189,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 52, 45, "The Large Buildings" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 190,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 81, 151, "The Green Planets" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 191,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 220, 60, "Fifteen Rose Smelling Houses" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 192,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 106, 211, "An army of Purple Planets" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 193,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 174, 18, "Fifteen Large Houses" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 194,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 97, 16, "A bunch of Transparent Leopards" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 195,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 231, 212, "A herd of Bitter Planets" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 196,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 18, 161, "Two Rose Smelling Flowers" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 197,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 158, 201, "Two Green Buildings" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 198,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 3, 44, "The Rose Smelling Buildings" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 199,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 41, 225, "Two Bitter Cars" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 200,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 152, 125, "Several Purple Cars" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 201,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 149, 30, "A bunch of Large Cars" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 202,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 149, 5, "The Purple Cars" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 203,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 153, 93, "Two Purple Planets" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 204,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 21, 124, "An army of Green Leopards" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 205,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 88, 141, "The Microscopic Cars" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 206,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 64, 70, "Two Rose Smelling Flowers" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 207,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 152, 234, "A bunch of Microscopic Flowers" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 208,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 86, 105, "A herd of Bitter Leopards" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 209,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 122, 163, "An army of Bitter Planets" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 210,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 155, 96, "The Orange Cars" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 211,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 78, 227, "A bunch of Microscopic Houses" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 212,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 157, 152, "A herd of Purple Cars" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 213,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 123, 201, "A bunch of Bitter Leopards" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 214,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 213, 186, "Several Microscopic Houses" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 215,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 122, 164, "A herd of Green Buildings" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 216,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 214, 24, "The Bitter Buildings" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 217,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 143, 18, "Several Transparent Cars" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 218,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 211, 147, "Several Bitter Flowers" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 219,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 138, 78, "Fifteen Microscopic Buildings" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 220,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 53, 35, "Two Microscopic Leopards" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 221,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 189, 126, "The Purple Leopards" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 222,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 244, 135, "A herd of Large Buildings" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 223,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 17, 246, "The Rose Smelling Leopards" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 224,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 245, 183, "A herd of Orange Cars" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 225,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 124, 45, "A herd of Green Houses" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 226,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 114, 192, "Fifteen Bitter Leopards" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 227,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 132, 220, "A herd of Large Cars" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 228,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 110, 13, "The Rose Smelling Leopards" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 229,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 242, 198, "The Purple Buildings" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 230,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 145, 95, "Fifteen Transparent Planets" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 231,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 148, 214, "Fifteen Green Cars" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 232,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 183, 44, "A bunch of Large Cars" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 233,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 88, 193, "The Orange Leopards" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 234,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 216, 215, "Several Microscopic Flowers" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 235,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 104, 195, "A herd of Purple Flowers" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 236,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 205, 67, "A bunch of Green Buildings" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 237,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 183, 191, "A herd of Transparent Houses" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 238,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 233, 123, "A bunch of Orange Leopards" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 239,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 21, 128, "A bunch of Green Flowers" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 240,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 211, 102, "The Microscopic Cars" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 241,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 224, 18, "A herd of Bitter Flowers" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 242,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 207, 170, "An army of Microscopic Buildings" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 243,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 187, 247, "Fifteen Transparent Flowers" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 244,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 52, 9, "A herd of Orange Planets" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 245,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 249, 152, "Two Green Buildings" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 246,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 139, 178, "Several Microscopic Cars" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 247,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 129, 208, "Several Large Houses" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 248,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 240, 47, "An army of Rose Smelling Buildings" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 249,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 203, 66, "An army of Purple Leopards" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "bitter@google.com", "Cars Two" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "bitter@nasa.org.us", "Leopards An army of" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "purple@tesla.com", "Planets A bunch of" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "bitter@gov.gr", "Planets Several" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 5,
                column: "name",
                value: "Flowers A herd of");

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "purple@google.com", "Leopards Fifteen" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "purple@something.com", "Buildings Fifteen" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "large@gov.gr", "Planets A bunch of" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "microscopic@nasa.org.us", "Planets Fifteen" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "purple@google.com", "Houses An army of" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "microscopic@bbc.co.uk", "Houses A herd of" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "large@something.com", "Buildings Two" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "green@gov.ru", "Cars The" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "orange@something.com", "Buildings Fifteen" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "large@bbc.co.uk", "Cars An army of" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "bitter@gov.us", "Leopards Fifteen" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "green@theworld.ca", "Flowers A herd of" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "orange@google.com", "Houses Fifteen" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "bitter@tesla.com", "Leopards An army of" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "microscopic@tesla.com", "Cars The" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "bitter@gov.gr", "Buildings Fifteen" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "orange@gov.nl", "Cars A bunch of" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "green@gov.nl", "Houses A herd of" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "transparent@nasa.org.us", "Flowers Fifteen" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "microscopic@theworld.ca", "Planets Fifteen" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "bitter@gov.gr", "Leopards Fifteen" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "rose smelling@theworld.ca", "Flowers An army of" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "bitter@bbc.co.uk", "Flowers A bunch of" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "transparent@nasa.org.us", "Leopards An army of" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "rose smelling@theworld.ca", "Houses Two" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "rose smelling@google.com", "Flowers The" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "green@theworld.ca", "Houses Several" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 33,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "transparent@bbc.co.uk", "Cars An army of" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 34,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "purple@gov.nl", "Houses A herd of" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 35,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "bitter@gov.gr", "Flowers A herd of" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 36,
                column: "contact_details",
                value: "transparent@theworld.ca");

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 37,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "green@gov.us", "Cars A bunch of" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 38,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "transparent@theworld.ca", "Buildings A herd of" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 39,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "transparent@bbc.co.uk", "Flowers Several" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 40,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "bitter@tesla.com", "Buildings A bunch of" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 41,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "large@something.com", "Houses Fifteen" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 42,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "rose smelling@tesla.com", "Cars A herd of" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 43,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "microscopic@tesla.com", "Houses Fifteen" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 44,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "large@google.com", "Planets An army of" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 45,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "orange@bbc.co.uk", "Leopards Several" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 46,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "large@bbc.co.uk", "Cars A bunch of" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 47,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "purple@gov.nl", "Buildings Two" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 48,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "orange@gov.ru", "Cars Fifteen" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 49,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "purple@bbc.co.uk", "Leopards A herd of" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 50,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "purple@gov.gr", "Houses An army of" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 51,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "rose smelling@something.com", "Buildings A herd of" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 52,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "bitter@nasa.org.us", "Leopards Two" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 53,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "bitter@theworld.ca", "Houses An army of" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 54,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "microscopic@theworld.ca", "Leopards An army of" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 55,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "bitter@theworld.ca", "Flowers Several" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 56,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "transparent@google.com", "Leopards Several" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 57,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "orange@nasa.org.us", "Planets A herd of" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 58,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "orange@something.com", "Buildings The" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 59,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "rose smelling@something.com", "Leopards Two" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 60,
                column: "contact_details",
                value: "orange@google.com");

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 61,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "bitter@something.com", "Cars A bunch of" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 62,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "transparent@gov.gr", "Buildings A bunch of" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 63,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "microscopic@gov.nl", "Buildings An army of" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 64,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "rose smelling@bbc.co.uk", "Flowers The" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 65,
                column: "name",
                value: "Planets A herd of");

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 66,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "orange@gov.nl", "Cars Several" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 67,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "bitter@nasa.org.us", "Cars An army of" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 68,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "microscopic@gov.ru", "Planets A herd of" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 69,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "rose smelling@gov.gr", "Cars Fifteen" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 70,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "bitter@nasa.org.us", "Leopards Fifteen" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 71,
                column: "contact_details",
                value: "large@gov.nl");

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 72,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "large@gov.ru", "Planets A bunch of" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 73,
                column: "contact_details",
                value: "green@tesla.com");

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 74,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "bitter@theworld.ca", "Buildings Several" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 75,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "rose smelling@gov.gr", "Flowers Several" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 76,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "large@tesla.com", "Buildings An army of" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 77,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "rose smelling@something.com", "Flowers The" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 78,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "large@google.com", "Cars Two" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 79,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "rose smelling@something.com", "Buildings A bunch of" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 80,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "bitter@gov.ru", "Buildings Two" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 81,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "microscopic@tesla.com", "Houses A herd of" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 82,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "purple@gov.gr", "Leopards The" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 83,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "transparent@gov.ru", "Houses An army of" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 84,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "green@gov.us", "Buildings An army of" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 85,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "rose smelling@nasa.org.us", "Cars A herd of" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 86,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "green@google.com", "Cars Several" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 87,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "green@tesla.com", "Planets Several" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 88,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "microscopic@gov.ru", "Cars Several" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 89,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "green@gov.ru", "Flowers The" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 90,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "green@theworld.ca", "Flowers Fifteen" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 91,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "rose smelling@google.com", "Cars Fifteen" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 92,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "orange@bbc.co.uk", "Flowers Two" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 93,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "large@something.com", "Cars An army of" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 94,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "microscopic@nasa.org.us", "Planets Two" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 95,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "transparent@theworld.ca", "Buildings A bunch of" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 96,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "orange@gov.nl", "Leopards An army of" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 97,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "microscopic@gov.gr", "Planets An army of" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 98,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "green@gov.ru", "Houses Two" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 99,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "microscopic@nasa.org.us", "Cars The" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 100,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "orange@google.com", "Houses Two" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 101,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "rose smelling@bbc.co.uk", "Buildings The" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 102,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "orange@gov.ru", "Cars Two" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 103,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "orange@nasa.org.us", "Buildings A bunch of" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 104,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "large@gov.nl", "Cars Fifteen" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 105,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "large@nasa.org.us", "Flowers Two" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 106,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "purple@gov.us", "Buildings A bunch of" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 107,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "green@gov.us", "Planets The" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 108,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "purple@nasa.org.us", "Cars An army of" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 109,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "purple@gov.nl", "Cars A bunch of" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 110,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "orange@theworld.ca", "Planets A herd of" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 111,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "bitter@gov.nl", "Flowers A herd of" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 112,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "large@gov.us", "Buildings Fifteen" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 113,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "orange@something.com", "Planets A bunch of" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 114,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "bitter@gov.ru", "Leopards A bunch of" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 115,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "purple@bbc.co.uk", "Flowers Fifteen" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 116,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "orange@gov.nl", "Houses An army of" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 117,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "transparent@tesla.com", "Houses An army of" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 118,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "microscopic@gov.ru", "Houses An army of" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 119,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "microscopic@gov.us", "Buildings The" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 120,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "transparent@bbc.co.uk", "Leopards The" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 121,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "rose smelling@gov.nl", "Cars A bunch of" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 122,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "microscopic@google.com", "Cars A herd of" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 123,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "microscopic@gov.gr", "Cars Fifteen" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 124,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "large@google.com", "Flowers Fifteen" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 125,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "large@tesla.com", "Planets Several" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 126,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "orange@theworld.ca", "Houses A herd of" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 127,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "transparent@gov.gr", "Planets Two" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 128,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "rose smelling@nasa.org.us", "Planets A herd of" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 129,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "microscopic@something.com", "Planets Several" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 130,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "large@theworld.ca", "Leopards Several" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 131,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "microscopic@gov.ru", "Cars Two" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 132,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "orange@theworld.ca", "Houses Fifteen" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 133,
                column: "name",
                value: "Planets The");

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 134,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "large@gov.gr", "Cars An army of" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 135,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "green@nasa.org.us", "Houses A herd of" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 136,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "rose smelling@gov.gr", "Planets A bunch of" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 137,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "orange@google.com", "Flowers An army of" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 138,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "purple@gov.nl", "Flowers Several" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 139,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "transparent@bbc.co.uk", "Flowers Several" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 140,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "purple@something.com", "Cars A bunch of" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 141,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "rose smelling@gov.us", "Cars Fifteen" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 142,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "transparent@nasa.org.us", "Leopards Fifteen" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 143,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "purple@bbc.co.uk", "Cars The" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 144,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "green@something.com", "Leopards Several" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 145,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "large@tesla.com", "Leopards Fifteen" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 146,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "transparent@bbc.co.uk", "Planets Fifteen" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 147,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "purple@gov.ru", "Leopards Two" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 148,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "transparent@gov.us", "Cars Two" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 149,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "orange@tesla.com", "Buildings A herd of" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 150,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "green@google.com", "Houses The" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 151,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "bitter@nasa.org.us", "Cars Fifteen" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 152,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "transparent@bbc.co.uk", "Planets An army of" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 153,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "green@gov.ru", "Planets The" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 154,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "large@gov.gr", "Cars Fifteen" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 155,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "orange@google.com", "Leopards Several" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 156,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "bitter@something.com", "Buildings Two" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 157,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "green@gov.nl", "Buildings Two" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 158,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "large@google.com", "Buildings Two" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 159,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "green@gov.nl", "Houses Fifteen" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 160,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "large@gov.nl", "Planets Fifteen" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 161,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "transparent@google.com", "Leopards Several" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 162,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "rose smelling@theworld.ca", "Planets A bunch of" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 163,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "microscopic@bbc.co.uk", "Planets A bunch of" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 164,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "purple@gov.us", "Flowers Fifteen" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 165,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "bitter@nasa.org.us", "Buildings A herd of" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 166,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "purple@nasa.org.us", "Cars Fifteen" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 167,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "rose smelling@bbc.co.uk", "Leopards A bunch of" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 168,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "green@tesla.com", "Buildings An army of" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 169,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "bitter@gov.nl", "Buildings Fifteen" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 170,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "orange@nasa.org.us", "Planets Two" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 171,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "rose smelling@gov.ru", "Buildings A bunch of" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 172,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "bitter@gov.us", "Flowers A bunch of" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 173,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "green@bbc.co.uk", "Flowers Several" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 174,
                column: "contact_details",
                value: "microscopic@google.com");

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 175,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "purple@nasa.org.us", "Planets Several" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 176,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "rose smelling@theworld.ca", "Cars Several" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 177,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "green@nasa.org.us", "Cars Several" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 178,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "green@nasa.org.us", "Houses Two" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 179,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "purple@bbc.co.uk", "Planets Several" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 180,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "green@something.com", "Buildings Fifteen" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 181,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "large@gov.gr", "Planets Two" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 182,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "microscopic@google.com", "Flowers A bunch of" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 183,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "orange@google.com", "Leopards A herd of" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 184,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "rose smelling@theworld.ca", "Cars A herd of" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 185,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "orange@gov.nl", "Leopards Several" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 186,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "purple@gov.gr", "Leopards Fifteen" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 187,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "microscopic@tesla.com", "Houses A bunch of" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 188,
                column: "name",
                value: "Flowers The");

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 189,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "orange@gov.us", "Buildings An army of" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 190,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "bitter@gov.nl", "Flowers A bunch of" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 191,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "large@tesla.com", "Buildings An army of" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 192,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "microscopic@gov.us", "Houses The" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 193,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "rose smelling@google.com", "Leopards Several" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 194,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "rose smelling@google.com", "Cars A bunch of" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 195,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "purple@gov.ru", "Leopards Two" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 196,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "green@something.com", "Houses A bunch of" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 197,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "purple@gov.nl", "Cars A herd of" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 198,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "transparent@theworld.ca", "Houses The" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 199,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "green@nasa.org.us", "Cars The" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 200,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "microscopic@gov.ru", "Cars An army of" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 201,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "microscopic@gov.ru", "Flowers Fifteen" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 202,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "purple@tesla.com", "Cars A herd of" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 203,
                column: "contact_details",
                value: "transparent@something.com");

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 204,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "bitter@gov.ru", "Flowers A herd of" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 205,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "green@nasa.org.us", "Buildings Two" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 206,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "purple@bbc.co.uk", "Flowers A herd of" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 207,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "bitter@gov.ru", "Leopards Several" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 208,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "orange@google.com", "Planets A bunch of" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 209,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "rose smelling@gov.us", "Houses Fifteen" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 210,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "orange@google.com", "Cars The" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 211,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "orange@nasa.org.us", "Houses A bunch of" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 212,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "large@gov.us", "Houses Two" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 213,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "purple@bbc.co.uk", "Leopards A herd of" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 214,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "microscopic@google.com", "Planets A herd of" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 215,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "purple@nasa.org.us", "Houses A bunch of" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 216,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "bitter@gov.gr", "Leopards The" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 217,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "green@gov.gr", "Houses A bunch of" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 218,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "orange@bbc.co.uk", "Leopards Two" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 219,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "transparent@google.com", "Flowers Several" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 220,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "rose smelling@gov.us", "Planets Fifteen" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 221,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "green@gov.ru", "Houses An army of" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 222,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "large@google.com", "Houses Two" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 223,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "transparent@gov.ru", "Flowers Several" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 224,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "microscopic@something.com", "Buildings A herd of" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 225,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "green@google.com", "Houses The" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 226,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "purple@google.com", "Leopards Two" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 227,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "green@google.com", "Planets Several" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 228,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "bitter@something.com", "Buildings An army of" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 229,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "orange@google.com", "Buildings The" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 230,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "bitter@theworld.ca", "Cars Fifteen" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 231,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "rose smelling@bbc.co.uk", "Houses An army of" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 232,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "rose smelling@gov.us", "Planets The" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 233,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "bitter@something.com", "Buildings A bunch of" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 234,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "microscopic@bbc.co.uk", "Cars The" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 235,
                column: "contact_details",
                value: "transparent@gov.us");

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 236,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "rose smelling@something.com", "Buildings A herd of" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 237,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "rose smelling@tesla.com", "Planets Two" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 238,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "large@nasa.org.us", "Flowers The" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 239,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "rose smelling@gov.nl", "Flowers Fifteen" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 240,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "large@bbc.co.uk", "Flowers Several" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 241,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "orange@tesla.com", "Planets A bunch of" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 242,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "bitter@gov.us", "Planets An army of" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 243,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "microscopic@gov.nl", "Cars A bunch of" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 244,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "orange@bbc.co.uk", "Buildings Two" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 245,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "orange@bbc.co.uk", "Planets Fifteen" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 246,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "green@gov.nl", "Planets The" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 247,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "green@theworld.ca", "Flowers A bunch of" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 248,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "rose smelling@gov.gr", "Houses The" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 249,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "green@gov.nl", "Planets An army of" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "audrey.trump@bbc.co.uk", "Audrey", "Trump" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "mick.windsor@bbc.co.uk", "Mick", "Windsor" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "barack.winslet@theworld.ca", "Barack", "Winslet" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "barack.hepburn@theworld.ca", "Barack", "Hepburn" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "mick.windsor@nasa.org.us", "Mick", "Windsor" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "barack.middleton@theworld.ca", "Barack", "Middleton" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "charles.windsor@gov.nl", "Charles", "Windsor" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "mick.hepburn@nasa.org.us", "Mick", "Hepburn" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "donald.winfrey@theworld.ca", "Donald", "Winfrey" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.hepburn@nasa.org.us", "Kate", "Hepburn" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.windsor@gov.nl", "Kate", "Windsor" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "charles.middleton@gov.gr", "Charles", "Middleton" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.jagger@something.com", "Kate", "Jagger" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "email", "first_name" },
                values: new object[] { "oprah.obama@nasa.org.us", "Oprah" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.presley@gov.gr", "Kate", "Presley" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "email", "last_name" },
                values: new object[] { "jimi.presley@google.com", "Presley" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.jagger@tesla.com", "Kate", "Jagger" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "email", "first_name" },
                values: new object[] { "donald.obama@nasa.org.us", "Donald" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.obama@bbc.co.uk", "Kate", "Obama" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.winfrey@gov.nl", "Kate", "Winfrey" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "donald.presley@gov.ru", "Donald", "Presley" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "email", "first_name" },
                values: new object[] { "kate.trump@tesla.com", "Kate" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.obama@something.com", "Kate", "Obama" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "email", "first_name" },
                values: new object[] { "jimi.windsor@gov.nl", "Jimi" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "email", "last_name" },
                values: new object[] { "jimi.hepburn@nasa.org.us", "Hepburn" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "charles.jagger@gov.us", "Charles", "Jagger" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "barack.presley@gov.nl", "Barack", "Presley" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "email", "last_name" },
                values: new object[] { "donald.trump@gov.gr", "Trump" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "jimi.presley@gov.ru", "Jimi", "Presley" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "mick.winfrey@gov.gr", "Mick", "Winfrey" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "oprah.trump@google.com", "Oprah", "Trump" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "audrey.middleton@tesla.com", "Audrey", "Middleton" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 33,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.hendrix@nasa.org.us", "Kate", "Hendrix" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 34,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "mick.winfrey@gov.gr", "Mick", "Winfrey" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 35,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "mick.trump@gov.gr", "Mick", "Trump" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 36,
                columns: new[] { "email", "last_name" },
                values: new object[] { "oprah.trump@tesla.com", "Trump" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 37,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "jimi.middleton@something.com", "Jimi", "Middleton" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 38,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "mick.obama@google.com", "Mick", "Obama" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 39,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.hendrix@tesla.com", "Kate", "Hendrix" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 40,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "jimi.presley@gov.us", "Jimi", "Presley" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 41,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "donald.presley@gov.ru", "Donald", "Presley" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 42,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "barack.hendrix@bbc.co.uk", "Barack", "Hendrix" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 43,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "donald.winslet@gov.us", "Donald", "Winslet" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 44,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "charles.windsor@gov.us", "Charles", "Windsor" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 45,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "donald.hepburn@gov.nl", "Donald", "Hepburn" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 46,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.windsor@gov.nl", "Kate", "Windsor" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 47,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "donald.presley@bbc.co.uk", "Donald", "Presley" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 48,
                columns: new[] { "email", "first_name" },
                values: new object[] { "oprah.jagger@bbc.co.uk", "Oprah" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 49,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "barack.trump@bbc.co.uk", "Barack", "Trump" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 50,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "jimi.windsor@theworld.ca", "Jimi", "Windsor" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 51,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "elvis.windsor@something.com", "Elvis", "Windsor" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 52,
                columns: new[] { "email", "last_name" },
                values: new object[] { "donald.trump@gov.us", "Trump" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 53,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.jagger@gov.nl", "Kate", "Jagger" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 54,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "oprah.winslet@google.com", "Oprah", "Winslet" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 55,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "barack.winfrey@gov.us", "Barack", "Winfrey" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 56,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "mick.jagger@gov.nl", "Mick", "Jagger" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 57,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "elvis.jagger@nasa.org.us", "Elvis", "Jagger" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 58,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "oprah.winfrey@something.com", "Oprah", "Winfrey" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 59,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "oprah.hendrix@google.com", "Oprah", "Hendrix" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 60,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "donald.hendrix@something.com", "Donald", "Hendrix" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 61,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "donald.presley@bbc.co.uk", "Donald", "Presley" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 62,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "elvis.hepburn@gov.us", "Elvis", "Hepburn" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 63,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "elvis.obama@tesla.com", "Elvis", "Obama" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 64,
                columns: new[] { "email", "last_name" },
                values: new object[] { "audrey.middleton@google.com", "Middleton" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 65,
                columns: new[] { "email", "first_name" },
                values: new object[] { "oprah.hendrix@gov.ru", "Oprah" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 66,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "barack.jagger@google.com", "Barack", "Jagger" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 67,
                columns: new[] { "email", "last_name" },
                values: new object[] { "audrey.winslet@google.com", "Winslet" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 68,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "donald.presley@gov.us", "Donald", "Presley" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 69,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.middleton@tesla.com", "Kate", "Middleton" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 70,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.winfrey@gov.gr", "Kate", "Winfrey" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 71,
                columns: new[] { "email", "last_name" },
                values: new object[] { "kate.windsor@bbc.co.uk", "Windsor" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 72,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "audrey.trump@gov.us", "Audrey", "Trump" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 73,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "donald.hendrix@theworld.ca", "Donald", "Hendrix" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 74,
                columns: new[] { "email", "first_name" },
                values: new object[] { "kate.hendrix@nasa.org.us", "Kate" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 75,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "oprah.presley@gov.us", "Oprah", "Presley" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 76,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "mick.winslet@tesla.com", "Mick", "Winslet" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 77,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "audrey.winslet@gov.ru", "Audrey", "Winslet" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 78,
                columns: new[] { "email", "last_name" },
                values: new object[] { "kate.obama@nasa.org.us", "Obama" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 79,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "donald.trump@tesla.com", "Donald", "Trump" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 80,
                columns: new[] { "email", "last_name" },
                values: new object[] { "barack.obama@theworld.ca", "Obama" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 81,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.winslet@gov.ru", "Kate", "Winslet" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 82,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "jimi.hepburn@something.com", "Jimi", "Hepburn" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 83,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "oprah.presley@nasa.org.us", "Oprah", "Presley" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 84,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "mick.obama@gov.nl", "Mick", "Obama" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 85,
                column: "email",
                value: "kate.winfrey@gov.gr");

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 86,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "charles.hepburn@gov.us", "Charles", "Hepburn" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 87,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "jimi.windsor@nasa.org.us", "Jimi", "Windsor" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 88,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "audrey.hepburn@google.com", "Audrey", "Hepburn" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 89,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "barack.winslet@something.com", "Barack", "Winslet" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 90,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "jimi.trump@theworld.ca", "Jimi", "Trump" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 91,
                columns: new[] { "email", "last_name" },
                values: new object[] { "elvis.trump@theworld.ca", "Trump" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 92,
                columns: new[] { "email", "first_name" },
                values: new object[] { "elvis.middleton@nasa.org.us", "Elvis" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 93,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "audrey.trump@nasa.org.us", "Audrey", "Trump" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 94,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "oprah.obama@gov.ru", "Oprah", "Obama" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 95,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.winfrey@bbc.co.uk", "Kate", "Winfrey" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 96,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.hepburn@google.com", "Kate", "Hepburn" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 97,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "oprah.trump@gov.gr", "Oprah", "Trump" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 98,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "donald.presley@something.com", "Donald", "Presley" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 99,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "oprah.jagger@bbc.co.uk", "Oprah", "Jagger" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 100,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "donald.jagger@tesla.com", "Donald", "Jagger" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 101,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "audrey.presley@gov.us", "Audrey", "Presley" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 102,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "mick.winfrey@theworld.ca", "Mick", "Winfrey" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 103,
                columns: new[] { "email", "last_name" },
                values: new object[] { "charles.presley@bbc.co.uk", "Presley" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 104,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "oprah.winslet@tesla.com", "Oprah", "Winslet" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 105,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "barack.jagger@gov.ru", "Barack", "Jagger" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 106,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "elvis.obama@google.com", "Elvis", "Obama" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 107,
                columns: new[] { "email", "first_name" },
                values: new object[] { "elvis.presley@gov.gr", "Elvis" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 108,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "jimi.winslet@gov.nl", "Jimi", "Winslet" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 109,
                columns: new[] { "email", "last_name" },
                values: new object[] { "mick.presley@gov.gr", "Presley" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 110,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "jimi.hendrix@theworld.ca", "Jimi", "Hendrix" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 111,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "barack.obama@tesla.com", "Barack", "Obama" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 112,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "charles.middleton@bbc.co.uk", "Charles", "Middleton" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 113,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "elvis.obama@gov.us", "Elvis", "Obama" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 114,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "oprah.obama@google.com", "Oprah", "Obama" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 115,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "oprah.winslet@gov.nl", "Oprah", "Winslet" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 116,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "donald.middleton@gov.ru", "Donald", "Middleton" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 117,
                columns: new[] { "email", "last_name" },
                values: new object[] { "mick.windsor@tesla.com", "Windsor" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 118,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "elvis.winslet@google.com", "Elvis", "Winslet" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 119,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.winfrey@gov.nl", "Kate", "Winfrey" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 120,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "barack.presley@theworld.ca", "Barack", "Presley" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 121,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "jimi.middleton@gov.ru", "Jimi", "Middleton" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 122,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "audrey.presley@gov.ru", "Audrey", "Presley" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 123,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "charles.middleton@gov.gr", "Charles", "Middleton" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 124,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.winfrey@gov.gr", "Kate", "Winfrey" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 125,
                columns: new[] { "email", "first_name" },
                values: new object[] { "oprah.winslet@gov.nl", "Oprah" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 126,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "barack.presley@nasa.org.us", "Barack", "Presley" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 127,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "barack.presley@theworld.ca", "Barack", "Presley" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 128,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "mick.hepburn@tesla.com", "Mick", "Hepburn" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 129,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "charles.trump@gov.us", "Charles", "Trump" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 130,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "audrey.middleton@something.com", "Audrey", "Middleton" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 131,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "jimi.obama@something.com", "Jimi", "Obama" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 132,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.windsor@tesla.com", "Kate", "Windsor" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 133,
                columns: new[] { "email", "first_name" },
                values: new object[] { "audrey.hepburn@tesla.com", "Audrey" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 134,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.presley@gov.nl", "Kate", "Presley" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 135,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "mick.middleton@bbc.co.uk", "Mick", "Middleton" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 136,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "oprah.winslet@bbc.co.uk", "Oprah", "Winslet" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 137,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "jimi.hepburn@something.com", "Jimi", "Hepburn" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 138,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "mick.hepburn@google.com", "Mick", "Hepburn" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 139,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "barack.hendrix@something.com", "Barack", "Hendrix" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 140,
                columns: new[] { "email", "last_name" },
                values: new object[] { "kate.hendrix@gov.ru", "Hendrix" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 141,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.middleton@something.com", "Kate", "Middleton" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 142,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.winslet@gov.gr", "Kate", "Winslet" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 143,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "donald.middleton@gov.us", "Donald", "Middleton" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 144,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.obama@nasa.org.us", "Kate", "Obama" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 145,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "audrey.jagger@gov.nl", "Audrey", "Jagger" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 146,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "audrey.trump@gov.us", "Audrey", "Trump" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 147,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.winslet@bbc.co.uk", "Kate", "Winslet" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 148,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "donald.presley@gov.nl", "Donald", "Presley" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 149,
                columns: new[] { "email", "last_name" },
                values: new object[] { "elvis.middleton@gov.us", "Middleton" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 150,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "audrey.hepburn@bbc.co.uk", "Audrey", "Hepburn" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 151,
                columns: new[] { "email", "first_name" },
                values: new object[] { "audrey.middleton@theworld.ca", "Audrey" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 152,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "audrey.hendrix@google.com", "Audrey", "Hendrix" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 153,
                columns: new[] { "email", "last_name" },
                values: new object[] { "charles.middleton@gov.us", "Middleton" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 154,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.trump@google.com", "Kate", "Trump" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 155,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "barack.windsor@theworld.ca", "Barack", "Windsor" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 156,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.obama@something.com", "Kate", "Obama" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 157,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "donald.winfrey@gov.gr", "Donald", "Winfrey" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 158,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.windsor@something.com", "Kate", "Windsor" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 159,
                columns: new[] { "email", "first_name" },
                values: new object[] { "charles.winslet@bbc.co.uk", "Charles" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 160,
                columns: new[] { "email", "first_name" },
                values: new object[] { "mick.obama@theworld.ca", "Mick" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 161,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "audrey.presley@google.com", "Audrey", "Presley" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 162,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "elvis.presley@gov.ru", "Elvis", "Presley" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 163,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "elvis.obama@tesla.com", "Elvis", "Obama" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 164,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "charles.hendrix@tesla.com", "Charles", "Hendrix" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 165,
                columns: new[] { "email", "last_name" },
                values: new object[] { "charles.obama@gov.us", "Obama" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 166,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "jimi.hendrix@something.com", "Jimi", "Hendrix" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 167,
                columns: new[] { "email", "last_name" },
                values: new object[] { "kate.trump@tesla.com", "Trump" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 168,
                columns: new[] { "email", "last_name" },
                values: new object[] { "kate.trump@something.com", "Trump" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 169,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "donald.middleton@gov.gr", "Donald", "Middleton" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 170,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "barack.middleton@something.com", "Barack", "Middleton" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 171,
                columns: new[] { "email", "last_name" },
                values: new object[] { "kate.middleton@gov.nl", "Middleton" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 172,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.winslet@bbc.co.uk", "Kate", "Winslet" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 173,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "donald.windsor@google.com", "Donald", "Windsor" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 174,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "charles.winfrey@nasa.org.us", "Charles", "Winfrey" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 175,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "charles.hendrix@gov.gr", "Charles", "Hendrix" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 176,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "audrey.windsor@something.com", "Audrey", "Windsor" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 177,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "oprah.winfrey@gov.ru", "Oprah", "Winfrey" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 178,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "audrey.trump@tesla.com", "Audrey", "Trump" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 179,
                columns: new[] { "email", "last_name" },
                values: new object[] { "kate.middleton@gov.nl", "Middleton" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 180,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "oprah.jagger@nasa.org.us", "Oprah", "Jagger" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 181,
                column: "email",
                value: "elvis.windsor@gov.nl");

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 182,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.jagger@google.com", "Kate", "Jagger" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 183,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "oprah.obama@gov.nl", "Oprah", "Obama" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 184,
                columns: new[] { "email", "last_name" },
                values: new object[] { "jimi.trump@google.com", "Trump" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 185,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "barack.hepburn@gov.ru", "Barack", "Hepburn" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 186,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "donald.middleton@something.com", "Donald", "Middleton" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 187,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.obama@theworld.ca", "Kate", "Obama" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 188,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "oprah.presley@gov.ru", "Oprah", "Presley" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 189,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.middleton@gov.us", "Kate", "Middleton" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 190,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "donald.presley@gov.nl", "Donald", "Presley" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 191,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "donald.obama@google.com", "Donald", "Obama" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 192,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "donald.windsor@gov.ru", "Donald", "Windsor" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 193,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "jimi.obama@tesla.com", "Jimi", "Obama" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 194,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "elvis.winslet@gov.nl", "Elvis", "Winslet" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 195,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "barack.winfrey@something.com", "Barack", "Winfrey" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 196,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.winfrey@gov.gr", "Kate", "Winfrey" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 197,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.presley@gov.ru", "Kate", "Presley" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 198,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "donald.hepburn@tesla.com", "Donald", "Hepburn" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 199,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "donald.middleton@theworld.ca", "Donald", "Middleton" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 200,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "elvis.hendrix@gov.gr", "Elvis", "Hendrix" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 201,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "charles.jagger@google.com", "Charles", "Jagger" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 202,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "donald.trump@gov.gr", "Donald", "Trump" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 203,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "oprah.winslet@tesla.com", "Oprah", "Winslet" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 204,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "mick.hepburn@tesla.com", "Mick", "Hepburn" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 205,
                column: "email",
                value: "kate.obama@google.com");

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 206,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "elvis.winfrey@something.com", "Elvis", "Winfrey" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 207,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "barack.hepburn@gov.ru", "Barack", "Hepburn" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 208,
                columns: new[] { "email", "first_name" },
                values: new object[] { "charles.obama@google.com", "Charles" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 209,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.jagger@gov.gr", "Kate", "Jagger" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 210,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "charles.middleton@something.com", "Charles", "Middleton" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 211,
                columns: new[] { "email", "first_name" },
                values: new object[] { "donald.hepburn@something.com", "Donald" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 212,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "mick.winslet@something.com", "Mick", "Winslet" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 213,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "jimi.jagger@bbc.co.uk", "Jimi", "Jagger" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 214,
                columns: new[] { "email", "first_name" },
                values: new object[] { "elvis.windsor@gov.us", "Elvis" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 215,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "audrey.winfrey@gov.us", "Audrey", "Winfrey" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 216,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "barack.windsor@google.com", "Barack", "Windsor" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 217,
                columns: new[] { "email", "first_name" },
                values: new object[] { "jimi.jagger@gov.us", "Jimi" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 218,
                columns: new[] { "email", "first_name" },
                values: new object[] { "oprah.middleton@theworld.ca", "Oprah" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 219,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "barack.winslet@theworld.ca", "Barack", "Winslet" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 220,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "donald.hendrix@tesla.com", "Donald", "Hendrix" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 221,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "audrey.hepburn@google.com", "Audrey", "Hepburn" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 222,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "mick.hepburn@theworld.ca", "Mick", "Hepburn" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 223,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "oprah.presley@something.com", "Oprah", "Presley" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 224,
                columns: new[] { "email", "first_name" },
                values: new object[] { "donald.hendrix@bbc.co.uk", "Donald" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 225,
                column: "email",
                value: "kate.hendrix@google.com");

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 226,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.obama@theworld.ca", "Kate", "Obama" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 227,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "barack.windsor@gov.gr", "Barack", "Windsor" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 228,
                columns: new[] { "email", "last_name" },
                values: new object[] { "mick.presley@gov.nl", "Presley" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 229,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "donald.obama@nasa.org.us", "Donald", "Obama" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 230,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.winslet@tesla.com", "Kate", "Winslet" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 231,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "mick.hepburn@nasa.org.us", "Mick", "Hepburn" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 232,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "jimi.windsor@nasa.org.us", "Jimi", "Windsor" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 233,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.jagger@something.com", "Kate", "Jagger" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 234,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "barack.hepburn@tesla.com", "Barack", "Hepburn" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 235,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.jagger@gov.ru", "Kate", "Jagger" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 236,
                column: "email",
                value: "donald.windsor@tesla.com");

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 237,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "barack.trump@gov.ru", "Barack", "Trump" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 238,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.hepburn@google.com", "Kate", "Hepburn" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 239,
                columns: new[] { "email", "last_name" },
                values: new object[] { "donald.winslet@gov.ru", "Winslet" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 240,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "oprah.jagger@theworld.ca", "Oprah", "Jagger" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 241,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "audrey.winslet@nasa.org.us", "Audrey", "Winslet" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 242,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "donald.trump@theworld.ca", "Donald", "Trump" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 243,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "jimi.obama@bbc.co.uk", "Jimi", "Obama" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 244,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "elvis.winfrey@google.com", "Elvis", "Winfrey" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 245,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "mick.middleton@nasa.org.us", "Mick", "Middleton" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 246,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "mick.winslet@bbc.co.uk", "Mick", "Winslet" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 247,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "mick.trump@bbc.co.uk", "Mick", "Trump" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 248,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "mick.presley@gov.gr", "Mick", "Presley" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 249,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "charles.hepburn@gov.nl", "Charles", "Hepburn" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 237, 26, "Fifteen Large Leopards" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 168, 191, "Fifteen Orange Houses" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 200, 150, "The Transparent Houses" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 81, 65, "Fifteen Transparent Houses" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 236, 195, "The Purple Houses" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 1, 24, "A herd of Orange Buildings" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 156, 177, "A herd of Orange Buildings" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 39, 139, "Two Transparent Buildings" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 200, 93, "An army of Purple Cars" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 43, 144, "Several Purple Buildings" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 36, 32, "Two Green Leopards" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 33, 60, "Several Purple Planets" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 162, 81, "A bunch of Bitter Flowers" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 196, 206, "Fifteen Purple Leopards" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 201, 16, "An army of Rose Smelling Planets" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 2, 136, "An army of Green Planets" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 156, 232, "Two Transparent Houses" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 149, 36, "A bunch of Rose Smelling Buildings" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 64, 244, "An army of Large Cars" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 24, 109, "A herd of Rose Smelling Houses" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 184, 23, "A herd of Microscopic Flowers" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 109, 109, "Fifteen Purple Buildings" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 208, 14, "Several Green Buildings" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 146, 213, "Fifteen Microscopic Cars" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 10, 175, "Several Transparent Leopards" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 219, 119, "A herd of Green Cars" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 225, 110, "The Large Houses" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 53, 5, "An army of Microscopic Leopards" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 240, 74, "Several Transparent Planets" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 20, 46, "An army of Microscopic Houses" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 102, 219, "Several Purple Houses" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 23, 61, "Two Purple Houses" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 33,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 84, 80, "A bunch of Bitter Flowers" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 34,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 3, 41, "A herd of Transparent Leopards" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 35,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 185, 106, "The Transparent Planets" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 36,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 173, 232, "The Rose Smelling Buildings" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 37,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 49, 8, "Several Rose Smelling Planets" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 38,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 180, 157, "The Purple Cars" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 39,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 191, 54, "A herd of Transparent Planets" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 40,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 163, 238, "Two Microscopic Cars" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 41,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 228, 22, "The Large Planets" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 42,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 104, 224, "Several Green Leopards" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 43,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 7, 4, "Several Microscopic Flowers" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 44,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 137, 132, "A bunch of Large Flowers" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 45,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 35, 212, "An army of Purple Planets" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 46,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 139, 225, "A herd of Large Houses" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 47,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 206, 163, "An army of Large Planets" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 48,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 38, 89, "Several Bitter Buildings" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 49,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 15, 174, "Several Transparent Cars" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 50,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 203, 116, "Several Transparent Buildings" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 51,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 112, 63, "The Microscopic Flowers" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 52,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 225, 224, "Fifteen Orange Cars" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 53,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 119, 89, "The Transparent Houses" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 54,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 118, 196, "Fifteen Orange Leopards" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 55,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 214, 62, "Several Green Leopards" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 56,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 107, 214, "Fifteen Large Buildings" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 57,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 244, 196, "An army of Large Cars" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 58,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 111, 143, "An army of Orange Cars" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 59,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 217, 243, "A bunch of Microscopic Buildings" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 60,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 71, 95, "An army of Transparent Cars" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 61,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 33, 168, "A herd of Bitter Buildings" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 62,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 56, 249, "Several Rose Smelling Leopards" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 63,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 15, 45, "Two Green Planets" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 64,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 121, 202, "Fifteen Microscopic Houses" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 65,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 8, 6, "The Purple Houses" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 66,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 225, 163, "The Orange Cars" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 67,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 183, 216, "Several Purple Leopards" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 68,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 57, 74, "Two Purple Leopards" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 69,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 149, 66, "Fifteen Green Flowers" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 70,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 72, 39, "A bunch of Purple Cars" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 71,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 34, 132, "A herd of Transparent Cars" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 72,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 154, 106, "Two Orange Cars" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 73,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 214, 155, "Several Green Planets" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 74,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 148, 152, "A herd of Microscopic Flowers" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 75,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 38, 147, "Fifteen Rose Smelling Planets" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 76,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 227, 185, "A herd of Bitter Cars" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 77,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 193, 228, "Several Rose Smelling Buildings" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 78,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 142, 106, "Several Microscopic Leopards" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 79,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 17, 149, "Two Bitter Houses" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 80,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 188, 177, "Fifteen Bitter Buildings" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 81,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 20, 66, "The Bitter Cars" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 82,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 200, 181, "Two Rose Smelling Houses" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 83,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 50, 102, "An army of Transparent Leopards" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 84,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 73, 228, "An army of Bitter Leopards" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 85,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 235, 155, "Several Rose Smelling Flowers" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 86,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 62, 240, "An army of Large Flowers" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 87,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 119, 49, "An army of Microscopic Houses" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 88,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 4, 143, "Several Orange Cars" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 89,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 151, 151, "The Microscopic Buildings" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 90,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 106, 149, "A bunch of Bitter Buildings" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 91,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 76, 232, "Fifteen Microscopic Buildings" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 92,
                columns: new[] { "publisher_id", "title" },
                values: new object[] { 238, "An army of Orange Houses" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 93,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 67, 123, "The Bitter Buildings" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 94,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 35, 40, "Two Transparent Planets" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 95,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 135, 39, "Fifteen Transparent Leopards" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 96,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 219, 232, "Several Bitter Buildings" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 97,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 110, 144, "Fifteen Large Houses" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 98,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 139, 114, "The Microscopic Buildings" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 99,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 93, 226, "An army of Bitter Leopards" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 100,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 215, 184, "Two Microscopic Planets" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 101,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 115, 86, "Several Purple Planets" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 102,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 105, 111, "A bunch of Bitter Flowers" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 103,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 75, 136, "An army of Large Flowers" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 104,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 65, 68, "An army of Green Leopards" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 105,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 25, 28, "A herd of Transparent Planets" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 106,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 69, 240, "An army of Rose Smelling Houses" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 107,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 207, 99, "Fifteen Bitter Houses" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 108,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 95, 187, "Several Bitter Buildings" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 109,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 198, 89, "A herd of Rose Smelling Leopards" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 110,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 229, 15, "Fifteen Green Houses" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 111,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 247, 214, "An army of Green Houses" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 112,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 29, 1, "The Large Buildings" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 113,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 12, 248, "The Green Flowers" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 114,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 225, 52, "An army of Purple Flowers" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 115,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 137, 22, "A bunch of Purple Planets" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 116,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 185, 56, "An army of Rose Smelling Planets" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 117,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 143, 137, "Fifteen Purple Houses" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 118,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 199, 102, "Two Green Houses" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 119,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 48, 61, "Several Transparent Buildings" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 120,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 134, 168, "The Large Houses" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 121,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 91, 60, "A bunch of Microscopic Buildings" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 122,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 168, 116, "A herd of Large Leopards" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 123,
                columns: new[] { "author_id", "publisher_id" },
                values: new object[] { 141, 1 });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 124,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 181, 34, "Fifteen Orange Flowers" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 125,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 128, 32, "The Microscopic Houses" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 126,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 249, 216, "A herd of Microscopic Leopards" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 127,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 227, 146, "A herd of Transparent Cars" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 128,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 139, 3, "Several Bitter Planets" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 129,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 10, 33, "An army of Green Houses" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 130,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 40, 232, "A bunch of Orange Houses" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 131,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 128, 111, "A herd of Microscopic Leopards" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 132,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 27, 164, "Several Purple Houses" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 133,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 237, 179, "An army of Microscopic Leopards" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 134,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 146, 168, "Two Rose Smelling Cars" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 135,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 127, 48, "The Orange Leopards" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 136,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 65, 205, "The Microscopic Leopards" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 137,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 127, 200, "A bunch of Transparent Houses" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 138,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 161, 163, "A bunch of Green Cars" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 139,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 103, 176, "The Large Flowers" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 140,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 200, 168, "An army of Large Houses" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 141,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 82, 198, "Fifteen Large Houses" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 142,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 50, 122, "Two Large Houses" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 143,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 140, 143, "A herd of Purple Cars" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 144,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 133, 211, "A herd of Rose Smelling Leopards" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 145,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 185, 230, "A bunch of Bitter Planets" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 146,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 49, 67, "A bunch of Purple Houses" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 147,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 217, 56, "Fifteen Orange Buildings" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 148,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 178, 109, "Fifteen Rose Smelling Leopards" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 149,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 8, 93, "Fifteen Purple Flowers" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 150,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 34, 102, "A herd of Large Planets" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 151,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 159, 148, "The Green Planets" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 152,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 228, 209, "A herd of Large Cars" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 153,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 144, 186, "An army of Green Houses" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 154,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 64, 205, "Fifteen Orange Leopards" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 155,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 235, 214, "The Orange Houses" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 156,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 189, 113, "An army of Transparent Houses" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 157,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 53, 165, "Fifteen Purple Houses" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 158,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 91, 198, "Several Transparent Planets" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 159,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 40, 193, "The Microscopic Leopards" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 160,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 173, 210, "A bunch of Transparent Planets" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 161,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 137, 66, "The Transparent Flowers" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 162,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 32, 137, "An army of Green Cars" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 163,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 187, 57, "Fifteen Microscopic Flowers" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 164,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 52, 183, "The Transparent Houses" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 165,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 72, 14, "The Orange Cars" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 166,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 177, 232, "Fifteen Rose Smelling Houses" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 167,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 152, 198, "A bunch of Transparent Buildings" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 168,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 161, 23, "A bunch of Bitter Cars" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 169,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 168, 79, "An army of Orange Buildings" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 170,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 102, 28, "A herd of Bitter Flowers" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 171,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 57, 126, "Two Large Flowers" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 172,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 223, 143, "Two Green Leopards" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 173,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 5, 165, "The Microscopic Buildings" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 174,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 110, 137, "A bunch of Rose Smelling Cars" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 175,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 204, 217, "A herd of Microscopic Leopards" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 176,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 215, 237, "Two Green Buildings" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 177,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 119, 12, "A bunch of Purple Leopards" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 178,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 189, 99, "A bunch of Transparent Leopards" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 179,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 131, 10, "Several Rose Smelling Cars" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 180,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 191, 230, "Two Microscopic Flowers" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 181,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 202, 106, "A bunch of Microscopic Planets" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 182,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 61, 30, "The Microscopic Planets" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 183,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 5, 71, "The Bitter Flowers" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 184,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 69, 103, "An army of Green Houses" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 185,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 74, 67, "The Bitter Buildings" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 186,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 221, 239, "Two Orange Planets" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 187,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 55, 5, "An army of Purple Cars" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 188,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 120, 54, "Two Green Flowers" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 189,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 168, 140, "A herd of Microscopic Planets" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 190,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 10, 226, "A bunch of Transparent Leopards" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 191,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 230, 33, "An army of Orange Planets" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 192,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 234, 93, "Two Rose Smelling Leopards" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 193,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 246, 132, "The Rose Smelling Flowers" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 194,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 164, 109, "An army of Transparent Planets" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 195,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 61, 73, "The Rose Smelling Cars" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 196,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 241, 144, "An army of Transparent Leopards" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 197,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 172, 189, "Fifteen Green Cars" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 198,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 96, 240, "Fifteen Large Buildings" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 199,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 199, 220, "Several Green Cars" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 200,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 78, 15, "An army of Large Houses" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 201,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 218, 1, "Two Microscopic Planets" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 202,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 203, 89, "A herd of Rose Smelling Houses" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 203,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 119, 77, "Several Green Planets" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 204,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 174, 222, "Several Purple Planets" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 205,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 4, 210, "A bunch of Green Flowers" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 206,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 216, 92, "Fifteen Transparent Cars" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 207,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 99, 50, "An army of Rose Smelling Buildings" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 208,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 210, 187, "Fifteen Green Houses" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 209,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 218, 81, "A bunch of Rose Smelling Buildings" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 210,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 105, 243, "Fifteen Large Leopards" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 211,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 147, 38, "The Bitter Buildings" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 212,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 74, 246, "The Rose Smelling Cars" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 213,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 37, 33, "The Rose Smelling Houses" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 214,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 199, 168, "An army of Orange Planets" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 215,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 226, 234, "An army of Green Buildings" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 216,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 70, 89, "Several Orange Buildings" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 217,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 48, 249, "An army of Rose Smelling Flowers" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 218,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 240, 176, "Two Transparent Cars" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 219,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 33, 28, "Fifteen Rose Smelling Leopards" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 220,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 158, 164, "An army of Large Leopards" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 221,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 42, 218, "A bunch of Green Houses" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 222,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 195, 127, "Fifteen Green Buildings" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 223,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 151, 72, "A herd of Purple Houses" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 224,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 83, 215, "The Microscopic Cars" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 225,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 118, 198, "Several Rose Smelling Leopards" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 226,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 76, 237, "Several Bitter Leopards" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 227,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 93, 118, "Two Bitter Houses" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 228,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 47, 211, "A herd of Bitter Flowers" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 229,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 135, 46, "Several Bitter Houses" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 230,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 85, 124, "An army of Bitter Planets" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 231,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 110, 43, "The Rose Smelling Houses" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 232,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 118, 144, "Fifteen Green Flowers" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 233,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 147, 212, "Fifteen Green Planets" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 234,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 156, 133, "A bunch of Orange Buildings" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 235,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 85, 109, "An army of Green Buildings" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 236,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 69, 234, "An army of Purple Leopards" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 237,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 101, 27, "A herd of Bitter Cars" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 238,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 225, 167, "An army of Orange Houses" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 239,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 207, 164, "A herd of Green Cars" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 240,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 156, 25, "A herd of Orange Cars" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 241,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 93, 149, "An army of Green Houses" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 242,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 80, 98, "An army of Purple Flowers" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 243,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 158, 231, "The Purple Houses" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 244,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 171, 194, "Two Orange Buildings" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 245,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 14, 211, "Two Green Flowers" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 246,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 46, 86, "The Purple Buildings" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 247,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 201, 150, "Fifteen Rose Smelling Planets" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 248,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 171, 42, "The Orange Cars" });

            migrationBuilder.UpdateData(
                table: "book",
                keyColumn: "id",
                keyValue: 249,
                columns: new[] { "author_id", "publisher_id", "title" },
                values: new object[] { 55, 248, "A bunch of Microscopic Leopards" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "microscopic@gov.us", "Flowers A herd of" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "purple@gov.us", "Houses The" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "orange@gov.ru", "Planets A herd of" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "green@gov.gr", "Leopards A bunch of" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 5,
                column: "name",
                value: "Leopards The");

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "green@tesla.com", "Planets Several" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "green@gov.nl", "Cars The" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "green@bbc.co.uk", "Buildings Several" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "green@google.com", "Leopards Two" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "orange@gov.ru", "Cars The" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "microscopic@tesla.com", "Buildings Two" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "transparent@gov.ru", "Cars A herd of" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "large@gov.gr", "Buildings A herd of" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "bitter@google.com", "Houses A bunch of" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "purple@google.com", "Cars Fifteen" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "rose smelling@gov.nl", "Houses An army of" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "bitter@nasa.org.us", "Flowers Two" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "purple@gov.gr", "Cars Fifteen" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "microscopic@nasa.org.us", "Houses Several" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "rose smelling@bbc.co.uk", "Houses An army of" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "rose smelling@nasa.org.us", "Planets An army of" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "orange@nasa.org.us", "Flowers An army of" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "large@gov.ru", "Leopards A bunch of" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "green@gov.ru", "Cars The" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "bitter@theworld.ca", "Flowers Fifteen" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "microscopic@nasa.org.us", "Houses Fifteen" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "rose smelling@tesla.com", "Leopards A bunch of" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "transparent@theworld.ca", "Buildings A herd of" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "purple@gov.ru", "Cars An army of" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "purple@something.com", "Flowers Two" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "transparent@gov.ru", "Cars Fifteen" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "rose smelling@google.com", "Leopards A bunch of" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 33,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "microscopic@gov.gr", "Planets Several" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 34,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "purple@tesla.com", "Flowers An army of" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 35,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "bitter@tesla.com", "Flowers Two" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 36,
                column: "contact_details",
                value: "bitter@tesla.com");

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 37,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "transparent@nasa.org.us", "Buildings Two" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 38,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "bitter@gov.us", "Planets An army of" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 39,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "transparent@gov.us", "Buildings Two" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 40,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "purple@something.com", "Planets A bunch of" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 41,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "transparent@gov.us", "Leopards The" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 42,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "bitter@something.com", "Flowers The" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 43,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "rose smelling@gov.nl", "Flowers An army of" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 44,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "transparent@tesla.com", "Leopards Two" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 45,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "transparent@nasa.org.us", "Leopards The" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 46,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "bitter@gov.us", "Planets An army of" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 47,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "microscopic@google.com", "Cars Several" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 48,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "green@bbc.co.uk", "Planets The" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 49,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "large@google.com", "Flowers Two" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 50,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "transparent@nasa.org.us", "Planets An army of" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 51,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "orange@gov.ru", "Houses Several" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 52,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "purple@theworld.ca", "Planets Two" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 53,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "rose smelling@gov.ru", "Cars Two" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 54,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "bitter@google.com", "Leopards Several" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 55,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "microscopic@tesla.com", "Leopards Two" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 56,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "green@something.com", "Buildings The" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 57,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "green@gov.ru", "Buildings A bunch of" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 58,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "rose smelling@gov.gr", "Leopards An army of" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 59,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "orange@something.com", "Leopards A herd of" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 60,
                column: "contact_details",
                value: "purple@gov.gr");

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 61,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "orange@gov.gr", "Leopards Several" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 62,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "green@bbc.co.uk", "Flowers A bunch of" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 63,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "orange@gov.us", "Leopards Several" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 64,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "purple@nasa.org.us", "Leopards The" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 65,
                column: "name",
                value: "Cars The");

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 66,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "purple@nasa.org.us", "Houses A bunch of" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 67,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "green@theworld.ca", "Leopards The" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 68,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "bitter@google.com", "Buildings An army of" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 69,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "green@gov.us", "Leopards Two" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 70,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "large@bbc.co.uk", "Flowers Several" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 71,
                column: "contact_details",
                value: "large@gov.us");

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 72,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "green@gov.us", "Flowers A bunch of" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 73,
                column: "contact_details",
                value: "transparent@gov.gr");

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 74,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "purple@tesla.com", "Leopards A bunch of" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 75,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "bitter@gov.ru", "Planets Two" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 76,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "green@nasa.org.us", "Cars Several" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 77,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "large@tesla.com", "Cars Fifteen" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 78,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "large@nasa.org.us", "Houses Fifteen" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 79,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "microscopic@something.com", "Cars A herd of" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 80,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "purple@gov.ru", "Leopards A bunch of" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 81,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "orange@nasa.org.us", "Leopards A bunch of" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 82,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "green@something.com", "Planets An army of" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 83,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "transparent@tesla.com", "Houses A bunch of" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 84,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "bitter@bbc.co.uk", "Houses The" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 85,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "orange@gov.nl", "Flowers Fifteen" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 86,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "orange@theworld.ca", "Cars An army of" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 87,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "orange@nasa.org.us", "Houses Fifteen" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 88,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "green@tesla.com", "Planets The" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 89,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "orange@gov.nl", "Leopards Fifteen" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 90,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "bitter@bbc.co.uk", "Houses Two" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 91,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "bitter@gov.nl", "Cars The" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 92,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "large@gov.us", "Flowers An army of" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 93,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "rose smelling@theworld.ca", "Planets A herd of" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 94,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "rose smelling@something.com", "Flowers Several" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 95,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "rose smelling@gov.nl", "Planets A bunch of" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 96,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "bitter@gov.nl", "Leopards A bunch of" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 97,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "rose smelling@nasa.org.us", "Leopards Two" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 98,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "orange@tesla.com", "Flowers A bunch of" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 99,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "green@nasa.org.us", "Houses A herd of" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 100,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "bitter@gov.gr", "Houses A herd of" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 101,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "rose smelling@google.com", "Buildings Two" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 102,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "transparent@nasa.org.us", "Flowers Fifteen" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 103,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "bitter@gov.us", "Planets An army of" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 104,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "large@bbc.co.uk", "Planets Two" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 105,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "rose smelling@bbc.co.uk", "Buildings A herd of" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 106,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "rose smelling@google.com", "Buildings An army of" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 107,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "orange@theworld.ca", "Houses Fifteen" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 108,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "microscopic@bbc.co.uk", "Leopards Fifteen" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 109,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "large@theworld.ca", "Buildings An army of" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 110,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "transparent@theworld.ca", "Planets An army of" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 111,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "green@google.com", "Leopards The" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 112,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "large@theworld.ca", "Buildings The" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 113,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "purple@google.com", "Leopards A bunch of" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 114,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "transparent@gov.us", "Flowers Several" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 115,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "orange@gov.nl", "Leopards Fifteen" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 116,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "purple@theworld.ca", "Leopards Several" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 117,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "microscopic@gov.us", "Cars An army of" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 118,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "bitter@gov.gr", "Houses Several" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 119,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "bitter@gov.us", "Buildings Two" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 120,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "large@tesla.com", "Cars The" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 121,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "large@nasa.org.us", "Buildings A herd of" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 122,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "green@theworld.ca", "Cars An army of" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 123,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "orange@gov.us", "Buildings An army of" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 124,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "large@nasa.org.us", "Buildings Two" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 125,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "purple@bbc.co.uk", "Flowers Two" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 126,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "orange@gov.ru", "Houses The" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 127,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "orange@gov.gr", "Cars An army of" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 128,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "purple@gov.ru", "Flowers Fifteen" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 129,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "microscopic@google.com", "Houses Two" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 130,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "orange@something.com", "Flowers Two" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 131,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "large@gov.gr", "Buildings Several" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 132,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "transparent@bbc.co.uk", "Leopards An army of" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 133,
                column: "name",
                value: "Leopards Two");

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 134,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "rose smelling@gov.us", "Cars A bunch of" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 135,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "microscopic@gov.ru", "Buildings A herd of" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 136,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "large@google.com", "Houses The" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 137,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "orange@gov.nl", "Leopards An army of" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 138,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "purple@gov.gr", "Buildings Several" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 139,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "large@tesla.com", "Planets Two" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 140,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "transparent@something.com", "Buildings Several" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 141,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "microscopic@gov.gr", "Leopards Two" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 142,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "microscopic@gov.us", "Houses An army of" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 143,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "bitter@bbc.co.uk", "Buildings Fifteen" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 144,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "transparent@gov.gr", "Cars Fifteen" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 145,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "purple@theworld.ca", "Planets A herd of" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 146,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "large@gov.nl", "Buildings Several" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 147,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "rose smelling@gov.nl", "Buildings Two" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 148,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "purple@gov.gr", "Buildings A herd of" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 149,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "transparent@theworld.ca", "Buildings An army of" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 150,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "green@tesla.com", "Cars Several" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 151,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "rose smelling@bbc.co.uk", "Leopards A herd of" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 152,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "microscopic@tesla.com", "Planets Two" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 153,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "rose smelling@gov.us", "Leopards A bunch of" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 154,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "large@theworld.ca", "Flowers The" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 155,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "bitter@something.com", "Leopards An army of" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 156,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "orange@tesla.com", "Buildings An army of" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 157,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "orange@gov.us", "Houses A herd of" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 158,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "green@gov.nl", "Leopards The" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 159,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "microscopic@gov.us", "Leopards A herd of" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 160,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "large@nasa.org.us", "Cars Several" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 161,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "large@gov.gr", "Flowers An army of" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 162,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "transparent@google.com", "Cars Several" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 163,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "transparent@google.com", "Buildings Two" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 164,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "microscopic@theworld.ca", "Houses An army of" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 165,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "rose smelling@google.com", "Cars A herd of" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 166,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "microscopic@nasa.org.us", "Leopards The" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 167,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "purple@gov.nl", "Houses The" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 168,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "transparent@tesla.com", "Planets A bunch of" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 169,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "purple@gov.gr", "Planets A herd of" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 170,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "rose smelling@something.com", "Houses Several" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 171,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "purple@something.com", "Cars A herd of" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 172,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "rose smelling@gov.us", "Planets An army of" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 173,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "microscopic@nasa.org.us", "Planets Several" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 174,
                column: "contact_details",
                value: "microscopic@tesla.com");

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 175,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "microscopic@tesla.com", "Houses Several" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 176,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "microscopic@theworld.ca", "Houses A herd of" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 177,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "large@gov.gr", "Planets The" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 178,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "purple@theworld.ca", "Buildings A herd of" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 179,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "bitter@tesla.com", "Buildings The" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 180,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "transparent@nasa.org.us", "Planets Fifteen" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 181,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "purple@gov.ru", "Leopards A herd of" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 182,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "green@gov.nl", "Planets An army of" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 183,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "purple@gov.ru", "Cars Two" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 184,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "purple@gov.nl", "Leopards An army of" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 185,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "microscopic@gov.ru", "Buildings Two" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 186,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "large@tesla.com", "Cars Fifteen" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 187,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "rose smelling@gov.nl", "Leopards The" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 188,
                column: "name",
                value: "Cars A herd of");

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 189,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "rose smelling@bbc.co.uk", "Planets A bunch of" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 190,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "rose smelling@google.com", "Cars Several" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 191,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "purple@nasa.org.us", "Cars An army of" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 192,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "large@google.com", "Houses Several" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 193,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "purple@google.com", "Leopards Fifteen" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 194,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "green@tesla.com", "Leopards A herd of" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 195,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "large@gov.nl", "Houses Several" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 196,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "bitter@nasa.org.us", "Planets An army of" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 197,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "green@nasa.org.us", "Flowers Several" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 198,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "orange@gov.nl", "Cars Two" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 199,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "green@gov.ru", "Planets An army of" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 200,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "large@gov.gr", "Flowers A bunch of" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 201,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "rose smelling@nasa.org.us", "Houses A bunch of" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 202,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "orange@something.com", "Planets Two" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 203,
                column: "contact_details",
                value: "rose smelling@gov.ru");

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 204,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "microscopic@bbc.co.uk", "Houses A bunch of" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 205,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "purple@tesla.com", "Planets Two" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 206,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "transparent@gov.nl", "Buildings An army of" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 207,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "green@something.com", "Cars Several" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 208,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "microscopic@gov.nl", "Flowers Several" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 209,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "purple@gov.ru", "Leopards The" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 210,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "purple@google.com", "Leopards The" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 211,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "rose smelling@something.com", "Buildings Fifteen" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 212,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "transparent@bbc.co.uk", "Cars Several" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 213,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "microscopic@google.com", "Flowers A bunch of" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 214,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "purple@gov.nl", "Houses Fifteen" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 215,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "green@theworld.ca", "Leopards A bunch of" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 216,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "orange@tesla.com", "Planets A bunch of" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 217,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "rose smelling@gov.ru", "Planets Fifteen" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 218,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "orange@gov.us", "Leopards A herd of" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 219,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "large@google.com", "Cars Fifteen" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 220,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "large@bbc.co.uk", "Buildings Fifteen" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 221,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "green@gov.nl", "Flowers Fifteen" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 222,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "microscopic@theworld.ca", "Cars Several" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 223,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "green@something.com", "Flowers Two" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 224,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "purple@gov.ru", "Planets Several" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 225,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "orange@theworld.ca", "Buildings An army of" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 226,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "bitter@theworld.ca", "Cars An army of" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 227,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "microscopic@gov.nl", "Flowers The" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 228,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "bitter@nasa.org.us", "Cars Several" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 229,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "purple@bbc.co.uk", "Cars Several" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 230,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "rose smelling@gov.nl", "Flowers A herd of" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 231,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "microscopic@nasa.org.us", "Houses The" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 232,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "purple@gov.gr", "Houses Fifteen" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 233,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "purple@bbc.co.uk", "Planets An army of" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 234,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "bitter@nasa.org.us", "Houses Two" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 235,
                column: "contact_details",
                value: "bitter@nasa.org.us");

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 236,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "purple@theworld.ca", "Houses A bunch of" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 237,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "green@tesla.com", "Buildings Fifteen" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 238,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "rose smelling@gov.nl", "Planets A herd of" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 239,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "bitter@google.com", "Cars A herd of" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 240,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "rose smelling@gov.ru", "Planets Fifteen" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 241,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "purple@theworld.ca", "Flowers A bunch of" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 242,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "orange@gov.us", "Cars Fifteen" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 243,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "green@nasa.org.us", "Planets Two" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 244,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "green@nasa.org.us", "Cars Fifteen" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 245,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "rose smelling@nasa.org.us", "Leopards Fifteen" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 246,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "large@tesla.com", "Flowers A bunch of" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 247,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "transparent@something.com", "Flowers An army of" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 248,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "orange@tesla.com", "Planets A herd of" });

            migrationBuilder.UpdateData(
                table: "publisher",
                keyColumn: "id",
                keyValue: 249,
                columns: new[] { "contact_details", "name" },
                values: new object[] { "large@google.com", "Planets The" });
        }
    }
}
