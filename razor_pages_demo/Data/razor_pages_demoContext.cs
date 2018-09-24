using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace razor_pages_demo.Models
{
    public class razor_pages_demoContext : DbContext
    {
        public razor_pages_demoContext (DbContextOptions<razor_pages_demoContext> options)
            : base(options)
        {
        }

        public DbSet<razor_pages_demo.Models.Movie> Movie { get; set; }
    }
}
