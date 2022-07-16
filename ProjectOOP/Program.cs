using System;
using System.Collections.Generic;
using System.Text;



namespace ObjectOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Experience ex = new Experience();
            ex.ID = "M001";
            ex.FirstName = "Nguyễn";
            ex.Name = "Long";
            ex.PhoneNumber = "0123456789";
            ex.Age = 25;
            ex.ExprienceYear = 2;
            ex.Email = "nguyenlong@gmail.com";
            ex.Skills = new List<string> { "học", "ăn", "ngủ" };
            ex.GetName();

            ex.GetInformation();

            ex.SendEmail("Hà Nội", "Hồ Chí Minh", "Giải Phóng", "Đất nước được giải phóng");

            Console.WriteLine("===========================================");

            Fresher fresher = new Fresher();
            fresher.ID = "M004";
            fresher.FirstName = "Tạ";
            fresher.Name = "Tốn";
            fresher.Age = 25;
            fresher.PhoneNumber = "0869816789";
            fresher.GraduationType = "Khá";
            fresher.Email = "Ton@gmail.com";
            fresher.GraduationTime = DateTime.Now;
            fresher.GraduationSchool = "Giao thông hà nội";
            fresher.GetName();

            fresher.GetInformation();

            Console.WriteLine("===========================================");

            Intern intern = new Intern();
            intern.ID = "M004";
            intern.FirstName = "Diệp";
            intern.Name = "Vấn";
            intern.Age = 25;
            intern.PhoneNumber = "0869123456";
            intern.Majors = "IT";
            intern.Email = "vanvanvo@gmail.com";
            intern.NameSchool = "Công nghệ";
            intern.Semester = 8;
            intern.GetName();
            Console.WriteLine("===========================================");
            intern.GetInformation();



            Console.ReadLine();
        }
    }
}