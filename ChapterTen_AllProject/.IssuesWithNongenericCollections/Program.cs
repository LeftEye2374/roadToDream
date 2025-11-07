using System;
using System.Collections;
using IssuesWithNonGenericCollections;

UsePersonCollection();
Console.ReadLine();

static void SimpleBoxUnboxOperation()
{
    int myInt = 25;
    object boxeInt = myInt;
    int unboxedInt = (int) boxeInt;
}

static void WorkWithArrayList()
{
    ArrayList myInts = new ArrayList();
    myInts.Add(10);
    myInts.Add(20);
    myInts.Add(35);
    int i = (int) myInts[0];
    Console.WriteLine(i);
}

static void UsePersonCollection()
{
    Console.WriteLine("Custom User Collection");
    PersonCollection myPeople = new PersonCollection();
    myPeople.AddPerson(new Person("Misha", "Borissov", 21));
    myPeople.AddPerson(new Person("Max", "Borissov", 29));
    myPeople.AddPerson(new Person("Natasha","Shap",24));
    myPeople.AddPerson(new Person("Sonya","Borissova",18));

    foreach(Person p in myPeople)
    {
        Console.WriteLine(p.ToString);
    }
}

