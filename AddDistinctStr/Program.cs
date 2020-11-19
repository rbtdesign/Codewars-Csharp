using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddDistinctStr
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "xyaabbbccccdefww";
            string s2 = "xxxxyyyyabklmopq";

            string concat = s1 + s2;

            List<char> distinctChar = concat.Distinct().ToList();

            distinctChar.Sort();


            string output = string.Join("", distinctChar);

            

            Console.WriteLine(output);
            Console.ReadLine();


            // Solution without passing by a list and sort is to use OrderBy from Linq with Distinct
            // return string.Concat((s1 + s2).Distinct().OrderBy(x => x));


        }
    }
}
