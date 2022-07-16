// See https://aka.ms/new-console-template for more information
using System.Collections;

Console.WriteLine("===================Collection====================");

Console.WriteLine("===================1. ArrayList ====================");

ArrayList arrayList1 = new ArrayList();
ArrayList arrayList2 = new ArrayList();
arrayList1.Add("Item 1");
arrayList1.Add("Item 2");
arrayList1.Add("Item 3");
arrayList1.Add("Item 4"); //Item 1, Item 2, Item 3, Item 4

//arrayList2.Add("Item ArrayList 2"); //Item ArrayList 2
//arrayList1.AddRange(arrayList2); // Item 1, Item 2, Item 3, Item 4, Item ArrayList 2

//arrayList1.Insert(2, "New Item"); // Item 1, Item 2, "New Item" ,Item 3, Item 4, Item ArrayList 2

//for (var i = 0; i < arrayList1.Count; i++)
//{
//    Console.WriteLine(arrayList1[i]);
//}

//Clone(): tạo bản sao cho ArrayList
ArrayList arrayList3 = (ArrayList)arrayList1.Clone(); 
//tham chiếu (reference type)
arrayList3[0] = "Item 1 updated";


Console.WriteLine(arrayList1[0]); //Item 1




Console.WriteLine("===================2. HashTable ====================");
Hashtable hashtable = new Hashtable();
hashtable.Add("Key1", "Value1");
hashtable.Add("Key2", "Value2");
hashtable.Add("Key3", "Value3");
hashtable.Add("Key4", "Value4");
Console.WriteLine(hashtable["Key1"]);


foreach (DictionaryEntry item in hashtable)
{
    Console.WriteLine("Key: {0} - Value: {1}", item.Key, item.Value);
}


foreach (var key in hashtable.Keys)
{
    Console.WriteLine("Key: {0} ", key);
}

foreach (var value in hashtable.Values)
{
    Console.WriteLine("Value: {0} ", value);
}


//bảng xếp hạng
Console.WriteLine("===================3. Sorted List ====================");

SortedList ranking = new SortedList();
ranking.Add("4", "Peter");
ranking.Add("3", "Tony stark");
ranking.Add("5", "Tom");

for (int i = 0; i < ranking.Count; i++)
{
    Console.WriteLine("\t{0}:\t{1}", ranking.GetKey(i), ranking.GetByIndex(i));
}

Console.WriteLine("===================4. Stack ====================");
Stack myStack = new Stack();
myStack.Push("Hello");
myStack.Push("World");
myStack.Push("!");
// Displays the properties and values of the Stack.
Console.WriteLine("myStack");
Console.WriteLine("\tCount: {0}", myStack.Count);
Console.Write("\tValues:");
foreach (Object obj in myStack)
    Console.Write(" {0}", obj);


Console.WriteLine("===================5. Queue ====================");
// Creates and initializes a new Queue.
Queue myQ = new Queue();
myQ.Enqueue("Hello");
myQ.Enqueue("World");
myQ.Enqueue("!");
// Displays the properties and values of the Queue.
Console.WriteLine("myQ");
Console.WriteLine("\tCount: {0}", myQ.Count);
Console.Write("\tValues:");
foreach (Object obj in myQ)
    Console.Write(" {0}", obj);

Console.WriteLine("===================6. List ====================");
List<int> list1 = new List<int>();
list1.Add(1);
//list1.Add("Pony"); //<-- Error at compile process
int total = 0;
foreach (int num in list1)
{
    total += num;
}

Console.ReadLine();