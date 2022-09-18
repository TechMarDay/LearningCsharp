using EntityFrameworkCoreCodeFirst.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkCoreCodeFirst
{
    public class FunctionCUDCategory
    {
        Category category = new Category();
        BlogDbContext db = new BlogDbContext();
        public void AddCategory(string title,string content, int createUserId, DateTime createDate, DateTime updateDate,int updateUserId)
        {
            category.Title = title;
            category.Content = content;
            category.CreateUserId = createUserId;
            category.CreateDate = createDate;
            category.UpdateDate = updateDate;
            category.UpdateUserId=  updateUserId;
            db.Add(category);
            db.SaveChanges();
            Console.WriteLine("Succesful");
        }
        public void UpdateCategory(int Id, string title, string content, int createUserId, DateTime createDate, DateTime updateDate, int updateUserId)
        {
            var checkId = db.Categories.Where(c => c.Id == Id).FirstOrDefault();
            if(checkId ==null)
            {
                Console.WriteLine("Id không đúng");
            }  
            else
            {
                checkId.Title = title;
                checkId.Content = content;
                checkId.CreateUserId = createUserId;
                checkId.CreateDate = createDate;
                checkId.UpdateDate = updateDate;
                checkId.UpdateUserId = updateUserId;
                db.Update(checkId);
                db.SaveChanges();
                Console.WriteLine("Succesful");
            }
          
        }
        public void DeleteCategory(int Id)
        {
            var checkId = db.Categories.Where(c => c.Id == Id).FirstOrDefault();
            if (checkId == null)
            {
                Console.WriteLine("Id không đúng");
            }
            else
            {
                db.Remove(checkId);
                db.SaveChanges();
                Console.WriteLine("Succesful");
            }

        }

    }
}
