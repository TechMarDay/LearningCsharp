// See https://aka.ms/new-console-template for more information
using EFCoreDBFirst.Models;

Console.WriteLine("================Entity framework core - Database first");

//Lấy ra toàn bộ tên của nhân viên

//EmployeeManagementContext: Query lấy dữ liệu từ database
//var dbContext = new EmployeeManagementContext();
//var employeeNames = dbContext.Employees //Data source
//                    .Select(x => x.Name).ToList();

//Linq + EF Core => Linq to entites

//foreach(var name in employeeNames)
//{
//    Console.WriteLine(name);
//}


//Iqueryable và IEnumerable

//1.IEnumerable
//IEnumerable thuộc về namespace system.collections (list, arrayList, Hashtable, stack, queuee...)
//IEmuberable thực hiện truy vấn các collection trong bộ nhớ (RAM)


List<int> numbers = new List<int> { 1, 2, 4 }; //Ienumerable
var numberResult = numbers.Where(x => x == 2); //RAM - memmory
var numberResultList = numberResult.ToArray();//Array RAM-memmory


//2.Iqueryable
//Iqueryable thuộc namespace system.linq

//Iqueryable không thực hiện truy vấn trên RAM (out-memory) máy tính.
//Iqueryable thực hiện truy vấn trên sql server
var dbContext = new EmployeeManagementContext();
var employeeNames = dbContext.Employees //Data source 
                    .Where(x => x.Age > 10)
                    .Select(x => x.Name); //Xử lý trên sql server



//=> sql server: tạo ra query => thực thi.


//Sql server => RAM máy để tính toán, xử lý
var employeeNamesResult = employeeNames.ToList();

//ToList chuyển từ Iqueryable sang IEnumerable
//employeeNamesResult: lưu ở RAM

//employeeNamesResult linq


//1000 items trong database

//List = dbContext.Employees.ToList(); RAM IEnumerable => load 1000 items lên RAM
//List linq where order


//dbContext.Employees Iqueryable where order => xử lý query 1000 items với conditons ở trên
//sql server

//.ToList() => RAM => Dữ liệu RAM ít 


//Paging - phân trang
//1000 items => phân trang mỗi page 100 items => 10 pages

//1000 items => RAM => Skip, take phân trang

//100 items => iqueryable skip take //sql server

//Iqueryable skip(100).take(100) page 2 => Iqueryable.ToList() 100RAM


Console.ReadLine();
