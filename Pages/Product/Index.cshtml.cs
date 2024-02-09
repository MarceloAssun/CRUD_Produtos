using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using NunesSports.Data;
using NunesSports.Models;

namespace NunesSports.Pages_Product
{
    public class IndexModel : PageModel
    {
        private readonly NunesSports.Data.ApplicationDbContext _context;

        public IndexModel(NunesSports.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Product> Product { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Product = await _context.Product.ToListAsync();
        }
    }
}
