
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityFrameworkCodeFirst.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(20)]
        public string EmpCode { get; set; }

        [MaxLength(50)]
        public string FristName { get; set; }

        [MaxLength(50)]
        public string LastName { get; set; }


        public int Age { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime? UpdatedDate { get; set; }

        //[ForeignKey("DepartmentEmployee")]
        public int DepartmentId { get; set; }

        public virtual Department? Department { get; set; }
    }

    //Query data thông tin department từ employee => employee.Department 

    //Table department query dựa DepartmentId
}
