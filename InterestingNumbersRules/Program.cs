using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace InterestingNumbersRules
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 67890;
            List<int> awesomePhrases = new List<int>() { 1337, 256 };

            
            bool res1 = test(number, awesomePhrases);
            bool res2 = test(number + 1, awesomePhrases);
            bool res3 = test(number + 2, awesomePhrases);

            if (res1) {
                Console.WriteLine(2);
            } else if (res2 || res3)
            {
                Console.WriteLine(1);
            } else
            {
                Console.WriteLine(0);
            }

            Console.ReadLine();
        }

        private static bool test(int x, List<int> awesomePhrases)
        {

            string numStr = x.ToString();

            // A number is only interesting if it is greater than 99!

            if (x <= 99)
                return false;

            // Any digit followed by all zeros: 100, 90000

            bool res1 = Regex.IsMatch(numStr, @"^[1-9][0]+$");
            if (res1)
                return res1;


            // Every digit is the same number: 1111

            bool res2 = Regex.IsMatch(numStr, @"^([0-9])\1*$");
            if (res2)
                return res2;

            // The digits are sequential, incementing†: 1234

            bool res3 = false;

            for (int i = 0; i < numStr.Length - 1; i++)
            {
                if (numStr[i] + 1 == numStr[i + 1])
                {
                    res3 = true;
                }
                else if (numStr[i] == '9' && numStr[i + 1] == '0') // special addons for special case after 9 is 0 as in 10.  67890 should return true;
                {
                    res3 = true;

                }
                else
                {
                    res3 = false;
                    break;
                }

            }
            if (res3)
                return res3;

            // The digits are sequential, decrementing‡: 4321

            bool res4 = false;

            for (int i = 0; i < numStr.Length - 1; i++)
            {
                if (numStr[i] - 1 == numStr[i + 1])
                {
                    res4 = true;
                } 
                else
                {
                    res4 = false;
                    break;
                }

            }

            if (res4)
                return res4;

            // The digits are a palindrome: 1221 or 73837

            char[] charArr = numStr.ToCharArray();
            Array.Reverse(charArr);
            string numReverse = new string(charArr);

            bool res5 = numReverse == numStr;

            if (res5)
                return res5;


            // The digits match one of the values in the awesomePhrases array

            bool res6 = false;

            foreach (int num in awesomePhrases)
            {
                if (x == num)
                {
                    res6 = true;
                    break;
                }
            }

            if (res6)
                return res6;

            return false;
        }
    }
}



// Extra solution with LINQ

//using System;
//using System.Collections.Generic;
//using System.Linq;

//public static class Kata
//{
//    public static int IsInteresting(int number, List<int> awesomePhrases)
//    {
//        return Enumerable.Range(number, 3)
//          .Where(x => Interesting(x, awesomePhrases))
//          .Select(x => (number - x + 4) / 2)
//          .FirstOrDefault();
//    }

//    private static bool Interesting(int num, List<int> awesome)
//    {
//        if (num < 100) return false;
//        var s = num.ToString();
//        return awesome.Contains(num)
//          || s.Skip(1).All(c => c == '0')
//          || s.Skip(1).All(c => c == s[0])
//          || "1234567890".Contains(s)
//          || "9876543210".Contains(s)
//          || s.SequenceEqual(s.Reverse());
//    }
//}