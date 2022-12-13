using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class Generics<T>
    {
        public string[] arr;

        public Generics()
        {
            arr = new string[0];
        }
        public void Add<T> (T num)
        {
            Array.Resize(ref arr, arr.Length + 1);
            arr[arr.Length -1] = num;
        }
    }
}
