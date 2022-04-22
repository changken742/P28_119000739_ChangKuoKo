#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using P28_119000739_ChangKuoKo.Models;

namespace P28_119000739_ChangKuoKo.Pages_comment
{
    public class IndexModel : PageModel
    {
        private readonly RazorPagesMovieContext _context;

        public IndexModel(RazorPagesMovieContext context)
        {
            _context = context;
        }

        public IList<comment> comment { get;set; }

        public async Task OnGetAsync()
        {
            comment = await _context.comment.ToListAsync();
        }
    }
}
