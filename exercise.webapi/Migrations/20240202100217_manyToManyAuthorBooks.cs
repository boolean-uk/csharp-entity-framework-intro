using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace exercise.webapi.Migrations
{
    /// <inheritdoc />
    public partial class manyToManyAuthorBooks : Migration
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
                    first_name = table.Column<string>(type: "text", nullable: false),
                    last_name = table.Column<string>(type: "text", nullable: false),
                    email = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_authors", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "publisher",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_publisher", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "books",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    title = table.Column<string>(type: "text", nullable: false),
                    fk_publisher_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_books", x => x.id);
                    table.ForeignKey(
                        name: "FK_books_publisher_fk_publisher_id",
                        column: x => x.fk_publisher_id,
                        principalTable: "publisher",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AuthorBooks",
                columns: table => new
                {
                    ppk_author_id = table.Column<int>(type: "integer", nullable: false),
                    ppk_book_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuthorBooks", x => new { x.ppk_author_id, x.ppk_book_id });
                    table.ForeignKey(
                        name: "FK_AuthorBooks_authors_ppk_author_id",
                        column: x => x.ppk_author_id,
                        principalTable: "authors",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AuthorBooks_books_ppk_book_id",
                        column: x => x.ppk_book_id,
                        principalTable: "books",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "authors",
                columns: new[] { "id", "email", "first_name", "last_name" },
                values: new object[,]
                {
                    { 1, "oprah.winfrey@gov.us", "Oprah", "Winfrey" },
                    { 2, "audrey.hendrix@tesla.com", "Audrey", "Hendrix" },
                    { 3, "kate.hepburn@tesla.com", "Kate", "Hepburn" },
                    { 4, "donald.windsor@google.com", "Donald", "Windsor" },
                    { 5, "charles.hendrix@bbc.co.uk", "Charles", "Hendrix" },
                    { 6, "donald.jagger@something.com", "Donald", "Jagger" },
                    { 7, "charles.jagger@bbc.co.uk", "Charles", "Jagger" },
                    { 8, "oprah.winslet@gov.gr", "Oprah", "Winslet" },
                    { 9, "audrey.jagger@bbc.co.uk", "Audrey", "Jagger" }
                });

            migrationBuilder.InsertData(
                table: "publisher",
                columns: new[] { "id", "name" },
                values: new object[,]
                {
                    { 1, "Merriam Webster" },
                    { 2, "Merriam Webster" },
                    { 3, "Penguin Collins" },
                    { 4, "Macmillan Library" }
                });

            migrationBuilder.InsertData(
                table: "books",
                columns: new[] { "id", "fk_publisher_id", "title" },
                values: new object[,]
                {
                    { 1, 4, "Two Large Cars" },
                    { 2, 3, "Two Purple Leopards" },
                    { 3, 2, "Fifteen Purple Cars" },
                    { 4, 3, "A herd of Purple Planets" },
                    { 5, 1, "The Large Planets" },
                    { 6, 1, "Fifteen Green Buildings" },
                    { 7, 3, "An army of Bitter Planets" },
                    { 8, 3, "Fifteen Transparent Buildings" },
                    { 9, 3, "A herd of Microscopic Houses" },
                    { 10, 1, "A bunch of Purple Cars" },
                    { 11, 2, "Two Large Cars" },
                    { 12, 4, "An army of Orange Buildings" },
                    { 13, 4, "A herd of Green Planets" },
                    { 14, 4, "An army of Green Flowers" },
                    { 15, 1, "Fifteen Bitter Leopards" },
                    { 16, 2, "The Microscopic Flowers" },
                    { 17, 1, "Fifteen Purple Buildings" },
                    { 18, 2, "An army of Rose Smelling Buildings" },
                    { 19, 1, "An army of Bitter Leopards" },
                    { 20, 2, "An army of Purple Houses" },
                    { 21, 3, "A bunch of Orange Cars" },
                    { 22, 2, "Several Transparent Houses" },
                    { 23, 3, "An army of Microscopic Buildings" },
                    { 24, 2, "Fifteen Large Flowers" }
                });

            migrationBuilder.InsertData(
                table: "AuthorBooks",
                columns: new[] { "ppk_author_id", "ppk_book_id" },
                values: new object[] { 1, 1 });

            migrationBuilder.CreateIndex(
                name: "IX_AuthorBooks_ppk_book_id",
                table: "AuthorBooks",
                column: "ppk_book_id");

            migrationBuilder.CreateIndex(
                name: "IX_books_fk_publisher_id",
                table: "books",
                column: "fk_publisher_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AuthorBooks");

            migrationBuilder.DropTable(
                name: "authors");

            migrationBuilder.DropTable(
                name: "books");

            migrationBuilder.DropTable(
                name: "publisher");
        }
    }
}
