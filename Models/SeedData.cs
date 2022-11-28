using System;
using Microsoft.EntityFrameworkCore;

namespace MvcMovie.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcMovieContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcMovieContext>>()))
            {
                // Look for any movies.
                if (context.Movie.Any())
                {
                    return; // DB has been seeded
                }

                context.Movie.AddRange(
                    new Movie
                    {
                        Title = "Raiders of the Lost Ark",
                        ReleaseDate = DateTime.Parse("1981-6-12"),
                        Genre = "Adventure/Action",
                        Price = 389.9M,
                        Rating = "S",
                        ImageURL = "raiders_of_the_lost_ark.jpeg"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}

