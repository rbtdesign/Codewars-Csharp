using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayDiff
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 2, 2, 3 };
            int[] b = { 2 };


            //// Working solution 

            List<int> num = new List<int>();

            for (int i = 0; i < a.Length; i++)
            {
                if (!b.Contains(a[i]))
                {
                    num.Add(a[i]);
                }
            }

            int[] output = num.ToArray();

            return output;


            //// Solution with Linq
            // return a.Where(x => !b.Contains(x)).ToArray();




        }
    }
}
