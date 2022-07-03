using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement
{
    public class EmployeeExperience: Employee
    {
      
        public int ExperienceYear { get; set; }
        public List<string>Skills { get; set; }
        public override string GetInterfor()
        {
            return $"Mã nhân viên là: {EmpCode}" +"\n"+
               $"Họ tên: {FirstName} {Name} " + "\n" +
               $"Tuổi: {Age}" + "\n" +
               $"Số điện thoại: {PhoneNumber} " + "\n" +
               $"Email: {Email}" + "\n" +
               $"Số năm kinh nghiệm: {ExperienceYear} " + "\n" +
               $"Kỹ năng:{string.Join(", ", Skills)} ";
        }
    }
}
