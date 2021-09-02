using Microsoft.Extensions.Logging;
using RoasterWebApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoasterWebApplication.Helpers
{
    public class RosterContextSeed
    {
        public static async Task SeedAsync(RosterDBContext context, ILoggerFactory loggerFactory)
        {
            try
            {
                var p = context.Users.ToList();
                if (!context.Users.Any())
                {
                    User _users = new User {Username = "BatMan123", Password = "heLOgen92" };
                    context.Users.Add(_users);
                    await context.SaveChangesAsync();
                }

            }
            catch (Exception ex)
            {
                var logger = loggerFactory.CreateLogger<RosterContextSeed>();
                logger.LogError(ex.Message);
            }
        }
    }
}
