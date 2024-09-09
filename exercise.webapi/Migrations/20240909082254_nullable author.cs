using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace exercise.webapi.Migrations
{
    /// <inheritdoc />
    public partial class nullableauthor : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_Authors_AuthorId",
                table: "Books");

            migrationBuilder.AlterColumn<int>(
                name: "AuthorId",
                table: "Books",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "mick.winslet@gov.nl", "Mick", "Winslet" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "audrey.jagger@nasa.org.us", "Audrey", "Jagger" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "charles.middleton@gov.ru", "Charles", "Middleton" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Email", "FirstName" },
                values: new object[] { "jimi.trump@gov.us", "Jimi" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Email", "FirstName" },
                values: new object[] { "kate.winfrey@something.com", "Kate" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "jimi.winslet@gov.ru", "Jimi", "Winslet" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "mick.obama@bbc.co.uk", "Mick", "Obama" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "oprah.presley@nasa.org.us", "Oprah", "Presley" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Email", "FirstName" },
                values: new object[] { "kate.hepburn@something.com", "Kate" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Email", "LastName" },
                values: new object[] { "charles.trump@theworld.ca", "Trump" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "barack.trump@gov.ru", "Barack", "Trump" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "charles.winfrey@google.com", "Charles", "Winfrey" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "elvis.winslet@gov.nl", "Elvis", "Winslet" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "charles.hendrix@gov.ru", "Charles", "Hendrix" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "charles.jagger@google.com", "Charles", "Jagger" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "oprah.middleton@something.com", "Oprah", "Middleton" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Email", "FirstName" },
                values: new object[] { "charles.presley@gov.gr", "Charles" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "kate.trump@something.com", "Kate", "Trump" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "barack.hendrix@gov.nl", "Barack", "Hendrix" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "kate.windsor@gov.ru", "Kate", "Windsor" });

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
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "charles.obama@bbc.co.uk", "Charles", "Obama" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Email", "LastName" },
                values: new object[] { "mick.winfrey@nasa.org.us", "Winfrey" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "barack.jagger@gov.us", "Barack", "Jagger" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "elvis.jagger@bbc.co.uk", "Elvis", "Jagger" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Email", "FirstName" },
                values: new object[] { "kate.trump@gov.ru", "Kate" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "audrey.winslet@gov.ru", "Audrey", "Winslet" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Email", "FirstName" },
                values: new object[] { "kate.winslet@google.com", "Kate" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Email", "LastName" },
                values: new object[] { "donald.presley@gov.ru", "Presley" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Email", "LastName" },
                values: new object[] { "jimi.hendrix@gov.gr", "Hendrix" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "mick.windsor@tesla.com", "Mick", "Windsor" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "donald.hepburn@gov.nl", "Donald", "Hepburn" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "jimi.obama@gov.ru", "Jimi", "Obama" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "mick.trump@gov.ru", "Mick", "Trump" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "mick.windsor@tesla.com", "Mick", "Windsor" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "mick.hepburn@gov.us", "Mick", "Hepburn" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "kate.hendrix@gov.gr", "Kate", "Hendrix" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Email", "LastName" },
                values: new object[] { "kate.jagger@gov.nl", "Jagger" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "donald.windsor@gov.gr", "Donald", "Windsor" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 6, "A herd of Purple Leopards" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 38, "A bunch of Rose Smelling Cars" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 15, "The Orange Leopards" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 21, "Two Rose Smelling Buildings" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 20, "A herd of Purple Cars" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 22, "A herd of Bitter Buildings" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 14, "Two Microscopic Cars" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 31, "Two Bitter Buildings" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 34, "An army of Large Cars" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 20, "Several Rose Smelling Planets" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 8, "Two Large Buildings" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 38, "An army of Bitter Buildings" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 31, "Several Large Flowers" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 10, "Two Large Buildings" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 32, "A herd of Large Buildings" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 14, "Several Large Planets" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 16, "Several Rose Smelling Planets" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 10, "Two Green Leopards" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 16, "Several Large Leopards" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 10, "A bunch of Green Houses" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 33, "Fifteen Green Houses" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 9, "A bunch of Orange Flowers" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 16, "Several Bitter Planets" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 12, "Two Large Houses" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 17, "The Microscopic Cars" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 15, "A bunch of Orange Planets" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 2, "A bunch of Rose Smelling Planets" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 20, "A herd of Green Leopards" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 16, "Two Rose Smelling Cars" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 23, "Several Green Cars" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 19, "A bunch of Orange Cars" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 13, "Fifteen Microscopic Leopards" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 24, "Fifteen Green Cars" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 18, "A bunch of Bitter Planets" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 1, "An army of Microscopic Houses" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 10, "A herd of Green Houses" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 31, "A bunch of Green Houses" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 34, "Fifteen Orange Cars" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 16, "The Purple Buildings" });

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Authors_AuthorId",
                table: "Books",
                column: "AuthorId",
                principalTable: "Authors",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_Authors_AuthorId",
                table: "Books");

            migrationBuilder.AlterColumn<int>(
                name: "AuthorId",
                table: "Books",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "elvis.hepburn@bbc.co.uk", "Elvis", "Hepburn" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "kate.presley@bbc.co.uk", "Kate", "Presley" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "audrey.windsor@gov.gr", "Audrey", "Windsor" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Email", "FirstName" },
                values: new object[] { "mick.trump@gov.gr", "Mick" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Email", "FirstName" },
                values: new object[] { "donald.winfrey@gov.nl", "Donald" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "oprah.middleton@gov.nl", "Oprah", "Middleton" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "barack.trump@bbc.co.uk", "Barack", "Trump" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "charles.trump@bbc.co.uk", "Charles", "Trump" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Email", "FirstName" },
                values: new object[] { "jimi.hepburn@gov.nl", "Jimi" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Email", "LastName" },
                values: new object[] { "charles.middleton@gov.gr", "Middleton" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "kate.jagger@tesla.com", "Kate", "Jagger" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "mick.hendrix@gov.ru", "Mick", "Hendrix" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "mick.middleton@gov.us", "Mick", "Middleton" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "oprah.trump@gov.us", "Oprah", "Trump" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "kate.trump@gov.us", "Kate", "Trump" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "donald.hepburn@gov.us", "Donald", "Hepburn" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Email", "FirstName" },
                values: new object[] { "mick.presley@something.com", "Mick" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "audrey.obama@gov.us", "Audrey", "Obama" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "kate.windsor@nasa.org.us", "Kate", "Windsor" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "mick.winfrey@bbc.co.uk", "Mick", "Winfrey" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "charles.presley@gov.gr", "Charles", "Presley" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "jimi.winfrey@something.com", "Jimi", "Winfrey" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Email", "LastName" },
                values: new object[] { "mick.trump@gov.us", "Trump" });

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
                values: new object[] { "jimi.windsor@gov.ru", "Jimi", "Windsor" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Email", "FirstName" },
                values: new object[] { "barack.trump@gov.nl", "Barack" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "mick.trump@tesla.com", "Mick", "Trump" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Email", "FirstName" },
                values: new object[] { "mick.winslet@bbc.co.uk", "Mick" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Email", "LastName" },
                values: new object[] { "donald.hepburn@theworld.ca", "Hepburn" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Email", "LastName" },
                values: new object[] { "jimi.jagger@something.com", "Jagger" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "kate.middleton@something.com", "Kate", "Middleton" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "charles.obama@gov.gr", "Charles", "Obama" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "mick.windsor@nasa.org.us", "Mick", "Windsor" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "kate.winfrey@tesla.com", "Kate", "Winfrey" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "charles.hendrix@theworld.ca", "Charles", "Hendrix" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "oprah.presley@gov.ru", "Oprah", "Presley" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "donald.presley@theworld.ca", "Donald", "Presley" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Email", "LastName" },
                values: new object[] { "kate.winslet@nasa.org.us", "Winslet" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "audrey.obama@theworld.ca", "Audrey", "Obama" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 5, "A bunch of Orange Flowers" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 12, "A bunch of Orange Buildings" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 6, "The Rose Smelling Planets" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 25, "A herd of Purple Buildings" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 24, "Several Green Buildings" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 11, "A bunch of Bitter Houses" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 26, "The Transparent Flowers" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 20, "Fifteen Microscopic Buildings" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 1, "A bunch of Orange Flowers" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 27, "Fifteen Bitter Planets" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 30, "A bunch of Orange Flowers" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 36, "A bunch of Green Leopards" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 20, "An army of Large Planets" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 25, "The Purple Cars" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 6, "Several Transparent Leopards" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 33, "Fifteen Rose Smelling Leopards" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 4, "The Purple Houses" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 26, "An army of Purple Cars" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 27, "An army of Purple Cars" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 26, "An army of Green Houses" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 31, "A bunch of Rose Smelling Cars" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 39, "An army of Transparent Flowers" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 30, "The Green Planets" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 23, "A bunch of Rose Smelling Planets" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 29, "The Purple Flowers" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 27, "An army of Rose Smelling Planets" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 5, "Two Orange Cars" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 25, "An army of Green Leopards" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 33, "Fifteen Large Planets" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 12, "An army of Rose Smelling Houses" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 14, "A herd of Purple Leopards" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 12, "An army of Rose Smelling Planets" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 32, "Fifteen Purple Flowers" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 19, "The Large Planets" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 37, "A herd of Purple Leopards" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 29, "Several Microscopic Cars" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 22, "A bunch of Orange Flowers" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 26, "Fifteen Microscopic Flowers" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 29, "The Orange Houses" });

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
