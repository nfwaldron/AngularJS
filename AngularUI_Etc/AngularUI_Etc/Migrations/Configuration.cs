namespace AngularUI_Etc.Migrations
{
    using AngularUI_Etc.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<AngularUI_Etc.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(AngularUI_Etc.Models.ApplicationDbContext context)
        {
            var reptiles = new Reptile[]
          {
              new Reptile {Name="Bob", NumberOfScales=34, Species="Gila Monster"},
              new Reptile {Name="Barry", NumberOfScales=34, Species="Leopard Gecko"},
              new Reptile {Name="Bishop", NumberOfScales=34, Species="Striped Terrapin"},
              new Reptile {Name="Bill", NumberOfScales=34, Species="Iguana"}
          };

            context.Reptiles.AddOrUpdate(r => r.Name, reptiles);
        }
    }
}
