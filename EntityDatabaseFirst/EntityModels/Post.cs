using System;
using System.Collections.Generic;

namespace EntityDatabaseFirst.EntityModels
{
    public partial class Post
    {
        public int Id { get; set; }
        public int CreateUserId { get; set; }
        public int CategoryId { get; set; }
        public string Title { get; set; } = null!;
        public string? Content { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public int? UpdateUserId { get; set; }

        public virtual Category Category { get; set; } = null!;
        public virtual User CreateUser { get; set; } = null!;
    }
}
