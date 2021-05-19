using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;

namespace Persistence
{
    public class Seed
    {
        public static async Task SeedData(DataContext context)
        {
            if (context.Books.Any()) return;

            var activities = new List<Book>
            {
                new Book
                {
                    Title = "Book1",
                    Date = DateTime.Now.AddMonths(-2),
                    Description = "The book was launched 2 months ago",
                    Category = "horror",
                },
                new Book
                {
                    Title = "Book2",
                    Date = DateTime.Now.AddMonths(-1),
                    Description = "The book was launched 1 month ago",
                    Category = "culture",
                },
                new Book
                {
                    Title = "Book3",
                    Date = DateTime.Now.AddMonths(1),
                    Description = "The book will be launched in 1 month",
                    Category = "culture",
                },
                new Book
                {
                    Title = "Book4",
                    Date = DateTime.Now.AddMonths(2),
                    Description = "The book will be launched in 2 months",
                    Category = "horror",
                },
                new Book
                {
                    Title = "Book5",
                    Date = DateTime.Now.AddMonths(3),
                    Description = "The book will be launched in 3 months",
                    Category = "kids",
                },
                new Book
                {
                    Title = "Book6",
                    Date = DateTime.Now.AddMonths(4),
                    Description = "The book will be launched in 4 months",
                    Category = "kids",
                },
                new Book
                {
                    Title = "Book7",
                    Date = DateTime.Now.AddMonths(5),
                    Description = "The book will be launched in 5 months",
                    Category = "kids",
                },
                new Book
                {
                    Title = "Book8",
                    Date = DateTime.Now.AddMonths(6),
                    Description = "The book will be launched in 6 months",
                    Category = "culture",
                },
                new Book
                {
                    Title = "Book9",
                    Date = DateTime.Now.AddMonths(7),
                    Description = "The book was launched 2 months ago",
                    Category = "travel",
                },
                new Book
                {
                    Title = "Book10",
                    Date = DateTime.Now.AddMonths(8),
                    Description = "The book will be launched 8 months",
                    Category = "travel",
                }
            };

            await context.Books.AddRangeAsync(activities);
            await context.SaveChangesAsync();
        }
    }
}