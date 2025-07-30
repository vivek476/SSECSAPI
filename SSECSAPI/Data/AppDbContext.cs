﻿using Microsoft.EntityFrameworkCore;
using SSECSAPI.Models;

namespace SSECSAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Rating> Ratings { get; set; }
        public DbSet<OrderStatus> OrderStatuses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Role>().HasData(
                new Role { Id = 1, Name = "Super Admin" },
                new Role { Id = 2, Name = "Admin" },
                new Role { Id = 3, Name = "User" });

            modelBuilder.Entity<User>().HasData(
               new User { Id = 1, Name = "Anil", Email = "anil@gmail.com", Mobile = 9876543210, Password = "Test@123" },
               new User { Id = 2, Name = "Vivek", Email = "vivek@gmail.com", Mobile = 9658896558, Password = "Test@123" },
               new User { Id = 3, Name = "Smruti", Email = "smruti@gmail.com", Mobile = 8547963213, Password = "Test@123" },
               new User { Id = 4, Name = "Manas", Email = "manas@gmail.com", Mobile = 8569321441, Password = "Test@123" });

            modelBuilder.Entity<UserRole>().HasData(
              new UserRole { Id = 1, UserId = 1, RoleId = 1 },
              new UserRole { Id = 2, UserId = 2, RoleId = 2 },
              new UserRole { Id = 3, UserId = 3, RoleId = 3 },
              new UserRole { Id = 4, UserId = 4, RoleId = 4 });
        }
    }
}
