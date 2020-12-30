using Microsoft.EntityFrameworkCore.Migrations;

namespace Library.Migrations
{
    public partial class AddingBooksAndAuthors : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Authors",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(maxLength: 50, nullable: false),
                    LastName = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: false),
                    AuthorId = table.Column<int>(nullable: false)
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
                columns: new[] { "Id", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, "James", "Bond" },
                    { 2, "Jackie", "Chan" },
                    { 3, "Sylvester", "Stallone" },
                    { 4, "Van", "Damme" },
                    { 5, "Jet", "Lee" }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Title" },
                values: new object[,]
                {
                    { 1, 1, "Spectre" },
                    { 29, 5, "Fist of legend" },
                    { 28, 5, "Fearless" },
                    { 27, 5, "Hero" },
                    { 26, 5, "Once upon a time in China" },
                    { 25, 5, "Cradle to the grave" },
                    { 24, 5, "Romeo Must Die" },
                    { 23, 5, "The Black Mask" },
                    { 22, 4, "Bullet in the head" },
                    { 21, 4, "Street Fighter" },
                    { 20, 4, "Hard Way" },
                    { 19, 4, "Universal Soldier" },
                    { 18, 4, "Double Impact" },
                    { 17, 4, "Hard Target" },
                    { 30, 5, "The one" },
                    { 16, 3, "Judgment Day" },
                    { 14, 3, "The expendables" },
                    { 13, 3, "First Blood" },
                    { 12, 3, "Rambo" },
                    { 11, 2, "Drunken Master" },
                    { 10, 2, "The karate kid" },
                    { 9, 2, "Who am I?" },
                    { 8, 2, "Police story" },
                    { 7, 2, "Rush Hour" },
                    { 6, 1, "Die another day" },
                    { 5, 1, "From russia with love" },
                    { 4, 1, "The spy who loved me" },
                    { 3, 1, "007" },
                    { 2, 1, "Casino Royal" },
                    { 15, 3, "Escape plan" },
                    { 31, 5, "Unleashed" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Books_AuthorId",
                table: "Books",
                column: "AuthorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "Authors");
        }
    }
}
