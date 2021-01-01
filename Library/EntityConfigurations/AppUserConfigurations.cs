using Library.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace Library.EntityConfigurations
{
    public class AppUserConfigurations : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            builder.HasData(Users);


        }

        private IEnumerable<ApplicationUser> Users => new List<ApplicationUser>()
        {
            new ApplicationUser()
            {
                FirstName = "Debra",
                Id = "4D69ED13-08F0-46DE-DE69-5FFE74A43A37",
                DateOfBirth = DateTime.Parse("08-16-60"),
                LastName = "Kristen"
            },
            new ApplicationUser()
            {

                FirstName= "Patrick",
                Id= "EC72E9E5-50EB-8460-4469-A916232838B5",
                DateOfBirth= DateTime.Parse("12/08/64"),
                LastName= "Caleb"
            },
            new ApplicationUser()
            {
                FirstName= "Penelope",
                Id= "D2D57256-EFC2-3259-D7BB-7A126DDC3CE2",
                DateOfBirth= DateTime.Parse("08/07/07"),
                LastName= "Philip"
            },
            new ApplicationUser(){
                FirstName= "Armand",
                Id= "8A6C8FB7-461F-187B-0B96-E2EFBBF7A8EB",
                DateOfBirth=DateTime.Parse ("03/23/62"),
                LastName= "Jack"
            },
            new ApplicationUser(){
                FirstName= "Brittany",
                Id= "9CDFB677-9945-9AAB-B988-352A780D5F50",
                DateOfBirth=DateTime.Parse ("03/05/07"),
                LastName= "Elmo"
            },
            new ApplicationUser()
            {
                FirstName= "Gwendolyn",
                Id= "B0268B9E-510C-8DE9-2C11-31B8FC0AE1F2",
                DateOfBirth=DateTime.Parse("08/16/70"),
                LastName= "Reese"
            },
            new ApplicationUser()
            {
                FirstName= "Myra",
                Id= "F89981C5-066C-CE27-7E6D-FBE7C845C60C",
                DateOfBirth=DateTime.Parse("06/22/01"),
                LastName= "Lana"
            },
            new ApplicationUser() {
                FirstName= "Lana",
                Id= "C8AB11C9-7812-0753-64CF-46FA919744C0",
                DateOfBirth=DateTime.Parse("09/09/72"),
                LastName= "Holly"
            },
            new ApplicationUser()
            {
                FirstName= "Riley",
                Id= "AEE7B39C-0613-3443-BC1C-6911A94B7846",
                DateOfBirth=DateTime.Parse("10/02/65"),
                LastName= "Yasir"
            },
            new ApplicationUser()
            {
                FirstName= "Caldwell",
                Id= "0D3F221A-ED66-C81D-9C57-5DBE93551E26",
                DateOfBirth=DateTime.Parse("02/19/77"),
                LastName= "Kaitlin"
            },
            new ApplicationUser()
            {
                FirstName= "Alfreda",
                Id= "3CC0CC6E-7CD2-BE49-813B-913A94C80FD9",
                DateOfBirth=DateTime.Parse("04/08/94"),
                LastName= "Kim"
            },
            new ApplicationUser(){
                FirstName= "Stephen",
                Id= "B87C5391-D282-961A-AADD-10501EFCA2A8",
                DateOfBirth=DateTime.Parse("01/19/07"),
                LastName= "Amethyst"
            },
            new ApplicationUser()
            {
                FirstName= "Donovan",
                Id= "1144D05C-F75A-AE5C-B806-0EEE7CF38021",
                DateOfBirth=DateTime.Parse("11/11/65"),
                LastName= "Lacy"
            },
            new ApplicationUser(){
                FirstName= "Daphne",
                Id= "5035504A-00BC-450A-49B8-11F9309CE924",
                DateOfBirth=DateTime.Parse("10/11/59"),
                LastName= "Plato"
            },
            new ApplicationUser(){
                FirstName= "Adena",
                Id= "FC00EA26-D0AF-876B-C655-5FB95C1BFBBB",
                DateOfBirth=DateTime.Parse("02/21/14"),
                LastName= "Gray"
            },
            new ApplicationUser(){
                FirstName= "Jonas",
                Id= "A4B20C1F-13BB-F831-EE9A-83C2F5034EC2",
                DateOfBirth=DateTime.Parse("05/28/84"),
                LastName= "Pascale"
            },
            new ApplicationUser(){
                FirstName= "Declan",
                Id= "2BE4CA58-BCB8-CF64-F121-E1BD464A80F2",
                DateOfBirth=DateTime.Parse("07/29/07"),
                LastName= "Maxwell"
            },
            new ApplicationUser(){
                FirstName= "Daphne",
                Id= "D364495F-913B-4505-8809-4F709B3A66CF",
                DateOfBirth=DateTime.Parse("02/11/06"),
                LastName= "Hiroko"
            },
            new ApplicationUser()
            {
                FirstName= "Imani",
                Id= "7D70D508-C8A4-C522-C6D2-0175D3A963E1",
                DateOfBirth=DateTime.Parse("01/27/78"),
                LastName= "Melyssa"
            },
            new ApplicationUser(){
                FirstName= "Hayes",
                Id= "9B2B64D2-A663-906D-88BF-C783B7DFED12",
                DateOfBirth=DateTime.Parse("08/17/69"),
                LastName= "Linus"
            },
            new ApplicationUser(){
                FirstName= "Florence",
                Id= "EC5306BA-5307-1D1F-2AB6-72309C38CAF8",
                DateOfBirth=DateTime.Parse("10/11/97"),
                LastName= "Naida"
            },
            new ApplicationUser(){
                FirstName= "Scarlet",
                Id= "333C9736-9F1B-90AB-1A26-C805AF166493",
                DateOfBirth=DateTime.Parse("11/19/97"),
                LastName= "Cynthia"
            }
        };
    }
}
