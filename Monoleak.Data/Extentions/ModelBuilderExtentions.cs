using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Monoleak.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monoleak.Data.Extentions
{
    public static class ModelBuilderExtentions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AppConfig>().HasData(
                new AppConfig()
                { Key = "HomeTitle", Value = "this home page for Monoleak." }
                );
            modelBuilder.Entity<Category>().HasData(
                new Category() { Id = 1, Name = "Sức khỏe" },
                new Category() { Id = 2, Name = "Chuyển tiền" },
                new Category() { Id = 3, Name = "Ăn uống" },
                new Category() { Id = 4, Name = "Mua sắm" },
                new Category() { Id = 5, Name = "Kiến thức" },
                new Category() { Id = 6, Name = "Khác" }
                );
            var roleId = new Guid("066F74D8-E6DB-4E31-B4B7-A6E71980A3E6");
            var adminId = new Guid("3061882B-D2F9-4F5C-9CF1-1D3557D4870D");
            modelBuilder.Entity<AppRole>().HasData(new AppRole
            {
                Id = roleId,
                Name = "admin",
                NormalizedName = "admin",
                Description = "Administrator role"
            });

            var hasher = new PasswordHasher<AppUser>();
            modelBuilder.Entity<AppUser>().HasData(new AppUser
            {
                Id = adminId,
                UserName = "admin",
                NormalizedUserName = "admin",
                Email = "nam645939@gmail.com",
                NormalizedEmail = "tedu.international@gmail.com",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "Abcd1234$"),
                SecurityStamp = string.Empty,
                FirstName = "Nam",
                LastName = "Nguyen",
                Dob = new DateTime(2020, 01, 31)
            });

            modelBuilder.Entity<IdentityUserRole<Guid>>().HasData(new IdentityUserRole<Guid>
            {
                RoleId = roleId,
                UserId = adminId
            });
        }
    }
}
