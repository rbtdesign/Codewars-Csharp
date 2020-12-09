using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoveZerosEnd
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 0, 1, 0, 1, 0, 3, 0, 1 };
            // return int[] {1, 2, 1, 1, 3, 1, 0, 0, 0, 0}


            // First solution 

                //List<int> result = new List<int>();
                //var count = 0;

                //for (int i = 0; i < arr.Length; i++)
                //{
                //    if (arr[i] != 0)
                //    {
                //        result.Add(arr[i]);
                //    }
                //    else
                //    {
                //        count++;
                //    }
                //}

                //while (count > 0)
                //{
                //    result.Add(0);
                //    count--;
                //}

                //Console.WriteLine(result.ToArray());




            // Solution with Linq

                //var output = arr.Where(x => x != 0).ToList();

                //output.AddRange(Enumerable.Repeat(0, arr.Count(x => x == 0)));

                //return output.ToArray();


            // Extra for ref : 

                //.AddRange(Enumerable.Repeat(42, 50));
                //var output = arr.Count(x => x == 0);  


            // Best solution with Linq

                //return arr.OrderBy(x => x == 0).ToArray();


            var extra = arr.OrderBy(x => x == 0).ToArray();

            Console.WriteLine(extra);
            Console.ReadLine();



        }
    }
}
