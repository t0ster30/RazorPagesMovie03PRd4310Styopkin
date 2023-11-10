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
    public class IndexModel : PageModel
    {
        private readonly RazorPagesMovie03PRd4310Styopkin.Data.RazorPagesMovie03PRd4310StyopkinContext _context;

        public IndexModel(RazorPagesMovie03PRd4310Styopkin.Data.RazorPagesMovie03PRd4310StyopkinContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; }

        public async Task OnGetAsync()
        {
            Movie = await _context.Movie.ToListAsync();
        }
    }
}
