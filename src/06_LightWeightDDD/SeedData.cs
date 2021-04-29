using System;
using System.Collections.Generic;
using System.Linq;
using ApiArchitectureSample.Application.Core.AggregateModels.UserAggregate;
using ApiArchitectureSample.Infrastructure;

namespace ApiArchitectureSample
{
    public class SeedData
    {
        public static void EnsureSampleData(ApiArchitectureSampleContext dbContext, IServiceProvider sp)
        {
            if (!dbContext.Users.Any())
            {
                dbContext.Users.AddRange(
                    new List<User>
                    {
                        new User(1, "Tanaka Ichiro", new Address("street", "city", "state", "country", "zipcode")),
                        new User(2, "Tanaka Jiro", new Address("street", "city", "state", "country", "zipcode")),
                        new User(3, "Tanaka Saburo", new Address("street", "city", "state", "country", "zipcode"))
                    }
                );
                dbContext.SaveChanges();
            }
        }
    }
}
