namespace BookStore.Migrations
{
    using BookStore.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<BookStore.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(BookStore.Models.ApplicationDbContext context)
        {
            var books = new Book[]
            {
                new Book {Title="Eragon", Author="Chris Paolini"},
                new Book {Title="Jurassic Park", Author="Michael Crighton"},
                new Book {Title="The Martian", Author="Any Weir"}
            };

            context.Books.AddOrUpdate(b => b.Title, books);

        }
    }
}
