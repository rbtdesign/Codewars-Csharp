using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace FindOddInt
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] seq = new[] { 20, 1, -1, 2, -2, 3, 3, 5, 5, 1, 2, 4, 20, 4, -1, -2, 5 };

            //foreach(int n in seq)
            //{
            //    int count = seq.Count(x => x == n);

            //    if (count % 2 != 0)
            //    {
            //        Console.WriteLine(n);
            //        break;
            //    }
            //}


            var test = seq.Distinct().Where(x => seq.Count(c => c == x) % 2 != 0).FirstOrDefault();

            seq.First(x => seq.Count(c => c == x) % 2 != 0);
             

            Console.WriteLine(test);
            Console.ReadLine();

            //5
        }
    }
}
