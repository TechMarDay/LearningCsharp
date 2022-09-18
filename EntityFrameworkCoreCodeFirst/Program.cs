// See https://aka.ms/new-console-template for more information
using EntityFrameworkCoreCodeFirst;
using EntityFrameworkCoreCodeFirst.Models;
using Microsoft.EntityFrameworkCore;
using System.Text;

Console.OutputEncoding = Encoding.UTF8;
BlogDbContext db = new BlogDbContext();
FuncitonGetData funcitonGetData = new FuncitonGetData();

//var categories = funcitonGetData.GetListCategory();


//Cách 1

//RAM => paging 100, 100 1000 items => page 10 pages
var listCategory = funcitonGetData.GetListCategory2(); //memory RAM

foreach(var category in listCategory)
{
    Console.WriteLine($"{category.Id}-{category.Title}-{category.Content}");
    foreach(var post in category.Posts)
    {
        Console.WriteLine($"{post.Id}-{post.Title}");
    }

}    

//open connection databae
//excute query
//close connection

//100


//1 query => execute 1 lần => cách 1 => query phức tạp
//2 query => execute xuống db 2 lần => cách 2 (thường dùng hơn) do query đơn giản


//Cách 2

/*
var resultCategoryPost = from c in listCategory //linq in memory
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
foreach (var item in resultCategoryPost) // 1000 item categories 
{
    Console.WriteLine($"{item.Id}-{item.Title}-{item.Content}-{item.CreateUserId}-{item.CreateDate}-{item.UpdateDate}-{item.UpdateUserId}");
    foreach (var i in item.list)   // 10 posts => queryable => List => run query in sql profile
    {
        Console.WriteLine($"{i.Id}-{i.Title}-{i.Content}-{i.UserId}-{i.CreateDate}-{i.UpdateDate}-{i.UpdateUserId}");
    }
}

*/


// truy xuất database nhiều lần => ko tốt, tốn performance 

//Viết toàn query 1 lần => thực thi 1 lần => peformance tốt


/*
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

*/

// [US-11] Viết function Add, Update, Delete Category
//  function Add
//Console.WriteLine("==========================================================================");
//Console.WriteLine("[US-11] Viết function Add, Update, Delete Category");
//Console.Write("Nhập Id:");
//int Id = Convert.ToInt32(Console.ReadLine());
//Console.Write("Nhập Title:");
//string title =Console.ReadLine() +"\n";
//Console.Write("Nhập Content:");
//string content = Console.ReadLine() + "\n";
//Console.Write("Nhập CreateUserId:");
//int createUserId =Convert.ToInt32(Console.ReadLine()) ;

//Console.Write("Nhập CreateDate:");
//DateTime createDate = Convert.ToDateTime(Console.ReadLine());

//Console.Write("Nhập UpdateDate:");
//DateTime updateDate = Convert.ToDateTime(Console.ReadLine());


//Console.Write("Nhập UpdateUserId:");
//int updateUserId = Convert.ToInt32(Console.ReadLine());
//FunctionCUDCategory functionCUD = new FunctionCUDCategory();

//Console.WriteLine("function Add");
////functionCUD.AddCategory(title,content,createUserId,createDate,updateDate,updateUserId);

//Console.WriteLine("==========================================================================");
//Console.WriteLine("function Update");
////functionCUD.UpdateCategory(Id,title,content,createUserId,createDate,updateDate,updateUserId);


//Console.WriteLine("==========================================================================");
//Console.WriteLine("function Delete");
//functionCUD.DeleteCategory(Id);

Console.ReadLine();