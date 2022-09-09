// See https://aka.ms/new-console-template for more information
using EntityDatabaseFirst;
using EntityDatabaseFirst.Function;
using EntityDatabaseFirst.Models;
using System.Text;

Console.OutputEncoding = Encoding.UTF8;
//[US-03]Viết function lấy danh sách toàn bộ bài viết. Bên ngoài gọi function và sử dụng foreach để in Name của bài post ra màn hình.
var dbcontext = new BlogContext();
var posts = new GetData();

foreach (var item in posts.GetAllPost())
{
    Console.WriteLine(item.Title);
}
//Viết function lấy bài viết theo Id. Bên ngoài gọi function này và in Name + description ra màn hình.
Console.WriteLine("Viết function lấy bài viết theo Id. Bên ngoài gọi function này và in Name + description ra màn hình.");
Console.WriteLine("Mời nhập id");
int idPost = Convert.ToInt32(Console.ReadLine());
var posts1 = new GetData();

if (posts1.GetIdPost(idPost).Count == 0)
{
    Console.WriteLine("Rỗng");
}
else
{
    foreach (var item in posts1.GetIdPost(idPost))
    {
        Console.WriteLine($"{item.Title}-{item.Content}");
    }
}


   

Console.ReadLine();