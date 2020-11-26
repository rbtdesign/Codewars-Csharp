using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstNonRepeatingLetter
{
    class Program
    {
        static void Main(string[] args)
        {

			string s = "sTretss";


			List<char> word = new List<char>(s.ToLower());

			IEnumerable<char> distinctChar = word.Distinct();

			Dictionary<char, int> countLetter = new Dictionary<char, int>();

			foreach (char letter in distinctChar)
			{
				int count = word.Count(x => x == letter);

				countLetter.Add(letter, count);
			}

			string res = String.Empty;

			foreach (KeyValuePair<char, int> nbLetter in countLetter)
			{

				if (nbLetter.Value == 1)
				{

					res = nbLetter.Key.ToString();
					break;

				}
				else
				{
					res = String.Empty;
				}
			}

			var i = s.ToLower().IndexOf(res);

			if (res == String.Empty)
			{
				Console.WriteLine("");
			}
			else
			{
				Console.WriteLine(s[i].ToString());
			};

			Console.ReadLine();

			// Solution using linq : 

			/*
			return s.GroupBy(char.ToLower)
				.Where(gr => gr.Count() == 1)
				.Select(x => x.First().ToString())
				.DefaultIfEmpty("") 
				.First();
			*/

		}
	}
}
