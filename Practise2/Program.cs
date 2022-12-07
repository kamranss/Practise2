// See https://aka.ms/new-console-template for more information

#region Extension for Class object

//using Practise2;

//User user1 = new User();

//user1.Name = "Kamran";

//user1.PrintName();
#endregion

#region Extension for For any string
//user1.Name.Printname2();

//string surname= "Suleyman";

//surname.Printname2();
#endregion


#region Print ENUM values
//foreach (var item in Enum.GetNames(typeof(Itutype)))
//{
//    Console.WriteLine(item);
//}

//Console.WriteLine("-------------------");

//for (int i = 0; i < Enum.GetNames(typeof(Itutype)).Length; i++)
//{
//    Console.WriteLine(Enum.GetNames(typeof(Itutype))[i]);
//}
#endregion

#region Resize Array and cw

using Practise2;
using Practise2.Service_2;

Mystr str1 = new Mystr();

#endregion

#region Celcius to Kelvin to Fahrenheit
//fahrenheit = (celsius * 9) / 5 + 32;
//Console.WriteLine("Fahrenheit: " + fahrenheit);
#endregion

#region Operator overloading compare two class according to their filed

Person p1 = new Person("Kamran", "Suleyman", 45, 4500);
Person p2 = new Person("Kamil", "huseyn", 56, 2300);

p1.BithDay = DateTime.Now.AddDays(-15);
Console.WriteLine(p1.BithDay);

//Arr[Arr.Length - 1] = Person.p1;

Console.WriteLine(p1 >= p2);
#endregion