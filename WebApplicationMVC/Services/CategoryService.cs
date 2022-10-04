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
    }
}
