using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise2.Service_2
{
    internal class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public int Salary { get; set; }
        public Person(string name, string surname, int age, int salary)
        {
            Name = name;
            Surname = surname;
            Age = age;
            Salary = salary;
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
