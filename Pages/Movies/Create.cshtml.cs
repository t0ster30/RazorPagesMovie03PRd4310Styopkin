using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RazorPagesMovie03PRd4310Styopkin.Data;
using RazorPagesMovie03PRd4310Styopkin.Models;

namespace RazorPagesMovie03PRd4310Styopkin.Pages.Movies
{
    public class CreateModel : PageModel
    {
        private readonly RazorPagesMovie03PRd4310Styopkin.Data.RazorPagesMovie03PRd4310StyopkinContext _context;

        public CreateModel(RazorPagesMovie03PRd4310Styopkin.Data.RazorPagesMovie03PRd4310StyopkinContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Movie Movie { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Movie.Add(Movie);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
