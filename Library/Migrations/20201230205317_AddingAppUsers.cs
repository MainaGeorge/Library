using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Library.Migrations
{
    public partial class AddingAppUsers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(nullable: true),
                    NormalizedUserName = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    NormalizedEmail = table.Column<string>(nullable: true),
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
                    FirstName = table.Column<string>(nullable: false),
                    LastName = table.Column<string>(nullable: false),
                    DateOfBirth = table.Column<DateTime>(nullable: false)
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
                    { "4D69ED13-08F0-46DE-DE69-5FFE74A43A37", 0, "cc1f2bd1-413a-4480-96ff-4f8dab8ee653", new DateTime(1960, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Debra", "Kristen", false, null, null, null, null, null, false, "4a01b7e9-df4d-4f31-9373-0f065869cc41", false, null },
                    { "9B2B64D2-A663-906D-88BF-C783B7DFED12", 0, "22e19453-4f1f-47b1-8773-0ad1d46a57d4", new DateTime(1969, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Hayes", "Linus", false, null, null, null, null, null, false, "43bfdc17-4f27-4b04-bc75-125f9f1c1312", false, null },
                    { "7D70D508-C8A4-C522-C6D2-0175D3A963E1", 0, "ea08fb53-8349-446a-88fa-9ea5424b58bc", new DateTime(1978, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Imani", "Melyssa", false, null, null, null, null, null, false, "2054797f-b2a0-43d5-a4fe-c0ab18677b02", false, null },
                    { "D364495F-913B-4505-8809-4F709B3A66CF", 0, "3d0320c8-0876-4f22-8ef1-1d0aa881d9c3", new DateTime(2006, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Daphne", "Hiroko", false, null, null, null, null, null, false, "167de7ab-63d9-4096-916a-1052d72c03e6", false, null },
                    { "2BE4CA58-BCB8-CF64-F121-E1BD464A80F2", 0, "b2ec34de-4b9b-46d6-a351-877705eb1576", new DateTime(2007, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Declan", "Maxwell", false, null, null, null, null, null, false, "cb174b1f-76a1-4032-bbb0-d783fa8329bc", false, null },
                    { "A4B20C1F-13BB-F831-EE9A-83C2F5034EC2", 0, "84e2f85e-8c8a-4a67-bbae-11e9c2027057", new DateTime(1984, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Jonas", "Pascale", false, null, null, null, null, null, false, "e468085a-5597-4321-b3e5-84e54ba0ae5a", false, null },
                    { "FC00EA26-D0AF-876B-C655-5FB95C1BFBBB", 0, "3c77e58f-5d4a-4be0-a459-2b69316fbc19", new DateTime(2014, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Adena", "Gray", false, null, null, null, null, null, false, "82c85bd7-49c2-4a8e-aff5-1d34d8033d0c", false, null },
                    { "5035504A-00BC-450A-49B8-11F9309CE924", 0, "3f1ea825-9f77-479e-a757-fb9926413710", new DateTime(1959, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Daphne", "Plato", false, null, null, null, null, null, false, "3dc7fbae-f17d-4b32-bb17-13c76530de78", false, null },
                    { "1144D05C-F75A-AE5C-B806-0EEE7CF38021", 0, "8bbd6ad0-5b3c-4f7d-ba9f-3647977a1951", new DateTime(1965, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Donovan", "Lacy", false, null, null, null, null, null, false, "c36fc737-c028-44ba-b67f-ef551fa196be", false, null },
                    { "B87C5391-D282-961A-AADD-10501EFCA2A8", 0, "e707f0e3-7b16-483f-b4a6-b05db31d9232", new DateTime(2007, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Stephen", "Amethyst", false, null, null, null, null, null, false, "8a1beadd-f544-43c8-8e64-3bbf3bdda32b", false, null },
                    { "3CC0CC6E-7CD2-BE49-813B-913A94C80FD9", 0, "3ccf7eb4-431b-4b7f-9e9a-b2157489e311", new DateTime(1994, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Alfreda", "Kim", false, null, null, null, null, null, false, "ecfce5a0-a3c4-4886-8624-1fed61690e72", false, null },
                    { "0D3F221A-ED66-C81D-9C57-5DBE93551E26", 0, "42e29b86-e642-4b34-b666-b724866a23ec", new DateTime(1977, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Caldwell", "Kaitlin", false, null, null, null, null, null, false, "d586aeaf-5322-441e-9df8-269c31ff0020", false, null },
                    { "AEE7B39C-0613-3443-BC1C-6911A94B7846", 0, "5e25e3a1-96a0-4962-8174-53181cac5719", new DateTime(1965, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Riley", "Yasir", false, null, null, null, null, null, false, "db267738-404d-4b77-a314-ec7457eedc06", false, null },
                    { "C8AB11C9-7812-0753-64CF-46FA919744C0", 0, "183e3d97-1a99-4db2-8ddb-cd0304bf65f3", new DateTime(1972, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Lana", "Holly", false, null, null, null, null, null, false, "0955c0fb-126e-483a-9178-28fe6e9216b6", false, null },
                    { "F89981C5-066C-CE27-7E6D-FBE7C845C60C", 0, "a6a5d87e-43a1-404a-80a5-e6f7e48d72e1", new DateTime(2001, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Myra", "Lana", false, null, null, null, null, null, false, "7834a639-1ac1-4c22-a3a3-f3e013176172", false, null },
                    { "B0268B9E-510C-8DE9-2C11-31B8FC0AE1F2", 0, "49a135dc-066b-42c2-af59-3c09aea8d99c", new DateTime(1970, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Gwendolyn", "Reese", false, null, null, null, null, null, false, "353806c4-0922-48a2-88db-4e64bafae8c6", false, null },
                    { "9CDFB677-9945-9AAB-B988-352A780D5F50", 0, "8cad547a-1c14-4dd5-9b14-7a7b4a4ff166", new DateTime(2007, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Brittany", "Elmo", false, null, null, null, null, null, false, "33967473-2c89-4c82-84bd-8a3d8d06b3f4", false, null },
                    { "8A6C8FB7-461F-187B-0B96-E2EFBBF7A8EB", 0, "4ac1ff60-3d04-449c-a445-57a7a4174b1f", new DateTime(1962, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Armand", "Jack", false, null, null, null, null, null, false, "7dd3bed1-d2bf-4d66-8aa8-011343bbd5cb", false, null },
                    { "D2D57256-EFC2-3259-D7BB-7A126DDC3CE2", 0, "facf94c6-3d5b-4642-9794-d7659429a0e5", new DateTime(2007, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Penelope", "Philip", false, null, null, null, null, null, false, "833d7801-3eb9-45d6-b32b-5a190e66876b", false, null },
                    { "EC72E9E5-50EB-8460-4469-A916232838B5", 0, "e14e410b-2c0b-4110-bf0e-25d6f131483f", new DateTime(1964, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Patrick", "Caleb", false, null, null, null, null, null, false, "6b55f141-e32a-4fb2-b1f9-b5d86047f6c2", false, null },
                    { "EC5306BA-5307-1D1F-2AB6-72309C38CAF8", 0, "56144cee-3c5f-4689-a437-27a1b40874e5", new DateTime(1997, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Florence", "Naida", false, null, null, null, null, null, false, "013fcf0a-0eb0-4e7d-ae74-db3aa6a6cdec", false, null },
                    { "333C9736-9F1B-90AB-1A26-C805AF166493", 0, "7e7e6d74-c53b-4b55-825d-aa0f6968b50b", new DateTime(1997, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Scarlet", "Cynthia", false, null, null, null, null, null, false, "1df21719-86ec-45be-8fb1-69d058c4fe88", false, null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
