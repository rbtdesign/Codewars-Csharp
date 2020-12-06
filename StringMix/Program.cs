using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringMix
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = " In many languages";
            string s2 = " theres a pair of functions";
            // "=:aaaaaa/2:eeeee/=:fffff/1:tt/2:rr/=:hh"

            Dictionary<char, int> dict1;
           

            dict1 = s1
                .Trim()
                .ToLower()
                .Replace(" ", "")
                .GroupBy(letter => letter)
                .ToDictionary(x => x.Key, x => x.Count());

            var output = new List<string>();

            s2 = s2.ToLower().Replace(" ", "");

            foreach (var item in dict1)
            {
                if (s2.Contains(item.Key))
                {
                    var s2count = s2.Count(x => x == item.Key);

                    if( s2count == 1 && item.Value == 1)
                    {
                        continue;
                    } else 

                    if(s2count < item.Value)
                    {
                        output.Add( "1:" + new String(item.Key, item.Value));
                    } else

                    if ( s2count > item.Value)
                    {
                        output.Add("2:" + new String(item.Key, s2count)) ;
                    } else

                    if (s2count == item.Value)
                    {
                        output.Add("=:" + new String(item.Key, item.Value)); 
                    }
                } else if (item.Value > 1)
                {
                    output.Add("1:" + new String(item.Key, item.Value));
                }   

            }
            
            foreach( char x in s2.Distinct())
            {

                var s2count = s2.Count(l => l == x);

                if (!dict1.Keys.Contains(x) && s2count > 1)
                {
                    output.Add("2:" + new String(x, s2count));
                }
            }


            var test = output.OrderByDescending(x => x.Length).ThenBy(x => (int)x[0] ).ThenBy(x => x);






            var final = "";

            foreach(var item in test)
            {
                final += item + "/";
            }

            //return final.Trim('/');

            Console.WriteLine(final);

            Console.WriteLine("end");
            Console.ReadLine();

            // Refactor
        }
    }
}
