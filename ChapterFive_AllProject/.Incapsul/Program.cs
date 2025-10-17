using System;
using Incapsul;

Console.WriteLine("Fun with incapsulation");
Employee emp = new Employee("Marvin", 456, 30000);
Console.WriteLine(emp.Id.ToString());
Console.ReadLine();