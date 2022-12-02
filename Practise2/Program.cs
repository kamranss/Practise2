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

using Practise2;

#region Print ENUM values
foreach (var item in Enum.GetNames(typeof(Itutype)))
{
    Console.WriteLine(item);
}

Console.WriteLine("-------------------");

for (int i = 0; i < Enum.GetNames(typeof(Itutype)).Length; i++)
{
    Console.WriteLine(Enum.GetNames(typeof(Itutype))[i]);
}
#endregion