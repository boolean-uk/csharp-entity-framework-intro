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
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    first_name = table.Column<string>(type: "text", nullable: false),
                    last_name = table.Column<string>(type: "text", nullable: false),
                    email = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authors", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "publishers",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "text", nullable: false)
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
                    PublisherId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_books", x => x.id);
                    table.ForeignKey(
                        name: "FK_books_Authors_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Authors",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_books_publishers_PublisherId",
                        column: x => x.PublisherId,
                        principalTable: "publishers",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "id", "email", "first_name", "last_name" },
                values: new object[,]
                {
                    { 1, "oprah.winslet@gov.ru", "Oprah", "Winslet" },
                    { 2, "kate.obama@google.com", "Kate", "Obama" },
                    { 3, "kate.middleton@gov.gr", "Kate", "Middleton" },
                    { 4, "charles.trump@tesla.com", "Charles", "Trump" },
                    { 5, "audrey.winslet@bbc.co.uk", "Audrey", "Winslet" },
                    { 6, "donald.hepburn@something.com", "Donald", "Hepburn" },
                    { 7, "elvis.hepburn@gov.nl", "Elvis", "Hepburn" },
                    { 8, "oprah.winslet@gov.ru", "Oprah", "Winslet" },
                    { 9, "kate.hepburn@something.com", "Kate", "Hepburn" },
                    { 10, "barack.winfrey@gov.ru", "Barack", "Winfrey" },
                    { 11, "mick.middleton@something.com", "Mick", "Middleton" },
                    { 12, "elvis.presley@gov.us", "Elvis", "Presley" },
                    { 13, "charles.winslet@gov.us", "Charles", "Winslet" },
                    { 14, "barack.presley@google.com", "Barack", "Presley" },
                    { 15, "jimi.winfrey@google.com", "Jimi", "Winfrey" },
                    { 16, "kate.obama@gov.ru", "Kate", "Obama" },
                    { 17, "kate.winfrey@gov.nl", "Kate", "Winfrey" },
                    { 18, "barack.windsor@gov.nl", "Barack", "Windsor" },
                    { 19, "oprah.trump@gov.us", "Oprah", "Trump" },
                    { 20, "audrey.middleton@theworld.ca", "Audrey", "Middleton" },
                    { 21, "jimi.windsor@nasa.org.us", "Jimi", "Windsor" },
                    { 22, "kate.windsor@google.com", "Kate", "Windsor" },
                    { 23, "elvis.obama@gov.gr", "Elvis", "Obama" },
                    { 24, "mick.obama@gov.us", "Mick", "Obama" },
                    { 25, "charles.middleton@bbc.co.uk", "Charles", "Middleton" },
                    { 26, "elvis.hendrix@gov.ru", "Elvis", "Hendrix" },
                    { 27, "elvis.jagger@gov.gr", "Elvis", "Jagger" },
                    { 28, "mick.presley@google.com", "Mick", "Presley" },
                    { 29, "elvis.winslet@gov.nl", "Elvis", "Winslet" }
                });

            migrationBuilder.InsertData(
                table: "publishers",
                columns: new[] { "id", "name" },
                values: new object[,]
                {
                    { 1, "Pegalon" },
                    { 2, "Gyldenme" },
                    { 3, "Flamber" },
                    { 4, "Pegage" },
                    { 5, "Kagsus" },
                    { 6, "Pegadal" },
                    { 7, "Flamme" },
                    { 8, "Cappehoug" },
                    { 9, "Gyldenlon" },
                    { 10, "Flamlen" },
                    { 11, "Kagme" },
                    { 12, "Oktodal" },
                    { 13, "Oktoge" },
                    { 14, "Cappege" }
                });

            migrationBuilder.InsertData(
                table: "books",
                columns: new[] { "id", "AuthorId", "PublisherId", "title" },
                values: new object[,]
                {
                    { 1, 24, 6, "Two Rose Smelling Buildings" },
                    { 2, 5, 13, "Fifteen Large Planets" },
                    { 3, 7, 12, "Several Large Buildings" },
                    { 4, 7, 1, "A bunch of Orange Flowers" },
                    { 5, 25, 13, "A herd of Bitter Flowers" },
                    { 6, 8, 12, "Two Orange Planets" },
                    { 7, 18, 6, "The Purple Cars" },
                    { 8, 13, 3, "A herd of Microscopic Houses" },
                    { 9, 21, 4, "Fifteen Purple Planets" },
                    { 10, 28, 13, "An army of Transparent Flowers" },
                    { 11, 13, 8, "Fifteen Transparent Houses" },
                    { 12, 22, 1, "Fifteen Rose Smelling Houses" },
                    { 13, 5, 8, "A bunch of Large Houses" },
                    { 14, 18, 14, "Several Microscopic Cars" },
                    { 15, 8, 5, "A herd of Microscopic Buildings" },
                    { 16, 17, 12, "Several Purple Cars" },
                    { 17, 16, 4, "Two Green Houses" },
                    { 18, 13, 12, "The Purple Houses" },
                    { 19, 3, 8, "A herd of Bitter Cars" },
                    { 20, 19, 5, "A bunch of Orange Cars" },
                    { 21, 16, 9, "A herd of Rose Smelling Cars" },
                    { 22, 29, 3, "A herd of Bitter Planets" },
                    { 23, 28, 8, "Several Transparent Planets" },
                    { 24, 18, 14, "An army of Rose Smelling Buildings" },
                    { 25, 4, 3, "Two Large Flowers" },
                    { 26, 22, 3, "A herd of Rose Smelling Flowers" },
                    { 27, 16, 14, "Two Purple Leopards" },
                    { 28, 15, 2, "A herd of Orange Houses" },
                    { 29, 3, 11, "Several Large Houses" }
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
                name: "Authors");

            migrationBuilder.DropTable(
                name: "publishers");
        }
    }
}
