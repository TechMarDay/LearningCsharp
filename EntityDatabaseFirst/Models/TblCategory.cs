using System;
using System.Collections.Generic;

namespace EntityDatabaseFirst.Models
{
    public partial class TblCategory
    {
        public long Id { get; set; }
        public string? Title { get; set; }
        public string? Content { get; set; }

        public virtual TblPost IdNavigation { get; set; } = null!;
    }
    
}
