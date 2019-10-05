using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Learn_Net_Core_ASP.Data;
using Learn_Net_Core_ASP.Models;

namespace Learn_Net_Core_ASP.Views.Movies
{
    public class DetailsModel : PageModel
    {
        private readonly Learn_Net_Core_ASP.Data.AppDbContext _context;

        public DetailsModel(Learn_Net_Core_ASP.Data.AppDbContext context)
        {
            _context = context;
        }

        public Movie Movie { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Movie = await _context.Movies.FirstOrDefaultAsync(m => m.id == id);

            if (Movie == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
