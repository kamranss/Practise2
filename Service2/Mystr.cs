using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service2
{
    internal class Mystr
    {
        public string[] Arr;

        public Mystr()
        {
            Arr = new string[0];
        }

        public void Add(string element)
        {
            Array.Resize(ref Arr,Arr.Length+1);
            Arr[Arr.Length - 1] = element;
        }

        public void ShowArr()
        {
            for (int i = 0; i < Arr.Length-1; i++)
            {
                Console.WriteLine(Arr[i]);
            }
        }
    }
}
