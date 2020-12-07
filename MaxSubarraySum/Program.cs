using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxSubarraySum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { -2, 1, -3, 4, -1, 2, 1, -5, 4 };
            //int[] arr = { 1,1,-2,3,3,-1 };

            // should be 6: [4, -1, 2, 1]

            //var output = arr.Aggregate( 0 , (res, item) => res + item, result => result / arr.Count() );
            //var output = arr.Aggregate( 0 , (res, item) => res + item);

            //var output = arr.Max(x => arr.Aggregate(0, (res, item) => res + item), result => result > );

            //var output = arr.SelectMany(x => arr.Aggregate(0, (res, item) => res + item)).Max();


            //var output = Enumerable.Range(arr);


            //var output = arr.SelectMany(x => x + 10);


            //foreach (int x in arr)
            //{


            //    if (currentSum == 0)
            //    {
            //        currentSum = x; 
            //    } else
            //    {
            //        currentSum += x;
            //    }

            //    if(currentSum > bestSum)
            //    {
            //        bestSum = currentSum;
            //    } else if (currentSum < bestSum)
            //    {
            //        currentSum = 0;
            //    }


            //}


            // max_so_far = max_ending_here = 0

            var maxSoFar = 0;
            var maxEndingHere = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                maxEndingHere = maxEndingHere + arr[i];

                if (maxSoFar < maxEndingHere)
                {
                    maxSoFar = maxEndingHere;
                } 

                if(maxEndingHere < 0)
                {
                    maxEndingHere = 0;
                }

            }


            Console.WriteLine(maxSoFar);
            Console.ReadLine();
        }
    }
}
