using System.ComponentModel.DataAnnotations;

namespace EFCoreCodeFirst.Models
{
    public class Employee
    {
        [Key]
        public string? EmpCode { get; set; }
        public string? Name { get; set; }
        public int? Age { get; set; } //? => nullable
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public bool? IsDelete { get; set; }
        public DateTime? DeletedDate { get; set; }
        public int? DepartmentId { get; set; }
        public virtual Department? Department { get; set; }
    }
}
