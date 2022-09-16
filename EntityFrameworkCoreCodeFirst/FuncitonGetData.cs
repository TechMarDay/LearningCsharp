using EntityFrameworkCoreCodeFirst.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkCoreCodeFirst
{
    public class FuncitonGetData
    {
        

        public List<Category> GetListCategory()
        {
            BlogDbContext db = new BlogDbContext();
            var result = from c in db.Categories
            orderby c.Id select c;
           
            return result.ToList();

        }  public List<Category> GetListCategoryPostEagerLoading()
        {
            BlogDbContext db = new BlogDbContext();
            var result = db.Categories.Include(p => p.Posts);
           
            return result.ToList();

        }
        
    }
}
