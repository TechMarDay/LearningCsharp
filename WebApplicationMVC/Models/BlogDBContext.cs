using Microsoft.EntityFrameworkCore;

namespace WebApplicationMVC.Models
{

    public class BlogDBContext : DbContext
    {
        public BlogDBContext(DbContextOptions<BlogDBContext> options)
            : base(options)
        {
        }

        public DbSet<Category> Category { get; set; } = default!;

    }
}
