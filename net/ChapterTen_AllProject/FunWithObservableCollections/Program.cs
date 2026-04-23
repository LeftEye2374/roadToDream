using System;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using IssuesWithNonGenericCollections;

ObservableCollection<Person> people = new ObservableCollection<Person>()
{
    new Person {FirstName = "Misha", LastName = "Borissov", Age = 21},
    new Person {FirstName = "Misha", LastName= "Kashanin", Age = 21},
    new Person {FirstName = "Sasha", LastName = "Skibel", Age = 20}
};

people.Add(new Person("Sonya", "Borissova", 18)); // ???
people.RemoveAt(0);
Console.ReadLine();

people.CollectionChanged += people_CollectionChanged;

static void people_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
{
    Console.WriteLine("Action for this event: {0}", e.Action);
    if (e.Action == NotifyCollectionChangedAction.Remove)
    {
        Console.WriteLine("Here is the OLD items: ");
        foreach( Person p in e.OldItems)
        {
            Console.WriteLine(p.ToString());
        }
        Console.WriteLine();
    }
    if (e.Action == NotifyCollectionChangedAction.Add)
    {
        Console.WriteLine("Here is the NEW items: ");
        foreach( Person p in e.NewItems)
        {
            Console.WriteLine(p.ToString());
        }
    }
}
