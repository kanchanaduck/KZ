using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using PTum.Data;
using System;
using System.Linq;

namespace PTum.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new PTumContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<PTumContext>>()))
            {
            }
        }
    }
}