using System;
using System.Collections.Generic;

namespace EFCoreDBFirstExcercise.Models
{
    public partial class TblUser
    {
        public long Id { get; set; }
        public string? Name { get; set; }
        public string? Phone { get; set; }
        public string? Email { get; set; }
        public string? Pass { get; set; }
    }
}
