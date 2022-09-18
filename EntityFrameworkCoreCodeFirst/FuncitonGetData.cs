using EntityFrameworkCoreCodeFirst.Models;
using EntityFrameworkCoreCodeFirst.ViewModels;
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
           
            return result.ToList(); //Queryable => Enumerable (list)

            //ToList => memory 


            //Tất cả xử lý trên database (query)

            //ToList 1 lần => memory

            //var query = from c in db.Categories
            //            join p in db.Posts
            //            on c.Id equals p.CategoryId
            //            group c by new { c.Id, c.Title, c.Content } into g
            //            select new CategoryViewModel
            //            {
            //                Id = g.Key.Id,
            //                Content = g.Key.Content,
            //                Title = g.Key.Title,
            //                Posts = g.Select(p => new PostViewModel
            //                {
            //                    Title = p.Title,
            //                    Id = p.Id
            //                }).ToList()
            //            };

            //var categoryPosts = query.ToList();

        }  

        public List<CategoryViewModel> GetListCategory2() //2 query
        {
            BlogDbContext db = new BlogDbContext();

            //list categories => ram
            var categories = db.Categories.Select(c => new CategoryViewModel
            {
                Id = c.Id,
                Content = c.Content,
                Title = c.Title
            }).ToList(); ///sql profiler 1 query

            var categoryIds = categories.Select(c => c.Id).ToList(); //category ids

            var posts = db.Posts.Where(c => categoryIds.Contains(c.Id)) //1 query
                .Select(p => new PostViewModel
                {
                    Id=p.Id,
                    Title=p.Title,
                    CategoryId = p.CategoryId
                })
                .ToList(); //Posts thuộc list categoryid => RAM

            foreach(var category in categories) //RAM
            {
                category.Posts = posts.Where(p => p.CategoryId == category.Id).ToList();
            }    

            return categories;
        }

        public List<CategoryViewModel> GetListCategory1()
        {
            BlogDbContext db = new BlogDbContext();

            var query = from c in db.Categories
                        join p in db.Posts
                        on c.Id equals p.CategoryId
                        group c by new { c.Id, c.Title, c.Content } into g
                        select new CategoryViewModel
                        {
                            Id = g.Key.Id,
                            Content = g.Key.Content,
                            Title = g.Key.Title,
                            Posts = g.Select(p => new PostViewModel
                            {
                                Title = p.Title,
                                Id = p.Id
                            }).ToList()
                        };

            var categoryPosts = query.ToList();

            return categoryPosts;
        }


        public List<Category> GetListCategoryPostEagerLoading()
        {
            BlogDbContext db = new BlogDbContext();
            var result = db.Categories.Include(p => p.Posts);
           
            return result.ToList();

        }
        
    }
}
