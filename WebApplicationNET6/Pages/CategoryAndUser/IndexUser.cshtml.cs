using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebApplicationNET6.Model;

namespace WebApplicationNET6.Pages.CategoryAndUser
{
    public class IndexUserModel : PageModel
    {
        private readonly WebApplicationNET6.Data.BlogDBContext _context;

        public IndexUserModel(WebApplicationNET6.Data.BlogDBContext context)
        {
            _context = context;
        }

        public List<User> User { get; set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Category != null)
            {
                User = await _context.User.ToListAsync();
            }
        }
    }
}
