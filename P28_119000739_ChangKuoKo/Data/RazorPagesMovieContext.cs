#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using P28_119000739_ChangKuoKo.Models;

    public class RazorPagesMovieContext : DbContext
    {
        public RazorPagesMovieContext (DbContextOptions<RazorPagesMovieContext> options)
            : base(options)
        {
        }

        public DbSet<P28_119000739_ChangKuoKo.Models.News> News { get; set; }

        public DbSet<P28_119000739_ChangKuoKo.Models.Category> Category { get; set; }

        public DbSet<P28_119000739_ChangKuoKo.Models.comment> comment { get; set; }
    }
