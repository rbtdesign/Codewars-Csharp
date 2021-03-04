using System;
using System.Collections.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digital_Root
{
    class Program
    {

        static void Main(string[] args)
        {
            //16-- > 1 + 6 = 7
            //942-- > 9 + 4 + 2 = 15-- > 1 + 5 = 6
            //132189-- > 1 + 3 + 2 + 1 + 8 + 9 = 24-- > 2 + 4 = 6
            //493193-- > 4 + 9 + 3 + 1 + 9 + 3 = 29-- > 2 + 9 = 11

            int num = 493193;

            //int res = (int)(1 + (num - 1) % 9);

            int res = (int)(num % 9);

            Console.WriteLine(res);
            Console.ReadLine();

            //int[] res = getIntArr(num);

            //int tot = res.Sum(); 

            //while(tot >= 10)
            //{
            //    res = getIntArr(tot);
            //    tot = res.Sum();
            //}


            //return tot;


        }

        //static int[] getIntArr(long num)
        //{
        //    List<int> listDigits = new List<int>();
        //    while (num > 0)
        //    {
        //        listDigits.Add((int)(num % 10));
        //        num = num / 10;
        //    }
        //    listDigits.Reverse();
        //    return listDigits.ToArray();
        //}
    }
}
