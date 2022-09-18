using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebApplicationNET6.Data;
using WebApplicationNET6.Model;

namespace WebApplicationNET6.Pages.Categories
{
    public class IndexModel : PageModel
    {
        private readonly WebApplicationNET6.Data.BlogDBContext _context;

        public IndexModel(WebApplicationNET6.Data.BlogDBContext context)
        {
            _context = context;
        }

        public List<Category> Category { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Category != null)
            {
                Category = await _context.Category.ToListAsync();
            }
        }
    }
}
