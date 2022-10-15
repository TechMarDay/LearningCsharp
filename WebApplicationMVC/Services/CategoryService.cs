using Microsoft.EntityFrameworkCore;
using WebApplicationMVC.Models;

namespace WebApplicationMVC.Services
{
    public class CategoryService
    {
        private readonly BlogDBContext _context;
        public CategoryService(BlogDBContext context)
        {
            _context = context;
        }

        //Xử lý nghiệp vụ model 
        public async Task AddCategory(Category category)
        {
            _context.Add(category);
            await _context.SaveChangesAsync();
        }

        //Model in MVC = service + model (xử lý nghiệp vụ)

        public async Task<List<Category>> GetAllCategories()
        {
            var categories = await _context.Category.ToListAsync();
            return categories;
        }

        protected int TestProtected()
        {
            var x = 1;
            return x;
        }
    }
}
