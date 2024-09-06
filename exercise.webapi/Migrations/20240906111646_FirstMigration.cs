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
                name: "Authors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    FirstName = table.Column<string>(type: "text", nullable: false),
                    LastName = table.Column<string>(type: "text", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Title = table.Column<string>(type: "text", nullable: false),
                    AuthorId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Books_Authors_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Authors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "Email", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, "elvis.hepburn@bbc.co.uk", "Elvis", "Hepburn" },
                    { 2, "kate.presley@bbc.co.uk", "Kate", "Presley" },
                    { 3, "audrey.windsor@gov.gr", "Audrey", "Windsor" },
                    { 4, "mick.trump@gov.gr", "Mick", "Trump" },
                    { 5, "donald.winfrey@gov.nl", "Donald", "Winfrey" },
                    { 6, "oprah.middleton@gov.nl", "Oprah", "Middleton" },
                    { 7, "barack.trump@bbc.co.uk", "Barack", "Trump" },
                    { 8, "charles.trump@bbc.co.uk", "Charles", "Trump" },
                    { 9, "jimi.hepburn@gov.nl", "Jimi", "Hepburn" },
                    { 10, "charles.middleton@gov.gr", "Charles", "Middleton" },
                    { 11, "kate.jagger@tesla.com", "Kate", "Jagger" },
                    { 12, "mick.hendrix@gov.ru", "Mick", "Hendrix" },
                    { 13, "mick.middleton@gov.us", "Mick", "Middleton" },
                    { 14, "oprah.trump@gov.us", "Oprah", "Trump" },
                    { 15, "kate.trump@gov.us", "Kate", "Trump" },
                    { 16, "donald.hepburn@gov.us", "Donald", "Hepburn" },
                    { 17, "mick.presley@something.com", "Mick", "Presley" },
                    { 18, "audrey.obama@gov.us", "Audrey", "Obama" },
                    { 19, "kate.windsor@nasa.org.us", "Kate", "Windsor" },
                    { 20, "mick.winfrey@bbc.co.uk", "Mick", "Winfrey" },
                    { 21, "charles.presley@gov.gr", "Charles", "Presley" },
                    { 22, "jimi.winfrey@something.com", "Jimi", "Winfrey" },
                    { 23, "mick.trump@gov.us", "Mick", "Trump" },
                    { 24, "mick.presley@bbc.co.uk", "Mick", "Presley" },
                    { 25, "jimi.windsor@gov.ru", "Jimi", "Windsor" },
                    { 26, "barack.trump@gov.nl", "Barack", "Trump" },
                    { 27, "mick.trump@tesla.com", "Mick", "Trump" },
                    { 28, "mick.winslet@bbc.co.uk", "Mick", "Winslet" },
                    { 29, "donald.hepburn@theworld.ca", "Donald", "Hepburn" },
                    { 30, "jimi.jagger@something.com", "Jimi", "Jagger" },
                    { 31, "kate.middleton@something.com", "Kate", "Middleton" },
                    { 32, "charles.obama@gov.gr", "Charles", "Obama" },
                    { 33, "mick.windsor@nasa.org.us", "Mick", "Windsor" },
                    { 34, "kate.winfrey@tesla.com", "Kate", "Winfrey" },
                    { 35, "charles.hendrix@theworld.ca", "Charles", "Hendrix" },
                    { 36, "oprah.presley@gov.ru", "Oprah", "Presley" },
                    { 37, "donald.presley@theworld.ca", "Donald", "Presley" },
                    { 38, "kate.winslet@nasa.org.us", "Kate", "Winslet" },
                    { 39, "audrey.obama@theworld.ca", "Audrey", "Obama" }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Title" },
                values: new object[,]
                {
                    { 1, 5, "A bunch of Orange Flowers" },
                    { 2, 12, "A bunch of Orange Buildings" },
                    { 3, 6, "The Rose Smelling Planets" },
                    { 4, 25, "A herd of Purple Buildings" },
                    { 5, 24, "Several Green Buildings" },
                    { 6, 11, "A bunch of Bitter Houses" },
                    { 7, 26, "The Transparent Flowers" },
                    { 8, 20, "Fifteen Microscopic Buildings" },
                    { 9, 1, "A bunch of Orange Flowers" },
                    { 10, 27, "Fifteen Bitter Planets" },
                    { 11, 30, "A bunch of Orange Flowers" },
                    { 12, 36, "A bunch of Green Leopards" },
                    { 13, 20, "An army of Large Planets" },
                    { 14, 25, "The Purple Cars" },
                    { 15, 6, "Several Transparent Leopards" },
                    { 16, 33, "Fifteen Rose Smelling Leopards" },
                    { 17, 4, "The Purple Houses" },
                    { 18, 26, "An army of Purple Cars" },
                    { 19, 27, "An army of Purple Cars" },
                    { 20, 26, "An army of Green Houses" },
                    { 21, 31, "A bunch of Rose Smelling Cars" },
                    { 22, 39, "An army of Transparent Flowers" },
                    { 23, 30, "The Green Planets" },
                    { 24, 23, "A bunch of Rose Smelling Planets" },
                    { 25, 29, "The Purple Flowers" },
                    { 26, 27, "An army of Rose Smelling Planets" },
                    { 27, 5, "Two Orange Cars" },
                    { 28, 25, "An army of Green Leopards" },
                    { 29, 33, "Fifteen Large Planets" },
                    { 30, 12, "An army of Rose Smelling Houses" },
                    { 31, 14, "A herd of Purple Leopards" },
                    { 32, 12, "An army of Rose Smelling Planets" },
                    { 33, 32, "Fifteen Purple Flowers" },
                    { 34, 19, "The Large Planets" },
                    { 35, 37, "A herd of Purple Leopards" },
                    { 36, 29, "Several Microscopic Cars" },
                    { 37, 22, "A bunch of Orange Flowers" },
                    { 38, 26, "Fifteen Microscopic Flowers" },
                    { 39, 29, "The Orange Houses" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Books_AuthorId",
                table: "Books",
                column: "AuthorId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "Authors");
        }
    }
}
