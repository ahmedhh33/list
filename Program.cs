using System.Collections;

namespace Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            list.Add(1);
            Console.WriteLine($"Size of the list is {list.Count}");
            list.Add(2);
            Console.WriteLine($"Size of the list is {list.Count}");
            list.Add(3);
            Console.WriteLine($"Size of the list is {list.Count}");
            list.Remove(0);
            Console.WriteLine($"Size of the list is {list.Count}");
            list.Insert(0,5);
            Console.WriteLine($"Size of the list is {list.Count}");
            Console.WriteLine(list[0]);
            foreach(int i in list)
            {
                Console.WriteLine(i);
            }

            List<Person> personList = new List<Person>();

            personList.Add(new Person(1101, "abc", "Male",23));
            personList.Add(new Person(1102,"def","Femal",29));
            personList.Add (new Person(1102, "ghi","male",45));
            foreach (Person person in personList)
            {
                Console.WriteLine(person.Name);
            }
            personList.Sort();
            //personList.Sort(Person.Id);
            foreach (Person person in personList)
            {
                Console.WriteLine(person.ToString());
            }
            Console.WriteLine("ArrayLIst");
            ArrayList arrayList = new ArrayList();
            arrayList.Add(1);
            arrayList.Add("hello");
            arrayList.Add(new Person(1102, "ghi", "male", 45));
            foreach(var items in arrayList)
            {
                Console.WriteLine(items);
            }
        }
    }
}