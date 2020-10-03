using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Linq;
using System.Threading.Tasks;
using WebForum.Data.Models;

namespace WebForum.Data
{
    public class DataSeeder
    {
        private readonly ApplicationDbContext _context;

        public DataSeeder(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<Task> SeedSuperUser()
        {
            var RolesStore = new RoleStore<IdentityRole>(_context);
            var UserStore = new UserStore<ApplicationUser>(_context);

            var user = new ApplicationUser
            {
                UserName = "Admin",
                NormalizedUserName = "admin",
                Email = "admin@example.com",
                NormalizedEmail = "admin@example.com",
                EmailConfirmed = true,
                LockoutEnabled = false,
                SecurityStamp = Guid.NewGuid().ToString()
            };

            var hasher = new PasswordHasher<ApplicationUser>();
            var hashedPassword = hasher.HashPassword(user, "admin");
            user.PasswordHash = hashedPassword;

            var hasAdminRole = _context.Roles.Any(roles => roles.Name == "Admin");

            if (!hasAdminRole)
            {
                    await RolesStore.CreateAsync(
                    new IdentityRole
                    {
                        Name = "Admin",
                        NormalizedName = "admin",
                    });
            }

            var hasSuperUser = _context.Users.Any(u => u.NormalizedUserName == user.UserName);

            if (!hasSuperUser)
            {
                await UserStore.CreateAsync(user);
                await UserStore.AddToRoleAsync(user, "Admin");
            }
            await _context.SaveChangesAsync();

            return Task.CompletedTask;
        }
    }
}
