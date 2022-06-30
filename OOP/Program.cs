// See https://aka.ms/new-console-template for more information
using OOP;

Console.WriteLine("Hello, World!-----");


var newEmployee = new Employee();
newEmployee.Empcode = "EMP01";
newEmployee.FristName = "Long";
newEmployee.LastName = "Nguyen";
newEmployee.Age = 18;

var fullName = newEmployee.GetFullName();

Console.WriteLine($"Full Name: {fullName}");
Console.WriteLine($"Age: {newEmployee.Age}");

//newEmployee là 1 object - 1 instance của class Employee;


Console.WriteLine("-----------Inheritance-Ke thua----------------");
var developer = new Developer();
developer.Empcode = "dev01";
developer.FristName = "Huy";
developer.LastName = "Nguyen";

var devFullName = developer.GetFullName(); //GetFullName method of employeee

Console.WriteLine($"Dev Full Name: {devFullName}");
Console.WriteLine($"Empcode: {developer.Empcode}");
Console.WriteLine($"Dev tasks: {developer.GetTasks()}");

Console.WriteLine("-----------Polymophism-Đa hình----------------");
Console.WriteLine("-----------Polymophism-Đa hình Overriding----------------");
var tester = new Tester();
Console.WriteLine($"Tester tasks: {tester.GetTasks()}");

Console.WriteLine("-----------Polymophism-Đa hình Overloading----------------");
developer.SendMail("Long", "Huy", "Interview Invitation ", "Test content");

developer.SendMail("Long", "Huy", "Tam","Interview Invitation ", "Test content");

//developer.SendMail("Long", "Huy", "Interview Invitation ", "Test content", true);
developer.SendMail("Long", "Huy", "Interview Invitation ", "Test content", 1);






Console.ReadLine();