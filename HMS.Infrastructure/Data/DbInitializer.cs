using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Infrastructure.Data
{
    public static class DbInitializer
    {
        public static void Seed(HMSDbContext context)
        {
            if (!context.Hotels.Any())
            {
                context.Hotels.AddRange(
                    new Hotel { Name = "Hotel A", Rating = 5, Country = "USA", City = "New York", Address = "123 Main St" },
                    new Hotel { Name = "Hotel B", Rating = 4, Country = "France", City = "Paris", Address = "456 Avenue" }
                );
                context.SaveChanges();
            }
        }
    }
}
