using System;
using System.Collections.Generic;
using FunWithGenericCollections;

UseGenericStack();
Console.ReadLine();

static void UseGenericList()
{
    List<Person> people = new List<Person>()
    {
        new Person("Misha","Borissov",21),
        new Person("Roma", "Bainazarov", 24),
        new Person("Sasha","Skibel",20),
        new Person("Sonya", "Samoylenko", 18)
    };
    Console.WriteLine("Items in list: {0}",people.Count);
    foreach (Person p in people )
    {
        Console.WriteLine(p);
    }

    Console.WriteLine("\n -> Inserting new person.");
    people.Insert(2, new Person
    {
        FirstName = "Misha",LastName = "Kashanin",Age = 22 });
    Console.WriteLine("Peoples in list: {0}", people.Count);
    
    
    Person[] arrayOnPeople = people.ToArray();
    foreach (Person p in arrayOnPeople)
    {
        Console.WriteLine("First Names: {0}", p.FirstName);
    }
}

static void UseGenericStack()
{
    Console.WriteLine("Use Genericis Stack");
    Stack<Person> stackOfPeople = new();
    stackOfPeople.Push(new Person
    {
        FirstName = "Misha",
        LastName = "Borissov", Age = 22
    });
    stackOfPeople.Push(new Person
    {
        FirstName = "Roma",
        LastName = "Bainazarov", Age = 24
    });
    stackOfPeople.Push( new Person
    {
        FirstName = "Sasha",
        LastName = "Skibel",
        Age = 20
    });
    Console.WriteLine("Firs person is : {0} ", stackOfPeople.Peek());
    Console.WriteLine("Pooped off {0}", stackOfPeople.Pop());
    Console.WriteLine("\nFirst person is: {0}",  stackOfPeople.Peek());
    Console.WriteLine("Pooped off {0}", stackOfPeople.Pop());
    Console.WriteLine("\nFirst person item is: {0}",  stackOfPeople.Peek());
    Console.WriteLine("Pooped off {0}", stackOfPeople.Pop());
    try
    {
        Console.WriteLine("\nFirst person is: {0}", stackOfPeople.Peek());
        Console.WriteLine("Pooped off {0}", stackOfPeople.Pop());
    }
    catch (InvalidOperationException e)
    {
        Console.WriteLine("Error! {0}", e.Message);
    }
}