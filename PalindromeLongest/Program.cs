using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeLongest
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "I love racecars";


            // return "racecar"

            //if (String.IsNullOrEmpty(str))
            //    return 0;

            var buffer = string.Join("", str
                            .Reverse()
                            );


            var current_word = "";
            var longest = 0;

            for (int i = 0; i < buffer.Length; i++)
            {

                current_word = current_word + buffer[i];

                if (str.Contains(current_word) && longest < current_word.Length)
                {
                    longest++;
                }
                else if (!str.Contains(current_word))
                {
                    current_word = buffer[i].ToString();
                }



            }



            Console.WriteLine(longest);
            Console.ReadLine();


        }
    }
}
