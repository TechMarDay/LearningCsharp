using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement
{
    public class EmployeeIntern: Employee
    {
        public string Majors { get; set; }
        public int Semester { get; set; }
        public string NameChool { get; set; }
        public override string GetInterfor()
        {
            return $"Mã nhân viên là: {EmpCode}" + "\n" +
                $"Họ tên: {FirstName} {Name} " + "\n" +
                $"Tuổi :{Age}" + "\n" +
                $"Số điện thoại: {PhoneNumber} " + "\n" +
                $"Email: {Email}" + "\n" +
                $"Chuyên ngành: {Majors} " + "\n" +
                $"Học kì: {Semester} " + "\n" +
                $"Tên trường: {NameChool}";
        }
      
    }
}
