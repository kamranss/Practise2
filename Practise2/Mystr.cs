using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise2
{
    internal class Mystr
    {

        public string Name { get; set; }
        public string[] Arr;

        public Mystr()
        {
            Arr = new string[0];
        }

        #region Resize Array method
        public void Add(string element)
        {
            Array.Resize(ref Arr, Arr.Length + 1);
            Arr[Arr.Length - 1] = element;
         
        }
        #endregion

        #region Print ARR elemnts
        public void ShowArr()
        {
            for (int i = 0; i < Arr.Length - 1; i++)
            {
                Console.WriteLine(Arr[i]);
            }
            foreach (var item in Arr)
            {
                Console.WriteLine(item);
            }
        }
        #endregion

        public int CompareTo(object obj)
        {
            return ((Mystr)obj).Name.CompareTo(this.Name);
        }
    }
}
