using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityFrameworkCodeFirst.Models
{
    [Table("DepartmentEmployee")]
    public class Department
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(100)]
        public string Name { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime? UpdatedDate { get; set; }

        //virtual khi class con kế thừa class cha.
        //Class con có thể override thuộc tính, phương thức virtual

        public virtual List<Employee> Employees { get; set; }
    }
}
