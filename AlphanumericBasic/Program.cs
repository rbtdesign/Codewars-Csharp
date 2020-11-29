using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AlphanumericBasic
{
    class Program
    {


        static void Main(string[] args)
        {
            /*
            The string has the following conditions to be alphanumeric:
            At least one character("" is not valid)
            Allowed characters are uppercase / lowercase latin letters and digits from 0 to 9
            No whitespaces / underscore
            */

            string str = "PassW0rd"; // should return true

            bool res = Regex.IsMatch(str, @"^[a-zA-Z0-9]+$");

            Console.WriteLine(res);
            Console.ReadLine();



            // Solution using Linq
            // return str.All(c => Char.IsLetterOrDigit(c)) && !string.IsNullOrEmpty(str);


          
            // Regex Refs 

            //Only letters: 
            //        Regex.IsMatch(input, @"^[a-zA-Z]+$");

            //Only letters and numbers:
            //        Regex.IsMatch(input, @"^[a-zA-Z0-9]+$");

            //Only letters, numbers and underscore:
            //        Regex.IsMatch(input, @"^[a-zA-Z0-9_]+$");





        }
    }
}
