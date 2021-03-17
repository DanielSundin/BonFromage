using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using BonFromage.Data;
using System;
using System.Linq;

namespace BonFromage.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new BonFromageContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<BonFromageContext>>()))
            {
                // Look for any movies.
                if (context.MenuItem.Any())
                {
                    return;   // DB has been seeded
                }

                context.MenuItem.AddRange(
                    new MenuItem
                    {
                        Name= "Escargot",
                        Description = "Garlic and snail",
                        Price = 85
                        
                    },

                    new MenuItem
                    {
                        Name = "Onion Soup ",
                        Description = "Gratine with cheese",
                        Price = 90
                    }

                );
                context.SaveChanges();
            }
        }
    }
}