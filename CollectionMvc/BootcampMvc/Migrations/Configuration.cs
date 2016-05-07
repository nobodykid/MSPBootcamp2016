namespace BootcampMvc.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    // this class is generated by using enable-migrations on NuGet Package Manager console
    internal sealed class Configuration : DbMigrationsConfiguration<BootcampMvc.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            // set to true 
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(BootcampMvc.Models.ApplicationDbContext context)
        {
            // this is where update function placed when Web updating the database
            // run 'update-database' to create user tables in database
            // option : 
            //          -script  : generate SQL query script
            //          -verbose : show details in console during process
        }
    }
}