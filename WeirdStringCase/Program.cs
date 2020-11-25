using System;
using System.Collections.Generic;
using System.Linq;

namespace WeirdStringCase
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "Weird string case";

            string[] arr = s.Split(' ');

            List<String> listOutput = new List<string>();

            foreach (string word in arr)
            {
                string output = String.Empty;


                for (int i = 0; i < word.Length; i++)
                {
                    if (i % 2 == 0)
                    {
                        output += word[i].ToString().ToUpper();
                    }
                    else
                    {
                        output += word[i].ToString().ToLower();
                    }

                }
                listOutput.Add(output);
            }

            string res = String.Join(" ", listOutput.ToArray());







            Console.WriteLine(res);
            Console.ReadLine();




            // Extra Solution using Linq

            //return string.Join(" ",
            //  s.Split(' ')
            //  .Select(w => string.Concat(
            //    w.Select((ch, i) => i % 2 == 0 ? char.ToUpper(ch) : char.ToLower(ch)
            //  ))));


        }
    }
}
