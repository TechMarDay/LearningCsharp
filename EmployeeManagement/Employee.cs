using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement
{
    public class Employee
    {
        public string EmpCode { get; set; }
        public string FirstName { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string GetFullName()
        {
            return $"{FirstName} {Name}";
        }
        public virtual string GetInterfor()
        {
            return $"{EmpCode} {Name}{FirstName} {Age}{PhoneNumber} {Email}";
        }
        public virtual string SendMail(string mailFrom, string mailTo, string mailCC,
           string title, string content)
        {
            return (@$"Developer send mail from {mailFrom} to {mailTo}
                    and cc to {mailCC} with title {title} and content {content}");
        }

    }
}
