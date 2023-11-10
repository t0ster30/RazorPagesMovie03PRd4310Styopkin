using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorPagesMovie03PRd4310Styopkin.Models;

namespace RazorPagesMovie03PRd4310Styopkin.Data
{
    public class RazorPagesMovie03PRd4310StyopkinContext : DbContext
    {
        public RazorPagesMovie03PRd4310StyopkinContext (DbContextOptions<RazorPagesMovie03PRd4310StyopkinContext> options)
            : base(options)
        {
        }

        public DbSet<RazorPagesMovie03PRd4310Styopkin.Models.Movie> Movie { get; set; }
    }
}
