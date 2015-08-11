namespace CarDealerShip.Migrations
{
    using CarDealerShip.Models;
    using Microsoft.AspNet.Identity.EntityFramework;
    using Microsoft.AspNet.Identity;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using System.Security.Claims;

    internal sealed class Configuration : DbMigrationsConfiguration<CarDealerShip.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(CarDealerShip.Models.ApplicationDbContext context)
        {

            var userStore = new UserStore<ApplicationUser>(context);
            var userManager = new ApplicationUserManager(userStore);

            // Ensure Stephen
            var user = userManager.FindByName("waldron.nathan@gmail.com");
            if (user == null)
            {
                // create user
                user = new ApplicationUser
                {
                    UserName = "waldron.nathan@gmail.com",
                    Email = "waldron.nathan@gmail.com"
                };
                userManager.Create(user, "Secret123!");

                // add claims
                userManager.AddClaim(user.Id, new Claim("IsAdmin", "true"));


                var teslas = new Tesla[]
            {
                new Tesla{Title="Model S", Price=57500.00m, Range=245, ChargeTime=3.50, FullDescription = "Tesla’s advanced electric powertrain delivers exhilarating performance. Unlike a gasoline internal combustion engine with hundreds of moving parts, Tesla electric motors have only one moving piece: the rotor. As a result, Model S acceleration is instantaneous, silent and smooth. Step on the accelerator and in as little as 2.8 seconds Model S is travelling 60 miles per hour, without hesitation, and without a drop of gasoline. Model S is an evolution in automobile engineering.", BriefDescription="Highest safety rating in America, AutoPilot Equipped", Picture="http://blog.caranddriver.com/wp-content/uploads/2014/10/Screen-Shot-2014-10-10-at-9.16.06-AM-626x3341.png"},
                new Tesla{Title="Model D", Price=67500.00m, Range=234, ChargeTime=3.50, FullDescription = "Tesla’s advanced electric powertrain delivers exhilarating performance. Unlike a gasoline internal combustion engine with hundreds of moving parts, Tesla electric motors have only one moving piece: the rotor. As a result, Model S acceleration is instantaneous, silent and smooth. Step on the accelerator and in as little as 2.8 seconds Model S is travelling 60 miles per hour, without hesitation, and without a drop of gasoline. Model S is an evolution in automobile engineering.", BriefDescription="Highest safety rating in America, AutoPilot Equipped", Picture="http://blog.caranddriver.com/wp-content/uploads/2014/10/Screen-Shot-2014-10-10-at-9.16.06-AM-626x3341.png"},
                new Tesla{Title="Model PSG", Price=87500.00m, Range=265, ChargeTime=3.50, FullDescription = "Tesla’s advanced electric powertrain delivers exhilarating performance. Unlike a gasoline internal combustion engine with hundreds of moving parts, Tesla electric motors have only one moving piece: the rotor. As a result, Model S acceleration is instantaneous, silent and smooth. Step on the accelerator and in as little as 2.8 seconds Model S is travelling 60 miles per hour, without hesitation, and without a drop of gasoline. Model S is an evolution in automobile engineering.", BriefDescription="Highest safety rating in America, AutoPilot Equipped", Picture="http://blog.caranddriver.com/wp-content/uploads/2014/10/Screen-Shot-2014-10-10-at-9.16.06-AM-626x3341.png"},
                new Tesla{Title="Model T", Price=47500.00m, Range=240, ChargeTime=3.50, FullDescription = "Tesla’s advanced electric powertrain delivers exhilarating performance. Unlike a gasoline internal combustion engine with hundreds of moving parts, Tesla electric motors have only one moving piece: the rotor. As a result, Model S acceleration is instantaneous, silent and smooth. Step on the accelerator and in as little as 2.8 seconds Model S is travelling 60 miles per hour, without hesitation, and without a drop of gasoline. Model S is an evolution in automobile engineering.", BriefDescription="Highest safety rating in America, AutoPilot Equipped", Picture="http://blog.caranddriver.com/wp-content/uploads/2014/10/Screen-Shot-2014-10-10-at-9.16.06-AM-626x3341.png"},
                new Tesla{Title="Model X", Price=87500.00m, Range=253, ChargeTime=2.50, Picture="http://www.teslamotors.com/sites/default/files/images/model-x/teaser@2x.jpg?2", FullDescription = "Every Model X comes with all-wheel drive standard, powered by two independent, digitally controlled electric motors. Brilliantly functional Falcon Wing rear doors fold up and out of the way to allow easy access to third row seats.", BriefDescription="Model X combines the space and functionality of a seven seat sport utility vehicle with the uncompromised performance of a Tesla."},
            };

                context.Teslas.AddOrUpdate(t => t.Title, teslas);

                var royces = new RollsRoyce[] 
            { 
                new RollsRoyce{Title="Wraith", Price=394025.00m, GasMileage=21, BriefDescription="The most technologically advanced and potent Rolls-Royce in history, Wraith is a car for the curious, the confident and the bold.", FullDescription="Drawing inspiration from Wraith's inimitable power, style and drama and the creative industries that shape our world, 'Inspired by' is a brand new concept in Bespoke. A concept that showcases the true potential of creativity and craftsmanship, and inspires you to create your own iconic version of Wraith.", Picture="http://1.bp.blogspot.com/-QdfC8mA0xss/VH3XgreCPgI/AAAAAAAAd6c/iJR1u1oKpT0/s1600/RR-Wraith-100.jpg" },
                new RollsRoyce{Title="Phantom", Price=254025.00m, GasMileage=23, BriefDescription="The most technologically advanced and potent Rolls-Royce in history, Wraith is a car for the curious, the confident and the bold.", FullDescription="Drawing inspiration from Wraith's inimitable power, style and drama and the creative industries that shape our world, 'Inspired by' is a brand new concept in Bespoke. A concept that showcases the true potential of creativity and craftsmanship, and inspires you to create your own iconic version of Wraith.", Picture="http://1.bp.blogspot.com/-QdfC8mA0xss/VH3XgreCPgI/AAAAAAAAd6c/iJR1u1oKpT0/s1600/RR-Wraith-100.jpg" },
                new RollsRoyce{Title="Spider", Price=274025.00m, GasMileage=25, BriefDescription="The most technologically advanced and potent Rolls-Royce in history, Wraith is a car for the curious, the confident and the bold.", FullDescription="Drawing inspiration from Wraith's inimitable power, style and drama and the creative industries that shape our world, 'Inspired by' is a brand new concept in Bespoke. A concept that showcases the true potential of creativity and craftsmanship, and inspires you to create your own iconic version of Wraith.", Picture="http://1.bp.blogspot.com/-QdfC8mA0xss/VH3XgreCPgI/AAAAAAAAd6c/iJR1u1oKpT0/s1600/RR-Wraith-100.jpg" },
                new RollsRoyce{Title="Syntax", Price=294085.00m, GasMileage=22, BriefDescription="The most technologically advanced and potent Rolls-Royce in history, Wraith is a car for the curious, the confident and the bold.", FullDescription="Drawing inspiration from Wraith's inimitable power, style and drama and the creative industries that shape our world, 'Inspired by' is a brand new concept in Bespoke. A concept that showcases the true potential of creativity and craftsmanship, and inspires you to create your own iconic version of Wraith.", Picture="http://1.bp.blogspot.com/-QdfC8mA0xss/VH3XgreCPgI/AAAAAAAAd6c/iJR1u1oKpT0/s1600/RR-Wraith-100.jpg" },
                new RollsRoyce{Title="Ghost", Price=230488.00m, GasMileage=20, Picture="http://cdn.bmwblog.com/wp-content/uploads/2010_rollsroyce_ghost1.jpg", BriefDescription="Introducing Ghost Series II. The ultimate expression of modern dynamism and luxury.", FullDescription="Ghost is the essence of Rolls-Royce in its simplest, purest form. Advanced engineering combined with a host of hidden technologies create a dynamic yet luxurious drive."}
            };

                context.RollyRoyces.AddOrUpdate(r => r.Title, royces);

            }
        }
    }
}
