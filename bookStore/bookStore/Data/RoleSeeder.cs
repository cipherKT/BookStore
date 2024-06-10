using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using System.Threading.Tasks;
namespace bookStore.Data
{
    public class RoleSeeder
    {
        public static async Task SeedRolesAsync(IApplicationBuilder app)
        {
            using (var scope = app.ApplicationServices.CreateScope())
            {
                var roleManager = scope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();
                string[] roles = { "Admin", "User" };

                foreach (var r in roles)
                {
                    if (!await roleManager.RoleExistsAsync(r))
                    {
                        await roleManager.CreateAsync(new IdentityRole(r));
                    }
                }
            }
        }
    }
}
