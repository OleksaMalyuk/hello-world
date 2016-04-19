using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ForbiddenWords
{
    class ForbiddenWords
    {
        static void Main()
        {
            string[] forbiddenWords = { "microsoft", "today", "dynamic", "php" };
            string text = "Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.";
            int index = 0;

            while (index <= text.Length - 1)
            {
                for (int i = 0; i < forbiddenWords.Length; i++)
                {
                    string word = forbiddenWords[i].ToUpper();
                    if (text.IndexOf(forbiddenWords[i], index, StringComparison.InvariantCultureIgnoreCase) != -1)
                    {
                        text = Regex.Replace(text, forbiddenWords[i], new string('*', forbiddenWords[i].Length), RegexOptions.IgnoreCase);
                    }
                }
                index++;
            }
            Console.WriteLine(text);
            Console.ReadLine();
        }
    }
}