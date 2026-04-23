using SimpleIndexer;

FunWithPersonCollectionStringlndexer();

static void FunWithIndexes()
{
    PersonCollection myPeople = new PersonCollection();
    myPeople[0] = new Person("Misha", "Borissov", 21);
    myPeople[1] = new Person("Sonya", "Borissova", 20);
    myPeople[2] = new Person("Sasha", "Skibel", 18);
    myPeople[3] = new Person("Misha", "Kashanin", 22);
    myPeople[4] = new Person("Alina", "Bond", 20);

    for (int i = 0; i < myPeople.Count; i++)
    {
        Console.WriteLine("Person number: {0}", i);
        Console.WriteLine("Name: {0} {1}", myPeople[i].FirstName, myPeople[i].LastName);
        Console.WriteLine("Age: {0}", myPeople[i].Age);
        Console.WriteLine();
    }
}

static void UseGenericListOfPeople()
{
    List<Person> myPeople = new List<Person>();
    myPeople.Add(new Person("Misha", "Borissov", 21));
    myPeople.Add(new Person("Sonya", "Borissova", 18));
    myPeople.Add(new Person("Sasha", "Skibel", 20));

    myPeople[0] = new Person("Alina", "Bond", 20);
    for (int i =0; i <= myPeople.Count; i++)
    {
        Console.WriteLine("Person number: {0}", i);
        Console.WriteLine("Name: {0} {1}", myPeople[i].FirstName, myPeople[i].LastName);
        Console.WriteLine("Age: {0}", myPeople[i].Age);
        Console.WriteLine();
    }
}

static void FunWithPersonCollectionStringlndexer()
{
    Console.WriteLine("Fun With Indexeres");

    PersonCollectionStringlndexer myPeopleStrings = new PersonCollectionStringlndexer();

    myPeopleStrings["Homer"] = new Person("Homer", "Simson", 40);
    myPeopleStrings["Misha"] = new Person("Misha", "Borissov", 21);
    myPeopleStrings["Sonya"] = new Person("Sonya", "Borissova", 18);
    myPeopleStrings["Sasha"] = new Person("Sasha", "Skibel", 20);
    Person homer = myPeopleStrings["Homer"];
    Console.WriteLine(homer.ToString());
    Console.ReadLine();
}
