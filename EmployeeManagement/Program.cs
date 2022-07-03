// See https://aka.ms/new-console-template for more information
using System.Collections.Generic;

Console.OutputEncoding = System.Text.Encoding.UTF8;

EmployeeManagement.Employee employee = new EmployeeManagement.Employee();
employee.FirstName = "Nguyễn";
employee.Name = "Long";
employee.GetFullName();
Console.WriteLine(employee.GetFullName());

EmployeeManagement.EmployeeExperience employeeExperience = new EmployeeManagement.EmployeeExperience();
employeeExperience.FirstName = "Nguyễn";
employeeExperience.Name = "Linh";
employeeExperience.Age = 21;
employeeExperience.PhoneNumber = "0359698197";
employeeExperience.EmpCode = "M001";
employeeExperience.Email = "nguyenlinh@1123";
employeeExperience.ExperienceYear = 3;
employeeExperience.Skills = new List<string>();
employeeExperience.Skills.Add("HTML");
employeeExperience.Skills.Add("CSS");
employeeExperience.Skills.Add("JAVASCRIPT");
Console.WriteLine(employeeExperience.GetInterfor());

Console.WriteLine("-----------------------------");
EmployeeManagement.EmployeeFresher employeeFresher = new EmployeeManagement.EmployeeFresher();
employeeFresher.FirstName = "Nguyễn";
employeeFresher.Name = "Minh";
employeeFresher.Age = 28;
employeeFresher.PhoneNumber = "0359698190";
employeeFresher.EmpCode = "M005";
employeeFresher.Email = "nguyenMinh@123456";

employeeFresher.GraduationTime = "12/04/2019";
employeeFresher.GraduationType = "Khá";
employeeFresher.GraduationChool = "Bách Khoa Hà Nội";

string sendEmail = employeeFresher.SendMail(employeeFresher.Name, employeeExperience.Name, employeeFresher.GraduationChool, "Quá trình tốt nghiệp", employeeFresher.GraduationType);
Console.WriteLine(employeeFresher.GetInterfor());
Console.WriteLine(sendEmail);




Console.ReadLine();

