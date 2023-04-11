using Core.Entities.Identity;
using Microsoft.AspNetCore.Identity;

namespace Infrastructure.Identity
{
    public class AppIdentityDbContextSeed
    {
        public static async Task SeedUserAsync(UserManager<AppUser> userManager)
        {
            if (userManager.Users.Any()) return;

            var user = new AppUser
            {
                DisplayName = "bob",
                Email = "bob@test.com",
                UserName = "bob@test.com",
                Address = new Address
                {
                    FirstName = "bob",
                    LastName = "bobity",
                    Street = "10 the street",
                    City = "New York",
                    ZipCode = "90251"
                }
            };

            await userManager.CreateAsync(user,"Pa$w0rd");
            
        }
    }
}