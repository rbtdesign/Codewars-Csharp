using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Accumul
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "ZpglnRxqenU";

            string output = string.Empty;

            TextInfo ti = CultureInfo.CurrentCulture.TextInfo;

            for (int i = 0; i < s.Length; i++)
            {
                string bufferStr = new String(s[i], i + 1);
                
                output = output + "-" + ti.ToTitleCase(bufferStr.ToLower()); // To lower because otherwise we get back only upercase when it's uppercase already and we just need first letter
            }

            Console.WriteLine(output.Trim('-'));
            Console.ReadLine();

            // Using linq
            // return string.Join("-",s.Select((x,i)=>char.ToUpper(x)+new string(char.ToLower(x),i)));
        }
    }
}
