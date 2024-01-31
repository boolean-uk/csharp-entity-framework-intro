using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace exercise.webapi.Migrations
{
    /// <inheritdoc />
    public partial class seeder : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "authors",
                columns: new[] { "id", "email", "first_name", "last_name" },
                values: new object[,]
                {
                    { 1, "barack.obama@google.com", "Barack", "Obama" },
                    { 2, "elvis.trump@something.com", "Elvis", "Trump" },
                    { 3, "kate.middleton@nasa.org.us", "Kate", "Middleton" },
                    { 4, "barack.hendrix@something.com", "Barack", "Hendrix" },
                    { 5, "kate.winslet@gov.gr", "Kate", "Winslet" },
                    { 6, "charles.middleton@nasa.org.us", "Charles", "Middleton" },
                    { 7, "mick.presley@something.com", "Mick", "Presley" },
                    { 8, "elvis.hendrix@theworld.ca", "Elvis", "Hendrix" },
                    { 9, "charles.jagger@tesla.com", "Charles", "Jagger" },
                    { 10, "jimi.obama@gov.gr", "Jimi", "Obama" },
                    { 11, "charles.jagger@gov.gr", "Charles", "Jagger" },
                    { 12, "charles.trump@nasa.org.us", "Charles", "Trump" },
                    { 13, "elvis.trump@gov.gr", "Elvis", "Trump" },
                    { 14, "barack.presley@gov.us", "Barack", "Presley" },
                    { 15, "elvis.winfrey@gov.gr", "Elvis", "Winfrey" },
                    { 16, "audrey.hendrix@gov.nl", "Audrey", "Hendrix" },
                    { 17, "kate.winfrey@gov.ru", "Kate", "Winfrey" },
                    { 18, "mick.winslet@gov.us", "Mick", "Winslet" },
                    { 19, "jimi.middleton@nasa.org.us", "Jimi", "Middleton" },
                    { 20, "charles.hepburn@something.com", "Charles", "Hepburn" },
                    { 21, "barack.middleton@bbc.co.uk", "Barack", "Middleton" },
                    { 22, "barack.trump@gov.nl", "Barack", "Trump" },
                    { 23, "mick.trump@theworld.ca", "Mick", "Trump" },
                    { 24, "donald.trump@nasa.org.us", "Donald", "Trump" },
                    { 25, "mick.obama@gov.gr", "Mick", "Obama" },
                    { 26, "kate.presley@bbc.co.uk", "Kate", "Presley" },
                    { 27, "audrey.presley@gov.nl", "Audrey", "Presley" },
                    { 28, "mick.presley@theworld.ca", "Mick", "Presley" },
                    { 29, "barack.middleton@gov.ru", "Barack", "Middleton" },
                    { 30, "charles.windsor@google.com", "Charles", "Windsor" },
                    { 31, "elvis.winslet@something.com", "Elvis", "Winslet" },
                    { 32, "jimi.hepburn@gov.us", "Jimi", "Hepburn" },
                    { 33, "charles.jagger@theworld.ca", "Charles", "Jagger" },
                    { 34, "charles.hendrix@gov.us", "Charles", "Hendrix" },
                    { 35, "jimi.obama@tesla.com", "Jimi", "Obama" },
                    { 36, "audrey.windsor@gov.us", "Audrey", "Windsor" },
                    { 37, "mick.jagger@google.com", "Mick", "Jagger" },
                    { 38, "kate.jagger@google.com", "Kate", "Jagger" },
                    { 39, "kate.windsor@google.com", "Kate", "Windsor" },
                    { 40, "barack.middleton@gov.ru", "Barack", "Middleton" },
                    { 41, "donald.obama@theworld.ca", "Donald", "Obama" },
                    { 42, "oprah.hendrix@google.com", "Oprah", "Hendrix" },
                    { 43, "audrey.winslet@nasa.org.us", "Audrey", "Winslet" },
                    { 44, "kate.hendrix@theworld.ca", "Kate", "Hendrix" },
                    { 45, "oprah.presley@bbc.co.uk", "Oprah", "Presley" },
                    { 46, "barack.hendrix@nasa.org.us", "Barack", "Hendrix" },
                    { 47, "mick.obama@gov.us", "Mick", "Obama" },
                    { 48, "barack.hendrix@theworld.ca", "Barack", "Hendrix" },
                    { 49, "donald.middleton@theworld.ca", "Donald", "Middleton" },
                    { 50, "mick.winslet@theworld.ca", "Mick", "Winslet" },
                    { 51, "kate.winfrey@something.com", "Kate", "Winfrey" },
                    { 52, "elvis.trump@google.com", "Elvis", "Trump" },
                    { 53, "jimi.jagger@something.com", "Jimi", "Jagger" },
                    { 54, "elvis.presley@gov.us", "Elvis", "Presley" },
                    { 55, "kate.winfrey@gov.nl", "Kate", "Winfrey" },
                    { 56, "oprah.hendrix@gov.us", "Oprah", "Hendrix" },
                    { 57, "charles.obama@gov.gr", "Charles", "Obama" },
                    { 58, "kate.obama@gov.gr", "Kate", "Obama" },
                    { 59, "elvis.jagger@gov.gr", "Elvis", "Jagger" },
                    { 60, "oprah.trump@bbc.co.uk", "Oprah", "Trump" },
                    { 61, "barack.hendrix@gov.ru", "Barack", "Hendrix" },
                    { 62, "mick.obama@bbc.co.uk", "Mick", "Obama" },
                    { 63, "donald.jagger@nasa.org.us", "Donald", "Jagger" },
                    { 64, "mick.windsor@gov.nl", "Mick", "Windsor" },
                    { 65, "jimi.middleton@gov.ru", "Jimi", "Middleton" },
                    { 66, "charles.presley@gov.ru", "Charles", "Presley" },
                    { 67, "charles.jagger@nasa.org.us", "Charles", "Jagger" },
                    { 68, "mick.windsor@gov.us", "Mick", "Windsor" },
                    { 69, "jimi.winslet@nasa.org.us", "Jimi", "Winslet" },
                    { 70, "mick.windsor@gov.nl", "Mick", "Windsor" },
                    { 71, "kate.trump@gov.us", "Kate", "Trump" },
                    { 72, "oprah.hendrix@nasa.org.us", "Oprah", "Hendrix" },
                    { 73, "audrey.winfrey@something.com", "Audrey", "Winfrey" },
                    { 74, "barack.middleton@gov.us", "Barack", "Middleton" },
                    { 75, "audrey.middleton@gov.nl", "Audrey", "Middleton" },
                    { 76, "oprah.winslet@nasa.org.us", "Oprah", "Winslet" },
                    { 77, "jimi.windsor@theworld.ca", "Jimi", "Windsor" },
                    { 78, "donald.windsor@something.com", "Donald", "Windsor" },
                    { 79, "audrey.windsor@nasa.org.us", "Audrey", "Windsor" },
                    { 80, "donald.presley@bbc.co.uk", "Donald", "Presley" },
                    { 81, "kate.hendrix@gov.us", "Kate", "Hendrix" },
                    { 82, "donald.jagger@google.com", "Donald", "Jagger" },
                    { 83, "donald.windsor@tesla.com", "Donald", "Windsor" },
                    { 84, "barack.middleton@something.com", "Barack", "Middleton" },
                    { 85, "elvis.winfrey@tesla.com", "Elvis", "Winfrey" },
                    { 86, "charles.jagger@bbc.co.uk", "Charles", "Jagger" },
                    { 87, "barack.middleton@gov.us", "Barack", "Middleton" },
                    { 88, "charles.hepburn@google.com", "Charles", "Hepburn" },
                    { 89, "elvis.presley@gov.nl", "Elvis", "Presley" },
                    { 90, "kate.jagger@nasa.org.us", "Kate", "Jagger" },
                    { 91, "kate.obama@gov.gr", "Kate", "Obama" },
                    { 92, "charles.presley@tesla.com", "Charles", "Presley" },
                    { 93, "kate.middleton@tesla.com", "Kate", "Middleton" },
                    { 94, "barack.middleton@theworld.ca", "Barack", "Middleton" },
                    { 95, "charles.windsor@tesla.com", "Charles", "Windsor" },
                    { 96, "audrey.jagger@gov.gr", "Audrey", "Jagger" },
                    { 97, "kate.presley@gov.nl", "Kate", "Presley" },
                    { 98, "audrey.winslet@gov.nl", "Audrey", "Winslet" },
                    { 99, "elvis.winslet@gov.us", "Elvis", "Winslet" },
                    { 100, "jimi.windsor@gov.gr", "Jimi", "Windsor" },
                    { 101, "oprah.hendrix@gov.us", "Oprah", "Hendrix" },
                    { 102, "oprah.winfrey@bbc.co.uk", "Oprah", "Winfrey" },
                    { 103, "oprah.hepburn@something.com", "Oprah", "Hepburn" },
                    { 104, "kate.obama@something.com", "Kate", "Obama" },
                    { 105, "oprah.obama@gov.us", "Oprah", "Obama" },
                    { 106, "kate.winslet@gov.ru", "Kate", "Winslet" },
                    { 107, "mick.winfrey@theworld.ca", "Mick", "Winfrey" },
                    { 108, "donald.presley@theworld.ca", "Donald", "Presley" },
                    { 109, "charles.hendrix@gov.ru", "Charles", "Hendrix" },
                    { 110, "jimi.presley@bbc.co.uk", "Jimi", "Presley" },
                    { 111, "kate.jagger@something.com", "Kate", "Jagger" },
                    { 112, "elvis.presley@nasa.org.us", "Elvis", "Presley" },
                    { 113, "donald.obama@gov.nl", "Donald", "Obama" },
                    { 114, "charles.hepburn@something.com", "Charles", "Hepburn" },
                    { 115, "jimi.windsor@bbc.co.uk", "Jimi", "Windsor" },
                    { 116, "jimi.winfrey@theworld.ca", "Jimi", "Winfrey" },
                    { 117, "jimi.trump@bbc.co.uk", "Jimi", "Trump" },
                    { 118, "jimi.jagger@gov.ru", "Jimi", "Jagger" },
                    { 119, "audrey.obama@nasa.org.us", "Audrey", "Obama" },
                    { 120, "jimi.windsor@gov.nl", "Jimi", "Windsor" },
                    { 121, "audrey.obama@gov.nl", "Audrey", "Obama" },
                    { 122, "donald.trump@google.com", "Donald", "Trump" },
                    { 123, "oprah.windsor@gov.gr", "Oprah", "Windsor" },
                    { 124, "oprah.hepburn@nasa.org.us", "Oprah", "Hepburn" },
                    { 125, "jimi.trump@tesla.com", "Jimi", "Trump" },
                    { 126, "oprah.windsor@nasa.org.us", "Oprah", "Windsor" },
                    { 127, "elvis.winslet@gov.us", "Elvis", "Winslet" },
                    { 128, "oprah.hendrix@something.com", "Oprah", "Hendrix" },
                    { 129, "charles.windsor@nasa.org.us", "Charles", "Windsor" },
                    { 130, "audrey.obama@bbc.co.uk", "Audrey", "Obama" },
                    { 131, "elvis.middleton@google.com", "Elvis", "Middleton" },
                    { 132, "barack.trump@bbc.co.uk", "Barack", "Trump" },
                    { 133, "kate.obama@nasa.org.us", "Kate", "Obama" },
                    { 134, "kate.hendrix@gov.ru", "Kate", "Hendrix" },
                    { 135, "donald.presley@bbc.co.uk", "Donald", "Presley" },
                    { 136, "elvis.hepburn@bbc.co.uk", "Elvis", "Hepburn" },
                    { 137, "barack.winfrey@something.com", "Barack", "Winfrey" },
                    { 138, "oprah.winslet@gov.us", "Oprah", "Winslet" },
                    { 139, "kate.winfrey@gov.ru", "Kate", "Winfrey" },
                    { 140, "jimi.obama@bbc.co.uk", "Jimi", "Obama" },
                    { 141, "oprah.hendrix@something.com", "Oprah", "Hendrix" },
                    { 142, "elvis.trump@gov.us", "Elvis", "Trump" },
                    { 143, "kate.middleton@theworld.ca", "Kate", "Middleton" },
                    { 144, "oprah.jagger@gov.nl", "Oprah", "Jagger" },
                    { 145, "jimi.hendrix@google.com", "Jimi", "Hendrix" },
                    { 146, "donald.windsor@google.com", "Donald", "Windsor" },
                    { 147, "elvis.winslet@gov.us", "Elvis", "Winslet" },
                    { 148, "elvis.winfrey@something.com", "Elvis", "Winfrey" },
                    { 149, "jimi.windsor@something.com", "Jimi", "Windsor" },
                    { 150, "jimi.winfrey@gov.ru", "Jimi", "Winfrey" },
                    { 151, "jimi.windsor@theworld.ca", "Jimi", "Windsor" },
                    { 152, "jimi.middleton@tesla.com", "Jimi", "Middleton" },
                    { 153, "audrey.winslet@gov.us", "Audrey", "Winslet" },
                    { 154, "kate.presley@something.com", "Kate", "Presley" },
                    { 155, "barack.obama@nasa.org.us", "Barack", "Obama" },
                    { 156, "elvis.hendrix@gov.us", "Elvis", "Hendrix" },
                    { 157, "kate.jagger@bbc.co.uk", "Kate", "Jagger" },
                    { 158, "audrey.winslet@gov.gr", "Audrey", "Winslet" },
                    { 159, "mick.winslet@tesla.com", "Mick", "Winslet" },
                    { 160, "audrey.presley@nasa.org.us", "Audrey", "Presley" },
                    { 161, "barack.presley@bbc.co.uk", "Barack", "Presley" },
                    { 162, "audrey.winfrey@something.com", "Audrey", "Winfrey" },
                    { 163, "kate.winslet@theworld.ca", "Kate", "Winslet" },
                    { 164, "oprah.presley@theworld.ca", "Oprah", "Presley" },
                    { 165, "mick.hepburn@google.com", "Mick", "Hepburn" },
                    { 166, "charles.trump@gov.us", "Charles", "Trump" },
                    { 167, "jimi.obama@gov.ru", "Jimi", "Obama" },
                    { 168, "audrey.winfrey@gov.nl", "Audrey", "Winfrey" },
                    { 169, "oprah.obama@gov.ru", "Oprah", "Obama" },
                    { 170, "audrey.hepburn@theworld.ca", "Audrey", "Hepburn" },
                    { 171, "charles.windsor@gov.us", "Charles", "Windsor" },
                    { 172, "jimi.hendrix@nasa.org.us", "Jimi", "Hendrix" },
                    { 173, "elvis.middleton@theworld.ca", "Elvis", "Middleton" },
                    { 174, "kate.jagger@google.com", "Kate", "Jagger" },
                    { 175, "charles.presley@something.com", "Charles", "Presley" },
                    { 176, "barack.hepburn@gov.nl", "Barack", "Hepburn" },
                    { 177, "kate.hepburn@bbc.co.uk", "Kate", "Hepburn" },
                    { 178, "mick.obama@bbc.co.uk", "Mick", "Obama" },
                    { 179, "kate.trump@something.com", "Kate", "Trump" },
                    { 180, "barack.presley@gov.nl", "Barack", "Presley" },
                    { 181, "kate.middleton@gov.nl", "Kate", "Middleton" },
                    { 182, "jimi.presley@nasa.org.us", "Jimi", "Presley" },
                    { 183, "charles.middleton@gov.nl", "Charles", "Middleton" },
                    { 184, "mick.hendrix@gov.gr", "Mick", "Hendrix" },
                    { 185, "mick.windsor@theworld.ca", "Mick", "Windsor" },
                    { 186, "donald.windsor@theworld.ca", "Donald", "Windsor" },
                    { 187, "jimi.jagger@gov.ru", "Jimi", "Jagger" },
                    { 188, "oprah.presley@theworld.ca", "Oprah", "Presley" },
                    { 189, "kate.hendrix@something.com", "Kate", "Hendrix" },
                    { 190, "mick.hendrix@gov.us", "Mick", "Hendrix" },
                    { 191, "audrey.hendrix@google.com", "Audrey", "Hendrix" },
                    { 192, "elvis.winfrey@theworld.ca", "Elvis", "Winfrey" },
                    { 193, "audrey.trump@gov.gr", "Audrey", "Trump" },
                    { 194, "barack.jagger@google.com", "Barack", "Jagger" },
                    { 195, "oprah.hepburn@google.com", "Oprah", "Hepburn" },
                    { 196, "kate.jagger@tesla.com", "Kate", "Jagger" },
                    { 197, "barack.hepburn@theworld.ca", "Barack", "Hepburn" },
                    { 198, "kate.hepburn@nasa.org.us", "Kate", "Hepburn" },
                    { 199, "donald.trump@bbc.co.uk", "Donald", "Trump" },
                    { 200, "charles.jagger@gov.gr", "Charles", "Jagger" },
                    { 201, "jimi.jagger@google.com", "Jimi", "Jagger" },
                    { 202, "donald.presley@tesla.com", "Donald", "Presley" },
                    { 203, "donald.obama@gov.gr", "Donald", "Obama" },
                    { 204, "kate.jagger@gov.gr", "Kate", "Jagger" },
                    { 205, "audrey.jagger@tesla.com", "Audrey", "Jagger" },
                    { 206, "mick.winfrey@google.com", "Mick", "Winfrey" },
                    { 207, "oprah.hepburn@gov.nl", "Oprah", "Hepburn" },
                    { 208, "kate.presley@google.com", "Kate", "Presley" },
                    { 209, "oprah.hepburn@gov.ru", "Oprah", "Hepburn" },
                    { 210, "charles.hepburn@gov.ru", "Charles", "Hepburn" },
                    { 211, "kate.winfrey@gov.us", "Kate", "Winfrey" },
                    { 212, "audrey.middleton@tesla.com", "Audrey", "Middleton" },
                    { 213, "audrey.middleton@nasa.org.us", "Audrey", "Middleton" },
                    { 214, "mick.winfrey@nasa.org.us", "Mick", "Winfrey" },
                    { 215, "kate.obama@gov.ru", "Kate", "Obama" },
                    { 216, "charles.jagger@nasa.org.us", "Charles", "Jagger" },
                    { 217, "elvis.jagger@gov.nl", "Elvis", "Jagger" },
                    { 218, "kate.obama@tesla.com", "Kate", "Obama" },
                    { 219, "charles.presley@bbc.co.uk", "Charles", "Presley" },
                    { 220, "charles.trump@bbc.co.uk", "Charles", "Trump" },
                    { 221, "elvis.presley@theworld.ca", "Elvis", "Presley" },
                    { 222, "audrey.middleton@gov.ru", "Audrey", "Middleton" },
                    { 223, "oprah.presley@nasa.org.us", "Oprah", "Presley" },
                    { 224, "mick.winfrey@gov.ru", "Mick", "Winfrey" },
                    { 225, "donald.trump@google.com", "Donald", "Trump" },
                    { 226, "jimi.middleton@bbc.co.uk", "Jimi", "Middleton" },
                    { 227, "barack.hendrix@gov.nl", "Barack", "Hendrix" },
                    { 228, "jimi.winslet@something.com", "Jimi", "Winslet" },
                    { 229, "elvis.trump@gov.gr", "Elvis", "Trump" },
                    { 230, "elvis.winfrey@gov.us", "Elvis", "Winfrey" },
                    { 231, "jimi.jagger@gov.ru", "Jimi", "Jagger" },
                    { 232, "elvis.windsor@gov.gr", "Elvis", "Windsor" },
                    { 233, "jimi.windsor@gov.ru", "Jimi", "Windsor" },
                    { 234, "barack.winfrey@something.com", "Barack", "Winfrey" },
                    { 235, "jimi.trump@gov.nl", "Jimi", "Trump" },
                    { 236, "audrey.obama@tesla.com", "Audrey", "Obama" },
                    { 237, "kate.winslet@something.com", "Kate", "Winslet" },
                    { 238, "audrey.winfrey@tesla.com", "Audrey", "Winfrey" },
                    { 239, "mick.winslet@something.com", "Mick", "Winslet" },
                    { 240, "barack.trump@bbc.co.uk", "Barack", "Trump" },
                    { 241, "elvis.windsor@gov.gr", "Elvis", "Windsor" },
                    { 242, "kate.winslet@gov.us", "Kate", "Winslet" },
                    { 243, "donald.presley@bbc.co.uk", "Donald", "Presley" },
                    { 244, "elvis.obama@theworld.ca", "Elvis", "Obama" },
                    { 245, "audrey.middleton@gov.us", "Audrey", "Middleton" },
                    { 246, "kate.jagger@tesla.com", "Kate", "Jagger" },
                    { 247, "donald.middleton@gov.nl", "Donald", "Middleton" },
                    { 248, "elvis.winslet@tesla.com", "Elvis", "Winslet" },
                    { 249, "donald.obama@gov.nl", "Donald", "Obama" }
                });

            migrationBuilder.InsertData(
                table: "books",
                columns: new[] { "id", "fk_author_id", "title" },
                values: new object[,]
                {
                    { 1, 22, "An army of Orange Houses" },
                    { 2, 225, "An army of Bitter Planets" },
                    { 3, 177, "The Bitter Buildings" },
                    { 4, 80, "The Bitter Buildings" },
                    { 5, 9, "The Large Planets" },
                    { 6, 40, "A herd of Large Planets" },
                    { 7, 14, "An army of Orange Planets" },
                    { 8, 226, "A bunch of Large Cars" },
                    { 9, 64, "Two Bitter Cars" },
                    { 10, 56, "The Purple Flowers" },
                    { 11, 13, "An army of Microscopic Houses" },
                    { 12, 26, "A bunch of Microscopic Leopards" },
                    { 13, 129, "Fifteen Green Planets" },
                    { 14, 18, "A herd of Bitter Planets" },
                    { 15, 157, "A herd of Orange Houses" },
                    { 16, 108, "The Orange Flowers" },
                    { 17, 48, "Two Green Planets" },
                    { 18, 160, "Several Bitter Buildings" },
                    { 19, 44, "An army of Green Houses" },
                    { 20, 119, "Fifteen Green Flowers" },
                    { 21, 93, "A herd of Rose Smelling Leopards" },
                    { 22, 143, "A bunch of Purple Buildings" },
                    { 23, 58, "The Large Houses" },
                    { 24, 158, "Several Rose Smelling Cars" },
                    { 25, 217, "A herd of Rose Smelling Cars" },
                    { 26, 217, "An army of Green Houses" },
                    { 27, 91, "A herd of Purple Cars" },
                    { 28, 31, "Fifteen Bitter Cars" },
                    { 29, 38, "Fifteen Transparent Flowers" },
                    { 30, 245, "The Transparent Houses" },
                    { 31, 90, "The Bitter Leopards" },
                    { 32, 153, "A herd of Large Leopards" },
                    { 33, 186, "A herd of Bitter Cars" },
                    { 34, 72, "A herd of Large Buildings" },
                    { 35, 15, "The Bitter Buildings" },
                    { 36, 41, "The Rose Smelling Buildings" },
                    { 37, 178, "Fifteen Large Flowers" },
                    { 38, 180, "A bunch of Large Leopards" },
                    { 39, 68, "A bunch of Rose Smelling Houses" },
                    { 40, 57, "An army of Purple Houses" },
                    { 41, 186, "A bunch of Orange Leopards" },
                    { 42, 93, "The Orange Leopards" },
                    { 43, 117, "A bunch of Rose Smelling Leopards" },
                    { 44, 148, "Two Purple Flowers" },
                    { 45, 20, "Fifteen Large Buildings" },
                    { 46, 185, "An army of Orange Houses" },
                    { 47, 26, "Fifteen Purple Buildings" },
                    { 48, 155, "A herd of Orange Leopards" },
                    { 49, 24, "A bunch of Large Buildings" },
                    { 50, 119, "A bunch of Rose Smelling Cars" },
                    { 51, 90, "Two Bitter Cars" },
                    { 52, 154, "The Rose Smelling Planets" },
                    { 53, 42, "An army of Orange Flowers" },
                    { 54, 203, "Two Green Planets" },
                    { 55, 40, "Fifteen Transparent Flowers" },
                    { 56, 26, "A bunch of Orange Flowers" },
                    { 57, 134, "A herd of Microscopic Buildings" },
                    { 58, 96, "The Transparent Planets" },
                    { 59, 28, "An army of Transparent Cars" },
                    { 60, 202, "Two Orange Leopards" },
                    { 61, 126, "Several Large Houses" },
                    { 62, 12, "The Green Cars" },
                    { 63, 91, "A herd of Large Flowers" },
                    { 64, 103, "A herd of Orange Houses" },
                    { 65, 58, "Two Rose Smelling Planets" },
                    { 66, 169, "A bunch of Large Leopards" },
                    { 67, 125, "Fifteen Purple Buildings" },
                    { 68, 244, "Two Orange Planets" },
                    { 69, 35, "The Microscopic Houses" },
                    { 70, 101, "Several Transparent Houses" },
                    { 71, 122, "A herd of Transparent Houses" },
                    { 72, 157, "Several Large Flowers" },
                    { 73, 237, "Fifteen Transparent Cars" },
                    { 74, 2, "Fifteen Rose Smelling Flowers" },
                    { 75, 213, "A herd of Green Buildings" },
                    { 76, 232, "A bunch of Bitter Cars" },
                    { 77, 81, "The Large Cars" },
                    { 78, 74, "Two Microscopic Flowers" },
                    { 79, 220, "An army of Microscopic Flowers" },
                    { 80, 120, "A bunch of Bitter Buildings" },
                    { 81, 76, "A herd of Green Buildings" },
                    { 82, 61, "An army of Large Leopards" },
                    { 83, 192, "Fifteen Rose Smelling Flowers" },
                    { 84, 227, "A bunch of Rose Smelling Flowers" },
                    { 85, 197, "A herd of Purple Flowers" },
                    { 86, 156, "Fifteen Bitter Houses" },
                    { 87, 85, "Two Microscopic Buildings" },
                    { 88, 247, "A bunch of Transparent Houses" },
                    { 89, 217, "A herd of Green Cars" },
                    { 90, 125, "A bunch of Rose Smelling Houses" },
                    { 91, 179, "The Purple Leopards" },
                    { 92, 6, "Several Green Leopards" },
                    { 93, 49, "A herd of Microscopic Houses" },
                    { 94, 18, "Several Large Leopards" },
                    { 95, 59, "Several Purple Buildings" },
                    { 96, 234, "A herd of Transparent Planets" },
                    { 97, 91, "Fifteen Large Cars" },
                    { 98, 90, "Several Bitter Leopards" },
                    { 99, 222, "Fifteen Orange Leopards" },
                    { 100, 213, "Fifteen Rose Smelling Cars" },
                    { 101, 226, "Two Rose Smelling Leopards" },
                    { 102, 218, "An army of Orange Leopards" },
                    { 103, 75, "A herd of Microscopic Buildings" },
                    { 104, 75, "A herd of Orange Planets" },
                    { 105, 141, "Several Large Houses" },
                    { 106, 141, "A bunch of Orange Planets" },
                    { 107, 51, "Two Rose Smelling Houses" },
                    { 108, 41, "Two Rose Smelling Houses" },
                    { 109, 180, "Two Large Cars" },
                    { 110, 199, "The Orange Houses" },
                    { 111, 240, "Two Transparent Leopards" },
                    { 112, 181, "The Bitter Houses" },
                    { 113, 138, "The Bitter Cars" },
                    { 114, 193, "Fifteen Large Buildings" },
                    { 115, 90, "A bunch of Transparent Cars" },
                    { 116, 126, "A bunch of Microscopic Leopards" },
                    { 117, 13, "An army of Large Cars" },
                    { 118, 108, "A bunch of Large Cars" },
                    { 119, 224, "Fifteen Orange Cars" },
                    { 120, 164, "A herd of Bitter Planets" },
                    { 121, 63, "An army of Bitter Flowers" },
                    { 122, 167, "The Rose Smelling Leopards" },
                    { 123, 121, "Fifteen Orange Planets" },
                    { 124, 116, "Several Large Buildings" },
                    { 125, 147, "A herd of Rose Smelling Leopards" },
                    { 126, 111, "An army of Transparent Leopards" },
                    { 127, 58, "An army of Large Cars" },
                    { 128, 235, "An army of Purple Houses" },
                    { 129, 137, "Fifteen Orange Flowers" },
                    { 130, 128, "The Transparent Buildings" },
                    { 131, 241, "A bunch of Transparent Planets" },
                    { 132, 186, "Several Rose Smelling Houses" },
                    { 133, 130, "A herd of Bitter Buildings" },
                    { 134, 145, "The Transparent Flowers" },
                    { 135, 212, "Two Purple Planets" },
                    { 136, 48, "Two Purple Planets" },
                    { 137, 189, "The Purple Flowers" },
                    { 138, 228, "The Green Houses" },
                    { 139, 62, "Several Rose Smelling Planets" },
                    { 140, 235, "A bunch of Purple Leopards" },
                    { 141, 172, "A herd of Purple Flowers" },
                    { 142, 60, "An army of Transparent Buildings" },
                    { 143, 42, "The Bitter Leopards" },
                    { 144, 38, "A bunch of Orange Flowers" },
                    { 145, 178, "Several Microscopic Flowers" },
                    { 146, 172, "A bunch of Rose Smelling Flowers" },
                    { 147, 244, "Several Green Leopards" },
                    { 148, 152, "The Microscopic Flowers" },
                    { 149, 24, "An army of Rose Smelling Flowers" },
                    { 150, 12, "Several Large Leopards" },
                    { 151, 217, "Two Microscopic Flowers" },
                    { 152, 147, "Fifteen Large Flowers" },
                    { 153, 28, "A herd of Purple Flowers" },
                    { 154, 166, "A herd of Microscopic Leopards" },
                    { 155, 130, "A herd of Bitter Planets" },
                    { 156, 49, "A herd of Bitter Houses" },
                    { 157, 163, "Fifteen Green Planets" },
                    { 158, 102, "An army of Rose Smelling Planets" },
                    { 159, 207, "Two Microscopic Buildings" },
                    { 160, 185, "Fifteen Green Planets" },
                    { 161, 92, "A herd of Bitter Leopards" },
                    { 162, 205, "Two Large Cars" },
                    { 163, 14, "An army of Green Planets" },
                    { 164, 223, "Two Rose Smelling Buildings" },
                    { 165, 143, "A bunch of Orange Planets" },
                    { 166, 39, "An army of Microscopic Leopards" },
                    { 167, 234, "Several Orange Planets" },
                    { 168, 128, "The Green Leopards" },
                    { 169, 96, "Two Purple Leopards" },
                    { 170, 210, "An army of Large Buildings" },
                    { 171, 125, "The Purple Cars" },
                    { 172, 142, "An army of Transparent Planets" },
                    { 173, 25, "Two Rose Smelling Cars" },
                    { 174, 71, "An army of Microscopic Buildings" },
                    { 175, 67, "A herd of Rose Smelling Buildings" },
                    { 176, 95, "Two Rose Smelling Flowers" },
                    { 177, 153, "An army of Orange Planets" },
                    { 178, 115, "Several Green Planets" },
                    { 179, 39, "The Purple Planets" },
                    { 180, 182, "Two Purple Flowers" },
                    { 181, 101, "An army of Green Flowers" },
                    { 182, 99, "Several Bitter Cars" },
                    { 183, 20, "The Orange Leopards" },
                    { 184, 138, "An army of Orange Planets" },
                    { 185, 138, "An army of Orange Buildings" },
                    { 186, 200, "Two Transparent Houses" },
                    { 187, 85, "Fifteen Transparent Planets" },
                    { 188, 80, "Several Transparent Flowers" },
                    { 189, 36, "The Bitter Cars" },
                    { 190, 194, "An army of Rose Smelling Buildings" },
                    { 191, 167, "Two Green Cars" },
                    { 192, 12, "A bunch of Purple Leopards" },
                    { 193, 11, "Two Purple Leopards" },
                    { 194, 1, "A herd of Purple Leopards" },
                    { 195, 179, "Several Green Leopards" },
                    { 196, 47, "Several Green Flowers" },
                    { 197, 239, "An army of Transparent Flowers" },
                    { 198, 187, "Several Purple Leopards" },
                    { 199, 72, "A herd of Large Buildings" },
                    { 200, 147, "Two Transparent Flowers" },
                    { 201, 46, "Two Large Buildings" },
                    { 202, 130, "An army of Bitter Houses" },
                    { 203, 136, "A herd of Rose Smelling Cars" },
                    { 204, 73, "Several Large Houses" },
                    { 205, 225, "Two Purple Cars" },
                    { 206, 174, "The Orange Houses" },
                    { 207, 22, "An army of Transparent Leopards" },
                    { 208, 172, "Fifteen Orange Cars" },
                    { 209, 189, "Two Purple Planets" },
                    { 210, 220, "A bunch of Bitter Houses" },
                    { 211, 222, "Several Orange Leopards" },
                    { 212, 180, "An army of Orange Leopards" },
                    { 213, 207, "Two Transparent Buildings" },
                    { 214, 186, "A herd of Green Leopards" },
                    { 215, 216, "Fifteen Transparent Planets" },
                    { 216, 109, "Fifteen Transparent Planets" },
                    { 217, 247, "An army of Green Flowers" },
                    { 218, 157, "Two Large Cars" },
                    { 219, 96, "The Orange Leopards" },
                    { 220, 13, "Fifteen Microscopic Flowers" },
                    { 221, 79, "Fifteen Purple Leopards" },
                    { 222, 135, "Several Transparent Buildings" },
                    { 223, 241, "Two Large Flowers" },
                    { 224, 75, "A bunch of Large Flowers" },
                    { 225, 248, "An army of Large Houses" },
                    { 226, 1, "A bunch of Purple Flowers" },
                    { 227, 70, "A bunch of Microscopic Planets" },
                    { 228, 61, "Two Transparent Planets" },
                    { 229, 207, "Two Orange Flowers" },
                    { 230, 227, "A bunch of Microscopic Houses" },
                    { 231, 172, "A bunch of Green Leopards" },
                    { 232, 234, "Several Bitter Buildings" },
                    { 233, 38, "The Rose Smelling Houses" },
                    { 234, 85, "A bunch of Rose Smelling Buildings" },
                    { 235, 109, "Two Large Flowers" },
                    { 236, 4, "Fifteen Bitter Buildings" },
                    { 237, 46, "An army of Microscopic Buildings" },
                    { 238, 144, "Two Bitter Cars" },
                    { 239, 87, "Two Rose Smelling Cars" },
                    { 240, 12, "Several Purple Houses" },
                    { 241, 209, "Several Bitter Buildings" },
                    { 242, 71, "A herd of Bitter Planets" },
                    { 243, 65, "The Bitter Flowers" },
                    { 244, 107, "A herd of Rose Smelling Cars" },
                    { 245, 20, "A herd of Orange Flowers" },
                    { 246, 100, "The Microscopic Houses" },
                    { 247, 36, "A bunch of Large Cars" },
                    { 248, 97, "Several Rose Smelling Leopards" },
                    { 249, 81, "Fifteen Transparent Leopards" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 198);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 204);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 206);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 208);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 211);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 214);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 215);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 219);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 221);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 229);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 230);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 231);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 233);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 236);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 238);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 242);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 243);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 246);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 249);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 198);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 199);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 203);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 204);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 205);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 206);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 207);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 208);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 209);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 210);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 211);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 212);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 213);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 214);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 215);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 216);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 217);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 218);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 219);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 220);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 221);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 222);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 223);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 224);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 225);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 226);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 227);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 228);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 229);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 230);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 231);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 232);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 233);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 234);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 235);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 236);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 237);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 238);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 239);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 240);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 241);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 242);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 243);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 244);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 245);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 246);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 247);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 248);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 249);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 199);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 203);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 205);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 207);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 209);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 210);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 212);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 213);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 216);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 217);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 218);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 220);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 222);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 223);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 224);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 225);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 226);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 227);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 228);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 232);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 234);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 235);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 237);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 239);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 240);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 241);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 244);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 245);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 247);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 248);
        }
    }
}
