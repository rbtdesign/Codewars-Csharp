using System;
using System.Collections.Generic;

using System.Text;
using System.Threading.Tasks;

namespace ReverseSomeWords
{
    class Program
    {
        static void Main(string[] args)
        {

            string sentence = "Hey wollef sroirraw";

            string[] words = sentence.Split(' ');

            string output = String.Empty;

            for (int i = 0; i < words.Length; i++)
            {
                if(words[i].Length >= 5 )
                {

                    char[] buffer = words[i].ToCharArray();

                    Array.Reverse(buffer);

                    string newString = new String(buffer);
                     
                    output = output + " " + newString;
                
                
                } else
                {
                    output = output + " " + words[i];
                }
            }

            Console.WriteLine(output.Trim());
            Console.ReadLine();




            // Must return : "Hello fellow warrior";



            // Retry with LINQ

        }
    }
}
