using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;
using WebApplicationMVC.Models;
using WebApplicationMVC.Services;

namespace UnitTest
{
    [TestClass]
    public class CategoryUnitTest
    {
        [TestMethod]
        public async Task GetAllCategoriesAsync()
        {
            var options = new DbContextOptionsBuilder<BlogDBContext>()
            .UseInMemoryDatabase(databaseName: "Blog")
            .Options;

            using (var context = new BlogDBContext(options))
            {
                context.Category.Add(new Category
                {
                    Id = 1,
                    Content = "content 1",
                    Title = "Title 1",
                    CreateUserId = 1,
                    CreateDate = new System.DateTime(2022, 10, 4)
                });

                context.Category.Add(new Category
                {
                    Id = 2,
                    Content = "content 2",
                    Title = "Title 2",
                    CreateUserId = 2,
                    CreateDate = new System.DateTime(2022, 10, 4)
                });

                await context.SaveChangesAsync();
            }

            using (var context = new BlogDBContext(options))
            {
                CategoryService categoryService = new CategoryService(context);
                var categories = await categoryService.GetAllCategories();

                Assert.AreEqual(2, categories.Count);
            }
        }

        [TestMethod]
        public void TestProtectedTest()
        {
            var options = new DbContextOptionsBuilder<BlogDBContext>()
           .UseInMemoryDatabase(databaseName: "Blog")
           .Options;

            using (var context = new BlogDBContext(options))
            {
                CategoryService categoryService = new CategoryService(context);
                //categoryService.TestProtected();
                var type = categoryService.GetType();
                var mi = type.GetMethod("TestProtected", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
                Assert.IsNotNull(mi);
            }
        }
    }
}