using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using razor_pages_demo.Models;

namespace razor_pages_demo.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly razor_pages_demo.Models.razor_pages_demoContext _context;

        public IndexModel(razor_pages_demo.Models.razor_pages_demoContext context)
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
