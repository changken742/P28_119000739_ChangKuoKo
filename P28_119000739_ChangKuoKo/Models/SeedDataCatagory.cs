using Microsoft.EntityFrameworkCore;


namespace P28_119000739_ChangKuoKo.Models
{
    public static class SeedDataCatagory
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new RazorPagesMovieContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<RazorPagesMovieContext>>()))
            {
                if (context == null || context.Category == null)
                {
                    throw new ArgumentNullException("Null RazorPagesMovieContext");
                }

                // Look for any movies.
                if (context.Category.Any())
                {
                    return;   // DB has been seeded
                }

                context.Category.AddRange(
                    new Category
                    {
                    
                        Name="Tuoi Tre"
                        
                    },

                    new Category
                    {
                        Name="Thanh nien"
                    },

                    new Category
                    {
                        Name="Cong an"
                    },

                    new Category
                    {
                        Name="Bao Doi"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}