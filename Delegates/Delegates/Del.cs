using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates.Delegates
{
    internal class Del
    {
        public delegate bool Check(int m);

        public bool IsEven(int m)
        {
            return m % 2 == 0;
        }

        public static int Sum(Check function, params int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (function(arr[i]))
                {
                    sum += arr[i];
                }
            }
            return sum;
        } 


    }
}
