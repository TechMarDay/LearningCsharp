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
        public async Task<IActionResult> OnPostCreateCategoryAsync()
        {
            //if (!ModelState.IsValid)
            if (!IsValidCategoryModel())
            {
                return Page();
            }
            else
            {
                //Meta data
                Category.CreateDate = DateTime.UtcNow;
                Category.UpdateDate = DateTime.UtcNow;
                Category.CreateUserId = 1; //Login => userId

                _context.Category.Add(Category);
                await _context.SaveChangesAsync();
                return RedirectToPage("./Index");
            }

        }
        [HttpPost]
        public async Task<IActionResult> OnPostCreateUserAsync()
        {

            if (User == null)
            {
                return Page();
            }
            else
            {
                _context.User.Add(User);
                await _context.SaveChangesAsync();
                return RedirectToPage("./IndexUser");
            }

        }

        private bool IsValidCategoryModel()
        {
            if(String.IsNullOrWhiteSpace(Category.Title))
                return false;
            //

            return true;
        }
    }
}
