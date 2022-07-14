// See https://aka.ms/new-console-template for more information
Console.WriteLine("=====================Array==================");

//string[] cars;
//------------index 0       1       2       3
string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
int[] myNumbers = { 10, 20, 30, 40 };

Console.WriteLine(cars[0]); //index = 0
Console.WriteLine(cars[3]); //index = 3

cars[0] = "Opel";
Console.WriteLine($"New value at index zero: {cars[0]}");

Console.WriteLine($"Length: {cars.Length}"); //4

for(var index = 0; index < cars.Length; index++)
{
    Console.WriteLine($"{index} - {cars[index]}");
}

foreach (string car in cars)
{
    Console.WriteLine(car);
}

Console.ReadLine();
