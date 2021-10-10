﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using RPFGOAccount.Data;
using System;
using System.Linq;

namespace RPFGOAccount.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new RPFGOAccountContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<RPFGOAccountContext>>()))
            {
                // Look for any movies.
                if (context.Character.Any())
                {
                    return;   // DB has been seeded
                }

                context.Character.AddRange(
                    new Character
                    {
                        Name = "Artoria Pendragon (Alter)",
                        Level = 100,
                        ATK = 14408,
                        HP = 16501
                    },

                    new Character
                    {
                        Name = "Circe",
                        Level = 100,
                        ATK = 11499,
                        HP = 15853
                    },

                    new Character
                    {
                        Name = "Mochizuki Chiyome",
                        Level = 90,
                        ATK = 10403,
                        HP = 13868
                    },

                    new Character
                    {
                        Name = "Mash",
                        Level = 80,
                        ATK = 9520,
                        HP = 13877
                    }
                );
                context.SaveChanges();
            }
        }
    }
}