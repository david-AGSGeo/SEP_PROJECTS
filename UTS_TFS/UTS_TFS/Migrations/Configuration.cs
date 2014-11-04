namespace UTS_TFS.Migrations
{
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using UTS_TFS.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<UTS_TFS.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

                protected override void Seed(ApplicationDbContext context)

        {

            var manager = new UserManager<ApplicationUser>(
                new UserStore<ApplicationUser>(
                    new ApplicationDbContext()));

                var user = new ApplicationUser()
                {
                    UserName = "David@Lee42.com",
                    firstName = "David",
                    lastName = "Lee",
                    studentNo = 11055579,
                    phoneNo = "555-3931"
                };
                manager.Create(user, "Password1!");
            
        }

    }
}
