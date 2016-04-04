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
            

            while (index <= text.Length - 1)
            {
                for (int i = 0; i < Words.Length; i++)
                {
                    string word = Words[i].ToUpper();
                    if (text.IndexOf(Words[i], index, StringComparison.InvariantCultureIgnoreCase) != -1)
                    {
                        Regex.Replace(text, Words[i], new string('*', Words[i].Length), Words.IgnoreCase);
                    }
                }
                index++;
            }
            Console.WriteLine(text);
        }
    }
}
