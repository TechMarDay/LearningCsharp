using ProjectOOP;
using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOOP
{
    public class Fresher : Employee, IFunction, ISendMail
    {
        public DateTime GraduationTime { get; set; }
        public string GraduationType { get; set; }
        public string GraduationSchool { get; set; }

        public override void GetInformation()
        {
            Console.WriteLine($"Mã nhân viên:" + ID + "\n"
                + "Họ và tên:" + FirstName + " " + Name + "\n"
                + "Tuổi:" + Age + "\n"
                + "Số điện thoại:" + PhoneNumber + "\n"
                + "Email:" + Email + "\n"
                + "Thời gian tốt nghiệp:" + GraduationTime + "\n"
                + "Tốt nghiệp loại:" + GraduationType + "\n"
                + "Tốt nghiệp trường:" + GraduationSchool + "\n");
        }

        public void SendEmail(string mailFrom, string mailTo, string title, string content)
        {
            Console.WriteLine($"Mail: Send important mail from {mailFrom} to {mailTo} with {title} and {content}");
        }
    }
}