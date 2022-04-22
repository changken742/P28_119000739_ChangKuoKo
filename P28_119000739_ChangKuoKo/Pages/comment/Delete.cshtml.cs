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
    public class DeleteModel : PageModel
    {
        private readonly RazorPagesMovieContext _context;

        public DeleteModel(RazorPagesMovieContext context)
        {
            _context = context;
        }

        [BindProperty]
        public comment comment { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            comment = await _context.comment.FirstOrDefaultAsync(m => m.ID == id);

            if (comment == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            comment = await _context.comment.FindAsync(id);

            if (comment != null)
            {
                _context.comment.Remove(comment);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
