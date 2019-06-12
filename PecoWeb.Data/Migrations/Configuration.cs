namespace PecoWeb.Data.Migrations
{
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using Model.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<PecoWeb.Data.PecoWebDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(PecoWeb.Data.PecoWebDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.


            var manager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(new PecoWebDbContext()));
            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(new PecoWebDbContext()));

            var user = new ApplicationUser()
            {
                UserName = "tedu",
                Email = "phamthuannsth@gmail.com",
                EmailConfirmed = true,
                BirthDay = DateTime.Now,
                FullName = "Peco Web"
            };
            manager.Create(user, "123654$");
            if(!roleManager.Roles.Any())
            {
                roleManager.Create(new IdentityRole { Name = "Admin" });
                roleManager.Create(new IdentityRole { Name = "User" });
            }
            var adminUser = manager.FindByEmail("phamthuannsth@gmail.com");

            manager.AddToRoles(adminUser.Id, new string[] { "Admin", "User" });
            
        }
    }
}
