using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApplicationNET6.Model;

namespace WebApplicationNET6.Data
{
    public class BlogDBContext : DbContext
    {
        public BlogDBContext (DbContextOptions<BlogDBContext> options)
            : base(options)
        {
        }

        public DbSet<WebApplicationNET6.Model.Category> Category { get; set; } = default!;
    }
}
