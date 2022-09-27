using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplicationNET6.Model;

namespace WebApplicationNET6.Pages.CategoryAndUser
{
    public class CreateModel : PageModel
    {
        private readonly WebApplicationNET6.Data.BlogDBContext _context;

        public CreateModel(WebApplicationNET6.Data.BlogDBContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Category Category { get; set; }
        [BindProperty]
        public User User { get; set; }


        [HttpPost]
        public IActionResult OnPostCreateCategory()
        {
            if (Category == null)
            {
                return Page();
            }
            else
            {
                _context.Category.Add(Category);
                _context.SaveChanges();
                return RedirectToPage("./Index");
            }
        
        }
        [HttpPost]
        public IActionResult OnPostCreateUser()
        {

            if (User == null)
            {
                return Page();
            }
            else
            {
                _context.User.Add(User);
                _context.SaveChanges();
                return RedirectToPage("./IndexUser");
            }

        }
    }
}
