using SimpleIndexer;

Console.WriteLine("Fun With Indexes");

PersonCollection myPeople = new PersonCollection();
myPeople[0] = new Person("Misha", "Borissov", 21);
myPeople[1] = new Person("Sonya", "Borissova", 20);
myPeople[2] =  new Person("Sasha", "Skibel", 18);
myPeople[3] = new Person("Misha", "Kashanin", 22);
myPeople[4] = new Person("Alina","Bond",20);

for (int i = 0; i < myPeople.Count; i++)
{
    Console.WriteLine("Person number: {0}", i);
    Console.WriteLine("Name: {0} {1}", myPeople[i].FirstName, myPeople[i].LastName );
    Console.WriteLine("Age: {0}", myPeople[i].Age);
    Console.WriteLine();
}