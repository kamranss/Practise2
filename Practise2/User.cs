using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Practise2


{
    public class User
    {

        public string Name { get; set; }

    }

    public static class Extantion
    {
        #region Extension for Class itself
        public static void PrintName( this User obj)
        {
            Console.WriteLine(obj.Name);
        }
        #endregion

        #region Extension for any string
        public static void Printname2(this string obj2)
        {
            Console.WriteLine(obj2);
        }
        #endregion
    }
}
