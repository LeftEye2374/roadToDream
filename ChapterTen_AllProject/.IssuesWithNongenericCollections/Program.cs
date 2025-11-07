using System;
using System.Collections;
using IssuesWithNonGenericCollections;
using System.Collections.Generic;


int[] myInts = { 10,4,2,33,93};
Array.Sort(myInts);
foreach (int i in myInts )
{
    Console.WriteLine(i);
}


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

static void UseGenericsList()
{
    Console.WriteLine("Fun With Generics");
    List<Person> morePeople = new List<Person>();
    morePeople.Add(new Person("Jack","Pivo",21));
    Console.WriteLine(morePeople[0]);

    List<int> moreInts = new List<int>();
    moreInts.Add(10);
    moreInts.Add(20);

    // int sum = moreInts[1] + morePeople[0];
    //Ошибка на этапе компиляции
    // moreInts.Add(new Person ...) не может быть добавлена
}

