using System;
using System.Collections;
using IssuesWithNonGenericCollections;
using System.Collections.Generic;

UseSortedSet();
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

static void UseGenericStack()
{
    Console.WriteLine("Fun with Stack");
    Stack<Person> stackPerson = new();
    stackPerson.Push(new Person()
    {
        FirstName = "Misha",
        LastName = "Borissov", Age = 21
    });
    stackPerson.Push(new Person()
    {
        FirstName = "Sasha",
        LastName = "Skibel", Age = 20
    });
    stackPerson.Push(new Person()
    {
        FirstName = "Sonya", 
        LastName = "Borissova", Age = 18
    });
    Console.WriteLine("First person is: {0}",stackPerson.Peek());
    Console.WriteLine("Popped off {0}", stackPerson.Pop());
    Console.WriteLine("\nFirst person is: {0}", stackPerson.Peek());
    Console.WriteLine("Popped off {0}", stackPerson.Pop());
    Console.WriteLine("\nFirst person is: {0}", stackPerson.Peek());
    Console.WriteLine("Popped off {0}", stackPerson.Pop());

    try
    {
        Console.WriteLine("First person is: {0}", stackPerson.Peek());
        Console.WriteLine("Popped off {0}", stackPerson.Pop());
    }
    catch (InvalidOperationException e)
    {
        Console.WriteLine("Error! {0}", e.Message);
    }
    // ????????????
}

static void UseGenericQueue()
{
    Console.WriteLine("Fun With Queue");
    Queue<Person> personQueue = new();
    personQueue.Enqueue(new Person()
    {
        FirstName = "Misha",
        LastName = "Borissov",Age = 21
    });
    personQueue.Enqueue(new Person()
    {
        FirstName = "Sasha",
        LastName = "Skibel", Age = 20
    });
    personQueue.Enqueue(new Person()
    {
        FirstName = "Sonya",
        LastName = "Borissova", Age = 18
    });

    Console.WriteLine("{0} is first in line", personQueue.Peek().FirstName);
    GetCoffee(personQueue.Dequeue());
    GetCoffee(personQueue.Dequeue());
    GetCoffee(personQueue.Dequeue());

    try
    {
        GetCoffee(personQueue.Dequeue());
    }
    catch( InvalidOperationException ex)
    {
        Console.WriteLine("Error!{0}", ex.Message);
    }
    
    static void GetCoffee(Person p)
    {
        Console.WriteLine("{0} got coffee!", p.FirstName);
    }
}

static void UseSortedSet()
{
    SortedSet<Person> setOfPeople = new SortedSet<Person>(new SortPeopleByAge()) 
    {
        new Person {FirstName = "Misha", LastName = "Borissov", Age = 21},
        new Person {FirstName = "Sasha", LastName = "Skibel", Age = 20},
        new Person {FirstName = "Sonya", LastName = "Borissova", Age = 18 },
        new Person {FirstName = "Misha", LastName = "Kashanin", Age = 21}
    };
    foreach(Person p in setOfPeople)
    {
        Console.WriteLine(p);
    }
    Console.WriteLine();
    setOfPeople.Add(new Person()
    {
        FirstName = "Roma",
        LastName = "Bainazarov", Age = 24
    });
    setOfPeople.Add(new Person()
    {
        FirstName = "Sasha",
        LastName = "Pererva",
        Age = 18
    });
    foreach(Person p in setOfPeople)
    {
        Console.WriteLine(p);
    }
}

