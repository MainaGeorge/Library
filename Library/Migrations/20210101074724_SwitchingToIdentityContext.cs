using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Library.Migrations
{
    public partial class SwitchingToIdentityContext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_Users_BorrowerId",
                table: "Books");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    Discriminator = table.Column<string>(nullable: false),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    DateOfBirth = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(nullable: false),
                    ProviderKey = table.Column<string>(nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "DateOfBirth", "FirstName", "LastName" },
                values: new object[,]
                {
                    { "4D69ED13-08F0-46DE-DE69-5FFE74A43A37", 0, "e07a4fd8-1ebb-4f13-988c-cec2a761097a", "ApplicationUser", null, false, false, null, null, null, null, null, false, "947f077d-8d60-4428-ba88-0b12ca2916e4", false, null, new DateTime(1960, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Debra", "Kristen" },
                    { "9B2B64D2-A663-906D-88BF-C783B7DFED12", 0, "8cfde59b-345d-4caf-849e-431f8103d6b4", "ApplicationUser", null, false, false, null, null, null, null, null, false, "ae6d024b-81fd-432a-a03e-84a34c602cd1", false, null, new DateTime(1969, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hayes", "Linus" },
                    { "7D70D508-C8A4-C522-C6D2-0175D3A963E1", 0, "8fbcc62c-c6a8-4ae6-8686-ad49fffaab71", "ApplicationUser", null, false, false, null, null, null, null, null, false, "62fa9f12-37dc-42cc-8570-02f3184a22ee", false, null, new DateTime(1978, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Imani", "Melyssa" },
                    { "D364495F-913B-4505-8809-4F709B3A66CF", 0, "b4ca0bfa-5176-4f55-a181-d64d563dee4c", "ApplicationUser", null, false, false, null, null, null, null, null, false, "274eac66-254d-4f26-97fa-491b2db1d3b8", false, null, new DateTime(2006, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Daphne", "Hiroko" },
                    { "2BE4CA58-BCB8-CF64-F121-E1BD464A80F2", 0, "31e99f1d-2e90-4133-b955-0f57025293ec", "ApplicationUser", null, false, false, null, null, null, null, null, false, "743d558a-d67d-47b9-bcfd-faea9de17e8d", false, null, new DateTime(2007, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Declan", "Maxwell" },
                    { "A4B20C1F-13BB-F831-EE9A-83C2F5034EC2", 0, "18a37947-690e-4c63-a3b6-905080b0d875", "ApplicationUser", null, false, false, null, null, null, null, null, false, "35fbd475-77f0-4883-81ae-1e769190ee8c", false, null, new DateTime(1984, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jonas", "Pascale" },
                    { "FC00EA26-D0AF-876B-C655-5FB95C1BFBBB", 0, "1bb0f940-b4d3-47a5-9250-df5b2b5698c9", "ApplicationUser", null, false, false, null, null, null, null, null, false, "29dcf7b6-ec69-4122-aa25-14b1d35d7103", false, null, new DateTime(2014, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Adena", "Gray" },
                    { "5035504A-00BC-450A-49B8-11F9309CE924", 0, "24ff3908-5a55-4d3d-83a6-b48f775444e4", "ApplicationUser", null, false, false, null, null, null, null, null, false, "5a08061b-adcd-457f-bdb0-532e7c6b7ac7", false, null, new DateTime(1959, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Daphne", "Plato" },
                    { "1144D05C-F75A-AE5C-B806-0EEE7CF38021", 0, "bfcb9994-cefd-44c7-9796-348f0ea478f7", "ApplicationUser", null, false, false, null, null, null, null, null, false, "a2b3a012-fb2a-4e0c-bb1e-cd5f0840c1ba", false, null, new DateTime(1965, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Donovan", "Lacy" },
                    { "B87C5391-D282-961A-AADD-10501EFCA2A8", 0, "48dd4592-7813-4ada-a2c1-86bfbd704707", "ApplicationUser", null, false, false, null, null, null, null, null, false, "8cbf2693-2137-4f4b-b690-80961e1027ea", false, null, new DateTime(2007, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Stephen", "Amethyst" },
                    { "3CC0CC6E-7CD2-BE49-813B-913A94C80FD9", 0, "fa961721-4bfb-4dc2-9452-802946b08f78", "ApplicationUser", null, false, false, null, null, null, null, null, false, "0e826f09-6f5d-4c3b-80f8-36d7817920ee", false, null, new DateTime(1994, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Alfreda", "Kim" },
                    { "0D3F221A-ED66-C81D-9C57-5DBE93551E26", 0, "ac39ddaf-5d03-4727-a9be-7c1bef6dee69", "ApplicationUser", null, false, false, null, null, null, null, null, false, "7a5195ce-5f44-4be8-8038-0d7dcad18f0f", false, null, new DateTime(1977, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Caldwell", "Kaitlin" },
                    { "AEE7B39C-0613-3443-BC1C-6911A94B7846", 0, "4cda554f-7841-491d-8936-a0483c87c255", "ApplicationUser", null, false, false, null, null, null, null, null, false, "955edc30-5403-4673-9634-df4c9ab87e35", false, null, new DateTime(1965, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Riley", "Yasir" },
                    { "C8AB11C9-7812-0753-64CF-46FA919744C0", 0, "e8485936-397d-4d27-ac56-187fac6d2e07", "ApplicationUser", null, false, false, null, null, null, null, null, false, "7b067892-4d51-426d-b257-9cdae2aaeb85", false, null, new DateTime(1972, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lana", "Holly" },
                    { "F89981C5-066C-CE27-7E6D-FBE7C845C60C", 0, "cb8d8e00-c261-4f1b-940e-0b094ae9aa21", "ApplicationUser", null, false, false, null, null, null, null, null, false, "73478e25-1a25-481d-8672-851a5ddfea09", false, null, new DateTime(2001, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Myra", "Lana" },
                    { "B0268B9E-510C-8DE9-2C11-31B8FC0AE1F2", 0, "adbf604e-8d7e-4cee-8d79-65fb72b62002", "ApplicationUser", null, false, false, null, null, null, null, null, false, "3de62cdd-8a29-4016-8b5f-90772393b18a", false, null, new DateTime(1970, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gwendolyn", "Reese" },
                    { "9CDFB677-9945-9AAB-B988-352A780D5F50", 0, "9dd9be8e-0930-45d2-9974-cf07fb08141b", "ApplicationUser", null, false, false, null, null, null, null, null, false, "507f3d5c-b406-4c9f-b6cd-087192ea3d92", false, null, new DateTime(2007, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Brittany", "Elmo" },
                    { "8A6C8FB7-461F-187B-0B96-E2EFBBF7A8EB", 0, "98a9d7dd-f0c6-4e54-9dbe-57b32b3caa66", "ApplicationUser", null, false, false, null, null, null, null, null, false, "029943c1-cbdb-4a61-abd4-7a6d6e058586", false, null, new DateTime(1962, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Armand", "Jack" },
                    { "D2D57256-EFC2-3259-D7BB-7A126DDC3CE2", 0, "ed438531-b7e2-48e8-be6b-e2139a2d646c", "ApplicationUser", null, false, false, null, null, null, null, null, false, "7eab755b-2da7-44a1-a3ad-210651647a4f", false, null, new DateTime(2007, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Penelope", "Philip" },
                    { "EC72E9E5-50EB-8460-4469-A916232838B5", 0, "04031f8b-6ee3-4d27-bd79-135e12fc0eb7", "ApplicationUser", null, false, false, null, null, null, null, null, false, "0789d673-7fe1-4d02-b0ed-17deae4f8d20", false, null, new DateTime(1964, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Patrick", "Caleb" },
                    { "EC5306BA-5307-1D1F-2AB6-72309C38CAF8", 0, "f07e5c9c-b845-4842-9f84-6ef227644921", "ApplicationUser", null, false, false, null, null, null, null, null, false, "76e0685e-9e1b-4bfe-8d7f-439c62c10e41", false, null, new DateTime(1997, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Florence", "Naida" },
                    { "333C9736-9F1B-90AB-1A26-C805AF166493", 0, "d77790f5-6df7-4f71-8366-e056b80e84b8", "ApplicationUser", null, false, false, null, null, null, null, null, false, "6c74613d-7ccc-4a4a-8319-69d880a22b61", false, null, new DateTime(1997, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Scarlet", "Cynthia" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Books_AspNetUsers_BorrowerId",
                table: "Books",
                column: "BorrowerId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_AspNetUsers_BorrowerId",
                table: "Books");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "4D69ED13-08F0-46DE-DE69-5FFE74A43A37", 0, "daf3a6b8-5b5f-4dd0-81f1-ad7810d0edc9", new DateTime(1960, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Debra", "Kristen", false, null, null, null, null, null, false, "5f5cc147-694d-427f-8739-b0d24f1bcff4", false, null },
                    { "9B2B64D2-A663-906D-88BF-C783B7DFED12", 0, "0c05b3d9-0bac-41e0-ba92-9f43536ca39d", new DateTime(1969, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Hayes", "Linus", false, null, null, null, null, null, false, "35a1307c-14df-4b48-bf24-99a1e5a09d95", false, null },
                    { "7D70D508-C8A4-C522-C6D2-0175D3A963E1", 0, "0fab432a-de29-40ac-9981-aa0e78e57140", new DateTime(1978, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Imani", "Melyssa", false, null, null, null, null, null, false, "a86999f5-8209-4a0b-8782-459c38981205", false, null },
                    { "D364495F-913B-4505-8809-4F709B3A66CF", 0, "d386f618-bcc2-44a2-ab38-c184e32752b8", new DateTime(2006, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Daphne", "Hiroko", false, null, null, null, null, null, false, "6d3567d7-a533-4c7a-a6ec-b22725472e75", false, null },
                    { "2BE4CA58-BCB8-CF64-F121-E1BD464A80F2", 0, "6508540b-7782-4e3e-b69c-7af5af724f81", new DateTime(2007, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Declan", "Maxwell", false, null, null, null, null, null, false, "0efeb9a7-2524-424e-87e5-d644c9664e35", false, null },
                    { "A4B20C1F-13BB-F831-EE9A-83C2F5034EC2", 0, "69cbbb93-9a00-4345-814b-4b680c2fa556", new DateTime(1984, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Jonas", "Pascale", false, null, null, null, null, null, false, "b36d0cc3-2902-48f3-947c-377a1eb54922", false, null },
                    { "FC00EA26-D0AF-876B-C655-5FB95C1BFBBB", 0, "76e95924-6aeb-42b7-b911-1733b60738ab", new DateTime(2014, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Adena", "Gray", false, null, null, null, null, null, false, "ed46bd1b-9435-4d96-af05-98ce4ffb790f", false, null },
                    { "5035504A-00BC-450A-49B8-11F9309CE924", 0, "132c72f5-12a1-4e5e-aa5a-44e30e4ce894", new DateTime(1959, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Daphne", "Plato", false, null, null, null, null, null, false, "1579d695-7ebb-4311-93ad-edfb454a5034", false, null },
                    { "1144D05C-F75A-AE5C-B806-0EEE7CF38021", 0, "f97476f8-fa21-4c8b-a602-35f5e2a96d33", new DateTime(1965, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Donovan", "Lacy", false, null, null, null, null, null, false, "487db28a-80c8-4b70-930f-0d2124bd10f1", false, null },
                    { "B87C5391-D282-961A-AADD-10501EFCA2A8", 0, "47d033f7-3829-49c0-99e0-28f6b154e656", new DateTime(2007, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Stephen", "Amethyst", false, null, null, null, null, null, false, "5ffc175b-f3ab-4022-a427-f135648267c8", false, null },
                    { "3CC0CC6E-7CD2-BE49-813B-913A94C80FD9", 0, "d54424fe-ed7c-4f3a-8e5a-7e1535dfd066", new DateTime(1994, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Alfreda", "Kim", false, null, null, null, null, null, false, "707fa098-393d-4869-a2bd-d6dc0362acac", false, null },
                    { "0D3F221A-ED66-C81D-9C57-5DBE93551E26", 0, "6a0a4935-b695-40f0-8f67-5a8df662aacc", new DateTime(1977, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Caldwell", "Kaitlin", false, null, null, null, null, null, false, "a34b0290-4d22-4422-90c0-872a828f0273", false, null },
                    { "AEE7B39C-0613-3443-BC1C-6911A94B7846", 0, "41aa2617-9de9-4031-9a86-637b930fae37", new DateTime(1965, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Riley", "Yasir", false, null, null, null, null, null, false, "e9dd4fe7-b997-4888-81a3-782edd991d5f", false, null },
                    { "C8AB11C9-7812-0753-64CF-46FA919744C0", 0, "62d621a8-0d49-4d8b-930c-9f7f689497e7", new DateTime(1972, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Lana", "Holly", false, null, null, null, null, null, false, "c0542800-4b23-49e4-86af-cade78c0301a", false, null },
                    { "F89981C5-066C-CE27-7E6D-FBE7C845C60C", 0, "9452d09e-8834-418c-9f51-571652874f9e", new DateTime(2001, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Myra", "Lana", false, null, null, null, null, null, false, "e5d52d41-44d8-4d23-8c18-9845922f111a", false, null },
                    { "B0268B9E-510C-8DE9-2C11-31B8FC0AE1F2", 0, "59682333-c9f2-4093-8fd4-0d8642865839", new DateTime(1970, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Gwendolyn", "Reese", false, null, null, null, null, null, false, "fda33e0e-aeec-4833-9b95-661b599b0cf1", false, null },
                    { "9CDFB677-9945-9AAB-B988-352A780D5F50", 0, "f71c807c-3587-4c95-a4d0-d427f535b19a", new DateTime(2007, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Brittany", "Elmo", false, null, null, null, null, null, false, "941ee3e9-4785-4c99-a122-911e7938d8ee", false, null },
                    { "8A6C8FB7-461F-187B-0B96-E2EFBBF7A8EB", 0, "037cb4cc-8d32-46ad-b648-ab7dff954c8c", new DateTime(1962, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Armand", "Jack", false, null, null, null, null, null, false, "64c51e76-b7f0-45c3-93bd-c5e4f0400c34", false, null },
                    { "D2D57256-EFC2-3259-D7BB-7A126DDC3CE2", 0, "457c71d2-7fb6-4ca7-badd-ca67a2c80cf5", new DateTime(2007, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Penelope", "Philip", false, null, null, null, null, null, false, "79abfea4-d812-4118-90da-f144c1580a4e", false, null },
                    { "EC72E9E5-50EB-8460-4469-A916232838B5", 0, "6d0df368-fe74-4521-bfe4-3607b67435e2", new DateTime(1964, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Patrick", "Caleb", false, null, null, null, null, null, false, "73143b9c-c183-4fc8-b2fe-d0b44980b059", false, null },
                    { "EC5306BA-5307-1D1F-2AB6-72309C38CAF8", 0, "174ba4b5-f822-43df-9fd2-3c136388c31f", new DateTime(1997, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Florence", "Naida", false, null, null, null, null, null, false, "d93ebe3f-ed55-4117-a2c0-40ea1ee9b9bf", false, null },
                    { "333C9736-9F1B-90AB-1A26-C805AF166493", 0, "b006f36c-3a3f-4c49-8c81-c5b9ce98c2d9", new DateTime(1997, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Scarlet", "Cynthia", false, null, null, null, null, null, false, "9569e175-fb70-417b-af8f-d8977f8011d1", false, null }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Users_BorrowerId",
                table: "Books",
                column: "BorrowerId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
