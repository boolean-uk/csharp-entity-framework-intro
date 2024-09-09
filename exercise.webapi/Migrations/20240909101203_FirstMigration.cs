using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace exercise.webapi.Migrations
{
    /// <inheritdoc />
    public partial class FirstMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "authors",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    firstname = table.Column<string>(type: "text", nullable: false),
                    lastname = table.Column<string>(type: "text", nullable: false),
                    email = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_authors", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "publishers",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    firstname = table.Column<string>(type: "text", nullable: false),
                    lastname = table.Column<string>(type: "text", nullable: false),
                    email = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_publishers", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "books",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    title = table.Column<string>(type: "text", nullable: false),
                    AuthorId = table.Column<int>(type: "integer", nullable: false),
                    PublisherId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_books", x => x.id);
                    table.ForeignKey(
                        name: "FK_books_authors_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "authors",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_books_publishers_PublisherId",
                        column: x => x.PublisherId,
                        principalTable: "publishers",
                        principalColumn: "id");
                });

            migrationBuilder.InsertData(
                table: "authors",
                columns: new[] { "id", "email", "firstname", "lastname" },
                values: new object[,]
                {
                    { 1, "audrey.obama@bbc.co.uk", "Audrey", "Obama" },
                    { 2, "donald.hendrix@bbc.co.uk", "Donald", "Hendrix" },
                    { 3, "donald.hepburn@tesla.com", "Donald", "Hepburn" },
                    { 4, "mick.trump@google.com", "Mick", "Trump" },
                    { 5, "charles.obama@gov.us", "Charles", "Obama" },
                    { 6, "kate.windsor@tesla.com", "Kate", "Windsor" },
                    { 7, "oprah.windsor@nasa.org.us", "Oprah", "Windsor" },
                    { 8, "kate.jagger@gov.ru", "Kate", "Jagger" },
                    { 9, "kate.middleton@google.com", "Kate", "Middleton" },
                    { 10, "kate.hendrix@tesla.com", "Kate", "Hendrix" },
                    { 11, "barack.middleton@gov.gr", "Barack", "Middleton" },
                    { 12, "barack.middleton@gov.nl", "Barack", "Middleton" },
                    { 13, "jimi.windsor@theworld.ca", "Jimi", "Windsor" },
                    { 14, "kate.presley@gov.ru", "Kate", "Presley" },
                    { 15, "oprah.hendrix@gov.us", "Oprah", "Hendrix" },
                    { 16, "kate.windsor@gov.gr", "Kate", "Windsor" },
                    { 17, "kate.presley@google.com", "Kate", "Presley" },
                    { 18, "audrey.presley@bbc.co.uk", "Audrey", "Presley" },
                    { 19, "oprah.trump@gov.ru", "Oprah", "Trump" },
                    { 20, "charles.hepburn@theworld.ca", "Charles", "Hepburn" },
                    { 21, "kate.middleton@gov.us", "Kate", "Middleton" },
                    { 22, "kate.hepburn@gov.us", "Kate", "Hepburn" },
                    { 23, "audrey.jagger@theworld.ca", "Audrey", "Jagger" },
                    { 24, "jimi.middleton@google.com", "Jimi", "Middleton" },
                    { 25, "elvis.middleton@theworld.ca", "Elvis", "Middleton" },
                    { 26, "jimi.jagger@gov.us", "Jimi", "Jagger" },
                    { 27, "audrey.jagger@gov.gr", "Audrey", "Jagger" },
                    { 28, "oprah.jagger@tesla.com", "Oprah", "Jagger" },
                    { 29, "elvis.trump@tesla.com", "Elvis", "Trump" },
                    { 30, "oprah.winfrey@google.com", "Oprah", "Winfrey" },
                    { 31, "oprah.middleton@bbc.co.uk", "Oprah", "Middleton" },
                    { 32, "elvis.middleton@gov.us", "Elvis", "Middleton" },
                    { 33, "audrey.hendrix@gov.ru", "Audrey", "Hendrix" },
                    { 34, "kate.obama@bbc.co.uk", "Kate", "Obama" },
                    { 35, "barack.presley@gov.nl", "Barack", "Presley" },
                    { 36, "audrey.jagger@theworld.ca", "Audrey", "Jagger" },
                    { 37, "jimi.presley@bbc.co.uk", "Jimi", "Presley" },
                    { 38, "kate.hendrix@gov.gr", "Kate", "Hendrix" },
                    { 39, "charles.obama@nasa.org.us", "Charles", "Obama" },
                    { 40, "donald.jagger@gov.gr", "Donald", "Jagger" },
                    { 41, "barack.winslet@gov.us", "Barack", "Winslet" },
                    { 42, "kate.middleton@tesla.com", "Kate", "Middleton" },
                    { 43, "jimi.windsor@gov.gr", "Jimi", "Windsor" },
                    { 44, "donald.winslet@gov.ru", "Donald", "Winslet" },
                    { 45, "donald.winslet@tesla.com", "Donald", "Winslet" },
                    { 46, "barack.hepburn@nasa.org.us", "Barack", "Hepburn" },
                    { 47, "kate.winslet@something.com", "Kate", "Winslet" },
                    { 48, "elvis.winfrey@tesla.com", "Elvis", "Winfrey" },
                    { 49, "kate.hepburn@gov.us", "Kate", "Hepburn" },
                    { 50, "kate.windsor@tesla.com", "Kate", "Windsor" },
                    { 51, "charles.hepburn@tesla.com", "Charles", "Hepburn" },
                    { 52, "charles.winfrey@gov.gr", "Charles", "Winfrey" },
                    { 53, "elvis.jagger@nasa.org.us", "Elvis", "Jagger" },
                    { 54, "kate.hendrix@something.com", "Kate", "Hendrix" },
                    { 55, "oprah.winslet@gov.nl", "Oprah", "Winslet" },
                    { 56, "elvis.jagger@nasa.org.us", "Elvis", "Jagger" },
                    { 57, "mick.trump@gov.gr", "Mick", "Trump" },
                    { 58, "mick.windsor@something.com", "Mick", "Windsor" },
                    { 59, "donald.hepburn@gov.gr", "Donald", "Hepburn" },
                    { 60, "elvis.presley@tesla.com", "Elvis", "Presley" },
                    { 61, "donald.middleton@google.com", "Donald", "Middleton" },
                    { 62, "oprah.winslet@bbc.co.uk", "Oprah", "Winslet" },
                    { 63, "jimi.windsor@bbc.co.uk", "Jimi", "Windsor" },
                    { 64, "kate.trump@gov.us", "Kate", "Trump" },
                    { 65, "mick.obama@something.com", "Mick", "Obama" },
                    { 66, "elvis.presley@tesla.com", "Elvis", "Presley" },
                    { 67, "jimi.hepburn@bbc.co.uk", "Jimi", "Hepburn" },
                    { 68, "charles.jagger@gov.gr", "Charles", "Jagger" },
                    { 69, "kate.winfrey@tesla.com", "Kate", "Winfrey" },
                    { 70, "kate.winslet@nasa.org.us", "Kate", "Winslet" },
                    { 71, "audrey.winslet@gov.ru", "Audrey", "Winslet" },
                    { 72, "charles.winfrey@gov.ru", "Charles", "Winfrey" },
                    { 73, "elvis.winslet@tesla.com", "Elvis", "Winslet" },
                    { 74, "mick.hendrix@tesla.com", "Mick", "Hendrix" },
                    { 75, "kate.windsor@gov.us", "Kate", "Windsor" },
                    { 76, "kate.trump@gov.nl", "Kate", "Trump" },
                    { 77, "elvis.trump@nasa.org.us", "Elvis", "Trump" },
                    { 78, "jimi.trump@bbc.co.uk", "Jimi", "Trump" },
                    { 79, "charles.winfrey@tesla.com", "Charles", "Winfrey" },
                    { 80, "kate.presley@gov.nl", "Kate", "Presley" },
                    { 81, "mick.hepburn@google.com", "Mick", "Hepburn" },
                    { 82, "jimi.hendrix@theworld.ca", "Jimi", "Hendrix" },
                    { 83, "kate.winslet@google.com", "Kate", "Winslet" },
                    { 84, "jimi.presley@gov.gr", "Jimi", "Presley" },
                    { 85, "mick.middleton@nasa.org.us", "Mick", "Middleton" },
                    { 86, "kate.obama@google.com", "Kate", "Obama" },
                    { 87, "audrey.middleton@gov.nl", "Audrey", "Middleton" },
                    { 88, "jimi.hepburn@nasa.org.us", "Jimi", "Hepburn" },
                    { 89, "donald.winslet@gov.us", "Donald", "Winslet" },
                    { 90, "charles.jagger@gov.nl", "Charles", "Jagger" },
                    { 91, "kate.trump@tesla.com", "Kate", "Trump" },
                    { 92, "mick.presley@gov.gr", "Mick", "Presley" },
                    { 93, "barack.trump@google.com", "Barack", "Trump" },
                    { 94, "donald.jagger@gov.ru", "Donald", "Jagger" },
                    { 95, "charles.winfrey@theworld.ca", "Charles", "Winfrey" },
                    { 96, "charles.hendrix@gov.us", "Charles", "Hendrix" },
                    { 97, "jimi.obama@gov.nl", "Jimi", "Obama" },
                    { 98, "audrey.winfrey@gov.nl", "Audrey", "Winfrey" },
                    { 99, "charles.presley@theworld.ca", "Charles", "Presley" }
                });

            migrationBuilder.InsertData(
                table: "publishers",
                columns: new[] { "id", "email", "firstname", "lastname" },
                values: new object[,]
                {
                    { 1, "oprah.winfrey@theworld.ca", "Oprah", "Winfrey" },
                    { 2, "barack.jagger@tesla.com", "Barack", "Jagger" },
                    { 3, "barack.trump@gov.gr", "Barack", "Trump" },
                    { 4, "barack.hepburn@gov.gr", "Barack", "Hepburn" },
                    { 5, "audrey.jagger@gov.us", "Audrey", "Jagger" },
                    { 6, "kate.jagger@google.com", "Kate", "Jagger" },
                    { 7, "donald.winslet@google.com", "Donald", "Winslet" },
                    { 8, "kate.hepburn@gov.gr", "Kate", "Hepburn" },
                    { 9, "charles.hepburn@gov.nl", "Charles", "Hepburn" },
                    { 10, "kate.middleton@theworld.ca", "Kate", "Middleton" },
                    { 11, "kate.winfrey@something.com", "Kate", "Winfrey" },
                    { 12, "audrey.hepburn@bbc.co.uk", "Audrey", "Hepburn" },
                    { 13, "charles.trump@google.com", "Charles", "Trump" },
                    { 14, "elvis.jagger@tesla.com", "Elvis", "Jagger" },
                    { 15, "donald.middleton@something.com", "Donald", "Middleton" },
                    { 16, "oprah.trump@bbc.co.uk", "Oprah", "Trump" },
                    { 17, "kate.winslet@tesla.com", "Kate", "Winslet" },
                    { 18, "kate.windsor@gov.nl", "Kate", "Windsor" },
                    { 19, "audrey.middleton@gov.gr", "Audrey", "Middleton" },
                    { 20, "oprah.winslet@tesla.com", "Oprah", "Winslet" },
                    { 21, "elvis.hepburn@gov.gr", "Elvis", "Hepburn" },
                    { 22, "charles.windsor@gov.ru", "Charles", "Windsor" },
                    { 23, "kate.hendrix@something.com", "Kate", "Hendrix" },
                    { 24, "mick.winslet@gov.ru", "Mick", "Winslet" },
                    { 25, "charles.middleton@gov.us", "Charles", "Middleton" },
                    { 26, "kate.winslet@something.com", "Kate", "Winslet" },
                    { 27, "barack.obama@something.com", "Barack", "Obama" },
                    { 28, "charles.winfrey@nasa.org.us", "Charles", "Winfrey" },
                    { 29, "elvis.trump@gov.ru", "Elvis", "Trump" },
                    { 30, "kate.winslet@gov.nl", "Kate", "Winslet" },
                    { 31, "kate.jagger@gov.ru", "Kate", "Jagger" },
                    { 32, "jimi.winslet@tesla.com", "Jimi", "Winslet" },
                    { 33, "audrey.winfrey@theworld.ca", "Audrey", "Winfrey" },
                    { 34, "charles.middleton@tesla.com", "Charles", "Middleton" },
                    { 35, "audrey.obama@tesla.com", "Audrey", "Obama" },
                    { 36, "jimi.windsor@gov.nl", "Jimi", "Windsor" },
                    { 37, "donald.middleton@nasa.org.us", "Donald", "Middleton" },
                    { 38, "jimi.jagger@gov.nl", "Jimi", "Jagger" },
                    { 39, "donald.obama@gov.gr", "Donald", "Obama" },
                    { 40, "elvis.jagger@gov.nl", "Elvis", "Jagger" },
                    { 41, "kate.jagger@nasa.org.us", "Kate", "Jagger" },
                    { 42, "kate.windsor@gov.gr", "Kate", "Windsor" },
                    { 43, "donald.winslet@gov.nl", "Donald", "Winslet" },
                    { 44, "donald.middleton@gov.us", "Donald", "Middleton" },
                    { 45, "kate.jagger@gov.nl", "Kate", "Jagger" },
                    { 46, "kate.winslet@tesla.com", "Kate", "Winslet" },
                    { 47, "mick.obama@bbc.co.uk", "Mick", "Obama" },
                    { 48, "oprah.winfrey@gov.ru", "Oprah", "Winfrey" },
                    { 49, "jimi.presley@gov.us", "Jimi", "Presley" },
                    { 50, "oprah.trump@tesla.com", "Oprah", "Trump" },
                    { 51, "donald.hepburn@something.com", "Donald", "Hepburn" },
                    { 52, "donald.hendrix@theworld.ca", "Donald", "Hendrix" },
                    { 53, "barack.jagger@something.com", "Barack", "Jagger" },
                    { 54, "barack.winslet@gov.nl", "Barack", "Winslet" },
                    { 55, "kate.hepburn@bbc.co.uk", "Kate", "Hepburn" },
                    { 56, "jimi.winfrey@gov.gr", "Jimi", "Winfrey" },
                    { 57, "donald.trump@gov.gr", "Donald", "Trump" },
                    { 58, "elvis.winslet@gov.us", "Elvis", "Winslet" },
                    { 59, "oprah.hepburn@gov.ru", "Oprah", "Hepburn" },
                    { 60, "mick.middleton@bbc.co.uk", "Mick", "Middleton" },
                    { 61, "mick.winfrey@theworld.ca", "Mick", "Winfrey" },
                    { 62, "kate.winslet@google.com", "Kate", "Winslet" },
                    { 63, "jimi.trump@bbc.co.uk", "Jimi", "Trump" },
                    { 64, "oprah.winfrey@something.com", "Oprah", "Winfrey" },
                    { 65, "audrey.hepburn@gov.nl", "Audrey", "Hepburn" },
                    { 66, "mick.winslet@gov.gr", "Mick", "Winslet" },
                    { 67, "kate.winfrey@bbc.co.uk", "Kate", "Winfrey" },
                    { 68, "barack.presley@something.com", "Barack", "Presley" },
                    { 69, "jimi.jagger@gov.us", "Jimi", "Jagger" },
                    { 70, "donald.winslet@tesla.com", "Donald", "Winslet" },
                    { 71, "barack.winfrey@theworld.ca", "Barack", "Winfrey" },
                    { 72, "jimi.hendrix@gov.ru", "Jimi", "Hendrix" },
                    { 73, "kate.winfrey@theworld.ca", "Kate", "Winfrey" },
                    { 74, "jimi.winfrey@tesla.com", "Jimi", "Winfrey" },
                    { 75, "kate.windsor@google.com", "Kate", "Windsor" },
                    { 76, "kate.windsor@gov.nl", "Kate", "Windsor" },
                    { 77, "donald.winfrey@theworld.ca", "Donald", "Winfrey" },
                    { 78, "donald.windsor@tesla.com", "Donald", "Windsor" },
                    { 79, "mick.hendrix@theworld.ca", "Mick", "Hendrix" },
                    { 80, "elvis.presley@bbc.co.uk", "Elvis", "Presley" },
                    { 81, "audrey.jagger@gov.gr", "Audrey", "Jagger" },
                    { 82, "charles.hepburn@gov.ru", "Charles", "Hepburn" },
                    { 83, "mick.trump@something.com", "Mick", "Trump" },
                    { 84, "donald.trump@tesla.com", "Donald", "Trump" },
                    { 85, "audrey.winslet@gov.us", "Audrey", "Winslet" },
                    { 86, "oprah.hepburn@google.com", "Oprah", "Hepburn" },
                    { 87, "barack.hepburn@gov.gr", "Barack", "Hepburn" },
                    { 88, "barack.trump@nasa.org.us", "Barack", "Trump" },
                    { 89, "oprah.winfrey@gov.us", "Oprah", "Winfrey" },
                    { 90, "charles.jagger@gov.nl", "Charles", "Jagger" },
                    { 91, "oprah.winfrey@nasa.org.us", "Oprah", "Winfrey" },
                    { 92, "kate.hendrix@google.com", "Kate", "Hendrix" },
                    { 93, "elvis.trump@theworld.ca", "Elvis", "Trump" },
                    { 94, "donald.winslet@google.com", "Donald", "Winslet" },
                    { 95, "audrey.winslet@something.com", "Audrey", "Winslet" },
                    { 96, "kate.middleton@nasa.org.us", "Kate", "Middleton" },
                    { 97, "oprah.hepburn@gov.gr", "Oprah", "Hepburn" },
                    { 98, "mick.middleton@gov.nl", "Mick", "Middleton" },
                    { 99, "kate.winslet@gov.gr", "Kate", "Winslet" }
                });

            migrationBuilder.InsertData(
                table: "books",
                columns: new[] { "id", "AuthorId", "PublisherId", "title" },
                values: new object[,]
                {
                    { 1, 78, 99, "Fifteen Microscopic Flowers" },
                    { 2, 86, 57, "Fifteen Transparent Leopards" },
                    { 3, 46, 48, "A bunch of Orange Houses" },
                    { 4, 67, 56, "Two Purple Planets" },
                    { 5, 33, 1, "An army of Orange Buildings" },
                    { 6, 53, 34, "Two Transparent Buildings" },
                    { 7, 19, 61, "Fifteen Large Leopards" },
                    { 8, 59, 62, "Several Large Flowers" },
                    { 9, 89, 14, "A herd of Large Buildings" },
                    { 10, 75, 80, "A bunch of Orange Buildings" },
                    { 11, 27, 52, "Several Bitter Flowers" },
                    { 12, 43, 66, "Fifteen Orange Cars" },
                    { 13, 6, 18, "The Orange Flowers" },
                    { 14, 53, 62, "A herd of Large Flowers" },
                    { 15, 37, 4, "A herd of Microscopic Houses" },
                    { 16, 33, 36, "A bunch of Bitter Houses" },
                    { 17, 59, 80, "An army of Purple Cars" },
                    { 18, 53, 21, "Two Large Flowers" },
                    { 19, 48, 24, "Two Green Flowers" },
                    { 20, 30, 79, "Two Purple Planets" },
                    { 21, 62, 60, "Several Green Flowers" },
                    { 22, 84, 26, "A herd of Purple Houses" },
                    { 23, 78, 89, "Fifteen Large Buildings" },
                    { 24, 52, 51, "Several Microscopic Flowers" },
                    { 25, 13, 48, "Two Microscopic Leopards" },
                    { 26, 45, 11, "A herd of Rose Smelling Flowers" },
                    { 27, 77, 75, "Several Green Houses" },
                    { 28, 18, 6, "Two Green Houses" },
                    { 29, 48, 8, "A herd of Green Cars" },
                    { 30, 13, 54, "The Purple Houses" },
                    { 31, 72, 93, "An army of Bitter Planets" },
                    { 32, 38, 87, "Several Green Leopards" },
                    { 33, 81, 71, "Two Microscopic Houses" },
                    { 34, 33, 30, "A bunch of Green Planets" },
                    { 35, 3, 76, "Fifteen Bitter Buildings" },
                    { 36, 54, 20, "Fifteen Purple Houses" },
                    { 37, 77, 94, "Two Large Houses" },
                    { 38, 39, 90, "A bunch of Bitter Planets" },
                    { 39, 71, 93, "The Purple Flowers" },
                    { 40, 1, 15, "Fifteen Large Cars" },
                    { 41, 84, 30, "An army of Large Planets" },
                    { 42, 39, 90, "A herd of Bitter Flowers" },
                    { 43, 34, 56, "An army of Bitter Planets" },
                    { 44, 69, 90, "A bunch of Green Planets" },
                    { 45, 90, 30, "Fifteen Green Buildings" },
                    { 46, 64, 39, "The Green Planets" },
                    { 47, 74, 24, "An army of Transparent Flowers" },
                    { 48, 15, 90, "Several Large Planets" },
                    { 49, 90, 46, "Two Large Buildings" },
                    { 50, 13, 82, "An army of Large Houses" },
                    { 51, 23, 20, "Several Orange Buildings" },
                    { 52, 62, 10, "Two Green Leopards" },
                    { 53, 26, 77, "A herd of Microscopic Planets" },
                    { 54, 87, 12, "Several Rose Smelling Leopards" },
                    { 55, 57, 90, "Two Bitter Planets" },
                    { 56, 26, 33, "Several Purple Buildings" },
                    { 57, 5, 25, "The Green Houses" },
                    { 58, 23, 61, "An army of Rose Smelling Planets" },
                    { 59, 83, 43, "A bunch of Large Planets" },
                    { 60, 71, 46, "A bunch of Large Cars" },
                    { 61, 26, 53, "A bunch of Transparent Planets" },
                    { 62, 50, 89, "The Rose Smelling Buildings" },
                    { 63, 8, 20, "Fifteen Orange Cars" },
                    { 64, 12, 90, "Two Green Planets" },
                    { 65, 55, 91, "Two Green Buildings" },
                    { 66, 2, 18, "The Purple Planets" },
                    { 67, 65, 73, "Several Large Buildings" },
                    { 68, 53, 70, "Several Green Cars" },
                    { 69, 10, 95, "An army of Large Planets" },
                    { 70, 57, 93, "An army of Large Houses" },
                    { 71, 74, 17, "Two Bitter Planets" },
                    { 72, 81, 99, "A bunch of Large Leopards" },
                    { 73, 70, 75, "Several Purple Houses" },
                    { 74, 25, 39, "An army of Orange Flowers" },
                    { 75, 65, 26, "Two Purple Buildings" },
                    { 76, 42, 99, "The Orange Flowers" },
                    { 77, 18, 18, "A herd of Orange Flowers" },
                    { 78, 21, 73, "The Green Buildings" },
                    { 79, 72, 74, "An army of Rose Smelling Buildings" },
                    { 80, 76, 63, "An army of Green Leopards" },
                    { 81, 99, 84, "The Microscopic Flowers" },
                    { 82, 76, 16, "A herd of Transparent Leopards" },
                    { 83, 91, 37, "A bunch of Large Houses" },
                    { 84, 60, 23, "Several Rose Smelling Flowers" },
                    { 85, 34, 88, "Fifteen Microscopic Planets" },
                    { 86, 28, 58, "Several Bitter Cars" },
                    { 87, 22, 96, "The Large Leopards" },
                    { 88, 51, 55, "Several Large Leopards" },
                    { 89, 36, 28, "An army of Purple Leopards" },
                    { 90, 73, 18, "Fifteen Purple Flowers" },
                    { 91, 66, 64, "An army of Bitter Leopards" },
                    { 92, 33, 66, "An army of Large Leopards" },
                    { 93, 58, 76, "An army of Orange Buildings" },
                    { 94, 71, 28, "The Green Flowers" },
                    { 95, 67, 33, "Several Microscopic Leopards" },
                    { 96, 33, 47, "A bunch of Purple Cars" },
                    { 97, 95, 96, "Fifteen Green Houses" },
                    { 98, 17, 53, "An army of Orange Houses" },
                    { 99, 53, 25, "Fifteen Green Leopards" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_books_AuthorId",
                table: "books",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_books_PublisherId",
                table: "books",
                column: "PublisherId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "books");

            migrationBuilder.DropTable(
                name: "authors");

            migrationBuilder.DropTable(
                name: "publishers");
        }
    }
}
