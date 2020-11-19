using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapitalizeFirstLetterWord
{
    class Program
    {
        static void Main(string[] args)
        {

            string phrase = "How can mirrors be real if our eyes aren't real";

            string[] strArr = phrase.Split(' ');

            string output = "";

            foreach (string word in strArr)
            {
                output = output + char.ToUpper(word[0]) + word.Substring(1) + " ";

            }

            output.Trim();



            Console.WriteLine(output);
            Console.ReadLine();


            // Better way to do it by using TitleCase method


        }
    }
}
