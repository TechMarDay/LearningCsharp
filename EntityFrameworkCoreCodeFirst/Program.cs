// See https://aka.ms/new-console-template for more information
using EntityFrameworkCoreCodeFirst;
using EntityFrameworkCoreCodeFirst.Models;
using Microsoft.EntityFrameworkCore;
using System.Text;

Console.OutputEncoding = Encoding.UTF8;
BlogDbContext db = new BlogDbContext();
FuncitonGetData funcitonGetData = new FuncitonGetData();
var listCategory = funcitonGetData.GetListCategory();
var resultCategoryPost = from c in listCategory
                  
                  select new
                  {
                      c.Id,
                      c.Title,
                      c.Content,
                      c.CreateUserId,
                      c.CreateDate,
                      c.UpdateDate,
                      c.UpdateUserId,
                      list = (from p in db.Posts where p.CategoryId == c.Id select p).ToList()

                  };
foreach (var item in resultCategoryPost)
{
    Console.WriteLine($"{item.Id}-{item.Title}-{item.Content}-{item.CreateUserId}-{item.CreateDate}-{item.UpdateDate}-{item.UpdateUserId}");
    foreach (var i in item.list)
    {
        Console.WriteLine($"{i.Id}-{i.Title}-{i.Content}-{i.UserId}-{i.CreateDate}-{i.UpdateDate}-{i.UpdateUserId}");
    }
}
var resultCategoryPostEagerLoading = funcitonGetData.GetListCategoryPostEagerLoading();
//var resultCategoryPostEagerLoading = db.Categories.Include(p => p.Posts);
foreach (var item in resultCategoryPostEagerLoading)
{
    Console.WriteLine($"{item.Id}-{item.Title}-{item.Content}-{item.CreateUserId}-{item.CreateDate}-{item.UpdateDate}-{item.UpdateUserId}");
    foreach (var i in item.Posts)
    {
        Console.WriteLine($"{i.Id}-{i.Title}-{i.Content}-{i.UserId}-{i.CreateDate}-{i.UpdateDate}-{i.UpdateUserId}");
    }
}


Console.ReadLine();