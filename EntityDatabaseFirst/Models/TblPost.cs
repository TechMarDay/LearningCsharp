using System;
using System.Collections.Generic;

namespace EntityDatabaseFirst.Models
{
    public partial class TblPost
    {
        public long Id { get; set; }
        public long? IdUser { get; set; }
        public long? IdCategory { get; set; }
        public string? Title { get; set; }
        public string? Content { get; set; }
        public DateTime? CreatTime { get; set; }
        public DateTime? UpdateTime { get; set; }

        public virtual TblUser? IdUserNavigation { get; set; }
        public virtual TblCategory TblCategory { get; set; } = null!;
    }
    
}
