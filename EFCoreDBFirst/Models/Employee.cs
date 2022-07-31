using System;
using System.Collections.Generic;

namespace EFCoreDBFirst.Models
{
    public partial class Employee
    {
        public string? EmpCode { get; set; }
        public string? Name { get; set; }
        public int? Age { get; set; } //? => nullable
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public bool? IsDelete { get; set; }
        public DateTime? DeletedDate { get; set; }
    }
}
