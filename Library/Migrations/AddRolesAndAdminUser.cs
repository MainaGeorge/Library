using Library.Data;
using Library.Utility;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
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

            var roles = new[] { AppConstants.AdminUser, AppConstants.RegularUser };

            var context = scope.ServiceProvider.GetRequiredService<AppDbContext>();
            await context.Database.MigrateAsync(cancellationToken: cancellationToken);

            foreach (var role in roles)
            {
                if (!await roleManager.RoleExistsAsync(role))
                    await roleManager.CreateAsync(new IdentityRole(role));
            }

            var admin = await userManager.FindByEmailAsync("admin@gmail.com") ?? await CreateUser(userManager);

            await userManager.AddToRolesAsync(admin, new[] { AppConstants.RegularUser, AppConstants.AdminUser });
        }

        public Task StopAsync(CancellationToken cancellationToken) => Task.CompletedTask;


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
    }
}
