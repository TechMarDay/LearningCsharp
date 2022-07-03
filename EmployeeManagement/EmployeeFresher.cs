using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement
{
    public class EmployeeFresher: Employee
    {
         public string GraduationTime { get; set; }
         public string GraduationType { get; set; }
         public string GraduationChool { get; set; }
        public override string GetInterfor()
        {
            return $"Mã nhân viên là: {EmpCode}" + "\n" +
                $"Họ tên: {FirstName} {Name} " + "\n" +
                $"Tuổi: {Age}" + "\n" +
                $"Số điện thoại: {PhoneNumber} " + "\n" +
                $"Email: {Email}" + "\n" +
                $"Thời gian tốt nghiệp: {GraduationTime} " + "\n" +
                $"Tốt nghiệp loai: {GraduationType} " + "\n" +
                $"Trường học: {GraduationChool}";
        }
       
    }
}
