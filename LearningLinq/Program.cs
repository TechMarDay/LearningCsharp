// See https://aka.ms/new-console-template for more information
using LearningLinq;

Console.WriteLine("=====================LINQ===================");

var productIds = new int[6] { 3, 5, 2, 1, 9, 10 };

var productEvenIds = from productId in productIds
                     where productId % 2 == 0
                     select productId;

Console.WriteLine("=====================Query syntax===================");

foreach (var productEven in productEvenIds)
{
    Console.WriteLine($"{productEven}");
}


Console.WriteLine("=====================Method syntax===================");

var productEven2Ids = productIds.Where(x => x % 2 == 0)
    .Select(x => x);
foreach (var productEven in productEven2Ids)
{
    Console.WriteLine($"{productEven}");
}

var products = new List<Product>
{
    new Product {Id = 1, Name = "Mazda"},
    new Product {Id = 2, Name = "Honda city"},
    new Product {Id =3, Name = "Kia Morning"}
};

//lấy ra product name với id = 2

var productName = products.Where(x => x.Id == 2)
    .Select(x => x.Name).FirstOrDefault();

Console.WriteLine($"Lambda expression example: {productName}");


Console.WriteLine("========Tạo ra 1 object mới trong Select========");
var employeeList = new List<Employee>
{
    new Employee{EmpCode = "E01", FirstName = "Peter", LastName = "Parker"},
    new Employee{EmpCode = "E02", FirstName = "Tony", LastName = "Stark"},
    new Employee{EmpCode = "E03", FirstName = "Paul", LastName = "Ruu"},

};

var employees = employeeList
    //.Where(x => x.EmpCode == "E03")
    .Select(x => new 
    {
        FullName = x.FirstName + " " + x.LastName,
        EmpCode = x.EmpCode
    });

foreach (var employee in employees)
{
    Console.WriteLine($"{employee.FullName}");
}

Console.ReadLine();

