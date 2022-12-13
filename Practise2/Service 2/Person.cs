using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise2.Service_2
{
    public class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public int Salary { get; set; }
        public DateTime BithDay { get; set; }

        public Person [] Arr;

        
        
        public Person(string name, string surname, int age, int salary)
        {
            Name = name;
            Surname = surname;
            Age = age;
            Salary = salary;

            Array.Resize(ref Arr, Arr.Length + 1);
        }


        #region Operator overloading -> allows users to compare object
        public static bool operator >=(Person p1, Person p2)
        {
            return p1.Age >= p2.Age;
        }
        public static bool operator <=(Person p1, Person p2)
        {
            return p1.Age <= p2.Age;
        }
        #endregion


        

    }
}
