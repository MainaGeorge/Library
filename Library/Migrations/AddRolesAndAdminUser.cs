using Library.Data;
using Library.Entities;
using Library.Utility;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Library.Migrations
{
    public class AddRolesAndAdminUser : IHostedService
    {
        private readonly IServiceProvider _serviceProvider;

        public AddRolesAndAdminUser(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }
        public async Task StartAsync(CancellationToken cancellationToken)
        {
            using var scope = _serviceProvider.CreateScope();
            var roleManager = scope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();
            var userManager = scope.ServiceProvider.GetRequiredService<UserManager<IdentityUser>>();


            var context = scope.ServiceProvider.GetRequiredService<AppDbContext>();
            await context.Database.MigrateAsync(cancellationToken: cancellationToken);

            if (!await roleManager.RoleExistsAsync(AppConstants.AdminUser))
                await AddRoles(roleManager);


            if (!await context.ApplicationUsers.AnyAsync(cancellationToken))
                await AddRegularUsers(userManager, Users);

            var admin = await userManager.FindByEmailAsync("admin@gmail.com") ?? await CreateUser(userManager);

            await userManager.AddToRolesAsync(admin, new[] { AppConstants.RegularUser, AppConstants.AdminUser });
        }

        private static async Task AddRegularUsers(UserManager<IdentityUser> userManager, IEnumerable<ApplicationUser> users)
        {
            foreach (var user in users)
            {
                await userManager.CreateAsync(user);

                await userManager.AddToRoleAsync(user, AppConstants.RegularUser);
            }
        }
        public Task StopAsync(CancellationToken cancellationToken) => Task.CompletedTask;

        private static async Task AddRoles(RoleManager<IdentityRole> roleManager)
        {
            var roles = new[] { AppConstants.AdminUser, AppConstants.RegularUser };

            foreach (var role in roles)
            {
                if (!await roleManager.RoleExistsAsync(role))
                    await roleManager.CreateAsync(new IdentityRole(role));
            }
        }
        private static async Task<ApplicationUser> CreateUser(UserManager<IdentityUser> userManager)
        {
            var appUser = new ApplicationUser()
            {
                Email = "admin@gmail.com",
                FirstName = "Admin",
                LastName = "User",
                UserName = "Admin",
                DateOfBirth = new DateTime(2000, 12, 25)
            };

            const string password = "Admin123*@";

            await userManager.CreateAsync(appUser, password);

            return appUser;


        }

        public IEnumerable<ApplicationUser> Users => new List<ApplicationUser>()
        {
            new ApplicationUser()
            {
                FirstName = "Debra",
                Id = "4D69ED13-08F0-46DE-DE69-5FFE74A43A37",
                DateOfBirth = new DateTime(1960, 8, 1960),
                LastName = "Kristen",
                Email ="angel.ameurr@yablochnipirog.space",
                UserName = "Debra"
            },
            new ApplicationUser()
            {

                FirstName= "Patrick",
                Id= "EC72E9E5-50EB-8460-4469-A916232838B5",
                DateOfBirth= new DateTime(1964, 8, 12),
                UserName = "Caleb",
                Email = "momarsamy123s@haiok.cf"
            },
            new ApplicationUser()
            {
                FirstName= "Penelope",
                Id= "D2D57256-EFC2-3259-D7BB-7A126DDC3CE2",
                DateOfBirth= new DateTime(1907, 8, 7),
                LastName= "Philip",
                UserName = "Philip",
                Email = "sauobzaareer2@cbrit.com"
            },
            new ApplicationUser(){
                FirstName= "Armand",
                Id= "8A6C8FB7-461F-187B-0B96-E2EFBBF7A8EB",
                DateOfBirth= new DateTime(1962, 3, 23),
                LastName= "Jack",
                UserName = "Jack",
                Email = "5abdallah.zaid.7@packiu.com"
            },
            new ApplicationUser(){
                FirstName= "Brittany",
                Id= "9CDFB677-9945-9AAB-B988-352A780D5F50",
                DateOfBirth= new DateTime(1907, 3, 5),
                LastName= "Elmo",
                Email = "amdjed.p@limez.ninja",
                UserName = "Brittany"
            },
            new ApplicationUser()
            {
                FirstName = "Gwendolyn",
                Id = "B0268B9E-510C-8DE9-2C11-31B8FC0AE1F2",
                DateOfBirth = new DateTime(1970, 8, 16),
                LastName= "Reese",
                UserName = "Reese",
                Email = "vdelano.edwards@packiu.com"
            },
            new ApplicationUser()
            {
                FirstName= "Myra",
                Id= "F89981C5-066C-CE27-7E6D-FBE7C845C60C",
                DateOfBirth=new DateTime(1909, 6, 22),
                LastName= "Lana",
                UserName = "Lana",
                Email = "dbrikidhiag@aquapro.biz"
            },
            new ApplicationUser() {
                FirstName= "Lana",
                Id= "C8AB11C9-7812-0753-64CF-46FA919744C0",
                DateOfBirth=new DateTime(1972, 9, 9),
                LastName= "Holly",
                UserName = "Holly",
                Email = "eabode.harith2@moderntanks.us"
            },
            new ApplicationUser()
            {
                FirstName= "Riley",
                Id= "AEE7B39C-0613-3443-BC1C-6911A94B7846",
                DateOfBirth=new DateTime(1965, 10, 2),
                LastName= "Yasir",
                UserName = "Riley",
                Email = "apeterandreasschr@ateh.su"
            },
            new ApplicationUser()
            {
                FirstName= "Caldwell",
                Id= "0D3F221A-ED66-C81D-9C57-5DBE93551E26",
                DateOfBirth=new DateTime(1977, 2, 19),
                LastName= "Kaitlin",
                UserName = "Caldwell",
                Email = "monstrousness@leibian9.com"
            },
            new ApplicationUser()
            {
                FirstName= "Alfreda",
                Id= "3CC0CC6E-7CD2-BE49-813B-913A94C80FD9",
                DateOfBirth=new DateTime(1984, 4, 8),
                LastName= "Kim",
                UserName = "Kim",
                Email = "phiago.rafael.56@capnography.info"
            },
            new ApplicationUser(){
                FirstName= "Stephen",
                Id= "B87C5391-D282-961A-AADD-10501EFCA2A8",
                DateOfBirth=new DateTime(1970, 1, 19),
                LastName= "Amethyst",
                UserName = "Stephen",
                Email = "mmahmoudelgen@dirty.gr"
            },
            new ApplicationUser()
            {
                FirstName= "Donovan",
                Id= "1144D05C-F75A-AE5C-B806-0EEE7CF38021",
                DateOfBirth=new DateTime(1995, 11, 11),
                LastName= "Lacy",
                UserName = "Lacy",
                Email = "xsix_pensee@sagame.berlin"
            },
            new ApplicationUser(){
                FirstName= "Daphne",
                Id= "5035504A-00BC-450A-49B8-11F9309CE924",
                DateOfBirth=new DateTime(1959, 10, 11),
                LastName= "Plato",
                UserName = "Daphne",
                Email = "rserkan.bosic@meaningmagazine.com"
            },
            new ApplicationUser(){
                FirstName= "Adena",
                Id= "FC00EA26-D0AF-876B-C655-5FB95C1BFBBB",
                DateOfBirth=new DateTime(1970, 2, 30),
                LastName= "Gray",
                UserName = "Gray",
                Email = "wahmed.srour.165l@libridivertenti.shop"
            },
            new ApplicationUser(){
                FirstName= "Jonas",
                Id= "A4B20C1F-13BB-F831-EE9A-83C2F5034EC2",
                DateOfBirth=new DateTime(1984, 5 , 30),
                LastName= "Pascale",
                UserName = "Jonas",
                Email = "6delenda_fp@edwardnmkpro.design"
            },
            new ApplicationUser(){
                FirstName= "Declan",
                Id= "2BE4CA58-BCB8-CF64-F121-E1BD464A80F2",
                DateOfBirth=new DateTime(1970, 2, 14),
                LastName= "Maxwell",
                UserName = "Declan",
                Email = "9crazy.sam1@mangohik.xyz"
            },
            new ApplicationUser(){
                FirstName= "Daphne",
                Id= "D364495F-913B-4505-8809-4F709B3A66CF",
                DateOfBirth=new DateTime(1980, 2, 14),
                LastName= "Hiroko",
                UserName = "Hiroko",
                Email = "vwallyssom.p@rackabzar.com"
            },
            new ApplicationUser()
            {
                FirstName= "Imani",
                Id= "7D70D508-C8A4-C522-C6D2-0175D3A963E1",
                DateOfBirth=new DateTime(1978, 10, 27),
                LastName= "Melyssa",
                UserName = "Imani",
                Email = "ymarwan@coronagg.com"
            },
            new ApplicationUser(){
                FirstName= "Hayes",
                Id= "9B2B64D2-A663-906D-88BF-C783B7DFED12",
                DateOfBirth=new DateTime(1989, 12, 31),
                LastName= "Linus",
                UserName = "Linus",
                Email = "3altbrey0111i@maglo.sk"
            },
            new ApplicationUser(){
                FirstName= "Florence",
                Id= "EC5306BA-5307-1D1F-2AB6-72309C38CAF8",
                DateOfBirth=new DateTime(1997, 1, 1),
                LastName= "Naida",
                UserName = "Florence",
                Email = "1aziz123chnitiy@justinwelch.dev"
            },
            new ApplicationUser(){
                FirstName= "Scarlet",
                Id= "333C9736-9F1B-90AB-1A26-C805AF166493",
                DateOfBirth=new DateTime(1995, 1, 1),
                LastName= "Cynthia",
                Email = "jmilode-753w@cifro.tech",
                UserName = "Scarlet"
            }
        };

    }
}
