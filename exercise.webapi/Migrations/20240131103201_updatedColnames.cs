using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace exercise.webapi.Migrations
{
    /// <inheritdoc />
    public partial class updatedColnames : Migration
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

            migrationBuilder.DropPrimaryKey(
                name: "PK_Authors",
                table: "Authors");

            migrationBuilder.RenameTable(
                name: "Books",
                newName: "Book");

            migrationBuilder.RenameTable(
                name: "Authors",
                newName: "author");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "Book",
                newName: "title");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Book",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "AuthorId",
                table: "Book",
                newName: "author_id");

            migrationBuilder.RenameIndex(
                name: "IX_Books_AuthorId",
                table: "Book",
                newName: "IX_Book_author_id");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "author",
                newName: "email");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "author",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "author",
                newName: "last_name");

            migrationBuilder.RenameColumn(
                name: "FirstName",
                table: "author",
                newName: "first_name");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Book",
                table: "Book",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_author",
                table: "author",
                column: "id");

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "author_id", "title" },
                values: new object[] { 227, "Several Purple Houses" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "author_id", "title" },
                values: new object[] { 2, "The Bitter Buildings" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "author_id", "title" },
                values: new object[] { 64, "A bunch of Large Buildings" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "author_id", "title" },
                values: new object[] { 133, "An army of Rose Smelling Leopards" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "author_id", "title" },
                values: new object[] { 171, "Fifteen Microscopic Leopards" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "author_id", "title" },
                values: new object[] { 246, "Two Orange Cars" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "author_id", "title" },
                values: new object[] { 100, "Two Rose Smelling Buildings" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "author_id", "title" },
                values: new object[] { 38, "The Large Houses" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "author_id", "title" },
                values: new object[] { 181, "A herd of Microscopic Buildings" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "author_id", "title" },
                values: new object[] { 58, "The Rose Smelling Cars" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "author_id", "title" },
                values: new object[] { 120, "A herd of Green Flowers" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "author_id", "title" },
                values: new object[] { 50, "A herd of Green Leopards" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "author_id", "title" },
                values: new object[] { 222, "A herd of Orange Buildings" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "author_id", "title" },
                values: new object[] { 137, "A herd of Bitter Leopards" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "author_id", "title" },
                values: new object[] { 168, "Two Purple Cars" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "author_id", "title" },
                values: new object[] { 208, "Several Transparent Flowers" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "author_id", "title" },
                values: new object[] { 134, "The Orange Cars" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "author_id", "title" },
                values: new object[] { 39, "A herd of Microscopic Planets" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "author_id", "title" },
                values: new object[] { 79, "A herd of Rose Smelling Buildings" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "author_id", "title" },
                values: new object[] { 134, "A bunch of Green Cars" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "author_id", "title" },
                values: new object[] { 22, "Two Transparent Planets" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "author_id", "title" },
                values: new object[] { 70, "Several Purple Leopards" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "author_id", "title" },
                values: new object[] { 106, "The Orange Flowers" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "author_id", "title" },
                values: new object[] { 132, "A bunch of Purple Houses" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "author_id", "title" },
                values: new object[] { 17, "A bunch of Orange Flowers" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "author_id", "title" },
                values: new object[] { 61, "Several Bitter Flowers" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "author_id", "title" },
                values: new object[] { 226, "Fifteen Orange Buildings" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "author_id", "title" },
                values: new object[] { 16, "The Rose Smelling Buildings" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "author_id", "title" },
                values: new object[] { 107, "A herd of Purple Leopards" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "author_id", "title" },
                values: new object[] { 80, "An army of Microscopic Leopards" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "author_id", "title" },
                values: new object[] { 232, "Several Green Planets" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "author_id", "title" },
                values: new object[] { 148, "A herd of Large Cars" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: 33,
                columns: new[] { "author_id", "title" },
                values: new object[] { 241, "A herd of Large Cars" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: 34,
                columns: new[] { "author_id", "title" },
                values: new object[] { 197, "Fifteen Rose Smelling Cars" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: 35,
                columns: new[] { "author_id", "title" },
                values: new object[] { 180, "An army of Rose Smelling Buildings" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: 36,
                columns: new[] { "author_id", "title" },
                values: new object[] { 241, "A herd of Large Planets" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: 37,
                columns: new[] { "author_id", "title" },
                values: new object[] { 143, "Several Bitter Flowers" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: 38,
                columns: new[] { "author_id", "title" },
                values: new object[] { 37, "A herd of Rose Smelling Buildings" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: 39,
                columns: new[] { "author_id", "title" },
                values: new object[] { 89, "Two Bitter Flowers" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: 40,
                columns: new[] { "author_id", "title" },
                values: new object[] { 235, "The Bitter Cars" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: 41,
                columns: new[] { "author_id", "title" },
                values: new object[] { 113, "The Transparent Planets" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: 42,
                columns: new[] { "author_id", "title" },
                values: new object[] { 152, "A bunch of Orange Houses" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: 43,
                column: "title",
                value: "A herd of Rose Smelling Buildings");

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: 44,
                columns: new[] { "author_id", "title" },
                values: new object[] { 215, "Two Green Buildings" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: 45,
                columns: new[] { "author_id", "title" },
                values: new object[] { 7, "Fifteen Purple Houses" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: 46,
                columns: new[] { "author_id", "title" },
                values: new object[] { 111, "Fifteen Green Cars" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: 47,
                columns: new[] { "author_id", "title" },
                values: new object[] { 10, "The Orange Buildings" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: 48,
                columns: new[] { "author_id", "title" },
                values: new object[] { 32, "Several Transparent Flowers" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: 49,
                columns: new[] { "author_id", "title" },
                values: new object[] { 211, "Fifteen Transparent Houses" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: 50,
                columns: new[] { "author_id", "title" },
                values: new object[] { 238, "An army of Green Houses" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: 51,
                columns: new[] { "author_id", "title" },
                values: new object[] { 211, "Two Microscopic Cars" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: 52,
                columns: new[] { "author_id", "title" },
                values: new object[] { 194, "A herd of Transparent Planets" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: 53,
                columns: new[] { "author_id", "title" },
                values: new object[] { 224, "A bunch of Purple Flowers" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: 54,
                columns: new[] { "author_id", "title" },
                values: new object[] { 177, "A herd of Orange Houses" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: 55,
                columns: new[] { "author_id", "title" },
                values: new object[] { 26, "An army of Rose Smelling Houses" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: 56,
                columns: new[] { "author_id", "title" },
                values: new object[] { 181, "A herd of Rose Smelling Buildings" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: 57,
                columns: new[] { "author_id", "title" },
                values: new object[] { 247, "A herd of Bitter Leopards" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: 58,
                columns: new[] { "author_id", "title" },
                values: new object[] { 218, "Fifteen Green Planets" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: 59,
                columns: new[] { "author_id", "title" },
                values: new object[] { 156, "A herd of Transparent Planets" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: 60,
                columns: new[] { "author_id", "title" },
                values: new object[] { 73, "Several Orange Houses" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: 61,
                columns: new[] { "author_id", "title" },
                values: new object[] { 58, "A bunch of Transparent Cars" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: 62,
                columns: new[] { "author_id", "title" },
                values: new object[] { 150, "An army of Transparent Planets" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: 63,
                columns: new[] { "author_id", "title" },
                values: new object[] { 75, "An army of Green Buildings" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: 64,
                columns: new[] { "author_id", "title" },
                values: new object[] { 6, "The Microscopic Leopards" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: 65,
                columns: new[] { "author_id", "title" },
                values: new object[] { 188, "A bunch of Bitter Cars" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: 66,
                columns: new[] { "author_id", "title" },
                values: new object[] { 101, "A herd of Microscopic Leopards" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: 67,
                columns: new[] { "author_id", "title" },
                values: new object[] { 185, "The Transparent Houses" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: 68,
                columns: new[] { "author_id", "title" },
                values: new object[] { 32, "A herd of Large Houses" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: 69,
                columns: new[] { "author_id", "title" },
                values: new object[] { 112, "Two Transparent Houses" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: 70,
                columns: new[] { "author_id", "title" },
                values: new object[] { 35, "An army of Microscopic Flowers" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: 71,
                columns: new[] { "author_id", "title" },
                values: new object[] { 200, "A herd of Large Buildings" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: 72,
                columns: new[] { "author_id", "title" },
                values: new object[] { 18, "Several Bitter Houses" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: 73,
                columns: new[] { "author_id", "title" },
                values: new object[] { 238, "Two Large Flowers" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: 74,
                columns: new[] { "author_id", "title" },
                values: new object[] { 227, "Two Green Buildings" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: 75,
                columns: new[] { "author_id", "title" },
                values: new object[] { 17, "A bunch of Orange Flowers" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: 76,
                columns: new[] { "author_id", "title" },
                values: new object[] { 228, "A herd of Rose Smelling Cars" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: 77,
                columns: new[] { "author_id", "title" },
                values: new object[] { 119, "The Large Flowers" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: 78,
                columns: new[] { "author_id", "title" },
                values: new object[] { 121, "Several Purple Houses" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: 79,
                columns: new[] { "author_id", "title" },
                values: new object[] { 189, "An army of Microscopic Buildings" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: 80,
                columns: new[] { "author_id", "title" },
                values: new object[] { 60, "A herd of Microscopic Houses" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: 81,
                columns: new[] { "author_id", "title" },
                values: new object[] { 23, "Several Rose Smelling Houses" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: 82,
                columns: new[] { "author_id", "title" },
                values: new object[] { 215, "Two Large Houses" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: 83,
                columns: new[] { "author_id", "title" },
                values: new object[] { 228, "Two Large Leopards" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: 84,
                columns: new[] { "author_id", "title" },
                values: new object[] { 22, "Several Microscopic Flowers" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: 85,
                columns: new[] { "author_id", "title" },
                values: new object[] { 243, "Several Large Leopards" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: 86,
                columns: new[] { "author_id", "title" },
                values: new object[] { 55, "Two Rose Smelling Flowers" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: 87,
                columns: new[] { "author_id", "title" },
                values: new object[] { 159, "A herd of Purple Leopards" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: 88,
                columns: new[] { "author_id", "title" },
                values: new object[] { 241, "The Green Planets" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: 89,
                columns: new[] { "author_id", "title" },
                values: new object[] { 38, "A herd of Green Houses" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: 90,
                columns: new[] { "author_id", "title" },
                values: new object[] { 137, "A bunch of Rose Smelling Flowers" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: 91,
                columns: new[] { "author_id", "title" },
                values: new object[] { 208, "Two Rose Smelling Cars" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: 92,
                columns: new[] { "author_id", "title" },
                values: new object[] { 247, "The Purple Buildings" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: 93,
                columns: new[] { "author_id", "title" },
                values: new object[] { 205, "The Large Buildings" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: 94,
                columns: new[] { "author_id", "title" },
                values: new object[] { 103, "Fifteen Microscopic Houses" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: 95,
                columns: new[] { "author_id", "title" },
                values: new object[] { 129, "Several Large Cars" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: 96,
                columns: new[] { "author_id", "title" },
                values: new object[] { 226, "A herd of Large Leopards" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: 97,
                columns: new[] { "author_id", "title" },
                values: new object[] { 23, "Fifteen Large Cars" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: 98,
                columns: new[] { "author_id", "title" },
                values: new object[] { 71, "The Large Buildings" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: 99,
                columns: new[] { "author_id", "title" },
                values: new object[] { 203, "The Rose Smelling Leopards" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: 100,
                columns: new[] { "author_id", "title" },
                values: new object[] { 65, "Fifteen Orange Buildings" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: 101,
                columns: new[] { "author_id", "title" },
                values: new object[] { 203, "The Transparent Houses" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: 102,
                columns: new[] { "author_id", "title" },
                values: new object[] { 227, "An army of Rose Smelling Cars" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: 103,
                columns: new[] { "author_id", "title" },
                values: new object[] { 150, "Several Transparent Leopards" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: 104,
                columns: new[] { "author_id", "title" },
                values: new object[] { 142, "Fifteen Transparent Buildings" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: 105,
                columns: new[] { "author_id", "title" },
                values: new object[] { 189, "A herd of Purple Houses" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: 106,
                columns: new[] { "author_id", "title" },
                values: new object[] { 213, "Several Bitter Buildings" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: 107,
                columns: new[] { "author_id", "title" },
                values: new object[] { 154, "The Large Houses" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: 108,
                columns: new[] { "author_id", "title" },
                values: new object[] { 113, "Two Bitter Leopards" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: 109,
                columns: new[] { "author_id", "title" },
                values: new object[] { 162, "Fifteen Transparent Cars" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: 110,
                columns: new[] { "author_id", "title" },
                values: new object[] { 110, "Two Transparent Leopards" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: 111,
                columns: new[] { "author_id", "title" },
                values: new object[] { 180, "The Orange Planets" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: 112,
                columns: new[] { "author_id", "title" },
                values: new object[] { 13, "Fifteen Transparent Flowers" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: 113,
                columns: new[] { "author_id", "title" },
                values: new object[] { 81, "Fifteen Purple Houses" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: 114,
                columns: new[] { "author_id", "title" },
                values: new object[] { 192, "A bunch of Rose Smelling Cars" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: 115,
                columns: new[] { "author_id", "title" },
                values: new object[] { 121, "Several Large Leopards" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: 116,
                columns: new[] { "author_id", "title" },
                values: new object[] { 216, "Several Green Cars" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: 117,
                columns: new[] { "author_id", "title" },
                values: new object[] { 220, "An army of Rose Smelling Leopards" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: 118,
                columns: new[] { "author_id", "title" },
                values: new object[] { 34, "Several Transparent Cars" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: 119,
                columns: new[] { "author_id", "title" },
                values: new object[] { 217, "A bunch of Purple Buildings" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: 120,
                columns: new[] { "author_id", "title" },
                values: new object[] { 136, "A herd of Transparent Cars" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: 121,
                columns: new[] { "author_id", "title" },
                values: new object[] { 237, "A herd of Microscopic Flowers" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: 122,
                columns: new[] { "author_id", "title" },
                values: new object[] { 164, "Several Microscopic Leopards" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: 123,
                columns: new[] { "author_id", "title" },
                values: new object[] { 196, "A bunch of Large Flowers" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: 124,
                columns: new[] { "author_id", "title" },
                values: new object[] { 58, "Several Transparent Cars" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: 125,
                columns: new[] { "author_id", "title" },
                values: new object[] { 201, "Fifteen Orange Houses" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: 126,
                columns: new[] { "author_id", "title" },
                values: new object[] { 204, "Several Rose Smelling Cars" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: 127,
                columns: new[] { "author_id", "title" },
                values: new object[] { 165, "Fifteen Bitter Buildings" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: 128,
                columns: new[] { "author_id", "title" },
                values: new object[] { 169, "A herd of Large Cars" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: 129,
                columns: new[] { "author_id", "title" },
                values: new object[] { 200, "Two Purple Houses" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: 130,
                columns: new[] { "author_id", "title" },
                values: new object[] { 149, "The Transparent Leopards" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: 131,
                columns: new[] { "author_id", "title" },
                values: new object[] { 228, "Several Purple Cars" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: 132,
                columns: new[] { "author_id", "title" },
                values: new object[] { 131, "A bunch of Orange Houses" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: 133,
                columns: new[] { "author_id", "title" },
                values: new object[] { 228, "Fifteen Green Leopards" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: 134,
                columns: new[] { "author_id", "title" },
                values: new object[] { 191, "A bunch of Bitter Leopards" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: 135,
                columns: new[] { "author_id", "title" },
                values: new object[] { 134, "Several Rose Smelling Houses" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: 136,
                columns: new[] { "author_id", "title" },
                values: new object[] { 160, "An army of Bitter Houses" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: 137,
                columns: new[] { "author_id", "title" },
                values: new object[] { 148, "An army of Bitter Planets" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: 138,
                columns: new[] { "author_id", "title" },
                values: new object[] { 160, "Fifteen Transparent Leopards" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: 139,
                columns: new[] { "author_id", "title" },
                values: new object[] { 230, "Two Bitter Houses" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: 140,
                columns: new[] { "author_id", "title" },
                values: new object[] { 32, "Fifteen Rose Smelling Flowers" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: 141,
                columns: new[] { "author_id", "title" },
                values: new object[] { 80, "Two Large Flowers" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: 142,
                columns: new[] { "author_id", "title" },
                values: new object[] { 3, "Two Microscopic Leopards" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: 143,
                columns: new[] { "author_id", "title" },
                values: new object[] { 227, "Several Transparent Houses" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: 144,
                columns: new[] { "author_id", "title" },
                values: new object[] { 160, "An army of Microscopic Buildings" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: 145,
                columns: new[] { "author_id", "title" },
                values: new object[] { 209, "An army of Transparent Leopards" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: 146,
                columns: new[] { "author_id", "title" },
                values: new object[] { 128, "Two Orange Planets" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: 147,
                columns: new[] { "author_id", "title" },
                values: new object[] { 78, "Two Bitter Houses" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: 148,
                columns: new[] { "author_id", "title" },
                values: new object[] { 38, "Fifteen Bitter Flowers" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: 149,
                columns: new[] { "author_id", "title" },
                values: new object[] { 67, "A herd of Bitter Buildings" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: 150,
                columns: new[] { "author_id", "title" },
                values: new object[] { 194, "The Rose Smelling Buildings" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: 151,
                columns: new[] { "author_id", "title" },
                values: new object[] { 18, "Fifteen Microscopic Leopards" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: 152,
                columns: new[] { "author_id", "title" },
                values: new object[] { 75, "The Green Houses" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: 153,
                columns: new[] { "author_id", "title" },
                values: new object[] { 127, "A herd of Transparent Houses" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: 154,
                columns: new[] { "author_id", "title" },
                values: new object[] { 20, "The Large Leopards" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: 155,
                columns: new[] { "author_id", "title" },
                values: new object[] { 16, "An army of Rose Smelling Planets" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: 156,
                columns: new[] { "author_id", "title" },
                values: new object[] { 68, "Several Green Flowers" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: 157,
                columns: new[] { "author_id", "title" },
                values: new object[] { 123, "A bunch of Bitter Cars" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: 158,
                columns: new[] { "author_id", "title" },
                values: new object[] { 13, "Fifteen Microscopic Buildings" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: 159,
                columns: new[] { "author_id", "title" },
                values: new object[] { 220, "An army of Transparent Buildings" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: 160,
                columns: new[] { "author_id", "title" },
                values: new object[] { 201, "Fifteen Green Planets" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: 161,
                columns: new[] { "author_id", "title" },
                values: new object[] { 74, "A herd of Bitter Flowers" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: 162,
                columns: new[] { "author_id", "title" },
                values: new object[] { 109, "Fifteen Transparent Buildings" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: 163,
                columns: new[] { "author_id", "title" },
                values: new object[] { 185, "A herd of Transparent Cars" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: 164,
                columns: new[] { "author_id", "title" },
                values: new object[] { 189, "Two Large Planets" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: 165,
                columns: new[] { "author_id", "title" },
                values: new object[] { 125, "Two Orange Planets" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: 166,
                columns: new[] { "author_id", "title" },
                values: new object[] { 14, "A herd of Green Buildings" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: 167,
                columns: new[] { "author_id", "title" },
                values: new object[] { 180, "A bunch of Orange Flowers" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: 168,
                columns: new[] { "author_id", "title" },
                values: new object[] { 200, "Two Purple Buildings" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: 169,
                columns: new[] { "author_id", "title" },
                values: new object[] { 244, "A herd of Transparent Planets" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: 170,
                columns: new[] { "author_id", "title" },
                values: new object[] { 203, "Several Green Cars" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: 171,
                columns: new[] { "author_id", "title" },
                values: new object[] { 143, "A herd of Transparent Leopards" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: 172,
                columns: new[] { "author_id", "title" },
                values: new object[] { 72, "An army of Green Buildings" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: 173,
                columns: new[] { "author_id", "title" },
                values: new object[] { 103, "Two Orange Cars" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: 174,
                columns: new[] { "author_id", "title" },
                values: new object[] { 186, "Several Microscopic Planets" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: 175,
                columns: new[] { "author_id", "title" },
                values: new object[] { 142, "Two Rose Smelling Cars" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: 176,
                columns: new[] { "author_id", "title" },
                values: new object[] { 172, "A herd of Transparent Houses" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: 177,
                columns: new[] { "author_id", "title" },
                values: new object[] { 36, "The Orange Planets" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: 178,
                columns: new[] { "author_id", "title" },
                values: new object[] { 238, "Several Green Cars" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: 179,
                columns: new[] { "author_id", "title" },
                values: new object[] { 171, "A herd of Large Planets" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: 180,
                columns: new[] { "author_id", "title" },
                values: new object[] { 22, "An army of Large Houses" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: 181,
                columns: new[] { "author_id", "title" },
                values: new object[] { 21, "Fifteen Microscopic Buildings" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: 182,
                columns: new[] { "author_id", "title" },
                values: new object[] { 138, "An army of Purple Planets" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: 183,
                columns: new[] { "author_id", "title" },
                values: new object[] { 20, "An army of Rose Smelling Flowers" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: 184,
                columns: new[] { "author_id", "title" },
                values: new object[] { 194, "The Purple Houses" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: 185,
                columns: new[] { "author_id", "title" },
                values: new object[] { 115, "Fifteen Green Cars" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: 186,
                columns: new[] { "author_id", "title" },
                values: new object[] { 35, "Fifteen Orange Houses" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: 187,
                columns: new[] { "author_id", "title" },
                values: new object[] { 187, "Two Purple Planets" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: 188,
                columns: new[] { "author_id", "title" },
                values: new object[] { 209, "Two Transparent Leopards" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: 189,
                columns: new[] { "author_id", "title" },
                values: new object[] { 239, "A herd of Green Flowers" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: 190,
                columns: new[] { "author_id", "title" },
                values: new object[] { 42, "Two Rose Smelling Leopards" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: 191,
                columns: new[] { "author_id", "title" },
                values: new object[] { 187, "Two Large Cars" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: 192,
                columns: new[] { "author_id", "title" },
                values: new object[] { 119, "Several Green Buildings" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: 193,
                columns: new[] { "author_id", "title" },
                values: new object[] { 127, "Several Bitter Houses" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: 194,
                columns: new[] { "author_id", "title" },
                values: new object[] { 37, "Two Bitter Leopards" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: 195,
                columns: new[] { "author_id", "title" },
                values: new object[] { 229, "Two Orange Leopards" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: 196,
                columns: new[] { "author_id", "title" },
                values: new object[] { 140, "Several Purple Flowers" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: 197,
                columns: new[] { "author_id", "title" },
                values: new object[] { 85, "Fifteen Rose Smelling Planets" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: 198,
                columns: new[] { "author_id", "title" },
                values: new object[] { 181, "A bunch of Orange Planets" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: 199,
                columns: new[] { "author_id", "title" },
                values: new object[] { 9, "The Microscopic Cars" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: 200,
                columns: new[] { "author_id", "title" },
                values: new object[] { 226, "Fifteen Large Houses" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: 201,
                columns: new[] { "author_id", "title" },
                values: new object[] { 86, "Fifteen Bitter Flowers" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: 202,
                columns: new[] { "author_id", "title" },
                values: new object[] { 185, "A bunch of Green Flowers" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: 203,
                columns: new[] { "author_id", "title" },
                values: new object[] { 65, "A bunch of Bitter Flowers" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: 204,
                columns: new[] { "author_id", "title" },
                values: new object[] { 65, "A herd of Bitter Cars" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: 205,
                columns: new[] { "author_id", "title" },
                values: new object[] { 145, "Fifteen Large Cars" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: 206,
                columns: new[] { "author_id", "title" },
                values: new object[] { 156, "An army of Orange Leopards" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: 207,
                columns: new[] { "author_id", "title" },
                values: new object[] { 113, "An army of Orange Leopards" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: 208,
                columns: new[] { "author_id", "title" },
                values: new object[] { 53, "Fifteen Green Flowers" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: 209,
                columns: new[] { "author_id", "title" },
                values: new object[] { 24, "The Transparent Buildings" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: 210,
                columns: new[] { "author_id", "title" },
                values: new object[] { 130, "Fifteen Purple Flowers" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: 211,
                columns: new[] { "author_id", "title" },
                values: new object[] { 8, "A herd of Orange Leopards" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: 212,
                columns: new[] { "author_id", "title" },
                values: new object[] { 248, "A bunch of Large Flowers" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: 213,
                columns: new[] { "author_id", "title" },
                values: new object[] { 9, "A herd of Rose Smelling Houses" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: 214,
                columns: new[] { "author_id", "title" },
                values: new object[] { 122, "Several Rose Smelling Leopards" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: 215,
                columns: new[] { "author_id", "title" },
                values: new object[] { 129, "An army of Rose Smelling Cars" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: 216,
                columns: new[] { "author_id", "title" },
                values: new object[] { 86, "An army of Large Cars" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: 217,
                columns: new[] { "author_id", "title" },
                values: new object[] { 183, "The Transparent Houses" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: 218,
                columns: new[] { "author_id", "title" },
                values: new object[] { 105, "A bunch of Bitter Buildings" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: 219,
                columns: new[] { "author_id", "title" },
                values: new object[] { 65, "Several Bitter Buildings" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: 220,
                columns: new[] { "author_id", "title" },
                values: new object[] { 225, "The Purple Buildings" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: 221,
                columns: new[] { "author_id", "title" },
                values: new object[] { 207, "A bunch of Purple Houses" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: 222,
                columns: new[] { "author_id", "title" },
                values: new object[] { 24, "Fifteen Orange Leopards" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: 223,
                columns: new[] { "author_id", "title" },
                values: new object[] { 102, "Several Microscopic Buildings" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: 224,
                columns: new[] { "author_id", "title" },
                values: new object[] { 214, "A herd of Transparent Cars" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: 225,
                columns: new[] { "author_id", "title" },
                values: new object[] { 199, "Two Transparent Houses" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: 226,
                columns: new[] { "author_id", "title" },
                values: new object[] { 180, "Several Transparent Houses" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: 227,
                columns: new[] { "author_id", "title" },
                values: new object[] { 98, "A bunch of Large Planets" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: 228,
                columns: new[] { "author_id", "title" },
                values: new object[] { 126, "An army of Bitter Cars" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: 229,
                columns: new[] { "author_id", "title" },
                values: new object[] { 149, "The Rose Smelling Leopards" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: 230,
                columns: new[] { "author_id", "title" },
                values: new object[] { 162, "Two Large Cars" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: 231,
                columns: new[] { "author_id", "title" },
                values: new object[] { 216, "Several Green Leopards" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: 232,
                columns: new[] { "author_id", "title" },
                values: new object[] { 15, "The Purple Buildings" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: 233,
                columns: new[] { "author_id", "title" },
                values: new object[] { 206, "An army of Orange Flowers" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: 234,
                columns: new[] { "author_id", "title" },
                values: new object[] { 109, "Fifteen Microscopic Flowers" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: 235,
                columns: new[] { "author_id", "title" },
                values: new object[] { 88, "The Green Leopards" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: 236,
                columns: new[] { "author_id", "title" },
                values: new object[] { 70, "A bunch of Microscopic Houses" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: 237,
                columns: new[] { "author_id", "title" },
                values: new object[] { 236, "Fifteen Green Cars" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: 238,
                columns: new[] { "author_id", "title" },
                values: new object[] { 76, "A herd of Large Houses" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: 239,
                columns: new[] { "author_id", "title" },
                values: new object[] { 157, "Fifteen Purple Flowers" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: 240,
                columns: new[] { "author_id", "title" },
                values: new object[] { 225, "Fifteen Large Leopards" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: 241,
                columns: new[] { "author_id", "title" },
                values: new object[] { 119, "The Green Houses" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: 242,
                columns: new[] { "author_id", "title" },
                values: new object[] { 121, "Several Rose Smelling Buildings" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: 243,
                columns: new[] { "author_id", "title" },
                values: new object[] { 112, "The Purple Houses" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: 244,
                columns: new[] { "author_id", "title" },
                values: new object[] { 136, "The Bitter Flowers" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: 245,
                columns: new[] { "author_id", "title" },
                values: new object[] { 149, "An army of Purple Planets" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: 246,
                columns: new[] { "author_id", "title" },
                values: new object[] { 69, "Several Rose Smelling Leopards" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: 247,
                columns: new[] { "author_id", "title" },
                values: new object[] { 42, "Two Microscopic Houses" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: 248,
                columns: new[] { "author_id", "title" },
                values: new object[] { 75, "A bunch of Bitter Cars" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: 249,
                columns: new[] { "author_id", "title" },
                values: new object[] { 140, "Fifteen Bitter Leopards" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "email", "last_name" },
                values: new object[] { "audrey.obama@gov.gr", "Obama" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 2,
                column: "email",
                value: "oprah.trump@something.com");

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "jimi.middleton@gov.us", "Jimi", "Middleton" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "email", "last_name" },
                values: new object[] { "elvis.winfrey@something.com", "Winfrey" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "elvis.middleton@theworld.ca", "Elvis", "Middleton" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "email", "last_name" },
                values: new object[] { "mick.jagger@bbc.co.uk", "Jagger" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "elvis.obama@gov.gr", "Elvis", "Obama" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.windsor@gov.ru", "Kate", "Windsor" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "oprah.winfrey@gov.ru", "Oprah", "Winfrey" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "email", "last_name" },
                values: new object[] { "barack.presley@something.com", "Presley" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "email", "last_name" },
                values: new object[] { "elvis.winfrey@something.com", "Winfrey" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "donald.middleton@gov.gr", "Donald", "Middleton" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "email", "first_name" },
                values: new object[] { "barack.trump@tesla.com", "Barack" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "jimi.jagger@nasa.org.us", "Jimi", "Jagger" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "charles.winfrey@bbc.co.uk", "Charles", "Winfrey" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "email", "first_name" },
                values: new object[] { "charles.obama@theworld.ca", "Charles" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "audrey.trump@gov.ru", "Audrey", "Trump" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "email", "first_name" },
                values: new object[] { "charles.presley@tesla.com", "Charles" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "email", "first_name" },
                values: new object[] { "mick.obama@bbc.co.uk", "Mick" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "elvis.jagger@gov.nl", "Elvis", "Jagger" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "donald.hendrix@gov.ru", "Donald", "Hendrix" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "barack.jagger@google.com", "Barack", "Jagger" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "mick.hepburn@tesla.com", "Mick", "Hepburn" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "email", "last_name" },
                values: new object[] { "charles.middleton@tesla.com", "Middleton" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "jimi.hepburn@nasa.org.us", "Jimi", "Hepburn" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "email", "last_name" },
                values: new object[] { "audrey.obama@gov.ru", "Obama" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.hepburn@gov.gr", "Kate", "Hepburn" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "jimi.winfrey@something.com", "Jimi", "Winfrey" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "donald.winslet@gov.gr", "Donald", "Winslet" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "email", "last_name" },
                values: new object[] { "audrey.trump@something.com", "Trump" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "jimi.hepburn@nasa.org.us", "Jimi", "Hepburn" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "donald.obama@gov.ru", "Donald", "Obama" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 33,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "audrey.hepburn@gov.us", "Audrey", "Hepburn" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 34,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "audrey.windsor@something.com", "Audrey", "Windsor" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 35,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "oprah.jagger@theworld.ca", "Oprah", "Jagger" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 36,
                columns: new[] { "email", "last_name" },
                values: new object[] { "audrey.hepburn@tesla.com", "Hepburn" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 37,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.hepburn@gov.ru", "Kate", "Hepburn" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 38,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "oprah.hepburn@something.com", "Oprah", "Hepburn" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 39,
                columns: new[] { "email", "first_name" },
                values: new object[] { "charles.obama@gov.us", "Charles" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 40,
                columns: new[] { "email", "last_name" },
                values: new object[] { "kate.presley@something.com", "Presley" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 41,
                columns: new[] { "email", "last_name" },
                values: new object[] { "jimi.presley@something.com", "Presley" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 42,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.jagger@gov.nl", "Kate", "Jagger" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 43,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "jimi.hendrix@google.com", "Jimi", "Hendrix" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 44,
                columns: new[] { "email", "last_name" },
                values: new object[] { "oprah.jagger@theworld.ca", "Jagger" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 45,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "oprah.jagger@tesla.com", "Oprah", "Jagger" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 46,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "mick.hepburn@google.com", "Mick", "Hepburn" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 47,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "charles.winfrey@gov.gr", "Charles", "Winfrey" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 48,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "charles.presley@gov.us", "Charles", "Presley" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 49,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "mick.middleton@theworld.ca", "Mick", "Middleton" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 50,
                columns: new[] { "email", "last_name" },
                values: new object[] { "charles.windsor@theworld.ca", "Windsor" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 51,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "audrey.winfrey@gov.gr", "Audrey", "Winfrey" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 52,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "elvis.middleton@something.com", "Elvis", "Middleton" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 53,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "oprah.winfrey@google.com", "Oprah", "Winfrey" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 54,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "mick.obama@theworld.ca", "Mick", "Obama" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 55,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "mick.presley@tesla.com", "Mick", "Presley" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 56,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "audrey.presley@gov.gr", "Audrey", "Presley" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 57,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "elvis.presley@nasa.org.us", "Elvis", "Presley" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 58,
                columns: new[] { "email", "first_name" },
                values: new object[] { "jimi.presley@gov.gr", "Jimi" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 59,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "oprah.winfrey@gov.ru", "Oprah", "Winfrey" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 60,
                column: "email",
                value: "oprah.winfrey@google.com");

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 61,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "audrey.hendrix@nasa.org.us", "Audrey", "Hendrix" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 62,
                columns: new[] { "email", "first_name" },
                values: new object[] { "charles.windsor@nasa.org.us", "Charles" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 63,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "charles.trump@gov.gr", "Charles", "Trump" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 64,
                columns: new[] { "email", "first_name" },
                values: new object[] { "elvis.windsor@google.com", "Elvis" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 65,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "oprah.trump@gov.ru", "Oprah", "Trump" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 66,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.winfrey@theworld.ca", "Kate", "Winfrey" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 67,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.trump@gov.us", "Kate", "Trump" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 68,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "oprah.presley@gov.ru", "Oprah", "Presley" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 69,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "jimi.hepburn@gov.ru", "Jimi", "Hepburn" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 70,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.middleton@gov.nl", "Kate", "Middleton" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 71,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "oprah.winfrey@tesla.com", "Oprah", "Winfrey" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 72,
                columns: new[] { "email", "first_name" },
                values: new object[] { "oprah.middleton@something.com", "Oprah" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 73,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "donald.middleton@google.com", "Donald", "Middleton" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 74,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "jimi.winslet@gov.gr", "Jimi", "Winslet" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 75,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "oprah.obama@nasa.org.us", "Oprah", "Obama" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 76,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "charles.winslet@gov.us", "Charles", "Winslet" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 77,
                columns: new[] { "email", "last_name" },
                values: new object[] { "kate.hendrix@gov.ru", "Hendrix" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 78,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "oprah.winfrey@gov.us", "Oprah", "Winfrey" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 79,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "audrey.hendrix@google.com", "Audrey", "Hendrix" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 80,
                column: "email",
                value: "barack.hendrix@something.com");

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 81,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "elvis.hepburn@gov.nl", "Elvis", "Hepburn" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 82,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "jimi.winslet@gov.gr", "Jimi", "Winslet" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 83,
                columns: new[] { "email", "last_name" },
                values: new object[] { "kate.windsor@tesla.com", "Windsor" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 84,
                columns: new[] { "email", "last_name" },
                values: new object[] { "kate.winfrey@google.com", "Winfrey" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 85,
                columns: new[] { "email", "last_name" },
                values: new object[] { "donald.presley@gov.nl", "Presley" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 86,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "jimi.obama@nasa.org.us", "Jimi", "Obama" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 87,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.hepburn@google.com", "Kate", "Hepburn" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 88,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "jimi.jagger@tesla.com", "Jimi", "Jagger" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 89,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "audrey.trump@google.com", "Audrey", "Trump" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 90,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "donald.windsor@google.com", "Donald", "Windsor" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 91,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "audrey.middleton@google.com", "Audrey", "Middleton" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 92,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "charles.windsor@bbc.co.uk", "Charles", "Windsor" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 93,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.windsor@gov.nl", "Kate", "Windsor" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 94,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "donald.presley@google.com", "Donald", "Presley" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 95,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "barack.winfrey@google.com", "Barack", "Winfrey" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 96,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "barack.trump@google.com", "Barack", "Trump" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 97,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.obama@gov.us", "Kate", "Obama" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 98,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "audrey.hepburn@something.com", "Audrey", "Hepburn" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 99,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "donald.hepburn@nasa.org.us", "Donald", "Hepburn" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 100,
                columns: new[] { "email", "last_name" },
                values: new object[] { "audrey.hepburn@tesla.com", "Hepburn" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 101,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "jimi.jagger@gov.us", "Jimi", "Jagger" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 102,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.windsor@nasa.org.us", "Kate", "Windsor" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 103,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.winfrey@bbc.co.uk", "Kate", "Winfrey" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 104,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "charles.windsor@theworld.ca", "Charles", "Windsor" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 105,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "mick.presley@tesla.com", "Mick", "Presley" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 106,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "mick.windsor@gov.nl", "Mick", "Windsor" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 107,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.middleton@gov.gr", "Kate", "Middleton" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 108,
                columns: new[] { "email", "first_name" },
                values: new object[] { "oprah.presley@gov.gr", "Oprah" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 109,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "mick.presley@bbc.co.uk", "Mick", "Presley" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 110,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "jimi.jagger@theworld.ca", "Jimi", "Jagger" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 111,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "mick.hepburn@gov.gr", "Mick", "Hepburn" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 112,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "charles.trump@gov.us", "Charles", "Trump" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 113,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.hendrix@tesla.com", "Kate", "Hendrix" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 114,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.middleton@gov.gr", "Kate", "Middleton" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 115,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "mick.windsor@something.com", "Mick", "Windsor" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 116,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "charles.middleton@gov.nl", "Charles", "Middleton" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 117,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "audrey.trump@nasa.org.us", "Audrey", "Trump" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 118,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "donald.hendrix@gov.nl", "Donald", "Hendrix" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 119,
                columns: new[] { "email", "first_name" },
                values: new object[] { "barack.windsor@gov.nl", "Barack" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 120,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "mick.hepburn@tesla.com", "Mick", "Hepburn" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 121,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "audrey.hendrix@gov.ru", "Audrey", "Hendrix" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 122,
                columns: new[] { "email", "first_name" },
                values: new object[] { "donald.obama@gov.gr", "Donald" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 123,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "donald.winfrey@tesla.com", "Donald", "Winfrey" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 124,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "mick.winfrey@gov.nl", "Mick", "Winfrey" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 125,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "audrey.winfrey@google.com", "Audrey", "Winfrey" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 126,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "audrey.windsor@gov.gr", "Audrey", "Windsor" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 128,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "audrey.winslet@gov.nl", "Audrey", "Winslet" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 129,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "charles.hendrix@tesla.com", "Charles", "Hendrix" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 130,
                columns: new[] { "email", "first_name" },
                values: new object[] { "kate.trump@gov.nl", "Kate" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 131,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "audrey.windsor@google.com", "Audrey", "Windsor" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 132,
                columns: new[] { "email", "last_name" },
                values: new object[] { "kate.presley@nasa.org.us", "Presley" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 133,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "mick.middleton@nasa.org.us", "Mick", "Middleton" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 134,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "elvis.presley@bbc.co.uk", "Elvis", "Presley" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 135,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "barack.jagger@gov.gr", "Barack", "Jagger" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 136,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "oprah.windsor@something.com", "Oprah", "Windsor" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 137,
                columns: new[] { "email", "last_name" },
                values: new object[] { "kate.winslet@tesla.com", "Winslet" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 138,
                columns: new[] { "email", "last_name" },
                values: new object[] { "kate.jagger@gov.ru", "Jagger" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 139,
                columns: new[] { "email", "first_name" },
                values: new object[] { "kate.obama@gov.gr", "Kate" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 140,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "audrey.obama@gov.us", "Audrey", "Obama" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 141,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "donald.presley@gov.gr", "Donald", "Presley" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 142,
                columns: new[] { "email", "first_name" },
                values: new object[] { "barack.windsor@gov.nl", "Barack" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 143,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.windsor@gov.ru", "Kate", "Windsor" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 144,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "audrey.middleton@bbc.co.uk", "Audrey", "Middleton" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 145,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.middleton@google.com", "Kate", "Middleton" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 146,
                columns: new[] { "email", "last_name" },
                values: new object[] { "mick.trump@gov.nl", "Trump" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 147,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "donald.trump@gov.us", "Donald", "Trump" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 148,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "oprah.presley@theworld.ca", "Oprah", "Presley" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 149,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "audrey.hendrix@google.com", "Audrey", "Hendrix" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 150,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "donald.middleton@bbc.co.uk", "Donald", "Middleton" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 151,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "oprah.trump@bbc.co.uk", "Oprah", "Trump" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 152,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "elvis.windsor@gov.us", "Elvis", "Windsor" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 153,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "donald.presley@bbc.co.uk", "Donald", "Presley" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 154,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "jimi.windsor@google.com", "Jimi", "Windsor" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 155,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "oprah.obama@something.com", "Oprah", "Obama" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 156,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "audrey.middleton@gov.gr", "Audrey", "Middleton" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 157,
                column: "email",
                value: "oprah.hendrix@tesla.com");

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 158,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "oprah.obama@tesla.com", "Oprah", "Obama" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 159,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "barack.middleton@nasa.org.us", "Barack", "Middleton" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 160,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "oprah.obama@gov.nl", "Oprah", "Obama" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 161,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "audrey.windsor@gov.ru", "Audrey", "Windsor" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 162,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "oprah.hepburn@gov.gr", "Oprah", "Hepburn" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 163,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "elvis.hepburn@something.com", "Elvis", "Hepburn" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 164,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "audrey.jagger@theworld.ca", "Audrey", "Jagger" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 165,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "charles.jagger@google.com", "Charles", "Jagger" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 166,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.jagger@gov.nl", "Kate", "Jagger" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 167,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.windsor@something.com", "Kate", "Windsor" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 168,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "mick.winslet@gov.ru", "Mick", "Winslet" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 169,
                columns: new[] { "email", "first_name" },
                values: new object[] { "jimi.hepburn@something.com", "Jimi" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 170,
                columns: new[] { "email", "first_name" },
                values: new object[] { "jimi.windsor@gov.us", "Jimi" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 171,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "mick.hendrix@something.com", "Mick", "Hendrix" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 172,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "mick.winslet@nasa.org.us", "Mick", "Winslet" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 173,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.winslet@bbc.co.uk", "Kate", "Winslet" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 174,
                column: "email",
                value: "kate.trump@gov.ru");

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 175,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "elvis.winfrey@nasa.org.us", "Elvis", "Winfrey" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 176,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "donald.winfrey@gov.ru", "Donald", "Winfrey" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 177,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "charles.trump@theworld.ca", "Charles", "Trump" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 178,
                columns: new[] { "email", "first_name" },
                values: new object[] { "mick.middleton@theworld.ca", "Mick" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 179,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.presley@gov.nl", "Kate", "Presley" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 180,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "charles.jagger@something.com", "Charles", "Jagger" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 181,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "jimi.presley@gov.ru", "Jimi", "Presley" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 182,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.windsor@something.com", "Kate", "Windsor" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 183,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "barack.hepburn@tesla.com", "Barack", "Hepburn" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 184,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "mick.windsor@nasa.org.us", "Mick", "Windsor" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 185,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "barack.winslet@gov.ru", "Barack", "Winslet" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 186,
                columns: new[] { "email", "first_name" },
                values: new object[] { "charles.winfrey@nasa.org.us", "Charles" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 187,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "mick.jagger@tesla.com", "Mick", "Jagger" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 188,
                column: "email",
                value: "jimi.jagger@gov.gr");

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 189,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "audrey.winslet@something.com", "Audrey", "Winslet" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 190,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.obama@bbc.co.uk", "Kate", "Obama" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 191,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "jimi.windsor@nasa.org.us", "Jimi", "Windsor" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 192,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "jimi.presley@gov.ru", "Jimi", "Presley" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 193,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "donald.trump@tesla.com", "Donald", "Trump" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 194,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "donald.hepburn@gov.ru", "Donald", "Hepburn" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 195,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "mick.jagger@gov.gr", "Mick", "Jagger" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 196,
                columns: new[] { "email", "last_name" },
                values: new object[] { "audrey.winslet@nasa.org.us", "Winslet" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 197,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.trump@something.com", "Kate", "Trump" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 198,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "elvis.presley@nasa.org.us", "Elvis", "Presley" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 199,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "charles.obama@something.com", "Charles", "Obama" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 200,
                columns: new[] { "email", "last_name" },
                values: new object[] { "elvis.hendrix@nasa.org.us", "Hendrix" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 201,
                columns: new[] { "email", "last_name" },
                values: new object[] { "oprah.windsor@gov.nl", "Windsor" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 202,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "mick.windsor@theworld.ca", "Mick", "Windsor" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 203,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "oprah.obama@bbc.co.uk", "Oprah", "Obama" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 204,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "audrey.windsor@gov.us", "Audrey", "Windsor" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 205,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "audrey.winfrey@gov.nl", "Audrey", "Winfrey" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 206,
                columns: new[] { "email", "first_name" },
                values: new object[] { "oprah.winfrey@theworld.ca", "Oprah" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 207,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "audrey.hepburn@google.com", "Audrey", "Hepburn" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 208,
                columns: new[] { "email", "last_name" },
                values: new object[] { "elvis.middleton@gov.nl", "Middleton" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 209,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "charles.middleton@tesla.com", "Charles", "Middleton" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 210,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "mick.windsor@theworld.ca", "Mick", "Windsor" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 211,
                columns: new[] { "email", "first_name" },
                values: new object[] { "mick.obama@google.com", "Mick" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 212,
                columns: new[] { "email", "last_name" },
                values: new object[] { "kate.windsor@something.com", "Windsor" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 213,
                columns: new[] { "email", "first_name" },
                values: new object[] { "barack.middleton@tesla.com", "Barack" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 214,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "jimi.hendrix@nasa.org.us", "Jimi", "Hendrix" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 215,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "jimi.windsor@gov.ru", "Jimi", "Windsor" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 216,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.hendrix@bbc.co.uk", "Kate", "Hendrix" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 217,
                columns: new[] { "email", "last_name" },
                values: new object[] { "charles.winfrey@bbc.co.uk", "Winfrey" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 218,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "donald.hepburn@google.com", "Donald", "Hepburn" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 219,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "barack.obama@gov.nl", "Barack", "Obama" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 220,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.presley@bbc.co.uk", "Kate", "Presley" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 221,
                columns: new[] { "email", "last_name" },
                values: new object[] { "mick.hepburn@bbc.co.uk", "Hepburn" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 222,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "elvis.windsor@gov.nl", "Elvis", "Windsor" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 223,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "jimi.obama@theworld.ca", "Jimi", "Obama" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 224,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "charles.presley@google.com", "Charles", "Presley" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 225,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "mick.middleton@gov.ru", "Mick", "Middleton" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 226,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "audrey.windsor@bbc.co.uk", "Audrey", "Windsor" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 227,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "audrey.winslet@bbc.co.uk", "Audrey", "Winslet" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 228,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "jimi.trump@something.com", "Jimi", "Trump" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 229,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "mick.middleton@bbc.co.uk", "Mick", "Middleton" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 230,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "jimi.winfrey@something.com", "Jimi", "Winfrey" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 231,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "jimi.obama@google.com", "Jimi", "Obama" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 232,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "mick.winfrey@gov.us", "Mick", "Winfrey" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 233,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.trump@gov.us", "Kate", "Trump" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 234,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "charles.windsor@something.com", "Charles", "Windsor" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 235,
                columns: new[] { "email", "last_name" },
                values: new object[] { "kate.winfrey@bbc.co.uk", "Winfrey" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 236,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "mick.hepburn@gov.nl", "Mick", "Hepburn" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 237,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.winslet@something.com", "Kate", "Winslet" });

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
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "donald.windsor@tesla.com", "Donald", "Windsor" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 240,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "oprah.windsor@google.com", "Oprah", "Windsor" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 241,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "audrey.presley@tesla.com", "Audrey", "Presley" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 242,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "donald.hepburn@nasa.org.us", "Donald", "Hepburn" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 243,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "elvis.winfrey@nasa.org.us", "Elvis", "Winfrey" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 244,
                columns: new[] { "email", "last_name" },
                values: new object[] { "mick.obama@google.com", "Obama" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 245,
                columns: new[] { "email", "last_name" },
                values: new object[] { "kate.middleton@gov.us", "Middleton" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 246,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "donald.trump@something.com", "Donald", "Trump" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 247,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "kate.hepburn@theworld.ca", "Kate", "Hepburn" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 248,
                columns: new[] { "email", "last_name" },
                values: new object[] { "kate.jagger@theworld.ca", "Jagger" });

            migrationBuilder.UpdateData(
                table: "author",
                keyColumn: "id",
                keyValue: 249,
                columns: new[] { "email", "first_name", "last_name" },
                values: new object[] { "barack.obama@gov.ru", "Barack", "Obama" });

            migrationBuilder.AddForeignKey(
                name: "FK_Book_author_author_id",
                table: "Book",
                column: "author_id",
                principalTable: "author",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Book_author_author_id",
                table: "Book");

            migrationBuilder.DropPrimaryKey(
                name: "PK_author",
                table: "author");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Book",
                table: "Book");

            migrationBuilder.RenameTable(
                name: "author",
                newName: "Authors");

            migrationBuilder.RenameTable(
                name: "Book",
                newName: "Books");

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

            migrationBuilder.RenameColumn(
                name: "title",
                table: "Books",
                newName: "Title");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Books",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "author_id",
                table: "Books",
                newName: "AuthorId");

            migrationBuilder.RenameIndex(
                name: "IX_Book_author_id",
                table: "Books",
                newName: "IX_Books_AuthorId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Authors",
                table: "Authors",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Books",
                table: "Books",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Email", "LastName" },
                values: new object[] { "audrey.hendrix@gov.ru", "Hendrix" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2,
                column: "Email",
                value: "oprah.trump@gov.nl");

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "mick.trump@tesla.com", "Mick", "Trump" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Email", "LastName" },
                values: new object[] { "elvis.presley@nasa.org.us", "Presley" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "barack.jagger@bbc.co.uk", "Barack", "Jagger" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Email", "LastName" },
                values: new object[] { "mick.winslet@gov.ru", "Winslet" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "barack.jagger@nasa.org.us", "Barack", "Jagger" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "audrey.hendrix@nasa.org.us", "Audrey", "Hendrix" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "elvis.hendrix@something.com", "Elvis", "Hendrix" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Email", "LastName" },
                values: new object[] { "barack.windsor@gov.nl", "Windsor" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Email", "LastName" },
                values: new object[] { "elvis.hendrix@gov.us", "Hendrix" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "charles.trump@theworld.ca", "Charles", "Trump" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Email", "FirstName" },
                values: new object[] { "donald.trump@gov.gr", "Donald" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "kate.winfrey@bbc.co.uk", "Kate", "Winfrey" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "kate.trump@nasa.org.us", "Kate", "Trump" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Email", "FirstName" },
                values: new object[] { "kate.obama@gov.us", "Kate" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "elvis.obama@bbc.co.uk", "Elvis", "Obama" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Email", "FirstName" },
                values: new object[] { "oprah.presley@theworld.ca", "Oprah" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Email", "FirstName" },
                values: new object[] { "elvis.obama@gov.gr", "Elvis" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "kate.windsor@gov.us", "Kate", "Windsor" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "barack.obama@gov.ru", "Barack", "Obama" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "kate.winfrey@gov.gr", "Kate", "Winfrey" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "barack.presley@gov.ru", "Barack", "Presley" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Email", "LastName" },
                values: new object[] { "charles.hepburn@gov.nl", "Hepburn" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "oprah.winslet@gov.nl", "Oprah", "Winslet" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Email", "LastName" },
                values: new object[] { "audrey.trump@gov.ru", "Trump" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "oprah.winslet@gov.ru", "Oprah", "Winslet" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "barack.middleton@gov.us", "Barack", "Middleton" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "kate.jagger@something.com", "Kate", "Jagger" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Email", "LastName" },
                values: new object[] { "audrey.presley@gov.us", "Presley" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "kate.hendrix@google.com", "Kate", "Hendrix" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "charles.winfrey@something.com", "Charles", "Winfrey" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "barack.winfrey@google.com", "Barack", "Winfrey" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "barack.jagger@something.com", "Barack", "Jagger" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "audrey.winfrey@gov.us", "Audrey", "Winfrey" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Email", "LastName" },
                values: new object[] { "audrey.winfrey@google.com", "Winfrey" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "donald.trump@something.com", "Donald", "Trump" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "kate.windsor@gov.gr", "Kate", "Windsor" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Email", "FirstName" },
                values: new object[] { "audrey.obama@theworld.ca", "Audrey" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Email", "LastName" },
                values: new object[] { "kate.windsor@gov.nl", "Windsor" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Email", "LastName" },
                values: new object[] { "jimi.middleton@theworld.ca", "Middleton" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "barack.hepburn@bbc.co.uk", "Barack", "Hepburn" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "kate.winfrey@gov.us", "Kate", "Winfrey" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Email", "LastName" },
                values: new object[] { "oprah.obama@bbc.co.uk", "Obama" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "audrey.hepburn@bbc.co.uk", "Audrey", "Hepburn" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "audrey.obama@google.com", "Audrey", "Obama" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "audrey.trump@google.com", "Audrey", "Trump" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "kate.jagger@gov.nl", "Kate", "Jagger" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "oprah.hendrix@gov.gr", "Oprah", "Hendrix" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Email", "LastName" },
                values: new object[] { "charles.hendrix@gov.us", "Hendrix" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "kate.presley@gov.ru", "Kate", "Presley" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "charles.presley@something.com", "Charles", "Presley" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "charles.hepburn@something.com", "Charles", "Hepburn" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "audrey.middleton@tesla.com", "Audrey", "Middleton" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "elvis.trump@theworld.ca", "Elvis", "Trump" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "kate.hepburn@gov.gr", "Kate", "Hepburn" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "charles.winfrey@something.com", "Charles", "Winfrey" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "Email", "FirstName" },
                values: new object[] { "kate.presley@gov.ru", "Kate" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "kate.trump@nasa.org.us", "Kate", "Trump" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 60,
                column: "Email",
                value: "oprah.winfrey@gov.ru");

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "mick.middleton@google.com", "Mick", "Middleton" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "Email", "FirstName" },
                values: new object[] { "donald.windsor@gov.ru", "Donald" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "barack.windsor@nasa.org.us", "Barack", "Windsor" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "Email", "FirstName" },
                values: new object[] { "barack.windsor@bbc.co.uk", "Barack" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "audrey.winslet@gov.ru", "Audrey", "Winslet" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "donald.windsor@gov.us", "Donald", "Windsor" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "donald.windsor@gov.gr", "Donald", "Windsor" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "elvis.jagger@theworld.ca", "Elvis", "Jagger" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "donald.trump@gov.nl", "Donald", "Trump" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "mick.obama@tesla.com", "Mick", "Obama" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "charles.middleton@gov.us", "Charles", "Middleton" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "Email", "FirstName" },
                values: new object[] { "mick.middleton@gov.us", "Mick" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "charles.jagger@something.com", "Charles", "Jagger" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "mick.hendrix@tesla.com", "Mick", "Hendrix" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "mick.hepburn@theworld.ca", "Mick", "Hepburn" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "elvis.middleton@gov.gr", "Elvis", "Middleton" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "Email", "LastName" },
                values: new object[] { "kate.hepburn@gov.gr", "Hepburn" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "elvis.middleton@theworld.ca", "Elvis", "Middleton" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "jimi.winslet@tesla.com", "Jimi", "Winslet" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 80,
                column: "Email",
                value: "barack.hendrix@gov.nl");

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "jimi.winfrey@tesla.com", "Jimi", "Winfrey" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "kate.trump@google.com", "Kate", "Trump" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "Email", "LastName" },
                values: new object[] { "kate.obama@theworld.ca", "Obama" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "Email", "LastName" },
                values: new object[] { "kate.presley@bbc.co.uk", "Presley" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "Email", "LastName" },
                values: new object[] { "donald.obama@gov.us", "Obama" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "mick.windsor@google.com", "Mick", "Windsor" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "elvis.middleton@gov.nl", "Elvis", "Middleton" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "donald.hendrix@nasa.org.us", "Donald", "Hendrix" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "elvis.hepburn@theworld.ca", "Elvis", "Hepburn" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "audrey.presley@gov.gr", "Audrey", "Presley" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "mick.hendrix@theworld.ca", "Mick", "Hendrix" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "elvis.winslet@gov.us", "Elvis", "Winslet" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "donald.winslet@nasa.org.us", "Donald", "Winslet" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "audrey.hepburn@gov.us", "Audrey", "Hepburn" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "kate.middleton@gov.gr", "Kate", "Middleton" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "elvis.middleton@theworld.ca", "Elvis", "Middleton" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "charles.presley@google.com", "Charles", "Presley" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "donald.obama@theworld.ca", "Donald", "Obama" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "charles.winslet@tesla.com", "Charles", "Winslet" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "Email", "LastName" },
                values: new object[] { "audrey.windsor@gov.gr", "Windsor" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "elvis.trump@tesla.com", "Elvis", "Trump" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "jimi.trump@bbc.co.uk", "Jimi", "Trump" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "donald.jagger@gov.nl", "Donald", "Jagger" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "jimi.middleton@gov.ru", "Jimi", "Middleton" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "charles.hendrix@gov.nl", "Charles", "Hendrix" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "kate.presley@gov.us", "Kate", "Presley" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "elvis.hendrix@something.com", "Elvis", "Hendrix" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "Email", "FirstName" },
                values: new object[] { "mick.presley@gov.nl", "Mick" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "donald.trump@gov.us", "Donald", "Trump" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "audrey.obama@gov.us", "Audrey", "Obama" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "jimi.trump@bbc.co.uk", "Jimi", "Trump" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "mick.obama@gov.gr", "Mick", "Obama" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "charles.winfrey@google.com", "Charles", "Winfrey" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "jimi.windsor@bbc.co.uk", "Jimi", "Windsor" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "kate.hepburn@gov.ru", "Kate", "Hepburn" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "kate.winfrey@something.com", "Kate", "Winfrey" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "charles.middleton@nasa.org.us", "Charles", "Middleton" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "elvis.winfrey@gov.ru", "Elvis", "Winfrey" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "Email", "FirstName" },
                values: new object[] { "kate.windsor@gov.us", "Kate" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "audrey.winfrey@gov.ru", "Audrey", "Winfrey" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "kate.middleton@gov.gr", "Kate", "Middleton" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "Email", "FirstName" },
                values: new object[] { "oprah.obama@google.com", "Oprah" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "elvis.jagger@bbc.co.uk", "Elvis", "Jagger" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "audrey.middleton@nasa.org.us", "Audrey", "Middleton" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "elvis.hendrix@nasa.org.us", "Elvis", "Hendrix" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "kate.hendrix@tesla.com", "Kate", "Hendrix" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "elvis.presley@tesla.com", "Elvis", "Presley" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "mick.winfrey@gov.nl", "Mick", "Winfrey" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "Email", "FirstName" },
                values: new object[] { "audrey.trump@theworld.ca", "Audrey" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "jimi.hendrix@theworld.ca", "Jimi", "Hendrix" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "Email", "LastName" },
                values: new object[] { "kate.hepburn@gov.us", "Hepburn" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "elvis.jagger@bbc.co.uk", "Elvis", "Jagger" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "audrey.obama@gov.us", "Audrey", "Obama" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "mick.winslet@bbc.co.uk", "Mick", "Winslet" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "mick.middleton@tesla.com", "Mick", "Middleton" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "Email", "LastName" },
                values: new object[] { "kate.presley@gov.gr", "Presley" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "Email", "LastName" },
                values: new object[] { "kate.trump@gov.gr", "Trump" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "Email", "FirstName" },
                values: new object[] { "barack.obama@nasa.org.us", "Barack" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "elvis.hepburn@nasa.org.us", "Elvis", "Hepburn" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "kate.hepburn@nasa.org.us", "Kate", "Hepburn" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "Email", "FirstName" },
                values: new object[] { "jimi.windsor@gov.us", "Jimi" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "charles.jagger@google.com", "Charles", "Jagger" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "kate.hepburn@something.com", "Kate", "Hepburn" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "mick.obama@tesla.com", "Mick", "Obama" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "Email", "LastName" },
                values: new object[] { "mick.hepburn@google.com", "Hepburn" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "elvis.obama@gov.gr", "Elvis", "Obama" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "kate.obama@theworld.ca", "Kate", "Obama" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "kate.windsor@google.com", "Kate", "Windsor" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "oprah.winslet@gov.gr", "Oprah", "Winslet" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "audrey.windsor@google.com", "Audrey", "Windsor" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "barack.middleton@theworld.ca", "Barack", "Middleton" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "mick.jagger@bbc.co.uk", "Mick", "Jagger" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "charles.middleton@gov.us", "Charles", "Middleton" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "kate.trump@google.com", "Kate", "Trump" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "kate.hepburn@gov.gr", "Kate", "Hepburn" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 157,
                column: "Email",
                value: "oprah.hendrix@nasa.org.us");

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "mick.winfrey@something.com", "Mick", "Winfrey" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "charles.hepburn@theworld.ca", "Charles", "Hepburn" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "charles.trump@nasa.org.us", "Charles", "Trump" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "charles.middleton@gov.us", "Charles", "Middleton" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "donald.presley@something.com", "Donald", "Presley" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "charles.jagger@gov.us", "Charles", "Jagger" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "donald.trump@bbc.co.uk", "Donald", "Trump" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "jimi.hepburn@theworld.ca", "Jimi", "Hepburn" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "donald.trump@nasa.org.us", "Donald", "Trump" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "mick.jagger@tesla.com", "Mick", "Jagger" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "charles.presley@something.com", "Charles", "Presley" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "Email", "FirstName" },
                values: new object[] { "audrey.hepburn@tesla.com", "Audrey" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "Email", "FirstName" },
                values: new object[] { "audrey.windsor@theworld.ca", "Audrey" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "elvis.winslet@gov.gr", "Elvis", "Winslet" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "kate.hepburn@theworld.ca", "Kate", "Hepburn" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "jimi.windsor@gov.us", "Jimi", "Windsor" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 174,
                column: "Email",
                value: "kate.trump@google.com");

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "jimi.obama@gov.gr", "Jimi", "Obama" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "mick.windsor@tesla.com", "Mick", "Windsor" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "barack.winfrey@gov.ru", "Barack", "Winfrey" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "Email", "FirstName" },
                values: new object[] { "kate.middleton@gov.gr", "Kate" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "charles.winfrey@gov.gr", "Charles", "Winfrey" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "barack.hepburn@nasa.org.us", "Barack", "Hepburn" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "barack.winslet@google.com", "Barack", "Winslet" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "donald.presley@nasa.org.us", "Donald", "Presley" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "donald.middleton@gov.us", "Donald", "Middleton" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "elvis.winfrey@tesla.com", "Elvis", "Winfrey" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "elvis.middleton@gov.us", "Elvis", "Middleton" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "Email", "FirstName" },
                values: new object[] { "oprah.winfrey@gov.us", "Oprah" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "oprah.trump@tesla.com", "Oprah", "Trump" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 188,
                column: "Email",
                value: "jimi.jagger@tesla.com");

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "kate.hendrix@gov.nl", "Kate", "Hendrix" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "oprah.middleton@nasa.org.us", "Oprah", "Middleton" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "kate.winslet@gov.nl", "Kate", "Winslet" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "audrey.winfrey@gov.gr", "Audrey", "Winfrey" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "kate.obama@theworld.ca", "Kate", "Obama" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "elvis.obama@gov.us", "Elvis", "Obama" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "jimi.obama@gov.us", "Jimi", "Obama" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "Email", "LastName" },
                values: new object[] { "audrey.jagger@gov.gr", "Jagger" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "barack.presley@gov.us", "Barack", "Presley" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "kate.windsor@tesla.com", "Kate", "Windsor" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "elvis.hepburn@google.com", "Elvis", "Hepburn" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "Email", "LastName" },
                values: new object[] { "elvis.windsor@gov.nl", "Windsor" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "Email", "LastName" },
                values: new object[] { "oprah.presley@something.com", "Presley" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "charles.hendrix@something.com", "Charles", "Hendrix" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 203,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "kate.jagger@gov.gr", "Kate", "Jagger" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 204,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "kate.trump@google.com", "Kate", "Trump" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 205,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "kate.presley@nasa.org.us", "Kate", "Presley" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 206,
                columns: new[] { "Email", "FirstName" },
                values: new object[] { "mick.winfrey@tesla.com", "Mick" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 207,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "mick.middleton@something.com", "Mick", "Middleton" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 208,
                columns: new[] { "Email", "LastName" },
                values: new object[] { "elvis.hepburn@gov.ru", "Hepburn" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 209,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "kate.hepburn@something.com", "Kate", "Hepburn" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 210,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "barack.presley@gov.us", "Barack", "Presley" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 211,
                columns: new[] { "Email", "FirstName" },
                values: new object[] { "oprah.obama@nasa.org.us", "Oprah" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 212,
                columns: new[] { "Email", "LastName" },
                values: new object[] { "kate.presley@gov.us", "Presley" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 213,
                columns: new[] { "Email", "FirstName" },
                values: new object[] { "charles.middleton@gov.us", "Charles" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 214,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "kate.obama@tesla.com", "Kate", "Obama" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 215,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "kate.winslet@gov.us", "Kate", "Winslet" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 216,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "jimi.obama@tesla.com", "Jimi", "Obama" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 217,
                columns: new[] { "Email", "LastName" },
                values: new object[] { "charles.obama@gov.gr", "Obama" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 218,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "barack.obama@gov.ru", "Barack", "Obama" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 219,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "mick.winslet@google.com", "Mick", "Winslet" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 220,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "charles.obama@google.com", "Charles", "Obama" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 221,
                columns: new[] { "Email", "LastName" },
                values: new object[] { "mick.trump@bbc.co.uk", "Trump" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 222,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "audrey.hepburn@nasa.org.us", "Audrey", "Hepburn" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 223,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "kate.middleton@nasa.org.us", "Kate", "Middleton" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 224,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "mick.middleton@theworld.ca", "Mick", "Middleton" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 225,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "kate.presley@nasa.org.us", "Kate", "Presley" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 226,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "elvis.hepburn@gov.us", "Elvis", "Hepburn" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 227,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "kate.presley@theworld.ca", "Kate", "Presley" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 228,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "elvis.jagger@gov.gr", "Elvis", "Jagger" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 229,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "oprah.presley@tesla.com", "Oprah", "Presley" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 230,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "kate.presley@tesla.com", "Kate", "Presley" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 231,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "audrey.windsor@nasa.org.us", "Audrey", "Windsor" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 232,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "barack.hendrix@something.com", "Barack", "Hendrix" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 233,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "jimi.winfrey@gov.gr", "Jimi", "Winfrey" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 234,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "audrey.jagger@google.com", "Audrey", "Jagger" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 235,
                columns: new[] { "Email", "LastName" },
                values: new object[] { "kate.winslet@google.com", "Winslet" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 236,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "elvis.jagger@google.com", "Elvis", "Jagger" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 237,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "donald.trump@something.com", "Donald", "Trump" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 238,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "kate.jagger@gov.ru", "Kate", "Jagger" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 239,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "mick.hendrix@google.com", "Mick", "Hendrix" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 240,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "barack.trump@gov.ru", "Barack", "Trump" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 241,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "charles.windsor@bbc.co.uk", "Charles", "Windsor" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 242,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "charles.winslet@google.com", "Charles", "Winslet" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 243,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "barack.trump@bbc.co.uk", "Barack", "Trump" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 244,
                columns: new[] { "Email", "LastName" },
                values: new object[] { "mick.hepburn@nasa.org.us", "Hepburn" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 245,
                columns: new[] { "Email", "LastName" },
                values: new object[] { "kate.jagger@something.com", "Jagger" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 246,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "jimi.windsor@tesla.com", "Jimi", "Windsor" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 247,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "oprah.obama@gov.ru", "Oprah", "Obama" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 248,
                columns: new[] { "Email", "LastName" },
                values: new object[] { "kate.trump@google.com", "Trump" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 249,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "oprah.hepburn@gov.nl", "Oprah", "Hepburn" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 229, "A herd of Microscopic Leopards" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 11, "The Large Buildings" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 207, "A bunch of Large Planets" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 5, "Several Transparent Leopards" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 52, "A bunch of Bitter Houses" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 120, "Two Transparent Leopards" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 247, "A bunch of Microscopic Houses" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 130, "Fifteen Rose Smelling Planets" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 239, "Two Purple Flowers" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 179, "Two Microscopic Houses" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 89, "A herd of Green Buildings" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 15, "The Orange Buildings" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 212, "A bunch of Large Planets" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 70, "Two Large Leopards" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 73, "The Green Houses" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 228, "The Orange Houses" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 173, "The Orange Flowers" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 189, "The Large Leopards" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 49, "Two Transparent Flowers" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 17, "Two Rose Smelling Flowers" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 102, "Fifteen Green Planets" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 177, "Two Microscopic Flowers" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 68, "Several Transparent Leopards" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 244, "A bunch of Large Cars" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 153, "Several Orange Leopards" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 240, "Several Green Houses" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 142, "Two Large Houses" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 94, "Several Green Leopards" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 196, "Fifteen Bitter Planets" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 46, "Fifteen Microscopic Cars" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 159, "Two Orange Planets" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 45, "Fifteen Large Houses" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 25, "Two Rose Smelling Houses" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 218, "Several Large Houses" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 18, "Fifteen Rose Smelling Planets" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 45, "A herd of Rose Smelling Leopards" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 127, "A bunch of Bitter Houses" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 210, "The Rose Smelling Planets" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 238, "Several Green Houses" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 52, "A herd of Purple Houses" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 241, "A herd of Rose Smelling Houses" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 247, "A bunch of Purple Flowers" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 43,
                column: "Title",
                value: "Fifteen Microscopic Flowers");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 120, "Two Purple Flowers" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 26, "Several Transparent Flowers" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 149, "An army of Green Cars" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 143, "A bunch of Transparent Flowers" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 224, "A herd of Purple Flowers" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 113, "A bunch of Large Planets" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 84, "A herd of Rose Smelling Flowers" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 34, "An army of Microscopic Buildings" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 206, "A herd of Green Buildings" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 210, "Several Bitter Buildings" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 201, "An army of Microscopic Leopards" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 61, "A herd of Transparent Planets" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 125, "Fifteen Purple Planets" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 85, "An army of Microscopic Planets" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 125, "A bunch of Purple Cars" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 81, "Fifteen Green Houses" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 137, "A herd of Large Leopards" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 205, "A herd of Orange Planets" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 35, "An army of Microscopic Leopards" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 130, "An army of Transparent Houses" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 43, "Several Green Planets" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 159, "Fifteen Purple Houses" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 81, "Two Rose Smelling Leopards" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 21, "An army of Rose Smelling Leopards" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 68, "A herd of Microscopic Cars" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 132, "An army of Orange Leopards" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 52, "A bunch of Purple Cars" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 123, "A bunch of Bitter Houses" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 102, "The Purple Flowers" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 54, "A bunch of Green Cars" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 107, "The Large Buildings" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 15, "A bunch of Orange Buildings" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 173, "The Purple Planets" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 48, "An army of Microscopic Flowers" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 28, "Several Bitter Buildings" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 165, "A bunch of Transparent Flowers" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 186, "Two Transparent Houses" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 223, "The Green Buildings" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 104, "Fifteen Transparent Buildings" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 194, "A bunch of Orange Houses" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 140, "Two Microscopic Cars" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 195, "A herd of Orange Houses" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 157, "Several Green Flowers" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 46, "Fifteen Rose Smelling Leopards" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 143, "An army of Green Flowers" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 234, "A bunch of Green Cars" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 156, "Several Bitter Houses" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 216, "A bunch of Microscopic Leopards" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 124, "A bunch of Large Leopards" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 65, "Several Transparent Buildings" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 82, "Several Orange Houses" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 82, "A herd of Green Buildings" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 72, "Fifteen Transparent Houses" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 225, "A herd of Orange Planets" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 83, "Several Large Planets" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 164, "A bunch of Green Planets" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 236, "A herd of Bitter Cars" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 68, "The Orange Flowers" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 203, "A bunch of Purple Flowers" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 50, "A bunch of Microscopic Houses" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 82, "A bunch of Purple Leopards" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 198, "A bunch of Transparent Buildings" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 106, "An army of Large Leopards" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 119, "An army of Green Cars" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 33, "Fifteen Orange Flowers" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 93, "A herd of Microscopic Flowers" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 86, "The Bitter Leopards" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 232, "Two Bitter Planets" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 123, "Several Purple Houses" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 197, "Several Purple Leopards" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 165, "An army of Rose Smelling Planets" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 5, "Two Green Planets" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 243, "A bunch of Microscopic Cars" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 125, "A herd of Purple Flowers" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 1, "An army of Microscopic Flowers" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 24, "Two Orange Leopards" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 243, "Several Purple Planets" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 161, "Several Transparent Flowers" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 67, "A bunch of Purple Cars" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 212, "A herd of Transparent Cars" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 84, "The Green Cars" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 119, "Fifteen Purple Houses" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 52, "A herd of Transparent Planets" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 202, "An army of Bitter Cars" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 88, "A bunch of Bitter Planets" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 234, "A herd of Large Cars" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 204, "A bunch of Orange Planets" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 65, "A bunch of Rose Smelling Houses" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 203, "A herd of Transparent Leopards" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 212, "An army of Purple Houses" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 31, "The Rose Smelling Flowers" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 57, "A bunch of Rose Smelling Buildings" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 103, "Several Bitter Houses" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 189, "An army of Large Leopards" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 198, "Fifteen Green Buildings" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 200, "Two Transparent Houses" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 181, "A bunch of Microscopic Planets" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 18, "Fifteen Rose Smelling Cars" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 101, "A herd of Purple Planets" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 67, "A bunch of Orange Cars" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 235, "The Purple Planets" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 44, "The Bitter Leopards" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 42, "A herd of Rose Smelling Houses" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 128, "Two Bitter Cars" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 90, "A herd of Orange Houses" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 183, "A herd of Microscopic Houses" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 53, "Fifteen Bitter Flowers" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 2, "Several Orange Flowers" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 224, "Several Bitter Flowers" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 103, "An army of Purple Flowers" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 147, "Fifteen Rose Smelling Houses" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 22, "A bunch of Orange Cars" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 212, "Two Large Planets" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 206, "The Green Houses" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 149, "The Bitter Cars" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 104, "Fifteen Transparent Buildings" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 77, "The Bitter Leopards" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 150, "A bunch of Orange Leopards" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 182, "A herd of Rose Smelling Cars" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 127, "Two Green Houses" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 238, "Two Rose Smelling Leopards" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 67, "Fifteen Large Houses" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 1, "Two Transparent Cars" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 17, "A herd of Purple Buildings" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 110, "Two Green Cars" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 221, "Fifteen Large Planets" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 68, "An army of Orange Cars" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 192, "A herd of Purple Cars" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 236, "A herd of Purple Planets" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 114, "Two Purple Flowers" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 178, "An army of Green Planets" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 25, "A herd of Rose Smelling Houses" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 111, "Two Orange Flowers" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 81, "A herd of Transparent Cars" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 38, "Fifteen Green Cars" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 52, "An army of Rose Smelling Houses" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 159, "A bunch of Orange Flowers" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 26, "A bunch of Rose Smelling Flowers" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 130, "The Orange Planets" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 234, "A bunch of Rose Smelling Leopards" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 26, "An army of Green Buildings" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 122, "Two Purple Buildings" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 84, "Fifteen Transparent Houses" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 109, "Fifteen Bitter Flowers" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 15, "Several Orange Flowers" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 119, "An army of Green Flowers" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 236, "Fifteen Large Flowers" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 75, "Fifteen Rose Smelling Houses" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 210, "Several Rose Smelling Planets" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 193, "A bunch of Large Leopards" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 2, "Fifteen Rose Smelling Cars" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 112, "An army of Microscopic Houses" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 198, "Two Green Houses" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 197, "A bunch of Orange Flowers" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 182, "Several Green Houses" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 243, "Two Transparent Flowers" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 243, "Several Rose Smelling Flowers" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 18, "An army of Bitter Houses" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 137, "Fifteen Transparent Cars" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 203,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 247, "Two Transparent Leopards" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 204,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 238, "A herd of Large Cars" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 205,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 34, "Fifteen Microscopic Cars" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 206,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 27, "The Microscopic Buildings" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 207,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 198, "Fifteen Orange Leopards" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 208,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 21, "Two Bitter Flowers" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 209,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 28, "An army of Microscopic Cars" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 210,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 164, "Several Transparent Buildings" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 211,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 91, "Several Orange Leopards" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 212,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 197, "Fifteen Green Flowers" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 213,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 173, "A bunch of Transparent Buildings" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 214,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 10, "A bunch of Large Buildings" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 215,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 221, "A herd of Large Cars" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 216,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 149, "Fifteen Purple Buildings" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 217,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 224, "An army of Microscopic Flowers" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 218,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 220, "Fifteen Rose Smelling Buildings" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 219,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 182, "A bunch of Transparent Planets" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 220,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 134, "Several Large Leopards" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 221,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 182, "The Microscopic Leopards" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 222,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 221, "A herd of Transparent Leopards" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 223,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 210, "Several Purple Cars" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 224,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 51, "Several Green Leopards" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 225,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 16, "A bunch of Rose Smelling Leopards" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 226,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 36, "Several Purple Cars" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 227,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 125, "The Large Planets" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 228,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 171, "The Orange Planets" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 229,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 218, "A herd of Large Buildings" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 230,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 126, "An army of Microscopic Leopards" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 231,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 76, "Fifteen Purple Flowers" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 232,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 119, "The Microscopic Leopards" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 233,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 96, "The Transparent Houses" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 234,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 183, "An army of Microscopic Planets" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 235,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 49, "Fifteen Green Houses" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 236,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 138, "Two Rose Smelling Cars" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 237,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 96, "Two Rose Smelling Flowers" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 238,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 142, "A herd of Purple Cars" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 239,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 246, "Several Rose Smelling Leopards" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 240,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 105, "The Purple Planets" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 241,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 202, "An army of Large Leopards" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 242,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 154, "A bunch of Transparent Planets" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 243,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 119, "The Rose Smelling Buildings" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 244,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 76, "An army of Orange Cars" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 245,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 123, "The Purple Houses" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 246,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 185, "Two Green Leopards" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 247,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 245, "Two Bitter Leopards" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 248,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 237, "The Purple Cars" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 249,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 163, "Fifteen Transparent Flowers" });

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
