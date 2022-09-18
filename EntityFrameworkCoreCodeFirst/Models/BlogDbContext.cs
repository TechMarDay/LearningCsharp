using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkCoreCodeFirst.Models
{
    public class BlogDbContext :DbContext
    {
        public DbSet<Category>? Categories { get; set; }
        public DbSet<Post>? Posts { get; set; }
        // để kết nối database sử dụng 
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder
                
                .UseSqlServer("Data Source=.\\SQLEXPRESS;Initial Catalog=BlogCodeFirst;User ID=sa;Password=Asdf@123456;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //foregin key
        }
    }
}
