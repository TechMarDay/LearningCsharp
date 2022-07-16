using ProjectOOP;
using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOOP
{
    public class Intern : Employee, ISendMail, IFunction
    {
        public string Majors { get; set; }
        public int Semester { get; set; }
        public string NameSchool { get; set; }

        public override void GetInformation()
        {
            Console.WriteLine($"Mã nhân viên:" + ID + "\n"
                + "Họ và tên:" + FirstName + " " + Name + "\n"
                + "Tuổi:" + Age + "\n"
                + "Số điện thoại:" + PhoneNumber + "\n"
                + "Email:" + Email + "\n"
                + "Chuyên ngành:" + Majors + "\n"
                + "Học kì:" + Semester + "\n"
                + "Tên trường:" + NameSchool + "\n");
        }

        public void SendEmail(string mailFrom, string mailTo, string title, string content)
        {
            Console.WriteLine($"Mail: Send important mail from {mailFrom} to {mailTo} with {title} and {content}");
        }
    }
}
