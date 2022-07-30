// See https://aka.ms/new-console-template for more information
using GenericLearning;

Console.WriteLine("===========================Generic==============================");



int SumInterger(int a, int b)
{
    return a + b;
}

double SumDouble(double a, double b)
{
    return a + b;
}

var sum1 = SumInterger(1, 2);
var sum2 = SumDouble(1.2, 3.4);


//Generic flexible - linh động, clear - gọn gòn, reusedable - tái sử dụng
T Sum<T>(T a, T b)
{
    dynamic dx = a;
    dynamic dy = b;
    return dx + dy;
}

//var sum3 = Sum<int>(1, 2);
//var sum4 = Sum<double>(1.2, 3.4);
//var sum5 = Sum<string>("1", "2");

//Console.WriteLine(sum3);
//Console.WriteLine(sum4);
//Console.WriteLine(sum5);

//Class generic => flexible, clear, reuseable
var printer = new Printer<int>(200);
printer.Print();
var printer1 = new Printer<string>("Hello");
printer1.Print();




Console.ReadLine();
