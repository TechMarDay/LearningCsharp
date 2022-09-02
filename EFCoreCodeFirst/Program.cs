using EFCoreCodeFirst.Models;
using Microsoft.EntityFrameworkCore;

var dbContext = new EmployeeManagementDbContext();

//var employees = dbContext.Employees.ToList();

//var deparment = dbContext.Departments
//    .Include(d => d.Employees).ToList();

//var employees = deparment?.FirstOrDefault()?.Employees?.ToList();

//foreach(var employee in employees)
//{
//    Console.WriteLine(employee?.Name);
//}

//var departments = dbContext.Departments.FirstOrDefault();

//var employees = dbContext.Entry(departments).Collection(s => s.Employees)
//    .Query()
//    .ToList();


Console.ReadLine();