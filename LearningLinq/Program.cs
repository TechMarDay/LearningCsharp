// See https://aka.ms/new-console-template for more information
using LearningLinq;

/*
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
*/
//var str = "0010111"; //Chuỗi string => gồm nhiều ký tự (char)
//var strList = str.ToCharArray();

//foreach (var item in strList)
//{
//    if (item == '1')
//        Console.WriteLine(item);
//}

//for, foreach, while... (loop) danh sách (list, array, arrayList,...)

//Thuật toán
//String, Array, List...


//Nhập số: 214543675
//Output: array [2, 1, 4, 5...]

//var number = 214543675;
//var numberStr = number.ToString(); //char -> int '1' => 1 '2' => 2
//var numberStrList = numberStr.ToCharArray().Select(x => Convert.ToInt32(new string(x, 1))).ToArray();
//foreach (var item in numberStrList)
//{
//    Console.WriteLine(item);
//}

//139 [1, 3, 9]
//1
//3
//9

//139/10 = 13 dư 9 
//13/10 = 1 dư 3
//1/10 =  0 dư 1

//Số lần chia: 3
//Đếm số chữ số
var number = 214543675;
var length = number.ToString().Length; //3

var arr = new int[length]; //3 items

var lst = new List<int>();
lst.Sort(); //buble, quick sort, seleciton, insertion sort...

//0 -> length -1
//Length - 1 -> 0
for (var index = length - 1; index >= 0; index--)
{
    var item = number % 10;
    arr[index] = item;

    number = number / 10;
}

foreach (var item in arr)
{
    Console.WriteLine(item);
}




Console.ReadLine();

