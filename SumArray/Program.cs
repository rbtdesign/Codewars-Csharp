using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumArray
{
    class Program
    {
        static void Main(string[] args)
        {

            double[] array = { 1, 5.2, 4, 0, -1 };

            // var output = array.Aggregate(0, (double sum, double x)  => sum += x );

            var output = array.Sum();

            Console.WriteLine(output);
            Console.ReadLine();

        }
    }
}
