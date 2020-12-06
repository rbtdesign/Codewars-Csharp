using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiple3_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //If we list all the natural numbers below 10 that are multiples 
            //of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.

            int value = 10;

            var multiple = new List<int>();

            for (int i = 1; i < value; i++)
            {
                if (i % 3 == 0 || i % 5 == 0) {

                    multiple.Add(i);
     
                }
            }

            int sum = multiple.Sum();


            // Extra solution with Linq.
            // var output = Enumerable.Range(0, value).Where(x => x % 3 == 0 || x % 5 == 0).Sum();



            //return sum;

            Console.WriteLine(sum);
            Console.ReadLine();
        }
    }
}
