using BenchmarkDotNet.Running;
using EntityDatabaseFirst;
using EntityDatabaseFirst.Function;
using System.Text;

Console.OutputEncoding = Encoding.UTF8;

#region Entity Framework Data first
/*
//[US-03]Viết function lấy danh sách toàn bộ bài viết. Bên ngoài gọi function và sử dụng foreach để in Name của bài post ra màn hình.
var postService = new PostService();

foreach (var item in postService.GetAllPost())
{
    Console.WriteLine(item.Title);
}

//Viết function lấy bài viết theo Id. Bên ngoài gọi function này và in Name + description ra màn hình.
Console.WriteLine("Viết function lấy bài viết theo Id. Bên ngoài gọi function này và in Name + description ra màn hình.");
Console.WriteLine("Mời nhập id");
int postId = Convert.ToInt32(Console.ReadLine());
var post = postService.GetPostById(postId);

if (post == null) 
    Console.WriteLine($"Không tìm thấy bài post với Id = {postId}");
else
    Console.WriteLine($"{post?.Title}-{post?.Content}");
*/
#endregion

//var adoConnectService = new AdoService(); //Ado.net
//adoConnectService.Run();

//var postService = new PostService(); //Entity framrework core
//postService.Run();

var summary = BenchmarkRunner.Run(typeof(BenchMarkService));

Console.ReadLine();