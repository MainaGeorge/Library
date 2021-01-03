using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Library.Migrations
{
    public partial class MakingDateOfBirthDateTime : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0D3F221A-ED66-C81D-9C57-5DBE93551E26");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1144D05C-F75A-AE5C-B806-0EEE7CF38021");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2BE4CA58-BCB8-CF64-F121-E1BD464A80F2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "333C9736-9F1B-90AB-1A26-C805AF166493");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3CC0CC6E-7CD2-BE49-813B-913A94C80FD9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4D69ED13-08F0-46DE-DE69-5FFE74A43A37");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5035504A-00BC-450A-49B8-11F9309CE924");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7D70D508-C8A4-C522-C6D2-0175D3A963E1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8A6C8FB7-461F-187B-0B96-E2EFBBF7A8EB");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9B2B64D2-A663-906D-88BF-C783B7DFED12");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9CDFB677-9945-9AAB-B988-352A780D5F50");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "A4B20C1F-13BB-F831-EE9A-83C2F5034EC2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "AEE7B39C-0613-3443-BC1C-6911A94B7846");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "B0268B9E-510C-8DE9-2C11-31B8FC0AE1F2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "B87C5391-D282-961A-AADD-10501EFCA2A8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "C8AB11C9-7812-0753-64CF-46FA919744C0");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "D2D57256-EFC2-3259-D7BB-7A126DDC3CE2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "D364495F-913B-4505-8809-4F709B3A66CF");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "EC5306BA-5307-1D1F-2AB6-72309C38CAF8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "EC72E9E5-50EB-8460-4469-A916232838B5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "F89981C5-066C-CE27-7E6D-FBE7C845C60C");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "FC00EA26-D0AF-876B-C655-5FB95C1BFBBB");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "DateOfBirth", "FirstName", "LastName" },
                values: new object[,]
                {
                    { "4D69ED13-08F0-46DE-DE69-5FFE74A43A37", 0, "b67a37bc-f81f-4bf9-b0a8-0c7dddd0e60a", "ApplicationUser", null, false, false, null, null, null, null, null, false, "c29c0f46-9ebf-4e65-be40-4a3b606de966", false, null, new DateTime(1960, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Debra", "Kristen" },
                    { "9B2B64D2-A663-906D-88BF-C783B7DFED12", 0, "57fda1ad-faa0-4abb-b968-61d6706be347", "ApplicationUser", null, false, false, null, null, null, null, null, false, "c77dd4ed-fd8c-41e9-96d6-a9557d30f54a", false, null, new DateTime(1969, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hayes", "Linus" },
                    { "7D70D508-C8A4-C522-C6D2-0175D3A963E1", 0, "5c0ac6b7-adac-4a30-8e05-b0c897b1ff8a", "ApplicationUser", null, false, false, null, null, null, null, null, false, "cc399271-5b5a-41cd-bf84-a82f556e760f", false, null, new DateTime(1978, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Imani", "Melyssa" },
                    { "D364495F-913B-4505-8809-4F709B3A66CF", 0, "dfde22ff-8a5a-47c5-9a7c-b1d7a70f6005", "ApplicationUser", null, false, false, null, null, null, null, null, false, "30f78502-af03-44b9-8893-2e4c43d71968", false, null, new DateTime(2006, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Daphne", "Hiroko" },
                    { "2BE4CA58-BCB8-CF64-F121-E1BD464A80F2", 0, "17e8c0c6-775f-4c1a-80ba-ab2c5166e026", "ApplicationUser", null, false, false, null, null, null, null, null, false, "6616d025-675c-409f-afe7-50aab6142730", false, null, new DateTime(2007, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Declan", "Maxwell" },
                    { "A4B20C1F-13BB-F831-EE9A-83C2F5034EC2", 0, "1e55648c-d941-4427-b30d-6ed29b33adb0", "ApplicationUser", null, false, false, null, null, null, null, null, false, "f171d489-3af2-4329-b2e9-4ca0ccad0687", false, null, new DateTime(1984, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jonas", "Pascale" },
                    { "FC00EA26-D0AF-876B-C655-5FB95C1BFBBB", 0, "d5458ea2-94cb-4ae8-bc55-8f969206f304", "ApplicationUser", null, false, false, null, null, null, null, null, false, "1efe5bfe-96b3-4426-8d15-04f6502e2d4d", false, null, new DateTime(2014, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Adena", "Gray" },
                    { "5035504A-00BC-450A-49B8-11F9309CE924", 0, "6243b8b0-88dc-494f-8298-f8be259f1523", "ApplicationUser", null, false, false, null, null, null, null, null, false, "1d5f594c-d4b5-4d13-9766-953e77a28cc9", false, null, new DateTime(1959, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Daphne", "Plato" },
                    { "1144D05C-F75A-AE5C-B806-0EEE7CF38021", 0, "bbcd032e-1a8a-41cb-8f8e-9947d7aa68f1", "ApplicationUser", null, false, false, null, null, null, null, null, false, "ab69e0cc-fe54-4949-8733-de2ee9de4bd5", false, null, new DateTime(1965, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Donovan", "Lacy" },
                    { "B87C5391-D282-961A-AADD-10501EFCA2A8", 0, "08fde93c-a03e-491a-8820-df3e8980b745", "ApplicationUser", null, false, false, null, null, null, null, null, false, "e6171942-77c7-4260-8843-045d19b47226", false, null, new DateTime(2007, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Stephen", "Amethyst" },
                    { "3CC0CC6E-7CD2-BE49-813B-913A94C80FD9", 0, "5b76678e-2c9a-4c14-82c7-e8b6e8661830", "ApplicationUser", null, false, false, null, null, null, null, null, false, "738ebabe-611e-41f9-989f-3c43440f5b24", false, null, new DateTime(1994, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Alfreda", "Kim" },
                    { "0D3F221A-ED66-C81D-9C57-5DBE93551E26", 0, "5463c8bd-6e64-4096-b116-58bbb38e9ab6", "ApplicationUser", null, false, false, null, null, null, null, null, false, "bed2db01-4163-48f0-890f-5c473228fe16", false, null, new DateTime(1977, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Caldwell", "Kaitlin" },
                    { "AEE7B39C-0613-3443-BC1C-6911A94B7846", 0, "181bf726-4069-4ea2-a183-9c494235b0aa", "ApplicationUser", null, false, false, null, null, null, null, null, false, "4332a89c-976b-40e7-a661-070d62f1ebc0", false, null, new DateTime(1965, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Riley", "Yasir" },
                    { "C8AB11C9-7812-0753-64CF-46FA919744C0", 0, "937f49fc-b928-41f1-bb20-50c740b6a7c1", "ApplicationUser", null, false, false, null, null, null, null, null, false, "bd4f07b2-96a2-4210-a52e-3dc1da61f6a3", false, null, new DateTime(1972, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lana", "Holly" },
                    { "F89981C5-066C-CE27-7E6D-FBE7C845C60C", 0, "5713cee1-8d10-4bea-96f5-a06dfc3e6f2f", "ApplicationUser", null, false, false, null, null, null, null, null, false, "dbc14014-240f-4559-b19d-b1827c9487c3", false, null, new DateTime(2001, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Myra", "Lana" },
                    { "B0268B9E-510C-8DE9-2C11-31B8FC0AE1F2", 0, "1213b362-5fe2-431d-a0e3-6beecdfa6226", "ApplicationUser", null, false, false, null, null, null, null, null, false, "90b7a8ea-5e6a-4abd-b798-3f42e2d7dbf8", false, null, new DateTime(1970, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gwendolyn", "Reese" },
                    { "9CDFB677-9945-9AAB-B988-352A780D5F50", 0, "f562ea81-8afd-4903-99e3-f15928449c08", "ApplicationUser", null, false, false, null, null, null, null, null, false, "f3a27e8f-e8e5-4618-b363-29823d328344", false, null, new DateTime(2007, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Brittany", "Elmo" },
                    { "8A6C8FB7-461F-187B-0B96-E2EFBBF7A8EB", 0, "df9193ed-ed3e-4a3d-8efd-b44c66db3e29", "ApplicationUser", null, false, false, null, null, null, null, null, false, "0e075f62-7141-4443-b2c0-1c0ca5d2e62f", false, null, new DateTime(1962, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Armand", "Jack" },
                    { "D2D57256-EFC2-3259-D7BB-7A126DDC3CE2", 0, "7cb95272-34ad-42f8-b737-da61be69bd29", "ApplicationUser", null, false, false, null, null, null, null, null, false, "15187a4d-641d-44a9-ad6e-815d2238a06e", false, null, new DateTime(2007, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Penelope", "Philip" },
                    { "EC72E9E5-50EB-8460-4469-A916232838B5", 0, "c94dce3b-f39a-4ead-82a6-3bf4f8252419", "ApplicationUser", null, false, false, null, null, null, null, null, false, "cf8aa5a4-aaaf-409a-99c0-481797a2bf54", false, null, new DateTime(1964, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Patrick", "Caleb" },
                    { "EC5306BA-5307-1D1F-2AB6-72309C38CAF8", 0, "af180fa3-0ca8-4da9-a65c-bda5d1c2ff9f", "ApplicationUser", null, false, false, null, null, null, null, null, false, "7ff53b41-a80b-4c09-bdb0-56498aa5ee23", false, null, new DateTime(1997, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Florence", "Naida" },
                    { "333C9736-9F1B-90AB-1A26-C805AF166493", 0, "bdb6ba72-04c9-4a92-9893-a5ef34f52c4c", "ApplicationUser", null, false, false, null, null, null, null, null, false, "a389f113-d995-443f-9fd1-f447b6a2d728", false, null, new DateTime(1997, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Scarlet", "Cynthia" }
                });
        }
    }
}
