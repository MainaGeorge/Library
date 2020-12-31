using Microsoft.EntityFrameworkCore.Migrations;

namespace Library.Migrations
{
    public partial class ChangingBook : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "BorrowerId",
                table: "Books",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsAvailable",
                table: "Books",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                column: "IsAvailable",
                value: true);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                column: "IsAvailable",
                value: true);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                column: "IsAvailable",
                value: true);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                column: "IsAvailable",
                value: true);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5,
                column: "IsAvailable",
                value: true);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6,
                column: "IsAvailable",
                value: true);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7,
                column: "IsAvailable",
                value: true);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 8,
                column: "IsAvailable",
                value: true);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 9,
                column: "IsAvailable",
                value: true);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 10,
                column: "IsAvailable",
                value: true);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 11,
                column: "IsAvailable",
                value: true);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 12,
                column: "IsAvailable",
                value: true);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 13,
                column: "IsAvailable",
                value: true);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 14,
                column: "IsAvailable",
                value: true);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 15,
                column: "IsAvailable",
                value: true);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 16,
                column: "IsAvailable",
                value: true);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 17,
                column: "IsAvailable",
                value: true);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 18,
                column: "IsAvailable",
                value: true);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 19,
                column: "IsAvailable",
                value: true);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 20,
                column: "IsAvailable",
                value: true);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 21,
                column: "IsAvailable",
                value: true);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 22,
                column: "IsAvailable",
                value: true);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 23,
                column: "IsAvailable",
                value: true);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 24,
                column: "IsAvailable",
                value: true);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 25,
                column: "IsAvailable",
                value: true);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 26,
                column: "IsAvailable",
                value: true);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 27,
                column: "IsAvailable",
                value: true);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 28,
                column: "IsAvailable",
                value: true);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 29,
                column: "IsAvailable",
                value: true);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 30,
                column: "IsAvailable",
                value: true);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 31,
                column: "IsAvailable",
                value: true);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "0D3F221A-ED66-C81D-9C57-5DBE93551E26",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e464d603-6f6f-4203-a069-69ddeb827f79", "6f0ca5c6-ad06-4045-adbf-29983d0750ab" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "1144D05C-F75A-AE5C-B806-0EEE7CF38021",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "7889d4c6-b2e5-4b2f-8c26-6b1f61a9d1f2", "7e08c141-2e92-4bf4-bc02-05708f4ad4bd" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "2BE4CA58-BCB8-CF64-F121-E1BD464A80F2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "04872dd3-ba86-4fb8-85f6-9d07cdde2d27", "239ac1f1-e29a-42af-a005-8dd061f888ae" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "333C9736-9F1B-90AB-1A26-C805AF166493",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "7183fa3d-1ec1-400d-8d65-4fce7b7cfdf1", "59c05c30-f250-4fdd-9c62-39faf05c8cca" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "3CC0CC6E-7CD2-BE49-813B-913A94C80FD9",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "bd6b38f7-ce11-4964-90fc-0f2037a79541", "cfc70297-6c69-4392-be80-a220c02d0921" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "4D69ED13-08F0-46DE-DE69-5FFE74A43A37",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "38a17945-7b40-4a70-9f74-50948f438a4d", "82883759-34fb-49f9-b48e-d6d16a24193b" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "5035504A-00BC-450A-49B8-11F9309CE924",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "33556173-87f3-4fe1-98b1-cb869c83f805", "3325cc97-1fc8-4ca3-ac20-aac6342249fd" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "7D70D508-C8A4-C522-C6D2-0175D3A963E1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "92e605f6-db0a-4764-8564-7a9ceaaae4f7", "2c2b8823-dbfe-4994-b411-e9db810f5453" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "8A6C8FB7-461F-187B-0B96-E2EFBBF7A8EB",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "67d2344e-da5a-4c57-9cd4-adc137f6da76", "fb9bda64-41a5-4cfd-aa9f-d0fced27c2df" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "9B2B64D2-A663-906D-88BF-C783B7DFED12",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "a5813355-2c5f-445c-acaa-ffec97c08fb9", "995ce533-a550-4527-9e33-b16c39dbae4a" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "9CDFB677-9945-9AAB-B988-352A780D5F50",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "8a88fda6-c4b0-404c-836a-c15e56c070b2", "240d1db7-c7b7-4c99-96cb-da286cf26a64" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "A4B20C1F-13BB-F831-EE9A-83C2F5034EC2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "129954d1-e2c1-41cf-9b00-d0de5675edc8", "a47b9666-9170-4ce9-9c53-a344a41cfb87" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "AEE7B39C-0613-3443-BC1C-6911A94B7846",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "bdb5ba6b-7dff-4adf-8a59-7361d3c28fcb", "7d1b811b-7ae2-40ff-9176-d7b1056cef92" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "B0268B9E-510C-8DE9-2C11-31B8FC0AE1F2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "998a685c-b50d-4a72-9e50-e0cc096d8111", "2094d742-d636-43fd-804c-33f773676b01" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "B87C5391-D282-961A-AADD-10501EFCA2A8",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "3df10cbe-65bd-4f02-8802-3489e523a1ef", "7c03dd6b-5f9e-491a-8149-79f86c62671b" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "C8AB11C9-7812-0753-64CF-46FA919744C0",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "0d9f8bd2-001d-49b5-a47f-405e181bdd14", "560ffd12-bb18-49d7-9376-333ca4c70c61" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "D2D57256-EFC2-3259-D7BB-7A126DDC3CE2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "42913f6f-aa2d-4fb3-8af6-16606fbf57d7", "ca969b45-1740-457a-93cc-6f4a9c5fc4dc" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "D364495F-913B-4505-8809-4F709B3A66CF",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d76b036d-597d-42a7-b023-c8664c6df124", "d33c1217-1099-470e-97dd-a575a4afb4c6" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "EC5306BA-5307-1D1F-2AB6-72309C38CAF8",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "63c57dce-2575-42ce-b429-e3d0863dec67", "3ef19bd2-7f40-4ff9-aa44-4d0c43d9becd" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "EC72E9E5-50EB-8460-4469-A916232838B5",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "b8c3ed98-19d7-461b-972c-a5dc6027e0a1", "d58e316a-24cb-4e4a-a941-1487b5c44696" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "F89981C5-066C-CE27-7E6D-FBE7C845C60C",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "94c77761-c838-48d9-8833-8ce28977cc9f", "a8803687-acbb-4c2a-ae00-49be37339c51" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "FC00EA26-D0AF-876B-C655-5FB95C1BFBBB",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d29ef4db-70cb-4edb-9864-43d4199f13e1", "11b4fdef-7d2a-4c02-bb8e-ff7be1516863" });

            migrationBuilder.CreateIndex(
                name: "IX_Books_BorrowerId",
                table: "Books",
                column: "BorrowerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Users_BorrowerId",
                table: "Books",
                column: "BorrowerId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_Users_BorrowerId",
                table: "Books");

            migrationBuilder.DropIndex(
                name: "IX_Books_BorrowerId",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "BorrowerId",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "IsAvailable",
                table: "Books");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "0D3F221A-ED66-C81D-9C57-5DBE93551E26",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "42e29b86-e642-4b34-b666-b724866a23ec", "d586aeaf-5322-441e-9df8-269c31ff0020" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "1144D05C-F75A-AE5C-B806-0EEE7CF38021",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "8bbd6ad0-5b3c-4f7d-ba9f-3647977a1951", "c36fc737-c028-44ba-b67f-ef551fa196be" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "2BE4CA58-BCB8-CF64-F121-E1BD464A80F2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "b2ec34de-4b9b-46d6-a351-877705eb1576", "cb174b1f-76a1-4032-bbb0-d783fa8329bc" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "333C9736-9F1B-90AB-1A26-C805AF166493",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "7e7e6d74-c53b-4b55-825d-aa0f6968b50b", "1df21719-86ec-45be-8fb1-69d058c4fe88" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "3CC0CC6E-7CD2-BE49-813B-913A94C80FD9",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "3ccf7eb4-431b-4b7f-9e9a-b2157489e311", "ecfce5a0-a3c4-4886-8624-1fed61690e72" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "4D69ED13-08F0-46DE-DE69-5FFE74A43A37",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "cc1f2bd1-413a-4480-96ff-4f8dab8ee653", "4a01b7e9-df4d-4f31-9373-0f065869cc41" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "5035504A-00BC-450A-49B8-11F9309CE924",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "3f1ea825-9f77-479e-a757-fb9926413710", "3dc7fbae-f17d-4b32-bb17-13c76530de78" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "7D70D508-C8A4-C522-C6D2-0175D3A963E1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ea08fb53-8349-446a-88fa-9ea5424b58bc", "2054797f-b2a0-43d5-a4fe-c0ab18677b02" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "8A6C8FB7-461F-187B-0B96-E2EFBBF7A8EB",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "4ac1ff60-3d04-449c-a445-57a7a4174b1f", "7dd3bed1-d2bf-4d66-8aa8-011343bbd5cb" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "9B2B64D2-A663-906D-88BF-C783B7DFED12",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "22e19453-4f1f-47b1-8773-0ad1d46a57d4", "43bfdc17-4f27-4b04-bc75-125f9f1c1312" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "9CDFB677-9945-9AAB-B988-352A780D5F50",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "8cad547a-1c14-4dd5-9b14-7a7b4a4ff166", "33967473-2c89-4c82-84bd-8a3d8d06b3f4" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "A4B20C1F-13BB-F831-EE9A-83C2F5034EC2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "84e2f85e-8c8a-4a67-bbae-11e9c2027057", "e468085a-5597-4321-b3e5-84e54ba0ae5a" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "AEE7B39C-0613-3443-BC1C-6911A94B7846",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "5e25e3a1-96a0-4962-8174-53181cac5719", "db267738-404d-4b77-a314-ec7457eedc06" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "B0268B9E-510C-8DE9-2C11-31B8FC0AE1F2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "49a135dc-066b-42c2-af59-3c09aea8d99c", "353806c4-0922-48a2-88db-4e64bafae8c6" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "B87C5391-D282-961A-AADD-10501EFCA2A8",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e707f0e3-7b16-483f-b4a6-b05db31d9232", "8a1beadd-f544-43c8-8e64-3bbf3bdda32b" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "C8AB11C9-7812-0753-64CF-46FA919744C0",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "183e3d97-1a99-4db2-8ddb-cd0304bf65f3", "0955c0fb-126e-483a-9178-28fe6e9216b6" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "D2D57256-EFC2-3259-D7BB-7A126DDC3CE2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "facf94c6-3d5b-4642-9794-d7659429a0e5", "833d7801-3eb9-45d6-b32b-5a190e66876b" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "D364495F-913B-4505-8809-4F709B3A66CF",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "3d0320c8-0876-4f22-8ef1-1d0aa881d9c3", "167de7ab-63d9-4096-916a-1052d72c03e6" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "EC5306BA-5307-1D1F-2AB6-72309C38CAF8",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "56144cee-3c5f-4689-a437-27a1b40874e5", "013fcf0a-0eb0-4e7d-ae74-db3aa6a6cdec" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "EC72E9E5-50EB-8460-4469-A916232838B5",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e14e410b-2c0b-4110-bf0e-25d6f131483f", "6b55f141-e32a-4fb2-b1f9-b5d86047f6c2" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "F89981C5-066C-CE27-7E6D-FBE7C845C60C",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "a6a5d87e-43a1-404a-80a5-e6f7e48d72e1", "7834a639-1ac1-4c22-a3a3-f3e013176172" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "FC00EA26-D0AF-876B-C655-5FB95C1BFBBB",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "3c77e58f-5d4a-4be0-a459-2b69316fbc19", "82c85bd7-49c2-4a8e-aff5-1d34d8033d0c" });
        }
    }
}
