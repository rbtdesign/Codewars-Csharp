using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplePigLatin
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Pig latin is cool"; //return igPay atinlay siay oolcay

            var output = String.Join(" ",
                            str.Split(' ')
                            .Select(word => String.Concat(word.Substring(1), word[0], "ay"))
                         );

            Console.WriteLine(output);
            Console.ReadLine();

        }
    }
}
