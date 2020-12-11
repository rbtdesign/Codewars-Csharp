using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anagrams
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = "racer";
            List<string> words = new List<string>{"crazer", "carer", "racar", "caers", "racer"};

            List<string> output = new List<string>();

            foreach (string w in words)
            {

                if (w.Length != word.Length)
                    continue;

                var test = w.OrderBy(x => x);
                var test2 = word.OrderBy(x => x);

                bool equal = test.SequenceEqual(test2);

                if (equal)
                    output.Add(w);

            }

            Console.WriteLine(output);






            Console.ReadLine();

        }
    }
}
