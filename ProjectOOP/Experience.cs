using ProjectOOP;
using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOOP
{
    public class Experience : Employee, IFunction, ISendMail
    {
        public int ExprienceYear { get; set; }
        public List<string> Skills { get; set; }

        public override void GetInformation()
        {
            Console.WriteLine($"Mã nhân viên:" + ID + "\n"
                + "Họ và tên:" + FirstName + " " + Name + "\n"
                + "Tuổi:" + Age + "\n"
                + "Số điện thoại:" + PhoneNumber + "\n"
                + "Email:" + Email + "\n"
                + "Số năm kinh nghiệm:" + ExprienceYear + "\n"
                + "Kỹ năng chuyên môn:" + string.Join(",", Skills) + "\n");
        }

        public void SendEmail(string mailFrom, string mailTo, string title, string content)
        {
            Console.WriteLine($"Mail: Send important mail from {mailFrom} to {mailTo} with {title} and {content}");
        }
    }
}