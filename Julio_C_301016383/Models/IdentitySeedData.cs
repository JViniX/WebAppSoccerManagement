using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;

namespace Julio_C_301016383.Models
{
    public static class IdentitySeedData
    {
        private const string adminUser = "Admin";
        private const string adminPassword = "Secret123$";

        private const string genUser = "General";
        private const string genPassword = "Secret123$";

        

        public static async void EnsurePopulated(IApplicationBuilder app)
        {
            RoleManager<IdentityRole> roleManager = app.ApplicationServices
                .GetRequiredService<RoleManager<IdentityRole>>();

            await roleManager.CreateAsync(new IdentityRole("Admins"));
            await roleManager.CreateAsync(new IdentityRole("GeneralUsers"));

            UserManager <IdentityUser> userManager = app.ApplicationServices
                .GetRequiredService<UserManager<IdentityUser>>();

            IdentityUser user1 = await userManager.FindByIdAsync(adminUser);
            if (user1 == null)
            {
                user1 = new IdentityUser("Admin");
                await userManager.CreateAsync(user1, adminPassword);
                await userManager.AddToRoleAsync(user1, "Admins");
                await userManager.AddToRoleAsync(user1, "GeneralUsers");
            }       

            IdentityUser user2 = await userManager.FindByIdAsync(genUser);
            if (user2 == null)
            {
                user2 = new IdentityUser("General");
                await userManager.CreateAsync(user2, genPassword);
                await userManager.AddToRoleAsync(user2, "GeneralUsers");
            }
        }
    }
}
