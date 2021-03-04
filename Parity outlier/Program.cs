using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parity_outlier
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] integers = new int[] {2, 4, 0, 100, 4, 11, 2602, 36};

            var res = integers.GroupBy(x => x % 2).Where(groupe => groupe.Count() == 1).FirstOrDefault().First();

            Console.WriteLine(res);
            Console.ReadLine();
        
        }
    }
}
