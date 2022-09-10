using System;
using System.Collections.Generic;

namespace EntityDatabaseFirst.EntityModels
{
    public partial class Category
    {
        public Category()
        {
            Posts = new HashSet<Post>();
        }

        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public string? Content { get; set; }
        public int CreateUserId { get; set; }
        public DateTime CreateDate { get; set; }
        public int? UpdateUserId { get; set; }
        public DateTime? UpdateDate { get; set; }

        public virtual ICollection<Post> Posts { get; set; }
    }
}
