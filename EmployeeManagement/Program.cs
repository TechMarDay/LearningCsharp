// See https://aka.ms/new-console-template for more information
using EmployeeManagement.RegularClass;
using System.Collections.Generic;

Console.OutputEncoding = System.Text.Encoding.UTF8;

Console.WriteLine("=============================================");

Developer dev = new Developer
{
    EmpCode = "TonyStark",
    FristName = "Tony",
    LastName = "Stark",
    DevSkills = new List<string> { "HTML", "CSSS", "JS", "C#" }
};

dev.GetFullName();
dev.GetTasks();
dev.GetEmployeeSkills();
dev.SendImportantMail("Tony Stark", "HR deparment", "Leave request mail", string.Empty);
dev.ExportPdfReport();
dev.ExportExcelReport();

Console.WriteLine("=============================================");

Tester tester = new Tester
{
    EmpCode = "PeterParker",
    FristName = "Peter",
    LastName = "Parker",
    TesterSkills = new List<string> { "Automation testing", "Performance testing" }
};
tester.GetFullName();
tester.GetTasks();
tester.GetEmployeeSkills();
tester.SendRegularMail("Tony Stark", "HR deparment", "Leave request mail", string.Empty);
tester.ExportExcelReport();

Console.ReadLine();

//Câu thần chú Abstraction - Ẩn chi tiết, thể hiện tổng quan.

//Abstract class sử dụng như một lớp cha có chứa các thuộc tính và phương thức chung. (các phương
//thức này có thể được thực hiện hoặc không (ẩn chi tiết, thể hiện tổng quan) - chỉ phần khai báo.
//Mối quan hệ giữa abstract và class con là mối quan hệ cha con is-a

//interface hiểu như là một bản thiết kế chứa các chức năng. Nhìn vào đó ta có thể biết được 
//Chức năng đó làm gì, có kiểu trả về, tham số của hành động ra sao.
//Mỗi quan hệ giữa interface và class sử dụng nó là mối quan hệ has-a



