using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesMovie03PRd4310Styopkin.Data;
using RazorPagesMovie03PRd4310Styopkin.Models;

namespace RazorPagesMovie03PRd4310Styopkin.Pages.Movies
{
    public class DeleteModel : PageModel
    {
        private readonly RazorPagesMovie03PRd4310Styopkin.Data.RazorPagesMovie03PRd4310StyopkinContext _context;

        public DeleteModel(RazorPagesMovie03PRd4310Styopkin.Data.RazorPagesMovie03PRd4310StyopkinContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Movie Movie { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Movie = await _context.Movie.FirstOrDefaultAsync(m => m.Id == id);

            if (Movie == null)
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

            Movie = await _context.Movie.FindAsync(id);

            if (Movie != null)
            {
                _context.Movie.Remove(Movie);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
