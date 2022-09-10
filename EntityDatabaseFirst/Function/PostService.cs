using BenchmarkDotNet.Attributes;
using EntityDatabaseFirst.EntityModels;
using EntityDatabaseFirst.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityDatabaseFirst.Function
{

    //Name of class => Danh từ (noun)
    public class PostService 
    {
        //Name of method, function => prefix verb 
         public List<Post> GetAllPost()
        {
            var db = new BlogDbContext();
            return db.Posts.ToList();
            
        }

        public void Run()
        {
            var posts = GetAllPost();
            foreach (var post in posts)
            {
                Console.WriteLine("{0}=={1}", post.Title, post.Content);
            }    
        }    

        //Camel-case quy tắc lạc đà

        //Entity 1 bài post - 1 khóa chính Id duy nhất
        //=> 1 bài post

        public Post? GetPostById(int Id)

        {
            //FirstOrDefault => không tìm thấy => trả về giá trị default
            //=> default of object Post => null
            var db = new BlogDbContext();

            var id = db.Posts
                .Where(x => x.Id == Id)
                .Select(x => x.Id) //id kiểu int => 0
                .FirstOrDefault();

            return db.Posts.FirstOrDefault(m => m.Id == Id);
        }
    }
}
