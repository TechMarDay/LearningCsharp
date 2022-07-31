// See https://aka.ms/new-console-template for more information
using LinqLearning;

Console.WriteLine("========================Language Integrated Query===================");


var employeeList = new List<Employee>();

employeeList.Add(new Employee
{
    EmpCode = 1,
    Name = "Tony Stark",
    Age = 20,
    City = "Da Nang"
});

employeeList.Add(new Employee
{
    EmpCode = 2,
    Name = "Peter Parker",
    Age = 18,
    City = "Da Nang"
});

employeeList.Add(new Employee
{
    EmpCode = 3,
    Name = "John Dick",
    Age = 18,
    City = "HN"
});

employeeList.Add(new Employee
{
    EmpCode = 4,
    Name = "Messi",
    Age = 32,
    City = "HN"
});

#region example

//Lay ra danh sach nhan vien 18 tuoi
//var youngEmployeeList = new List<Employee>();
//foreach(var employee in employeeList)
//{
//    if (employee.Age == 18)
//        youngEmployeeList.Add(employee);
//}

//Linq query from data sources (collection: List))
//var youngEmployees = employeeList.Where(e => e.Age == 18).ToList();

//Linq ngan gon, don gian

//Iqueryable & IEnumerable

//Cach 1- way 1
//Query Syntax 
//Lay ra danh sach ma code cua nhan vien 18 tuoi
//var youngEmployeeList = from employee in employeeList
//                        where employee.Age == 18
//                        select employee.EmpCode;

//Console.WriteLine("========================Query Syntax===================");
//foreach (var employeeEmpcode in youngEmployeeList)
//{
//    Console.WriteLine(employeeEmpcode);
//}

//Method syntax
//Lay ra danh sach ma code cua nhan vien 18 tuoi
//var youngEmployees = employeeList.Where(e => e.Age == 18).Select(e => e.EmpCode);
//Console.WriteLine("========================Method syntax===================");
//foreach (var employeeEmpcode in youngEmployees)
//{
//    Console.WriteLine(employeeEmpcode);
//}

//e => e.Age == 18 lambda expression = function an danh (anonymous function)
//bool isThan18(int age)
//{
//    return age == 18;
//}

#endregion
//Console.WriteLine("========================Method All===================");
//All xác định tất cả phần tử thỏa một điều kiện hay không
//Kiem tra xem tat ca nhan vien o Da Nang hay khong?

//var isDNCity = employeeList.All(e => e.City == "Da Nang");

//if (isDNCity)
//    Console.WriteLine("All employees in Da Nang City");
//else
//    Console.WriteLine("All employees not in Da Nang City");


//Console.WriteLine("========================Method Any===================");
//Any xác định tồn tại bất kỳ phần tử thỏa một điều kiện cụ thể hay không
//var isAnyDNCity = employeeList.Any(e => e.City == "Da Nang");
//if (isAnyDNCity)
//    Console.WriteLine("Having employee in Da Nang City");
//else
//    Console.WriteLine("Not employees in Da Nang City");

Console.WriteLine("========================Method Frist===================");
//First() Lấy ra phần tử đầu tiên thỏa 1 điều kiện. Nếu không tìm thấy sẽ throw exception

//Egger/bad case
//var employee = employeeList.First(e => e.City == "HN");

Console.WriteLine("========================Method FirstOrDefault===================");
//FirstOrDefault() tương tự như First() trong trường hợp không có phần tử thỏa điều kiện sẽ trả về null
//cho kiểu tham chiếu và giá trị default cho kiểu tham trị.

//default int 0
//default string empty
//default object null
//...
//var employee2 = employeeList.Where(e => e.City == "HN").Select(e => e.Age).FirstOrDefault();
//Console.WriteLine(employee2); //if(employee2 != null) employee2.Name else null

Console.WriteLine("========================Method Single===================");
//Single() trả về một phần tử trong danh sách thỏa điều kiện. Nếu không có phần tử nào hoặc tìm thấy hơn 1
//phần tử sẽ throw exception
//var employee = employeeList.Single(e => e.City == "HN"); //single = duy nhat => 1 item
//Console.WriteLine(employee?.Name);


//SingleOrDefault() tương tự như Single() nhưng nếu không có phần tử nào sẽ trả về null cho kiểu tham chiếu và
//giá trị default cho kiểu tham trị. Throw exception nếu kết quả nhiều hơn 1 phần tử.
//Happy case : find only 1 item
//var employee = employeeList.SingleOrDefault(e => e.City == "Quang Binh");
//Console.WriteLine(employee?.Name);

Console.WriteLine("========================Method Skip, Take===================");
//Danh sach nhan vien => web => phan trang - paging 4 nhan vien
//=> 2 pages & 1 page having 2 employees


//Click page 1
var employeeListPage1 = employeeList.Take(2); //.Skip(0)

Console.WriteLine("Page 1");
foreach(var em in employeeListPage1)
{
    Console.WriteLine(em.Name);
}

//Click page 2

var employeeListPage2 = employeeList.Skip(2).Take(2);
Console.WriteLine("Page 2");
foreach (var em in employeeListPage2)
{
    Console.WriteLine(em.Name);
}

//IEnumerable làm việc trên Memory (RAM) 
//Iqueryable làm việc với query trên database
//Iqueryable vs IEnumerable



Console.ReadLine();
