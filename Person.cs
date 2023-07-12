using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists
{
    internal class Person : IComparable<Person>
    {
        public int Id{ get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public int Age { get; set; }

        public Person(int id,string name, string Title,int age ) 
        { 
            Id = id;
            Name = name;
            this.Title = Title;
            Age = age;
        }

        public int CompareTo(Person? other)
        {
           if (other == null) return 1;
           if (other.Age == this.Age) return 0;
           if(other.Age>this.Age) return -1;
            return 1;
        }
    }
}
