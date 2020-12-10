using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildTower
{
    class Program
    {
        static void Main(string[] args)
        {
            int nFloors = 3;

            //return [
            //    "  *  ",
            //    " *** ",
            //    "*****"
            //    ];

            var n = nFloors * 2 - 1;

            var output = new List<string>();

            for (int i = 1; i <= nFloors; i++) //nFloors = 3
            {
                var y = i * 2 - 1;

                var str = new string('*', y);

                int spaces = n - y;
                int padLeft = spaces / 2 + y;


                //output.Add(str.PadLeft(padding).PadRight(padding));

                Console.WriteLine(str.PadLeft(padLeft).PadRight(n));
            }


            //return output.ToArray();


            //Console.WriteLine(charArr);
            Console.ReadLine();




        }



    }
}


//Extra Solution with Linq

//    
//return Enumerable.Range(0, nFloors)
//    .Select(x => new string('*', x * 2 + 1)
//    .PadLeft(nFloors + x)
//    .PadRight(nFloors * 2 - 1))
//    .ToArray();