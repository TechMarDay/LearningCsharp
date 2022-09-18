using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkCoreCodeFirst.ViewModels
{
    public class CategoryViewModel
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string? Content { get; set; }

        public int CategoryId { get; set; }

        public virtual List<PostViewModel> Posts { get; set; }
    }

    public class PostViewModel
    {
        public int Id { get; set; }

        public int CategoryId { get; set; }

        public string Title { get; set; }
    }
}
