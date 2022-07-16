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

arrayList2.Add("Item ArrayList 2"); //Item ArrayList 2
arrayList1.AddRange(arrayList2); // Item 1, Item 2, Item 3, Item 4, Item ArrayList 2

arrayList1.Insert(2, "New Item"); // Item 1, Item 2, "New Item" ,Item 3, Item 4, Item ArrayList 2

for (var i = 0; i < arrayList1.Count; i++)
{
    Console.WriteLine(arrayList1[i]);
}

Console.WriteLine("===================2. HashTable ====================");
Hashtable hashtable = new Hashtable();
hashtable.Add("Key1", "Value1");
hashtable.Add("Key2", "Value2");
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

Console.ReadLine();