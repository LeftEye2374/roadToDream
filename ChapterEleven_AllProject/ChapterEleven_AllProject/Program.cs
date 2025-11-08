using System;
using Chap;


static void UseGenericListOfPeople()
{
    List<Person> myPeople = new List<Person>();
    myPeople.Add(new Person("Misha","Borissov",21));
    myPeople.Add(new Person("Sasha","Skibel",20));

    myPeople[0] = new Person("Sonya", "Borissova", 18);

    for (int i = 0; i < myPeople.Count; i++)
    {
        Console.WriteLine("Person number: {0}",i);
        Console.WriteLine("Name: {0} {1}", myPeople[i].FirstName, myPeople[i].LastName);
        Console.WriteLine("Age: {0}", myPeople[i].Age);
        Console.WriteLine();
    }
}