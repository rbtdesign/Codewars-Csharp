using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreedIsGood
{
    class Program
    {

            //Throw Score
            //---------------------------
            //5 1 3 4 1   250:  50(for the 5) +2 * 100(for the 1s)
            //1 1 1 3 1   1100: 1000(for three 1s) +100(for the other 1)
            //2 4 4 5 4   450:  400(for three 4s) +50(for the 5)

         //Three 1's => 1000 points
         //Three 6's =>  600 points
         //Three 5's =>  500 points
         //Three 4's =>  400 points
         //Three 3's =>  300 points
         //Three 2's =>  200 points
         //One   1   =>  100 points
         //One   5   =>   50 point
        static void Main(string[] args)
        {
            int[] dice = { 2, 4, 4, 4, 3 }; // 450

            int[] dist = dice.Distinct().ToArray();

            int output = 0;

            foreach (int num in dist)
            {
                var count = dice.Count(i => i == num);

                if (count > 2)
                {
                    output += SubScoreTriplet(num);
                    output += (count - 3) * SubScore(num);

                }
                else
                {
                    output += SubScore(num) * count;
                }

            }


            Console.WriteLine(output);

            Console.ReadLine();




        }

        private static int SubScore(int num)
        {
            switch (num)
            {
                case 1:
                    return 100;
                case 5:
                    return 50;
                default:
                    return 0;
            }
        }

        private static int SubScoreTriplet(int num)
        {
            switch (num)
            {
                case 1:
                    return 1000;
                case 6:
                    return 600;
                case 5:
                    return 500;
                case 4:
                    return 400;
                case 3:
                    return 300;
                case 2:
                    return 200;
                default:
                    return 0;
            }

        }

    }
}


// Extra solution 1
//return Enumerable
//            .Range(1, 6)
//            .Sum(x => dice.Count(v => v == x) / 3 * (x == 1 ? 1000 : x * 100) + dice.Count(v => v == x) % 3 * (x == 1 ? 100 : (x == 5 ? 50 : 0)));





//Extra Solution 2


//public static class Kata
//{
//    public static int Score(int[] dice)
//    {
//        return dice
//          .GroupBy(d => d)
//          .Select(g => Points(g.Key, g.Count()))
//          .Sum();
//    }

//    private static int Points(int die, int count)
//    {
//        switch (die)
//        {
//            case 1:
//                return (count / 3) * 1000 + (count % 3) * 100;
//            case 5:
//                return (count / 3) * 500 + (count % 3) * 50;
//            default:
//                return (count / 3) * die * 100;
//        }
//    }
//}