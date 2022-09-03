// See https://aka.ms/new-console-template for more information
using EntityFrameworkCodeFirst.Models;
using Microsoft.EntityFrameworkCore;

Console.WriteLine("==============Entity framework core code first=========");

var dbcontext = new EmployeeManageDbContext();

//Explicic loading
var department = dbcontext.Departments.FirstOrDefault();

var employees = dbcontext.Entry(department).Collection(d => d.Employees)
    .Query()
    .ToList();

//var employees = department?.FirstOrDefault()?.Employees; //load


//var department = dbcontext.Departments.Include(d => d.Employees)
//    .FirstOrDefault(); //1 query

//if(department != null)
//{
//    var employees = dbcontext.Employees.Where(e => e.DepartmentId == department.Id)
//        .ToList(); //1 câu query
//}    

//2 query

//Join Departments vs Employee

//var employees = dbcontext.Employees.Where(x => x.Age == 18).ToList();

//SELECT [e].[Id], [e].[Age], [e].[CreatedDate], [e].[DepartmentId], [e].[EmpCode], [e].[FristName], [e].[LastName], [e].[UpdatedDate]
//FROM[Employees] AS[e]

//Linq to entities

//SQL Profiler

//foreach (var employee in employees)
//{
//    Console.WriteLine($"{employee.FristName} {employee.LastName}");
//}    

Console.ReadLine();

/*
   Code c# object => generate database (code frist)
   App: EmployeeManagement

   Employee (nhân viên)

   Department (phòng ban)

   Relationship - mối quan hệ giữa 2 table
   1 Employee 1 Department
   1 Department - n Employee

    Code frist quản lý thay đổi database bằng code c#

    thay đổi dbcontext, dbset, data type, add, update, delete column...

    => migration mới => update-database cập nhật thay đổi vào database trong sql server
 */



