using System;
using System.Collections.Generic;

namespace EntityDatabaseFirst.Models
{
    public partial class TblUser
    {
        public TblUser()
        {
            TblPosts = new HashSet<TblPost>();
        }

        public long Id { get; set; }
        public string? Name { get; set; }
        public string? Phone { get; set; }
        public string? Email { get; set; }
        public string? Pass { get; set; }

        public virtual ICollection<TblPost> TblPosts { get; set; }
    }
}
