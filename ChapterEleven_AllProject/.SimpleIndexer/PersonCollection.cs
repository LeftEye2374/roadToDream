using System.Collections;

namespace SimpleIndexer
{
    public class PersonCollection : IEnumerable
    {
        private ArrayList arPerson = new ArrayList();

        public Person GetPerson(int pos) => (Person)arPerson[pos];

        public void AddPerson(Person p)
        {
            arPerson.Add(p);
        }

        public void ClearPeople()
        {
            arPerson.Clear();
        }

        public int Count => arPerson.Count;

        IEnumerator IEnumerable.GetEnumerator() => arPerson.GetEnumerator();

        public Person this[int index]
        {
            get => (Person) arPerson[index];
            set => arPerson.Insert(index, value);
        }
    }
}