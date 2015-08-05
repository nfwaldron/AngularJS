namespace LessonsUnlimited_V2._0.Migrations
{
    using LessonsUnlimited_V2._0.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<LessonsUnlimited_V2._0.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(LessonsUnlimited_V2._0.Models.ApplicationDbContext context)
        {
            var lessons = new Lesson[]
            {
                new Lesson{Author  = "Riley Hagan", Description = "Master the Cycle of Fourths!", Title = "Cycle of Fourths", VideoLink="3TRDtpkbL3c"},
                new Lesson{Author  = "Riley Hagan", Description = "Master the Pentatonic Scale!", Title = "Bb Pentatonics", VideoLink="cr3_Vim0JcI"},
                new Lesson{Author  = "Riley Hagan", Description = "Master Arpeggios!", Title = "1-3-5 Arpeggios", VideoLink="cr3_Vim0JcI"}
            };

            //The Migrations Seed() method is called everytime you execute the Update-Database command. 
            //You won't be starting from a new database every time the Migrations Seed() method is called.
            //For this reason, you use the AddOrUpdate() method to seed the database. 
            //This methods adds new data only when the data does not already exist.
            context.Lessons.AddOrUpdate(model => model.Title, lessons);
        }
    }
}
