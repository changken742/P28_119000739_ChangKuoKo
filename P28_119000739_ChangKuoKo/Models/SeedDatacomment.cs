using Microsoft.EntityFrameworkCore;


namespace P28_119000739_ChangKuoKo.Models
{
    public static class SeedDatacomment
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new RazorPagesMovieContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<RazorPagesMovieContext>>()))
            {
                if (context == null || context.comment == null)
                {
                    throw new ArgumentNullException("Null RazorPagesMovieContext");
                }

                // Look for any movies.
                if (context.comment.Any())
                {
                    return;   // DB has been seeded
                }

                context.comment.AddRange(
                    new comment
                    {
                    
                        
                        Content = "Romantic Comedy",
                        Author = "ChangKuoKo",
                        CreatedAt = "asd"
                        
                    },

                    new comment
                    {
                        
                        Content = "Romantic Comedy",
                        Author = "ChangKuoKo",
                        CreatedAt = "asd"
                    },

                    new comment
                    {
                        
                        Content = "Romantic Comedy",
                        Author = "ChangKuoKo",
                        CreatedAt = "asd"
                    },

                    new comment
                    {
                        
                        Content = "Romantic Comedy",
                        Author = "ChangKuoKo",
                        CreatedAt = "asd"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}