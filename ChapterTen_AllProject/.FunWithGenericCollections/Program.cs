using System;
using System.Collections.Generic;
using FunWithGenericCollections;

UseGenericList();
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